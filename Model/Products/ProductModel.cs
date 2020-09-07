using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Products
{
    public class ProductModel
    {
        /// <summary>
        /// Branch code
        /// </summary>
        public string idBranch { get; set; }
        private string ID_BRANCH
        {
            get { return idBranch; }
            set { idBranch = value.Trim(); }
        }
        /// <summary>
        /// Company code
        /// </summary>
        [Required, StringLength(6), MinLength(3)]
        public string idCompany { get; set; }
        private string ID_COMPANY
        {
            get { return idCompany; }
            set { idCompany = value.Trim(); }
        }

        /// <summary>
        /// Name branch for accounting purposes
        /// </summary>
        [Required, StringLength(60), MinLength(5)]
        public string nameBranch { get; set; }
        private string NAME_BRANCH
        {
            get { return nameBranch; }
            set { nameBranch = value.Trim(); }
        }

        /// <summary>
        ///  Branch address
        /// </summary>
        [Required, StringLength(60), MinLength(5)]
        public string addressBranch { get; set; }
        private string ADDRESS_BRANCH
        {
            get { return addressBranch; }
            set { addressBranch = value.Trim(); }
        }

        /// <summary>
        /// City code
        /// </summary>
        [Required, StringLength(5), MinLength(5)]
        public string idCity { get; set; }
        private string ID_CITY
        {
            get { return idCity; }
            set { idCity = value.Trim(); }
        }

        /// <summary>
        /// Code of main branch for accounting purposes
        /// </summary>
        [Required, StringLength(4), MinLength(4)]
        public string idMainBranch { get; set; }
        private string ID_MAIN_BRANCH
        {
            get { return idMainBranch; }
            set { idMainBranch = value.Trim(); }
        }

        /// <summary>
        /// Flag branch code (O :open C: closed)
        /// </summary>
        [Required, StringLength(1), MinLength(1)]
        public string idFlagBranch { get; set; }
        private string ID_FLAG_BRANCH
        {
            get { return idFlagBranch; }
            set { idFlagBranch = value.Trim(); }
        }

        /// <summary>
        /// code type branch (P:Payee R:Agent A:Both)
        /// </summary>
        [Required, StringLength(1), MinLength(1)]
        public string idTypeBranch { get; set; }
        private string ID_TYPE_BRANCH
        {
            get { return idTypeBranch; }
            set { idTypeBranch = value.Trim(); }
        }

        /// <summary>
        /// Agency Phone number 1
        /// </summary>
        [StringLength(15), MinLength(7)]
        public string phone1Branch { get; set; }
        private string PHONE1_BRANCH
        {
            get { return phone1Branch; }
            set { phone1Branch = value.Trim(); }
        }

        /// <summary>
        /// Agency Phone number 2
        /// </summary>
        [StringLength(15), MinLength(7)]
        public string phone2Branch { get; set; }
        private string PHONE2_BRANCH
        {
            get { return phone2Branch; }
            set { phone2Branch = value.Trim(); }
        }

        /// <summary>
        /// Agency Fax
        /// </summary>
        [StringLength(15), MinLength(10)]
        public string faxBranch { get; set; }
        private string FAX_BRANCH
        {
            get { return faxBranch; }
            set { faxBranch = value.Trim(); }
        }

        /// <summary>
        /// date of creation branch
        /// </summary>
        public DateTime dateCreateBranch { get; set; }
        private DateTime DATE_CRE_BRANCH
        {
            get { return dateCreateBranch; }
            set { dateCreateBranch = value; }
        }

        /// <summary>
        /// Agency Zip code
        /// </summary>
        public decimal zipBranch { get; set; }
        private decimal ZIP_BRANCH
        {
            get { return zipBranch; }
            set { zipBranch = value; }
        }

        /// <summary>
        /// Agency currency for payments (N: National Currency - D:Dollar)
        /// </summary>
        [Required, StringLength(1), MinLength(1)]
        public string currencyPayBranch { get; set; }
        private string CURRENCY_PAY_BRANCH
        {
            get { return currencyPayBranch; }
            set { currencyPayBranch = value.Trim(); }
        }

        /// <summary>
        /// Branch status (O: Open - C: Close)
        /// </summary>
        [Required, StringLength(1), MinLength(1)]
        public string idStatusBranch { get; set; }
        private string ID_STATUS_BRANCH
        {
            get { return idStatusBranch; }
            set { idStatusBranch = value.Trim(); }
        }

        /// <summary>
        /// Last comment about agency status
        /// </summary>
        [StringLength(200)]
        public string statusComment { get; set; }
        private string STATUS_COMMENT
        {
            get { return statusComment; }
            set { statusComment = value.Trim(); }
        }

        /// <summary>
        /// Agency Schedule for customers
        /// </summary>
        [StringLength(200)]
        public string businessHours { get; set; }
        private string BUSINESS_HOURS
        {
            get { return businessHours; }
            set { businessHours = value.Trim(); }
        }

        /// <summary>
        /// Location latitud value
        /// </summary>
        [StringLength(20)]
        public string latitud { get; set; }

        /// <summary>
        /// Location longitud value
        /// </summary>
        [StringLength(20)]
        public string longitud { get; set; }

        /// <summary>
        /// Geo precision value
        /// </summary>
        [StringLength(1)]
        public string geoPrecision { get; set; }
        private string GEO_PRECISION
        {
            get { return geoPrecision; }
            set { geoPrecision = value.Trim(); }
        }

        /// <summary>
        /// Location code
        /// </summary>
        [StringLength(6)]
        public string idLocation { get; set; }
        private string ID_LOCATION
        {
            get { return idLocation; }
            set { idLocation = value.Trim(); }
        }

        /// <summary>
        /// Chain code
        /// </summary>
        [StringLength(9)]
        public string idChain { get; set; }
        private string ID_CHAIN
        {
            get { return idChain; }
            set { idChain = value.Trim(); }
        }

        /// <summary>
        /// Value to validate if redphone app is installed
        /// </summary>
        public int redphone { get; set; }
        private int REDPHONE
        {
            get { return redphone; }
            set { redphone = value; }
        }

        /// <summary>
        /// Date open
        /// </summary>
        public DateTime dateOpen { get; set; }
        private DateTime DATE_OPEN
        {
            get { return dateOpen; }
            set { dateOpen = value; }
        }

        /// <summary>
        /// Name main branch
        /// </summary>
        [Required, StringLength(60), MinLength(5)]
        public string nameMainBranch { get; set; }
        private string NAME_MAIN_BRANCH
        {
            get { return nameMainBranch; }
            set { nameMainBranch = value.Trim(); }
        }

        /// <summary>
        /// Date create main branch open
        /// </summary>
        public DateTime dateCreaMainOpen { get; set; }
        private DateTime @ATE_CREA_MAIN_BRANCH
        {
            get { return dateCreaMainOpen; }
            set { dateCreaMainOpen = value; }
        }

        /// <summary>
        /// Email address for business
        /// </summary>
        public string emailBusiness { get; set; }
        private string EMAILBUSINESS
        {
            get { return emailBusiness; }
            set { emailBusiness = value.Trim(); }
        }

        /// <summary>
        /// Owner email address
        /// </summary>
        public string emailOwner { get; set; }
        private string EMAILOWNER
        {
            get { return emailOwner; }
            set { emailOwner = value.Trim(); }
        }

        /// <summary>
        /// Payment method alternative 1 (c:bank deposit  p: cash pick up)
        /// </summary>
        [StringLength(2)]
        public string paymentMethod1 { get; set; }
        private string PAYMENT_METHOD_1
        {
            get { return paymentMethod1; }
            set { paymentMethod1 = value; }
        }
        /// <summary>
        /// Payment method alternative 2 (c: bank deposit p:cash pick up)
        /// </summary>
        public string paymentMethod2 { get; set; }
        private string PAYMENT_METHOD_2
        {
            get { return paymentMethod2; }
            set { paymentMethod2 = value; }
        }

        /// <summary>
        /// Financial schedule value
        /// </summary>
        public string finSchedule { get; set; }
        private string FIN_SCHEDULE
        {
            get { return finSchedule; }
            set { finSchedule = value; }
        }

        /// <summary>
        /// Operations area email address
        /// </summary>
        public string emailOperations { get; set; }
        private string EMAIL_OPERATIONS
        {
            get { return emailOperations; }
            set { emailOperations = value; }
        }

        /// <summary>
        /// Financial yearly interest rate
        /// </summary>
        public string finYearlyInterestRate { get; set; }
        private string FIN_YEARLYINTERESTRATE
        {
            get { return finYearlyInterestRate; }
            set { finYearlyInterestRate = value; }
        }

        /// <summary>
        /// Financial status last comments
        /// </summary>
        public string finStatusComments { get; set; }
        private string FIN_STATUSCOMMENTS
        {
            get { return finStatusComments; }
            set { finStatusComments = value; }
        }

        /// <summary>
        /// Credit grade
        /// </summary>
        public string creditGrade { get; set; }
        private string CREDIT_GRADE
        {
            get { return creditGrade; }
            set { creditGrade = value; }
        }

        /// <summary>
        /// Bank deposit
        /// </summary>
        public string depositBank { get; set; }
        private string DEPOSIT_BANK
        {
            get { return depositBank; }
            set { depositBank = value; }
        }

        /// <summary>
        /// SalesForce code
        /// </summary>
        [StringLength(50)]
        public string idSalesForce { get; set; }
        private string ID_SALESFORCE
        {
            get { return idSalesForce; }
            set { idSalesForce = value; }
        }

        /// <summary>
        /// Name of agent
        /// </summary>
        public string nameAgent { get; set; }
        private string NAME_AGENT
        {
            get { return nameAgent; }
            set { nameAgent = value; }
        }
    }
}
