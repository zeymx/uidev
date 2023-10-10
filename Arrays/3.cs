using System;

class Program {
    static void Main() {
        return;
    }
    void RandomArray(int size) {
        int[] array = new int[size];
        var rand = new Random();
        for (int i = 0; i < size; i++) {
            array[i] = rand.Next() % 100;
        }
    }
}