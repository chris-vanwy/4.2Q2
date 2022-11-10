using System;

namespace VanWy_Assignment_4._2Q2
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstRow, secondRow, size;
            int[,] firstArray = new int[5, 5];
            int[,] secondArray = new int[5, 5];
            int[,] sumOfTheArrays = new int[5, 5];


            Console.Write("Input the size of the square matrix (less than 5): ");
            size = Convert.ToInt32(Console.ReadLine());

            /* Stored values into the array*/
            Console.Write("\nInput elements in the first matrix :\n");
            for (firstRow = 0; firstRow < size; firstRow++)
            {
                for (secondRow = 0; secondRow < size; secondRow++)
                {
                    Console.Write("element - [{0},{1}] : ", firstRow, secondRow);
                    firstArray[firstRow, secondRow] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nInput elements in the second matrix :\n");
            for (firstRow = 0; firstRow < size; firstRow++)
            {
                for (secondRow = 0; secondRow < size; secondRow++)
                {
                    Console.Write("element - [{0},{1}] : ", firstRow, secondRow);
                    secondArray[firstRow, secondRow] = Convert.ToInt32(Console.ReadLine());
                }
            }

            /* calculate the sum of the matrix */
            for (firstRow = 0; firstRow < size; firstRow++)
                for (secondRow = 0; secondRow < size; secondRow++)
                    sumOfTheArrays[firstRow, secondRow] = firstArray[firstRow, secondRow] + secondArray[firstRow, secondRow];
            Console.Write("\nThe Sum of two matrixes is : \n");
            for (firstRow = 0; firstRow < size; firstRow++)
            {
                Console.Write("\n");
                for (secondRow = 0; secondRow < size; secondRow++)
                    Console.Write("{0}\t", sumOfTheArrays[firstRow, secondRow]);
            }
            Console.Write("\n\n");
        }
    }
}