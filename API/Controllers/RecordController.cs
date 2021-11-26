using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Application;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api/records")]
    public class RecordController : ControllerBase
    {
        private readonly IMusicalGenreApplicationService _musicalGenreApplicationService;
        public RecordController(IMusicalGenreApplicationService musicalGenreApplicationService)
        {
            _musicalGenreApplicationService = musicalGenreApplicationService;
        }

        [HttpPost]
        [Route("musical")]
        public string PostMusicalGenre(FilterApplication filterApplication)
        {
            var response = _musicalGenreApplicationService.FilterGenre(filterApplication);
            return JsonConvert.SerializeObject(response);
        }
            
    }
}
