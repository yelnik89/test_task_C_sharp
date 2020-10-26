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

namespace Test_task
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ClientServise Clients;

        public MainWindow()
        {
            InitializeComponent();
            Clients = new ClientServise();
        }

        private void FileOpenBt_Click(object sender, RoutedEventArgs e)
        {
            FileReader file = new FileReader();
            if (file.OpenFile() == true)
            {
                Clients.AddClients(file.SplitFileText());
                Clients.SaveChengesInDb();
            }
        }
    }
}
