using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalkylator
{
    class Program
    {
        static int[,] matrix1;
        static int[,] matrix2;
        static int[,] matrix3;

        static Program()
        {
            matrix1 = new int[3,3];
            matrix2 = new int[3,3]; 
        }
        static void Main(string[] args)
        {
            WeightMatrix1();
            WeightMatrix2();            
            Multiplication();
            Console.ReadKey();
            
        }

        static void WeightMatrix1()
        {
            int rows = matrix1.GetUpperBound(0) + 1;
            int columns = matrix1.Length / rows;
            Console.WriteLine("Задайте парамерты матрицы 1 : ");
            for (int i = 0 ; i < 3; i++)
            {                
                for (int j = 0; j < 3; j++)
                {                    
                    Console.Write("Число: ");
                    matrix1[i,j] = Int32.Parse(Console.ReadLine());                    
                }                
            }
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix1[i,j]} \t");
                }
                Console.WriteLine();
            }                                    
        }

        static void WeightMatrix2()
        {
            int rows = matrix2.GetUpperBound(0) + 1;
            int columns = matrix2.Length / rows;
            Console.WriteLine("Задайте парамерты матрицы 2 : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Число: ");
                    matrix2[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix2[i, j]} \t");
                }
                Console.WriteLine();
            }                                  
        }

        static int[,] MultiplicationMatrix()
        {
            int[,] matrix3 = new int[matrix1.Length, matrix2.Length];
            for (int i = 0; i < matrix2.GetLength(1); i++)
            {
                for (int j = 0; j < matrix2.GetLength(0); j++)
                {
                    matrix3[i, j] = 0;
                    for (int k = 0; k < matrix2.GetLength(0); k++)
                    {
                        matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return matrix3;
        }

        static void Multiplication()
        {
            Console.WriteLine("Произведение первой и второй матрицы равно: ");
            matrix3 = MultiplicationMatrix();

            int rows = matrix3.GetUpperBound(0) + 1;
            int columns = matrix3.Length / rows;
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix3[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            
        }        
    }
}
