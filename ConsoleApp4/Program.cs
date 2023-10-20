using System;
using System.Runtime.InteropServices;

class Programm
{
    static void Main()
    {
        int[] nums1 = new int[5];
        Console.WriteLine("Введите 5 символов:");
        for (int i = 0; i < nums1.Length; i++)
        {
            nums1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Выводятся числа в обратном попрядке");
        for (int v = nums1.Length; v > 0; v--)
        {
            Console.WriteLine(v);
        }
        Console.ReadLine();
    }
}