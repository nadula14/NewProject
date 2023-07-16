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

namespace StudentData
{
    /// <summary>
    /// Interaction logic for Add_Student.xaml
    /// </summary>
    public partial class Add_Student : Window
    {
        public Add_Student(Add_StudentVM vm)
        {
            InitializeComponent();
            DataContext = vm;
            vm.Close = () => Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
;