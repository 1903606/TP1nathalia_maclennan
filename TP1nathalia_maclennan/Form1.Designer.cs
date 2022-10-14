namespace TP1nathalia_maclennan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControlCollege1 = new System.Windows.Forms.TabControl();
            this.tabPageAcceuil1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxLogo1 = new System.Windows.Forms.PictureBox();
            this.tabPageDossier2 = new System.Windows.Forms.TabPage();
            this.labelResultat = new System.Windows.Forms.Label();
            this.labelMatiere = new System.Windows.Forms.Label();
            this.labelGroupe = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelDossierEtudiant2 = new System.Windows.Forms.Label();
            this.tabPageCahier3 = new System.Windows.Forms.TabPage();
            this.buttonQuitter1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlCollege1.SuspendLayout();
            this.tabPageAcceuil1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo1)).BeginInit();
            this.tabPageDossier2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCollege1
            // 
            this.tabControlCollege1.Controls.Add(this.tabPageAcceuil1);
            this.tabControlCollege1.Controls.Add(this.tabPageDossier2);
            this.tabControlCollege1.Controls.Add(this.tabPageCahier3);
            this.tabControlCollege1.Location = new System.Drawing.Point(40, 31);
            this.tabControlCollege1.Name = "tabControlCollege1";
            this.tabControlCollege1.SelectedIndex = 0;
            this.tabControlCollege1.Size = new System.Drawing.Size(711, 370);
            this.tabControlCollege1.TabIndex = 0;
            // 
            // tabPageAcceuil1
            // 
            this.tabPageAcceuil1.Controls.Add(this.label1);
            this.tabPageAcceuil1.Controls.Add(this.pictureBoxLogo1);
            this.tabPageAcceuil1.Location = new System.Drawing.Point(4, 24);
            this.tabPageAcceuil1.Name = "tabPageAcceuil1";
            this.tabPageAcceuil1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAcceuil1.Size = new System.Drawing.Size(703, 342);
            this.tabPageAcceuil1.TabIndex = 0;
            this.tabPageAcceuil1.Text = "Acceuil";
            this.tabPageAcceuil1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion des étudiants";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxLogo1
            // 
            this.pictureBoxLogo1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo1.Image")));
            this.pictureBoxLogo1.Location = new System.Drawing.Point(67, 45);
            this.pictureBoxLogo1.Name = "pictureBoxLogo1";
            this.pictureBoxLogo1.Size = new System.Drawing.Size(592, 169);
            this.pictureBoxLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo1.TabIndex = 0;
            this.pictureBoxLogo1.TabStop = false;
            // 
            // tabPageDossier2
            // 
            this.tabPageDossier2.Controls.Add(this.pictureBox1);
            this.tabPageDossier2.Controls.Add(this.labelResultat);
            this.tabPageDossier2.Controls.Add(this.labelMatiere);
            this.tabPageDossier2.Controls.Add(this.labelGroupe);
            this.tabPageDossier2.Controls.Add(this.labelCode);
            this.tabPageDossier2.Controls.Add(this.labelNom);
            this.tabPageDossier2.Controls.Add(this.labelPrenom);
            this.tabPageDossier2.Controls.Add(this.labelDossierEtudiant2);
            this.tabPageDossier2.Location = new System.Drawing.Point(4, 24);
            this.tabPageDossier2.Name = "tabPageDossier2";
            this.tabPageDossier2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDossier2.Size = new System.Drawing.Size(703, 342);
            this.tabPageDossier2.TabIndex = 1;
            this.tabPageDossier2.Text = "Dossier";
            this.tabPageDossier2.UseVisualStyleBackColor = true;
            // 
            // labelResultat
            // 
            this.labelResultat.AutoSize = true;
            this.labelResultat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResultat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelResultat.Location = new System.Drawing.Point(234, 201);
            this.labelResultat.Name = "labelResultat";
            this.labelResultat.Size = new System.Drawing.Size(83, 25);
            this.labelResultat.TabIndex = 6;
            this.labelResultat.Text = "Résultat";
            // 
            // labelMatiere
            // 
            this.labelMatiere.AutoSize = true;
            this.labelMatiere.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMatiere.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelMatiere.Location = new System.Drawing.Point(27, 201);
            this.labelMatiere.Name = "labelMatiere";
            this.labelMatiere.Size = new System.Drawing.Size(80, 25);
            this.labelMatiere.TabIndex = 5;
            this.labelMatiere.Text = "Matière";
            // 
            // labelGroupe
            // 
            this.labelGroupe.AutoSize = true;
            this.labelGroupe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGroupe.Location = new System.Drawing.Point(89, 165);
            this.labelGroupe.Name = "labelGroupe";
            this.labelGroupe.Size = new System.Drawing.Size(61, 20);
            this.labelGroupe.TabIndex = 4;
            this.labelGroupe.Text = "Groupe:";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCode.Location = new System.Drawing.Point(27, 125);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(123, 20);
            this.labelCode.TabIndex = 3;
            this.labelCode.Text = "Code permanent:";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNom.Location = new System.Drawing.Point(105, 90);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(45, 20);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Nom:";
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrenom.Location = new System.Drawing.Point(87, 52);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(63, 20);
            this.labelPrenom.TabIndex = 1;
            this.labelPrenom.Text = "Prénom:";
            // 
            // labelDossierEtudiant2
            // 
            this.labelDossierEtudiant2.AutoSize = true;
            this.labelDossierEtudiant2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDossierEtudiant2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDossierEtudiant2.Location = new System.Drawing.Point(27, 17);
            this.labelDossierEtudiant2.Name = "labelDossierEtudiant2";
            this.labelDossierEtudiant2.Size = new System.Drawing.Size(195, 25);
            this.labelDossierEtudiant2.TabIndex = 0;
            this.labelDossierEtudiant2.Text = "Dossier de l\'étudiant";
            this.labelDossierEtudiant2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabPageCahier3
            // 
            this.tabPageCahier3.Location = new System.Drawing.Point(4, 24);
            this.tabPageCahier3.Name = "tabPageCahier3";
            this.tabPageCahier3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCahier3.Size = new System.Drawing.Size(703, 342);
            this.tabPageCahier3.TabIndex = 2;
            this.tabPageCahier3.Text = "Cahier de notes";
            this.tabPageCahier3.UseVisualStyleBackColor = true;
            // 
            // buttonQuitter1
            // 
            this.buttonQuitter1.Location = new System.Drawing.Point(655, 407);
            this.buttonQuitter1.Name = "buttonQuitter1";
            this.buttonQuitter1.Size = new System.Drawing.Size(96, 35);
            this.buttonQuitter1.TabIndex = 1;
            this.buttonQuitter1.Text = "Quitter";
            this.buttonQuitter1.UseVisualStyleBackColor = true;
            this.buttonQuitter1.Click += new System.EventHandler(this.buttonQuitter1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP1nathalia_maclennan.Properties.Resources.image_Students;
            this.pictureBox1.Location = new System.Drawing.Point(464, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.buttonQuitter1);
            this.Controls.Add(this.tabControlCollege1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Collège Nathalia Maclennan";
            this.tabControlCollege1.ResumeLayout(false);
            this.tabPageAcceuil1.ResumeLayout(false);
            this.tabPageAcceuil1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo1)).EndInit();
            this.tabPageDossier2.ResumeLayout(false);
            this.tabPageDossier2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlCollege1;
        private TabPage tabPageAcceuil1;
        private TabPage tabPageDossier2;
        private TabPage tabPageCahier3;
        private Label label1;
        private PictureBox pictureBoxLogo1;
        private Button buttonQuitter1;
        private Label labelDossierEtudiant2;
        private Label labelResultat;
        private Label labelMatiere;
        private Label labelGroupe;
        private Label labelCode;
        private Label labelNom;
        private Label labelPrenom;
        private PictureBox pictureBox1;
    }
}