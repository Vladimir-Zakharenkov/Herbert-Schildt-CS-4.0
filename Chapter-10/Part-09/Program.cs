#region Russian

// Применение модификаторов доступа в аксессорах

// По умолчанию доступность аксессоров set и get оказывается такой же, как и у
// индексатора и свойства, частью которых они являются. Так, если свойство объявляется
// как public, то по умолчанию его аксессоры set и get также становятся открытыми
// (public). Тем не менее для аксессора set или get можно указать собственный модификатор
// доступа, например private. Но в любом случае доступность аксессора,
// определяемая таким модификатором, должна быть более ограниченной, чем доступность,
// указываемая для его свойства или индексатора.

// Существует целый ряд причин, по которым требуется ограничить доступность аксессора.
// Допустим, что требуется предоставить свободный доступ к значению свойства,
// но вместе с тем дать возможность устанавливать это свойство только членам его класса.
// Для этого достаточно объявить аксессор данного свойства как private. В приведенном
// ниже примере используется свойство MyProp, аксессор set которого указан как private.

//Применить модификатор доступа в аксессоре.
using System;

class PropAccess
{
    int prop; //поле, управляемое свойством MyProp

    public PropAccess()
    {
        prop = 0;
    }

    //Это свойство обеспечивает доступ к закрытой переменной экземпляра prop.
    //Оно разрешает получать значение переменной prop из любого кода,
    //но устанавливать его - только членам своего класса.
    public int MyProp
    {
        get
        {
            return prop;
        }

        private set
        {
            //теперь это закрытый аксессор
            prop = value;
        }
    }

    //Этот член класса инкрементирует значение MyProp.
    public void IncrProp()
    {
        MyProp++; //Допускается в том же самом классе.
    }
}

//Продемонстрировать применение модификатора доступа в аксессоре свойства.
class PropAccessDemo
{
    static void Main()
    {
        PropAccess ob = new PropAccess();

        Console.WriteLine("Первоначальное значение ob.MyProp: " + ob.MyProp);

        //ob.MyProp = 100; //недоступно для установки

        ob.IncrProp();
        Console.WriteLine("Значение ob.MyProp после инкрементирования: " + ob.MyProp);

        //Задержка программы.
        Console.ReadKey();
    }
}

// В классе PropAccess аксессор set указан как private. Это означает, что он доступен
// только другим членам данного класса, например методу IncrProp(), но недоступен
// для кода за пределами класса PropAccess. Именно поэтому попытка Присвоить
// свойству ob.МуРrор значение в классе PropAccessDemo закомментирована.

#endregion

#region English

// Use Access Modifiers with Accessors

// By default, the set and get accessors have the same accessibility as the indexer or property
// of which they are a part. For example, if the property is declared public, then by default the
// get and set accessors are also public. It is possible, however, to give set or get its own access
// modifier, such as private. In all cases, the access modifier for an accessor must be more
// restrictive than the access specification of its property or indexer.

// There are a number of reasons why you may want to restrict the accessibility of an
// accessor. For example, you might want to let anyone obtain the value of a property, but
// allow only members of its class to set the property. To do this, declare the set accessor as
// private. For example, here is a property called MyProp that has its set accessor specified
// as private.

// Use an access modifier with an accessor. 

// using System;  

// class PropAccess
// {
//    int prop; // field being managed by MyProp  

//    public PropAccess() { prop = 0; }

//    /* This is the property that supports access to  
//       the private instance variable prop.  It allows 
//       any code to obtain the value of prop, but only 
//       other class members can set the value of prop. */
//    public int MyProp
//    {
//        get
//        {
//            return prop;
//        }
//        private set
//        { // now, private  
//            prop = value;
//        }
//    }

//    // This class member increments the value of MyProp. 
//    public void IncrProp()
//    {
//        MyProp++; // OK, in same class. 
//    }
// }

// // Demonstrate accessor access modifier. 
// class PropAccessDemo
// {
//    static void Main()
//    {
//        PropAccess ob = new PropAccess();

//        Console.WriteLine("Original value of ob.MyProp: " + ob.MyProp);

//        //    ob.MyProp = 100; // can't access set 

//        ob.IncrProp();
//        Console.WriteLine("Value of ob.MyProp after increment: "
//                          + ob.MyProp);
//    }
// }

// In the PropAccess class, the set accessor is specified private. This means that it can be
// accessed by other class members, such as IncrProp( ), but it cannot be accessed by code
// outside of PropAccess. This is why the attempt to assign ob.MyProp a value inside
// PropAccessDemo is commented out.

#endregion