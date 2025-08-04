
using AutomationTests.Api.Models.Requests;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTests
{
    public class ReqResApiTest
    {
        public static async Task Main()
        {
            var api = RestService.For<IReqResApi>("https://reqres.in");


            // Get single user
            var user = await api.GetUserByIdAsync(2);
            Console.WriteLine($"User: {user.Data.First_name} {user.Data.Last_name}");

          
            // Update user
            var updatedUser = await api.UpdateUserAsync(2, new UpdateUserRequest { Name = "Gaurav", Job = "Architect" });
            Console.WriteLine($"Updated At: {updatedUser.UpdatedAt}");

            // Delete user
            var deleteResponse = await api.DeleteUserAsync(2);
            Console.WriteLine($"Deleted Status Code: {deleteResponse.StatusCode}");
        }
    }
}
