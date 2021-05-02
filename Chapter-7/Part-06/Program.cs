#region Russian

// Массивы трех и более измерений

// В C# допускаются массивы трех и более измерений. Ниже приведена общая форма
// объявления многомерного массива.

// тип[,...,] имя_массива = new тип[размер1, размер2, ... размерN];

// Например, в приведенном ниже объявлении создается трехмерный целочисленный
// массив размерами 4×10×3.

// int[,,] multidim = new int[4, 10, 3];

// А в следующем операторе элементу массива multidim с координатами местоположения
// (2,4,1) присваивается значение 100.

// multidim[2, 4, 1] = 100;

// Ниже приведен пример программы, в которой сначала организуется трехмерный
// массив, содержащий матрицу значений 3×3×3, а затем значения элементов этого массива
// суммируются по одной из диагоналей матрицы.

//Суммировать значения по одной из диагоналей матрицы 3×3×3.
using System;

class ThreeDMatrix
{
    static void Main()
    {
        int[,,] m = new int[3, 3, 3];
        int sum = 0;
        int n = 1;

        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                for (int z = 0; z < 3; z++)
                {
                    m[x, y, z] = n++;
                }
            }
        }

        sum = m[0, 0, 0] + m[1, 1, 1] + m[2, 2, 2];

        Console.WriteLine("Сумма значений по первой диагонали: " + sum);

        //Задержка программы.
        Console.ReadKey();
    }
}

// Вот какой результат дает выполнение этой программы.

// Сумма значений по первой диагонали: 42

#endregion

#region English

// Arrays of Three or More Dimensions

// C# allows arrays with more than two dimensions. Here is the general form of a
// multidimensional array declaration:

// type[, ...,] name = new type[size1, size2, ..., sizeN];

// For example, the following declaration creates a 4×10×3 three-dimensional integer array:

// int[,,] multidim = new int[4, 10, 3];

// To assign element 2, 4, 1 of multidim the value 100, use this statement:

// multidim[2, 4, 1] = 100;

// Here is a program that uses a three-dimensional array that holds a 3×3×3 matrix of
// values. It then sums the value on one of the diagonals through the cube.

// Sum the values on a diagonal of a 3x3x3 matrix. 

// using System; 

// class ThreeDMatrix
// {
//    static void Main()
//    {
//        int[,,] m = new int[3, 3, 3];
//        int sum = 0;
//        int n = 1;

//        for (int x = 0; x < 3; x++)
//            for (int y = 0; y < 3; y++)
//                for (int z = 0; z < 3; z++)
//                    m[x, y, z] = n++;

//        sum = m[0, 0, 0] + m[1, 1, 1] + m[2, 2, 2];

//        Console.WriteLine("Sum of first diagonal: " + sum);
//    }
// }

// The output is shown here:

// Sum of first diagonal: 42

#endregion