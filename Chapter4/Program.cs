using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            
             //1
             Console.WriteLine(int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine()));
             //2
             int radius=int.Parse(Console.ReadLine());
             Console.WriteLine("Permieter: " + 2 * 3.14 * radius + "\tArea: " + 3.14 * radius * radius);
             //3
             string companyName, companyAdress, companyPhoneNumber, companyFaxNumber, companyWebSite, managerName, managerSurname, managerPhoneNumber;
             Console.Write("Company name: "); companyName=Console.ReadLine();
             Console.Write("Company adres: "); companyAdress = Console.ReadLine();
             Console.Write("Company phone number: "); companyPhoneNumber = Console.ReadLine();
             Console.Write("Company fax number: "); companyFaxNumber = Console.ReadLine();
             Console.Write("Company web site: "); companyWebSite = Console.ReadLine();
             Console.Write("Manager name: "); managerName = Console.ReadLine();
             Console.Write("Manager surname: "); managerSurname = Console.ReadLine();
             Console.Write("Manager phone number: "); managerPhoneNumber = Console.ReadLine();

             Console.WriteLine("\nCompany name:\t\t\t\t" + companyName);
             Console.WriteLine("Company adres:\t\t\t\t" + companyAdress);
             Console.WriteLine("Company phone number:\t\t\t" + companyPhoneNumber);
             Console.WriteLine("Company fax number:\t\t\t" + companyFaxNumber);
             Console.WriteLine("Company web site:\t\t\t" + companyWebSite);
             Console.WriteLine("Manager name:\t\t\t\t" + managerName);
             Console.WriteLine("Manager surname:\t\t\t" + managerSurname);
             Console.WriteLine("Manager phone number:\t\t\t" + managerPhoneNumber);             
             //4
             int numberOne = 115;
             float numberTwo = 0.483f, numberThree = -0.486f;
             Console.WriteLine("{0:X10}\t{1:0000000.00}\t{2:000000.00}", numberOne, numberTwo, numberThree);
             //5      
             int downRange = int.Parse(Console.ReadLine());
             int upRange = int.Parse(Console.ReadLine());
             int answer = 0;
             if (downRange == 0) answer -= 1;
             if (downRange % 5 == 0|| upRange % 5 == 0) answer++;
             answer += (upRange - downRange) / 5;
             Console.WriteLine(answer); 
             //6*
             Console.WriteLine(Math.Max(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
             //7
             int[] numbersToSumUp = new int[5];
             for(int i=0;i<5;i++)
             {
                 bool isParsingPossible;
                 do
                 {
                     Console.Write("Write number {0}: ", i+1);
                     isParsingPossible = int.TryParse(Console.ReadLine(), out numbersToSumUp[i]);
                 } while (isParsingPossible == false);                
             }
             Console.WriteLine(numbersToSumUp[0] + numbersToSumUp[1] + numbersToSumUp[2] + numbersToSumUp[3] + numbersToSumUp[4]);
             //8
            int whichIsGreates= int.Parse(Console.ReadLine());            
            for (int i = 0; i<4;i++)
            {
                int buffor = int.Parse(Console.ReadLine());
                if (whichIsGreates < buffor) whichIsGreates = buffor;
            }
            Console.WriteLine("Greatest number is " + whichIsGreates);
            //9
            Console.Write("How many number would you like to sum up? ");
            int howManyNumbers = int.Parse(Console.ReadLine());
            int answerIs = 0;
            for(int i =0;i<howManyNumbers;i++)
            {               
                answerIs += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum of {0} numbers is: {1}", howManyNumbers, answerIs);
            //10
            Console.Write("How many number would you like to sort? ");
            int howManyNumbersToSort = int.Parse(Console.ReadLine());
            int[] numbersToSort = new int[howManyNumbersToSort];
            for(int i=0;i<howManyNumbersToSort;i++)
            {
                numbersToSort[i] = int.Parse(Console.ReadLine());
            }
            QuickSort(numbersToSort, 0, howManyNumbersToSort - 1);
            for (int i = 0; i < howManyNumbersToSort; i++)
            {
                Console.WriteLine(numbersToSort[i]);
            }
            //11
            BigInteger[] fibbonacciSequence = new BigInteger[3];
            fibbonacciSequence[0] = 1;
            fibbonacciSequence[1] = 1;
            Console.WriteLine("0\n1\n1");
            for (int i =0 ; i < 98; i++)
            {
                fibbonacciSequence[2] = fibbonacciSequence[0] + fibbonacciSequence[1];
                fibbonacciSequence[0] = fibbonacciSequence[1];
                fibbonacciSequence[1] = fibbonacciSequence[2];
                Console.Write(i+3 + " ");
                Console.WriteLine("{0:F0}", fibbonacciSequence[2]);
            }
            //12
            double current = 1;
            double previous = 1.1;
            int j = 2;

            while(Math.Abs(previous - current) > 0.001)
            {
                previous = current;
                if (j % 2 == 0) current += (1.0 / j);
                else current -= (1.0 / j);
                j++;
            }
            Console.WriteLine("{0:N3}",current);
                                 
        }

        public static void QuickSort(int[] array, int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = array[(left + right) / 2];
            while (i < j)
            {
                while (array[i] < pivot) i++;
                while (array[j] > pivot) j--;
                if (i <= j)
                {
                    // swap
                    var tmp = array[i];
                    array[i++] = array[j];  // ++ and -- inside array braces for shorter code
                    array[j--] = tmp;
                }
            }
            if (left < j) QuickSort(array, left, j);
            if (i < right) QuickSort(array, i, right);
        }
    }

    /*
1.     Write a program that reads from the console three numbers of type int and prints their sum.

2.     Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.

3.     A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number. Write a program that reads information about the company and its manager and then prints it on the console.

4.     Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters and the numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional positive; and the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.

5.     Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that the remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.

6.     Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional statements.

7.     Write a program that reads five integer numbers and prints their sum. If an invalid number is entered the program should prompt the user to enter another number.

8.     Write a program that reads five numbers from the console and prints the greatest of them.

9.     Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.

10.   Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line.

11.   Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …

12.   Write a program that calculates the sum (with precision of 0.001) of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …
    */

}
