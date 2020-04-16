using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Viam.SalesForce.API.Model.Locations;

namespace Viam.SalesForce.API.Data.Groups
{
    public class GroupRepository
    {

        private string _connectionString;

        private IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }

        public GroupRepository(string connection)
        {
            _connectionString = connection;
        }

        public ActionResult<List<MainBranchModel>> getMainBranchList(string idLocation)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                var p = new DynamicParameters();
                p.Add("@Filter", idLocation);

                var query = dbConnection.Query<MainBranchModel>(Helper.Constants.spSalesFMainBranchList,
                                                                p,
                                                                commandType: CommandType.StoredProcedure);
                return query.AsList();
            }
        }

    }
}
