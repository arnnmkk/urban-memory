using System;

Console.Title = "Угадай число";
Random random = new Random();
int myNum;
int secret = random.Next(100) +1;
Console.WriteLine("Я загадал число от 1 до 100, попробуй угадать.");
for (int i = 0; i < 15;  i++)
{
    myNum = int.Parse(Console.ReadLine());
    if (myNum == secret)
    {
        Console.WriteLine("харооош");
        return;
    }
    else
    {
        if (myNum > secret)
        {
            Console.WriteLine("чуть меньше бро");
        }

        else
        {
            Console.WriteLine("чуть больше бро");
        } 

    }
    
}
Console.WriteLine("Попытки закончились, было загадано число" + secret + ".");

Console.ReadKey();
