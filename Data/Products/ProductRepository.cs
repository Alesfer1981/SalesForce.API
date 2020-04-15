using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Data.Products
{
    public class ProductRepository
    {
        private string _connectionString;

        private IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }

        public ProductRepository(string connection)
        {
            _connectionString = connection;
        }

    }
}
