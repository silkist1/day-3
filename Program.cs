using day3;

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
        Console.WriteLine(employee.Id() + ". " + " ФИО:" + emp.Fio + " Зарплата:" + emp.Salary + " Департамент:" + emp.Department + " ");
    }
}

double TotalSalary()
{
    double total = 0;

    foreach (var emp in employees)
    {
        total += emp.Salary;
    }

    Console.WriteLine("Сумма затрат на зарплаты: " + total + "руб.");

    return total;
}

double MaxSalary()
{
    double maxSalary = 0;

    foreach (var emp in employees)
    {
        if (emp.Salary > maxSalary)
        {
            maxSalary = emp.Salary;
        }
    }

    Console.WriteLine("Сотрудник с максимальной зарплатой: " + maxSalary);

    return maxSalary;
}

void MinSalary()
{
    double minSalary = 1.7976931348623157E+308;

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
    Console.WriteLine("Средняя зарплата сотрудников: " + TotalSalary() / employees.Count);
}

void Fio()
{
    foreach (var emp in employees)
    {
        Console.WriteLine(emp.Fio);
    }
}

void Indeks()
{
    
    foreach (var emp in employees)
    {
        emp.Salary += emp.Salary* 0.1;
        Console.WriteLine($"Зарплата повышена {emp.Fio} до {emp.Salary} в отделе {emp.Department}");
    }
    
    
}

   

void MinSalDEp()
{
    Console.WriteLine("Выберите отдел от 1-5");
    int select = Convert.ToInt32(Console.ReadLine());
    double minSalDep = 99999999;
    foreach (var emp in employees)
    {
        if (emp.Department == select)
        {
            if (emp.Salary < minSalDep)
            {
                minSalDep = emp.Salary;
            }
        }
    }
    Console.WriteLine($"Минимальная зарплата в отделе у {employee.Fio} {minSalDep}");
}

void MaxSalDEp()
{
    Console.WriteLine("Выберите отдел от 1-5");
    int select = Convert.ToInt32(Console.ReadLine());
    double maxSalDep = 0;
    foreach (var emp in employees)
    {
        if (emp.Department == select)
        {
            if (emp.Salary > maxSalDep)
            {
                maxSalDep = emp.Salary;
            }
        }
    }
    Console.WriteLine($"Максимальна зарплата в отделе у {employee.Fio} {maxSalDep}");
}

void AvargSalDep()
{
    Console.WriteLine("Выберите отдел от 1-5");
    int select = Convert.ToInt32(Console.ReadLine());
    int countDep = 0;
    double totalSalDep = 0;
    foreach (var emp in employees)
    {
        
        if (emp.Department == select)
        {
            countDep++;
        }
            
        if (emp.Department == select)
        {
            totalSalDep += emp.Salary;
        }
    }
    Console.WriteLine($"Средняя зарплата отдела: {totalSalDep/countDep}");
}

void IndeksDep()
{
    Console.WriteLine("Выберите отдел от 1-5");
    int select = Convert.ToInt32(Console.ReadLine());

    foreach (var emp in employees)
    {
        if (emp.Department == select)
        {
            emp.Salary += emp.Salary * 0.1;
            Console.WriteLine ($"Зарплата повышена {emp.Fio} до {emp.Salary}");
        }
        
    }
}

void ListDep()
{
    Console.WriteLine("Выберите отдел от 1-5");
    int select = Convert.ToInt32(Console.ReadLine());
    foreach (var emp in employees)
    {
        if (emp.Department == select)
        {
            Console.WriteLine(employee.Id() + ". " + " ФИО:" + emp.Fio + " Зарплата:" + emp.Salary + " ");
        }
    }
}



void LowSalary()
{
    Console.WriteLine("Введите зарплату");
    int sal = Convert.ToInt32(Console.ReadLine());
    foreach (var emp in employees)
    {
        if (emp.Salary<sal)
        {
            Console.WriteLine($"Id: {employee.Id()} ФИО:{emp.Fio} Зарплата:{emp.Salary}");
        }
    }
}

void HighSalary()
{
    Console.WriteLine("Введите зарплату");
    int sal = Convert.ToInt32(Console.ReadLine());
    foreach (var emp in employees)
    {
        if (emp.Salary > sal)
        {
            Console.WriteLine($"Id: {employee.Id()} ФИО:{emp.Fio} Зарплата:{emp.Salary}");
        }
    }
}

int b = 1;

while (b == 1)
{
    Console.WriteLine("Выберети задание от 1 до 14 (0 для завершения)");

    int a = Convert.ToInt32(Console.ReadLine());
    if (a == 0) break;

    if (a == 1)List();
    
    if (a == 2)TotalSalary();
  
    if (a == 4)MaxSalary();
   
    if (a == 3)MinSalary();
 
    if (a == 5)AvargeSalary();
  
    if (a == 6)Fio();

    if (a == 7) Indeks();

    if (a == 8) MinSalDEp();

    if (a == 9) MaxSalDEp();

    if (a == 10) AvargSalDep();

    if (a == 11) IndeksDep();

    if(a == 12) ListDep();

    if (a == 13) LowSalary();

     if(a == 14) HighSalary();
}