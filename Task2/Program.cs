int secterPassword = 1325476;
string? userPassword = "";
string? userName = "";

while(true)
{
    string? input = Console.ReadLine();

    switch(input)
    {
        case "help": 

            Console.WriteLine("Для установки 13имени пользователя введите 'setName' \n" +
                              "Для25 установки пароля введите 'setPassword' \n" +
                              "Для вывода спис47ка команд введите 'help' \n" +
                              "Для выхода введит6е 'exit' \n" +
                              "Испытайте себя 'sayHello'");
            break;              
    
        case "setName":

            Console.WriteLine("Введите имя пользователя: ");
            userName = Console.ReadLine();

            break;

        case "setPassword":
    
            Console.WriteLine("Установите пароль: ");
            userPassword = Console.ReadLine();

            break;
    
        case "sayHello":

            Console.WriteLine("Введите тайный пароль: ");
            int password = Convert.ToInt32(Console.ReadLine());

            if(password == secterPassword)
            {
                Console.WriteLine("Вы настоящий сыщик! Поздравляем :)");
            }    
            else
            {
                Console.WriteLine("Жаль, что не ко всему в нашем мире есть инструкция :( ");
            }

            break;

        case "writeName":

            Console.WriteLine("Введите ваш пароль: ");
            string? pass = Console.ReadLine();

            if(pass == userPassword)
            {
                Console.WriteLine($"Привет, {userName}");
            }
            else
            {
                Console.WriteLine("Вы ввели неверный пароль");
            }
            break;

        default:
            {
                Console.WriteLine("Такой команды не существует");
            }
            break;
    }

    if(input == "exit")
    {
        break;
    }
}    


