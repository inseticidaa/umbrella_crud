using Domain.Entities;
using Domain.Interfaces;

namespace Domain.Adapters
{
    public interface IUsersRepository : IGenericRepository<User>
    {
        Task<User> GetByUsernameAsync(string username);
    }
}