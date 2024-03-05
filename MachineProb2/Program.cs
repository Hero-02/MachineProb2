using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineProb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare
            int x = 0;
            int y = 0;
            int[,] z = new int[x, y];
            Random rnd = new Random();
            // For selecting the operators
            Console.WriteLine("\nSelect The Operator:\n [0] Transpose\n [1] Addition\n [2] Subtraction\n [3] Multiplication\n");
            char operation = Convert.ToChar(Console.ReadLine());     
            Console.Clear(); // This is for removing the choices after the operator has been chosen       
                             
            
            // Input the number rows
            Console.WriteLine("Enter the number of rows:");
            x = int.Parse(Console.ReadLine());
            // Input the number of columns
            Console.WriteLine("Enter the number of columns:");
            y = int.Parse(Console.ReadLine());

            // Generate random values for z matrix
            z = new int[x, y];
            Console.WriteLine("-----------------------------");
            Console.WriteLine("First Matrix:");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    z[i, j] = rnd.Next(1, 10); // Generate random values between 1 and 10
                    Console.Write(z[i, j] + "\t"); // Output the random value and a tab for formatting
                }
                Console.WriteLine(); // Move to the next row after printing all columns in a row
            }
            if (operation == '0')
            {
                Console.WriteLine("Transposed Matrix:");
                
                for (int i = 0; i < z.GetLength(1); i++)
                {
                    for (int j = 0; j < z.GetLength(0); j++)
                    {
                        Console.Write(z[j, i] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("-----------------------------");
            }
            else if (operation == '1' || operation == '2' || operation == '3')
            {
                Console.WriteLine("Second Matrix:");
                int[,] secondMatrix = new int[x, y];
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        secondMatrix[i, j] = rnd.Next(1, 10); // Generate random values between 1 and 10
                        Console.Write(secondMatrix[i, j] + "\t"); // Output the random value and a tab for formatting
                    }
                    Console.WriteLine(); // Move to the next row after printing all columns in a row
                }
                
                Console.WriteLine("-----------------------------");
                // Perform the selected operation
                if (operation == '1')
                {
                    Console.WriteLine("Matrix After Addition:");
                    
                    for (int i = 0; i < z.GetLength(0); i++)
                    {
                        for (int j = 0; j < z.GetLength(1); j++)
                        {
                            Console.Write(z[i, j] + secondMatrix[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("-----------------------------");
                }
                
                else if (operation == '2')
                {
                    Console.WriteLine("Matrix After Subtraction:");
                   
                    for (int i = 0; i < z.GetLength(0); i++)
                    {
                        for (int j = 0; j < z.GetLength(1); j++)
                        {
                            Console.Write(z[i, j] - secondMatrix[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("-----------------------------");
                }
                else if (operation == '3')
                {
                   if (x > secondMatrix.GetLength(0))
                   {
                     Console.WriteLine("Error: Second matrix does not have enough rows for multiplication.");
                   }
                  else
                  {
                     Console.WriteLine("Matrix After Multiplication:");
                     for (int i = 0; i < x; i++)
                    {
                      for (int j = 0; j < y; j++)
                      {
                        Console.Write(z[i, j] * secondMatrix[i, j] + "\t");
                      }
                      Console.WriteLine();
                    }
                  }
                    Console.WriteLine("-----------------------------");
                }
                else
                {
                    Console.WriteLine("Invalid operation selected.");
                }
            }
        }
    }
}
