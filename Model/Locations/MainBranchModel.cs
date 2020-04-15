using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Viam.SalesForce.API.Model.Locations
{
    public class MainBranchModel
    {
        public string idBranch { get; set; }
        private string ID_BRANCH
        {
            get { return idBranch; }
            set { idBranch = value.Trim(); }
        }

        public string nameBranch { get; set; }
        private string NAME_BRANCH
        {
            get { return nameBranch; }
            set { nameBranch = value.Trim(); }
        }

        public string flagGrupo { get; set; }
        private string FLAG_GRUPO
        {
            get { return flagGrupo; }
            set { flagGrupo = value.Trim(); }
        }
    }
}
