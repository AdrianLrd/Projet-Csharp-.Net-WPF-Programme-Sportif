using Modele;
using System.Windows;

namespace AppFin
{
    /// <summary>
    /// Logique d'interaction pour InfoAct.xaml
    /// </summary>
    public partial class InfoAct : Window
    {
        public InfoAct(Activite a)
        {
            InitializeComponent();

            this.nom.Text = a.NomAct;
            this.duree.Text = a.Duree.ToString();
            this.nbserie.Text = a.NbSerie.ToString();
            this.nbrep.Text = a.NbRep.ToString();
            this.desc.Text = a.Desc;
        }
    }
}
