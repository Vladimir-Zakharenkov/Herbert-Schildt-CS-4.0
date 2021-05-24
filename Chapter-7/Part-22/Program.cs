#region Russian

// Рассмотрим более интересный пример. В приведенной ниже программе целое число
// выводится словами. Например, число 19 выводится словами "один девять".

//Вывести отдельные цифры целого числа словами.
using System;

class ConvertDigitsToWords
{
    static void Main()
    {
        int num;
        int nextdigit;
        int numdigits;
        int[] n = new int[20];

        string[] digits = { "нуль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

        num = 1908;

        Console.WriteLine("Число: " + num);

        Console.WriteLine("Число словами: ");

        nextdigit = 0;
        numdigits = 0;

        //Получить отдельные цифры и сохранить их в массиве n.
        //Эти цифры сохраняются в обратном порядке.
        do
        {
            nextdigit = num % 10;
            n[numdigits] = nextdigit;
            numdigits++;
            num = num / 10;
        }
        while (num > 0);

        numdigits--;

        //Вывести полученные слова.
        for (; numdigits >= 0; numdigits--)
        {
            Console.Write(digits[n[numdigits]] + " ");
        }

        Console.WriteLine();

        //Задержка программы.
        Console.ReadKey();

    }
}

// Выполнение этой программы приводит к следующему результату.

// Число: 1908
// Число словами: один девять нуль восемь

// В данной программе использован массив строк digits для хранения словесных
// обозначений цифр от 0 до 9. По ходу выполнения программы целое число преобразуется
// в слова. Для этого сначала получаются отдельные цифры числа, а затем они сохраняются
// в обратном порядке следования в массиве n типа int. После этого выполняется
// циклический опрос массива n в обратном порядке. При этом каждое целое значение
// из массива n служит в качестве индекса, указывающего на слова, соответствующие полученным
// цифрам числа и выводимые как строки.

#endregion

#region English

// Here is a more interesting example.The following program displays an integer value
// using words.For example, the value 19 will display as “one nine”.

//Display the digits of an integer using words. 
// using System; 

// class ConvertDigitsToWords
// {
//    static void Main()
//    {
//        int num;
//        int nextdigit;
//        int numdigits;
//        int[] n = new int[20];

//        string[] digits = { "zero", "one", "two",
//                        "three", "four", "five",
//                        "six", "seven", "eight",
//                        "nine" };

//        num = 1908;

//        Console.WriteLine("Number: " + num);

//        Console.Write("Number in words: ");

//        nextdigit = 0;
//        numdigits = 0;

//        // Get individual digits and store in n. 
//        // These digits are stored in reverse order. 
//        do
//        {
//            nextdigit = num % 10;
//            n[numdigits] = nextdigit;
//            numdigits++;
//            num = num / 10;
//        } while (num > 0);
//        numdigits--;

//        // Display the words. 
//        for (; numdigits >= 0; numdigits--)
//            Console.Write(digits[n[numdigits]] + " ");

//        Console.WriteLine();
//    }
// }

// The output is shown here:

// Number: 1908
// Number in words: one nine zero eight

// In the program, the string array digits holds in order the word equivalents of the digits
// from zero to nine. The program converts an integer into words by first obtaining each digit
// of the value and storing those digits, in reverse order, in the int array called n. Then, this
// array is cycled through from back to front. In the process, each integer value in n is used as
// an index into digits, with the corresponding string being displayed.

#endregion