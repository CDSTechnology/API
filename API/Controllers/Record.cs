using Microsoft.AspNetCore.Mvc;
using Application;

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
    }
}
