using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string src1 = @"C:\Users\igorc\OneDrive\Рабочий стол\file1.txt";
        Console.WriteLine("Введите название файла");
        string name = Console.ReadLine();
        Console.WriteLine("Введите путь файла");
        string way = Console.ReadLine();
        File.Copy(src1, (@"" + way + name + ".txt"));

        Console.WriteLine("Последовательное копирование");
        Timer timer = new Timer();
        timer.Start();
        string dest1 = @"C:\Users\igorc\OneDrive\Рабочий стол\cory1.txt";
        File.Copy(src1, dest1);
        string src2 = @"C:\Users\igorc\OneDrive\Рабочий стол\file2.txt";
        string dest2 = @"C:\Users\igorc\OneDrive\Рабочий стол\cory2.txt";
        File.Copy(src2, dest2);
        timer.Stop();

        Console.WriteLine("Паралельное копирование");
        Thread th = new Thread(Copy);
        timer.Start();
        th.Start();
        string src = @"C:\Users\igorc\OneDrive\Рабочий стол\file1.txt";
        string dest = @"C:\Users\igorc\OneDrive\Рабочий стол\cory3.txt";
        File.Copy(src, dest);
        timer.Stop();

    }


    public static void Copy()
    {
        string src = @"C:\Users\igorc\OneDrive\Рабочий стол\file2.txt";
        string dest = @"C:\Users\igorc\OneDrive\Рабочий стол\cory4.txt";
        File.Copy(src, dest);
    }
}
internal class Timer
{
    public DateTime dt1;
    public DateTime dt2;
    public Timer() /// Конструктор создаёт таймер вызывать так: Timer timer = new Timer();
    {

    }
    public void Start() /// запускает таймер вызывать так: timer.Start();
    {
        dt1 = DateTime.Now;
    }
    public void Stop() /// останавливает таймер и выводит сколько времени прошло с начала запуска вызывать так: Timer.Stop();
    {
        dt2 = DateTime.Now;
        TimeSpan ts = dt2 - dt1;
        Console.WriteLine("Времени прошло " + ts.TotalMilliseconds + " миллисекунда"); /// время отоброжается в миллисекундах
    }
}
