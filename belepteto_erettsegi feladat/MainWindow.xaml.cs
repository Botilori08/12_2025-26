using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace belepteto_erettsegi_feladat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            betoltes();
        }
        List<Adat> adatok = new List<Adat>();
        void betoltes()
        {
            string[] sorok = File.ReadAllLines("bedat.txt");

            foreach (var sor in sorok)
            {
                adatok.Add(new Adat(sor));
            }



        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }


}