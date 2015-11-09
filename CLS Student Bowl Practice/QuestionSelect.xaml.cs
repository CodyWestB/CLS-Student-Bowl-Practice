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

        public static string[] categoryNumber = new string[2];

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
            categoryNumber[0] = "Blood Bank";
            categoryNumber[1] = "5";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnBodyFluids5_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Body Fluids";
            categoryNumber[1] = "5";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnChemistry5_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Chemistry";
            categoryNumber[1] = "5";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnCoagulation5_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Coagulation";
            categoryNumber[1] = "5";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnHematology5_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Hematology";
            categoryNumber[1] = "5";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnImmunology5_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Immunology";
            categoryNumber[1] = "5";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnLab5_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Lab Operations";
            categoryNumber[1] = "5";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnMicro5_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Micro/Parasit/Mycol";
            categoryNumber[1] = "5";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnBlood10_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Blood Bank";
            categoryNumber[1] = "10";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnBodyFluids10_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Body Fluids";
            categoryNumber[1] = "10";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnChemisty10_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Chemistry";
            categoryNumber[1] = "10";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnCoagulation10_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Coagulation";
            categoryNumber[1] = "10";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnHematology10_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Hematology";
            categoryNumber[1] = "10";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnImmunology10_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Immunology";
            categoryNumber[1] = "10";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnLab10_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Lab Operations";
            categoryNumber[1] = "10";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnMicro10_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Micro/Parasit/Mycol";
            categoryNumber[1] = "10";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnBlood20_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Blood Bank";
            categoryNumber[1] = "20";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnBody20_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Body Fluids";
            categoryNumber[1] = "20";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnChemisty20_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Chemistry";
            categoryNumber[1] = "20";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnCoagulation20_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Coagulation";
            categoryNumber[1] = "20";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnHematology20_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Hematology";
            categoryNumber[1] = "20";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnImmunology20_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Immunology";
            categoryNumber[1] = "20";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnLab20_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Lab Operations";
            categoryNumber[1] = "20";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }

        private void btnMicro20_Click(object sender, RoutedEventArgs e)
        {
            categoryNumber[0] = "Micro/Parasit/Mycol";
            categoryNumber[1] = "20";

            this.Visibility = Visibility.Collapsed;
            Question newCategory = new Question();
            QuestionSelect category = newCategory.getNewCategory();
            this.Visibility = Visibility.Visible;
            this.ShowDialog();
        }
    }
}
