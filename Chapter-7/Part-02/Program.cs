#region Russian

// Массивы часто применяются в программировании потому, что они дают возможность
// легко обращаться с большим числом взаимосвязанных переменных. Например,
// в приведенной ниже программе выявляется среднее арифметическое ряда значений,
// хранящихся в массиве nums, который циклически опрашивается с помощью оператора
// цикла for.

//Вычислить среднее арифметическое ряда значений.
using System;

class Average
{
    static void Main()
    {
        int[] nums = new int[10];
        int avg = 0;

        nums[0] = 99;
        nums[1] = 10;
        nums[2] = 100;
        nums[3] = 18;
        nums[4] = 78;
        nums[5] = 23;
        nums[6] = 63;
        nums[7] = 9;
        nums[8] = 87;
        nums[9] = 49;

        for (int i = 0; i < 10; i++)
        {
            avg = avg + nums[i];
        }

        avg = avg / 10;

        Console.WriteLine("Среднее: " + avg);

        //Задержка программы.
        Console.ReadKey();
    }
}

#endregion

#region English

// Arrays are common in programming because they let you deal easily with large numbers
// of related variables. For example, the following program finds the average of the set of values
// stored in the nums array by cycling through the array using a for loop:

// Compute the average of a set of values. 

// using System; 

// class Average
// {
//    static void Main()
//    {
//        int[] nums = new int[10];
//        int avg = 0;

//        nums[0] = 99;
//        nums[1] = 10;
//        nums[2] = 100;
//        nums[3] = 18;
//        nums[4] = 78;
//        nums[5] = 23;
//        nums[6] = 63;
//        nums[7] = 9;
//        nums[8] = 87;
//        nums[9] = 49;

//        for (int i = 0; i < 10; i++)
//            avg = avg + nums[i];

//        avg = avg / 10;

//        Console.WriteLine("Average: " + avg);
//    }
// }

// The output from the program is shown here:

// Average: 53

#endregion