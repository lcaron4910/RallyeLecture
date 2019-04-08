using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PPE
{
    public partial class FenetrePrincipale : Form
    {
        TableNiveau niveau = new TableNiveau();
        List<Niveau> listeNiveaux;
        public FenetrePrincipale()
        {
            InitializeComponent();
            listeNiveaux = niveau.GetAll();
            foreach (Niveau n in listeNiveaux)
            {
                cbNiveau.Items.Add(n.GetniveauScolaire);
            }
            this.cbFichier.Click += new EventHandler(cbFichier_Click);
            this.btnLancer.Click += new EventHandler(btnLancer_Click);
        }

        void btnLancer_Click(object sender, EventArgs e)
        {
            bool fail = true;
            LesEleves lesEleves = new LesEleves();
            foreach (string nomFichier in this.clbFichier.SelectedItems)
            {
                if (this.cbAleatoire.Checked == true || this.cbConstruit.Checked == true)
                {
                    if (this.cbConstruit.Checked == true)
                    {
                        lesEleves.LoadCsv(PassWordType.construit, nomFichier, folderBrowserDialog1.SelectedPath);

                    }
                    else
                    {
                        lesEleves.LoadCsv(PassWordType.aleatoire, nomFichier, folderBrowserDialog1.SelectedPath);
                    }
                }
                else
                {
                    lesEleves.LoadCsv(PassWordType.construit, nomFichier, folderBrowserDialog1.SelectedPath);
                }
                fail = false;
                lesEleves.CreateCsv(string.Format("{0}_{1}",this.cbNiveau.Text,this.tbAnnee.Text),folderBrowserDialog1.SelectedPath);
            }
            if (fail == true) {
                MessageBox.Show("Intégration fail");
            }
            else
            {
                MessageBox.Show("Intégration réussit");
            }
            IntegrationBdd(lesEleves);

        }
        void IntegrationBdd(LesEleves lesEleves)
        {
            TableClasse tabClasse = new TableClasse();
            TableEnseignant tabEnseignant = new TableEnseignant();
            TableEleve tabEleve = new TableEleve();
            Enseignant enseignant = tabEnseignant.GetByLogin("enseignant@sio.jjr.fr");
            int idNiveau = 0;
            foreach (Niveau n in listeNiveaux)
            {
                if (n.GetniveauScolaire == this.cbNiveau.Text)
                {
                    idNiveau = n.GetId;
                }
            }
            int idClasse=tabClasse.Insert(new Classe(enseignant.Id, idNiveau, this.tbAnnee.Text));
            foreach (Eleve eleve in lesEleves.GetLesEleves)
            {
                tabEleve.Insert(eleve, idClasse);
            }
            
        }
        void cbFichier_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            cbFichier.Text = folderBrowserDialog1.SelectedPath;
            DirectoryInfo dir = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            FileInfo[] fichiers = dir.GetFiles("*.csv");
            foreach (FileInfo fichier in fichiers)
            {
                clbFichier.Items.Add(fichier.Name);
            }
        }

    }
}
