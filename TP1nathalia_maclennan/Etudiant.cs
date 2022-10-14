using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1nathalia_maclennan
{
    //Initialisation de variables
    class Etudiant
    {
        public String codePerm { get; set; }
        public String prenom { get; set; }
        public String nom { get; set; }
        public String[] matieres { get; set; }
        public int[] notes { get; set; }

      //Constructeur
      public Etudiant()
        {
            codePerm = null;
            prenom = null;
            nom = null;
            matieres = null;
            notes = null;
        }
        //Constructeur avec param.
        public Etudiant(string pCodePerm, string pPrenom, string pNom)
            {
            codePerm = pCodePerm;
            prenom = pPrenom;
            nom = pNom;
        }
        //Fonction afficher le prenom et le nom dans Cahier etudiant

        public override string ToString()
        {
            return prenom + " " + nom;
        }
    }
}
