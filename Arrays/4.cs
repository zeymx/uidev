using System;

class Program {
    static void Main() {
        string s = Console.ReadLine();
        string[] buf = s.Split(' ');
        int N = Convert.ToInt32(buf[0]), M = Convert.ToInt32(buf[1]);
        int[,] seats = new int[N, M];
        for (int i = 0; i < N; i++) {
            s = Console.ReadLine();
            buf = s.Split(' ');
            for (int j = 0; j < M; j++)
                seats[i,j] = Convert.ToInt32(buf[j]);
        }
        int K = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < N; i++) {
            int p = 0, pmax = 0;
            for (int j = 0; j < M; j++) {
                p = p + 1;
                if (seats[i,j] == 1)
                    p = 0;
                if (p > pmax) {
                    pmax = p;
                }
            }
            if (K <= pmax) {
                Console.WriteLine(i + 1);
                return;
            }
        }
        Console.Write(0);
        return;
    }
}