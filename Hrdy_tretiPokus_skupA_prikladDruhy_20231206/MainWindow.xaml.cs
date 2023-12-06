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
            double leva =0;
            double prava =0;

            try
            {
                
                x = double.Parse(InputX.Text);
                y = double.Parse(InputY.Text);

                for (int i = 0; i < y; i++)
                {
                    prava = prava + 22;
                    leva = 0;
                    for(int j = 0; j < x; j++)
                    {
                        leva = leva + 22;
                        Rectangle rectangle = new Rectangle();
                        rectangle.Width = 20;
                        rectangle.Height = 20;
                        rectangle.Fill = Brushes.Red;
                        rectangle.Stroke = Brushes.Black;

                        Canvas.SetLeft(rectangle, 0+leva);
                        Canvas.SetTop(rectangle, 0+prava);

                        TheField.Children.Add(rectangle);
                    }
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Chyba vstupu! Zadávejte poute čísla prosím - {ex.Message}");
            }
        }
    }
}
