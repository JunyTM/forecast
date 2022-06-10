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

namespace displayed
{
    /// <summary>
    /// Interaction logic for SingIn.xaml
    /// </summary>
    public partial class SingIn : Window
    {
        public SingIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Đăng ký thành công");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            login log = new login();
            log.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
