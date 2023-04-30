﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace DBaInstaller
{
    internal static class DBEncryption
    {
        public static void writePassword(string s1, string s2)
        {
            RegistryKey lkey = Registry.LocalMachine;
            RegistryKey nkey = lkey.OpenSubKey("SOFTWARE", true);
            RegistryKey pass = nkey.CreateSubKey("ZRDB");
            pass.SetValue("p1", s1);
            pass.SetValue("p2", s2);
            pass.Close();
            Console.ReadLine();
        }

        public static string[] getPasswords()
        {
            RegistryKey lkey = Registry.LocalMachine;
            RegistryKey nkey = lkey.CreateSubKey("SOFTWARE", true);
            RegistryKey pass2 = nkey.CreateSubKey("WOW6432Node");
            RegistryKey pass = pass2.CreateSubKey("ZRDB");
            string s1 = pass.GetValue("p1").ToString();
            string s2 = pass.GetValue("p2").ToString();
            return new string[] { s1, s2 };
        }

        public static bool isAdminRights()
        {
            return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static string[] splitKeyPass(string _pass, string _key)
        {
            string s1 = "";
            string s2 = "";

            for (int i = 0; i < _pass.Length; i++)
            {
                if (_key[i] == '0')
                {
                    s1 += _pass[i];
                }
                else s2 += _pass[i];
            }

            return new string[] { s1, s2 };
        }

        public static string compileKeyPass(string[] splitted, string key)
        {
            int index1 = 0, index2 = 0;
            string ret = "";
            for (int i = 0; i < splitted[0].Length + splitted[1].Length; i++)
            {
                if (key[i] == '0')
                {
                    ret += splitted[0][index1];
                    index1++;
                }
                else
                {
                    ret += splitted[1][index2];
                    index2++;
                }
            }
            return ret;
        }

        public static string getKey(string password)
        {
            string key_ = "";
            switch (password.Length) 
            {
                case 14:
                    key_ = "10010110011101";
                    break;
                case 15:
                    key_ = "111111001101010";
                    break;
                case 16:
                    key_ = "1011111001010100";
                    break;
                case 17:
                    key_ = "11011011111001111";
                    break;
                case 18:
                    key_ = "100001111011010101";
                    break;
            }
            return key_;
        }
        
    }
}
