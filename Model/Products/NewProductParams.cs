using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Products
{
    public class NewProductParams
    {
        /// <summary>
        /// Company Code
        /// </summary>
        [Required, StringLength(6), MinLength(3)]
        public string idCompany { get; set; }

        /// <summary>
        /// Agency name
        /// </summary>
        [Required, StringLength(60), MinLength(6)]
        public string nameBranch { get; set; }

        /// <summary>
        /// Agency Address
        /// </summary>
        [Required, StringLength(60), MinLength(6)]
        public string addressBranch { get; set; }

        /// <summary>
        /// City Code
        /// </summary>
        [Required, StringLength(5), MinLength(5)]
        public string idCity { get; set; }

        /// <summary>
        /// Code of main branch
        /// </summary>
        [Required, StringLength(4), MinLength(4)]
        public string idMainBranch { get; set; }

        /// <summary>
        /// Flag Agency (I:Inactive - A: Active)
        /// </summary>
        [Required, StringLength(1), MinLength(1)]
        public string idFlagBranch { get; set; }

        /// <summary>
        /// Type of agency, (P: Payee - R: Agent - A: Both)
        /// </summary>
        [Required, StringLength(1), MinLength(1)]
        public string idTypeBranch { get; set; }

        /// <summary>
        /// Agency Phone number 1
        /// </summary>
        [StringLength(15)]
        public string phone1Branch { get; set; }

        /// <summary>
        /// Agency Phone number 2
        /// </summary>
        [StringLength(15)]
        public string phone2Branch { get; set; }

        /// <summary>
        /// Agency Fax
        /// </summary>
        [StringLength(15)]
        public string faxBranch { get; set; }

        /// <summary>
        /// date of creation branch
        /// </summary>
        public DateTime dateCreateBranch { get; set; }

        /// <summary>
        /// Agency Zip code
        /// </summary>
        public decimal zipBranch { get; set; }

        /// <summary>
        /// Agency currency for payments (N: National Currency - D:Dollar)
        /// </summary>
        [Required, StringLength(1), MinLength(1)]
        public string currencyPayBranch { get; set; }

        /// <summary>
        /// Branch status (O: Open - C: Close)
        /// </summary>
        [Required, StringLength(1), MinLength(1)]
        public string idStatusBranch { get; set; }

        /// <summary>
        /// Last comment about agency status
        /// </summary>
        [StringLength(200)]
        public string statusComment { get; set; }

        /// <summary>
        /// Agency Schedule for customers 
        /// </summary>
        [StringLength(200)]
        public string businessHours { get; set; }

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

        /// <summary>
        /// Location code
        /// </summary>
        [StringLength(6)]
        public string idLocation { get; set; }

        /// <summary>
        /// Chain code
        /// </summary>
        [StringLength(9)]
        public string idChain { get; set; }

        /// <summary>
        /// Value to validate if redphone app is installed 
        /// </summary>
        public int redPhone { get; set; }

        /// <summary>
        /// Date open
        /// </summary>
        public DateTime dateOpen { get; set; }

        /// <summary>
        /// Name main branch
        /// </summary>
        public string nameMainBranch { get; set; }

        /// <summary>
        /// Date create main branch
        /// </summary>
        public string dateCreateMainBranch { get; set; }

        /// <summary>
        /// Email address for business
        /// </summary>
        public string emailBusiness { get; set; }

        /// <summary>
        /// Owner email address 
        /// </summary>
        public string emailOwner { get; set; }

        /// <summary>
        /// Payment method alternative 1 (c: bank deposit p:cash pick up)
        /// </summary>
        public string paymentMethod1 { get; set; }

        /// <summary>
        /// Payment method alternative 2 (c: bank deposit p:cash pick up)
        /// </summary>
        public string paymentMethod2 { get; set; }

        /// <summary>
        /// Financial schedule value
        /// </summary>
        public string finSchedule { get; set; }

        /// <summary>
        /// Operations area email address
        /// </summary>
        public string emailOperations { get; set; }

        /// <summary>
        /// Financial yearly interest rate
        /// </summary>
        public string finYearlyInterestRate { get; set; }

        /// <summary>
        /// Financial status last comments
        /// </summary>
        public string finStatusComments { get; set; }

        /// <summary>
        /// Credit grade
        /// </summary>
        public string creditGrade { get; set; }

        /// <summary>
        /// Bank deposit
        /// </summary>
        public string depositBank { get; set; }

        /// <summary>
        /// SalesForce code
        /// </summary>
        [StringLength(50)]
        public string idSalesForce { get; set; }

        /// <summary>
        /// Name of Agent
        /// </summary>
        public string nameAgent { get; set; }
    }
}
