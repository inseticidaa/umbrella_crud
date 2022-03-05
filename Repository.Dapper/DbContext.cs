using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Repository.Dapper
{
    public sealed class DbContext : IDisposable
    {
        private Guid _id;
        public IDbConnection Connection { get; }
        public IDbTransaction Transaction { get; set; }

        public IConfiguration Configuration;

        public DbContext(IConfiguration configuration)
        {
            Configuration = configuration;
            _id = Guid.NewGuid();
            Connection = new SqlConnection(Configuration.GetConnectionString("DefaultConnection"));
            Connection.Open();
        }

        public void Dispose() => Connection?.Dispose();
    }
}