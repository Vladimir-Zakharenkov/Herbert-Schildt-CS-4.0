#region Russian
/*
В предыдущем примере показано, как накладывается ограничение на базовый
класс, но из него не совсем ясно, зачем это вообще нужно. Для того чтобы особое значение
ограничения на базовый класс стало понятнее, рассмотрим еще один, более
практический пример. Допустим, что требуется реализовать механизм управления
списками телефонных номеров, чтобы пользоваться разными категориями таких списков,
в частности отдельными списками для друзей, поставщиков, клиентов и т.д. Для
этой цели можно сначала создать класс PhoneNumber, в котором будут храниться имя
абонента и номер его телефона. Такой класс может иметь следующий вид.

//Базовый класс, в котором хранятся имя абонента и номер его телефона.
class PhoneNumber {
    public PhoneNumber(string n, string num) {
        Name = n;
        Number = num;
    }

    // Автоматически реализуемые свойства, в которых хранятся имя абонента и номер его телефона.
    public string Number { get; set; }
    public string Name { get; set; }
}

Далее создадим классы, наследующие класс PhoneNumber: Friend и Supplier.

Эти классы приведены ниже.

//Класс для телефонных номеров друзей.
class Friend : PhoneNumber {
    public Friend(string n, string num, bool wk) : base(n, num)
    {
        IsWorkNumber = wk;
    }

    public bool IsWorkNumber { get; private set; }
    // ...
}

//Класс для телефонных номеров поставщиков.
class Supplier : PhoneNumber {
    public Supplier(string n, string num) : base(n, num)
    { }

    // ...
}

Обратите внимание на то, что в класс Friend введено свойство IsWorkNumber, возвращающее
логическое значение true, если номер телефона является рабочим.

Для управления списками телефонных номеров создадим еще один класс под названием
PhoneList. Его следует сделать обобщенным, поскольку он должен служить
для управления любым списком телефонных номеров. В функции такого управления
должен, в частности, входить поиск телефонных номеров по заданным именам и наоборот,
поэтому на данный класс необходимо наложить ограничение по типу, требующее,
чтобы объекты, сохраняемые в списке, были экземплярами класса, производного
от класса PhoneNumber.

// Класс PhoneList способен управлять любым видом списка телефонных
// номеров, при условии, что он является производным от класса PhoneNumber.
class PhoneList<T> where T : PhoneNumber {
    T[] phList;
    int end;

    public PhoneList() {
        phList = new T[10];
        end = 0;
    }

    // Добавить элемент в список.
    public bool Add(T newEntry) {
        if(end == 10) return false;
        phList[end] = newEntry;
        end++;
        return true;
    }

    // Найти и возвратить сведения о телефоне по заданному имени.
    public Т FindByName(string name) {
        for(int i=0; i<end; i++) {
            // Имя может использоваться, потому что его свойство Name
            // относится к членам класса PhoneNumber, который является
            // базовым по накладываемому ограничению.
            if(phList[i].Name == name)
            return phList [i];
        }   
        // Имя отсутствует в списке.
        throw new NotFoundException();
    }

    // Найти и возвратить сведения о телефоне по заданному номеру.
    public Т FindByNumber(string number) {
        for(int i=0; i<end; i++) {
        // Номер телефона также может использоваться, поскольку
        // его свойство Number относится к членам класса PhoneNumber,
        // который является базовым по накладываемому ограничению.
        if(phList[i].Number == number)
            return phList[i];
        }
        // Номер телефона отсутствует в списке.
        throw new NotFoundException();
    }
    // ...
}

Ограничение на базовый класс разрешает коду в классе PhoneList доступ к свойствам
Name и Number для управления любым видом списка телефонных номеров. Оно
гарантирует также, что для построения объекта класса PhoneList будут использоваться
только доступные типы. Обратите внимание на то, что в классе PhoneList генерируется
исключение NotFoundException, если имя или номер телефона не найдены.
Это специальное исключение, объявляемое ниже.

class NotFoundException : Exception {
    // Реализовать все конструкторы класса Exception.
    // Эти конструкторы выполняют вызов конструктора базового класса.
    // Класс NotFoundException ничем не дополняет класс Exception и
    // поэтому не требует никаких дополнительных действий.

    public NotFoundException() : base() { }
    public NotFoundException(string str) : base(str) { }
    public NotFoundException(string str, Exception inner) : base(str, inner) { }
    protected NotFoundException(
        System.Runtime.Serialization.Serializationlnfo si,
        System.Runtime.Serialization.StreamingContext sc) : base(si, sc) { }
}

В данном примере используется только конструктор, вызываемый по умолчанию,
но ради наглядности этого примера в классе исключения NotFoundException реализуются
все конструкторы, определенные в классе Exception. Обратите внимание на
то, что эти конструкторы вызывают эквивалентный конструктор базового класса, определенный
в классе Exception. А поскольку класс исключения NotFoundException
ничем не дополняет базовый класс Exception, то для любых дополнительных действий
нет никаких оснований.

В приведенной ниже программе все рассмотренные выше фрагменты кода объединяются
вместе, а затем демонстрируется применение класса PhoneList. Кроме
того, в ней создается класс EmailFriend. Этот класс не наследует от класса
PhoneNumber, а следовательно, он не может использоваться для создания объектов
класса PhoneList.
*/
//Более практический пример, демонстрирующий применение ограничения на базовый класс.
using System;

