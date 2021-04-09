#region Russian

// С помощью ключевого слова base могут также вызываться скрытые методы.
// Например, в приведенном ниже коде класс В наследует класс А и в обоих классах
// объявляется метод Show(). А затем в методе Show() класса В с помощью ключевого
// слова base вызывается вариант метода Show(), определенный в классе А.

//Вызвать скрытый метод.
using System;

class A
{
    public int i = 0;

    //Метод Show() в классе A.
    public void Show()
    {
        Console.WriteLine("Член i в базовом классе: " + i);
    }
}

//Создать производный класс.
class B : A
{
    new int i; //этот член скрывает член i из класса A

    public B(int a, int b)
    {
        base.i = a; //здесь обнаруживается скрытый член из класса A
        i = b; //член i из класса B
    }
    //Здесь скрывается метод Show() из класса A.
    //Обратите внимание на применение ключевого слова new.
    new public void Show()
    {
        base.Show(); //здесь вызывается метод Show() из класса A

        //далее выводится член i из класса B
        Console.WriteLine("Член i в производном классе: " + i);
    }
}

class UncoverName
{
    static void Main()
    {
        B ob = new B(1, 2);
        ob.Show();

        //Задержка программы.
        Console.ReadKey();
    }
}

// Выполнение этого кода приводит к следующему результату.

// Член i в базовом классе: 1
// Член i в производном классе: 2

// Как видите, в выражении base.Show() вызывается вариант метода Show() из базового класса.

// Обратите также внимание на следующее: ключевое слово new используется в приведенном
// выше коде с целью сообщить компилятору о том, что метод Show(), вновь
// объявляемый в производном классе В, намеренно скрывает другой метод Show(),
// определенный в базовом классе А.

#endregion

#region English

// Hidden methods can also be called through the use of base. For example, in the
// following code, class B inherits class A, and both A and B declare a method called Show( ).
// Inside, B’s Show(), the version of Show( ) defined by A is called through the use of base.

// Call a hidden method. 

// using System; 

// class A
// {
//    public int i = 0;

//    // Show() in A 
//    public void Show()
//    {
//        Console.WriteLine("i in base class: " + i);
//    }
// }

// // Create a derived class. 
// class B : A
// {
//    new int i; // this i hides the i in A 

//    public B(int a, int b)
//    {
//        base.i = a; // this uncovers the i in A 
//        i = b; // i in B 
//    }

//    // This hides Show() in A. Notice the use of new. 
//    new public void Show()
//    {
//        base.Show(); // this calls Show() in A 

//        // this displays the i in B 
//        Console.WriteLine("i in derived class: " + i);
//    }
// }

// class UncoverName
// {
//    static void Main()
//    {
//        B ob = new B(1, 2);

//        ob.Show();
//    }
// }

// The output from the program is shown here:

// i in base class: 1
// i in derived class: 2

// As you can see, base.Show( ) calls the base class version of Show().

// One other point: Notice that new is used in this program to tell the compiler that you
// know a new method called Show() is being declared that hides the Show( ) in A.

#endregion