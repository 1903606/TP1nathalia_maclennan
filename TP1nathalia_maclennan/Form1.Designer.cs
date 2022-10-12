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
            this.tabPageCahier3 = new System.Windows.Forms.TabPage();
            this.buttonQuitter1 = new System.Windows.Forms.Button();
            this.tabControlCollege1.SuspendLayout();
            this.tabPageAcceuil1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo1)).BeginInit();
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
            this.tabPageDossier2.Location = new System.Drawing.Point(4, 24);
            this.tabPageDossier2.Name = "tabPageDossier2";
            this.tabPageDossier2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDossier2.Size = new System.Drawing.Size(703, 354);
            this.tabPageDossier2.TabIndex = 1;
            this.tabPageDossier2.Text = "Dossier";
            this.tabPageDossier2.UseVisualStyleBackColor = true;
            // 
            // tabPageCahier3
            // 
            this.tabPageCahier3.Location = new System.Drawing.Point(4, 24);
            this.tabPageCahier3.Name = "tabPageCahier3";
            this.tabPageCahier3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCahier3.Size = new System.Drawing.Size(703, 354);
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
    }
}