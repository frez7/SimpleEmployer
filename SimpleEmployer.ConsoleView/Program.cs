using SimpleEmployer.BLL.ConsoleBL;

EmployeeManagement manager = new EmployeeManagement();
while (true)
{
    Console.Clear();
    Console.WriteLine("\nНажмите на соотвествующую цифру пункта меню.");
    Console.WriteLine("\nГлавное меню:");
    Console.WriteLine("1. Добавить нового сотрудника.");
    Console.WriteLine("2. Удалить сотрудника.");
    Console.WriteLine("3. Показать всех сотрудников.");
    Console.WriteLine("4. Выйти из программы.");

    ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
    char choice = keyInfo.KeyChar;

    switch (choice)
    {
        case '1':
            Console.Clear();
            Console.Write("Введи имя сотрудника: ");
            string name = Console.ReadLine();

            Console.Write("Введи возраст сотрудника: ");
            int age = IntegerInputValidation();

            Console.Write("Введи должность сотрудника: ");
            string position = Console.ReadLine();

            manager.AddEmployee(name, age, position);
            Console.WriteLine("\nСотрудник успешно добавлен в общий список, нажмите любую кнопку чтобы вернуться в главное меню!");
            Console.ReadKey();
            break;

        case '2':
            Console.Clear();
            Console.Write("Введи ID сотрудника для удаления: ");
            int idToRemove = IntegerInputValidation();

            bool removed = manager.RemoveEmployee(idToRemove);
            if (removed)
            {
                Console.WriteLine("Сотрудник успешно удален.");
            }
            else
            {
                Console.WriteLine("Сотрудник не найден.");
            }
            Console.WriteLine("\nНажмите любую кнопку, чтобы вернуться в главное меню!");
            Console.ReadKey();
            break;

        case '3':
            Console.Clear();
            Console.WriteLine("Все сотрудники:");
            manager.GetAllEmployees();
            Console.WriteLine("\nНажмите любую кнопку, чтобы вернуться в главное меню!");
            Console.ReadKey();
            break;

        case '4':
            Console.WriteLine("Выход из программы...");
            return;

        default:
            Console.Clear();
            Console.WriteLine("Такого пункта не существует, нажмите любую кнопку, чтобы вернуться в главное меню!");
            Console.ReadKey();
            break;
    }
}

int IntegerInputValidation()
{
    bool isSuccess = false;
    var parsed = 0;
    while (!isSuccess)
    {
        try
        {
            parsed = int.Parse(Console.ReadLine());
            isSuccess = true;
        }
        catch (Exception)
        {
            Console.WriteLine("Вы должны ввести валидное число, попробуйте еще раз!");
        }
    }
    return parsed;
}