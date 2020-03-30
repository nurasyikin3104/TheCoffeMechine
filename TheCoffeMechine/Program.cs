using System;

namespace TheCoffeMechine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CoffePowder coffe = new CoffePowder(100);
            WaterGalon water = new WaterGalon(1000);
            CoffeMechine yummycoffe = new CoffeMechine(coffe, water);

            //1st cup coffe
            Console.WriteLine("Checck " + yummycoffe.checkAvailability());
            String result = yummycoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            //2nd cup coffe
            Console.WriteLine("Checck " + yummycoffe.checkAvailability());
            result = yummycoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            //3nd cup coffe
            Console.WriteLine("Checck " + yummycoffe.checkAvailability());
            result = yummycoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            //4nd cup coffe
            Console.WriteLine("Checck " + yummycoffe.checkAvailability());
            result = yummycoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            //5nd cup coffe
            Console.WriteLine("Checck " + yummycoffe.checkAvailability());
            result = yummycoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            //6nd cup coffe
            Console.WriteLine("Checck " + yummycoffe.checkAvailability());
            result = yummycoffe.makeEsspresso();
            Console.WriteLine("result " + result);

            Console.WriteLine("Check " + yummycoffe.checkAvailability());
        }
    }
}
