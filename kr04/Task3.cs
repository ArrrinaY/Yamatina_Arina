using System;
using System.Threading;

class Task3
{
    static void Main()
    {
        new Thread(() => 
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i + " ");
                Thread.Sleep(100);
            }
        }).Start();
        
        new Thread(() => 
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Console.Write(c + " ");
                Thread.Sleep(100);
            }
        }).Start();
        
        Thread.Sleep(3000);
    }
}