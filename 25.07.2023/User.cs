using System;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace _25._07._2023
{
    internal class User
    {
        string _name;

       string _pasword;
      public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                if (value.Length > 6)
                {
                   Name = value;
                }
            }
        }
        public string Pasword;
        
        public void CheckPasword()
        {
            for (int i = 0; i < Pasword.Length; i++)
            {


                if (char.IsUpper(Pasword[i]))
                {
                    return;
                }
                Console.WriteLine("Please enter valid Pasword!");
                if (Pasword[i] == 1 || Pasword[i] == 2 || Pasword[i] == 3 || Pasword[i] == 4 || Pasword[i] == 5 || Pasword[i] == 6 || Pasword[i] == 7 || Pasword[i] == 8 || Pasword[i] == 9 || Pasword[i] == 0)
                {
                    return;
                }
                Console.WriteLine("Please enter valid Pasword!");
            }

        }



        public User(string name, string pasword)
        {

            Name = name;
            Pasword = pasword;

        }
        
        

    }
}

