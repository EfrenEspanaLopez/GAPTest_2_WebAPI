using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GAP.WebAPICore.Data;
using GAP.WebAPICore.Extensions;
using GAP.WebAPICore.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GAP.WebAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradesController : ControllerBase
    {
        private readonly IGAPTestRepository _repository;
        private readonly IMapper _mapper;
        public GradesController(IGAPTestRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        [EnableQuery()]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _repository.GetAllGradesAsync(true,true);
                var data = _mapper.Map<GradesModel[]>(results);
                //var dt = data.ToPivotTable(item => item.SubjectName, item => item.StudentName, items => items.Any() ? items.First().Grade : null);

                return Ok(data);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }

        }
    }
}