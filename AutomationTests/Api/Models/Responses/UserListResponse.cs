using AutomationTests.Api.Models.Domain;
using AutomationTests.Api.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.Api.Models.Responses
{
    public class UserListResponse
    {
        public int Page { get; set; }
        public int Per_page { get; set; }
        public int Total { get; set; }
        public int Total_pages { get; set; }
        public List<UserData> Data { get; set; }
    }
}
