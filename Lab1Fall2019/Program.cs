using System;

namespace Lab1Fall2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;

            
            
            int heightFeet;
            double heightInches;

            Console.Write("What is your first name?: ");
            firstName = Console.ReadLine();
            Console.WriteLine();
            
            Console.Write("What is your middle initial?: ");
            middleInitial = Console.ReadLine();
            Console.WriteLine();

            Console.Write("What is your last name?: ");
            lastName = Console.ReadLine();
            Console.WriteLine();


            fullName = firstName + " " + middleInitial + ". " + lastName;
            Console.Write("Well, hello... ");
            Console.WriteLine(fullName);
            Console.WriteLine("");

           

            Console.Write("What if your height in feet?: ");
            heightFeet = int.Parse(Console.ReadLine());

            Console.Write("And how many inches?: ");
            heightInches = double.Parse(Console.ReadLine());

            double inches = heightFeet * 12;
            inches += heightInches;

            double heightCM = 2.54 * inches;

            int age;
            bool isCitizen;

            Console.Write("Your age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Citizen?: ");
            bool isCitizen = Console.ReadLine().ToLower().StartsWith("y");

            Console.WriteLine(age >= 18 && isCitizen);
                       
            Console.ReadKey();
        }
    }
}
