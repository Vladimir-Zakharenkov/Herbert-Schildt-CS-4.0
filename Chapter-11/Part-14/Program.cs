#region Russian

// Вообще говоря, переменная ссылки на объект может ссылаться только на объект
// своего типа.

// Но из этого принципа строгого соблюдения типов в C# имеется одно важное исключение:
// переменной ссылки на объект базового класса может быть присвоена ссылка
// на объект любого производного от него класса. Такое присваивание считается вполне
// допустимым, поскольку экземпляр объекта производного типа инкапсулирует экземпляр
// объекта базового типа. Следовательно, по ссылке на объект базового класса
// можно обращаться к объекту производного класса. Ниже приведен соответствующий
// пример.

//По ссылке на объект базового класса можно обращаться к объекту производного класса.
using System;

class X
{
    public int a;

    public X(int i)
    {
        a = i;
    }
}

class Y : X
{
    public int b;

    public Y(int i, int j) : base(j)
    {
        b = i;
    }
}

class BaseRef
{
    static void Main()
    {
        X x = new X(10);
        X x2;

        Y y = new Y(5, 6);

        x2 = x; //верно, поскольку оба объекта относятся к одному и тому же типу
        Console.WriteLine("x2.a: " + x2.a);

        x2 = y; //тоже верно, поскольку класс Y является производным от класса X
        Console.WriteLine("x2.a: " + x2.a);

        //ссылкам на объекты класса X известно только о членах класса X
        x2.a = 19; //верно
        Console.WriteLine("x2.a: " + x2.a);

        // x2.b = 27 //неверно, поскольку член b отсутствует у класса X

        //Задержка программы.
        Console.ReadKey();
    }
}

// В данном примере класс Y является производным от класса X. Поэтому следующая
// операция присваивания:

// х2 = у; // тоже верно, поскольку класс Y является производным от класса X

// считается вполне допустимой. Ведь по ссылке на объект базового класса (в данном случае
// — это переменная х2 ссылки на объект класса X) можно обращаться к объекту производного
// класса, т.е. к объекту, на который ссылается переменная у.

// Следует особо подчеркнуть, что доступ к конкретным членам класса определяется
// типом переменной ссылки на объект, а не типом объекта, на который она ссылается.
// Это означает, что если ссылка на объект производного класса присваивается переменной
// ссылки на объект базового класса, то доступ разрешается только к тем частям этого
// объекта, которые определяются базовым классом. Именно поэтому переменной х2
// недоступен член b класса Y, когда она ссылается на объект этого класса. И в этом есть
// своя логика, поскольку базовому классу ничего не известно о тех членах, которые добавлены
// в производный от него класс. Именно поэтому последняя строка кода в приведенном
// выше примере была закомментирована.

// Несмотря на кажущийся несколько отвлеченным характер приведенных выше рас-
// суждений, им можно найти ряд важных применений на практике. Одно из них рассматривается
// ниже, а другое — далее в этой главе, когда речь пойдет о виртуальных методах.

#endregion

#region English

// In general, an object reference variable can refer only to objects of its type.

// There is, however, an important exception to C#’s strict type enforcement. A reference
// variable of a base class can be assigned a reference to an object of any class derived from
// that base class. This is legal because an instance of a derived type encapsulates an instance
// of the base type. Thus, a base class reference can refer to it. Here is an example:

// A base class reference can refer to a derived class object. 

// using System; 

// class X
// {
//    public int a;

//    public X(int i)
//    {
//        a = i;
//    }
// }

// class Y : X
// {
//    public int b;

//    public Y(int i, int j) : base(j)
//    {
//        b = i;
//    }
// }

// class BaseRef
// {
//    static void Main()
//    {
//        X x = new X(10);
//        X x2;
//        Y y = new Y(5, 6);

//        x2 = x; // OK, both of same type 
//        Console.WriteLine("x2.a: " + x2.a);

//        x2 = y; // Ok because Y is derived from X 
//        Console.WriteLine("x2.a: " + x2.a);

//        // X references know only about X members 
//        x2.a = 19; // OK 
//                   //    x2.b = 27; // Error, X doesn't have a b member 
//    }
// }

// In this program, Y is derived from X.Now, the assignment

// x2 = y; // OK because Y is derived from X

// is permissible because a base class reference, x2 in this case, can refer to a derived class
// object(which is the object referred to by y).

// It is important to understand that it is the type of the reference variable—not the type of
// the object that it refers to—that determines what members can be accessed. That is, when a
// reference to a derived class object is assigned to a base class reference variable, you will
// have access only to those parts of the object defined by the base class. This is why x2 can’t
// access b even when it refers to a Y object. This makes sense because the base class has no
// knowledge of what a derived class adds to it.This is why the last line of code in the program
// is commented out.

// Although the preceding discussion may seem a bit esoteric, it has some important
// practical applications. One is described here. The other is discussed later in this chapter,
// when virtual methods are covered.

#endregion