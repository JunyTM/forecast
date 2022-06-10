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
using System.Data.SQLite;
using System.Data;

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

        public void connectDB(String query)
        {
            const string env = @"Data Source = E:\C#\forecast\forecast.db";

            SQLiteConnection connect = new SQLiteConnection(env);
            connect.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, connect);
            cmd.ExecuteNonQuery();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (passWord.Text.Equals(resPassWord.Text))
            {
                String query = "INSERT INTO profiles (account, passwork, gmail) values ('" +
                        userName.Text + "', '" + passWord.Text + "', '" + email.Text + "'" +
                        ");";
                connectDB(query);
                MessageBox.Show("Đăng ký thành công");
                login log = new login();
                log.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nhập lại mật khẩu sai");
            }
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
