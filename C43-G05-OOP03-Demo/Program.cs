using System.Security.Cryptography;
using C43_G05_OOP03.Interface_Ex01;
using C43_G05_OOP03.Interface_Ex02;

namespace C43_G05_OOP03
{

    internal class Program
    {
    static void Print10Number(ISeries series)
    {
        for (int i = 0; i < 10; i++) {

            Console.Write($"{series.Current} ");
            series.Next();
        }
        Console.WriteLine();
        series.Rest();

    }
        static void Main(string[] args)
        {

            // Let's imagine you're building a system for different types of shapes.
            // You want to be able to calculate the area of each shape.
            // An interface is a great way to define this requirement:


            // Note : Can't create Any Object From Any Interface
            // IMyType mytype = new IMyType();

            // Note : Can Create Reference From Interface and this reference can refer to object 
            // from class which implenent the interface

            //IMyType myType = new IMyType();  Invalid

            //MyType myType = new MyType();
            //IMyType imyType = new MyType();

            //imyType.Print();
            //myType.Print();  Invalid
            //myType.Print();
            //IMyType imyType = new IMyType();

            SeriesByTwo seriesTwo = new SeriesByTwo();
            SeriesByThree seriesThree = new SeriesByThree();

            //Print10Number(seriesTwo);
            Print10Number(seriesThree);

            //stoded 51:22

        }
    }
}
