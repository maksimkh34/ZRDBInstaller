using System;
using System.Windows;

namespace DBaInstaller
{
    /// <summary>
    /// Логика взаимодействия для Finish.xaml
    /// </summary>
    public partial class Finish : Window
    {
        public Finish()
        {
            InitializeComponent();
        }

        private void returnButton_C(object sender, RoutedEventArgs e)
        {
            if ((bool)startDB_cb.IsChecked)
            {
                string path = "";
                if ((bool)Application.Current.Properties["isUpdating"])
                {
                    path += Application.Current.Properties["updatingPath"];
                }
                else
                {
                    path += Application.Current.Properties["installingPath"];
                }
                path += "\\ZRDB.exe";
                System.Diagnostics.Process.Start(path);
            }
            Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
