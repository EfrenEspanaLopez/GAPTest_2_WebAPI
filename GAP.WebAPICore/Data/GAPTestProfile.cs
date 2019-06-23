using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GAP.WebAPICore.Models;

namespace GAP.WebAPICore.Data
{
    public class GAPTestProfile : Profile
    {
        public GAPTestProfile()
        {
            this.CreateMap<Grades, GradesModel>();
        }
    }
}
