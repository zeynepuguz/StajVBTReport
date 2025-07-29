using Microsoft.AspNetCore.Mvc;
using Core.Models;
using Service.ReportService;

namespace StajVbtReport.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpPost("GetStajReport")]
        public List<ReportResponseModel> GetStajReport([FromBody] ReportRequestModel requestModel)
        {
            var response = new List<ReportResponseModel>();

            response = _reportService.GetStajReport(requestModel);


            return response;
        }

        [HttpGet("GetStajReportTest")]
        public List<ReportResponseModel> GetStajReportTest()
        {
            var request = new ReportRequestModel
            {
                startDate = DateTime.Now
            };

            return _reportService.GetStajReport(request);
        }

        [HttpPost("GetStudentReport")]
        public List<StudentReportModel> GetStudentReport([FromBody] StudentReportSearchModel searchModel)
        {
            var response = new List<StudentReportModel>();
            response = _reportService.GetStudentReport(searchModel);
            return response;
        }
        [HttpGet("GetStudentReportTest")]
        public List<StudentReportModel> GetStudentReportTest([FromQuery] StudentReportSearchModel searchModel)
        {
            var response = _reportService.GetStudentReport(searchModel);
            return response;
        }



    }
}
