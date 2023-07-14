using System;
using System.Threading;

//ref link:https://www.youtube.com/watch?v=DsHV2BY1lgQ&list=PLRwVmtr-pp06KcX24ycbC-KkmAISAFKV5&index=4
// 

class MainClass
{
    static int count = 0;
    static void Main()
    {
        var thread1 = new Thread(IncrementCount);
        var thread2 = new Thread(IncrementCount);
        thread1. Start();
        Thread.Sleep(500);
        thread2.Start();
    }
    static void IncrementCount()
    {
        while (true)
        {
            int temp = count;
            Thread.Sleep(1000);
            count = temp + 1;
            //count++; // count = count + 1;
            Console.WriteLine(
                "Thread ID " + Thread.CurrentThread.ManagedThreadId + 
                " incremented count to " + count);
            Thread.Sleep(1000);
        }
    }
}