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
        int M = 0;
        Console.WriteLine();
        Console.WriteLine("Input number of new elements: ");
        M = Convert.ToInt32(Console.ReadLine());
        int[] new_array = new int[] {};
        Array.Resize(ref new_array, M);
        Console.WriteLine("Input elements: ");
        for (int i = 0; i < M; i++) new_array[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input position K: ");
        int K = Convert.ToInt32(Console.ReadLine());
        Array.Resize(ref array, array.Length + M);
        int[] buf = new int[] {};
        Array.Resize(ref buf, (N - K + 1));
        for (int i = 0; i < (N - K + 1); i++)
                buf[i] = array[K + i - 1];
        for (int i = 0; i < (N - K + 1); i++)
                array[K + M + i - 1] = buf[i];
        for (int i = 0; i < M; i++)
            array[K + i - 1] = new_array[i];
        foreach (var element in array) Console.Write(element.ToString() + ' ');
        return;
    }
}