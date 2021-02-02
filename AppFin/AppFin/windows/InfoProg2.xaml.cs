using Modele;
using System.Windows;

namespace AppFin
{
    /// <summary>
    /// Logique d'interaction pour InfoProg2.xaml
    /// </summary>
    public partial class InfoProg2 : Window
    {
        public InfoProg2(Programme p)
        {
            InitializeComponent();

            this.nom.Text = p.NomProg;
            this.note.Text = p.Note.ToString();
            this.periodicite.Text = p.Periodicite;
            this.intensite.Text = p._intensite.ToString();
            this.objectif.Text = p._objectif.ToString();
        }
    }
}
