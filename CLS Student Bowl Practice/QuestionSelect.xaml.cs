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

        public QuestionSelect()
        {
            InitializeComponent();
        }

        private void questionSelect_onLoad(object sender, RoutedEventArgs e)
        {
            lblType.Content = MainWindow.selectedQuestion[1];
            lblYear.Content = MainWindow.selectedQuestion[0];
        }

        internal GameSelect getNewQuestion()
        {
            this.ShowDialog();
            return question;
        }

        private void btnBlood5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Blood Bank";
            MainWindow.selectedQuestion[4] = "5";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnBodyFluids5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Body Fluids";
            MainWindow.selectedQuestion[4] = "5";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnChemistry5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Chemistry";
            MainWindow.selectedQuestion[4] = "5";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnCoagulation5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Coagulation";
            MainWindow.selectedQuestion[4] = "5";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnHematology5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Hematology";
            MainWindow.selectedQuestion[4] = "5";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnImmunology5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Immunology";
            MainWindow.selectedQuestion[4] = "5";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnLab5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Lab Operations";
            MainWindow.selectedQuestion[4] = "5";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnMicro5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Micro/Parasit/Mycol";
            MainWindow.selectedQuestion[4] = "5";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnBlood10_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Blood Bank";
            MainWindow.selectedQuestion[4] = "10";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnBodyFluids10_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Body Fluids";
            MainWindow.selectedQuestion[4] = "10";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnChemisty10_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Chemistry";
            MainWindow.selectedQuestion[4] = "10";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnCoagulation10_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Coagulation";
            MainWindow.selectedQuestion[4] = "10";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnHematology10_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Hematology";
            MainWindow.selectedQuestion[4] = "10";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnImmunology10_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Immunology";
            MainWindow.selectedQuestion[4] = "10";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnLab10_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Lab Operations";
            MainWindow.selectedQuestion[4] = "10";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnMicro10_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Micro/Parasit/Mycol";
            MainWindow.selectedQuestion[4] = "10";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnBlood20_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Blood Bank";
            MainWindow.selectedQuestion[4] = "20";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnBody20_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Body Fluids";
            MainWindow.selectedQuestion[4] = "20";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnChemisty20_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Chemistry";
            MainWindow.selectedQuestion[4] = "20";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnCoagulation20_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Coagulation";
            MainWindow.selectedQuestion[4] = "20";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnHematology20_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Hematology";
            MainWindow.selectedQuestion[4] = "20";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnImmunology20_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Immunology";
            MainWindow.selectedQuestion[4] = "20";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnLab20_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Lab Operations";
            MainWindow.selectedQuestion[4] = "20";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnMicro20_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.selectedQuestion[3] = "Micro/Parasit/Mycol";
            MainWindow.selectedQuestion[4] = "20";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }
    }
}
