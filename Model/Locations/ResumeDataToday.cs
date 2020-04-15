using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Locations
{
    public class ResumeDataToday
    {
        public string idLocation { get; set; }
        private string ID_LOCATION
        {
            get { return idLocation; }
            set { idLocation = value.Trim(); }
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

        public string todayCountViaTopups { get; set; }
        private string TODAY_COUNT_VIATOPUPS
        {
            get { return todayCountViaTopups; }
            set { todayCountViaTopups = value.Trim(); }
        }

        public string todayAmountViaTopups { get; set; }
        private string TODAY_AMOUNT_VIATOPUPS
        {
            get { return todayAmountViaTopups; }
            set { todayAmountViaTopups = value.Trim(); }
        }

        public string todayCountViaBillpay { get; set; }
        private string TODAY_COUNT_VIABILLPAY
        {
            get { return todayCountViaBillpay; }
            set { todayCountViaBillpay = value.Trim(); }
        }

        public string todayAmountViaBillpay { get; set; }
        private string TODAY_AMOUNT_VIABILLPAY
        {
            get { return todayAmountViaBillpay; }
            set { todayAmountViaBillpay = value.Trim(); }
        }


        public string todayCountMoneyOrders { get; set; }
        private string TODAY_COUNT_MONEYORDERS
        {
            get { return todayCountMoneyOrders; }
            set { todayCountMoneyOrders = value.Trim(); }
        }


        public string todayAmountMoneyorders { get; set; }
        private string TODAY_AMOUNT_MONEYORDERS
        {
            get { return todayAmountMoneyorders; }
            set { todayAmountMoneyorders = value.Trim(); }
        }


        public string todayCountMoneytransfer { get; set; }
        private string TODAY_COUNT_MONEYTRANSFER
        {
            get { return todayCountMoneytransfer; }
            set { todayCountMoneytransfer = value.Trim(); }
        }

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
