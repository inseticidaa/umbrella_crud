using Domain.Adapters;
using Domain.Services;
using Microsoft.Extensions.Configuration;

namespace Application.Services
{
    public class AuthService : IAuthService
    {
        #region [Attributer & Constructor]

        private readonly IUsersRepository _usersRepository;
        private readonly IConfiguration _configuration;

        public AuthService(IUsersRepository usersRepository, IConfiguration configuration)
        {
            _usersRepository = usersRepository;
            _configuration = configuration;
        }

        #endregion [Attributer & Constructor]

        #region [Methods]

        public async Task<string> Authenticate(string username, string password)
        {
            if (username == "alizzo" && password == "1234") return "token-caraio";
            else return null;
        }

        #endregion [Methods]
    }
}