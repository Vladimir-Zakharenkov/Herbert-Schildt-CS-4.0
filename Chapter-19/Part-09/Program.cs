// Одной из самых эффективных для оператора select является возможность возвращать
// последовательность результатов, содержащую элементы данных, формируемые
// во время выполнения запроса. В качестве примера рассмотрим еще одну программу.
// В ней определяется класс ContactInfo, в котором хранится имя, адрес электронной
// почты и номер телефона адресата. Кроме того, в этой программе определяется класс
// EmailAddress, использовавшийся в предыдущем примере. В методе Main() создается
// массив объектов типа ContactInfo, а затем объявляется запрос, в котором источником
// данных служит этот массив, но возвращаемая последовательность результатов
// содержит объекты типа EmailAddress. Таким образом, типом последовательности
// результатов, возвращаемой оператором select, является класс EmailAddress, а не
// класс ContactInfo, причем его объекты создаются во время выполнения запроса.

//Использовать запрос для получения последовательности объектов
//типа EmailAddresses из списка объектов типа ContactInfo.
using System;
using System.Linq;

class ContactInfo
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public ContactInfo(string n, string a, string p)
    {
        Name = n;
        Email = a;
        Phone = p;
    }
}

class EmailAddress
{
    public string Name { get; set; }
    public string Address { get; set; }

    public EmailAddress(string n, string a)
    {
        Name = n;
        Address = a;
    }
}

class SelectDemo3
{
    static void Main()
    {
        ContactInfo[] contacts =
        {
            new ContactInfo ("Герберт","Herb@HerbertSchildt.com","555-1010"),
            new ContactInfo ("Том","Tom@HerbertSchildt.com","555-1101"),
            new ContactInfo ("Сара","Sara@HerbertSchildt.com","555-0110")
        };

        //Сформировать запрос на получение объектов типа EmailAddress.
        var emailList = from entry in contacts
                        select new EmailAddress(entry.Name, entry.Email);

        Console.WriteLine("Список адресов электронной почты:\n");

        //Выполнить запрос и вывести его результаты.
        foreach (EmailAddress e in emailList)
        {
            Console.WriteLine(" {0}: {1}", e.Name, e.Address);
        }

        // Задержка программы.
        Console.ReadLine();
    }
}

// Ниже приведен результат выполнения этой программы.

// Список адресов электронной почты:
// Герберт: Herb @HerbSchildt.com
// Том: Tom @HerbSchildt.com
// Сара: Sara @HerbSchildt.com

// Обратите особое внимание в данном запросе на следующий оператор select.

// select new EmailAddress(entry.Name, entry.Email);

// В этом операторе создается новый объект типа EmailAddress, содержащий имя
// и адрес электронной почты, получаемые из объекта типа ContactInfo, хранящегося
// в массиве contacts. Но самое главное, что новые объекты типа EmailAddress создаются
// в операторе select во время выполнения запроса.
