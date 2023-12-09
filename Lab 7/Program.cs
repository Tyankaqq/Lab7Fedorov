//Средний уровень 3 вариант

Console.Write("Введите количество сотрудников: ");
int employeeCount = int.Parse(Console.ReadLine());


Employee[] employees = new Employee[employeeCount];


for (int i = 0; i < employeeCount; i++)
{
    Console.WriteLine($"Введите информацию о сотруднике {i + 1}:");

    Console.Write("Фамилия: ");
    employees[i].LastName = Console.ReadLine();

    Console.Write("Имя: ");
    employees[i].FirstName = Console.ReadLine();

    Console.Write("Отчество: ");
    employees[i].Patronymic = Console.ReadLine();

    Console.Write("Должность: ");
    employees[i].Position = Console.ReadLine();

    Console.Write("Зарплата: ");
    employees[i].Salary = decimal.Parse(Console.ReadLine());

    Console.Write("Дата рождения (гггг-мм-дд): ");
    employees[i].BirthDate = DateTime.Parse(Console.ReadLine());
}


decimal averageSalary = employees.Average((Employee e) => e.Salary);


Employee[] selectedEmployees = employees.Where((Employee e) => e.Salary > averageSalary && CalculateAge(e.BirthDate) < 30).ToArray();


foreach (Employee employee in selectedEmployees)
{
    Console.WriteLine($"{employee.LastName} {employee.FirstName} {employee.Patronymic}, {employee.Position}, Зарплата: {employee.Salary}, Дата рождения: {employee.BirthDate.ToShortDateString()}");
}

int CalculateAge(DateTime birthDate)
{
    DateTime currentDate = DateTime.Now;
    int age = currentDate.Year - birthDate.Year;

    if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
    {
        age--;
    }

    return age;
}

struct Employee
{
    public string LastName;
    public string FirstName;
    public string Patronymic;
    public string Position;
    public decimal Salary;
    public DateTime BirthDate;
}
