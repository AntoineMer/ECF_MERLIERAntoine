using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF_MERLIERAntoine
{
    [Serializable]
    public class ProfilDemandeur
    {
        string nom;
        string prenom;
        DateTime dateDInscription;
        DateTime anneeDeValidation;
        double tauxDEmployabilite;
        EDiplome diplome;
        static List<EDiplome> listDiplomes = new List<EDiplome>();
        static List<DateTime> listeAnneeVal = new List<DateTime>();

        public ProfilDemandeur(string _nom, string _prenom, DateTime _dateDInsciption, DateTime _anneeDeValidation, EDiplome _diplome)
        {
            Nom = _nom;
            Prenom = _prenom;
            DateDInscription = _dateDInsciption;
            AnneeDeValidation = _anneeDeValidation;
            Diplome = _diplome;
            tauxDEmployabilite = CalculerTauxDEmployabilite(_diplome);
            listDiplomes.Add(_diplome);
        }

        public EDiplome Diplome { get => diplome; set => diplome = value; }
        public double TauxDEmployabilite { get => tauxDEmployabilite; set => tauxDEmployabilite = value; }
        public static List<EDiplome> ListDiplomes { get => listDiplomes; set => listDiplomes = value; }
        public static List<DateTime> ListeAnneeVal { get => listeAnneeVal; set => listeAnneeVal = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateDInscription { get => dateDInscription; set => dateDInscription = value; }
        public DateTime AnneeDeValidation { get => anneeDeValidation; set => anneeDeValidation = value; }

        static public double CalculerTauxDEmployabilite(EDiplome _diplome) //taux d'employabilité fixé de manière arbitraire
        {
            double taux;
            if (_diplome == EDiplome.InfBac)
                return taux = 20;
            else if (_diplome == EDiplome.BacPlusUn)
                return taux = 30;
            else if (_diplome == EDiplome.BacPlusDeux)
                return taux = 40;
            else if (_diplome == EDiplome.BacPlusTrois)
                return taux = 50;
            else if (_diplome == EDiplome.BacPlusQuatre)
                return taux = 60;
            else if (_diplome == EDiplome.BacPlusCinq)
                return taux = 70;
            else
                return taux = 80;
        }

        public int GenererID()
        {
            int identifiantUnique = 0;
            identifiantUnique = identifiantUnique + 1;
            return identifiantUnique;
        }

    }
}
