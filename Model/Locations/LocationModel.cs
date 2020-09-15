using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Locations
{
    /// <summary>
    /// Location object to store data
    /// </summary>
    public class LocationModel
    {
        /// <summary>
        /// Location code
        /// </summary>
        [Required, StringLength(15), MinLength(6)]
        public string id { get; set; }
        //private string ID_LOCATION
        //{
        //    get { return idLocation; }
        //    set { idLocation = value.Trim(); }
        //}

        /// <summary>
        /// Code of the company group
        /// </summary>
        [StringLength(9)]
        public string idGroupCompany { get; set; }
        private string ID_GROUP_COMPANY
        {
            get { return idGroupCompany; }
            set { idGroupCompany = value.Trim(); }
        }

        /// <summary>
        /// List of branches, separated by comma
        /// </summary>
        public string branches { get; set; }
        //private string BRANCHES
        //{
        //    get { return branches; }
        //    set { branches = value.Trim(); }
        //}

        /// <summary>
        /// Type of location (New or Existing)
        /// </summary>
        public string type { get; set; }
        //private string TYPE
        //{
        //    get { return type; }
        //    set { type = value.Trim(); }
        //}

        /// <summary>
        /// Creation date of location (YYYY-mm-DD)
        /// </summary>
        [Timestamp]
        public string creationDate { get; set; }
        private string CREATION_DATE
        {
            get { return creationDate; }
            set { creationDate = value.Trim(); }
        }

        /// <summary>
        /// Total days open
        /// </summary>
        [Required]
        public string daysOpen { get; set; }
        private string DAYS_OPEN
        {
            get { return daysOpen; }
            set { daysOpen = value.Trim(); }
        }

        /// <summary>
        /// Company Name
        /// </summary>
        [Required, StringLength(40)]
        public string companyName { get; set; }
        private string COMPANY_NAME
        {
            get { return companyName; }
            set { companyName = value.Trim(); }
        }

        /// <summary>
        /// Group of company
        /// </summary>
        [StringLength(40)]
        public string groupCompany { get; set; }
        private string GROUP_COMPANY
        {
            get { return groupCompany; }
            set { groupCompany = value.Trim(); }
        }

        /// <summary>
        /// Name of location
        /// </summary>
        public string name { get; set; }
        //private string NAME
        //{
        //    get { return name; }
        //    set { name = value.Trim(); }
        //}

        /// <summary>
        /// Status of location (A:Active I:Inactive)
        /// </summary>
        public string status { get; set; }
        //private string STATUS
        //{
        //    get { return status; }
        //    set { status = value.Trim(); }
        //}

        /// <summary>
        /// Status of location (Open-Active, Open-Inactive, Closed)
        /// </summary>
        public string extendedStatus { get; set; }
        private string EXTENDED_STATUS
        {
            get { return extendedStatus; }
            set { extendedStatus = value.Trim(); }
        }

        /// <summary>
        /// Location City
        /// </summary>
        public string city { get; set; }
        //private string CITY
        //{
        //    get { return city; }
        //    set { city = value.Trim(); }
        //}

        /// <summary>
        /// Location State
        /// </summary>
        public string state { get; set; }
        //private string STATE
        //{
        //    get { return state; }
        //    set { state = value.Trim(); }
        //}

        /// <summary>
        /// Location Zone
        /// </summary>
        public string zone { get; set; }
        //private string ZONE
        //{
        //    get { return zone; }
        //    set { zone = value.Trim(); }
        //}

        /// <summary>
        /// Location Sales Representative
        /// </summary>
        public string salesRepresentative { get; set; }
        private string SALES_REPRESENTATIVE
        {
            get { return salesRepresentative; }
            set { salesRepresentative = value.Trim(); }
        }

        /// <summary>
        /// Location Sales Representative identifier
        /// </summary>
        public string idSalesRepresentative { get; set; }
        private string ID_SALES_REPRESENTATIVE
        {
            get { return idSalesRepresentative; }
            set { idSalesRepresentative = value.Trim(); }
        }

        /// <summary>
        /// Manager of location
        /// </summary>
        public string manager { get; set; }
        //private string MANAGER
        //{
        //    get { return manager; }
        //    set { manager = value.Trim(); }
        //}

        /// <summary>
        /// Location Address
        /// </summary>
        public string address { get; set; }
        //private string ADDRESS
        //{
        //    get { return address; }
        //    set { address = value.Trim(); }
        //}

        /// <summary>
        /// Location Zip code
        /// </summary>
        public string zip { get; set; }
        //private string ZIP
        //{
        //    get { return zip; }
        //    set { zip = value.Trim(); }
        //}

        /// <summary>
        /// Location Phone number 1
        /// </summary>
        public string phone1 { get; set; }
        //private string PHONE1
        //{
        //    get { return phone1; }
        //    set { phone1 = value.Trim(); }
        //}

        /// <summary>
        /// Location phone number 2
        /// </summary>
        public string phone2 { get; set; }
        //private string PHONE2
        //{
        //    get { return phone2; }
        //    set { phone2 = value.Trim(); }
        //}

        /// <summary>
        /// Location Fax number
        /// </summary>
        public string fax { get; set; }
        //private string FAX
        //{
        //    get { return fax; }
        //    set { fax = value.Trim(); }
        //}

        /// <summary>
        /// Instalation Type
        /// </summary>
        public string instalationType { get; set; }
        private string INSTALLATION_TYPE
        {
            get { return instalationType; }
            set { instalationType = value.Trim(); }
        }

        /// <summary>
        /// Name of the inside sales representative
        /// </summary>
        public string insideSales { get; set; }
        private string INSIDE_SALES
        {
            get { return insideSales; }
            set { insideSales = value.Trim(); }
        }

        /// <summary>
        /// Owner name
        /// </summary>
        public string ownerName { get; set; }
        private string OWNER_NAME
        {
            get { return ownerName; }
            set { ownerName = value.Trim(); }
        }

        /// <summary>
        /// Owner phone number
        /// </summary>
        public string ownerPhone { get; set; }
        private string OWNER_PHONE
        {
            get { return ownerPhone; }
            set { ownerPhone = value.Trim(); }
        }

        /// <summary>
        /// Owner cell phone number
        /// </summary>
        public string ownerCelularNumber { get; set; }
        private string OWNER_CELLULAR_NUMBER
        {
            get { return ownerCelularNumber; }
            set { ownerCelularNumber = value.Trim(); }
        }

        /// <summary>
        /// Value to indicate if Viacheck app is installed in this location (1:Installed 0:Not installed)
        /// </summary>
        public string isViacheck { get; set; }
        private string IS_VIACHECK
        {
            get { return isViacheck; }
            set { isViacheck = value.Trim(); }
        }

        /// <summary>
        /// Date to indicate since when is Viacheck app was installed on this location
        /// </summary>
        public string dateIsViacheck { get; set; }
        private string DATE_IS_VIACHECK
        {
            get { return dateIsViacheck; }
            set { dateIsViacheck = value.Trim(); }
        }

        /// <summary>
        /// Month to date transaction count for Viacheck app
        /// </summary>
        public string mtdCountViacheck { get; set; }
        private string MTD_COUNT_VIACHECK
        {
            get { return mtdCountViacheck; }
            set { mtdCountViacheck = value.Trim(); }
        }

        /// <summary>
        /// Average transactions for Viacheck app
        /// </summary>
        public string avgCountViacheck { get; set; }
        private string AVG_COUNT_VIACHECK
        {
            get { return avgCountViacheck; }
            set { avgCountViacheck = value.Trim(); }
        }

        /// <summary>
        /// Number of transactions today for Viacheck app
        /// </summary>
        public string todayCountViacheck { get; set; }
        private string TODAY_COUNT_VIACHECK
        {
            get { return todayCountViacheck; }
            set { todayCountViacheck = value.Trim(); }
        }

        /// <summary>
        /// Quantity of transactions today for Viacheck app
        /// </summary>
        public string todayAmountViacheck { get; set; }
        private string TODAY_AMOUNT_VIACHECK
        {
            get { return todayAmountViacheck; }
            set { todayAmountViacheck = value.Trim(); }
        }

        /// <summary>
        /// Gross Profit today value for Viacheck app
        /// </summary>
        public string todayGPViacheck { get; set; }
        private string TODAY_GP_VIACHECK
        {
            get { return todayGPViacheck; }
            set { todayGPViacheck = value.Trim(); }
        }

        /// <summary>
        /// Value to indicate if Viasafe app is installed in this location (1:Installed 0:Not installed)
        /// </summary>
        public string isViasafe { get; set; }
        private string IS_VIASAFE
        {
            get { return isViasafe; }
            set { isViasafe = value.Trim(); }
        }

        /// <summary>
        /// Date to indicate since when Viasafe app was installed on this location
        /// </summary>
        public string dateIsViasafe { get; set; }
        private string DATE_IS_VIASAFE
        {
            get { return dateIsViasafe; }
            set { dateIsViasafe = value.Trim(); }
        }

        /// <summary>
        /// Month to date transaction count for Viasafe app
        /// </summary>
        public string mtdCountViasafe { get; set; }
        private string MTD_COUNT_VIASAFE
        {
            get { return mtdCountViasafe; }
            set { mtdCountViasafe = value.Trim(); }
        }

        /// <summary>
        /// Number of transactions today for Viasafe app
        /// </summary>
        public string todayCountViasafe { get; set; }
        private string TODAY_COUNT_VIASAFE
        {
            get { return todayCountViasafe; }
            set { todayCountViasafe = value.Trim(); }
        }

        /// <summary>
        /// Quantity of transactions today for ViaSafe app
        /// </summary>
        public string todayAmountViasafe { get; set; }
        private string TODAY_AMOUNT_VIASAFE
        {
            get { return todayAmountViasafe; }
            set { todayAmountViasafe = value.Trim(); }
        }

        /// <summary>
        /// Gross Profit today value for Viasafe app
        /// </summary>
        public string todayGPViasafe { get; set; }
        private string TODAY_GP_VIASAFE
        {
            get { return todayGPViasafe; }
            set { todayGPViasafe = value.Trim(); }
        }

        /// <summary>
        /// Value to indicate if Viatopups app is installed in this location (1:Installed 0:Not installed)
        /// </summary>
        public string isViaTopups { get; set; }
        private string IS_VIATOPUPS
        {
            get { return isViaTopups; }
            set { isViaTopups = value.Trim(); }
        }

        /// <summary>
        /// Date to indicate since when Topups app was installed on this location
        /// </summary>
        public string dateIsViatopups { get; set; }
        private string DATE_IS_VIATOPUPS
        {
            get { return dateIsViatopups; }
            set { dateIsViatopups = value.Trim(); }
        }

        /// <summary>
        /// Month to date transaction count for Topups app
        /// </summary>
        public string mtdCountViatopups { get; set; }
        private string MTD_COUNT_VIATOPUPS
        {
            get { return mtdCountViatopups; }
            set { mtdCountViatopups = value.Trim(); }
        }

        /// <summary>
        /// Average transactions for Topups app
        /// </summary>
        public string avgCountViatopups { get; set; }
        private string AVG_COUNT_VIATOPUPS
        {
            get { return avgCountViatopups; }
            set { avgCountViatopups = value.Trim(); }
        }

        /// <summary>
        /// Number of transactions today for Topups app
        /// </summary>
        public string todayCountViatopups { get; set; }
        private string TODAY_COUNT_VIATOPUPS
        {
            get { return todayCountViatopups; }
            set { todayCountViatopups = value.Trim(); }
        }

        /// <summary>
        /// Quantity of transactions today for Topups app
        /// </summary>
        public string todayAmountViatopups { get; set; }
        private string TODAY_AMOUNT_VIATOPUPS
        {
            get { return todayAmountViatopups; }
            set { todayAmountViatopups = value.Trim(); }
        }

        /// <summary>
        /// Gross Profit today value for Topups app
        /// </summary>
        public string todayGPViatopups { get; set; }
        private string TODAY_GP_VIATOPUPS
        {
            get { return todayGPViatopups; }
            set { todayGPViatopups = value.Trim(); }
        }

        /// <summary>
        /// Value to indicate if Viapay app is installed in this location (1:Installed 0:Not installed)
        /// </summary>
        public string isViapay { get; set; }
        private string IS_VIAPAY
        {
            get { return isViapay; }
            set { isViapay = value.Trim(); }
        }

        /// <summary>
        /// Date to indicate since when Viapay app was installed on this location
        /// </summary>
        public string dateIsViapay { get; set; }
        private string DATE_IS_VIAPAY
        {
            get { return dateIsViapay; }
            set { dateIsViapay = value.Trim(); }
        }

        /// <summary>
        /// Month to date transaction count for Viapay app
        /// </summary>
        public string mtdCountViapay { get; set; }
        private string MTD_COUNT_VIAPAY
        {
            get { return mtdCountViapay; }
            set { mtdCountViapay = value.Trim(); }
        }

        /// <summary>
        /// Average transactions for Viapay app
        /// </summary>
        public string avgCountViapay { get; set; }
        private string AVG_COUNT_VIAPAY
        {
            get { return avgCountViapay; }
            set { avgCountViapay = value.Trim(); }
        }

        /// <summary>
        /// Number of transactions today for Viapay app
        /// </summary>
        public string todayCountViapay { get; set; }
        private string TODAY_COUNT_VIAPAY
        {
            get { return todayCountViapay; }
            set { todayCountViapay = value.Trim(); }
        }

        /// <summary>
        /// Quantity of transactions today for Viapay app
        /// </summary>
        public string todayAmountViapay { get; set; }
        private string TODAY_AMOUNT_VIAPAY
        {
            get { return todayAmountViapay; }
            set { todayAmountViapay = value.Trim(); }
        }

        /// <summary>
        /// Gross Profit today value for Viapay app
        /// </summary>
        public string todayGPViapay { get; set; }
        private string TODAY_GP_VIAPAY
        {
            get { return todayGPViapay; }
            set { todayGPViapay = value.Trim(); }
        }

        /// <summary>
        /// Value to indicate if Money Orders app is installed in this location (1:Installed 0:Not installed)
        /// </summary>
        public string isMoneyOrders { get; set; }
        private string IS_MONEYORDERS
        {
            get { return isMoneyOrders; }
            set { isMoneyOrders = value.Trim(); }
        }

        /// <summary>
        /// Date to indicate since when Money Orders app was installed on this location
        /// </summary>
        public string dateIsMoneyOrders { get; set; }
        private string DATE_IS_MONEYORDERS
        {
            get { return dateIsMoneyOrders; }
            set { dateIsMoneyOrders = value.Trim(); }
        }

        /// <summary>
        /// Month to date transaction count for Money Orders app
        /// </summary>
        public string mtdCountMoneyOrders { get; set; }
        private string MTD_COUNT_MONEYORDERS
        {
            get { return mtdCountMoneyOrders; }
            set { mtdCountMoneyOrders = value.Trim(); }
        }

        /// <summary>
        /// Average transactions for Money Orders app
        /// </summary>
        public string avgCountMoneyOrders { get; set; }
        private string AVG_COUNT_MONEYORDERS
        {
            get { return avgCountMoneyOrders; }
            set { avgCountMoneyOrders = value.Trim(); }
        }

        /// <summary>
        /// Number of transactions today for Money Orders app
        /// </summary>
        public string todayCountMoneyOrders { get; set; }
        private string TODAY_COUNT_MONEYORDERS
        {
            get { return todayCountMoneyOrders; }
            set { todayCountMoneyOrders = value.Trim(); }
        }

        /// <summary>
        /// Quantity of transactions today for Money Orders app
        /// </summary>
        public string todayAmountMoneyOrders { get; set; }
        private string TODAY_AMOUNT_MONEYORDERS
        {
            get { return todayAmountMoneyOrders; }
            set { todayAmountMoneyOrders = value.Trim(); }
        }

        /// <summary>
        /// Gross Profit today value for Money Orders app
        /// </summary>
        public string todayGPMoneyOrders { get; set; }
        private string TODAY_GP_MONEYORDERS
        {
            get { return todayGPMoneyOrders; }
            set { todayGPMoneyOrders = value.Trim(); }
        }

        /// <summary>
        /// Value to indicate if Billpayment app is installed in this location (1:Installed 0:Not installed)
        /// </summary>
        public string isViabillpay { get; set; }
        private string IS_VIABILLPAY
        {
            get { return isViabillpay; }
            set { isViabillpay = value.Trim(); }
        }

        /// <summary>
        /// Date to indicate since when Viapay app was installed on this location
        /// </summary>
        public string dateIsViabillpay { get; set; }
        private string DATE_IS_VIABILLPAY
        {
            get { return dateIsViabillpay; }
            set { dateIsViabillpay = value.Trim(); }
        }

        /// <summary>
        /// Month to date transaction count for Billpayment app
        /// </summary>
        public string mtdCountViabillpay { get; set; }
        private string MTD_COUNT_VIABILLPAY
        {
            get { return mtdCountViabillpay; }
            set { mtdCountViabillpay = value.Trim(); }
        }

        /// <summary>
        /// Average transactions for BillPayment app
        /// </summary>
        public string avgCountViabillpay { get; set; }
        private string AVG_COUNT_VIABILLPAY
        {
            get { return avgCountViabillpay; }
            set { avgCountViabillpay = value.Trim(); }
        }

        /// <summary>
        /// Number of transactions today for BillPayment app
        /// </summary>
        public string todayCountViabillpay { get; set; }
        private string TODAY_COUNT_VIABILLPAY
        {
            get { return todayCountViabillpay; }
            set { todayCountViabillpay = value.Trim(); }
        }

        /// <summary>
        /// Quantity of transactions today for Billpayment app
        /// </summary>
        public string todayAmountViabillpay { get; set; }
        private string TODAY_AMOUNT_VIABILLPAY
        {
            get { return todayAmountViabillpay; }
            set { todayAmountViabillpay = value.Trim(); }
        }

        /// <summary>
        /// Gross Profit today value for Billpayment app
        /// </summary>
        public string todayGPViabillpay { get; set; }
        private string TODAY_GP_VIABILLPAY
        {
            get { return todayGPViabillpay; }
            set { todayGPViabillpay = value.Trim(); }
        }

        /// <summary>
        /// Value to indicate if ViaTasa app is installed in this location (1:Installed 0:Not installed)
        /// </summary>
        public string isViatasa { get; set; }
        private string IS_VIATASA
        {
            get { return isViatasa; }
            set { isViatasa = value.Trim(); }
        }

        /// <summary>
        /// Month to date transaction count for Viatasa app
        /// </summary>
        public string mtdCountViatasa { get; set; }
        private string MTD_COUNT_VIATASA
        {
            get { return mtdCountViatasa; }
            set { mtdCountViatasa = value.Trim(); }
        }

        /// <summary>
        /// Average transactions for Viatasa app
        /// </summary>
        public string avgCountViatasa { get; set; }
        private string AVG_COUNT_VIATASA
        {
            get { return avgCountViatasa; }
            set { avgCountViatasa = value.Trim(); }
        }

        /// <summary>
        /// Value to indicate if Viadeal app is installed in this location (1:Installed 0:Not installed)
        /// </summary>
        public string isViadeal { get; set; }
        private string IS_VIADEAL
        {
            get { return isViadeal; }
            set { isViadeal = value.Trim(); }
        }

        /// <summary>
        /// Date to indicate since when Viadeal app was installed on this location
        /// </summary>
        public string startDateIsViadeal { get; set; }
        private string START_DATE_IS_VIADEAL
        {
            get { return startDateIsViadeal; }
            set { startDateIsViadeal = value.Trim(); }
        }

        /// <summary>
        /// Date to indicate the last day of Viadeal app working on this location
        /// </summary>
        public string endDateIsViadeal { get; set; }
        private string END_DATE_IS_VIADEAL
        {
            get { return endDateIsViadeal; }
            set { endDateIsViadeal = value.Trim(); }
        }

        /// <summary>
        /// Forex trade level major payer                
        /// </summary>
        public string fxLevelMajorPayer { get; set; }
        private string FX_LEVEL_MAJOR_PAYER
        {
            get { return fxLevelMajorPayer; }
            set { fxLevelMajorPayer = value.Trim(); }
        }

        /// <summary>
        /// Hight water mark of location
        /// </summary>
        public string highWaterMark { get; set; }
        private string HIGH_WATER_MARK
        {
            get { return highWaterMark; }
            set { highWaterMark = value.Trim(); }
        }

        /// <summary>
        /// Performance of location
        /// </summary>
        public string performance { get; set; }
        //private string PERFORMANCE
        //{
        //    get { return performance; }
        //    set { performance = value.Trim(); }
        //}

        /// <summary>
        /// Days Oustanding. Time it takes for an agency to pay the balance at the current sales rate
        /// </summary>
        public string dso { get; set; }
        //private string DSO
        //{
        //    get { return dso; }
        //    set { dso = value.Trim(); }
        //}

        /// <summary>
        /// Debit limit value for location
        /// </summary>
        public string debtLimit { get; set; }
        private string DEBT_LIMIT
        {
            get { return debtLimit; }
            set { debtLimit = value.Trim(); }
        }

        /// <summary>
        /// Debit limit value for location in weekenc
        /// </summary>
        public string debtLimitWknd { get; set; }
        private string DEBT_LIMIT_WKND
        {
            get { return debtLimitWknd; }
            set { debtLimitWknd = value.Trim(); }
        }

        /// <summary>
        /// Balance of location
        /// </summary>
        public string balance { get; set; }
        //private string BALANCE
        //{
        //    get { return balance; }
        //    set { balance = value.Trim(); }
        //}

        /// <summary>
        /// Outstanding balance for location
        /// </summary>
        public string outstanding { get; set; }
        //private string OUTSTANDING
        //{
        //    get { return outstanding; }
        //    set { outstanding = value.Trim(); }
        //}

        /// <summary>
        /// Available amount
        /// </summary>
        public string available { get; set; }
        //private string AVAILABLE
        //{
        //    get { return available; }
        //    set { available = value.Trim(); }
        //}

        /// <summary>
        /// Phase code
        /// </summary>
        public int idPhase { get; set; }
        private int ID_PHASE
        {
            get { return idPhase; }
            set { idPhase = value; }
        }

        /// <summary>
        /// Phase description
        /// </summary>
        public string phaseDescription { get; set; }
        private string PHASE_DESCRIPTION
        {
            get { return phaseDescription; }
            set { phaseDescription = value.Trim(); }
        }

        /// <summary>
        /// Financial Status, internal classification
        /// </summary>
        public string finStatus { get; set; }
        private string FIN_STATUS
        {
            get { return finStatus; }
            set { finStatus = value.Trim(); }
        }

        /// <summary>
        /// Primary payment method of location
        /// </summary>
        public string primaryPaymentMethod { get; set; }
        private string PRIMARY_PAYMENT_METHOD
        {
            get { return primaryPaymentMethod; }
            set { primaryPaymentMethod = value.Trim(); }
        }

        /// <summary>
        /// Second payment method of location
        /// </summary>
        public string secondaryPaymentMethod { get; set; }
        private string SECONDARY_PAYMENT_METHOD
        {
            get { return secondaryPaymentMethod; }
            set { secondaryPaymentMethod = value.Trim(); }
        }

        /// <summary>
        /// Bank name
        /// </summary>
        public string bank { get; set; }
        //private string BANK
        //{
        //    get { return bank; }
        //    set { bank = value.Trim(); }
        //}

        /// <summary>
        /// Terms of use
        /// </summary>
        public string terms { get; set; }
        //private string TERMS
        //{
        //    get { return terms; }
        //    set { terms = value.Trim(); }
        //}

        /// <summary>
        /// Date to indicate the last day of inactivation on this location
        /// </summary>
        public string dateLastInactivation { get; set; }
        private string DATE_LAST_INACTIVATION
        {
            get { return dateLastInactivation; }
            set { dateLastInactivation = value.Trim(); }
        }

        /// <summary>
        /// Number of inactivation year to date
        /// </summary>
        public string numberInactivationYtd { get; set; }
        private string NUMBER_INACTIVATION_YTD
        {
            get { return numberInactivationYtd; }
            set { numberInactivationYtd = value.Trim(); }
        }

        /// <summary>
        /// Number of transactions in current week
        /// </summary>
        public string countCurrentWeek { get; set; }
        private string COUNT_CURRENT_WEEK
        {
            get { return countCurrentWeek; }
            set { countCurrentWeek = value.Trim(); }
        }

        /// <summary>
        /// Number of transactions last week
        /// </summary>
        public string countLastWeek { get; set; }
        private string COUNT_LAST_WEEK
        {
            get { return countLastWeek; }
            set { countLastWeek = value.Trim(); }
        }

        /// <summary>
        /// Number of transaction today
        /// </summary>
        public string countToday { get; set; }
        private string COUNT_TODAY
        {
            get { return countToday; }
            set { countToday = value.Trim(); }
        }

        /// <summary>
        /// Value of number of transactions at same day of last week
        /// </summary>
        public string countSamedayLw { get; set; }
        private string COUNT_SAMEDAY_LW
        {
            get { return countSamedayLw; }
            set { countSamedayLw = value.Trim(); }
        }

        /// <summary>
        /// Value of number of transactions yesterday
        /// </summary>
        public string countYesterday { get; set; }
        private string COUNT_YESTERDAY
        {
            get { return countYesterday; }
            set { countYesterday = value.Trim(); }
        }

        /// <summary>
        /// Count of total budget
        /// </summary>
        public string countTotalBudget { get; set; }
        private string COUNT_TOTAL_BUDGET
        {
            get { return countTotalBudget; }
            set { countTotalBudget = value.Trim(); }
        }

        /// <summary>
        /// Count of month to date total budget
        /// </summary>
        public string countMtdBudget { get; set; }
        private string COUNT_MTD_BUDGET
        {
            get { return countMtdBudget; }
            set { countMtdBudget = value.Trim(); }
        }

        /// <summary>
        /// Gross profit value current week
        /// </summary>
        public string gpCurrentWeek { get; set; }
        private string GP_CURRENT_WEEK
        {
            get { return gpCurrentWeek; }
            set { gpCurrentWeek = value.Trim(); }
        }

        /// <summary>
        /// Gross profit value last week
        /// </summary>
        public string gpLastWeek { get; set; }
        private string GP_LAST_WEEK
        {
            get { return gpLastWeek; }
            set { gpLastWeek = value.Trim(); }
        }

        /// <summary>
        /// Gross profit value today
        /// </summary>
        public string gpToday { get; set; }
        private string GP_TODAY
        {
            get { return gpToday; }
            set { gpToday = value.Trim(); }
        }

        /// <summary>
        /// Gross profit value same day of last week
        /// </summary>
        public string gpSamedayLw { get; set; }
        private string GP_SAMEDAY_LW
        {
            get { return gpSamedayLw; }
            set { gpSamedayLw = value.Trim(); }
        }

        /// <summary>
        /// Gross profit value yesterday
        /// </summary>
        public string gpYesterday { get; set; }
        private string GP_YESTERDAY
        {
            get { return gpYesterday; }
            set { gpYesterday = value.Trim(); }
        }

        /// <summary>
        /// Gross profit total budget
        /// </summary>
        public string gpTotalBudget { get; set; }
        private string GP_TOTAL_BUDGET
        {
            get { return gpTotalBudget; }
            set { gpTotalBudget = value.Trim(); }
        }

        /// <summary>
        /// Gross profit month to date budget
        /// </summary>
        public string gpMtdBudget { get; set; }
        private string GP_MTD_BUDGET
        {
            get { return gpMtdBudget; }
            set { gpMtdBudget = value.Trim(); }
        }

        /// <summary>
        /// Gross profit by transaction in current week
        /// </summary>
        public string mgpCurrentWeek { get; set; }
        private string mGP_CURRENT_WEEK
        {
            get { return mgpCurrentWeek; }
            set { mgpCurrentWeek = value.Trim(); }
        }

        /// <summary>
        /// Gross profit by transaction in last week
        /// </summary>
        public string mgpLastWeek { get; set; }
        private string mGP_LAST_WEEK
        {
            get { return mgpLastWeek; }
            set { mgpLastWeek = value.Trim(); }
        }

        /// <summary>
        /// Gross profit by transaction today
        /// </summary>
        public string mgpToday { get; set; }
        private string mGP_TODAY
        {
            get { return mgpToday; }
            set { mgpToday = value.Trim(); }
        }

        /// <summary>
        /// Gross profit by transaction in same day of week
        /// </summary>
        public string mgpSamedayLw { get; set; }
        private string mGP_SAMEDAY_LW
        {
            get { return mgpSamedayLw; }
            set { mgpSamedayLw = value.Trim(); }
        }

        /// <summary>
        /// Gross profit by transaction yesterday
        /// </summary>
        public string mgpYesterday { get; set; }
        private string mGP_YESTERDAY
        {
            get { return mgpYesterday; }
            set { mgpYesterday = value.Trim(); }
        }

        /// <summary>
        /// Amount for current week
        /// </summary>
        public string amountCurrentWeek { get; set; }
        private string AMOUNT_CURRENT_WEEK
        {
            get { return amountCurrentWeek; }
            set { amountCurrentWeek = value.Trim(); }
        }

        /// <summary>
        /// Amount last week
        /// </summary>
        public string amountLastweek { get; set; }
        private string AMOUNT_LAST_WEEK
        {
            get { return amountLastweek; }
            set { amountLastweek = value.Trim(); }
        }

        /// <summary>
        /// Amount today
        /// </summary>
        public string amountToday { get; set; }
        private string AMOUNT_TODAY
        {
            get { return amountToday; }
            set { amountToday = value.Trim(); }
        }

        /// <summary>
        /// Amount same day of last week
        /// </summary>
        public string amountSamedayLw { get; set; }
        private string AMOUNT_SAMEDAY_LW
        {
            get { return amountSamedayLw; }
            set { amountSamedayLw = value.Trim(); }
        }

        /// <summary>
        /// Amount yesterday
        /// </summary>
        public string amountYesterday { get; set; }
        private string AMOUNT_YESTERDAY
        {
            get { return amountYesterday; }
            set { amountYesterday = value.Trim(); }
        }

        /// <summary>
        /// Latitude of location
        /// </summary>
        public string latitude { get; set; }
        private string LATITUDE
        {
            get { return latitude; }
            set { latitude = value.Trim(); }
        }

        /// <summary>
        /// Longitude of location
        /// </summary>
        public string longitude { get; set; }
        private string LONGITUDE
        {
            get { return longitude; }
            set { longitude = value.Trim(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string finClosingDay { get; set; }
        private string FIN_CLOSING_DAY
        {
            get { return finClosingDay; }
            set { finClosingDay = value.Trim(); }
        }

        /// <summary>
        /// Day of the last agent visit
        /// </summary>
        public string daysLastVisit { get; set; }
        private string DAYS_LAST_VISIT
        {
            get { return daysLastVisit; }
            set { daysLastVisit = value.Trim(); }
        }

        /// <summary>
        /// Day of the last agent call
        /// </summary>
        public string daysLastCall { get; set; }
        private string DAYS_LAST_CALL
        {
            get { return daysLastCall; }
            set { daysLastCall = value.Trim(); }
        }

        /// <summary>
        /// Date agreement
        /// </summary>
        public string dateAgreement { get; set; }
        private string DATE_AGREEMENT
        {
            get { return dateAgreement; }
            set { dateAgreement = value.Trim(); }
        }

        /// <summary>
        /// Payment agreement
        /// </summary>
        public string paymentAgreement { get; set; }
        private string PAYMENT_AGREEMENT
        {
            get { return paymentAgreement; }
            set { paymentAgreement = value.Trim(); }
        }

        /// <summary>
        /// Payments made
        /// </summary>
        public string paymentsMade { get; set; }
        private string PAYMENTS_MADE
        {
            get { return paymentsMade; }
            set { paymentsMade = value.Trim(); }
        }

        /// <summary>
        /// Payment agreement balance
        /// </summary>
        public string paymentAgreementBalance { get; set; }
        private string PAYMENT_AGREEMENT_BALANCE
        {
            get { return paymentAgreementBalance; }
            set { paymentAgreementBalance = value.Trim(); }
        }

        /// <summary>
        /// Last change
        /// </summary>
        public string lastChange { get; set; }
        private string LAST_CHANGE
        {
            get { return lastChange; }
            set { lastChange = value.Trim(); }
        }

        /// <summary>
        /// Flag to indicate if the location is synchronized (1:not synchronized 0:synchronized)
        /// </summary>
        public string synchronize { get; set; }
        private string SYNCHONIZE
        {
            get { return synchronize; }
            set { synchronize = value.Trim(); }
        }

    }

    public class LocationSynch
    {
        public string message { get; set; }
        private string Message
        {
            get { return message; }
            set { message = value.Trim(); }
        }

    }
}
