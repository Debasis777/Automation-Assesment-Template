using AutomationTests.Api.Models.Requests;
using AutomationTests.Api.Models.Responses;
using Refit;
using System.Threading.Tasks;

// Add method signatures during implementation
public interface IReqResApi
{
    [Get("/api/users?page={page}")]
    Task<UserListResponse> GetUsersAsync(int page);

    [Get("/api/users/{id}")]
    Task<UserResponse> GetUserByIdAsync(int id);

    [Post("/api/users")]
    Task<CreateUserResponse> CreateUserAsync([Body] CreateUserRequest request);

    [Put("/api/users/{id}")]
    Task<UpdateUserResponse> UpdateUserAsync(int id, [Body] UpdateUserRequest request);

    [Delete("/api/users/{id}")]
    Task<ApiResponse<object>> DeleteUserAsync(int id);
    //Task UpdateUserAsync(int v, UpdateUserRequest updateUserRequest);
}
