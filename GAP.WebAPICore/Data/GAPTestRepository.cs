using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GAP.WebAPICore.Data
{
    public class GAPTestRepository : IGAPTestRepository
    {
        private readonly WebAPIContext _context;

        public GAPTestRepository(WebAPIContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }       

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Grades[]> GetAllGradesAsync(bool includeStudent = false, bool includeSubject = false)
        {
            IQueryable<Grades> query = _context.Grades;

            if (includeStudent)
            {
                query = query
                  .Include(c => c.Student);
            }

            if (includeSubject)
            {
                query = query
                  .Include(c => c.Subject);
            }

            return await query.ToArrayAsync();
        }
    }
}
