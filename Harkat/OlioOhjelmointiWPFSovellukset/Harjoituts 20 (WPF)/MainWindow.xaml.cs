using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Harjoituts_20__WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void OpiskelijaIDValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btnAddOpiskelija_Click(object sender, RoutedEventArgs e)
        {
            string etunimi = etunimiInput.Text;
            string sukunimi = sukunimiInput.Text;
            string opiskelijaID = opiskelijaIDInput.Text;

            if (etunimi.Length < 2 || sukunimi.Length < 2 || opiskelijaID.Length < 2)
            {
                return;
            }

            try
            {
                if (KokoelmaManageri.TarkistaID(opiskelijaID))
                {
                    KokoelmaManageri.LisääOpiskelija(etunimi, sukunimi, opiskelijaID);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                ClearInputFields();
            }

            RefreshGrid();
        }

        private void ClearInputFields()
        {
            etunimiInput.Text = "";
            sukunimiInput.Text = "";
            opiskelijaIDInput.Text = "";
        }

        private void RefreshGrid()
        {
            OpiskelijatGrid.ItemsSource = KokoelmaManageri.PalautaOpiskelijat();
        }
    }
}
