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
using System.Data.SQLite;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Diagnostics;

namespace displayed
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public class FileView
    {
        public String STT { get; set; }
        public String Time { get; set; }
        public String Altm { get; set; }
        public String Temp { get; set; }
        public String Hud { get; set; }
        public String Wdir { get; set; }
        public String Wspd { get; set; }
        public String Vis { get; set; }

    }

    public partial class MainWindow : Window
    {
        FileView fileDelete = new FileView();
        public MainWindow()
        {
            InitializeComponent();


            string query = "SELECT * FROM hydrologicals";
            DataTable data = connectDB(query);

            List<FileView> files = new List<FileView>();
            foreach (DataRow col in data.Rows)
            {
                files.Add(new FileView()
                {
                    STT = col["id"].ToString(),
                    Time = col["time"].ToString(),
                    Altm = col["altm"].ToString(),
                    Temp = col["temp"].ToString(),
                    Hud = col["hud"].ToString(),
                    Wdir = col["wdir"].ToString(),
                    Wspd = col["wspd"].ToString(),
                    Vis =col["vis"].ToString(),
                });
            }
            ListView.ItemsSource= files;
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
            return data;
        }


        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FileView selectItem = (FileView)ListView.SelectedItems;
            MessageBox.Show(selectItem.Temp)

        }

        private void Button_Insert(object sender, RoutedEventArgs e)
        {
            InsertData insertView = new InsertData();
            insertView.Show();
            this.Close();
        }

        private void Button_Filter(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            /*
            const string env = @"Data Source = E:\C#\forecast\forecast.db";
            String query = "DELETE FROM hydrologicals WHERE ";

            SQLiteConnection connect = new SQLiteConnection(env);
            connect.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, connect);
            cmd.ExecuteNonQuery();
            */

            ListView.Items.RemoveAt(ListView.Items.IndexOf(ListView.SelectedItem));

        }
    }
}
