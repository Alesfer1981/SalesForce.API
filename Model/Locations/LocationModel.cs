using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Locations
{
    public class LocationModel
    {
        public string id { get; set; }
        //private string ID_LOCATION
        //{
        //    get { return idLocation; }
        //    set { idLocation = value.Trim(); }
        //}

        public string idGroupCompany { get; set; }
        private string ID_GROUP_COMPANY
        {
            get { return idGroupCompany; }
            set { idGroupCompany = value.Trim(); }
        }

        public string branches { get; set; }
        //private string BRANCHES
        //{
        //    get { return branches; }
        //    set { branches = value.Trim(); }
        //}

        public string type { get; set; }
        //private string TYPE
        //{
        //    get { return type; }
        //    set { type = value.Trim(); }
        //}

        public string creationDate { get; set; }
        private string CREATION_DATE
        {
            get { return creationDate; }
            set { creationDate = value.Trim(); }
        }

        public string daysOpen { get; set; }
        private string DAYS_OPEN
        {
            get { return daysOpen; }
            set { daysOpen = value.Trim(); }
        }

        public string companyName { get; set; }
        private string COMPANY_NAME
        {
            get { return companyName; }
            set { companyName = value.Trim(); }
        }

        public string groupCompany { get; set; }
        private string GROUP_COMPANY
        {
            get { return groupCompany; }
            set { groupCompany = value.Trim(); }
        }

        public string name { get; set; }
        //private string NAME
        //{
        //    get { return name; }
        //    set { name = value.Trim(); }
        //}

        public string status { get; set; }
        //private string STATUS
        //{
        //    get { return status; }
        //    set { status = value.Trim(); }
        //}

        public string extendedStatus { get; set; }
        private string EXTENDED_STATUS
        {
            get { return extendedStatus; }
            set { extendedStatus = value.Trim(); }
        }

        public string city { get; set; }
        //private string CITY
        //{
        //    get { return city; }
        //    set { city = value.Trim(); }
        //}

        public string state { get; set; }
        //private string STATE
        //{
        //    get { return state; }
        //    set { state = value.Trim(); }
        //}

        public string zone { get; set; }
        //private string ZONE
        //{
        //    get { return zone; }
        //    set { zone = value.Trim(); }
        //}

        public string salesRepresentative { get; set; }
        private string SALES_REPRESENTATIVE
        {
            get { return salesRepresentative; }
            set { salesRepresentative = value.Trim(); }
        }

        public string idSalesRepresentative { get; set; }
        private string ID_SALES_REPRESENTATIVE
        {
            get { return idSalesRepresentative; }
            set { idSalesRepresentative = value.Trim(); }
        }

        public string manager { get; set; }
        //private string MANAGER
        //{
        //    get { return manager; }
        //    set { manager = value.Trim(); }
        //}

        public string address { get; set; }
        //private string ADDRESS
        //{
        //    get { return address; }
        //    set { address = value.Trim(); }
        //}

        public string zip { get; set; }
        //private string ZIP
        //{
        //    get { return zip; }
        //    set { zip = value.Trim(); }
        //}

        public string phone1 { get; set; }
        //private string PHONE1
        //{
        //    get { return phone1; }
        //    set { phone1 = value.Trim(); }
        //}

        public string phone2 { get; set; }
        //private string PHONE2
        //{
        //    get { return phone2; }
        //    set { phone2 = value.Trim(); }
        //}

        public string fax { get; set; }
        //private string FAX
        //{
        //    get { return fax; }
        //    set { fax = value.Trim(); }
        //}

        public string instalationType { get; set; }
        private string INSTALLATION_TYPE
        {
            get { return instalationType; }
            set { instalationType = value.Trim(); }
        }

        public string insideSales { get; set; }
        private string INSIDE_SALES
        {
            get { return insideSales; }
            set { insideSales = value.Trim(); }
        }

        public string ownerName { get; set; }
        private string OWNER_NAME
        {
            get { return ownerName; }
            set { ownerName = value.Trim(); }
        }

        public string ownerPhone { get; set; }
        private string OWNER_PHONE
        {
            get { return ownerPhone; }
            set { ownerPhone = value.Trim(); }
        }

        public string ownerCelularNumber { get; set; }
        private string OWNER_CELLULAR_NUMBER
        {
            get { return ownerCelularNumber; }
            set { ownerCelularNumber = value.Trim(); }
        }

        public string isViacheck { get; set; }
        private string IS_VIACHECK
        {
            get { return isViacheck; }
            set { isViacheck = value.Trim(); }
        }

        public string dateIsViacheck { get; set; }
        private string DATE_IS_VIACHECK
        {
            get { return dateIsViacheck; }
            set { dateIsViacheck = value.Trim(); }
        }

        public string mtdCountViacheck { get; set; }
        private string MTD_COUNT_VIACHECK
        {
            get { return mtdCountViacheck; }
            set { mtdCountViacheck = value.Trim(); }
        }

        public string avgCountViacheck { get; set; }
        private string AVG_COUNT_VIACHECK
        {
            get { return avgCountViacheck; }
            set { avgCountViacheck = value.Trim(); }
        }

        public string todayCountViacheck { get; set; }
        private string TODAY_COUNT_VIACHECK
        {
            get { return todayCountViacheck; }
            set { todayCountViacheck = value.Trim(); }
        }

        public string todayAmountViacheck { get; set; }
        private string TODAY_AMOUNT_VIACHECK
        {
            get { return todayAmountViacheck; }
            set { todayAmountViacheck = value.Trim(); }
        }

        public string todayGPViacheck { get; set; }
        private string TODAY_GP_VIACHECK
        {
            get { return todayGPViacheck; }
            set { todayGPViacheck = value.Trim(); }
        }

        public string isViasafe { get; set; }
        private string IS_VIASAFE
        {
            get { return isViasafe; }
            set { isViasafe = value.Trim(); }
        }

        public string dateIsViasafe { get; set; }
        private string DATE_IS_VIASAFE
        {
            get { return dateIsViasafe; }
            set { dateIsViasafe = value.Trim(); }
        }

        public string mtdCountViasafe { get; set; }
        private string MTD_COUNT_VIASAFE
        {
            get { return mtdCountViasafe; }
            set { mtdCountViasafe = value.Trim(); }
        }

        public string todayCountViasafe { get; set; }
        private string TODAY_COUNT_VIASAFE
        {
            get { return todayCountViasafe; }
            set { todayCountViasafe = value.Trim(); }
        }

        public string todayAmountViasafe { get; set; }
        private string TODAY_AMOUNT_VIASAFE
        {
            get { return todayAmountViasafe; }
            set { todayAmountViasafe = value.Trim(); }
        }

        public string todayGPViasafe { get; set; }
        private string TODAY_GP_VIASAFE
        {
            get { return todayGPViasafe; }
            set { todayGPViasafe = value.Trim(); }
        }

        public string isViaTopups { get; set; }
        private string IS_VIATOPUPS
        {
            get { return isViaTopups; }
            set { isViaTopups = value.Trim(); }
        }

        public string dateIsViatopups { get; set; }
        private string DATE_IS_VIATOPUPS
        {
            get { return dateIsViatopups; }
            set { dateIsViatopups = value.Trim(); }
        }

        public string mtdCountViatopups { get; set; }
        private string MTD_COUNT_VIATOPUPS
        {
            get { return mtdCountViatopups; }
            set { mtdCountViatopups = value.Trim(); }
        }

        public string avgCountViatopups { get; set; }
        private string AVG_COUNT_VIATOPUPS
        {
            get { return avgCountViatopups; }
            set { avgCountViatopups = value.Trim(); }
        }

        public string todayCountViatopups { get; set; }
        private string TODAY_COUNT_VIATOPUPS
        {
            get { return todayCountViatopups; }
            set { todayCountViatopups = value.Trim(); }
        }

        public string todayAmountViatopups { get; set; }
        private string TODAY_AMOUNT_VIATOPUPS
        {
            get { return todayAmountViatopups; }
            set { todayAmountViatopups = value.Trim(); }
        }

        public string todayGPViatopups { get; set; }
        private string TODAY_GP_VIATOPUPS
        {
            get { return todayGPViatopups; }
            set { todayGPViatopups = value.Trim(); }
        }

        public string isViapay { get; set; }
        private string IS_VIAPAY
        {
            get { return isViapay; }
            set { isViapay = value.Trim(); }
        }

        public string dateIsViapay { get; set; }
        private string DATE_IS_VIAPAY
        {
            get { return dateIsViapay; }
            set { dateIsViapay = value.Trim(); }
        }

        public string mtdCountViapay { get; set; }
        private string MTD_COUNT_VIAPAY
        {
            get { return mtdCountViapay; }
            set { mtdCountViapay = value.Trim(); }
        }

        public string avgCountViapay { get; set; }
        private string AVG_COUNT_VIAPAY
        {
            get { return avgCountViapay; }
            set { avgCountViapay = value.Trim(); }
        }

        public string todayCountViapay { get; set; }
        private string TODAY_COUNT_VIAPAY
        {
            get { return todayCountViapay; }
            set { todayCountViapay = value.Trim(); }
        }

        public string todayAmountViapay { get; set; }
        private string TODAY_AMOUNT_VIAPAY
        {
            get { return todayAmountViapay; }
            set { todayAmountViapay = value.Trim(); }
        }

        public string todayGPViapay { get; set; }
        private string TODAY_GP_VIAPAY
        {
            get { return todayGPViapay; }
            set { todayGPViapay = value.Trim(); }
        }

        public string isMoneyOrders { get; set; }
        private string IS_MONEYORDERS
        {
            get { return isMoneyOrders; }
            set { isMoneyOrders = value.Trim(); }
        }

        public string dateIsMoneyOrders { get; set; }
        private string DATE_IS_MONEYORDERS
        {
            get { return dateIsMoneyOrders; }
            set { dateIsMoneyOrders = value.Trim(); }
        }

        public string mtdCountMoneyOrders { get; set; }
        private string MTD_COUNT_MONEYORDERS
        {
            get { return mtdCountMoneyOrders; }
            set { mtdCountMoneyOrders = value.Trim(); }
        }

        public string avgCountMoneyOrders { get; set; }
        private string AVG_COUNT_MONEYORDERS
        {
            get { return avgCountMoneyOrders; }
            set { avgCountMoneyOrders = value.Trim(); }
        }

        public string todayCountMoneyOrders { get; set; }
        private string TODAY_COUNT_MONEYORDERS
        {
            get { return todayCountMoneyOrders; }
            set { todayCountMoneyOrders = value.Trim(); }
        }

        public string todayAmountMoneyOrders { get; set; }
        private string TODAY_AMOUNT_MONEYORDERS
        {
            get { return todayAmountMoneyOrders; }
            set { todayAmountMoneyOrders = value.Trim(); }
        }

        public string todayGPMoneyOrders { get; set; }
        private string TODAY_GP_MONEYORDERS
        {
            get { return todayGPMoneyOrders; }
            set { todayGPMoneyOrders = value.Trim(); }
        }

        public string isViabillpay { get; set; }
        private string IS_VIABILLPAY
        {
            get { return isViabillpay; }
            set { isViabillpay = value.Trim(); }
        }

        public string dateIsViabillpay { get; set; }
        private string DATE_IS_VIABILLPAY
        {
            get { return dateIsViabillpay; }
            set { dateIsViabillpay = value.Trim(); }
        }

        public string mtdCountViabillpay { get; set; }
        private string MTD_COUNT_VIABILLPAY
        {
            get { return mtdCountViabillpay; }
            set { mtdCountViabillpay = value.Trim(); }
        }

        public string avgCountViabillpay { get; set; }
        private string AVG_COUNT_VIABILLPAY
        {
            get { return avgCountViabillpay; }
            set { avgCountViabillpay = value.Trim(); }
        }

        public string todayCountViabillpay { get; set; }
        private string TODAY_COUNT_VIABILLPAY
        {
            get { return todayCountViabillpay; }
            set { todayCountViabillpay = value.Trim(); }
        }

        public string todayAmountViabillpay { get; set; }
        private string TODAY_AMOUNT_VIABILLPAY
        {
            get { return todayAmountViabillpay; }
            set { todayAmountViabillpay = value.Trim(); }
        }

        public string todayGPViabillpay { get; set; }
        private string TODAY_GP_VIABILLPAY
        {
            get { return todayGPViabillpay; }
            set { todayGPViabillpay = value.Trim(); }
        }

        public string isViatasa { get; set; }
        private string IS_VIATASA
        {
            get { return isViatasa; }
            set { isViatasa = value.Trim(); }
        }

        public string mtdCountViatasa { get; set; }
        private string MTD_COUNT_VIATASA
        {
            get { return mtdCountViatasa; }
            set { mtdCountViatasa = value.Trim(); }
        }

        public string avgCountViatasa { get; set; }
        private string AVG_COUNT_VIATASA
        {
            get { return avgCountViatasa; }
            set { avgCountViatasa = value.Trim(); }
        }

        public string isViadeal { get; set; }
        private string IS_VIADEAL
        {
            get { return isViadeal; }
            set { isViadeal = value.Trim(); }
        }

        public string startDateIsViadeal { get; set; }
        private string START_DATE_IS_VIADEAL
        {
            get { return startDateIsViadeal; }
            set { startDateIsViadeal = value.Trim(); }
        }

        public string endDateIsViadeal { get; set; }
        private string END_DATE_IS_VIADEAL
        {
            get { return endDateIsViadeal; }
            set { endDateIsViadeal = value.Trim(); }
        }

        public string fxLevelMajorPayer { get; set; }
        private string FX_LEVEL_MAJOR_PAYER
        {
            get { return fxLevelMajorPayer; }
            set { fxLevelMajorPayer = value.Trim(); }
        }

        public string highWaterMark { get; set; }
        private string HIGH_WATER_MARK
        {
            get { return highWaterMark; }
            set { highWaterMark = value.Trim(); }
        }

        public string performance { get; set; }
        //private string PERFORMANCE
        //{
        //    get { return performance; }
        //    set { performance = value.Trim(); }
        //}

        public string dso { get; set; }
        //private string DSO
        //{
        //    get { return dso; }
        //    set { dso = value.Trim(); }
        //}

        public string debtLimit { get; set; }
        private string DEBT_LIMIT
        {
            get { return debtLimit; }
            set { debtLimit = value.Trim(); }
        }

        public string debtLimitWknd { get; set; }
        private string DEBT_LIMIT_WKND
        {
            get { return debtLimitWknd; }
            set { debtLimitWknd = value.Trim(); }
        }

        public string balance { get; set; }
        //private string BALANCE
        //{
        //    get { return balance; }
        //    set { balance = value.Trim(); }
        //}

        public string outstanding { get; set; }
        //private string OUTSTANDING
        //{
        //    get { return outstanding; }
        //    set { outstanding = value.Trim(); }
        //}

        public string available { get; set; }
        //private string AVAILABLE
        //{
        //    get { return available; }
        //    set { available = value.Trim(); }
        //}

        public string finStatus { get; set; }
        private string FIN_STATUS
        {
            get { return finStatus; }
            set { finStatus = value.Trim(); }
        }

        public string primaryPaymentMethod { get; set; }
        private string PRIMARY_PAYMENT_METHOD
        {
            get { return primaryPaymentMethod; }
            set { primaryPaymentMethod = value.Trim(); }
        }

        public string secondaryPaymentMethod { get; set; }
        private string SECONDARY_PAYMENT_METHOD
        {
            get { return secondaryPaymentMethod; }
            set { secondaryPaymentMethod = value.Trim(); }
        }

        public string bank { get; set; }
        //private string BANK
        //{
        //    get { return bank; }
        //    set { bank = value.Trim(); }
        //}

        public string terms { get; set; }
        //private string TERMS
        //{
        //    get { return terms; }
        //    set { terms = value.Trim(); }
        //}

        public string dateLastInactivation { get; set; }
        private string DATE_LAST_INACTIVATION
        {
            get { return dateLastInactivation; }
            set { dateLastInactivation = value.Trim(); }
        }

        public string numberInactivationYtd { get; set; }
        private string NUMBER_INACTIVATION_YTD
        {
            get { return numberInactivationYtd; }
            set { numberInactivationYtd = value.Trim(); }
        }

        public string countCurrentWeek { get; set; }
        private string COUNT_CURRENT_WEEK
        {
            get { return countCurrentWeek; }
            set { countCurrentWeek = value.Trim(); }
        }

        public string countLastWeek { get; set; }
        private string COUNT_LAST_WEEK
        {
            get { return countLastWeek; }
            set { countLastWeek = value.Trim(); }
        }

        public string countToday { get; set; }
        private string COUNT_TODAY
        {
            get { return countToday; }
            set { countToday = value.Trim(); }
        }

        public string countSamedayLw { get; set; }
        private string COUNT_SAMEDAY_LW
        {
            get { return countSamedayLw; }
            set { countSamedayLw = value.Trim(); }
        }

        public string countYesterday { get; set; }
        private string COUNT_YESTERDAY
        {
            get { return countYesterday; }
            set { countYesterday = value.Trim(); }
        }

        public string countTotalBudget { get; set; }
        private string COUNT_TOTAL_BUDGET
        {
            get { return countTotalBudget; }
            set { countTotalBudget = value.Trim(); }
        }

        public string countMtdBudget { get; set; }
        private string COUNT_MTD_BUDGET
        {
            get { return countMtdBudget; }
            set { countMtdBudget = value.Trim(); }
        }

        public string gpCurrentWeek { get; set; }
        private string GP_CURRENT_WEEK
        {
            get { return gpCurrentWeek; }
            set { gpCurrentWeek = value.Trim(); }
        }

        public string gpLastWeek { get; set; }
        private string GP_LAST_WEEK
        {
            get { return gpLastWeek; }
            set { gpLastWeek = value.Trim(); }
        }

        public string gpToday { get; set; }
        private string GP_TODAY
        {
            get { return gpToday; }
            set { gpToday = value.Trim(); }
        }

        public string gpSamedayLw { get; set; }
        private string GP_SAMEDAY_LW
        {
            get { return gpSamedayLw; }
            set { gpSamedayLw = value.Trim(); }
        }
        public string gpYesterday { get; set; }
        private string GP_YESTERDAY
        {
            get { return gpYesterday; }
            set { gpYesterday = value.Trim(); }
        }
        public string gpTotalBudget { get; set; }
        private string GP_TOTAL_BUDGET
        {
            get { return gpTotalBudget; }
            set { gpTotalBudget = value.Trim(); }
        }
        public string gpMtdBudget { get; set; }
        private string GP_MTD_BUDGET
        {
            get { return gpMtdBudget; }
            set { gpMtdBudget = value.Trim(); }
        }
        public string mgpCurrentWeek { get; set; }
        private string mGP_CURRENT_WEEK
        {
            get { return mgpCurrentWeek; }
            set { mgpCurrentWeek = value.Trim(); }
        }
        public string mgpLastWeek { get; set; }
        private string mGP_LAST_WEEK
        {
            get { return mgpLastWeek; }
            set { mgpLastWeek = value.Trim(); }
        }
        public string mgpToday { get; set; }
        private string mGP_TODAY
        {
            get { return mgpToday; }
            set { mgpToday = value.Trim(); }
        }
        public string mgpSamedayLw { get; set; }
        private string mGP_SAMEDAY_LW
        {
            get { return mgpSamedayLw; }
            set { mgpSamedayLw = value.Trim(); }
        }
        public string mgpYesterday { get; set; }
        private string mGP_YESTERDAY
        {
            get { return mgpYesterday; }
            set { mgpYesterday = value.Trim(); }
        }
        public string amountCurrentWeek { get; set; }
        private string AMOUNT_CURRENT_WEEK
        {
            get { return amountCurrentWeek; }
            set { amountCurrentWeek = value.Trim(); }
        }
        public string amountLastweek { get; set; }
        private string AMOUNT_LAST_WEEK
        {
            get { return amountLastweek; }
            set { amountLastweek = value.Trim(); }
        }
        public string amountToday { get; set; }
        private string AMOUNT_TODAY
        {
            get { return amountToday; }
            set { amountToday = value.Trim(); }
        }

        public string amountSamedayLw { get; set; }
        private string AMOUNT_SAMEDAY_LW
        {
            get { return amountSamedayLw; }
            set { amountSamedayLw = value.Trim(); }
        }
        public string amountYesterday { get; set; }
        private string AMOUNT_YESTERDAY
        {
            get { return amountYesterday; }
            set { amountYesterday = value.Trim(); }
        }
        public string latitude { get; set; }
        private string LATITUDE
        {
            get { return latitude; }
            set { latitude = value.Trim(); }
        }
        public string longitude { get; set; }
        private string LONGITUDE
        {
            get { return longitude; }
            set { longitude = value.Trim(); }
        }

        public string finClosingDay { get; set; }
        private string FIN_CLOSING_DAY
        {
            get { return finClosingDay; }
            set { finClosingDay = value.Trim(); }
        }
        public string daysLastVisit { get; set; }
        private string DAYS_LAST_VISIT
        {
            get { return daysLastVisit; }
            set { daysLastVisit = value.Trim(); }
        }
        public string daysLastCall { get; set; }
        private string DAYS_LAST_CALL
        {
            get { return daysLastCall; }
            set { daysLastCall = value.Trim(); }
        }
        public string dateAgreement { get; set; }
        private string DATE_AGREEMENT
        {
            get { return dateAgreement; }
            set { dateAgreement = value.Trim(); }
        }

        public string paymentAgreement { get; set; }
        private string PAYMENT_AGREEMENT
        {
            get { return paymentAgreement; }
            set { paymentAgreement = value.Trim(); }
        }
        public string paymentsMade { get; set; }
        private string PAYMENTS_MADE
        {
            get { return paymentsMade; }
            set { paymentsMade = value.Trim(); }
        }
        public string paymentAgreementBalance { get; set; }
        private string PAYMENT_AGREEMENT_BALANCE
        {
            get { return paymentAgreementBalance; }
            set { paymentAgreementBalance = value.Trim(); }
        }

        public string lastChange { get; set; }

        private string LAST_CHANGE
        {
            get { return lastChange; }
            set { lastChange = value.Trim(); }
        }

        public string synchronize { get; set; }

        private string SYNCHONIZE
        {
            get { return synchronize; }
            set { synchronize = value.Trim(); }
        }

    }
}
