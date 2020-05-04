using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Viam.SalesForce.API.Model.Groups;
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

        /// <summary>
        /// Update credit of group branch
        /// </summary>
        /// <param name="salesFUpdateCreditParam">salesFUpdateCreditParam object</param>
        /// <returns></returns>
        public ActionResult<string> updateCredit(SalesFUpdateCreditParam salesFUpdateCreditParam)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                var p = new DynamicParameters();
                p.Add("@ID_MAIN_BRANCH", salesFUpdateCreditParam.idMainBranch);
                p.Add("@DEBT_LIMIT", salesFUpdateCreditParam.debtLimit);
                p.Add("@DEBT_LIMIT_WKND", salesFUpdateCreditParam.debtLimitWknd);
                p.Add("@ID_PHASE", salesFUpdateCreditParam.idPhase);
                p.Add("@DEBT_LIMIT_MO", salesFUpdateCreditParam.debtLimitMo);
                p.Add("@DEBT_LIMIT_WKND_MO", salesFUpdateCreditParam.debtLimitWkndMo);

                var query = dbConnection.Query<string>(Helper.Constants.spUpdateSalesFCredit,
                                                       p,
                                                       commandType: CommandType.StoredProcedure);
                if (query.Count() > 0)
                {
                    return HttpStatusCode.OK.ToString();
                }
                else
                {
                    return HttpStatusCode.NotFound.ToString();
                }
            }
        }
    }
}