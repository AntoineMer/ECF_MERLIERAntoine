using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECF_MERLIERAntoine;


namespace DemandeurDEmploiForm
{
    public partial class Form1 : Form
    {
        // Les parties placées en commentaires sont soit là à titre informatif, soit destinées à faire évoluer le programme si demandé
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(EDiplome.Bac);
            comboBox1.Items.Add(EDiplome.BacPlusUn);
            comboBox1.Items.Add(EDiplome.BacPlusDeux);
            comboBox1.Items.Add(EDiplome.BacPlusTrois);
            comboBox1.Items.Add(EDiplome.BacPlusQuatre);
            comboBox1.Items.Add(EDiplome.BacPlusCinq);
            comboBox1.Items.Add(EDiplome.SupBacPlusCinq);
            //ajout à la liste des différents niveau d'étude

            groupBoxDE.Visible = false;
            buttonModifier.Visible = false;
            buttonValider.Visible = false;
            listBoxDmdEmpl.Visible = false;
           
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if ((DateTime.TryParse(textBoxDateDInscription.Text, out DateTime dateDInscription))
                && (DateTime.TryParse(textBoxDateDeValidation.Text, out DateTime dateDeValidation)))
            {
                ProfilDemandeur profil = new ProfilDemandeur(textBoxNom.Text, textBoxPrenom.Text, dateDInscription, dateDeValidation, (EDiplome)comboBox1.SelectedItem); //instance d'un nouveau profil de chercheurDEmploi
                ChercheurDEmploi chercheurDEmploi = new ChercheurDEmploi(profil.GenererID(), profil); //instance d'un nouveau chercheurDEmploi
                if (chercheurDEmploi != null)
                {
                    TrouveEmploi.ListeChercheursDEmploi.Add(chercheurDEmploi);
                    // Serialise.Serialize(chercheurDEmploi, "chercheurDEmploiSerial.bin"); //sérialisation d'un seul demandeur d'emploi
                    Serialise.Serialize(TrouveEmploi.ListeChercheursDEmploi, "listeDesChercheursDEmploi.bin");
                    MessageBox.Show("Ajout du demandeur d'emploi réalisé avec succès"); //confirmation de la réussite de l'ajout d'un chercheurDEmploi
                    MessageBox.Show("Avec ce niveau d'étude vous avez un taux d'employabilité de " + profil.TauxDEmployabilite + "%");
                }
                else
                    MessageBox.Show("Ce profil n'existe pas !");
            }
            else
                MessageBox.Show("Format de date incorrect !");
            
           
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(textBoxDateDeValidation.Text, out DateTime dateDeValidation))
            {
                if (!ProfilDemandeur.ListDiplomes.Contains((EDiplome)comboBox1.SelectedItem)
                && (!ProfilDemandeur.ListeAnneeVal.Contains(dateDeValidation)))
                {
                    ProfilDemandeur.ListDiplomes.Add((EDiplome)comboBox1.SelectedItem);
                    ProfilDemandeur.ListeAnneeVal.Add(dateDeValidation);
                }
                else
                    MessageBox.Show("Le diplôme ou la date existent déjà !");

            }
            else
                MessageBox.Show("Format de date incorrect !");
        }

        private void nouveauDemandeurDemploiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
            textBoxDateDInscription.Text = string.Empty;
            textBoxDateDeValidation.Text = string.Empty;
            textBoxNom.Text = string.Empty;
            textBoxPrenom.Text = string.Empty;
            groupBoxDE.Visible = true;
        }

        private void ouvrirUnDemandeurDemploiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           // TrouveEmploi.ListeChercheursDEmploi = Serialise.Deserialize(@"C:\Users\CRM\Desktop\ECF_MERLIERAntoine\DemandeurDEmploiForm\bin\Debug\chercheurDEmploiSerial.bin") as List <ChercheurDEmploi>;
            comboBox1.Text = string.Empty;
            textBoxDateDInscription.Text = string.Empty;
            textBoxDateDeValidation.Text = string.Empty;
            textBoxNom.Text = string.Empty;
            textBoxPrenom.Text = string.Empty;
            groupBoxDE.Visible = true;
            listBoxDmdEmpl.Visible = true;
           // TrouveEmploi.ListeChercheursDEmploi = Serialise.Deserialize(@"C:\Users\CRM\Desktop\ECF_MERLIERAntoine\WindowsFormsApp1\bin\listeDesChercheursDEmploi.bin") as List<ChercheurDEmploi>;
 

            for (int i = 0; i < TrouveEmploi.ListeChercheursDEmploi.Count; i++)
                {
                listBoxDmdEmpl.Items.Add(TrouveEmploi.ListeChercheursDEmploi[i].IdentifiantUnique);
                }
            
        }

        private void listBoxDmdEmpl_DoubleClick(object sender, EventArgs e)
        {
            //ChercheurDEmploi chercheurDEmploi = sender as ChercheurDEmploi;
            //comboBox1.Text = chercheurDEmploi.Profil.Diplome.ToString();
            //textBoxDateDeValidation.Text
        }

        private void listBoxDmdEmpl_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            int y = 1;
            int i = 0;
            do
            {
                for (i = 0; i < TrouveEmploi.ListeChercheursDEmploi.Count; i++)
                {
                    ChercheurDEmploi chercheurDEmploi = TrouveEmploi.ListeChercheursDEmploi[i];
                    comboBox1.Text = chercheurDEmploi.Profil.Diplome.ToString();
                    textBoxNom.Text = chercheurDEmploi.Profil.Nom;
                    textBoxPrenom.Text = chercheurDEmploi.Profil.Prenom;
                    textBoxDateDeValidation.Text = chercheurDEmploi.Profil.AnneeDeValidation.ToShortDateString();
                    textBoxDateDInscription.Text = chercheurDEmploi.Profil.DateDInscription.ToShortDateString();
                }
            
                y++;
            } while ((i < TrouveEmploi.ListeChercheursDEmploi.Count)
                 && (y != TrouveEmploi.ListeChercheursDEmploi[i].IdentifiantUnique));


        }
    }
}
