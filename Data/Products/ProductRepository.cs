using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Viam.SalesForce.API.Model.Products;

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

        /// <summary>
        /// Add a new product
        /// </summary>
        /// <param name="newProductParams"></param>
        /// <returns></returns>
        public ActionResult<NewProductParams> addNewProduct(NewProductParams newProductParams)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                var p = new DynamicParameters();

                p.Add("@ID_COMPANY", newProductParams.idCompany);
                p.Add("@NAME_BRANCH", newProductParams.nameBranch);
                p.Add("@ADDRESS_BRANCH", newProductParams.addressBranch);
                p.Add("@ID_CITY", newProductParams.idCity);
                p.Add("@ID_MAIN_BRANCH", newProductParams.idMainBranch);
                p.Add("@ID_FLAG_BRANCH", newProductParams.idFlagBranch);
                p.Add("@ID_TYPE_BRANCH", newProductParams.idTypeBranch);
                p.Add("@PHONE1_BRANCH", newProductParams.phone1Branch);
                p.Add("@PHONE2_BRANCH", newProductParams.phone2Branch);
                p.Add("@FAX_BRANCH", newProductParams.faxBranch);
                p.Add("@DATE_CRE_BRANCH", newProductParams.dateCreateBranch);
                p.Add("@ZIP_BRANCH", newProductParams.zipBranch);
                p.Add("@CURRENCY_PAY_BRANCH", newProductParams.currencyPayBranch);
                p.Add("@ID_STATUS_BRANCH", newProductParams.idStatusBranch);
                p.Add("@STATUS_COMMENT", newProductParams.statusComment);
                p.Add("@BUSINESS_HOURS", newProductParams.businessHours);
                p.Add("@LATITUD", newProductParams.latitud);
                p.Add("@LONGITUD", newProductParams.longitud);
                p.Add("@GEO_PRECISION", newProductParams.geoPrecision);
                p.Add("@ID_LOCATION", newProductParams.idLocation);
                p.Add("@ID_CHAIN", newProductParams.idChain);
                p.Add("@REDPHONE", newProductParams.redPhone);
                p.Add("@DATE_OPEN", newProductParams.dateOpen);

                p.Add("@NAME_MAIN_BRANCH", newProductParams.nameMainBranch);
                p.Add("@DATE_CREA_MAIN_BRANCH", newProductParams.dateCreateMainBranch);
                p.Add("@EMAILBUSINESS", newProductParams.emailBusiness);
                p.Add("@EMAILOWNER", newProductParams.emailOwner);

                p.Add("@PAYMENT_METHOD_1", newProductParams.paymentMethod1);
                p.Add("@PAYMENT_METHOD_2", newProductParams.paymentMethod2);

                p.Add("@FIN_SCHEDULE", newProductParams.finSchedule);
                p.Add("@EMAIL_OPERATIONS", newProductParams.emailOperations);
                p.Add("@FIN_YEARLYINTERESTRATE", newProductParams.finYearlyInterestRate);
                p.Add("@FIN_STATUSCOMMENTS", newProductParams.finStatusComments);
                p.Add("@CREDIT_GRADE", newProductParams.creditGrade);
                p.Add("@DEPOSIT_BANK", newProductParams.depositBank);

                p.Add("@ID_SALESFORCE", newProductParams.idSalesForce);
                p.Add("@NAME_AGENT", newProductParams.nameAgent);

                var query = dbConnection.Query<NewProductParams>(Helper.Constants.spAddSalesFNewProduct,
                                                                 p,
                                                                 commandType: CommandType.StoredProcedure);
                return query.FirstOrDefault();
            }
        }

        public ActionResult<ProductModel> getProduct(string idBranch)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                var p = new DynamicParameters();

                p.Add("@ID_BRANCH", idBranch);

                var query = dbConnection.Query<ProductModel>(Helper.Constants.spGetSalesFProduct,
                                                             p,
                                                             commandType: CommandType.StoredProcedure);
                return query.FirstOrDefault();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productModel"></param>
        /// <returns></returns>
        public ActionResult<ProductModel> updateProduct(ProductModel productModel)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                var p = new DynamicParameters();

                p.Add("@ID_BRANCH", productModel.idBranch);
                p.Add("@ID_COMPANY", productModel.idCompany);
                p.Add("@NAME_BRANCH", productModel.nameBranch);
                p.Add("@ADDRESS_BRANCH", productModel.addressBranch);
                p.Add("@ID_CITY", productModel.idCity);
                p.Add("@ID_MAIN_BRANCH", productModel.idMainBranch);
                p.Add("@ID_FLAG_BRANCH", productModel.idFlagBranch);
                p.Add("@ID_TYPE_BRANCH", productModel.idTypeBranch);
                p.Add("@PHONE1_BRANCH", productModel.phone1Branch);
                p.Add("@PHONE2_BRANCH", productModel.phone2Branch);
                p.Add("@FAX_BRANCH", productModel.faxBranch);
                p.Add("@DATE_CRE_BRANCH", productModel.dateCreateBranch);
                p.Add("@ZIP_BRANCH", productModel.zipBranch);
                p.Add("@CURRENCY_PAY_BRANCH", productModel.currencyPayBranch);
                p.Add("@ID_STATUS_BRANCH", productModel.idStatusBranch);
                p.Add("@STATUS_COMMENT", productModel.statusComment);
                p.Add("@BUSINESS_HOURS", productModel.businessHours);
                p.Add("@LATITUD", productModel.latitud);
                p.Add("@LONGITUD", productModel.longitud);
                p.Add("@GEO_PRECISION", productModel.geoPrecision);
                p.Add("@ID_LOCATION", productModel.idLocation);
                p.Add("@ID_CHAIN", productModel.idChain);
                p.Add("@REDPHONE", productModel.redphone);
                p.Add("@DATE_OPEN", productModel.dateOpen);

                p.Add("@NAME_MAIN_BRANCH", productModel.dateOpen);
                p.Add("@DATE_CREA_MAIN_BRANCH", productModel.dateOpen);
                p.Add("@EMAILBUSINESS", productModel.dateOpen);
                p.Add("@EMAILOWNER", productModel.dateOpen);

                p.Add("@PAYMENT_METHOD_1", productModel.paymentMethod1);
                p.Add("@PAYMENT_METHOD_2", productModel.paymentMethod2);

                p.Add("@FIN_SCHEDULE", productModel.finSchedule);
                p.Add("@EMAIL_OPERATIONS", productModel.emailOperations);
                p.Add("@FIN_YEARLYINTERESTRATE", productModel.finYearlyInterestRate);
                p.Add("@FIN_STATUSCOMMENTS", productModel.finStatusComments);
                p.Add("@CREDIT_GRADE", productModel.creditGrade);
                p.Add("@DEPOSIT_BANK", productModel.depositBank);
                p.Add("@ID_SALESFORCE", productModel.idSalesForce);
                p.Add("@NAME_AGENT", productModel.nameAgent);

                var query = dbConnection.Query<ProductModel>(Helper.Constants.spUpdateSalesFProduct,
                                                             p,
                                                             commandType: CommandType.StoredProcedure);
                return query.FirstOrDefault();
            }
        }
    }
}
