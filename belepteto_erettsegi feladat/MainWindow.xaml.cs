using System.IO;
using System.Text;
using System.Text.RegularExpressions;
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

		private void Elso_Checked(object sender, RoutedEventArgs e)
		{
			RadioButton radio = sender as RadioButton;

			if(radio.Name == "Elso")
			{
				kiir2.Text = adatok.First().ido;

			}

			if(radio.Name == "Utolso")
			{
				kiir2.Text = adatok.Last().ido;
			}

		}

        private void kereses_Click(object sender, RoutedEventArgs e)
        {
			string innen = Innen.Text;

			string idaig = Idaig.Text;

			

			Regex minta = new Regex(@"^([01]\d|2\d):[0-5]\d$");

			minta.IsMatch(innen);

			if(minta.IsMatch(innen))
			{
				Innen.Foreground = Brushes.Black;
			}
			else
			{
                Innen.Foreground = Brushes.Red;
				Innen.Focus();
            }

			if(minta.IsMatch(idaig))
			{
				Idaig.Foreground = Brushes.Black;
            }
			else
			{
				Idaig.Foreground = Brushes.Red;
				Idaig.Focus();
            }





        }
    }


}