using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BddpersonnelContext;

namespace appliWPFBDDpersonnels
{
    /// <summary>
    /// Logique d'interaction pour Ajouter_personnels.xaml
    /// </summary>
    public partial class Ajouter_personnels : Window
    {
        private List<Service> ListeS;
        public Ajouter_personnels()
        {
            InitializeComponent();
            ListeS = new List<Service>();
            Comboservice.Items.Add("Vie scolaire");
            Comboservice.Items.Add("Prof de maths");
            Comboservice.Items.Add("Informatique");
            Comboservice.Items.Add("Agricole");
            Comboservice.Items.Add("Bois");
            Comboservice.Items.Add("Automobile");
            Comboservice.Items.Add("Service 911");
            Comboservice.Items.Add("Administration");

        }

        private void BQuitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Comboservice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.BAjouter.Visibility = Visibility.Visible;
            this.BtModifier.Visibility = Visibility.Visible;
        }

        private void BtSupprimer_Click(object sender, RoutedEventArgs e)
        {
            
            TNom.Text = "";
            TPrénom.Text = "";
            Comboservice.Items.Clear();
            MessageBox.Show("Tous les informations ont étaient supprimées");
        }

        private void BtModifier_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Les modifications on été prise en compte");
          
        }

        private void BAjouter_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Veillez saisir toutes les informations");
           
        }

        private void TNom_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.BAjouter.Visibility = Visibility.Visible;
            this.BtModifier.Visibility = Visibility.Visible;
        }

        private void TPrénom_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.BAjouter.Visibility = Visibility.Visible;
            this.BtModifier.Visibility = Visibility.Visible;
        }
    }
}
