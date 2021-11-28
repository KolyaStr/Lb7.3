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

namespace LB7._3
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Store mystore = new Store();
            string str = textBox1.Text;
            int number = int.Parse(str);
            MessageBox.Show(mystore[number]);

            string name = textBox2.Text;
            MessageBox.Show(mystore[name]);
        }
    }
}
