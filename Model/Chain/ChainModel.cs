using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Chain
{
    public class ChainModel
    {
        /// <summary>
        /// Chain code of branch
        /// </summary>
        [Required, StringLength(50), MinLength(6)]
        public string idChain { get; set; }
        private string ID_CHAIN
        {
            get { return idChain; }
            set { idChain = value.Trim(); }
        }

        /// <summary>
        /// Name of chain
        /// </summary>
        [Required, StringLength(100)]
        public string nameChain { get; set; }
        private string NAME_CHAIN
        {
            get { return nameChain; }
            set { nameChain = value.Trim(); }
        }

        /// <summary>
        /// Flag to indicate the status chain (A:Active I:Inactive)
        /// </summary>
        [Required, StringLength(1), MinLength(1)]
        public string idFlagChain { get; set; }
        private string ID_FLAG_CHAIN
        {
            get { return idFlagChain; }
            set { idFlagChain = value.Trim(); }
        }

        /// <summary>
        /// Code of status chain (O:Open C:Closed)
        /// </summary>
        [Required, StringLength(1), MinLength(1)]
        public string idStatusChain { get; set; }
        private string ID_STATUS_CHAIN
        {
            get { return idStatusChain; }
            set { idStatusChain = value.Trim(); }
        }

        /// <summary>
        /// Respresentative name that belong to the chain
        /// </summary>
        [StringLength(100)]
        public string legalNameChain { get; set; }
        private string LEGAL_NAME_CHAIN
        {
            get { return legalNameChain; }
            set { legalNameChain = value.Trim(); }
        }
    }
}
