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
using System.Windows.Navigation;
using System.Windows.Shapes;
using bibioBDDPersonnels;
using BddpersonnelContext;

namespace appliWPFBDDpersonnels
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CBDDpersonnels bddpersonnels = null;
        public MainWindow()
        {
            InitializeComponent();
            bddpersonnels = new CBDDpersonnels();
            List<Service> services = bddpersonnels.getAllServices();
            datagridServices.ItemsSource = services;
        }

        private void BtAjouter2_Click(object sender, RoutedEventArgs e)
        {
            Ajouter_personnels  cl = new Ajouter_personnels();
            cl.ShowDialog();
        }

        private void BtQuitter2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void datagridServices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
