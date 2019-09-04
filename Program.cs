using System;
using System.Collections.Concurrent;
using System.IO;
class Geek
{

    // Main Method 
    public static void Main()
    {
       

        string firstname;
        string lastname;
        int phonenumber;
        
        Console.WriteLine("Enter your first name: ");


        // typecasting not needed as  
        // ReadLine returns string 
        firstname = Console.ReadLine();
        Console.WriteLine("Enter your  last name: ");
        lastname = Console.ReadLine();
        Console.WriteLine("Enter your  phone number: ");
        phonenumber = Convert.ToInt32(Console.ReadLine());

        List<Customr> Custmers = new List<Customr>(3);
        Custmers.Add(firstname);
        Custmers.Add(lastname);
        Custmers.Add(phonenumber);

        foreach (Customr c in Custmers)
        {
            Console.WriteLine("firstname={0}, lastname= {1}, phonenumber={2}", c.firstname, c.lastname, c.phonenumber);
        }
     

        // Pauses the console until  
        // the user preses enter key 
        Console.ReadLine();
    }

    public class Customr
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string phonenumber { get; set; }
    }
}