using Domain.Adapters;
using Domain.Services;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        public IUsersRepository UsersRepository { get; set; }
        public IAuthService AuthService { get; set; }
    }
}