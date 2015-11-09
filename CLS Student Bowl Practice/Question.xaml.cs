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
    /// Interaction logic for Question.xaml
    /// </summary>
    public partial class Question : Window
    {
        private QuestionSelect category = null;


        public Question()
        {
            InitializeComponent();
        }

        private void question_onLoad(object sender, RoutedEventArgs e)
        {

            if (QuestionSelect.categoryNumber == 1)
            {
                lblCategory.Content = "Blood Bank";
                lblAmount.Content = "5";
            }

            if (QuestionSelect.categoryNumber == 2)
            {
                lblCategory.Content = "Body Fluids";
                lblAmount.Content = "5";
            }

            if (QuestionSelect.categoryNumber == 3)
            {
                lblCategory.Content = "Chemistry";
                lblAmount.Content = "5";
            }

            if (QuestionSelect.categoryNumber == 4)
            {
                lblCategory.Content = "Coagulation";
                lblAmount.Content = "5";
            }

            if (QuestionSelect.categoryNumber == 5)
            {
                lblCategory.Content = "Hematology";
                lblAmount.Content = "5";
            }

            if (QuestionSelect.categoryNumber == 6)
            {
                lblCategory.Content = "Immunology";
                lblAmount.Content = "5";
            }

            if (QuestionSelect.categoryNumber == 7)
            {
                lblCategory.Content = "Lab Operations";
                lblAmount.Content = "5";
            }

            if (QuestionSelect.categoryNumber == 8)
            {
                lblCategory.Content = "Micro/Parasit/Mycol";
                lblAmount.Content = "5";
            }

            if (QuestionSelect.categoryNumber == 9)
            {
                lblCategory.Content = "Blood Bank";
                lblAmount.Content = "10";
            }

            if (QuestionSelect.categoryNumber == 10)
            {
                lblCategory.Content = "Body Fluids";
                lblAmount.Content = "10";
            }

            if (QuestionSelect.categoryNumber == 11)
            {
                lblCategory.Content = "Chemistry";
                lblAmount.Content = "10";
            }

            if (QuestionSelect.categoryNumber == 12)
            {
                lblCategory.Content = "Coagulation";
                lblAmount.Content = "10";
            }

            if (QuestionSelect.categoryNumber == 13)
            {
                lblCategory.Content = "Hematology";
                lblAmount.Content = "10";
            }

            if (QuestionSelect.categoryNumber == 14)
            {
                lblCategory.Content = "Immunology";
                lblAmount.Content = "10";
            }

            if (QuestionSelect.categoryNumber == 15)
            {
                lblCategory.Content = "Lab Operations";
                lblAmount.Content = "10";
            }

            if (QuestionSelect.categoryNumber == 16)
            {
                lblCategory.Content = "Micro/Parasit/Mycol";
                lblAmount.Content = "10";
            }

            if (QuestionSelect.categoryNumber == 17)
            {
                lblCategory.Content = "Blood Bank";
                lblAmount.Content = "20";
            }

            if (QuestionSelect.categoryNumber == 18)
            {
                lblCategory.Content = "Body Fluids";
                lblAmount.Content = "20";
            }

            if (QuestionSelect.categoryNumber == 19)
            {
                lblCategory.Content = "Chemistry";
                lblAmount.Content = "20";
            }

            if (QuestionSelect.categoryNumber == 20)
            {
                lblCategory.Content = "Coagulation";
                lblAmount.Content = "20";
            }

            if (QuestionSelect.categoryNumber == 21)
            {
                lblCategory.Content = "Hematology";
                lblAmount.Content = "20";
            }

            if (QuestionSelect.categoryNumber == 22)
            {
                lblCategory.Content = "Immunology";
                lblAmount.Content = "20";
            }

            if (QuestionSelect.categoryNumber == 23)
            {
                lblCategory.Content = "Lab Operations";
                lblAmount.Content = "20";
            }

            if (QuestionSelect.categoryNumber == 24)
            {
                lblCategory.Content = "Micro/Parasit/Mycol";
                lblAmount.Content = "20";
            }
        }

        internal QuestionSelect getNewCategory()
        {
            this.ShowDialog();
            return category;
        }
    }
}