//Специальное исключение, генерируемое в том случае, 
//если имя или номер телефона не найдены.
class NotFoundException : Exception
{
    public NotFoundException() : base() { }
    public NotFoundException(string str) : base(str) { }
    public NotFoundException(string str, Exception inner) : base(str, inner) { }
    protected NotFoundException(System.Runtime.Serialization.SerializationInfo si,
        System.Runtime.Serialization.StreamingContext sc) : base(si, sc) { }
}

//Базоовый класс, в котором хранится имя абонента и номер его телефона.
class PhoneNumber
{
    public string Number { get; set; }
    public string Name { get; set; }

    public PhoneNumber(string n, string num)
    {
        Name = n;
        Number = num;
    }
}

//Класс для телефонных номеров друзей.
class Friend : PhoneNumber
{
    public bool IsWorkNumber { get; private set; }

    public Friend(string n, string num, bool wk) : base(n, num)
    {
        IsWorkNumber = wk;
    }
}

//Класс для телефонных номеров поставщиков.
class Supplier : PhoneNumber
{
    public Supplier(string n, string num) : base(n, num) { }
}

//Этот класс не наследует от класса PhoneNumber/
class EmailFriend
{

}

//Класс PhoneList способен управлять любым видом списка телефонных номеров
//при условии, что он является производным от класса PhoneNumber/
class PhoneList<T> where T : PhoneNumber
{
    T[] phList;
    int end;

    public PhoneList()
    {
        phList = new T[10];
        end = 0;
    }

    //Добавить элемент в список.
    public bool Add(T newEntry)
    {
        if (end == 10)
        {
            return false;
        }

        phList[end] = newEntry;
        end++;
        return true;
    }

    //Найти и возвратить сведения по заданному имени.
    public T FindByName(string name)
    {
        for (int i = 0; i < end; i++)
        {
            //Имя может использоваться, потому что его свойство Name
            //относится к членам класса PhoneNumber, который является
            //базовым по накладываемому ограничению.
            if (phList[i].Name == name)
            {
                return phList[i];
            }
        }

        //Имя отсутствует в списке.
        throw new NotFoundException();
    }

    //Найти и возвратить сведения о телефоне по заданному номеру.
    public T FindByNumber(string number)
    {
        for (int i = 0; i < end; i++)
        {
            //Номер телефона может использоваться, поскольку
            //его свойство Number относится к членам класса PhoneNumbber,
            //который является базовым по накладываемому ограничению.
            if (phList[i].Number == number)
            {
                return phList[i];
            }
        }

        //Номер телефона отсутствует в списке.
        throw new NotFoundException();
    }
}

