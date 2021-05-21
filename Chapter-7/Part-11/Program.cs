#region Russian

// Когда запрашивается длина многомерного массива, то возвращается общее число
// элементов, из которых может состоять массив, как в приведенном ниже примере кода.

// Использовать свойство Length трехмерного массива.
using System;

class LengthDemo3D
{
    static void Main()
    {
        int[,,] nums = new int[10, 5, 6];

        Console.WriteLine("Длина массива nums равна " + nums.Length);

        //Задержка программы.
        Console.ReadKey();
    }
}

// При выполнении этого кода получается следующий результат.

// Длина массива nums равна 300

// Как подтверждает приведенный выше результат, свойство Length содержит число
// элементов, из которых может состоять массив (в данном случае — 300 (10×5×6) элементов).
// Тем не менее свойство Length нельзя использовать для определения длины
// массива в отдельном его измерении.

#endregion

#region English

// When the length of a multidimensional array is obtained, the total number of elements
// that can be held by the array is returned. For example:

// Use the Length array property on a 3-D array. 

// using System; 

// class LengthDemo3D
// {
//    static void Main()
//    {
//        int[,,] nums = new int[10, 5, 6];

//        Console.WriteLine("Length of nums is " + nums.Length);
//    }
// }

// The output is shown here:

// Length of nums is 300

// As the output verifies, Length obtains the number of elements that nums can hold, which
// is 300 (10×5×6) in this case. It is not possible to use Length to obtain the length of a specific
// dimension.

#endregion