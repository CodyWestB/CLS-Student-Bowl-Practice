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
    /// Interaction logic for QuestionSelect.xaml
    /// </summary>
    public partial class QuestionSelect : Window
    {
        private GameSelect question = null;

        public static int categoryNumber;

        public QuestionSelect()
        {
            InitializeComponent();
        }
        
        internal GameSelect getNewQuestion()
        {
            this.ShowDialog();
            return question;
        }

        private void btnBlood5_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 1;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnBodyFluids5_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 2;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnChemistry5_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 3;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnCoagulation5_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 4;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnHematology5_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 5;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnImmunology5_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 6;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnLab5_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 7;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnMicro5_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 8;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnBlood10_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 9;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnBodyFluids10_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 10;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnChemisty10_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 11;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnCoagulation10_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 12;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnHematology10_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 13;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnImmunology10_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 14;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnLab10_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 15;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnMicro10_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 16;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnBlood20_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 17;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnBody20_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 18;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnChemisty20_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 19;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnCoagulation20_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 20;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnHematology20_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 21;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnImmunology20_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 22;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnLab20_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 23;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnMicro20_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber = 24;

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }
    }
}
