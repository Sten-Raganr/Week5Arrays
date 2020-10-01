using System;

namespace Week5Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int number in array1)
            {
                Console.WriteLine(number);
            }int[] array2 = new int[10];
            array2[0] = 1;
            array2[1] = 2;
            array2[2] = 3;
            array2[3] = 4;
            array2[4] = 5;
            array2[5] = 6;
            array2[6] = 7;
            array2[7] = 8;
            array2[8] = 9;
            array2[9] = 10;

            foreach(int number in array2)
            {
                Console.WriteLine($"Array2: {number}");
            }
            int[] array3 = new int[10];
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = i+1;

            }
            foreach (int number in array3)
            {
                Console.WriteLine($"array3: {number}");
            }

            int[] array4 = new int[10];
            for (int i = array4.Length-1,j=0;i >=  0; i--,j++)
            {
                array4[i] = j+1;
                
            }foreach(int number in array4)
            {
                Console.WriteLine($"array4: {number}");
            }
            int[] array5 = new int[10];
            Random rnd = new Random();
            
            
            for(int i = 0; i < array5.Length; i++)
            {
                array5[i] = rnd.Next(1, 101); ;
            }
            foreach (int number in array5)
            {
                Console.WriteLine($"array5: {number}");
            }



        }
    }
}
