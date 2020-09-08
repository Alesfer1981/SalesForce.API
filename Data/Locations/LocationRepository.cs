using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Viam.SalesForce.API.Helper;
using Viam.SalesForce.API.Model.Locations;
using Viam.SalesForce.API.Model.Products;

namespace Viam.SalesForce.API.Data.Locations
{
    public class LocationRepository
    {
        private string _connectionString;

        private IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }

        public LocationRepository(string connection)
        {
            _connectionString = connection;
        }

        /// <summary>
        /// Get location data by identifier
        /// </summary>
        /// <param name="idLocation">Location indentifier</param>
        /// <param name="synchronize"></param>
        /// <returns></returns>
        public List<LocationModel> getLocations(string idLocation, string synchronize)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                var p = new DynamicParameters();
                p.Add("@IdLocation", idLocation);
                p.Add("@Synchronize", synchronize);

                var query = dbConnection.Query<LocationModel>(Constants.spGetSalesfLocations,
                                                              p,
                                                              commandType: CommandType.StoredProcedure);
                return query.AsList();

            }

        }

        /// <summary>
        /// Get resume data
        /// </summary>
        /// <param name="idLocation">Location code</param>
        /// <param name="measure">Date update</param>
        /// <returns></returns>
        public List<ResumeData> getResumeData(string idLocation, int measure)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                var p = new DynamicParameters();
                p.Add("@IdLocation", idLocation);
                p.Add("@Measure", measure);

                var query = dbConnection.Query<ResumeData>(Constants.spGetSalesfResumeData,
                                                           p,
                                                           commandType: CommandType.StoredProcedure);
                return query.AsList();
            }
        }

        /// <summary>
        /// Report of data at today date
        /// </summary>
        /// <param name="idLocation">Code of location</param>
        /// <returns>List of resume data today</returns>
        public ActionResult<List<ResumeDataToday>> getResumeDataToday(string idLocation)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                var p = new DynamicParameters();
                p.Add("@IdLocation", idLocation);

                var query = dbConnection.Query<ResumeDataToday>(Constants.spGetSalesfTodayResumeData,
                                                                p,
                                                                commandType: CommandType.StoredProcedure);
                return query.AsList();
            }
        }

        /// <summary>
        /// Set status a group of locations
        /// </summary>
        /// <param name="idLocationList">List of locations codes separated by comma</param>
        /// <param name="value">Value to set synchronize column</param>
        /// <returns>Confirm operation</returns>
        public ActionResult<string> setSynchronized(string idLocationList, string value)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                var p = new DynamicParameters();
                p.Add("@IDS_LOCATION", idLocationList);
                p.Add("@SYNCHRONIZE", value);

                var query = dbConnection.Query<string>(Constants.spUpdateSalesFLocationSynchronize,
                                                       p,
                                                       commandType: CommandType.StoredProcedure);
                return query.ToString();
            }
        }

        /// <summary>
        /// Change status of location
        /// </summary>
        /// <param name="idLocation">Code of location</param>
        /// <param name="status">status value O:open C:Closed</param>
        /// <param name="flag">flag status A:Active I:Incative</param>
        /// <returns>Message response</returns>
        public ActionResult<string> setLocationStatus(string idLocation)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                var p = new DynamicParameters();
                p.Add("@ID_LOCATION", idLocation);

                var query = dbConnection.Query<string>(Constants.spUpdateSalesFLocationStatus,
                                                       p,
                                                       commandType: CommandType.StoredProcedure);
                if (query.Count() > 0)
                    return "OK";
                else
                    return "Error";
            }
        }

        /// <summary>
        /// Get the current rates values
        /// </summary>
        /// <param name="idLocation">Locatio code</param>
        /// <param name="dateFrom">date from request data</param>
        /// <returns>Rate model list objects</returns>
        public ActionResult<List<RateModel>> getCurrentRates(string idLocation, DateTime? dateFrom)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                var p = new DynamicParameters();
                p.Add("@IdLocation", idLocation);
                p.Add("@DateFrom", dateFrom);

                var query = dbConnection.Query<RateModel>(Constants.spGetSalesfCurrentRatesData,
                                                          p,
                                                          commandType: CommandType.StoredProcedure);
                return query.AsList();
            }
        }

        /// <summary>
        /// Update the sales force code
        /// </summary>
        /// <param name="idLocation">Location Code</param>
        /// <param name="idSalesForce">Sales force Code</param>
        /// <returns></returns>
        public ActionResult<string> setSalesFId(string idLocation, string idSalesForce)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                var p = new DynamicParameters();
                p.Add("@ID_LOCATION", idLocation);
                p.Add("@ID_SALESFORCE", idSalesForce);

                var query = dbConnection.Query<string>(Constants.spSetSalesFId,
                                                       p,
                                                       commandType: CommandType.StoredProcedure);
                return query.ToString();
            }
        }

       public ActionResult<List<AgencyProducts>> getAgencyProducts(string idProduct, string date, string idLocation)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                var p = new DynamicParameters();

                p.Add("@IdProduct", idProduct);
                p.Add("@IdLocation", idLocation);
				p.Add("@Date", date);

                var query = dbConnection.Query<AgencyProducts>(Helper.Constants.spGetSLDailyTransactions,
                                                          p,
                                                          commandType: CommandType.StoredProcedure);
                return query.AsList();
            }
        }
    }
}