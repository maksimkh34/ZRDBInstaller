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
            if (!DBEncryption.isAdminRights())
            {
                MessageBoxResult res = MessageBox.Show("Пожалуйста, перезапустите установщик с правами администратора.", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
                Environment.Exit(-1);
            }
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
