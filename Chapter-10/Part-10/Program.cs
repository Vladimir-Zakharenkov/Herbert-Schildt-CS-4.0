#region Russian

// Вероятно, ограничение доступа к аксессорам оказывается наиболее важным для
// работы с автоматически реализуемыми свойствами. Как пояснялось выше, создать
// автоматически реализуемое свойство только для чтения или же только для записи
// нельзя, поскольку оба аксессора, get и set, должны быть указаны при объявлении
// такого свойства. Тем не менее добиться желаемого результата все же можно, объявив
// один из аксессоров автоматически реализуемого свойства как private. В качестве
// примера ниже приведено объявление автоматически реализуемого свойства Length
// для класса FailSoftArray, которое фактически становится доступным только для чтения.

// public int Length { get; private set; }

// Свойство Length может быть установлено только из кода в его классе, поскольку
// его аксессор set объявлен как private. А изменять свойство Length за пределами
// его класса не разрешается. Это означает, что за пределами своего класса свойство, по
// существу, оказывается доступным только для чтения. Аналогичным образом можно
// объявить и свойство Error, как показано ниже.

// public bool Error { get; private set; }

// Благодаря этому свойство Error становится доступным для чтения, но не для установки
// за пределами класса FailSoftArray.

// Для опробования автоматически реализуемых вариантов свойств Length и Error
// в классе FailSoftArray удалим сначала переменные len и ErrFlag, поскольку они
// больше не нужны, а затем заменим каждое применение переменных len и ErrFlag
// свойствами Length и Error в классе FailSoftArray. Ниже приведен обновленный
// вариант класса FailSoftArray вместе с методом Main(), демонстрирующим его
// применение.

//Применить автоматически реализуемые и доступные только для чтения свойства Length и Error.
using System;

class FailSoftArray
{
    int[] a; //ссылка на базовый массив  

    //Построить массив по заданному размеру.  
    public FailSoftArray(int size)
    {
        a = new int[size];
        Length = size;
    }

    //Автоматически реализуемое и доступное только для чтения свойство Length. 
    public int Length { get; private set; }

    //Автоматически реализуемое и доступное только для чтения свойство Error. 
    public bool Error { get; private set; }

    //Это индексатор для массива FailSoftArray. 
    public int this[int index]
    {
        //Это аксессор get. 
        get
        {
            if (ok(index))
            {
                Error = false;
                return a[index];
            }
            else
            {
                Error = true;
                return 0;
            }
        }

        //Это аксессор set. 
        set
        {
            if (ok(index))
            {
                a[index] = value;
                Error = false;
            }
            else
            {
                Error = true;
            }
        }
    }

    //Возвратить логическое значение true, если индекс находится в установленных границах. 
    private bool ok(int index)
    {
        if (index >= 0 & index < Length)
        {
            return true;
        }

        return false;
    }
}

//Продемонстрировать применение усовершенствованного отказоустойчивого массива. 
class FinalFSDemo
{
    static void Main()
    {
        FailSoftArray fs = new FailSoftArray(5);

        //Использовать свойство Error. 
        for (int i = 0; i < fs.Length + 1; i++)
        {
            fs[i] = i * 10;
            if (fs.Error)
            {
                Console.WriteLine("Ошибка в индексе " + i);
            }
        }

        //Задержка программы.
        Console.ReadKey();
    }
}

// Этот вариант класса FailSoftArray действует таким же образом, как и предыдущий,
// но в нем отсутствуют поддерживающие поля, объявляемые явно.

// На применение модификаторов доступа в аксессорах накладываются следующие
// ограничения. Во-первых, действию модификатора доступа подлежит только один аксессор:
// set или get, но не оба сразу. Во-вторых, модификатор должен обеспечивать
// более ограниченный доступ к аксессору, чем доступ на уровне свойства или индексатора.
// И наконец, модификатор доступа нельзя использовать при объявлении аксессора
// в интерфейсе или же при реализации аксессора, указываемого в интерфейсе. (Подробнее
// об интерфейсах речь пойдет в главе 12.)

#endregion

#region English

// Perhaps the most important use of restricting an accessor’s access is found when working
// with auto-implemented properties. As explained, it is not possible to create a read-only or
// write-only auto-implemented property because both the get and set accessors must be
// specified when the auto-implemented property is declared. However, you can gain much
// the same effect by declaring either get or set as private. For example, this declares what is
// effectively a read-only, auto-implemented Length property for the FailSoftArray class
// shown earlier.

// public int Length { get; private set; }

// Because set is private, Length can be set only by code within its class. Outside its class, an
// attempt to change Length is illegal. Thus, outside its class, Length is effectively read - only.
// The same technique can also be applied to the Error property, like this:

// public bool Error { get; private set; }

// This allows Error to be read, but not set, by code outside FailSoftArray.
// To try the auto-implemented version of Length and Error with FailSoftArray, first
// remove the len and ErrFlag variables. They are no longer needed. Then, replace each use of
// len inside FailSoftArray with Length and each use of ErrFlag with Error. Here is the updated
// version of FailSoftArray along with a Main( ) method to demonstrate it:

// Use read-only, auto-implemented properties for Length and Error.  

// using System; 

// class FailSoftArray
// {
//    int[] a; // reference to underlying array  

//    // Construct array given its size.  
//    public FailSoftArray(int size)
//    {
//        a = new int[size];
//        Length = size;
//    }

//    // An auto-implemented, read-only Length property. 
//    public int Length { get; private set; }

//    // An auto-implemented, read-only Error property. 
//    public bool Error { get; private set; }

//    // This is the indexer for FailSoftArray. 
//    public int this[int index]
//    {
//        // This is the get accessor. 
//        get
//        {
//            if (ok(index))
//            {
//                Error = false;
//                return a[index];
//            }
//            else
//            {
//                Error = true;
//                return 0;
//            }
//        }

//        // This is the set accessor. 
//        set
//        {
//            if (ok(index))
//            {
//                a[index] = value;
//                Error = false;
//            }
//            else Error = true;
//        }
//    }

//    // Return true if index is within bounds. 
//    private bool ok(int index)
//    {
//        if (index >= 0 & index < Length) return true;
//        return false;
//    }
// }

// // Demonstrate the improved fail-soft array. 
// class FinalFSDemo
// {
//    static void Main()
//    {
//        FailSoftArray fs = new FailSoftArray(5);

//        // Use Error property. 
//        for (int i = 0; i < fs.Length + 1; i++)
//        {
//            fs[i] = i * 10;
//            if (fs.Error)
//                Console.WriteLine("Error with index " + i);
//        }
//    }
// }

// This version of FailSoftArray works the same as the previous version, but it does not
// contain the explicitly declared backing fields.

// Here are some restrictions that apply to using access modifiers with accessors.First,
// only the set or get accessor can be modified, not both. Furthermore, the access modifier must
// be more restrictive than the access level of the property or indexer. Finally, an access
// modifier cannot be used when declaring an accessor within an interface or when implementing
// an accessor specified by an interface. (Interfaces are described in Chapter 12.)

#endregion