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

namespace CLS_Student_Bowl_Practice
{
    /// <summary>
    /// Interaction logic for GameSelect.xaml
    /// </summary>
    public partial class GameSelect : Window
    {
        private MainWindow game = null;

        public GameSelect()
        {
            InitializeComponent();
        }

        private void gameSelect_onLoad(object sender, RoutedEventArgs e)
        {
            if (MainWindow.type == 1)
            {
                lblType.Content = "MLS";
            }

            if (MainWindow.type == 2)
            {
                lblType.Content = "MLT";
            }

            if (MainWindow.year == 1)
            {
                lblYear.Content = "Year A";
            }

            if (MainWindow.year == 2)
            {
                lblYear.Content = "Year B";
            }

            if (MainWindow.year == 3)
            {
                lblYear.Content = "Year C";
            }

            if (MainWindow.year == 4)
            {
                lblYear.Content = "Year D";
            }
        }

        internal MainWindow getNewGame()
        {
            this.ShowDialog();
            return game;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
