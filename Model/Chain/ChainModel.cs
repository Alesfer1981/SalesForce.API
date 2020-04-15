using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Chain
{
    public class ChainModel
    {

        public string idChain { get; set; }
        private string ID_CHAIN
        {
            get { return idChain; }
            set { idChain = value.Trim(); }
        }

        public string nameChain { get; set; }
        private string NAME_CHAIN
        {
            get { return nameChain; }
            set { nameChain = value.Trim(); }
        }

        public string idFlagChain { get; set; }
        private string ID_FLAG_CHAIN
        {
            get { return idFlagChain; }
            set { idFlagChain = value.Trim(); }
        }

        public string idStatusChain { get; set; }
        private string ID_STATUS_CHAIN
        {
            get { return idStatusChain; }
            set { idStatusChain = value.Trim(); }
        }

        public string legalNameChain { get; set; }
        private string LEGAL_NAME_CHAIN
        {
            get { return legalNameChain; }
            set { legalNameChain = value.Trim(); }
        }
    }
}
