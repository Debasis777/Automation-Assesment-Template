using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.Api.Models.Requests
{
    public class UpdateUserRequest
    {
        public string Name { get; set; }
        public string Job { get; set; }
    }
}
