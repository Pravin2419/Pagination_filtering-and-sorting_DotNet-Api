using Pagination_filtering_and_sorting.Models;

namespace Pagination_filtering_and_sorting.Repository
{
    public interface IuserRepository
    {
        Task<IEnumerable<User>> GetUserAsync(int pageNUmber, int pageSize, string filter, string sortOrder);

        Task UpdateuserAsync(User user);
    }
}