//Продемонстрировать наложение ограничений на базовый класс.
class UseBaseClassConstraint
{
    static void Main()
    {
        //Следующий код вполне допустим, поскольку класс Friend наследует от класса PhoneNumber.
        PhoneList<Friend> plist = new PhoneList<Friend>();

        plist.Add(new Friend("Том", "555-1234", true));
        plist.Add(new Friend("Гари", "555-6756", true));
        plist.Add(new Friend("Матт", "555-9254", false));

        try
        {
            //Найти номер телефона по заданному имени друга.
            Friend frnd = plist.FindByName("Гари");

            Console.Write(frnd.Name + ": " + frnd.Number);

            if (frnd.IsWorkNumber)
            {
                Console.WriteLine(" (рабочий)");
            }
            else
            {
                Console.WriteLine();
            }
        }
        catch (NotFoundException)
        {
            Console.WriteLine("Не найдено");
        }

        Console.WriteLine();

        //Следующий код тоже допустим, поскольку класс Supplier наследует от класса PhoneNumber.
        PhoneList<Supplier> plist2 = new PhoneList<Supplier>();
        plist2.Add(new Supplier("Фирма Global Hardware", "555-8834"));
        plist2.Add(new Supplier("Агенство Computer Warehouse", "555-9256"));
        plist2.Add(new Supplier("Компания NetworkCity", "555-2564"));

        try
        {
            //Найти наименование поставщика по заданному номеру телефона.
            Supplier sp = plist2.FindByNumber("555-2564");
            Console.WriteLine(sp.Name + ": " + sp.Number);
        }
        catch (NotFoundException)
        {
            Console.WriteLine("Не найдено");
        }

        //Следующее объявление недопустимо, поскольку класс EmailFriend не наследует от класса PhoneNumber.
        //PhoneList<EmailFriend> plist3 = new PhoneList<EmailFriend>(); //Ошибка!

        //Задержка программы.
        Console.ReadKey();
    }
}

/*
 Ниже приведен результат выполнения этой программы.

Гари: 555-6756 (рабочий)

Компания NetworkCity: 555-2564

Поэкспериментируйте с этой программой. В частности, попробуйте составить разные
виды списков телефонных номеров или воспользоваться свойством IsWorkNumber
в классе PhoneList. Вы сразу же обнаружите, что компилятор не позволит вам этого
сделать, потому что свойство IsWorkNumber определено в классе Friend, а не в классе
PhoneNumber, а следовательно, оно неизвестно в классе PhoneList.
 */

#endregion

