

namespace AbstractFactoryExample
{
    public class Client
    {
        private EmployeeCreator employeeCreator = new EmployeeCreator();
        
        public void CreateNewEmployee()
        {
            var employee = employeeCreator.CreateNewEmployee("Full Time", "Bob", "Sales Rep");
        }
    }
}
