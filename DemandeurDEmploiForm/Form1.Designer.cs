namespace DemandeurDEmploiForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxDE = new System.Windows.Forms.GroupBox();
            this.labelDiplome = new System.Windows.Forms.Label();
            this.labelDateDeValidation = new System.Windows.Forms.Label();
            this.labelDateInscription = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxDateDeValidation = new System.Windows.Forms.TextBox();
            this.textBoxDateDInscription = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.buttonValider = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauDemandeurDemploiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirUnDemandeurDemploiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerLeDemandeurDemploiCourantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxDmdEmpl = new System.Windows.Forms.ListBox();
            this.groupBoxDE.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDE
            // 
            this.groupBoxDE.Controls.Add(this.labelDiplome);
            this.groupBoxDE.Controls.Add(this.labelDateDeValidation);
            this.groupBoxDE.Controls.Add(this.labelDateInscription);
            this.groupBoxDE.Controls.Add(this.labelPrenom);
            this.groupBoxDE.Controls.Add(this.labelNom);
            this.groupBoxDE.Controls.Add(this.comboBox1);
            this.groupBoxDE.Controls.Add(this.textBoxPrenom);
            this.groupBoxDE.Controls.Add(this.textBoxDateDeValidation);
            this.groupBoxDE.Controls.Add(this.textBoxDateDInscription);
            this.groupBoxDE.Controls.Add(this.textBoxNom);
            this.groupBoxDE.Location = new System.Drawing.Point(12, 30);
            this.groupBoxDE.Name = "groupBoxDE";
            this.groupBoxDE.Size = new System.Drawing.Size(363, 200);
            this.groupBoxDE.TabIndex = 0;
            this.groupBoxDE.TabStop = false;
            this.groupBoxDE.Text = "Saisie du nouveau demandeur d\'emploi";
            // 
            // labelDiplome
            // 
            this.labelDiplome.AutoSize = true;
            this.labelDiplome.Location = new System.Drawing.Point(50, 157);
            this.labelDiplome.Name = "labelDiplome";
            this.labelDiplome.Size = new System.Drawing.Size(45, 13);
            this.labelDiplome.TabIndex = 10;
            this.labelDiplome.Text = "Diplôme";
            // 
            // labelDateDeValidation
            // 
            this.labelDateDeValidation.AutoSize = true;
            this.labelDateDeValidation.Location = new System.Drawing.Point(50, 122);
            this.labelDateDeValidation.Name = "labelDateDeValidation";
            this.labelDateDeValidation.Size = new System.Drawing.Size(93, 13);
            this.labelDateDeValidation.TabIndex = 9;
            this.labelDateDeValidation.Text = "Date de validation";
            // 
            // labelDateInscription
            // 
            this.labelDateInscription.AutoSize = true;
            this.labelDateInscription.Location = new System.Drawing.Point(50, 90);
            this.labelDateInscription.Name = "labelDateInscription";
            this.labelDateInscription.Size = new System.Drawing.Size(88, 13);
            this.labelDateInscription.TabIndex = 8;
            this.labelDateInscription.Text = "Date d\'inscription";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(50, 64);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 7;
            this.labelPrenom.Text = "Prenom";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(50, 38);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 6;
            this.labelNom.Text = "Nom";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(147, 64);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenom.TabIndex = 4;
            // 
            // textBoxDateDeValidation
            // 
            this.textBoxDateDeValidation.Location = new System.Drawing.Point(147, 122);
            this.textBoxDateDeValidation.Name = "textBoxDateDeValidation";
            this.textBoxDateDeValidation.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateDeValidation.TabIndex = 2;
            // 
            // textBoxDateDInscription
            // 
            this.textBoxDateDInscription.Location = new System.Drawing.Point(147, 90);
            this.textBoxDateDInscription.Name = "textBoxDateDInscription";
            this.textBoxDateDInscription.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateDInscription.TabIndex = 1;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(147, 38);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 0;
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(184, 236);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(75, 23);
            this.buttonValider.TabIndex = 1;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(300, 236);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(75, 23);
            this.buttonModifier.TabIndex = 2;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauDemandeurDemploiToolStripMenuItem,
            this.ouvrirUnDemandeurDemploiToolStripMenuItem,
            this.enregistrerLeDemandeurDemploiCourantToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouveauDemandeurDemploiToolStripMenuItem
            // 
            this.nouveauDemandeurDemploiToolStripMenuItem.Name = "nouveauDemandeurDemploiToolStripMenuItem";
            this.nouveauDemandeurDemploiToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.nouveauDemandeurDemploiToolStripMenuItem.Text = "Nouveau demandeur d\'emploi";
            this.nouveauDemandeurDemploiToolStripMenuItem.Click += new System.EventHandler(this.nouveauDemandeurDemploiToolStripMenuItem_Click);
            // 
            // ouvrirUnDemandeurDemploiToolStripMenuItem
            // 
            this.ouvrirUnDemandeurDemploiToolStripMenuItem.Name = "ouvrirUnDemandeurDemploiToolStripMenuItem";
            this.ouvrirUnDemandeurDemploiToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.ouvrirUnDemandeurDemploiToolStripMenuItem.Text = "Ouvrir un demandeur d\'emploi";
            this.ouvrirUnDemandeurDemploiToolStripMenuItem.Click += new System.EventHandler(this.ouvrirUnDemandeurDemploiToolStripMenuItem_Click);
            // 
            // enregistrerLeDemandeurDemploiCourantToolStripMenuItem
            // 
            this.enregistrerLeDemandeurDemploiCourantToolStripMenuItem.Name = "enregistrerLeDemandeurDemploiCourantToolStripMenuItem";
            this.enregistrerLeDemandeurDemploiCourantToolStripMenuItem.Size = new System.Drawing.Size(300, 22);
            this.enregistrerLeDemandeurDemploiCourantToolStripMenuItem.Text = "Enregistrer le demandeur d\'emploi courant";
            this.enregistrerLeDemandeurDemploiCourantToolStripMenuItem.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // listBoxDmdEmpl
            // 
            this.listBoxDmdEmpl.FormattingEnabled = true;
            this.listBoxDmdEmpl.Location = new System.Drawing.Point(441, 38);
            this.listBoxDmdEmpl.Name = "listBoxDmdEmpl";
            this.listBoxDmdEmpl.Size = new System.Drawing.Size(312, 199);
            this.listBoxDmdEmpl.TabIndex = 4;
            this.listBoxDmdEmpl.SelectedIndexChanged += new System.EventHandler(this.listBoxDmdEmpl_SelectedIndexChanged);
            this.listBoxDmdEmpl.DoubleClick += new System.EventHandler(this.listBoxDmdEmpl_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 278);
            this.Controls.Add(this.listBoxDmdEmpl);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.groupBoxDE);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDE.ResumeLayout(false);
            this.groupBoxDE.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDE;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxDateDeValidation;
        private System.Windows.Forms.TextBox textBoxDateDInscription;
        private System.Windows.Forms.Label labelDiplome;
        private System.Windows.Forms.Label labelDateDeValidation;
        private System.Windows.Forms.Label labelDateInscription;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauDemandeurDemploiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirUnDemandeurDemploiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerLeDemandeurDemploiCourantToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxDmdEmpl;
    }
}

