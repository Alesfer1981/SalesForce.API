using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Groups
{
    public class SalesFUpdateCreditParam
    {

        public string idMainBranch { get; set; }

        public decimal debtLimit { get; set; }

        public decimal debtLimitWknd { get; set; }

        public int idPhase { get; set; }

        public decimal debtLimitMo { get; set; }

        public decimal debtLimitWkndMo { get; set; }

    }
}
