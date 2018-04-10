using System;

namespace FactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = SetupAutomobiles();
            var automobileFactory = new AutomobileFactory(vehicles);

            var automobileForUser = automobileFactory.GetAutomobile(bool.Parse(args[0]), bool.Parse(args[1]));

            Console.WriteLine(string.Format("The Automobile best suited for you is a {0}", automobileForUser.GetType().ToString()));
            Console.ReadLine();
        }

        private static IAutomobile[] SetupAutomobiles()
        {
            var automobileList = new IAutomobile[]
            {
                new SubaruOutback(),
                new SUV(),
                new Truck()
            };

            return automobileList;
        }
    }
}