using SQLite;
using System.Security.Cryptography;
using System.Text;

namespace DBaInstaller
{
    class User
    {
        public string Username { get; set; }
        public string Passhash { get; set; }
    }

    class Kid
    {
        public int VoucherID { get; set; }
        public string VoucherExtraditer { get; set; }
        public string FullName { get; set; }
        public string DateOfBirth { get; set; }
        public string School { get; set; }
        public string Grade { get; set; }
        public string Age { get; set; }
        public string HomeAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string MotherFullName { get; set; }
        public string MotherMobPhone { get; set; }
        public string MotherJob { get; set; }
        public string FatherFullName { get; set; }
        public string FatherMobPhone { get; set; }
        public string FatherJob { get; set; }
        public string Family { get; set; }
        public string Notes { get; set; }
        public string Group { get; set; }
    }

    class School
    {
        public string name { get; set; }
        public string subordination { get; set; }
        public string management { get; set; }
        public string form { get; set; }
        public string supervisor { get; set; }
        public string mail { get; set; }
        public string site { get; set; }
        public string PAN { get; set; }
        public string contacts { get; set; }
        public string address { get; set; }
    }

    class SQL_writer
    {
        public void WriteUsers(string path, string DBPass, string username, string password)
        {
            var options = new SQLiteConnectionString(path, true,
                key: DBPass);
            var db = new SQLiteConnection(options);

            db.CreateTable<User>();

            StringBuilder sb = new StringBuilder();

            using (MD5 md5 = MD5.Create())
            {
                byte[] hashValue = md5.ComputeHash(Encoding.UTF8.GetBytes(password.ToCharArray()));

                foreach (byte b in hashValue)
                {
                    sb.Append($"{b:X2}");
                }
            }

            User admin = new User();
            admin.Username = username;
            admin.Passhash = sb.ToString();

            db.Insert(admin);

            db.CreateTable<School>();

            db.CreateTable<Kid>();

            db.Close();
        }
    }
}
