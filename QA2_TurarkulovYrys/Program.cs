using QA2_TurarkulovYrys.Controllers;


bool exit = false;
while (!exit)
{
    Console.WriteLine("Выберите таблицу:");
    Console.WriteLine("1. Clients");
    Console.WriteLine("2. Orders");
    Console.WriteLine("3. Выйти");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Добавить клиента");
                Console.WriteLine("2. Редактировать клиента");
                Console.WriteLine("3. Удалить клиента");
                Console.WriteLine("4. Показать заказы клиента");
                Console.WriteLine("5. Вернуться к выбору таблицы");
                Console.WriteLine("6. Выйти");

                string action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        ClientController.AddClient();
                        break;
                    case "2":
                        ClientController.EditClient();
                        break;
                    case "3":
                        ClientController.DeleteClient();
                        break;
                    case "4":
                        ClientController.Show();
                        break;
                    case "5":
                        exit = true;
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }

                if (action == "5") break;
            }
            break;

        case "2":

            while (!exit)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Добавить заказ");
                Console.WriteLine("2. Редактировать заказ");
                Console.WriteLine("3. Удалить заказ");
                Console.WriteLine("4. Вернуться к выбору таблицы");
                Console.WriteLine("5. Выйти");

                string action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        OrderController.AddOrder();
                        break;
                    case "2":
                        OrderController.EditOrder();
                        break;
                    case "3":
                        OrderController.Show();
                        break;
                    case "4":
                        exit = true;
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }

                if (action == "4") break;
            }
            break;
        case "3":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Неверный выбор!");
            break;
    }
}


