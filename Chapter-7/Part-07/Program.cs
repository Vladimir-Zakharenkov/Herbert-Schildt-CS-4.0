#region Russian

// Инициализация многомерных массивов

// Для инициализации многомерного массива достаточно заключить в фигурные
// скобки список инициализаторов каждого его размера. Ниже в качестве примера приведена
// общая форма инициализации двумерного массива:

// тип[,] имя_массива = {
//  {val, val, val, ..., val},
//  {val, val, val, ..., val},

//  {val, val, val, ..., val}
// };

// где val обозначает инициализирующее значение, а каждый внутренний блок — отдельный
// ряд. Первое значение в каждом ряду сохраняется на первой позиции в массиве,
// второе значение — на второй позиции и т.д. Обратите внимание на то, что блоки
// инициализаторов разделяются запятыми, а после завершающей эти блоки закрывающей
// фигурной скобки ставится точка с запятой.

// В качестве примера ниже приведена программа, в которой двумерный массив sqrs
// инициализируется числами от 1 до 10 и квадратами этих чисел.

//Инициализировать двумерный массив.
using System;

class Squares
{
    static void Main()
    {
        int[,] sqrs =
        {
            {1,1 },
            {2,4 },
            {3,9 },
            {4,16 },
            {5,25 },
            {6,36 },
            {7,49 },
            {8,64 },
            {9,81 },
            {10,100 }
        };

        int i, j;

        for (i = 0; i < 10; i++)
        {
            for (j = 0; j < 2; j++)
            {
                Console.Write(sqrs[i,j] + " ");
            }

            Console.WriteLine();
        }

        //Задержка программы.
        Console.ReadKey();
    }
}

// При выполнении этой программы получается следующий результат.

// 1 1
// 2 4
// 3 9
// 4 16
// 5 25
// 6 36
// 7 49
// 8 64
// 9 81
// 10 100

#endregion

#region English

// Initializing Multidimensional Arrays

// A multidimensional array can be initialized by enclosing each dimension’s initializer list
// within its own set of curly braces. For example, the general form of array initialization for a
// two-dimensional array is shown here:

// type[,] array_name = {
//  { val, val, val, ..., val },
//  { val, val, val, ..., val },
//  ...
//  { val, val, val, ..., val }
// };

// Here, val indicates an initialization value. Each inner block designates a row. Within each
// row, the first value will be stored in the first position, the second value in the second position,
// and so on. Notice that commas separate the initializer blocks and that a semicolon follows
// the closing }.

// For example, the following program initializes an array called sqrs with the numbers 1
// through 10 and their squares.

// Initialize a two-dimensional array. 

// using System; 

// class Squares
// {
//    static void Main()
//    {
//        int[,] sqrs = {
//      { 1, 1 },
//      { 2, 4 },
//      { 3, 9 },
//      { 4, 16 },
//      { 5, 25 },
//      { 6, 36 },
//      { 7, 49 },
//      { 8, 64 },
//      { 9, 81 },
//      { 10, 100 }
//    };
//        int i, j;

//        for (i = 0; i < 10; i++)
//        {
//            for (j = 0; j < 2; j++)
//                Console.Write(sqrs[i, j] + " ");
//            Console.WriteLine();
//        }
//    }
// }

// Here is the output from the program:

// 1 1
// 2 4
// 3 9
// 4 16
// 5 25
// 6 36
// 7 49
// 8 64
// 9 81
// 10 100

#endregion