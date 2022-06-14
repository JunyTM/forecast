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
        FileView selectItem = new FileView();
        public InsertData()
        {
            InitializeComponent();
        }

        public InsertData(FileView item)
        {
            this.selectItem = item;
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
            MessageBox.Show("Tạo dữ liệu thành công");
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Time_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_update(object sender, RoutedEventArgs e)
        {
            try
            {
                String query = "UPDATE  hydrologicals SET " +
                    "time = '" + Time.Text + "', altm = " + Altm.Text + ", temp = " + 
                    Temp.Text + ", hud = " + Hud.Text + ", wdir = " + Wdir.Text + ", wspd = " + 
                    Wspd.Text + ", vis = " + Vis.Text + 
                    " WHERE id = " + selectItem.STT + " ;";
                connectDB(query);
                MessageBox.Show("Cập nhập dữ liệu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chọn dữ liệu muốn cập nhập");
            }
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