#region English
/*
 Although the preceding example shows the “how” of base class constraints, it does not
show the “why.” To better understand the value of base type constraints, let’s work through
another, more practical example. Assume you want to create a mechanism that manages
lists of telephone numbers. Furthermore, assume you want to use different lists for different
groupings of numbers. Specifically, you want one list for friends, another for suppliers, and
so on. To accomplish this, you might start by creating a base class called PhoneNumber that
stores a name and a phone number linked to that name. Such a class might look like this:

// A base class that stores a name and phone number.
class PhoneNumber {
    public PhoneNumber(string n, string num) {
    Name = n;
    Number = num;
    }

    // Auto-implemented properties that hold a name and phone number.
    public string Number { get; set; }
    public string Name { get; set; }
}

Next, you create two classes that inherit PhoneNumber: Friend and Supplier. They are
shown here:
// A class of phone numbers for friends.
class Friend : PhoneNumber {
    public Friend(string n, string num, bool wk) :
    base(n, num)
    {
    IsWorkNumber = wk;
    }

    public bool IsWorkNumber { get; private set; }
    // ...
}

// A class of phone numbers for suppliers.
class Supplier : PhoneNumber {
    public Supplier(string n, string num) : base(n, num) { }
    // ...
}

Notice that Friend adds a property called IsWorkNumber, which returns true if the
telephone number is a work number.

To manage telephone lists, you create a class called PhoneList. Because you want this
class to manage any type of phone list, you make it generic. Furthermore, because part
of the list management is looking up numbers given names, and vice versa, you add the
constraint that requires that the type of objects stored in the list must be instances of a class
derived from PhoneNumber.

// PhoneList can manage any type of phone list
// as long as it is derived from PhoneNumber.
class PhoneList<T> where T : PhoneNumber {
    T[] phList;
    int end;
    public PhoneList() {
    phList = new T[10];
    end = 0;
    }

    // Add an entry to the list.
    public bool Add(T newEntry) {
        if(end == 10) return false;
        phList[end] = newEntry;
        end++;
        return true;
    }

    // Given a name, find and return the phone info.
    public T FindByName(string name) {
        for(int i=0; i<end; i++) {
        // Name can be used because it is a member of
        // PhoneNumber, which is the base class constraint.
        if(phList[i].Name == name)
            return phList[i];
        }

    // Name not in list.
    throw new NotFoundException();
    }

    // Given a number, find and return the phone info.
    public T FindByNumber(string number) {
        for(int i=0; i<end; i++) {
        // Number can be used because it is also a member of
        // PhoneNumber, which is the base class constraint.
        if(phList[i].Number == number)
            return phList[i];
        }

    // Number not in list.
    throw new NotFoundException();
    }
    // ...
}

The base class constraint enables code inside PhoneList to access the properties Name and
Number for any type of telephone list. It also guarantees that only valid types are used to
construct a PhoneList object. Notice that PhoneList throws a NotFoundException if a name
or number is not found. This is a custom exception that is declared as shown here:

class NotFoundException : Exception {
    //Implement all of the Exception constructors. Notice that
    //the constructors simply execute the base class constructor.
    //Because NotFoundException adds nothing to Exception,
    //there is no need for any further actions.

    public NotFoundException() : base() { }
    public NotFoundException(string message) : base(message) { }
    public NotFoundException(string message, Exception innerException) :
    base(message, innerException) { }
    protected NotFoundException(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context) :
    base(info, context) { }
    }

Although only the default constructor is used by this example, NotFoundException
implements all of the constructors defined by Exception for the sake of illustration.
Notice that these constructors simply invoke the equivalent base class constructor
defined by Exception. Because NotFoundException adds nothing to Exception, there
is no reason for any further action.

The following program puts together all the pieces and demonstrates PhoneList. Notice
that a class called EmailFriend is also created. This class does not inherit PhoneNumber.
Thus, it cannot be used to create a PhoneList.
 */

// A more practical demonstration of a base class constraint. 

// using System; 

//// A custom exception that is thrown if a name or number is not found. 
// class NotFoundException : Exception
// {
//    /* Implement all of the Exception constructors. Notice that 
//       the constructors simply execute the base class constructor. 
//       Because NotFoundException adds nothing to Exception, 
//       there is no need for any further actions. */
//    public NotFoundException() : base() { }
//    public NotFoundException(string message) : base(message) { }
//    public NotFoundException(string message, Exception innerException) :
//      base(message, innerException)
//    { }
//    protected NotFoundException(
//      System.Runtime.Serialization.SerializationInfo info,
//      System.Runtime.Serialization.StreamingContext context) :
//        base(info, context)
//    { }
// }
//// A base class that stores a name and phone number. 
// class PhoneNumber
// {

//    public PhoneNumber(string n, string num)
//    {
//        Name = n;
//        Number = num;
//    }

//    public string Number { get; set; }
//    public string Name { get; set; }

// }

//// A class of phone numbers for friends. 
// class Friend : PhoneNumber
// {

//    public Friend(string n, string num, bool wk) :
//      base(n, num)
//    {
//        IsWorkNumber = wk;
//    }

