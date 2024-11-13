﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VaccineSystem
{
    class MyUserDL
    {

        private static List<MyUser> userList = new List<MyUser>();

        public static List<MyUser> UserList { get => userList; set => userList = value; }

        public static void adduserintolist(MyUser user)
        {
            UserList.Add(user);
        }
      
        public static void StoreUserData(string path, MyUser user)
        {

            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.UserName + "," + user.UserPassword + "," + user.UserRole);
            file.Flush();
            file.Close();

        }
        public static bool ReadUserData(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] spllitedrecord = record.Split(',');
                    string uname = spllitedrecord[0];
                    string upassword = spllitedrecord[1];
                    string urole = spllitedrecord[2];
                    MyUser user = new MyUser(uname, upassword, urole);
                    adduserintolist(user);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static MyUser SignIN(MyUser user)
        {
            foreach (MyUser user1 in UserList)
            {
                if (user1.UserName == user.UserName && user1.UserPassword == user.UserPassword)
                {
                    return user1;
                }
            }
            return null;
        }
        public static bool Checkuniqueusername(string name)
        {
            foreach(MyUser u in userList)
            {
                if(u.UserName==name)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
