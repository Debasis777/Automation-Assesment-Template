using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests.Api.Models.Responses
{
    public class UpdateUserResponse
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public string UpdatedAt { get; set; }
    }
}
