#region Russian

// Применение строк в операторах switch

// Объекты типа string могут использоваться для управления оператором switch.
// Это единственный нецелочисленный тип данных, который допускается применять
// в операторе switch. Благодаря такому применению строк в некоторых сложных ситуациях
// удается найти более простой выход из положения, чем может показаться на
// первый взгляд. Например, в приведенной ниже программе выводятся отдельные цифры,
// соответствующие словам "один", "два" и "три".

//Продемонстрировать управление оператором switch посредством строк.
using System;

class StringSSwitch
{
    static void Main()
    {
        string[] strs = { "один", "два", "три", "два", "один" };

        foreach (string s in strs)
        {
            switch (s)
            {
                case "один":
                    {
                        Console.Write(1);
                        break;
                    }
                case "два":
                    {
                        Console.Write(2);
                        break;
                    }
                case "три":
                    {
                        Console.Write(3);
                        break;
                    }
            }
        }

        Console.WriteLine();

        //Задержка программы.
        Console.ReadKey();

    }
}

// При выполнении этой программы получается следующий результат.

// 12321

#endregion

#region English

// Strings Can Be Used in switch Statements

// A string can be used to control a switch statement. It is the only non-integer type that can
// be used in the switch. The fact that strings can be used in switch statements makes it
// possible to handle some otherwise difficult situations quite easily. For example, the
// following program displays the digit equivalent of the words “one,” “two,” and “three”:

//A string can control a switch statement. 
// using System; 

// class StringSwitch
// {
//    static void Main()
//    {
//        string[] strs = { "one", "two", "three", "two", "one" };

//        foreach (string s in strs)
//        {
//            switch (s)
//            {
//                case "one":
//                    Console.Write(1);
//                    break;
//                case "two":
//                    Console.Write(2);
//                    break;
//                case "three":
//                    Console.Write(3);
//                    break;
//            }
//        }
//        Console.WriteLine();
//    }
// }

// The output is shown here:

// 12321

#endregion