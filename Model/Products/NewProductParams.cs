using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Products
{
    public class NewProductParams
    {
        public string idCompany { get; set; }

        public string nameBranch { get; set; }

        public string addressBranch { get; set; }

        public string idCity { get; set; }

        public string idMainBranch { get; set; }

        public string idFlagBranch { get; set; }

        public string idTypeBranch { get; set; }

        public string phone1Branch { get; set; }

        public string phone2Branch { get; set; }

        public string faxBranch { get; set; }

        public DateTime dateCreateBranch { get; set; }

        public decimal zipBranch { get; set; }

        public string currencyPayBranch { get; set; }

        public string idStatusBranch { get; set; }

        public string statusComment { get; set; }

        public string businessHours { get; set; }

        public string latitud { get; set; }

        public string longitud { get; set; }

        public string geoPrecision { get; set; }

        public string idLocation { get; set; }

        public string idChain { get; set; }

        public int redPhone { get; set; }

        public DateTime dateOpen { get; set; }

        public string nameMainBranch { get; set; }

        public string dateCreateMainBranch { get; set; }

        public string emailBusiness { get; set; }

        public string emailOwner { get; set; }

        public string paymentMethod1 { get; set; }

        public string paymentMethod2 { get; set; }

        public string finSchedule { get; set; }

        public string emailOperations { get; set; }

        public string finYearlyInterestRate { get; set; }

        public string finStatusComments { get; set; }

        public string creditGrade { get; set; }

        public string depositBank { get; set; }

        public string idSalesForce { get; set; }

        public string nameAgent { get; set; }
    }
}
