using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Locations
{
    public class ResumeData
    {
        /// <summary>
        /// Location Code
        /// </summary>
        public string idLocation { get; set; }
        private string ID_LOCATION
        {
            get { return idLocation; }
            set { idLocation = value.Trim(); }
        }

        /// <summary>
        /// Dso value
        /// </summary>
        public string dso { get; set; }
        //private string DSO
        //{
        //    get { return dso; }
        //    set { dso = value.Trim(); }
        //}

        /// <summary>
        /// Current past due
        /// </summary>
        public string currentPastDue { get; set; }
        private string CURRENT_PASTDUE
        {
            get { return currentPastDue; }
            set { currentPastDue = value.Trim(); }
        }

        /// <summary>
        /// Average of days in zero balance
        /// </summary>
        public string avgDaysZeroBalance { get; set; }
        private string AVG_DAYS_ZERO_BALANCE
        {
            get { return avgDaysZeroBalance; }
            set { avgDaysZeroBalance = value.Trim(); }
        }

        /// <summary>
        /// Date of last inactivation
        /// </summary>
        public string dateLastInactivation { get; set; }
        private string DATE_LAST_INACTIVATION
        {
            get { return dateLastInactivation; }
            set { dateLastInactivation = value.Trim(); }
        }

        /// <summary>
        /// Number of inactivations 
        /// </summary>
        public string inactivationsCount { get; set; }
        private string INACTIVATIONS_COUNT
        {
            get { return inactivationsCount; }
            set { inactivationsCount = value.Trim(); }
        }

        /// <summary>
        /// Average of days inactive
        /// </summary>
        public string avgDaysInactive { get; set; }
        private string AVG_DAYS_INACTIVE
        {
            get { return avgDaysInactive; }
            set { avgDaysInactive = value.Trim(); }
        }

        /// <summary>
        /// Mean days inactive
        /// </summary>
        public string meanDaysInactive { get; set; }
        private string MEAN_DAYS_INACTIVE
        {
            get { return meanDaysInactive; }
            set { meanDaysInactive = value.Trim(); }
        }

        /// <summary>
        /// Date from viacheck activated product
        /// </summary>
        public string dateIsViacheck { get; set; }
        private string DATE_IS_VIACHECK
        {
            get { return dateIsViacheck; }
            set { dateIsViacheck = value.Trim(); }
        }

        /// <summary>
        /// Month to day value for viacheck transactions
        /// </summary>
        public string mtdCountViacheck { get; set; }
        private string MTD_COUNT_VIACHECK
        {
            get { return mtdCountViacheck; }
            set { mtdCountViacheck = value.Trim(); }
        }

        /// <summary>
        /// Average value for Viacheck transactions
        /// </summary>
        public string avgCountViacheck { get; set; }
        private string AVG_COUNT_VIACHECK
        {
            get { return avgCountViacheck; }
            set { avgCountViacheck = value.Trim(); }
        }

        /// <summary>
        /// Today number of Viacheck transactions
        /// </summary>
        public string todayCountViacheck { get; set; }
        private string TODAY_COUNT_VIACHECK
        {
            get { return todayCountViacheck; }
            set { todayCountViacheck = value.Trim(); }
        }

        /// <summary>
        /// Today value of viacheck transactions
        /// </summary>
        public string todayAmountViacheck { get; set; }
        private string TODAY_AMOUNT_VIACHECK
        {
            get { return todayAmountViacheck; }
            set { todayAmountViacheck = value.Trim(); }
        }


        //public string isViasafe { get; set; }
        //private string IS_VIASAFE
        //{
        //    get { return isViasafe; }
        //    set { isViasafe = value.Trim(); }
        //}

        //public string dateIsViasafe { get; set; }
        //private string DATE_IS_VIASAFE
        //{
        //    get { return dateIsViasafe; }
        //    set { dateIsViasafe = value.Trim(); }
        //}

        /// <summary>
        /// Month to day value for Viasafe transactions
        /// </summary>
        public string mtdCountViasafe { get; set; }
        private string MTD_COUNT_VIASAFE
        {
            get { return mtdCountViasafe; }
            set { mtdCountViasafe = value.Trim(); }
        }

        /// <summary>
        /// Average value for Viasafe transactions
        /// </summary>
        public string avgCountViasafe { get; set; }
        private string AVG_COUNT_VIASAFE
        {
            get { return mtdCountViasafe; }
            set { mtdCountViasafe = value.Trim(); }
        }

        /// <summary>
        /// Today number of Viasafe transactions
        /// </summary>
        public string todayCountViasafe { get; set; }
        private string TODAY_COUNT_VIASAFE
        {
            get { return todayCountViasafe; }
            set { todayCountViasafe = value.Trim(); }
        }

        /// <summary>
        /// Today value of Viasafe transactions
        /// </summary>
        public string todayAmountViasafe { get; set; }
        private string TODAY_AMOUNT_VIASAFE
        {
            get { return todayAmountViasafe; }
            set { todayAmountViasafe = value.Trim(); }
        }

        //public string todayGPViasafe { get; set; }
        //private string TODAY_GP_VIASAFE
        //{
        //    get { return todayGPViasafe; }
        //    set { todayGPViasafe = value.Trim(); }
        //}


        //public string isViaTopups { get; set; }
        //private string IS_VIATOPUPS
        //{
        //    get { return isViaTopups; }
        //    set { isViaTopups = value.Trim(); }
        //}

        //public string dateIdViatopups { get; set; }
        //private string DATE_IS_VIATOPUPS
        //{
        //    get { return dateIdViatopups; }
        //    set { dateIdViatopups = value.Trim(); }
        //}


        /// <summary>
        /// Month to day value for topups transactions
        /// </summary>
        public string mtdCountTopups { get; set; }
        private string MTD_COUNT_TOPUPS
        {
            get { return mtdCountTopups; }
            set { mtdCountTopups = value.Trim(); }
        }

        /// <summary>
        /// Average value for topups transactions
        /// </summary>
        public string avgCountTopups { get; set; }
        private string AVG_COUNT_TOPUPS
        {
            get { return avgCountTopups; }
            set { avgCountTopups = value.Trim(); }
        }

        /// <summary>
        /// Today number of topups transactions
        /// </summary>
        public string todayCountTopups { get; set; }
        private string TODAY_COUNT_TOPUPS
        {
            get { return todayCountTopups; }
            set { todayCountTopups = value.Trim(); }
        }

        /// <summary>
        /// Today value of topups transactions
        /// </summary>
        public string todayAmountTopups { get; set; }
        private string TODAY_AMOUNT_TOPUPS
        {
            get { return todayAmountTopups; }
            set { todayAmountTopups = value.Trim(); }
        }

        //public string todayGPViatopups { get; set; }
        //private string TODAY_GP_VIATOPUPS
        //{
        //    get { return todayGPViatopups; }
        //    set { todayGPViatopups = value.Trim(); }
        //}


        //public string isMoneyOrders { get; set; }
        //private string IS_MONEYORDERS
        //{
        //    get { return isMoneyOrders; }
        //    set { isMoneyOrders = value.Trim(); }
        //}

        //public string dateIsMoneyOrders { get; set; }
        //private string DATE_IS_MONEYORDERS
        //{
        //    get { return dateIsMoneyOrders; }
        //    set { dateIsMoneyOrders = value.Trim(); }
        //}

        /// <summary>
        /// Month to day value for Money Orders transactions
        /// </summary>
        public string mtdCountMoneyOrders { get; set; }
        private string MTD_COUNT_MONEYORDERS
        {
            get { return mtdCountMoneyOrders; }
            set { mtdCountMoneyOrders = value.Trim(); }
        }

        /// <summary>
        /// Average value for Money Orders transactions
        /// </summary>
        public string avgCountMoneyOrders { get; set; }
        private string AVG_COUNT_MONEYORDERS
        {
            get { return avgCountMoneyOrders; }
            set { avgCountMoneyOrders = value.Trim(); }
        }

        /// <summary>
        /// Today number of Money Orders transactions
        /// </summary>
        public string todayCountMoneyOrders { get; set; }
        private string TODAY_COUNT_MONEYORDERS
        {
            get { return todayCountMoneyOrders; }
            set { todayCountMoneyOrders = value.Trim(); }
        }

        /// <summary>
        /// Today value of Money Orders transactions
        /// </summary>
        public string todayAmountMoneyOrders { get; set; }
        private string TODAY_AMOUNT_MONEYORDERS
        {
            get { return todayAmountMoneyOrders; }
            set { todayAmountMoneyOrders = value.Trim(); }
        }

        //public string todayGPMoneyOrders { get; set; }
        //private string TODAY_GP_MONEYORDERS
        //{
        //    get { return todayGPMoneyOrders; }
        //    set { todayGPMoneyOrders = value.Trim(); }
        //}

        /// <summary>
        /// Average value for Money Transfer transactions
        /// </summary>
        public string avgCountMoneyTransfer { get; set; }
        private string AVG_COUNT_MONEYTRANSFER
        {
            get { return avgCountMoneyTransfer; }
            set { avgCountMoneyTransfer = value.Trim(); }
        }

        /// <summary>
        /// Today number of Money transfer transactions
        /// </summary>
        public string todayCountMoneyTransfer { get; set; }
        private string TODAY_COUNT_MONEYTRANSFER
        {
            get { return todayCountMoneyTransfer; }
            set { todayCountMoneyTransfer = value.Trim(); }
        }

        /// <summary>
        /// Today value of Money transfer transactions
        /// </summary>
        public string todayAmountMoneyTransfer { get; set; }
        private string TODAY_AMOUNT_MONEYTRANSFER
        {
            get { return todayAmountMoneyTransfer; }
            set { todayAmountMoneyTransfer = value.Trim(); }
        }

        /// <summary>
        /// fx level major payer
        /// </summary>
        public string fxLevelMajorPayer { get; set; }
        private string FX_LEVEL_MAJOR_PAYER
        {
            get { return fxLevelMajorPayer; }
            set { fxLevelMajorPayer = value.Trim(); }
        }

        /// <summary>
        /// Higt water marck
        /// </summary>
        public string highWaterMark { get; set; }
        private string HIGH_WATER_MARK
        {
            get { return highWaterMark; }
            set { highWaterMark = value.Trim(); }
        }

    }
}
