using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace ECF_MERLIERAntoine
{
    [Serializable]
    public class TrouveEmploi
    {
        static List<ChercheurDEmploi> listeChercheursDEmploi = new List<ChercheurDEmploi>();

        public TrouveEmploi()
        { }

        public static List<ChercheurDEmploi> ListeChercheursDEmploi { get => listeChercheursDEmploi; set => listeChercheursDEmploi = value; }
    }
}
