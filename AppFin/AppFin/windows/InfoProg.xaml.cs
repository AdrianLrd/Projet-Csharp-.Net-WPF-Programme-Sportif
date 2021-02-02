using AppFin.Menu1;
using Modele;
using System.Windows;

namespace AppFin.windows
{
    /// <summary>
    /// Logique d'interaction pour InfoProg.xaml
    /// </summary>
    public partial class InfoProg : Window
    {

        public InfoProg(int p)
        {
            InitializeComponent();
            if (p == 1)
            {
                Programme p1 = new Programme("prog1", "MaisonSport", 4, "Lundi, Mardi", Intensite.Intermediaire, Objectif.Perte);
                this.nom.Text = p1.NomProg;
                this.note.Text = p1.Note.ToString();
                this.periodicite.Text = p1.Periodicite;
                this.intensite.Text = p1._intensite.ToString();
                this.objectif.Text = p1._objectif.ToString();

            }
            
            if(p == 2)
            {
                Programme p2 = new Programme("prog2", "Maison", 3, "Jeudi, Dimanche", Intensite.Expert, Objectif.Prise);
                this.nom.Text = p2.NomProg;
                this.note.Text = p2.Note.ToString();
                this.periodicite.Text = p2.Periodicite;
                this.intensite.Text = p2._intensite.ToString();
                this.objectif.Text = p2._objectif.ToString();
            }

            if(p == 3)
            {
                Programme p3 = new Programme("prog3", "SalleSport", 5, "Lundi", Intensite.Debutant, Objectif.Tonifier);
                this.nom.Text = p3.NomProg;
                this.note.Text = p3.Note.ToString();
                this.periodicite.Text = p3.Periodicite;
                this.intensite.Text = p3._intensite.ToString();
                this.objectif.Text = p3._objectif.ToString();
            }

            if (p == 4)
            {
                Programme p1 = new Programme("prog1", "MaisonSport", 4, "Lundi, Mardi", Intensite.Intermediaire, Objectif.Perte);
                this.nom.Text = p1.NomProg;
                this.note.Text = p1.Note.ToString();
                this.periodicite.Text = p1.Periodicite;
                this.intensite.Text = p1._intensite.ToString();
                this.objectif.Text = p1._objectif.ToString();

            }

            if (p == 5)
            {
                Programme p2 = new Programme("prog2", "Maison", 3, "Jeudi, Dimanche", Intensite.Expert, Objectif.Prise);
                this.nom.Text = p2.NomProg;
                this.note.Text = p2.Note.ToString();
                this.periodicite.Text = p2.Periodicite;
                this.intensite.Text = p2._intensite.ToString();
                this.objectif.Text = p2._objectif.ToString();
            }

            if (p == 6)
            {
                Programme p3 = new Programme("prog3", "SalleSport", 5, "Lundi", Intensite.Debutant, Objectif.Tonifier);
                this.nom.Text = p3.NomProg;
                this.note.Text = p3.Note.ToString();
                this.periodicite.Text = p3.Periodicite;
                this.intensite.Text = p3._intensite.ToString();
                this.objectif.Text = p3._objectif.ToString();
            }

            if (p == 7)
            {
                Programme p1 = new Programme("prog1", "MaisonSport", 4, "Lundi, Mardi", Intensite.Intermediaire, Objectif.Perte);
                this.nom.Text = p1.NomProg;
                this.note.Text = p1.Note.ToString();
                this.periodicite.Text = p1.Periodicite;
                this.intensite.Text = p1._intensite.ToString();
                this.objectif.Text = p1._objectif.ToString();

            }

            if (p == 8)
            {
                Programme p2 = new Programme("prog2", "Maison", 3, "Jeudi, Dimanche", Intensite.Expert, Objectif.Prise);
                this.nom.Text = p2.NomProg;
                this.note.Text = p2.Note.ToString();
                this.periodicite.Text = p2.Periodicite;
                this.intensite.Text = p2._intensite.ToString();
                this.objectif.Text = p2._objectif.ToString();
            }

            if (p == 9)
            {
                Programme p3 = new Programme("prog3", "SalleSport", 5, "Lundi", Intensite.Debutant, Objectif.Tonifier);
                this.nom.Text = p3.NomProg;
                this.note.Text = p3.Note.ToString();
                this.periodicite.Text = p3.Periodicite;
                this.intensite.Text = p3._intensite.ToString();
                this.objectif.Text = p3._objectif.ToString();
            }

            if (p == 10)
            {
                Programme p1 = new Programme("prog1", "MaisonSport", 4, "Lundi, Mardi", Intensite.Intermediaire, Objectif.Perte);
                this.nom.Text = p1.NomProg;
                this.note.Text = p1.Note.ToString();
                this.periodicite.Text = p1.Periodicite;
                this.intensite.Text = p1._intensite.ToString();
                this.objectif.Text = p1._objectif.ToString();

            }

            if (p == 11)
            {
                Programme p2 = new Programme("prog2", "Maison", 3, "Jeudi, Dimanche", Intensite.Expert, Objectif.Prise);
                this.nom.Text = p2.NomProg;
                this.note.Text = p2.Note.ToString();
                this.periodicite.Text = p2.Periodicite;
                this.intensite.Text = p2._intensite.ToString();
                this.objectif.Text = p2._objectif.ToString();
            }

            if (p == 12)
            {
                Programme p3 = new Programme("prog3", "SalleSport", 5, "Lundi", Intensite.Debutant, Objectif.Tonifier);
                this.nom.Text = p3.NomProg;
                this.note.Text = p3.Note.ToString();
                this.periodicite.Text = p3.Periodicite;
                this.intensite.Text = p3._intensite.ToString();
                this.objectif.Text = p3._objectif.ToString();
            }
            if (p == 13)
            {
                Programme p1 = new Programme("prog1", "MaisonSport", 4, "Lundi, Mardi", Intensite.Intermediaire, Objectif.Perte);
                this.nom.Text = p1.NomProg;
                this.note.Text = p1.Note.ToString();
                this.periodicite.Text = p1.Periodicite;
                this.intensite.Text = p1._intensite.ToString();
                this.objectif.Text = p1._objectif.ToString();

            }

            if (p == 14)
            {
                Programme p2 = new Programme("prog2", "Maison", 3, "Jeudi, Dimanche", Intensite.Expert, Objectif.Prise);
                this.nom.Text = p2.NomProg;
                this.note.Text = p2.Note.ToString();
                this.periodicite.Text = p2.Periodicite;
                this.intensite.Text = p2._intensite.ToString();
                this.objectif.Text = p2._objectif.ToString();
            }

            if (p == 15)
            {
                Programme p3 = new Programme("prog3", "SalleSport", 5, "Lundi", Intensite.Debutant, Objectif.Tonifier);
                this.nom.Text = p3.NomProg;
                this.note.Text = p3.Note.ToString();
                this.periodicite.Text = p3.Periodicite;
                this.intensite.Text = p3._intensite.ToString();
                this.objectif.Text = p3._objectif.ToString();
            }

            if (p == 16)
            {
                Programme p1 = new Programme("prog1", "MaisonSport", 4, "Lundi, Mardi", Intensite.Intermediaire, Objectif.Perte);
                this.nom.Text = p1.NomProg;
                this.note.Text = p1.Note.ToString();
                this.periodicite.Text = p1.Periodicite;
                this.intensite.Text = p1._intensite.ToString();
                this.objectif.Text = p1._objectif.ToString();

            }

            if (p == 17)
            {
                Programme p2 = new Programme("prog2", "Maison", 3, "Jeudi, Dimanche", Intensite.Expert, Objectif.Prise);
                this.nom.Text = p2.NomProg;
                this.note.Text = p2.Note.ToString();
                this.periodicite.Text = p2.Periodicite;
                this.intensite.Text = p2._intensite.ToString();
                this.objectif.Text = p2._objectif.ToString();
            }

            if (p == 18)
            {
                Programme p3 = new Programme("prog3", "SalleSport", 5, "Lundi", Intensite.Debutant, Objectif.Tonifier);
                this.nom.Text = p3.NomProg;
                this.note.Text = p3.Note.ToString();
                this.periodicite.Text = p3.Periodicite;
                this.intensite.Text = p3._intensite.ToString();
                this.objectif.Text = p3._objectif.ToString();
            }

            if (p == 19)
            {
                Programme p1 = new Programme("prog1", "MaisonSport", 4, "Lundi, Mardi", Intensite.Intermediaire, Objectif.Perte);
                this.nom.Text = p1.NomProg;
                this.note.Text = p1.Note.ToString();
                this.periodicite.Text = p1.Periodicite;
                this.intensite.Text = p1._intensite.ToString();
                this.objectif.Text = p1._objectif.ToString();

            }

            if (p == 20)
            {
                Programme p2 = new Programme("prog2", "Maison", 3, "Jeudi, Dimanche", Intensite.Expert, Objectif.Prise);
                this.nom.Text = p2.NomProg;
                this.note.Text = p2.Note.ToString();
                this.periodicite.Text = p2.Periodicite;
                this.intensite.Text = p2._intensite.ToString();
                this.objectif.Text = p2._objectif.ToString();
            }

            if (p == 21)
            {
                Programme p3 = new Programme("prog3", "SalleSport", 5, "Lundi", Intensite.Debutant, Objectif.Tonifier);
                this.nom.Text = p3.NomProg;
                this.note.Text = p3.Note.ToString();
                this.periodicite.Text = p3.Periodicite;
                this.intensite.Text = p3._intensite.ToString();
                this.objectif.Text = p3._objectif.ToString();
            }

            if (p == 22)
            {
                Programme p1 = new Programme("prog1", "MaisonSport", 4, "Lundi, Mardi", Intensite.Intermediaire, Objectif.Perte);
                this.nom.Text = p1.NomProg;
                this.note.Text = p1.Note.ToString();
                this.periodicite.Text = p1.Periodicite;
                this.intensite.Text = p1._intensite.ToString();
                this.objectif.Text = p1._objectif.ToString();

            }

            if (p == 23)
            {
                Programme p2 = new Programme("prog2", "Maison", 3, "Jeudi, Dimanche", Intensite.Expert, Objectif.Prise);
                this.nom.Text = p2.NomProg;
                this.note.Text = p2.Note.ToString();
                this.periodicite.Text = p2.Periodicite;
                this.intensite.Text = p2._intensite.ToString();
                this.objectif.Text = p2._objectif.ToString();
            }

            if (p == 24)
            {
                Programme p3 = new Programme("prog3", "SalleSport", 5, "Lundi", Intensite.Debutant, Objectif.Tonifier);
                this.nom.Text = p3.NomProg;
                this.note.Text = p3.Note.ToString();
                this.periodicite.Text = p3.Periodicite;
                this.intensite.Text = p3._intensite.ToString();
                this.objectif.Text = p3._objectif.ToString();
            }
        }
    }
}
