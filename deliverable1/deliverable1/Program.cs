using System;

namespace Deliverable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Close = false;
            while (!Close)
            {
                Console.WriteLine("How many people are we making PB&J sandwhiches for? ");
                int NumberPeople = int.Parse(Console.ReadLine());

                Decimal TotalSlices = (NumberPeople * 2);
                Decimal TablespoonsPB = (NumberPeople * 2);
                Decimal TeaspoonsJelly = (NumberPeople * 4);
                Decimal Loaves = (TotalSlices / 28);
                Decimal LoavesRounded = Math.Ceiling(Loaves);
                Decimal PBJars = (TablespoonsPB / 32);
                Decimal PBJarsRounded = Math.Ceiling(PBJars);
                Decimal JellyJars = (TeaspoonsJelly / 48);
                Decimal JellyJarsRounded = Math.Ceiling(JellyJars);




                Console.WriteLine("You need:");
                Console.WriteLine(+TotalSlices + " Slices of bread");
                Console.WriteLine(+TablespoonsPB + " TableSpoons of Peanut Butter");
                Console.WriteLine(+TeaspoonsJelly + " Teaspoons of Jelly");

                Console.WriteLine("Which is:");
                Console.WriteLine(+LoavesRounded + " Loaves of bread");
                Console.WriteLine(+PBJarsRounded + " Jars of Peanut Butter");
                Console.WriteLine(+JellyJarsRounded + " Jars of Jelly");

                Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
                string Continue;
                Continue = (Console.ReadLine());

                if (Continue is "y") { Close = false; }
                else if (Continue is "Y") { Close = false; }
                else if (Continue is "Yes") { Close = false; }
                else if (Continue is "yes") { Close = false; }
                else { Close = true; Console.WriteLine("Goodbye!"); }





            }

        }
    }
}
