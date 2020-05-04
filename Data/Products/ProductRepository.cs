using Dapper;
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

        /// <summary>
        /// Update product status
        /// </summary>
        /// <param name="idbranch">code of product</param>
        /// <param name="flag">status value to change</param>
        /// <returns>Message response</returns>
        public ActionResult<string> setProductStatus(string idbranch, string status, string flag)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                var p = new DynamicParameters();
                p.Add("@ID_BRANCH", idbranch);
                p.Add("@STATUS", status);
                p.Add("@FLAG", flag);

                var query = dbConnection.Query<string>(Helper.Constants.spUpdateSalesFProductStatus,
                                                       p,
                                                       commandType: CommandType.StoredProcedure);
                return query.ToString();
            }
        }
    }
}
