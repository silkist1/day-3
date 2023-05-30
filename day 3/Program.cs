using day_3;

Employee employee = new Employee();
List<Employee> employees = new List<Employee>()
{
    new(fio:"Исаков Евгений Иванович",salary:50000,3),
    new(fio:"Ефисов Анатолий Андреевич",salary:56000,1),
    new(fio:"Темофеев Сергей Семёнович",salary:96020,4),
    new(fio:"Кардонов Иван Фёдорович",salary:548961,2),
    new(fio:"Фаменко Илья Сергеевич",salary:165893,5),
    new(fio:"Кавалёв Андрей Андреевич",salary:80620,5),
    new(fio:"Гуйдаров Юлий Анатолевич",salary:56984,2),
    new(fio:"Седаренко Ева Велерьевна",salary:66520,3),
    new(fio:"Чебручан Анна Сергеевна",salary:242000,1),
    new(fio:"Исаков Андрей Иванович",salary:67800,3),
    new(fio:"Исакова Анастасия Ильинишна",salary:58000,5),
};

void List()
{
    foreach (var emp in employees)
    {    
        Console.WriteLine(employee.Id() + ". "+ " ФИО:" +emp.Fio + " Зарплата:" + emp.Salary + " Департамент:" + emp.Department+" ");
    }
}

double TotalSalary()
{
    double total = 0;

    foreach (var emp in employees)
    {
       total += emp.Salary;
    }

    Console.WriteLine("Сумма затрат на зарплаты: "+total+"руб.");

    return total;
}

double MaxSalary()
{
    double maxSalary=0;

    foreach (var emp in employees)
    {
        if (emp.Salary >maxSalary )
        {
            maxSalary = emp.Salary;
        }
    }
    
    Console.WriteLine("Сотрудник с максимальной зарплатой: "+ maxSalary);

    return maxSalary;
}

void MinSalary()
{
    double minSalary= 1.7976931348623157E+308;

    foreach (var emp in employees)
    {
        if (emp.Salary < minSalary)
        {
            minSalary = emp.Salary;
        }
    }

    Console.WriteLine("Сотрудник с минимальной зарплатой: " + minSalary);
}

void AvargeSalary()
{
    Console.WriteLine("Средняя зарплата сотрудников: " + TotalSalary()/employees.Count);
}

void Fio()
{
    foreach (var emp in employees)
    {
        Console.WriteLine(emp.Fio);
    }
}

List();
TotalSalary();
MaxSalary();
MinSalary();
AvargeSalary();
Fio();

