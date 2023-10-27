using System;

class Program {
    static void Main() {
        Stack stack = new Stack();
        while (true) {
            string[] inputData = Console.ReadLine().Split(' ');
            switch (inputData[0]) {
                case "push":
                Console.WriteLine(stack.Push(Convert.ToInt32(inputData[1])));
                break;
                case "pop":
                Console.WriteLine(stack.Pop());
                break;
                case "front":
                Console.WriteLine(stack.Front());
                break;
                case "size":
                Console.WriteLine(stack.Size());
                break;
                case "clear":
                Console.WriteLine(stack.Clear());
                break;
                case "exit":
                Console.WriteLine(stack.Exit());
                return;
            }
        }
    }
}

class Stack {
    int top;
    int bottom;
    int[] array;
    public Stack() {
        this.array = new int[] {};
        this.top = -1;
    }
    public string Push(int number) {
        if (this.Size() == 0) this.bottom = 0;
        Array.Resize(ref array, this.Size() + 1);
        this.top = this.top + 1;
        array[top] = number;
        return "ok";
    }
    public string Pop() {
        if (top != -1) {
            int firstElement = array[bottom];
            this.bottom += 1;
            Array.Resize(ref array, this.Size() - 1);
            return Convert.ToString(firstElement);
        } else return "error";
    }
    public string Front() {
        if (top != -1) {
            return Convert.ToString(array[bottom]);
        } else return "error";
    }
    public int Size() {
        return this.array.Length;
    }
    public string Clear() {
        this.top = -1;
        Array.Resize(ref array, 0);
        return "ok";
    }
    public string Exit() {
        return "bye";
    }
}