using IWshRuntimeLibrary;
using System;
using System.IO;
using System.Net;
using System.Windows;

namespace DBaInstaller
{
    /// <summary>
    /// Логика взаимодействия для Installation.xaml
    /// </summary>
    public partial class Installation : Window
    {
        public Installation()
        {
            InitializeComponent();
        }

        void Createlnk(string soucre)
        {
            string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            using (StreamWriter writer = new StreamWriter(deskDir + "\\ZRDB.url"))
            {
                writer.WriteLine("[InternetShortcut]");
                writer.WriteLine("URL=file:///" + soucre);
                writer.WriteLine("IconIndex=0");
                string icon = soucre.Replace('\\', '/');
                writer.WriteLine("IconFile=" + icon);
            }
        }

        private void continueButton_C(object sender, RoutedEventArgs e)
        {
            Finish finish = new Finish();
            Hide();
            finish.ShowDialog();

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void updateFiles(int increaseValue)
        {
            main_pb.Value = 0;
            status_t.Text = "Выбран статус: Обновление из фалйа";
            main_pb.Value += increaseValue;
            Directory.CreateDirectory("C:\\ProgramData\\DBa\\unarchived");
            string soucre = (string)Application.Current.Properties["updatingFilePath"];
            try
            {
                System.IO.Compression.ZipFile.ExtractToDirectory(soucre, "C:\\ProgramData\\DBa\\unarchived\\");
            }
            catch
            {
                Directory.Delete("C:\\ProgramData\\DBa\\unarchived", true);
                Directory.CreateDirectory("C:\\ProgramData\\DBa\\unarchived");
                System.IO.Compression.ZipFile.ExtractToDirectory(soucre, ("C:\\ProgramData\\DBa\\unarchived\\"));
            }
            main_pb.Value += increaseValue;
            status_t.Text = "Извлечение данных из файла обновления...";
            try
            {
                System.IO.File.Move("C:\\ProgramData\\DBa\\unarchived\\ZRDB.exe", (string)Application.Current.Properties["updatingPath"] + "\\ZRDB.exe");
                System.IO.File.Move("C:\\ProgramData\\DBa\\unarchived\\changelog.cl", (string)Application.Current.Properties["updatingPath"] + "\\changelog.cl");
                System.IO.File.Move("C:\\ProgramData\\DBa\\unarchived\\sni.dll", (string)Application.Current.Properties["updatingPath"] + "\\sni.dll");
                System.IO.File.Move("C:\\ProgramData\\DBa\\unarchived\\e_sqlcipher.dll", (string)Application.Current.Properties["updatingPath"] + "\\e_sqlcipher.dll");
            }
            catch
            {
                System.IO.File.Delete((string)Application.Current.Properties["updatingPath"] + "\\ZRDB.exe");
                System.IO.File.Delete((string)Application.Current.Properties["updatingPath"] + "\\changelog.cl");
                System.IO.File.Delete((string)Application.Current.Properties["updatingPath"] + "\\sni.dll");
                System.IO.File.Delete((string)Application.Current.Properties["updatingPath"] + "\\e_sqlcipher.dll");

                System.IO.File.Move("C:\\ProgramData\\DBa\\unarchived\\ZRDB.exe", (string)Application.Current.Properties["updatingPath"] + "\\ZRDB.exe");
                System.IO.File.Move("C:\\ProgramData\\DBa\\unarchived\\changelog.cl", (string)Application.Current.Properties["updatingPath"] + "\\changelog.cl");
                System.IO.File.Move("C:\\ProgramData\\DBa\\unarchived\\sni.dll", (string)Application.Current.Properties["updatingPath"] + "\\sni.dll");
                System.IO.File.Move("C:\\ProgramData\\DBa\\unarchived\\e_sqlcipher.dll", (string)Application.Current.Properties["updatingPath"] + "\\e_sqlcipher.dll");
            }
            main_pb.Value += increaseValue;
            status_t.Text = "Перемещение файлов в выбранную директорию...";
            main_pb.Value += increaseValue;
            status_t.Text = "Готово. ";

            Directory.Delete("C:\\ProgramData\\DBa\\unarchived", true);
        }

        private void install()
        {
            try
            {
                if ((bool)Application.Current.Properties["isUpdating"] && (bool)Application.Current.Properties["isUpdatingFromFile"])
                {
                Application.Current.Properties["isCreatingLink"] = false;
                updateFiles(25);
                }
                else if (!(bool)Application.Current.Properties["isUpdating"] && (bool)Application.Current.Properties["isUpdatingFromFile"])
                {
                    Application.Current.Properties["updatingPath"] = Application.Current.Properties["installingPath"];
                    updateFiles(17);

                    SQL_writer sqlw = new SQL_writer();
                    sqlw.WriteUsers(Application.Current.Properties["installingPath"] + "\\data.zb",
                        (string)Application.Current.Properties["databasePass"],
                        (string)Application.Current.Properties["std_login"],
                        (string)Application.Current.Properties["std_pass"]);

                    main_pb.Value += 32;

                    string[] passSptd = DBEncryption.splitKeyPass((string)Application.Current.Properties["databasePass"], DBEncryption.getKey((string)Application.Current.Properties["databasePass"]));
                    DBEncryption.writePassword(passSptd[0], passSptd[1]);
                }
                else if ((bool)Application.Current.Properties["isUpdating"] && !(bool)Application.Current.Properties["isUpdatingFromFile"])
                {
                Application.Current.Properties["isCreatingLink"] = false;

                    main_pb.Value = 20;
                    status_t.Text = "Загрузка файла с сервера...";

                    WebClient wc = new WebClient();
                    wc.DownloadFile("https://github.com/maksimkh34/dba_cs_inst/blob/main/update.zrf?raw=true", "C:\\ProgramData\\DBa\\update.zrf");
                    Application.Current.Properties["updatingFilePath"] = "C:\\ProgramData\\DBa\\update.zrf";

                    updateFiles(20);
                    System.IO.File.Delete("C:\\ProgramData\\DBa\\update.zrf");
                    main_pb.Value = 100;
                } else if (!(bool)Application.Current.Properties["isUpdating"] && !(bool)Application.Current.Properties["isUpdatingFromFile"])
                {
                    main_pb.Value = 20;
                    status_t.Text = "Загрузка файла с сервера...";

                    WebClient wc = new WebClient();
                    wc.DownloadFile("https://github.com/maksimkh34/dba_cs_inst/blob/main/update.zrf?raw=true", "C:\\ProgramData\\DBa\\update.zrf");

                    Application.Current.Properties["updatingFilePath"] = "C:\\ProgramData\\DBa\\update.zrf";
                    Application.Current.Properties["updatingPath"] = Application.Current.Properties["installingPath"];
                    updateFiles(20);

                    SQL_writer sqlw = new SQL_writer();
                    sqlw.WriteUsers(Application.Current.Properties["installingPath"] + "\\data.zb",
                        (string)Application.Current.Properties["databasePass"],
                        (string)Application.Current.Properties["std_login"],
                        (string)Application.Current.Properties["std_pass"]);

                    System.IO.File.Delete("C:\\ProgramData\\DBa\\update.zrf");

                    string[] passSptd = DBEncryption.splitKeyPass((string)Application.Current.Properties["databasePass"], DBEncryption.getKey((string)Application.Current.Properties["databasePass"]));
                    DBEncryption.writePassword(passSptd[0], passSptd[1]);

                    main_pb.Value = 100;
                }

                if((bool)Application.Current.Properties["isCreatingLink"])
                {
                    Createlnk((string)Application.Current.Properties["updatingPath"] + "\\ZRDB.exe");
                }

            } catch (Exception e){
                MessageBox.Show($"Произошла неизвестная ошибка во время установки: {e}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Application.Current.Shutdown();
            }

            continueButton.IsEnabled = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            install();
        }
    }


}
