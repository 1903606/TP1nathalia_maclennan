namespace TP1nathalia_maclennan
{
    public partial class Form1 : Form
    {
        // Iniatialisation tableau
        Etudiant[] tabEtudiant = new Etudiant[Constante.nbEtudMx];
        int nb_etud = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Button quitter pour fermer l'application
        private void buttonQuitter1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Fonction qui sauvegarde un étudiant 
        private void buttonSave_Click(object sender, EventArgs e)
        {
           try
            {

                // Validation de la zone de saisie pour le prenom
                
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxPrenom.Text, "[a-zA-Z]+$"))
                {
                    // Affiche le message d'erreur 
                    
                    MessageBox.Show("Veuillez entrer un prénom valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // ErrorProvider
                    errorProviderPrenom.SetError(textBoxPrenom, "Doit contenir des lettres");
                    return;
                }
                else
                {
                    // Enleve le ErrorProvider
                    errorProviderPrenom.Clear();
                }
                // Validation de la zone de saisie pour le nom

                if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxNom.Text, "[a-zA-Z]+$"))
                {
                    // Affiche le message d'erreur 

                    MessageBox.Show("Veuillez entrer un nom valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // ErrorProvider
                    errorProviderNom.SetError(textBoxNom, "Doit contenir des lettres");
                    return;
                }
                else
                
                {
                    // Enleve le ErrorProvider
                    errorProviderNom.Clear();
                }
                // Validation de la zone de saisie pour le code permanent
                string pattern = "^[A-Z]{4}[0-9]{6}$";

                if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxCodePerm.Text, pattern))
                {
                    // Affiche le message d'erreur 

                    MessageBox.Show("Veuillez entrer un code permanent valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // ErrorProvider
                    errorProviderCode.SetError(textBoxCodePerm, "Doit le format AAAA999999");
                    return;
                }
                else
                {
                    // Enleve le ErrorProvider
                    errorProviderCode.Clear();
                }
                // Validation de la zone de saisie pour une note
                int temp = int.Parse(numericUpDownNote1.Text);

                if (temp < 1 || temp > 100)
                {
                    // Affiche le message d'erreur 

                    MessageBox.Show("Veuillez entrer une note entre 0 et 100", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // ErrorProvider
                    errorProviderNote1.SetError(numericUpDownNote1, "Doit contenir un nombre entre 0 et 100");
                    return;
                }
                else
                {
                    // Enleve le ErrorProvider
                    errorProviderNote1.Clear();
                }

                // Validation de la zone de saisie pour une note
                int temp2 = int.Parse(numericUpDownNote2.Text);


                if (temp2 < 1 || temp2 > 100)
                {
                        // Affiche le message d'erreur 

                        MessageBox.Show("Veuillez entrer une note entre 0 et 100", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // ErrorProvider
                    errorProviderNote2.SetError(numericUpDownNote2, "Doit contenir un nombre entre 0 et 100");
                    return;
                }
                else
                {
                    // Enleve le ErrorProvider
                    errorProviderNote2.Clear();
                }
                // Validation de la zone de saisie pour une note
                int temp3 = int.Parse(numericUpDownNote3.Text);


                if (temp3 < 1 || temp3 > 100)
                {
                    // Affiche le message d'erreur 

                    MessageBox.Show("Veuillez entrer une note entre 0 et 100", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // ErrorProvider
                    errorProviderNote3.SetError(numericUpDownNote3, "Doit contenir un nombre entre 0 et 100");
                    return;
                }
                else
                {
                    // Enleve le ErrorProvider
                    errorProviderNote3.Clear();
                }
                // Validation de la zone de saisie pour une note
                int temp4 = int.Parse(numericUpDownNote4.Text);


                if (temp4 < 1 || temp4 > 100)
                {
                    // Affiche le message d'erreur 

                    MessageBox.Show("Veuillez entrer une note entre 0 et 100", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // ErrorProvider
                    errorProviderNote4.SetError(numericUpDownNote4, "Doit contenir un nombre entre 0 et 100");
                    return;
                }
                else
                {
                    // Enleve le ErrorProvider
                    errorProviderNote4.Clear();
                }
                // Validation de la zone de saisie pour une note
                int temp5 = int.Parse(numericUpDownNote5.Text);


                if (temp5 < 1 || temp5 > 100)
                {
                    // Affiche le message d'erreur 

                    MessageBox.Show("Veuillez entrer une note entre 0 et 100", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // ErrorProvider
                    errorProviderNote5.SetError(numericUpDownNote5, "Doit contenir un nombre entre 0 et 100");
                    return;
                }
                else
                {
                    // Enleve le ErrorProvider
                    errorProviderNote5.Clear();
                }
                // Creation d'un objet Étudiant
                Etudiant unEtudiant = new Etudiant(textBoxCodePerm.Text, textBoxPrenom.Text, textBoxNom.Text);
                tabEtudiant[nb_etud++] = unEtudiant;

                //Ajout de l'etudiant dans Cahier de notes
                listBoxGroupe.Items.Add(unEtudiant);

                //MessageBox qui indique les donnees ont sauvegarder
                MessageBox.Show("Les données de l’étudiant ont été sauvegardées! :)", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Message d'erreur
                MessageBox.Show("Erreur", "Donnees non-valide");
                return;
            }
            

    }

        private void numericUpDownNote5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxGrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxGrp.SelectedIndex = comboBoxGrp.SelectedIndex;
        }

        // Efface les etudiants
        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            textBoxPrenom.Clear();
            textBoxNom.Clear();
            textBoxCodePerm.Clear();
            comboBoxGrp.SelectedIndex = -1;
            numericUpDownNote1.ResetText();
            numericUpDownNote2.ResetText();
            numericUpDownNote3.ResetText();
            numericUpDownNote4.ResetText();
            numericUpDownNote5.ResetText();

        }

        //Fonction qui va permettre afficher les elements de mes objets Etudiant
        private void listBoxGroupe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Creation un objet Etudiant
            Etudiant unEtudiant = new Etudiant();
            unEtudiant = (Etudiant)listBoxGroupe.SelectedItem;

            //Boucle qui va selectionner les notes des etudiants selectionne

            foreach (Etudiant itemCourant in listBoxGroupe.SelectedItems)
            {
                textBoxNote1.Text = numericUpDownNote1.Value.ToString();
                textBoxNote2.Text = numericUpDownNote2.Value.ToString();
                textBoxNote3.Text = numericUpDownNote3.Value.ToString();
                textBoxNote4.Text = numericUpDownNote4.Value.ToString();
                textBoxNote5.Text = numericUpDownNote5.Value.ToString();

                //Moyenne generale
                double moyenneGenerale = ((double)numericUpDownNote1.Value + (double)numericUpDownNote2.Value + (double)numericUpDownNote3.Value + (double)numericUpDownNote4.Value + (double)numericUpDownNote5.Value) / 5;

                if(moyenneGenerale < 60)
                {
                    textBoxMoyenneGeneral.Text = moyenneGenerale.ToString("0.##") + "%";
                    textBoxMoyenneGeneral.BackColor = Color.Red;
                } else {
                    textBoxMoyenneGeneral.Text = moyenneGenerale.ToString("0.##")+ "%";
                    textBoxMoyenneGeneral.BackColor = Color.Green;
                }

                //Moyenne des cours ***BONUS***



            }
        }

        //Button qui supprimer etudiant selectionnee
        private void buttonSupprimerEleve_Click(object sender, EventArgs e)
        {
            //MessageBox qui demande oui/non
            DialogResult dialogResult = MessageBox.Show("Voulez-vous supprimer l’étudiant " + textBoxPrenom.Text + " " + textBoxNom.Text + " de la liste?" + "", "Message de confirmation", MessageBoxButtons.YesNo);

            //Boucle qui parcours les etudiants et supprime les donnees
            if (dialogResult == DialogResult.Yes)

                for (int items = listBoxGroupe.SelectedItems.Count - 1; items >= 0; items--)
                {
                    listBoxGroupe.Items.RemoveAt(listBoxGroupe.SelectedIndex);
                    textBoxNote1.Clear();
                    textBoxNote2.Clear();
                    textBoxNote3.Clear();
                    textBoxNote4.Clear();
                    textBoxNote5.Clear();
                    textBoxMoyenneGeneral.Clear();
                }
            else if (dialogResult == DialogResult.No)
            { 
            }
        }
    }
}
