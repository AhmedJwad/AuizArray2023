using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizArray.logic
{
    public class TowDiamation
    {
        private int[,] _array;

        public TowDiamation(int m, int n)
        {
           M= m;
           N = n;
            _array = new int[M,N];
        }

        public int M { get; }
        public int N { get; }

        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    output += $"{_array[i,j]}";
                }
            }
            return output;
        }

        public OneDiamation ToOneDiamation()
        {
            var oneDiamation = new OneDiamation(M * N);
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j <M; j++)
                {
                    oneDiamation.Add(_array[i, j]);
                }
            }
            return oneDiamation;
        }

        public void Fill()
        {
            var random = new Random();
            for (int i = 0; i < M; i++)
            {
                for (int j= 0; j < N; j++)
                {
                    _array[i, j] = random.Next(1, 100);
                }
            }
        }
    }
}
