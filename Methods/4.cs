using System;
using System.Collections.Generic;

class DoublyNode<T> {
    public T Data { get; set; }
    public DoublyNode<T> Previous { get; set; }
    public DoublyNode<T> Next { get; set; }
}

class Program {
    static void Main() {
        Deque exampleDeque = new Deque {};
        exampleDeque.PushBack(1);
        exampleDeque.PushBack(2);
        exampleDeque.PushBack(3);
        exampleDeque.PushBack(4);
        exampleDeque.PushBack(5);
        exampleDeque.PushBack(6);
        exampleDeque.Print();
        exampleDeque.PopFront();
        exampleDeque.Print();
        exampleDeque.PopBack();
        exampleDeque.Print();
        exampleDeque.Remove(3);
        exampleDeque.Print();
    }
}

class Deque {
    public DoublyNode<int> head;
    DoublyNode<int> tail;
    public Deque() {
        head = null;
        tail = null;
    }
    public List<int> Find(int element) {
        DoublyNode<int> currentNode = head;
        int i = 0;
        List<int> positions = new List<int> {};
        while (currentNode != null) {
            if (currentNode.Data == element) positions.Add(i);
            currentNode = currentNode.Next;
        }
        return positions;
    }
    public void PushFront(int element) {
        DoublyNode<int> currentNode = new DoublyNode<int> ();
        currentNode.Data = element;
        currentNode.Previous = null;
        currentNode.Next = head;
        head = currentNode;
        if (tail == null) tail = currentNode;
        else head.Next.Previous = currentNode;
    }
    public void PushBack(int element) {
        DoublyNode<int> currentNode = new DoublyNode<int> ();
        currentNode.Data = element;
        currentNode.Previous = tail;
        currentNode.Next = null;
        tail = currentNode;
        if (head == null) head = currentNode;
        else tail.Previous.Next = currentNode;
    }
    public void Remove(int element) {
        DoublyNode<int> currentNode = new DoublyNode<int> ();
        currentNode = head;
        while (currentNode != null) {
            if (currentNode.Data == element) {
                currentNode.Previous.Next = currentNode.Next;
                currentNode.Next.Previous = currentNode.Previous;
            }
            currentNode = currentNode.Next;
        }
    }
    public void PopFront() {
        head.Next.Previous = null;
        head = head.Next;
    }
    public void PopBack() {
        tail.Previous.Next = null;
        tail = tail.Previous;
    }
    public void Print() {
        DoublyNode<int> currentNode = new DoublyNode<int> ();
        currentNode = head;
        while (currentNode != null) {
            Console.Write(Convert.ToString(currentNode.Data) + ' ');
            currentNode = currentNode.Next;
        }
        Console.WriteLine();
    }
}