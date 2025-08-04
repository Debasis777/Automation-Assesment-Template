using AutomationTests.Api.Factory;
using AutomationTests.Api.Models.Requests;
using Refit;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace AutomationTests.Api
{
    public class UserTests
    {
        private readonly IReqResApi _api;

        public UserTests()
        {
            _api = ApiClientFactory.CreateReqResApiClient();
        }

        [Fact]
        public async Task ShouldFetchUsers()
        {
            // Act
            var users = await _api.GetUsersAsync(2);

            // Assert
            Assert.NotEmpty(users.Data);
        }

        [Fact]
        public async Task ShouldCreateUser_WithApiKeyHeader()
        {
            // Arrange
            var request = new CreateUserRequest
            {
                Name = "John Doe",
                Job = "Developer"
            };

            // Act
            var newUser = await _api.CreateUserAsync(request);

            // Assert
            Assert.NotNull(newUser.Id);
            Assert.Equal(request.Name, newUser.Name);
            Assert.Equal(request.Job, newUser.Job);
        }

        [Fact]
        public async Task ShouldFetchUserById()
        {
            // Act
            var user = await _api.GetUserByIdAsync(2);

            // Assert
            Assert.NotNull(user);
            Assert.Equal("Janet", user.Data.First_name);
            Assert.Equal("Weaver", user.Data.Last_name);
        }

        [Fact]
        public async Task ShouldUpdateUser()
        {
            // Arrange
            var updateRequest = new UpdateUserRequest
            {
                Name = "Gaurav",
                Job = "Architect"
            };

            // Act
            var updatedUser = await _api.UpdateUserAsync(2, updateRequest);

            // Assert
            Assert.NotNull(updatedUser);
            Assert.False(string.IsNullOrWhiteSpace(updatedUser.UpdatedAt));
            Assert.Equal(updateRequest.Name, updatedUser.Name);
            Assert.Equal(updateRequest.Job, updatedUser.Job);
        }

        [Fact]
        public async Task ShouldDeleteUser()
        {
            // Act
            var response = await _api.DeleteUserAsync(2);

            // Assert
            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode);
        }
    }
}
