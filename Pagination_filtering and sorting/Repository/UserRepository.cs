using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Pagination_filtering_and_sorting.Models;
using System;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Pagination_filtering_and_sorting.Repository
{
    public class UserRepository : IuserRepository
    {
        private readonly demoprojectContext _context;
        public UserRepository(demoprojectContext context)

        {
            this._context = context;
        }

        public async Task<IEnumerable<User>> GetUserAsync(int pageNUmber, int pageSize, string filter, string sortOrder)
        {
            var quary = _context.Users.AsQueryable();

            if (!string.IsNullOrEmpty(filter))
            {
                quary = quary.Where(u => u.Username.Contains(filter));
            }
            quary = sortOrder switch
            {
                "id_desc" => quary.OrderByDescending(u => u.UserId),
                "id_asc" => quary.OrderBy(quary => quary.UserId),
                _=> quary.OrderBy(quary => quary.Username),

            };
            var pageuser =quary.Skip(pageNUmber-1).Take(pageSize);
            return await pageuser.ToListAsync();
        }

        public async Task UpdateuserAsync(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();


        }
    }
    
}