//    public bool IsWorkNumber { get; private set; }

//    // ... 
// }

//// A class of phone numbers for suppliers. 
// class Supplier : PhoneNumber
// {
//    public Supplier(string n, string num) :
//      base(n, num)
//    { }

//    // ... 
// }

//// Notice that this class does not inherit PhoneNumber, 
// class EmailFriend
// {
//    // ... 
// }

//// PhoneList can manage any type of phone list 
//// as long as it is derived from PhoneNumber. 
// class PhoneList<T> where T : PhoneNumber
// {
//    T[] phList;
//    int end;

//    public PhoneList()
//    {
//        phList = new T[10];
//        end = 0;
//    }

//    // Add an entry to the list. 
//    public bool Add(T newEntry)
//    {
//        if (end == 10) return false;

//        phList[end] = newEntry;
//        end++;

//        return true;
//    }

//    // Given a name, find and return the phone info. 
//    public T FindByName(string name)
//    {

//        for (int i = 0; i < end; i++)
//        {
//            // Name can be used because it is a member of 
//            // PhoneNumber, which is the base class constraint. 
//            if (phList[i].Name == name)
//                return phList[i];
//        }

//        // Name not in list. 
//        throw new NotFoundException();
//    }

//    // Given a number, find and return the phone info. 
//    public T FindByNumber(string number)
//    {

//        for (int i = 0; i < end; i++)
//        {
//            // Number can be used because it is also a member of 
//            // PhoneNumber, which is the base class constraint. 
//            if (phList[i].Number == number)
//                return phList[i];
//        }

//        // Number not in list. 
//        throw new NotFoundException();
//    }

//    // ... 
// }

//// Demonstrate base class constraints. 
// class UseBaseClassConstraint
// {
//    static void Main()
//    {

//        // The following code is OK because Friend 
//        // inherits PhoneNumber. 
//        PhoneList<Friend> plist = new PhoneList<Friend>();
//        plist.Add(new Friend("Tom", "555-1234", true));
//        plist.Add(new Friend("Gary", "555-6756", true));
//        plist.Add(new Friend("Matt", "555-9254", false));

//        try
//        {
//            // Find the number of a friend given a name. 
//            Friend frnd = plist.FindByName("Gary");

//            Console.Write(frnd.Name + ": " + frnd.Number);

//            if (frnd.IsWorkNumber)
//                Console.WriteLine(" (work)");
//            else
//                Console.WriteLine();
//        }
//        catch (NotFoundException)
//        {
//            Console.WriteLine("Not Found");
//        }

//        Console.WriteLine();

//        // The following code is also OK because Supplier 
//        // inherits PhoneNumber. 
//        PhoneList<Supplier> plist2 = new PhoneList<Supplier>();
//        plist2.Add(new Supplier("Global Hardware", "555-8834"));
//        plist2.Add(new Supplier("Computer Warehouse", "555-9256"));
//        plist2.Add(new Supplier("NetworkCity", "555-2564"));

//        try
//        {
//            // Find the name of a supplier given a number. 
//            Supplier sp = plist2.FindByNumber("555-2564");
//            Console.WriteLine(sp.Name + ": " + sp.Number);
//        }
//        catch (NotFoundException)
//        {
//            Console.WriteLine("Not Found");
//        }

//        // The following declaration is invalid because EmailFriend 
//        // does NOT inherit PhoneNumber. 
//        //    PhoneList<EmailFriend> plist3 = 
//        //        new PhoneList<EmailFriend>(); // Error! 
//    }
// }

/*
 The output from the program is shown here:

Gary: 555-6756 (work)

NetworkCity: 555-2564

You might want to try experimenting with this program a bit. For example, try creating
different types of telephone lists. Also, try using IsWorkNumber from within PhoneList. As
you will see, the compiler won’t let you do it. The reason is that IsWorkNumber is a property
defined by Friend, not by PhoneNumber. Thus, PhoneList has no knowledge of it.
 */
#endregion