
namespace MediaManager.Admin
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
            this.labelInformation = new System.Windows.Forms.Label();
            this.labelNomFilm = new System.Windows.Forms.Label();
            this.labelDuree = new System.Windows.Forms.Label();
            this.labelSortie = new System.Windows.Forms.Label();
            this.labelSynopsis = new System.Windows.Forms.Label();
            this.richTextSynopsis = new System.Windows.Forms.RichTextBox();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.textBoxDuree = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.dateTimePickerSortie = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(13, 13);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(59, 13);
            this.labelInformation.TabIndex = 0;
            this.labelInformation.Text = "Information";
            // 
            // labelNomFilm
            // 
            this.labelNomFilm.AutoSize = true;
            this.labelNomFilm.Location = new System.Drawing.Point(16, 30);
            this.labelNomFilm.Name = "labelNomFilm";
            this.labelNomFilm.Size = new System.Drawing.Size(53, 13);
            this.labelNomFilm.TabIndex = 1;
            this.labelNomFilm.Text = "Nom film :";
            // 
            // labelDuree
            // 
            this.labelDuree.AutoSize = true;
            this.labelDuree.Location = new System.Drawing.Point(16, 53);
            this.labelDuree.Name = "labelDuree";
            this.labelDuree.Size = new System.Drawing.Size(90, 13);
            this.labelDuree.TabIndex = 2;
            this.labelDuree.Text = "Durée en minutes";
            // 
            // labelSortie
            // 
            this.labelSortie.AutoSize = true;
            this.labelSortie.Location = new System.Drawing.Point(16, 80);
            this.labelSortie.Name = "labelSortie";
            this.labelSortie.Size = new System.Drawing.Size(73, 13);
            this.labelSortie.TabIndex = 3;
            this.labelSortie.Text = "Date de sortie";
            // 
            // labelSynopsis
            // 
            this.labelSynopsis.AutoSize = true;
            this.labelSynopsis.Location = new System.Drawing.Point(19, 102);
            this.labelSynopsis.Name = "labelSynopsis";
            this.labelSynopsis.Size = new System.Drawing.Size(49, 13);
            this.labelSynopsis.TabIndex = 4;
            this.labelSynopsis.Text = "Synopsis";
            // 
            // richTextSynopsis
            // 
            this.richTextSynopsis.Location = new System.Drawing.Point(19, 119);
            this.richTextSynopsis.Name = "richTextSynopsis";
            this.richTextSynopsis.Size = new System.Drawing.Size(276, 96);
            this.richTextSynopsis.TabIndex = 5;
            this.richTextSynopsis.Text = "";
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(100, 221);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.buttonEnregistrer.TabIndex = 6;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            // 
            // textBoxDuree
            // 
            this.textBoxDuree.Location = new System.Drawing.Point(113, 53);
            this.textBoxDuree.Name = "textBoxDuree";
            this.textBoxDuree.Size = new System.Drawing.Size(100, 20);
            this.textBoxDuree.TabIndex = 7;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(75, 27);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 8;
            // 
            // dateTimePickerSortie
            // 
            this.dateTimePickerSortie.Location = new System.Drawing.Point(95, 79);
            this.dateTimePickerSortie.Name = "dateTimePickerSortie";
            this.dateTimePickerSortie.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSortie.TabIndex = 9;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(311, 260);
            this.Controls.Add(this.dateTimePickerSortie);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxDuree);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.richTextSynopsis);
            this.Controls.Add(this.labelSynopsis);
            this.Controls.Add(this.labelSortie);
            this.Controls.Add(this.labelDuree);
            this.Controls.Add(this.labelNomFilm);
            this.Controls.Add(this.labelInformation);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Label labelNomFilm;
        private System.Windows.Forms.Label labelDuree;
        private System.Windows.Forms.Label labelSortie;
        private System.Windows.Forms.Label labelSynopsis;
        private System.Windows.Forms.RichTextBox richTextSynopsis;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.TextBox textBoxDuree;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.DateTimePicker dateTimePickerSortie;
    }
}

