using System;

class Program {
    static int[] RandomArray(int size) {
        int[] array = new int[size];
        var rand = new Random((int)DateTime.Now.Ticks);
        for (int i = 0; i < size; i++) {
            array[i] = rand.Next() % 100;
        }
        return array;
    }
    static int[] SumTwoArrays(int[] first, int[] second) {
        int[] result = new int[first.Length];
        if (first.Length == second.Length) {
            for (int i = 0; i < first.Length; i++)
                result[i] = first[i] + second[i];
            return result;
        } else Console.WriteLine("Sizes not equal");
        return null;
    }
    static int[] Multiplication(int[] array, int number) {
        int[] result = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
                result[i] = array[i] * number;
        return result;
    }
    static int[] FindEqual(int[] first, int[] second) {
        int[] result = new int[] {};
        for (int i = 0; i < first.Length; i++)
            for (int j = 0; j < second.Length; j++) {
                if (first[i] == second[j]) {
                    int f = 0;
                    for (int k = 0; k < result.Length; k++)
                        if (result[k] == first[i]) {
                            f++;
                            break;
                        }
                    if (f == 0) {
                        Array.Resize(ref result, result.Length + 1);
                        result[result.Length - 1] = first[i];
                    }
                }
            }
        return result;
    }
    static void PrintArray(int[] array) {
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");
    }
    static int[] DescendingArray(int[] array) {
        int[] array_copy = (int[])array.Clone();
        int[] result = new int[array_copy.Length];
        for (int i = 0; i < array_copy.Length; i++) {
            int _max = (int)-1e7;
            int maxi = -1;
            for (int j = 0; j < array_copy.Length; j++)
                    if (_max < array_copy[j]) {
                        _max = array_copy[j];
                        maxi = j;
                    }
            result[i] = _max;
            array_copy[maxi] = (int)-1e7;
        }
        return result;
    }
    static int MinOfArray(int[] array) {
        int _min = (int)1e7;
        for (int i = 0; i < array.Length; i++)
            if (array[i] < _min)
            _min = array[i];
        return _min;
    }
    static int MaxOfArray(int[] array) {
        int _max = (int)-1e7;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > _max)
                    _max = array[i];
        return _max;
    }
    static int AvgOfArray(int[] array) {
        int avg = 0;
            for (int i = 0; i < array.Length; i++)
                avg = avg + array[i];
        return avg / array.Length;
    }
    static void Main() {
        int[] array1 = RandomArray(10);
        PrintArray(array1);
        int[] array2 = RandomArray(10);
        Console.WriteLine();
        Console.WriteLine();
        PrintArray(array2);
        int[] resultsum = SumTwoArrays(array1, array2);
        Console.WriteLine();
        Console.WriteLine();
        PrintArray(resultsum);
        int[] resultmult = Multiplication(array1, 5);
        Console.WriteLine();
        Console.WriteLine();
        PrintArray(resultmult);
        int[] array3 = RandomArray(100);
        int[] resulteq = FindEqual(array1, array3);
        Console.WriteLine();
        Console.WriteLine();
        PrintArray(resulteq);
        int[] resultdesc = DescendingArray(array1);
        Console.WriteLine();
        Console.WriteLine();
        PrintArray(resultdesc);
        Console.WriteLine();
        Console.Write("Min of array1: " + Convert.ToString(MinOfArray(array1)));
        Console.WriteLine();
        Console.Write("Max of array1: " + Convert.ToString(MaxOfArray(array1)));
        Console.WriteLine();
        Console.Write("Avg of array1: " + Convert.ToString(AvgOfArray(array1)));
        return;
    }
}