using System;
using MyLib;
using MyNewCollection;

namespace Lab13_PSTU_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNewCollection<Manufacture> firstCollection = new MyNewCollection<Manufacture>();
            MyNewCollection<Manufacture> secondCollection = new MyNewCollection<Manufacture>();
            firstCollection.Name = "Коллекция №1";
            secondCollection.Name = "Коллекция №2";

            Journal<Manufacture> firstJournal = new Journal<Manufacture>();
            Journal<Manufacture> secondJournal = new Journal<Manufacture>();

            firstCollection.CollectionCountChanged += firstJournal.CollectionCountChanged;
            firstCollection.CollectionReferenceChanged += secondJournal.CollectionReferenceChanged;

            secondCollection.CollectionCountChanged += secondJournal.CollectionCountChanged;
            secondCollection.CollectionReferenceChanged += secondJournal.CollectionReferenceChanged;
            
            firstCollection.Add(new Manufacture("r"));
            firstCollection.Add(new Workshop("r"));
            firstCollection.Add(new Shop("r"));
            firstCollection.Add(new Factory("r"));
            firstCollection.RemoveAt(0);
            firstCollection.RemoveAt(1);
            
            secondCollection.Add(new Manufacture("r"));
            secondCollection.Add(new Manufacture("r"));
            secondCollection.Add(new Manufacture("r"));
            secondCollection.Add(new Manufacture("r"));
            secondCollection[0] = new Manufacture();
            secondCollection[3] = new Manufacture();


            Console.WriteLine("Записи первого журнала:");
            foreach (var element in firstJournal.journalOfChange)
            {
                Console.Write(element);
                Console.WriteLine("_______________________________________");
            }
            
            Console.WriteLine("Нажмите enter.");
            Console.Read();
            
            Console.WriteLine("Записи второго журнала:");
            foreach (var element in secondJournal.journalOfChange)
            {
                Console.Write(element);
                Console.WriteLine("_______________________________________");
            }
        }
    }
}
