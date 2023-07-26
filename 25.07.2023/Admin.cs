using System;
namespace _25._07._2023
{
	internal class Admin:User
	{
		bool IsSuperAdmin;
		string Section;


        public Admin( string name, string pasword,bool ısSuperAdmin,string section):base(name,pasword)
		{
			IsSuperAdmin = ısSuperAdmin;
			Section = section;
		}
		public void GetInfo()
		{
			Console.WriteLine($"Name:{Name},  Pasword:{Pasword},  {(IsSuperAdmin ? "Super admindir":"Super Admin deyil")},  Section:{Section}");

        }
        
    }
}

