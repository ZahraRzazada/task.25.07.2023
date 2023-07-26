using System;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace _25._07._2023
{
    internal class User
    {
        private string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 6)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Please enter valid username!");
                }
            }
        }
        string _name;
        private string pasword
        {
            get
            {
                return _pasword;
            }
            set
            {
                for (int i = 0; i < _pasword.Length; i++)
                {
                    if (_pasword[i] == 1 || _pasword[i] == 2 || _pasword[i] == 3 || _pasword[i] == 4 || _pasword[i] == 5 || _pasword[i] == 6 || _pasword[i] == 7 || _pasword[i] == 8 || _pasword[i] == 9 || _pasword[i] == 0)
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid Pasword!");
                    }
                }
                for (int i= 0;  i<_pasword.Length; i++)
                {
                    if( char.IsUpper(_pasword[i]))
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid Pasword!");
                    }
                }
               
            }
        }
        string _pasword;
        public User(string name, string pasword)
        {

            Name = name;
            _pasword = pasword;

        }
        public void CreatingAdmin(string name, string pasword, bool ısSuperAdmin, string section)
        {
            //Console.WriteLine("Please enter name:");
            //string name = Console.ReadLine();
            //         Console.WriteLine("Please enter pasword:");
            //         string pasword = Console.ReadLine();
            //         Console.WriteLine("Please enter section:");
            //         string section = Console.ReadLine();


            Console.WriteLine($"Name of User:{name}, Pasword of user:{pasword}, {(ısSuperAdmin ? "User is superadmin" : "User is not superadmin")},Section:{section}");
        }

    }
}

