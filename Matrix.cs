namespace Class
{
    public class Matrix
    {
        private int[,] data;
        public Matrix(int[,] arr)
        {
            data = arr;
        }
        public int this[int index]
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    sum += data[i, index];
                }
                return sum;
            }
        }
        public double Rmeansquare
        {
            get
            {
                double sum = 0;
                int n = data.GetLength(0);
                int m = data.GetLength(1);
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        sum += data[i, j] * data[i, j];
                return Math.Sqrt(sum / (n * m));
            }
        }
    }
}
