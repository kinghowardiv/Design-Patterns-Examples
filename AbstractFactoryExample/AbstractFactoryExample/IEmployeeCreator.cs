

namespace AbstractFactoryExample
{
    public interface IEmployeeCreator
    {
        IEmployee CreateEmployee(string name, string title);
    }
}
