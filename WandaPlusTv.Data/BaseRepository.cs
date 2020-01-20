using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Microsoft.Extensions.Configuration;


namespace WandaPlusTv.Data
{    
    public interface IBaseRepository
    {

        void Execute(Action<IDbConnection> query);
    }

    public class BaseRepository : IBaseRepository
    {
        public BaseRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        private readonly string _connectionString;
        public void Execute(Action<IDbConnection> query)
        {
            //using (SqlConnection db = new SqlConnection(_connectionString))
            //{
            //    await Task<>;
            //}
        }
    }
}
