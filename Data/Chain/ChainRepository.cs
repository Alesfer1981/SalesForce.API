using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Viam.SalesForce.API.Helper;
using Viam.SalesForce.API.Model.Chain;

namespace Viam.SalesForce.API.Data.Chain
{
    public class ChainRepository
    {
        private string _connectionString;

        private IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }

        public ChainRepository(string connection)
        {
            _connectionString = connection;
        }

        public ActionResult<List<ChainModel>> getChainList(string filter)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                var p = new DynamicParameters();
                p.Add("@Filter", filter);

                var query = dbConnection.Query<ChainModel>(Constants.spSalesFChainList,
                                                           p,
                                                           commandType: CommandType.StoredProcedure);
                return query.AsList();

            }

        }

    }
}
