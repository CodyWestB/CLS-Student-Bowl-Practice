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
        public static int year;
        public static int type;

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
                year = 1;
            }

            if (cmbYear.SelectedItem.ToString() == "Year B")
            {
                year = 2;
            }

            if (cmbYear.SelectedItem.ToString() == "Year C")
            {
                year = 3;
            }

            if (cmbYear.SelectedItem.ToString() == "Year D")
            {
                year = 4;
            }
        }

        private void btnMLS_Click(object sender, RoutedEventArgs e)
        {
            type = 1;

            this.Visibility = Visibility.Collapsed;
            GameSelect newGame = new GameSelect();
            MainWindow game = newGame.getNewGame();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnMLT_Click(object sender, RoutedEventArgs e)
        {
            type = 2;

            this.Visibility = Visibility.Collapsed;
            GameSelect newGame = new GameSelect();
            MainWindow game = newGame.getNewGame();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }
    }
}
