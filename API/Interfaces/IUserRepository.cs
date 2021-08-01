using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);

        Task<bool> SaveAllAsync();

        Task<IEnumerable<AppUser>> GetUsersASync();

        Task<AppUser> GetUserASync(int id);

        Task<AppUser> GetUserByUsernameAsync(string username);
        
        
    }
}