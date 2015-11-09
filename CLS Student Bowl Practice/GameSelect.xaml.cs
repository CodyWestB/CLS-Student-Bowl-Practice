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
            lblType.Content = MainWindow.selectedQuestion[0];
            lblYear.Content = MainWindow.selectedQuestion[1];
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[2] = "1";

            this.Visibility = Visibility.Collapsed;
            QuestionSelect newQuestion = new QuestionSelect();
            GameSelect question = newQuestion.getNewQuestion();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[2] = "2";

            this.Visibility = Visibility.Collapsed;
            QuestionSelect newQuestion = new QuestionSelect();
            GameSelect question = newQuestion.getNewQuestion();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[2] = "3";

            this.Visibility = Visibility.Collapsed;
            QuestionSelect newQuestion = new QuestionSelect();
            GameSelect question = newQuestion.getNewQuestion();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[2] = "4";

            this.Visibility = Visibility.Collapsed;
            QuestionSelect newQuestion = new QuestionSelect();
            GameSelect question = newQuestion.getNewQuestion();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[2] = "5";

            this.Visibility = Visibility.Collapsed;
            QuestionSelect newQuestion = new QuestionSelect();
            GameSelect question = newQuestion.getNewQuestion();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[2] = "6";

            this.Visibility = Visibility.Collapsed;
            QuestionSelect newQuestion = new QuestionSelect();
            GameSelect question = newQuestion.getNewQuestion();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[2] = "7";

            this.Visibility = Visibility.Collapsed;
            QuestionSelect newQuestion = new QuestionSelect();
            GameSelect question = newQuestion.getNewQuestion();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[2] = "8";

            this.Visibility = Visibility.Collapsed;
            QuestionSelect newQuestion = new QuestionSelect();
            GameSelect question = newQuestion.getNewQuestion();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }
    }
}
