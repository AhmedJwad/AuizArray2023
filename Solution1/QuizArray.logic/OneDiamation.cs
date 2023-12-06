namespace QuizArray.logic
{
    public class OneDiamation
    {
        private int[] _array;
        private int _top;

        public OneDiamation(int n)
        {
            N = n;
            _array = new int[N];    
        }

        public int N { get; }
        private bool IsEmpty => N == 0;

        private bool IsFull => N == _top;

        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < _top; i++)
            {
                output += $"{_array[i]}\t";
            }
            return output;
        }
        public void Add(int Value)
        {
            if(IsFull)
            {
                throw new Exception("The array is full.");
            }
            _array[_top] = Value;
            _top++;
        }

    }
}
