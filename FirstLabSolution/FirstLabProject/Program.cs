using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLabProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;

            int age;

            bool isCitizen;

            int heightFeet;

            double heightInches;

            System.Console.Write("What is your first name? ");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial? ");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name? ");
            lastName = System.Console.ReadLine();


            string fullName;
            fullName = (firstName + " " + middleInitial + "." + " " + lastName);

            System.Console.Write("What is your height in feet?");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many inches tall are you BEYOND your base height in feet? (Ex: If your are 5'4 & 1/2, enter 4.5)");
            heightInches = float.Parse(System.Console.ReadLine());

            double totalHeightCM = (heightFeet * 12 + heightInches) * 2.54;

            System.Console.Write("What is your age?");
            age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you a U.S. citizen? (true or false)");
            isCitizen = bool.Parse(System.Console.ReadLine());

            bool canVote;
            canVote = isCitizen && age > 18;

            System.Console.WriteLine("Your Full Name is: " + fullName);
            System.Console.WriteLine("Your Total Height in Centimeters are: " + totalHeightCM);
            System.Console.WriteLine("Your Eligibility to Vote: " + canVote);
            System.Console.WriteLine("Press any Key to continue...");
            System.Console.ReadKey();
        }
    }
}
