using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Locations
{
    /// <summary>
    /// Resume today object to store data
    /// </summary>
    public class ResumeDataToday
    {
        /// <summary>
        /// Location code
        /// </summary>
        public string idLocation { get; set; }
        private string ID_LOCATION
        {
            get { return idLocation; }
            set { idLocation = value.Trim(); }
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
        /// Number of transactions today for Topups app
        /// </summary>
        public string todayCountViaTopups { get; set; }
        private string TODAY_COUNT_VIATOPUPS
        {
            get { return todayCountViaTopups; }
            set { todayCountViaTopups = value.Trim(); }
        }

        /// <summary>
        /// Quantity of transactions today for Topups app
        /// </summary>
        public string todayAmountViaTopups { get; set; }
        private string TODAY_AMOUNT_VIATOPUPS
        {
            get { return todayAmountViaTopups; }
            set { todayAmountViaTopups = value.Trim(); }
        }

        /// <summary>
        /// Number of transactions today for BillPayment app
        /// </summary>
        public string todayCountViaBillpay { get; set; }
        private string TODAY_COUNT_VIABILLPAY
        {
            get { return todayCountViaBillpay; }
            set { todayCountViaBillpay = value.Trim(); }
        }

        /// <summary>
        /// Quantity of transactions today for Billpayment app
        /// </summary>
        public string todayAmountViaBillpay { get; set; }
        private string TODAY_AMOUNT_VIABILLPAY
        {
            get { return todayAmountViaBillpay; }
            set { todayAmountViaBillpay = value.Trim(); }
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
        public string todayAmountMoneyorders { get; set; }
        private string TODAY_AMOUNT_MONEYORDERS
        {
            get { return todayAmountMoneyorders; }
            set { todayAmountMoneyorders = value.Trim(); }
        }

        /// <summary>
        /// Number of transactions today for Money transfer app
        /// </summary>
        public string todayCountMoneytransfer { get; set; }
        private string TODAY_COUNT_MONEYTRANSFER
        {
            get { return todayCountMoneytransfer; }
            set { todayCountMoneytransfer = value.Trim(); }
        }

        /// <summary>
        /// Quantity of transactions today for Money transfer app
        /// </summary>
        public string todayAmountMoneytransfer { get; set; }
        private string TODAY_AMOUNT_MONEYTRANSFER
        {
            get { return todayAmountMoneytransfer; }
            set { todayAmountMoneytransfer = value.Trim(); }
        }

        /// <summary>
        /// Forex level major payer
        /// </summary>
        public string fxLevelMajorPayer { get; set; }
        private string FX_LEVEL_MAJOR_PAYER
        {
            get { return fxLevelMajorPayer; }
            set { fxLevelMajorPayer = value.Trim(); }
        }
    }
}
