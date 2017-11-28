using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF_MERLIERAntoine
{
    [Serializable]
    public class ChercheurDEmploi
    {
        int identifiantUnique;
        ProfilDemandeur profil;
        public ChercheurDEmploi()
        {

        }
        public ChercheurDEmploi(int _idUnique, ProfilDemandeur _profil)
        {
            identifiantUnique = _idUnique;
            Profil = _profil;
        }

        public ProfilDemandeur Profil { get => profil; set => profil = value; }
        public int IdentifiantUnique { get => identifiantUnique; set => identifiantUnique = value; }
    }
}
