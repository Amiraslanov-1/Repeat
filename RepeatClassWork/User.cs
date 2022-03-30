using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class User
    {
        public User(string password,string username,Server roleEnum)
        {
            _id++;
            _password = password;
            Username = username;
            RoleEnum = roleEnum;
        }
        static int _id;
        public  int ID { get => _id; }
        public string Username { get; set; }
        private Server _rolenum;
        public Server RoleEnum {
            get => _rolenum;
            set
            {
                if (value == Server.Admin)
                {
                    this._rolenum = value;
                }
                else if (value == Server.Member)
                {
                    throw new IsNotAdmin("You Have No Authority To Enter Here !!!");
                }
            }
        
        
        }

        string _password;

        public string Password
        {
            get => _password;
            set
            {
                if(CheckPassword(value))
                this._password = value;
            }
        }
        public static bool CheckPassword(string pass)
        {
            if (!string.IsNullOrWhiteSpace(pass) && pass.Length >= 8)
            {
                bool HasDigit = false;
                bool HasUpper = false;
                bool HasLower = false;

                for (int i = 0; i < pass.Length; i++)
                {
                    if (char.IsDigit(pass[i]))
                    {
                        HasDigit = true;
                    }
                    else if (char.IsUpper(pass[i]))
                    {
                        HasUpper = true;
                    }
                    else if (char.IsLower(pass[i]))
                    {
                        HasLower = true;
                    }
                    if (HasDigit&&HasUpper&&HasLower)
                        return true;
                }
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID : {_id}\nSurname : {Username}\nPasswrod : {_password}");
        }


    }
}
