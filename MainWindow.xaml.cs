using System;
using System.Windows;

namespace DBaInstaller
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cancelButton_C(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Вы точно хотите отменить установку?", "Отмена установки",
                MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            switch (res)
            {
                case MessageBoxResult.Yes:
                    App.Current.Shutdown();
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }

        private void ContinueButton_C(object sender, RoutedEventArgs e)
        {
            Config form = new Config();
            this.Hide();
            form.ShowDialog();
        }
    }
}
