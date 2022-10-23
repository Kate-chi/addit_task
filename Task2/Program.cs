string ex = "exit";
int x = 2;

while(x > 1)
{
    Console.WriteLine("++++для выхода напишите exit++++");
    if(ex == Console.ReadLine())
    {
        break;
    }
    x++;
}