using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GAP.WebAPICore.Data
{
    public interface IGAPTestRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        // Grades
        Task<Grades[]> GetAllGradesAsync(bool includeStudent = false, bool includeSubject = false);
        //Task<Grades[]> GetAllGradesByStudentAsync(string StudentName, bool includeStudent = false, bool includeSubject = false);
        //Task<Grades[]> GetAllGradesBySubjectAsync(string Subject, bool includeStudent = false, bool includeSubject = false);


    }
}