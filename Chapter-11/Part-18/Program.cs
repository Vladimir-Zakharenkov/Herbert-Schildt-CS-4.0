#region Russian

// Если при наличии многоуровневой иерархии виртуальный метод не переопределяется
// в производном классе, то выполняется ближайший его вариант, обнаруживаемый
// вверх по иерархии, как в приведенном ниже примере.

//В многоуровневой иерархии классов выполняется тот переопределенный вариант виртуального метода,
//который обнаруживается первым при продвижении вверх по иерархии.
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

class Derived2 : Derived1
{
    //В этом классе метод Who() не переопределяется.
}

class Derived3 : Derived2
{
    //В этом классе метод Who() не переопределяется.
}

class NoOverrideDemo2
{
    static void Main()
    {
        Derived3 dOb = new Derived3();
        Base baseRef; //ссылка на базовый класс

        baseRef = dOb;
        baseRef.Who(); //вызов метода Who() из класса Derived1

        //Задержка программы.
        Console.ReadKey();
    }
}

// Вот к какому результату приводит выполнение этого кода.

// Метод Who() в классе Derived1

// В данном примере класс Derived3 наследует класс Derived2, который наследует
// класс Derived1, а тот, в свою очередь, — класс Base. Как показывает приведенный
// выше результат, выполняется метод Who(), переопределяемый в классе Derived1,
// поскольку это первый вариант виртуального метода, обнаруживаемый при продвижении
// вверх по иерархии от классов Derived3 и Derived2, где метод Who() не переопределяется,
// к классу Derived1.

// И еще одно замечание: свойства также подлежат модификации ключевым словом
// virtual и переопределению ключевым словом override. Это же относится и к индексаторам.

// Что дает переопределение методов

// Благодаря переопределению методов в C# поддерживается динамический полиморфизм.
// В объектно-ориентированном программировании полиморфизм играет
// очень важную роль, потому что он позволяет определить в общем классе методы,
// которые становятся общими для всех производных от него классов, а в производных
// классах — определить конкретную реализацию некоторых или же всех этих методов.
// Переопределение методов — это еще один способ воплотить в C# главный принцип
// полиморфизма: один интерфейс — множество методов.

// Удачное применение полиморфизма отчасти зависит от правильного понимания
// той особенности, что базовые и производные классы образуют иерархию, которая продвигается
// от меньшей к большей специализации. При надлежащем применении базовый
// класс предоставляет все необходимые элементы, которые могут использоваться
// в производном классе непосредственно. А с помощью виртуальных методов в базовом
// классе определяются те методы, которые могут быть самостоятельно реализованы в
// производном классе. Таким образом, сочетая наследование с виртуальными методами,
// можно определить в базовом классе общую форму методов, которые будут использоваться
// во всех его производных классах.

#endregion

#region English

// In the case of a multilevel hierarchy, if a derived class does not override a virtual
// method, then, while moving up the hierarchy, the first override of the method that is
// encountered is the one executed. For example:

/*  In a multilevel hierarchy, the first override of a virtual 
    method that is found while moving up the hierarchy is the 
    one executed. */

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

// class Derived2 : Derived1
// {
//    // This class also does not override Who().  
// }

// class Derived3 : Derived2
// {
//    // This class does not override Who().  
// }

// class NoOverrideDemo2
// {
//    static void Main()
//    {
//        Derived3 dOb = new Derived3();
//        Base baseRef; // a base-class reference  

//        baseRef = dOb;
//        baseRef.Who(); // calls Derived1's Who()  
//    }
// }

// Here, Derived3 inherits Derived2, which inherits Derived1, which inherits Base. As the
// output verifies, since Who( ) is not overridden by either Derived3 or Derived2, it is the
// override of Who( ) in Derived1 that is executed, since it is the first version of Who( ) that
// is found.

// One other point: Properties can also be modified by the virtual keyword and overridden
// using override. The same is true for indexers.

// Why Overridden Methods?

// Overridden methods allow C# to support runtime polymorphism. Polymorphism is essential
// to object-oriented programming for one reason: It allows a general class to specify methods
// that will be common to all of its derivatives, while allowing derived classes to define the
// specific implementation of some or all of those methods. Overridden methods are another
// way that C# implements the “one interface, multiple methods” aspect of polymorphism.

// Part of the key to applying polymorphism successfully is understanding that the base
// classes and derived classes form a hierarchy that moves from lesser to greater specialization.
// Used correctly, the base class provides all elements that a derived class can use directly.Through
// virtual methods, it also defines those methods that the derived class can implement on its
// own. This allows the derived class flexibility, yet still enforces a consistent interface. Thus,
// by combining inheritance with overridden methods, a base class can define the general
// form of the methods that will be used by all of its derived classes.

#endregion