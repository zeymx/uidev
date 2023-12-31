using System;

class Program {
    static void Main() {
        int N = 0;
        Console.WriteLine("Input array length: ");
        N = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[] {};
        Array.Resize(ref array, N);
        var rand = new Random((int)DateTime.Now.Ticks);
        for (int i = 0; i < N; i++) 
            array[i] = rand.Next() % (int)1e2;
        foreach (var element in array) Console.Write(element.ToString() + ' ');
        Console.WriteLine();
        for (int i = 0; i < N / 2; i++) {
            array[i] = array[((N + 1) / 2) + i] + array[i];
            array[((N + 1) / 2) + i] = array[i] - array[((N + 1) / 2) + i];
            array[i] = array[i] - array[((N + 1) / 2) + i];
        }
        foreach (var element in array) Console.Write(element.ToString() + ' ');
        return;
    }
}