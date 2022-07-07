using System;
using System.Collections.Generic;
using System.Linq;

namespace paiza
{
    class Program
    {
        static void Main(string[] args)
        {
            //paiza B095:カラオケ大会

            //input
            string[] line1 = Console.ReadLine().Trim().Split(' ');

            int N = int.Parse(line1[0]);
            int M = int.Parse(line1[1]);

            int[] answer = new int[M];
            int[,] src = new int[N, M];

            for (int i = 0; i < M; i++)
                answer[i] = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    src[i, j] = int.Parse(Console.ReadLine().Trim());

            //end input

            int[] dst = new int[N];
            List<int> score = new List<int>();
            for (int i = 0; i < N; i++)
            {
                int temp = 100;
                for (int j = 0; j < M; j++)
                {
                    int diff = Math.Abs(answer[j] - src[i, j]);
                    if (diff > 5)
                    {
                        if (diff <= 10)
                            temp -= 1;
                        else if (diff <= 20)
                            temp -= 2;
                        else if (diff <= 30)
                            temp -= 3;
                        else if (diff > 30)
                            temp -= 5;
                        if (temp <= 0)
                        {
                            temp = 0;
                            break;
                        }
                    }
                }
                score.Add(temp);
            }

            Console.WriteLine(score.Max());

        }
    }
}

