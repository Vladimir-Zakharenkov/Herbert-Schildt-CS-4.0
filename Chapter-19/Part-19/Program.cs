// В приведенном ниже примере демонстрируется применение метода запроса
// GroupBy(). Это измененный вариант представленного ранее примера.

//Продемонстрировать применение метода запроса GroupBy().
//Это переработанный вариант примера, представленного ранее
//для демонстрации синтаксиса запросов.
using System;
using System.Linq;

class GroupByDemo
{
    static void Main()
    {
        string[] websites = {
            "hsNameA.com", "hsNameB.net", "hsNameC.net",
            "hsNameD.com", "hsNameE.org", "hsNameF.org",
            "hsNameG.tv",  "hsNameH.net", "hsNameI.tv" };

        //Использовать методы запроса для группирования
        //веб-сайтов по имени домена самого верхнего уровня.
        var webAddrs = websites.Where(w => w.LastIndexOf('.') != -1).
            GroupBy(x => x.Substring(x.LastIndexOf(".")));

        //Выполнить запрос и вывести его результаты.
        foreach (var sites in webAddrs)
        {
            Console.WriteLine("Веб-сайты, сгруппированные по имени домена " + sites.Key);

            foreach (var site in sites)
            {
                Console.WriteLine(" " + site);
            }

            Console.WriteLine();
        }

        //Задержка программы.
        Console.ReadKey();
    }
}

// Эта версия программы дает такой же результат, как и предыдущая. Единственное
// отличие между ними заключается в том, как формируется запрос. В данной версии
// для этой цели используются методы запроса.

//Рассмотрим другой пример. Но сначала приведем еще раз запрос из представленного
//ранее примера применения оператора join.

// var inStockList = from item in items
// join entry in statusList
// on item.ItemNumber equals entry.ItemNumber
// select new Temp(item.Name, entry.InStock);

// По этому запросу формируется последовательность, состоящая из объектов, инкапсулирующих
// наименование товара и состояние его запасов на складе. Вся эта информация
// получается путем объединения двух источников данных: items и statusList.
// Ниже приведен переделанный вариант данного запроса, в котором вместо синтаксиса,
// предусмотренного в C# для запросов, используется метод запроса Join().

// Использовать метод запроса Join() для составления списка
// наименований товаров и состояния их запасов на складе.

// var inStockList = items.Join(statusList,
// k1 => k1.ItemNumber,
// k2 => k2.ItemNumber,
// (k1, k2) => new Temp(k1.Name, k2.InStock) );

// В данном варианте именованный класс Temp используется для хранения результирующего
// объекта, но вместо него можно воспользоваться анонимным типом. Такой
// вариант запроса приведен ниже.

// var inStockList = items.Join(statusList,
// k1 => k1.ItemNumber,
// k2 => k2.ItemNumber,
// (k1, k2) => new { k1.Name, k2.InStock } );