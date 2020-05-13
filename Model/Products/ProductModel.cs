using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Products
{
    public class ProductModel
    {
        public string idBranch { get; set; }
        private string ID_BRANCH
        {
            get { return idBranch; }
            set { idBranch = value.Trim(); }
        }

        public string idCompany { get; set; }
        private string ID_COMPANY
        {
            get { return idCompany; }
            set { idCompany = value.Trim(); }
        }

        public string nameBranch { get; set; }
        private string NAME_BRANCH
        {
            get { return nameBranch; }
            set { nameBranch = value.Trim(); }
        }

        public string addressBranch { get; set; }
        private string ADDRESS_BRANCH
        {
            get { return addressBranch; }
            set { addressBranch = value.Trim(); }
        }

        public string idCity { get; set; }
        private string ID_CITY
        {
            get { return idCity; }
            set { idCity = value.Trim(); }
        }

        public string idMainBranch { get; set; }
        private string ID_MAIN_BRANCH
        {
            get { return idMainBranch; }
            set { idMainBranch = value.Trim(); }
        }

        public string idFlagBranch { get; set; }
        private string ID_FLAG_BRANCH
        {
            get { return idFlagBranch; }
            set { idFlagBranch = value.Trim(); }
        }

        public string idTypeBranch { get; set; }
        private string ID_TYPE_BRANCH
        {
            get { return idTypeBranch; }
            set { idTypeBranch = value.Trim(); }
        }

        public string phone1Branch { get; set; }
        private string PHONE1_BRANCH
        {
            get { return phone1Branch; }
            set { phone1Branch = value.Trim(); }
        }

        public string phone2Branch { get; set; }
        private string PHONE2_BRANCH
        {
            get { return phone2Branch; }
            set { phone2Branch = value.Trim(); }
        }

        public string faxBranch { get; set; }
        private string FAX_BRANCH
        {
            get { return faxBranch; }
            set { faxBranch = value.Trim(); }
        }

        public DateTime dateCreateBranch { get; set; }
        private DateTime DATE_CRE_BRANCH
        {
            get { return dateCreateBranch; }
            set { dateCreateBranch = value; }
        }

        public decimal zipBranch { get; set; }
        private decimal ZIP_BRANCH
        {
            get { return zipBranch; }
            set { zipBranch = value; }
        }

        public string currencyPayBranch { get; set; }
        private string CURRENCY_PAY_BRANCH
        {
            get { return currencyPayBranch; }
            set { currencyPayBranch = value.Trim(); }
        }

        public string idStatusBranch { get; set; }
        private string ID_STATUS_BRANCH
        {
            get { return idStatusBranch; }
            set { idStatusBranch = value.Trim(); }
        }

        public string statusComment { get; set; }
        private string STATUS_COMMENT
        {
            get { return statusComment; }
            set { statusComment = value.Trim(); }
        }

        public string businessHours { get; set; }
        private string BUSINESS_HOURS
        {
            get { return businessHours; }
            set { businessHours = value.Trim(); }
        }

        public string latitud { get; set; }

        public string longitud { get; set; }

        public string geoPrecision { get; set; }
        private string GEO_PRECISION
        {
            get { return geoPrecision; }
            set { geoPrecision = value.Trim(); }
        }

        public string idLocation { get; set; }
        private string ID_LOCATION
        {
            get { return idLocation; }
            set { idLocation = value.Trim(); }
        }

        public string idChain { get; set; }
        private string ID_CHAIN
        {
            get { return idChain; }
            set { idChain = value.Trim(); }
        }

        public int redphone { get; set; }
        private int REDPHONE
        {
            get { return redphone; }
            set { redphone = value; }
        }

        public DateTime dateOpen { get; set; }
        private DateTime DATE_OPEN
        {
            get { return dateOpen; }
            set { dateOpen = value; }
        }

        public string nameMainBranch { get; set; }
        private string NAME_MAIN_BRANCH
        {
            get { return nameMainBranch; }
            set { nameMainBranch = value.Trim(); }
        }

        public DateTime dateCreaMainOpen { get; set; }
        private DateTime @ATE_CREA_MAIN_BRANCH
        {
            get { return dateCreaMainOpen; }
            set { dateCreaMainOpen = value; }
        }

        public string emailBusiness { get; set; }
        private string EMAILBUSINESS
        {
            get { return emailBusiness; }
            set { emailBusiness = value.Trim(); }
        }

        public string emailOwner { get; set; }
        private string EMAILOWNER
        {
            get { return emailOwner; }
            set { emailOwner = value.Trim(); }
        }

        public string paymentMethod1 { get; set; }
        private string PAYMENT_METHOD_1
        {
            get { return paymentMethod1; }
            set { paymentMethod1 = value; }
        }

        public string paymentMethod2 { get; set; }
        private string PAYMENT_METHOD_2
        {
            get { return paymentMethod2; }
            set { paymentMethod2 = value; }
        }


        public string finSchedule { get; set; }
        private string FIN_SCHEDULE
        {
            get { return finSchedule; }
            set { finSchedule = value; }
        }

        public string emailOperations { get; set; }
        private string EMAIL_OPERATIONS
        {
            get { return emailOperations; }
            set { emailOperations = value; }
        }

        public string finYearlyInterestRate { get; set; }
        private string FIN_YEARLYINTERESTRATE
        {
            get { return finYearlyInterestRate; }
            set { finYearlyInterestRate = value; }
        }

        public string finStatusComments { get; set; }
        private string FIN_STATUSCOMMENTS
        {
            get { return finStatusComments; }
            set { finStatusComments = value; }
        }

        public string creditGrade { get; set; }
        private string CREDIT_GRADE
        {
            get { return creditGrade; }
            set { creditGrade = value; }
        }

        public string depositBank { get; set; }
        private string DEPOSIT_BANK
        {
            get { return depositBank; }
            set { depositBank = value; }
        }

        public string idSalesForce { get; set; }
        private string ID_SALESFORCE
        {
            get { return idSalesForce; }
            set { idSalesForce = value; }
        }

        public string nameAgent { get; set; }
        private string NAME_AGENT
        {
            get { return nameAgent; }
            set { nameAgent = value; }
        }
    }
}
