using System;
using System.Collections;
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

namespace HW_SQLite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DataAccess.InitializeDatabase();
            //DataAccess.AddData("Suwanon Choojan");
        }

        private void BtnShowData_Click(object sender, RoutedEventArgs e)
        {
            ArrayList arrayData;
            string strData = "";
            int i = 1;
            arrayData = new ArrayList(DataAccess.GetData());
            foreach (string data in arrayData)
            {
                strData += i.ToString() + ") " + data + "@";
                i++;
            }
            strData = strData.Replace("@", Environment.NewLine);
            MessageBox.Show(strData);
        }
    }
}
