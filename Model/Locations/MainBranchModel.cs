using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Locations
{
    public class MainBranchModel
    {
        /// <summary>
        /// Code of Main branch
        /// </summary>
        public string idMainBranch { get; set; }
        private string ID_MAIN_BRANCH
        {
            get { return idMainBranch; }
            set { idMainBranch = value.Trim(); }
        }

        /// <summary>
        /// Name of Main branch
        /// </summary>
        public string nameMainBranch { get; set; }
        private string NAME_MAIN_BRANCH
        {
            get { return nameMainBranch; }
            set { nameMainBranch = value.Trim(); }
        }

        /// <summary>
        /// Flag to indicate status (A:Active C:Closed I:Inactive)
        /// </summary>
        public string flagGrupo { get; set; }
        private string FLAG_GRUPO
        {
            get { return flagGrupo; }
            set { flagGrupo = value.Trim(); }
        }
    }
}
