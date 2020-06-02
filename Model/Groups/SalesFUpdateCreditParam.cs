using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Groups
{
    public class SalesFUpdateCreditParam
    {
        /// <summary>
        /// Branch Code
        /// </summary>
        [Required, StringLength(10), MinLength(6)]
        public string idMainBranch { get; set; }

        /// <summary>
        /// Value of debit limit branch
        /// </summary>
        public decimal debtLimit { get; set; }

        /// <summary>
        /// Value of debit limit branch on Weekend
        /// </summary>
        public decimal debtLimitWknd { get; set; }

        /// <summary>
        /// Code of actual branch phase
        /// </summary>
        public int idPhase { get; set; }

        /// <summary>
        /// Value of debit limit Monthly
        /// </summary>
        public decimal debtLimitMo { get; set; }

        /// <summary>
        /// Value of debit limit Monthly
        /// </summary>
        public decimal debtLimitWkndMo { get; set; }

    }
}
