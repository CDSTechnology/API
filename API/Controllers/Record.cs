using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Application;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api/records")]
    public class Record : ControllerBase
    {
        private readonly IRecordApplicationService _recordApplicationService;
        public Record(IRecordApplicationService recordApplicationService)
        {
            _recordApplicationService = recordApplicationService;
        }

        [HttpPost]
        public string GetAllMusicalGenre(Filter filter)
        {
            var response = _recordApplicationService.FilterGenre(filter);
            return JsonConvert.SerializeObject(response);
        }
            
    }
}
