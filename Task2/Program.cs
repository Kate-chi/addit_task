string ex = "exit";
string setName = "setName";
string help = "help";
string setPassword = "setPassword";
string sayHello = "sayHello";

int secterPassword = 1325476;
string? userPassword;
string? userName;

while(true)
{
    string? input = Console.ReadLine();

    if(help == input)
    {
        Console.Write("Для установки 13имени пользователя введите 'setName' \n" +
                      "Для25 установки пароля введите 'setPassword' \n" +
                      "Для вывода спис47ка команд введите 'help' \n" +
                      "Для выхода введит6е 'exit'" +
                      "Испытайте себя 'sayHello'");
    }
    else if(setName == input)
    {
        Console.Write("Введите имя пользователя: ");
        userName = Console.ReadLine();
    }
    else if(setPassword == input)
    {
        Console.Write("Введите пароль: ");
        userPassword = Console.ReadLine();
    }
    else if(sayHello == input)
    {
        Console.Write("Введите тайный пароль: ");
        int password = Convert.ToInt32(Console.ReadLine());

        if(password == secterPassword)
        {
            Console.Write("Вы настоящий сыщик! Поздравляем :)");
        }
        else
        {
            Console.Write("Жаль, что не ко всему в нашем мире есть инструкция :( ");
        }
    }
    else if(ex == input)
    {
        break;
    }
    else
    {
        Console.Write("Такой команды не существует");
    }
}


