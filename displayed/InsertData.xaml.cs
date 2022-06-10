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
    /// Interaction logic for InsertData.xaml
    /// </summary>
    public partial class InsertData : Window
    {
        public InsertData()
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
            String query = "INSERT INTO hydrologicals (time, altm, temp, hud, wdir, wspd, vis) values (' " + 
                    Time.Text + "', " + Altm.Text + ", " + Temp.Text + ", " +
                    Hud.Text + ", " + Wdir.Text + ", " + Wspd.Text + ", " + Vis.Text + 
                    ");";
            connectDB(query);
            
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Time_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
