using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WP_Middleware.ViewModel;
using WP_Middleware_3._1.ViewModel;

namespace WP_Middleware_3._1.Api
{
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly ILogger<ReportController> _logger;
        public ReportController(ILogger<ReportController> logger)
        {
            _logger = logger;
        }

        [Route("/api/Employees")]
        public IActionResult Employees()
        {
            var url = "https://app.workpuls.com/api/v1/employee";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Accept = "application/json";
            httpRequest.Headers["Authorization"] = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IndsZ2ZraW14cTRnYjRiayIsImFjY291bnRJZCI6InducHNucGh4anh3dzV1dCIsIm9yZ2FuaXphdGlvbklkIjoid29mMnFhXzF3Y3hvNjZhIiwidHlwZSI6InVzZXIiLCJ1c2VyVHlwZSI6ImFwaSIsImlhdCI6MTY0NDkxMzQxMywiZXhwIjozMTcxODkzNTU4MTMsImF1ZCI6WyJQUk9EIl0sImlzcyI6IlBST0QifQ.B-M7rL4Ou7AFMeRiYgwrXBKhFw8m6y5fR_U6xbux99E";
            var result = "";
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return Ok(result);

        }

        [Route("/api/Projects")]
        public IActionResult Projects()
        {
            var url = "https://app.workpuls.com/api/v1/project";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Accept = "application/json";
            httpRequest.Headers["Authorization"] = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IndsZ2ZraW14cTRnYjRiayIsImFjY291bnRJZCI6InducHNucGh4anh3dzV1dCIsIm9yZ2FuaXphdGlvbklkIjoid29mMnFhXzF3Y3hvNjZhIiwidHlwZSI6InVzZXIiLCJ1c2VyVHlwZSI6ImFwaSIsImlhdCI6MTY0NDkxMzQxMywiZXhwIjozMTcxODkzNTU4MTMsImF1ZCI6WyJQUk9EIl0sImlzcyI6IlBST0QifQ.B-M7rL4Ou7AFMeRiYgwrXBKhFw8m6y5fR_U6xbux99E";
            var result = "";
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return Ok(result);

        }

        [Route("/api/Tasks")]
        public IActionResult Tasks()
        {
            var url = "https://app.workpuls.com/api/v1/task";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Accept = "application/json";
            httpRequest.Headers["Authorization"] = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IndsZ2ZraW14cTRnYjRiayIsImFjY291bnRJZCI6InducHNucGh4anh3dzV1dCIsIm9yZ2FuaXphdGlvbklkIjoid29mMnFhXzF3Y3hvNjZhIiwidHlwZSI6InVzZXIiLCJ1c2VyVHlwZSI6ImFwaSIsImlhdCI6MTY0NDkxMzQxMywiZXhwIjozMTcxODkzNTU4MTMsImF1ZCI6WyJQUk9EIl0sImlzcyI6IlBST0QifQ.B-M7rL4Ou7AFMeRiYgwrXBKhFw8m6y5fR_U6xbux99E";
            var result = "";
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return Ok(result);

        }

        
        [Route("/api/GetReport")]
        [HttpPost]
        public IActionResult GetReport(ReportGet reportGet)
        {
            /*try
            {*/
            var datesplt = reportGet.Date;
            string[] words = datesplt.Split('-');
            string dateFrom = words[0].TrimStart();
            string dateTo = words[1].TrimStart();
            DateTime fDate = Convert.ToDateTime(dateFrom);
            DateTime TDate = Convert.ToDateTime(dateTo);
            long longFdateTime = new DateTimeOffset(fDate).ToUnixTimeMilliseconds();
            long longTdateTime = new DateTimeOffset(TDate).ToUnixTimeMilliseconds();
            long tdate = longTdateTime + 84924000;
            string projectId = reportGet.Project;
            string employeeId = reportGet.Employee;
            string taskId = reportGet.Task;

            var result3 = "";

                EmployeeViewModel employee = new EmployeeViewModel();
                if (reportGet.Employee != "")
                {
                    var url2 = "https://app.workpuls.com/api/v1/employee/" + reportGet.Employee;
                    var httpRequest2 = (HttpWebRequest)WebRequest.Create(url2);
                    httpRequest2.Accept = "application/json";
                    httpRequest2.Headers["Authorization"] = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IndsZ2ZraW14cTRnYjRiayIsImFjY291bnRJZCI6InducHNucGh4anh3dzV1dCIsIm9yZ2FuaXphdGlvbklkIjoid29mMnFhXzF3Y3hvNjZhIiwidHlwZSI6InVzZXIiLCJ1c2VyVHlwZSI6ImFwaSIsImlhdCI6MTY0NDkxMzQxMywiZXhwIjozMTcxODkzNTU4MTMsImF1ZCI6WyJQUk9EIl0sImlzcyI6IlBST0QifQ.B-M7rL4Ou7AFMeRiYgwrXBKhFw8m6y5fR_U6xbux99E";

                    var httpResponse2 = (HttpWebResponse)httpRequest2.GetResponse();
                    using (var streamReader = new StreamReader(httpResponse2.GetResponseStream()))
                    {
                        result3 = streamReader.ReadToEnd();
                    }
                    employee = JsonConvert.DeserializeObject<EmployeeViewModel>(result3);
                }


                Resport resport = new Resport();
                List<ReportViewModel> reportViews = new List<ReportViewModel>();

                var url = "https://app.workpuls.com/api/v1/analytics/window?start=" + longFdateTime + "&end=" + tdate + "&employeeId=" + employeeId + "&projectId=" + projectId + "&taskId=" + taskId;
                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Accept = "application/json";
                httpRequest.Headers["Authorization"] = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IndsZ2ZraW14cTRnYjRiayIsImFjY291bnRJZCI6InducHNucGh4anh3dzV1dCIsIm9yZ2FuaXphdGlvbklkIjoid29mMnFhXzF3Y3hvNjZhIiwidHlwZSI6InVzZXIiLCJ1c2VyVHlwZSI6ImFwaSIsImlhdCI6MTY0NDkxMzQxMywiZXhwIjozMTcxODkzNTU4MTMsImF1ZCI6WyJQUk9EIl0sImlzcyI6IlBST0QifQ.B-M7rL4Ou7AFMeRiYgwrXBKhFw8m6y5fR_U6xbux99E";
                var result1 = "";
                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result1 = streamReader.ReadToEnd();
                }

