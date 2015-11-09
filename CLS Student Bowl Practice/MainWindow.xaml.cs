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

namespace CLS_Student_Bowl_Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string[] selectedQuestion = new[] { "0", "0", "0", "0", "0", "0" };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_onLoad(object sender, RoutedEventArgs e)
        {
            cmbYear.Items.Add("Year A");
            cmbYear.Items.Add("Year B");
            cmbYear.Items.Add("Year C");
            cmbYear.Items.Add("Year D");
        }

        private void cmbYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbYear.SelectedItem.ToString() == "Year A")
            {
                selectedQuestion[0] = "Year A";
            }

            if (cmbYear.SelectedItem.ToString() == "Year B")
            {
                selectedQuestion[0] = "Year B";
            }

            if (cmbYear.SelectedItem.ToString() == "Year C")
            {
                selectedQuestion[0] = "Year C";
            }

            if (cmbYear.SelectedItem.ToString() == "Year D")
            {
                selectedQuestion[0] = "Year D";
            }
        }

        private void btnMLS_Click(object sender, RoutedEventArgs e)
        {
            selectedQuestion[1] = "MLS";

            this.Visibility = Visibility.Collapsed;
            GameSelect newGame = new GameSelect();
            MainWindow game = newGame.getNewGame();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnMLT_Click(object sender, RoutedEventArgs e)
        {
            selectedQuestion[1] = "MLT";

            this.Visibility = Visibility.Collapsed;
            GameSelect newGame = new GameSelect();
            MainWindow game = newGame.getNewGame();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }
    }
}
