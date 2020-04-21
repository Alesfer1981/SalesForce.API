using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Viam.SalesForce.API.Model.User;

namespace Viam.SalesForce.API.Data.Users
{
    public class UserRepository
    {
        private string _connectionString;

        private IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }

        public UserRepository(string connection)
        {
            _connectionString = connection;
        }

        public Usuario getUserAPI(string login, string password)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                var p = new DynamicParameters();
                p.Add("@login", login);
                p.Add("@p_password", password);
                p.Add("@p_type", "V");

                var query = dbConnection.Query<Usuario>(Helper.Constants.spValidateCrmUsers,
                                                          p,
                                                          commandType: CommandType.StoredProcedure);
                return query.FirstOrDefault();

            }
        }
    }
}
