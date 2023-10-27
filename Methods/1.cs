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
                case "back":
                Console.WriteLine(stack.Back());
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
    int[] array;
    public Stack() {
        this.array = new int[] {};
        this.top = -1;
    }
    public string Push(int number) {
        Array.Resize(ref array, this.Size() + 1);
        this.top = this.top + 1;
        array[top] = number;
        return "ok";
    }
    public int Pop() {
        if (top != -1) {
            int lastElement = array[top];
            this.top -= 1;
            Array.Resize(ref array, this.Size() - 1);
            return lastElement;
        } else return -1;
    }
    public int Back() {
        if (top != -1) {
            return array[top];
        } else return -1;
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