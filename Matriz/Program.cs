using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat1 = new int[2, 2] { { 10, -1 }, { 6, 3 } };
            int[,] mat2 = new int[2, 2] { { 21, 12 }, { -2, -5 } };

            for(int linha = 0; linha <2; linha++)
            {
                for(int coluna = 0; coluna <2; coluna++)
                {
                    Console.Write(mat1[linha, coluna] * 2 + "\t");
                } 
                 Console.Write("\n");
            }
            Console.Write("\n");

            for (int linha = 0; linha <2; linha++)
            {
                for(int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write(mat2[coluna, linha] + "\t");
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    
    
    
    
    } 
}              