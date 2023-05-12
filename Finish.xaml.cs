using System;
using System.Windows;
using IWshRuntimeLibrary;

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
            Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
