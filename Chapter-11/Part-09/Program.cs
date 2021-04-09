#region Russian

// Применение ключевого слова base для доступа к скрытому имени

// Имеется еще одна форма ключевого слова base, которая действует подобно ключевому
// слову this, за исключением того, что она всегда ссылается на базовый класс
// в том производном классе, в котором она используется. Ниже эта форма приведена
// в общем виде:

// base.член

// где член может обозначать метод или переменную экземпляра. Эта форма ключевого
// слова base чаще всего применяется в тех случаях, когда под именами членов производного
// класса скрываются члены базового класса с теми же самыми именами. В качестве
// примера ниже приведен другой вариант иерархии классов из предыдущего примера.

//Применение ключевого слова base для преодоления препятствия, связанного с сокрытием имен.
using System;

class A
{
    public int i = 0;
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

    public void Show()
    {
        //Здесь выводится член i из класса A.
        Console.WriteLine("Член i в базовом классе: " + base.i);

        //А здесь выводится член i из класса B.
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

// Несмотря на то что переменная экземпляра i в производном классе В скрывает
// переменную i из базового класса А, ключевое слово base разрешает доступ к переменной
// i, определенной в базовом классе.

#endregion

#region English

// Using base to Access a Hidden Name

// There is a second form of base that acts somewhat like this, except that it always refers to the
// base class of the derived class in which it is used. This usage has the following general form:

// base.member

// Here, member can be either a method or an instance variable. This form of base is most
// applicable to situations in which member names of a derived class hide members by the
// same name in the base class. Consider this version of the class hierarchy from the preceding
// example:

// Using base to overcome name hiding. 

// using System; 

// class A
// {
//    public int i = 0;
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

//    public void Show()
//    {
//        // This displays the i in A. 
//        Console.WriteLine("i in base class: " + base.i);

//        // This displays the i in B. 
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

// This program displays the following:

// i in base class: 1
// i in derived class: 2

// Although the instance variable i in B hides the i in A, base allows access to the i defined in
// the base class.

#endregion