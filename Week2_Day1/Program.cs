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

            Console.WriteLine("PLease enter the size of your array.");
            int arraySize = int.Parse(Console.ReadLine());

            int[] newArray = new int[arraySize];

            Console.WriteLine("The array is of length " + newArray.Length);





        }
    }
}
