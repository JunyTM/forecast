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
    /// Interaction logic for login.xaml
    /// </summary>
    /// 

    public class Profile
    {
        public String STT { get; set; }
        public String UserName { get; set; }
        public String PassWord { get; set; }
        public String Email { get; set; }
    }

    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }


        public DataTable connectDB(String query)
        {
            const string env = @"Data Source = E:\C#\forecast\forecast.db";

            SQLiteConnection connect = new SQLiteConnection(env);
            connect.Open();
            SQLiteDataAdapter router = new SQLiteDataAdapter();
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = query;
            router.SelectCommand = cmd;
            cmd.Connection = connect;
            //SQLiteDataReader reader = cmd.ExecuteReader();
            
            DataSet ds = new DataSet();
            DataTable data = new DataTable();
            router.Fill(ds, "dataSet");
            data = ds.Tables["dataSet"];

            //return reader;
            return data;
        }

        private void loginAcount_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //String query = "SELECT * from profiles";
                String query = "SELECT * from profiles WHERE account = '" + userName.Text + "' AND passwork = '" + passWord.Text + "';";
                //SQLiteDataReader reader =  connectDB(query);
                DataTable data = connectDB(query);
                Profile profile = new Profile();
                foreach (DataRow col in data.Rows)
                {
                    profile.STT = col["id"].ToString();
                    profile.UserName = col["account"].ToString();
                    profile.PassWord = col["passwork"].ToString();
                }

                if (profile.STT != null)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                } else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai");
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Signin_Click(object sender, RoutedEventArgs e)
        {
            SingIn  signIn = new SingIn();
            signIn.Show();
            this.Close();
        }

        private void ResetPassword_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
