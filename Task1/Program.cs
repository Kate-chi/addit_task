﻿string secret = "Хе хе хе :)";
string password = "12345";

int count = 0;

while(count < 3)
{
    Console.Write("Введите пароль: ");
    if(password == Console.ReadLine())
    {
        Console.Write(secret);
        break;
    }
    else if(count < 2)
    {
        Console.WriteLine("Попробуйте снова!");
    }
    else
    {
        Console.WriteLine("Очень жаль, вы не узнаете секрет :(");
    }
    count++;
}
