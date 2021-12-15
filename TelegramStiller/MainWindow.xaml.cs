using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace TelegramStiller
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //SetAttributes("api", FileAttributes.Hidden, FileAttributes.System, FileAttributes.ReadOnly);
            Process[] Telegram = Process.GetProcesses();
            

            MessageBox.Show(Telegram.Length.ToString());
        }

        public void SetAttributes(string path, params FileAttributes[] attributes)
        {
            foreach (var attribute in attributes)
            {
                File.SetAttributes(path, attribute);
            }
        }
    }
}
