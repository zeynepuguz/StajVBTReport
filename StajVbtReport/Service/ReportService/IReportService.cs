using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ReportService
{
    public interface IReportService
    {
        List<ReportResponseModel> GetStajReport(ReportRequestModel requestModel);

        List<StudentReportModel> GetStudentReport(StudentReportSearchModel searchModel);
    }
}
