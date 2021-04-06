#region Russian

// Организация защищенного доступа

// Как пояснялось выше, закрытый член базового класса недоступен для производного
// класса. Из этого можно предположить, что для доступа к некоторому члену базового
// класса из производного класса этот член необходимо сделать открытым. Но если
// сделать член класса открытым, то он станет доступным для всего кода, что далеко не
// всегда желательно. Правда, упомянутое предположение верно лишь отчасти, поскольку
// в C# допускается создание защищенного члена класса. Защищенный член является
// открытым в пределах иерархии классов, но закрытым за пределами этой иерархии.

// Защищенный член создается с помощью модификатора доступа protected. Если
// член класса объявляется как protected, он становится закрытым, но за исключением
// одного случая, когда защищенный член наследуется. В этом случае защищенный член
// базового класса становится защищенным членом производного класса, а значит, доступным
// для производного класса. Таким образом, используя модификатор доступа
// protected, можно создать члены класса, являющиеся закрытыми для своего класса,
// но все же наследуемыми и доступными для производного класса.

// Ниже приведен простой пример применения модификатора доступа protected.

//Продемонстрировать применение модификатора доступа protected.
using System;

class B
{
    protected int i, j; //члены, закрытые для класса B, но доступные для класса D.

    public void Set(int a, int b)
    {
        i = a;
        j = b;
    }

    public void Show()
    {
        Console.WriteLine(i + " " + j);
    }
}

class D : B
{
    int k; //закрытый член

    //члены i и j класса B доступны для класса D
    public void Setk()
    {
        k = i * j;
    }

    public void Showk()
    {
        Console.WriteLine(k);
    }
}

class ProtectedDemo
{
    static void Main()
    {
        D ob = new D();
        ob.Set(2, 3); //допустимо, поскольку доступно для класса D
        ob.Show(); //допустимо, поскольку доступно для класса D
        ob.Setk(); //допустимо, поскольку входит в класс D
        ob.Showk(); //допустимо, поскольку входит в класс D

        //Задержка программы.
        Console.ReadKey();
    }
}

// В данном примере класс В наследуется классом D, а его члены i и j объявлены как
// protected, и поэтому они доступны для метода Setk(). Если бы члены i и j класса В
// были объявлены как private, то они оказались бы недоступными для класса D, и приведенный
// выше код нельзя было бы скомпилировать.

// Аналогично состоянию public и private, состояние protected сохраняется за
// членом класса независимо от количества уровней наследования. Поэтому когда производный
// класс используется в качестве базового для другого производного класса, любой
// защищенный член исходного базового класса, наследуемый первым производным
// классом, наследуется как защищенный и вторым производным классом.

// Несмотря на всю свою полезность, защищенный доступ пригоден далеко не для
// всех ситуаций. Так, в классе TwoDShape из приведенного ранее примера требовалось,
// чтобы значения его членов Width и Height были доступными открыто, поскольку
// нужно было управлять значениями, которые им присваивались, что было бы невозможно,
// если бы они были объявлены как protected. В данном случае более подходящим
// решением оказалось применение свойств, чтобы управлять доступом, а не предотвращать
// его. Таким образом, модификатор доступа protected следует применять
// в том случае, если требуется создать член класса, доступный для всей иерархии классов,
// но для остального кода он должен быть закрытым. А для управления доступом к
// значению члена класса лучше воспользоваться свойством.

#endregion

#region English

// Using Protected Access

// As just explained, a private member of a base class is not accessible to a derived class. This
// would seem to imply that if you wanted a derived class to have access to some member in
// the base class, it would need to be public. Of course, making the member public also makes
// it available to all other code, which may not be desirable. Fortunately, this implication is
// untrue because C# allows you to create a protected member. A protected member is public
// within a class hierarchy, but private outside that hierarchy.

// A protected member is created by using the protected access modifier.When a member
// of a class is declared as protected, that member is, with one important exception, private.
// The exception occurs when a protected member is inherited.In this case, a protected member
// of the base class becomes a protected member of the derived class and is, therefore, accessible
// to the derived class. Therefore, by using protected, you can create class members that are
// private to their class but that can still be inherited and accessed by a derived class.

// Here is a simple example that uses protected:

// // Demonstrate protected. 

// using System; 

// class B
// {
//    protected int i, j; // private to B, but accessible by D 

//    public void Set(int a, int b)
//    {
//        i = a;
//        j = b;
//    }

//    public void Show()
//    {
//        Console.WriteLine(i + " " + j);
//    }
// }

// class D : B
// {
//    int k; // private 

//    // D can access B's i and j 
//    public void Setk()
//    {
//        k = i * j;
//    }

//    public void Showk()
//    {
//        Console.WriteLine(k);
//    }
// }

// class ProtectedDemo
// {
//    static void Main()
//    {
//        D ob = new D();

//        ob.Set(2, 3); // OK, known to D 
//        ob.Show();    // OK, known to D 

//        ob.Setk();  // OK, part of D 
//        ob.Showk(); // OK, part of D 
//    }
// }

// In this example, because B is inherited by D and because i and j are declared as protected in
// B, the Setk() method can access them. If i and j had been declared as private by B, then D
// would not have access to them, and the program would not compile.

// Like public and private, protected status stays with a member no matter how many
// layers of inheritance are involved. Therefore, when a derived class is used as a base class for
// another derived class, any protected member of the initial base class that is inherited by the
// first derived class is also inherited as protected by a second derived class.

// Although protected access is quite useful, it doesn’t apply in all situations. For example,
// in the case of TwoDShape shown in the preceding section, we specifically want the Width
// and Height values to be publicly accessible. It’s just that we want to manage the values they
// are assigned. Therefore, declaring them protected is not an option. In this case, the use of
// properties supplies the proper solution by controlling, rather than preventing, access.
// Remember, use protected when you want to create a member that is accessible throughout
// a class hierarchy, but otherwise private. To manage access to a value, use a property.

#endregion