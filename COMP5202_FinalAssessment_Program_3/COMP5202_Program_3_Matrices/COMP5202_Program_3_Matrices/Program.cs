//Blake Jensen (Student ID 30006830)
//COMP5202 3rd program of final assignment. Adding 2 matrices after they've been displayed
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP5202_Program_3_Matrices
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            //allows for use of the 'random' property
            Random rand = new Random();
            
            //2 matrix variables using the 'new int' function
            int[,] matrixA = new int[3,3];
            int[,] matrixB = new int[3,3];

            //for loop for matrixA
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for(int l = 0; l < matrixA.GetLength(1); l++)
                {
                    matrixA[i, l] = rand.Next(-10, 10);
                }
            }

            //for loop for matrixB
            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int l = 0; l < matrixB.GetLength(1); l++)
                {
                    matrixB[i, l] = rand.Next(-10, 10);
                }
            }

            /*displays the first and second matrix*/
            Console.WriteLine("1st Matrix being tested (Matrix A): ");
            Display(matrixA);

            Console.WriteLine("2nd Matrix being tested (Matrix B): ");
            Display(matrixB);

            //for loop used to add both matrixes together
            Console.WriteLine("Matrix C = Matrix A + Matrix B: ");
            for (int i = 0; i < 3; i++)
            {
                for (int l = 0; l < 3; l++)
                {
                    Console.Write(matrixA[i, l] + matrixB[i, l] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();
        }

        //display method
        public static void Display (int[,] arr)
        {
            //for loop used for the display method to be used
            for(int i = 0; i < arr.GetLength(0); i++)//row
            {
                for(int l = 0; l < arr.GetLength(1); l++)//column
                {
                    Console.Write(arr[i, l] + "  ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
