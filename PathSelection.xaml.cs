using System;
using System.IO;
using System.Windows;
using WinForms = System.Windows.Forms;
using IWshRuntimeLibrary;

namespace DBaInstaller
{
    /// <summary>
    /// Логика взаимодействия для PathSelection.xaml
    /// </summary>
    public partial class PathSelection : Window
    {
        public PathSelection()
        {
            InitializeComponent();

            Application.Current.Properties.Add("isChecked", false);
            Application.Current.Properties.Add("installingPath", "");

            Application.Current.Properties.Add("std_login", "");
            Application.Current.Properties.Add("std_pass", "");

            textBox_Pass.Text = Pass.GeneratePass();
        }


        private void returnButton_C(object sender, RoutedEventArgs e)
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

        private void continueButton_C(object sender, RoutedEventArgs e)
        {
            if (!((Boolean)Application.Current.Properties["isChecked"]))
            {
                MessageBox.Show("Конфигурация не установлена! ", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!Pass.CheckPass(textBox_Pass.Text))
            {
                MessageBox.Show("Пароль не соответствует критериям!\n\n" +
                    "Длина 14-18 символов\n" +
                    "Минимум 2 заглавные лат. буквы\n" +
                    "Минимум две строчные лат. буквы\n" +
                    "Минимум две цифры и символа\n" +
                    "Без использования кириллицы", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (login_tb.Text == "" || pass_tb.Password == "")
            {
                MessageBoxResult res = MessageBox.Show("Данные о пользователе не были введены. При продолжении, будут\n" +
                                "использованы стандартные данные (admin-1234). Вы хотите продолжить?",
                                "Внимание! ", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                switch (res)
                {
                    case MessageBoxResult.Yes:
                        Application.Current.Properties["std_pass"] = "1234";
                        Application.Current.Properties["std_login"] = "admin";
                        break;
                    case MessageBoxResult.No:
                        return;
                }
            }
            else
            {
                Application.Current.Properties["std_pass"] = pass_tb.Password;
                Application.Current.Properties["std_login"] = login_tb.Text;
            }

            Application.Current.Properties.Add("databasePass", textBox_Pass.Text);

            if ((bool)createLink_cb.IsChecked)
            {
                Application.Current.Properties.Add("isCreatingLink", true);
            } else Application.Current.Properties.Add("isCreatingLink", false);

            Installation form = new Installation();
            Hide();
            form.ShowDialog();
        }

        private void selectPathButton_C(object sender, RoutedEventArgs e)
        {
            Directory.CreateDirectory("C:\\ProgramData\\DBa");
            WinForms.FolderBrowserDialog dialog = new WinForms.FolderBrowserDialog();
            dialog.ShowDialog();
            string path = dialog.SelectedPath;
            Application.Current.Properties["installingPath"] = path;
            Application.Current.Properties["isChecked"] = true;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void generatePassButton_C(object sender, RoutedEventArgs e)
        {
            textBox_Pass.Text = Pass.GeneratePass();
        }
    }
}
