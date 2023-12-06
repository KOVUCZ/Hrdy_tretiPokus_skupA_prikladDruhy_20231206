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

namespace Hrdy_tretiPokus_skupA_prikladDruhy_20231206
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

        private void GenerateClick_Click(object sender, RoutedEventArgs e)
        {
            double x;
            double y;

            try
            {
                x = double.Parse(InputX.Text);
                y = double.Parse(InputY.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"chyba vstupu! zadávejte poute čísla prosím - {ex.Message}");
            }
        }
    }
}
