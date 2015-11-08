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

        internal QuestionSelect getNewCategory()
        {
            this.ShowDialog();
            return category;
        }
    }
}
