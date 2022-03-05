using Domain.Adapters;
using Domain.Interfaces;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUsersRepository UsersRepository { get; set; }
        public IAuthService AuthService { get; set; }

        public UnitOfWork(IUsersRepository usersRepository, IAuthService authService)
        {
            UsersRepository = usersRepository;
            AuthService = authService;
        }
    }
}