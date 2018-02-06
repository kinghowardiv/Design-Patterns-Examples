
namespace AbstractFactoryExample
{
    public class EmployeeCreator
    {
        private FullTimeEmployeeCreator fullTimeEmployeeCreator = new FullTimeEmployeeCreator();
        private PartTimeEmployeeCreator partTimeEmployeeCreator = new PartTimeEmployeeCreator();

        public IEmployee CreateNewEmployee(string employeeType, string name, string title)
        {
            switch (employeeType)
            {
                case "Full Time":
                    return fullTimeEmployeeCreator.CreateEmployee(name, title);
                case "Part Time":
                    return partTimeEmployeeCreator.CreateEmployee(name, title);
            }
            return null;
        }
    }
}
