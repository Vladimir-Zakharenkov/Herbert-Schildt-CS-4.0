#region Russian

// Но переопределять виртуальный метод совсем не обязательно. Ведь если в производном
// классе не предоставляется собственный вариант виртуального метода, то используется
// его вариант из базового класса, как в приведенном ниже примере.

// Если виртуальный метод не переопределяется, то используется его вариант из базового класса.
using System;

class Base
{
    //Создать виртуальный метод в базовом классе.
    public virtual void Who()
    {
        Console.WriteLine("Метод Who() в классе Base");
    }
}

class Derived1 : Base
{
    //Переопределить метод Who() в производном классе.
    public override void Who()
    {
        Console.WriteLine("Метод Who() в классе Derived1");
    }
}

class Derived2 : Base
{
    //В этом классе метод Who() не переопределяется.
}

class NoOverrideDemo
{
    static void Main()
    {
        Base baseOb = new Base();
        Derived1 dOb1 = new Derived1();
        Derived2 dOb2 = new Derived2();

        Base baseRef; //ссылка на базовый класс

        baseRef = baseOb;
        baseRef.Who();

        baseRef = dOb1;
        baseRef.Who();

        baseRef = dOb2;
        baseRef.Who(); //вызывается метод Who() из класса Base

        //Задержка программы.
        Console.ReadKey();
    }
}

// Выполнение этого кода приводит к следующему результату.

// Метод Who() в классе Base.
// Метод Who() в классе Derived1
// Метод Who() в классе Base

// В данном примере метод Who() не переопределяется в классе Derived2. Поэтому
// для объекта класса Derived2 вызывается метод Who() из класса Base.

#endregion

#region English

// It is not necessary to override a virtual method. If a derived class does not provide
// its own version of a virtual method, then the one in the base class is used.For example:

/* When a virtual method is not overridden, 
   the base class method is used. */

// using System; 

// class Base
// {
//    // Create virtual method in the base class.  
//    public virtual void Who()
//    {
//        Console.WriteLine("Who() in Base");
//    }
// }

// class Derived1 : Base
// {
//    // Override Who() in a derived class. 
//    public override void Who()
//    {
//        Console.WriteLine("Who() in Derived1");
//    }
// }

// class Derived2 : Base
// {
//    // This class does not override Who(). 
// }

// class NoOverrideDemo
// {
//    static void Main()
//    {
//        Base baseOb = new Base();
//        Derived1 dOb1 = new Derived1();
//        Derived2 dOb2 = new Derived2();

//        Base baseRef; // a base-class reference 

//        baseRef = baseOb;
//        baseRef.Who();

//        baseRef = dOb1;
//        baseRef.Who();

//        baseRef = dOb2;
//        baseRef.Who(); // calls Base's Who() 
//    }
// }

// The output from this program is shown here:

// Who() in Base
// Who() in Derived1
// Who() in Base

// Here, Derived2 does not override Who( ). Thus, when Who() is called on a Derived2
// object, the Who( ) in Base is executed.

#endregion