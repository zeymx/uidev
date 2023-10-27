using System;

class Program {
    static void Main() {
        string text = Console.ReadLine();
        int balance = 0;
        int bracketsCounter = 0;
        bool isOpen = false;
        bool isFirst = true;
        int firstPosition = -1;
        for (int i = 0; i < text.Length; i++) {
            if (text[i] == '(') {
                if (isOpen == true) {
                    bracketsCounter += 1;
                    balance += 1;
                }
                else {
                    isOpen = true;
                    balance += 1;
                }
            } else if (text[i] == ')' && isFirst == true && isOpen == false) {
                balance -= 1;
                isFirst = false;
                firstPosition = i + 1;
            }
            else if (text[i] == ')' && isOpen == true) {
                balance -= 1;
                isOpen = false;
            }
            else if (text[i] == ')') balance -= 1;
        }
        if (firstPosition == -1 && bracketsCounter == 0) Console.WriteLine("yes");
        else if (balance > 0) {
            Console.WriteLine("no");
            Console.WriteLine(bracketsCounter);
        } else if (balance < 0) {
            Console.WriteLine("no");
            Console.WriteLine(firstPosition);
        } else Console.WriteLine("no");
    }
}