using System;
using System.IO;
using System.Windows;
using WinForms = System.Windows.Forms;
namespace DBaInstaller
{
    /// <summary>
    /// Логика взаимодействия для Config.xaml
    /// </summary>
    public partial class Config : Window
    {
        public Config()
        {
            InitializeComponent();
            Application.Current.Properties.Add("isUpdating", false);
            Application.Current.Properties.Add("updaingPath", "");

            Application.Current.Properties.Add("isUpdatingFromFile", false);
            Application.Current.Properties.Add("updatingFilePath", "");

            Application.Current.Properties.Add("isChecked1", false);
            Application.Current.Properties.Add("isChecked2", false);

            Application.Current.Properties.Add("buttChecked1", false);
            Application.Current.Properties.Add("buttChecked2", false);


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
            if (!(
                ((bool)iu1.IsChecked && (bool)um1.IsChecked) ||
                ((bool)iu2.IsChecked && (bool)Application.Current.Properties["buttChecked1"] && (bool)um1.IsChecked) ||
                ((bool)iu1.IsChecked && (bool)Application.Current.Properties["buttChecked2"] && (bool)um2.IsChecked) ||
                ((bool)iu2.IsChecked && (bool)Application.Current.Properties["buttChecked1"] && (bool)Application.Current.Properties["buttChecked2"] && (bool)um2.IsChecked)
                ))
            {
                MessageBox.Show("Конфигурация не установлена! ", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!(Boolean)Application.Current.Properties["isUpdating"])
            {
                PathSelection form = new PathSelection();
                Hide();
                form.ShowDialog();
            }
            else
            {
                Installation form = new Installation();
                Hide();
                form.ShowDialog();
            }
        }

        private void updateRButton_C(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["isUpdating"] = true;
            Application.Current.Properties["isChecked1"] = true;
            selectInstalledPath.IsEnabled = true;
        }

        private void installRButton_C(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["isUpdating"] = false;
            Application.Current.Properties["isChecked1"] = true;
            selectInstalledPath.IsEnabled = false;
        }

        private void selectInstalledPath_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["buttChecked1"] = true;
            Directory.CreateDirectory("C:\\ProgramData\\DBa");
            string path = "C:\\ProgramData\\DBa";
            WinForms.FolderBrowserDialog dialog = new WinForms.FolderBrowserDialog();
            dialog.ShowDialog();
            path = dialog.SelectedPath;

            Application.Current.Properties["updatingPath"] = path;
            Application.Current.Properties["isUpdating"] = true;

        }

        private void updateFileRB_C(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["isChecked2"] = true;
            Application.Current.Properties["isUpdatingFromFile"] = true;
            selectInstallMethodButton.IsEnabled = true;
        }

        private void updateServerRB_C(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["isChecked2"] = true;
            Application.Current.Properties["isUpdatingFromFile"] = false;
            selectInstallMethodButton.IsEnabled = false;
        }

        private void selectInstallMethodButton_C(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["buttChecked2"] = true;
            if (!(Directory.Exists("C:\\ProgramData\\DBa")))
            {
                Directory.CreateDirectory("C:\\ProgramData\\DBa");
            }

            string path = "C:\\ProgramData\\DBa";

            WinForms.OpenFileDialog dialog = new WinForms.OpenFileDialog();
            dialog.Filter = "ZRDB Update File(*.zrf)|*.zrf";
            dialog.ShowDialog();
            path = dialog.FileName;

            Application.Current.Properties["updatingFilePath"] = path;
            Application.Current.Properties["isUpdatingFromFile"] = true;

        }



        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
