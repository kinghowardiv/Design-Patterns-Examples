
namespace AbstractFactoryExample
{
    public class FullTimeEmployeeCreator : IEmployeeCreator
    {
        public IEmployee CreateEmployee(string name, string title)
        {
            var employee = new FullTimeEmployee();
            return employee;
        }
    }
}
