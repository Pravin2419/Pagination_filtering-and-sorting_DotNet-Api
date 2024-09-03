using Pagination_filtering_and_sorting.Models;
using Pagination_filtering_and_sorting.Repository;

namespace Pagination_filtering_and_sorting.Service
{
    public class UserService:IUserService
    {
        private readonly IuserRepository _userRepository;

        public UserService(IuserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public Task<IEnumerable<User>> GetUsersAsync(int pageNumber, int pageSize, string filter, string sortOrder)
        {
            if (pageNumber < 1) pageNumber = 1;
            if(pageSize < 1) pageSize = 1;
            return _userRepository.GetUserAsync(pageNumber, pageSize, filter, sortOrder);
        }

        public Task UpdateuserAsync(User user)
        {
            return _userRepository.UpdateuserAsync(user);
        }
    }
}

