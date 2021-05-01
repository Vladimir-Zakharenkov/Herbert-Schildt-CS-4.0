#region Russian

// Двумерные массивы

// Простейшей формой многомерного массива является двумерный массив. Местоположение
// любого элемента в двумерном массиве обозначается двумя индексами. Такой
// массив можно представить в виде таблицы, на строки которой указывает один индекс,
// а на столбцы — другой.

// В следующей строке кода объявляется двумерный массив integer размерами 10×20.

// int[,] table = new int[10, 20];

// Обратите особое внимание на объявление этого массива. Как видите, оба его размера
// разделяются запятой. В первой части этого объявления синтаксическое обозначение

// [,]

// означает, что создается переменная ссылки на двумерный массив. Если же память распределяется
// для массива с помощью оператора new, то используется следующее синтаксическое обозначение.

// int[10, 20]

// В данном объявлении создается массив размерами 10×20, но и в этом случае его размеры
// разделяются запятой.

// Для доступа к элементу двумерного массива следует указать оба индекса, разделив
// их запятой. Например, в следующей строке кода элементу массива table с координатами
// местоположения (3,5) присваивается значение 10.

// table[3, 5] = 10;

// Ниже приведен более наглядный пример в виде небольшой программы, в которой
// двумерный массив сначала заполняется числами от 1 до 12, а затем выводится его содержимое.

//Продемонстрировать двумерный массив.
using System;

class TwoD
{
    static void Main()
    {
        int t, i;
        int[,] table = new int[3, 4];

        for (t = 0; t < 3; ++t)
        {
            for (i = 0; i < 4; ++i)
            {
                table[t, i] = (t * 4) + i + 1;
                Console.Write(table[t, i] + " ");
            }

            Console.WriteLine();
        }

        //Задержка программы.
        Console.ReadKey();
    }
}

// В данном примере элемент массива table[0,0] будет иметь значение 1, элемент
// массива table[0,1] — значение 2, элемент массива table[0,2] — значение 3 и т.д.
// А значение элемента массива table[2,3] окажется равным 12.

// СОВЕТ
// Если вам приходилось раньше программировать на С, C++ или Java, то будьте особенно
// внимательны, объявляя или организуя доступ к многомерным массивам в С#. В этих языках
// программирования размеры массива и индексы указываются в отдельных квадратных
// скобках, тогда как в C# они разделяются запятой.

#endregion

#region English

// Multidimensional Arrays

// Although the one-dimensional array is the most commonly used array in programming,
// multidimensional arrays are certainly not rare. A multidimensional array is an array that has
// two or more dimensions, and an individual element is accessed through the combination
// of two or more indices.

// Two-Dimensional Arrays

// The simplest form of the multidimensional array is the two-dimensional array. In a twodimensional
// array, the location of any specific element is specified by two indices. If you
// think of a two-dimensional array as a table of information, one index indicates the row, the
// other indicates the column.

// To declare a two-dimensional integer array table of size 10, 20, you would write

// int[,] table = new int[10, 20];

// Pay careful attention to the declaration. Notice that the two dimensions are separated from
// each other by a comma. In the first part of the declaration, the syntax

// [,]

// indicates that a two-dimensional array reference variable is being created. When memory is
// actually allocated for the array using new, this syntax is used:

// int[10, 20]

// This creates a 10×20 array, and again, the comma separates the dimensions.

// To access an element in a two-dimensional array, you must specify both indices,
// separating the two with a comma. For example, to assign the value 10 to location 3, 5
// of array table, you would use

// able[3, 5] = 10;

// Here is a complete example.It loads a two-dimensional array with the numbers 1
// through 12 and then displays the contents of the array.

// Demonstrate a two-dimensional array.  

// using System; 

// class TwoD
// {
//    static void Main()
//    {
//        int t, i;
//        int[,] table = new int[3, 4];

//        for (t = 0; t < 3; ++t)
//        {
//            for (i = 0; i < 4; ++i)
//            {
//                table[t, i] = (t * 4) + i + 1;
//                Console.Write(table[t, i] + " ");
//            }
//            Console.WriteLine();
//        }
//    }
// }

// In this example, table[0, 0] will have the value 1, table[0, 1] the value 2, table[0, 2] the
// value 3, and so on.The value of table[2, 3] will be 12.

// NOTE
// If you have previously programmed in C, C++, or Java, be careful when declaring or accessing
// multidimensional arrays in C#. In these other languages, array dimensions and indices are
// specified within their own set of brackets. C# separates dimensions using commas.

#endregion