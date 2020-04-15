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
        /// Get resume data
        /// </summary>
        /// <param name="idLocation">Location code</param>
        /// <param name="measure">Date update</param>
        /// <returns></returns>
        public ActionResult<List<ResumeData>> getResumeData(string idLocation, int measure)
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
        /// Get location data by identifier
        /// </summary>
        /// <param name="idLocation">Location indentifier</param>
        /// <param name="synchronize"></param>
        /// <returns></returns>
        public ActionResult<List<LocationModel>> getLocations(string idLocation, string synchronize)
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
    }
}
