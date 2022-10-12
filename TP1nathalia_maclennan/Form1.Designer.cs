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
            this.tabControlCollege1 = new System.Windows.Forms.TabControl();
            this.tabPageAcceuil1 = new System.Windows.Forms.TabPage();
            this.tabPageDossier2 = new System.Windows.Forms.TabPage();
            this.tabPageCahier3 = new System.Windows.Forms.TabPage();
            this.tabControlCollege1.SuspendLayout();
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
            this.tabControlCollege1.Size = new System.Drawing.Size(711, 382);
            this.tabControlCollege1.TabIndex = 0;
            // 
            // tabPageAcceuil1
            // 
            this.tabPageAcceuil1.Location = new System.Drawing.Point(4, 24);
            this.tabPageAcceuil1.Name = "tabPageAcceuil1";
            this.tabPageAcceuil1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAcceuil1.Size = new System.Drawing.Size(703, 354);
            this.tabPageAcceuil1.TabIndex = 0;
            this.tabPageAcceuil1.Text = "Acceuil";
            this.tabPageAcceuil1.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlCollege1);
            this.Name = "Form1";
            this.Text = "Collège Nathalia Maclennan";
            this.tabControlCollege1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlCollege1;
        private TabPage tabPageAcceuil1;
        private TabPage tabPageDossier2;
        private TabPage tabPageCahier3;
    }
}