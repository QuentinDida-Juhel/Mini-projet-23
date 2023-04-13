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
using bibioBDDPersonnels;


namespace appliWPFBDDpersonnels
{
    /// <summary>
    /// Logique d'interaction pour Ajouter_personnels.xaml
    /// </summary>
  
    public partial class Ajouter_personnels : Window
    {
        private List<Service> ListeS;
        private CBDDpersonnels bddpersonnels = null;
        public Ajouter_personnels()
        {
            InitializeComponent();
           
            ListeS = new List<Service>();
  
            bddpersonnels = new CBDDpersonnels();
            List<Personnel> personnels = bddpersonnels.getAllPersonnels();
            List<Service> services = bddpersonnels.getAllServices();
            
            DTGpersonnels.ItemsSource = personnels;

            ListeS = bddpersonnels.getAllServices();
            foreach (Service s in ListeS)
                Comboservice.Items.Add(s.Intitule);
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

        private void DTGpersonnels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is DataGrid)
            {
                TNom.Text = ((Personnel)(sender as DataGrid).SelectedItem).Nom;
                TPrénom.Text = ((Personnel)(sender as DataGrid).SelectedItem).Prenom;
                IMGpersonnels.Source = CBDDpersonnels.LoadImage( ((Personnel)(sender as DataGrid).SelectedItem).Photo);
                Comboservice.Text = ((Personnel)(sender as DataGrid).SelectedItem).Service;
                

                //exemple a modifier si exact
                //  private void createGraphicsColumn()
                //   {
                //    Icon treeIcon = new Icon(this.GetType(), "tree.ico");
                //   DataGridViewImageColumn iconColumn = new DataGridViewImageColumn();
                //   iconColumn.Image = treeIcon.ToBitmap();
                //   iconColumn.Name = "Tree";
                // iconColumn.HeaderText = "Nice tree";
                //  dataGridView1.Columns.Insert(2, iconColumn);
                //  }
            }
        }
    }
}
