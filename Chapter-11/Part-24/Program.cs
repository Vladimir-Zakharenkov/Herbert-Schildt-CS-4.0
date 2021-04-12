#region Russian

// Ниже приведен еще один, более интересный пример упаковки. В данном случае
// значение типа int передается в качестве аргумента методу Sqr(), который, в свою
// очередь, принимает параметр типа object.

//Пример упаковки при передаче значения методу.
using System;

class BoxingDemo
{
    static void Main()
    {
        int x;
        x = 10;

        Console.WriteLine("Значение x равно: " + x);

        //значение переменной x автоматически упаковывается
        //когда оно передается методу Sqr().
        x = BoxingDemo.Sqr(x);
        Console.WriteLine("Значение x в квадрате равно: " + x);

        //Задержка программы.
        Console.ReadKey();
    }

    static int Sqr(object o)
    {
        return (int)o * (int)o;
    }
}

// Вот к какому результату приводит выполнение этого кода.

// Значение х равно: 10
// Значение х в квадрате равно: 100

// В данном примере значение переменной х автоматически упаковывается при передаче
// методу Sqr().

#endregion

#region English

// Here is another, more interesting example of boxing. In this case, an int is passed as an
// argument to the Sqr() method, which uses an object parameter.

// Boxing also occurs when passing values. 

// using System; 

// class BoxingDemo
// {
//    static void Main()
//    {
//        int x;

//        x = 10;
//        Console.WriteLine("Here is x: " + x);

//        // x is automatically boxed when passed to Sqr(). 
//        x = BoxingDemo.Sqr(x);
//        Console.WriteLine("Here is x squared: " + x);
//    }

//    static int Sqr(object o)
//    {
//        return (int)o * (int)o;
//    }
// }

// The output from the program is shown here:

// Here is x: 10
// Here is x squared: 100

// Here, the value of x is automatically boxed when it is passed to Sqr().

#endregion