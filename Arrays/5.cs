using System;

class Program {
    static void Main() {
        int[] array1 = new int[100000000];
        int[] array2 = new int[100000000];
        var rand = new Random((int)DateTime.Now.Ticks);
        for (int i = 0; i < 10000; i++) {
            array1[i] = rand.Next() % 10;
            array2[i] = rand.Next() % 10;
        }
        Console.WriteLine();
        Console.WriteLine("First Matrix: ");
        Console.WriteLine();
        for (int i = 0; i < 10000; i++) {
            for (int j = 0; j < 10000; j++) {
                Console.Write(Convert.ToString(array1[i * 10000 + j]) + ' ');
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("Second Matrix: ");
        Console.WriteLine();
        for (int i = 0; i < 10000; i++) {
            for (int j = 0; j < 10000; j++) {
                Console.Write(Convert.ToString(array2[i * 10000 + j]) + ' ');
            }
            Console.WriteLine();
        }
        int[] result = new int[100000000];
        for (int i = 0; i < 100000000; i++) {
            result[i] = 0;
            for (int j = 0; j < 10000; j++)
                result[i] += array1[10000 * (i / 10000) + j] * array2[j * 10000 + i % 10000];
        }
        Console.WriteLine();
        Console.WriteLine("Result: ");
        Console.WriteLine();
        for (int i = 0; i < 10000; i++) {
            for (int j = 0; j < 10000; j++) {
                Console.Write(Convert.ToString(result[i * 10000 + j]) + ' ');
            }
            Console.WriteLine();
        }
        return;
    }
}