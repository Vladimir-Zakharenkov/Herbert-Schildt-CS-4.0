#region Russian

// Благодаря наличию у массивов свойства Length операции с массивами во многих
// алгоритмах становятся более простыми, а значит, и более надежными. В качестве примера
// свойство Length используется в приведенной ниже программе с целью поменять
// местами содержимое элементов массива, скопировав их в обратном порядке в другой массив.

//Поменять местами содержимое элементов массива.
using System;

class RevCopy
{
    static void Main()
    {
        int i, j;

        int[] nums1 = new int[10];
        int[] nums2 = new int[10];

        for (i = 0; i < nums1.Length; i++)
        {
            nums1[i] = i;
        }

        Console.Write("Исходное содержимое массива: ");
        for (i = 0; i < nums1.Length; i++)
        {
            Console.Write(nums1[i] + " ");
        }

        Console.WriteLine();

        //Скопировать элементы массива nums1 в массив nums2 в обратном порядке.
        if (nums2.Length >= nums1.Length) //проверить, достаточно ли длины массива nums2
        {
            for (i = 0, j = nums1.Length - 1; i < nums1.Length; i++, j--)
            {
                nums2[j] = nums1[i];
            }
        }

        Console.Write("Содержимое массива в обратном порядке: ");
        for (i = 0; i < nums2.Length; i++)
        {
            Console.Write(nums2[i] + " ");
        }

        Console.WriteLine();

        //Задержка программы.
        Console.ReadKey();
    }
}

// Выполнение этой программы дает следующий результат.

// Исходное содержимое массива: 0 1 2 3 4 5 6 7 8 9
// Содержимое массива в обратном порядке: 9 8 7 6 5 4 3 2 1 0

// В данном примере свойство Length помогает выполнить две важные функции. Во-
// первых, оно позволяет убедиться в том, что длины целевого массива достаточно для
// хранения содержимого исходного массива. И во-вторых, оно предоставляет условие
// для завершения цикла for, в котором выполняется копирование исходного массива в
// обратном порядке. Конечно, в этом простом примере размеры массивов нетрудно выяснить
// и без свойства Length, но аналогичный подход может быть применен в целом
// ряде других, более сложных ситуаций.

#endregion

#region English

// The inclusion of the Length property simplifies many algorithms by making certain
// types of array operations easier—and safer—to perform. For example, the following
// program uses Length to reverse the contents of an array by copying it back-to-front into
// another array:

// Reverse an array. 
// using System; 

// class RevCopy
// {
//    static void Main()
//    {
//        int i, j;
//        int[] nums1 = new int[10];
//        int[] nums2 = new int[10];

//        for (i = 0; i < nums1.Length; i++) nums1[i] = i;

//        Console.Write("Original contents: ");
//        for (i = 0; i < nums2.Length; i++)
//            Console.Write(nums1[i] + " ");

//        Console.WriteLine();

//        // Reverse copy nums1 to nums2. 
//        if (nums2.Length >= nums1.Length) // make sure nums2 is long enough 
//            for (i = 0, j = nums1.Length - 1; i < nums1.Length; i++, j--)
//                nums2[j] = nums1[i];

//        Console.Write("Reversed contents: ");
//        for (i = 0; i < nums2.Length; i++)
//            Console.Write(nums2[i] + " ");

//        Console.WriteLine();
//    }
// }

// Here is the output:

// Original contents: 0 1 2 3 4 5 6 7 8 9
// Reversed contents: 9 8 7 6 5 4 3 2 1 0

// Here, Length helps perform two important functions. First, it is used to confirm that the
// target array is large enough to hold the contents of the source array. Second, it provides
// the termination condition of the for loop that performs the reverse copy. Of course, in this
// simple example, the size of the arrays is easily known, but this same approach can be
// applied to a wide range of more challenging situations.

#endregion