using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day1
{
    class Program
    {
        static void Main(string[] args)
        {

            //int favoriteNumber;

            //int[] favoriteNumbers;

            //int[] favoriteNumbers = { 1, 2, 3, 4, 5, 6 };

            //string[] studentNames = {"Raz", "Monica", "David", "Brian", "Ali"};

            //Console.WriteLine(favoriteNumbers[0]);

            //Console.WriteLine(studentNames[2]);


            //string[] vacationSpots = { "Bali", "Rio de Janeiro", "Amsterdam", "Cambodia", "Sydney", "Hawaii", " Oklahoma", "St. Petersburg", "Spain", "Honduras" };
            //Console.WriteLine(vacationSpots[0] + " " + vacationSpots[9]);
            ////Console.WriteLine(vacationSpots[9]);

            //int[] childrenAge = { 13, 10, 6 };
            //Console.WriteLine(childrenAge[0]);
            //Console.WriteLine(childrenAge[1]);
            //Console.WriteLine(childrenAge[2]);

            //double[] studentGpa = { 3.4, 2.8, 3.75, 4.0, 3.98, 2.0, 3.5, 2.99, 3.0, 2.75 };
            //Console.WriteLine(studentGpa[4]);

            //char[] firstInitial = { 'A', 'N', 'B', 'K', };
            //Console.WriteLine(firstInitial[1]);

            //int[] numbers = new int[4];
            //numbers[0] = 43;
            //numbers[1] = 12;
            //Console.WriteLine("Please enter a number.");
            //numbers[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter a number.");
            //numbers[3] = int.Parse(Console.ReadLine());

            //Console.WriteLine(numbers[3]);

            //string[] weekDays = new string[7];
            //weekDays[0] = "Monday";
            //weekDays[1] = "Tuesday";
            //weekDays[2] = "Wednesday";
            //weekDays[3] = "Thursday";
            //weekDays[4] = "Friday";
            //weekDays[5] = "Saturday";
            //weekDays[6] = "Sunday";

            //int[] studentAges = new int[5];
            //studentAges[0] = 12;
            //studentAges[1] = 14;
            //studentAges[2] = 13;
            //studentAges[3] = 12;
            //studentAges[4] = 11;

            //Console.WriteLine(weekDays.Length);

            //char[] lastName = { 'S', 'W', 'E', 'E', 'T' };
            //Console.WriteLine(lastName.Length);

            //
            //string[] directions = new string[4];
            //directions[0] = "Left";
            //directions[1] = "Right";
            //directions[2] = "Up";
            //directions[3] = "Down";
            //Console.WriteLine(directions.Length);

            //int length = directions.Length;

            //int secondLast = (length - 2);

            //Console.WriteLine(directions[secondLast]);

            //Console.WriteLine("This is the last index is " + (directions.Length - 1));

            //Console.WriteLine(directions[directions.Length - 1]);

            //
            //Console.WriteLine("PLease enter the size of your array.");
            //int arraySize = int.Parse(Console.ReadLine());

            //int[] newArray = new int[arraySize];

            //Console.WriteLine("The array is of length " + newArray.Length);


            //string[] birthMonths = { "October", "July", "October", "May" };
            //Console.WriteLine(Array.IndexOf(birthMonths,"October"));

            //int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            //Console.WriteLine(Array.LastIndexOf(numbers, 4));

            //Array.Reverse(numbers);
            //Console.WriteLine(numbers[0]);

            //Array.Sort(numbers);
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[numbers.Length - 1]);


            //Practice Problems

            string[] firstNames = { "Brad", "Cheria", "Rashida", "Ali", "Nick", "Bryan" };
            Console.WriteLine(firstNames[2]);
            Console.WriteLine(Array.IndexOf(firstNames, "Rashida"));

            int[] luckyNumbers = { 2, 5, 4, 3, 7, 1, 13 };
            Console.WriteLine(Array.LastIndexOf(luckyNumbers, 5));

            char[] letters = { 'd', 's', 'h', 'f', 'e', 'j', 'k', 'n' };
            Console.WriteLine(letters[0]);
            Array.Reverse(letters);
            Console.WriteLine(letters[0]);

            string[] randoNames = { "Brad", "Cheria", "Rashida", "Ali", "Nick", "Bryan" };
            Array.Sort(firstNames);
            Console.WriteLine(randoNames[0]);
            Console.WriteLine(randoNames[randoNames.Length - 1]);

            double[] favNumbers = { 13, 3, 26, 7, 90, 1040, 45, 32, 1.618, 4, 16 };
            Array.Sort(favNumbers);
            Console.WriteLine(favNumbers[0]);
            Console.WriteLine(favNumbers[favNumbers.Length - 1]);










        }
    }
}
