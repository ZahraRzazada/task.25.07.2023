using System.Xml.Linq;
using _25._07._2023;

string Name;
string Pasword;
do
{
    Console.WriteLine("Please enter name:");
    Name = Console.ReadLine();
} while (Name.Length <= 6);
//do
//{
//    Console.WriteLine("Please enter password:");
//    Pasword = Console.ReadLine();
//} while (CheckPasword);
Console.WriteLine("Please enter password:");
Pasword = Console.ReadLine();

Console.WriteLine("IsSuperAdmin?true or false?");
bool isSuperAdmin = false;
string answer = Console.ReadLine();
if (answer=="true")
{
    isSuperAdmin = true;
}
Console.WriteLine("Please enter section:");
string section = Console.ReadLine();

Admin admin = new Admin(Name, Pasword, isSuperAdmin, section);
admin.GetInfo();