                List<EmployeeDate> getData = JsonConvert.DeserializeObject<List<EmployeeDate>>(result1);
                int count = 0;
                foreach (var item in getData)
                {

                    ReportViewModel reportView = new ReportViewModel();
                    var result2 = "";
                 /*   try
                    {*/
                        count++;
                        var url1 = "https://app.workpuls.com/api/v1/task/" + item.taskId;
                        var httpRequest1 = (HttpWebRequest)WebRequest.Create(url1);
                        httpRequest1.Accept = "application/json";
                        httpRequest1.Headers["Authorization"] = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IndsZ2ZraW14cTRnYjRiayIsImFjY291bnRJZCI6InducHNucGh4anh3dzV1dCIsIm9yZ2FuaXphdGlvbklkIjoid29mMnFhXzF3Y3hvNjZhIiwidHlwZSI6InVzZXIiLCJ1c2VyVHlwZSI6ImFwaSIsImlhdCI6MTY0NDkxMzQxMywiZXhwIjozMTcxODkzNTU4MTMsImF1ZCI6WyJQUk9EIl0sImlzcyI6IlBST0QifQ.B-M7rL4Ou7AFMeRiYgwrXBKhFw8m6y5fR_U6xbux99E";

                        var httpResponse1 = (HttpWebResponse)httpRequest1.GetResponse();
                        using (var streamReader = new StreamReader(httpResponse1.GetResponseStream()))
                        {
                            result2 = streamReader.ReadToEnd();
                        }
                        TaskDetails task = JsonConvert.DeserializeObject<TaskDetails>(result2);

                        if (reportGet.Employee == "")
                        {
                            var url2 = "https://app.workpuls.com/api/v1/employee/" + item.employeeId;
                            var httpRequest2 = (HttpWebRequest)WebRequest.Create(url2);
                            httpRequest2.Accept = "application/json";
                            httpRequest2.Headers["Authorization"] = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IndsZ2ZraW14cTRnYjRiayIsImFjY291bnRJZCI6InducHNucGh4anh3dzV1dCIsIm9yZ2FuaXphdGlvbklkIjoid29mMnFhXzF3Y3hvNjZhIiwidHlwZSI6InVzZXIiLCJ1c2VyVHlwZSI6ImFwaSIsImlhdCI6MTY0NDkxMzQxMywiZXhwIjozMTcxODkzNTU4MTMsImF1ZCI6WyJQUk9EIl0sImlzcyI6IlBST0QifQ.B-M7rL4Ou7AFMeRiYgwrXBKhFw8m6y5fR_U6xbux99E";

                            var httpResponse2 = (HttpWebResponse)httpRequest2.GetResponse();
                            using (var streamReader = new StreamReader(httpResponse2.GetResponseStream()))
                            {
                                result3 = streamReader.ReadToEnd();
                            }
                            employee = JsonConvert.DeserializeObject<EmployeeViewModel>(result3);
                        }

                        reportView.ClockIn = item.start;
                        reportView.ClockOut = item.end;
                        reportView.TotalTime = item.duration;
                        reportView.PayRate = item.payRate;
                        reportView.TaskCreated = task.createdAt;
                        reportView.TaskName = task.name;
                        reportView.DueDate = task.deadline;
                        reportView.AssignedTo = employee.name;
                        reportView.TimezoneOffset = item.timezoneOffset;
                        reportView.Count = count;
                        reportViews.Add(reportView);
                        _logger.LogInformation(" PullNetSuiteData() " + "test");
                    /*}
                    catch (Exception ex)
                    {
                        _logger.LogInformation(" PullNetSuiteData() " + ex.Message, ex);
                    }*/
                }

                return Ok(reportViews);
           /* }
            catch (Exception ex)
            {
                _logger.LogInformation(" PullNetSuiteData() " + ex.Message, ex);
                return BadRequest();
            }*/

        }
    }
}
