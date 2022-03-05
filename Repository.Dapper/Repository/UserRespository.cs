using Dapper;
using Domain.Adapters;
using Domain.Entities;

namespace Repository.Dapper.Repository
{
    public class UserRespository : IUsersRepository
    {
        #region [Attributes & Constructor]

        private DbContext _context;

        public UserRespository(DbContext context)
        {
            _context = context;
        }

        #endregion [Attributes & Constructor]

        #region [Methods]

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll(int page, int pageSize)
        {
            return _context.Connection.QueryAsync<User>(@"
                SELECT * FROM [dbo].[TB_USERS]
                ORDER BY Id DESC
                OFFSET @Offset ROWS
                FETCH NEXT @PageSize ROWS ONLY;
            ", new
            {
                Offset = (page - 1) * pageSize,
                PageSize = pageSize
            });
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByUsernameAsync(string username)
        {
            return _context.Connection.QueryFirstOrDefaultAsync<User>(@"
                SELECT TOP(1) * FROM [dbo].[TB_USERS]
                WHERE Username = @Username;
            ", new { Username = username });
        }

        public Task<int> Insert(User obj)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(User obj)
        {
            throw new NotImplementedException();
        }

        #endregion [Methods]
    }
}