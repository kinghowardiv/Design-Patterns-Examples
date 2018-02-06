using System;

namespace AbstractFactoryExample
{
    public class PartTimeEmployeeCreator : IEmployeeCreator
    {
        public IEmployee CreateEmployee(string name, string title)
        {
            return new PartTimeEmployee();
        }
    }
}
