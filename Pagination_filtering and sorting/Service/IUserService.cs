using Pagination_filtering_and_sorting.Models;

namespace Pagination_filtering_and_sorting.Service
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync(int pageNumber, int pageSize,string filter, string sortOrder );

        Task UpdateuserAsync(User user);
    }
}
