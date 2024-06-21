using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_kurs
{
    internal class Tools
    {
        public static double[,] CloneDblMatr(double[,] matr)
        {
            int m = matr.GetLength(0);
            int n = matr.GetLength(1);
            double[,] clone = new double[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    clone[i, j] = matr[i, j];
                }
            }
            return clone;
        }

        public static double[,] CloneDblMatr(double[,] matr, int from_row, int from_col, int to_row, int to_col)
        {
            int m = matr.GetLength(0);
            int n = matr.GetLength(1);
            if (from_row < 0 || to_row < 0) return null;
            if (from_row >= m || to_row >= m) return null;
            if (from_col < 0 || to_col < 0) return null;
            if (from_col >= n || to_col >= n) return null;

            int mc = to_row - from_row + 1;
            int nc = to_col - from_col + 1;

            double[,] clone = new double[mc, nc];

            int ic = 0;
            for (int i = from_row; i <= to_row; i++)
            {
                int jc = 0;
                for (int j = from_col; j <= to_col; j++)
                {
                    clone[ic, jc] = matr[i, j];
                    jc++;
                }
                ic++;
            }

            return clone;
        }

        private static void SwapRows(double[,] M, int row1, int row2)
        {
            int m = M.GetLength(0);
            int n = M.GetLength(1);
            if (row1 < 0 || row2 < 0) return;
            if (row1 >= m || row2 >= m) return;
            for (int j = 0; j < n; j++)
            {
                double temp = M[row1, j];
                M[row1, j] = M[row2, j];
                M[row2, j] = temp;
            }
        }

        private static void SwapCols(double[,] M, int col1, int col2)
        {
            int m = M.GetLength(0);
            int n = M.GetLength(1);
            if (col1 < 0 || col2 < 0) return;
            if (col1 >= n || col2 >= n) return;

            for (int i = 0; i < m; i++)
            {
                double temp = M[i, col1];
                M[i, col1] = M[i, col2];
                M[i, col2] = temp;
            }
        }

        private static bool Normalize(double[,] M, int k)
        {
            if (M[k, k] != 0) return false;

            int row = -1;
            int m = M.GetLength(0);
            for (int i = k + 1; i < m; i++)
            {
                if (M[i, k] != 0)
                {
                    row = i;
                    break;
                }
            }
            if (row != -1)
            {
                SwapRows(M, row, k);
            }

            return row % 2 != k % 2;
        }

        public static double calcMatrixDeterminant(double[,] M)
        {
            int m = M.GetLength(0);
            int n = M.GetLength(1);
            int N = Math.Min(m, n);

            double[,] tempM = (double[,])M.Clone();

            bool minus = false;
            if (Normalize(tempM, 0)) minus = !minus;
            for (int k = 1; k < N; k++)
            {
                int p = k - 1;
                if (Normalize(tempM, p)) minus = !minus;
                double zn = tempM[p, p];
                if (zn == 0) return 0.0;
                for (int i = k; i < N; i++)
                {
                    double ch = tempM[i, p];
                    for (int j = 0; j < N; j++)
                    {
                        tempM[i, j] = tempM[i, j] - tempM[p, j] * ch / zn;
                    }
                }
            }

            double det = 1;
            for (int k = 0; k < N; k++)
            {
                det *= tempM[k, k];
            }

            if (minus) return -det;
            return det;
        }

        public static int calcMatrixRange(double[,] M)
        {
            int m = M.GetLength(0);
            int n = M.GetLength(1);
            int N = Math.Min(m, n);
            double[,] tempM = (double[,])M.Clone();

            int range = 0;
            for (int k = 0; k < N; k++)
            {
                double det = 0;
                for (int i = k; i < m; i++)
                {
                    SwapRows(tempM, k, i);
                    for (int j = k; j < n; j++)
                    {
                        SwapCols(tempM, k, j);
                        double[,] MM = CloneDblMatr(tempM, 0, 0, k, k);
                        det = calcMatrixDeterminant(MM);
                        if (Math.Abs(det) > 0.000001)
                        {
                            range++;
                            goto ExitLabel;
                        }
                    }
                }
            ExitLabel:;
                if (det == 0) break;
            }

            return range;
        }

        public static void JordanGaussTransform(double[,] M)
        {
            int m = M.GetLength(0);
            int n = M.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                Normalize(M, i);
                double lead = M[i, i];

                for (int j = 0; j < n; j++)
                {
                    if (lead != 0)
                    {
                        M[i, j] /= lead;
                    }
                    else
                    {
                        M[i, j] = 0;
                    }
                }

                for (int k = 0; k < m; k++)
                {
                    if (k != i)
                    {
                        double factor = M[k, i];
                        for (int j = 0; j < n; j++)
                        {
                            M[k, j] -= factor * M[i, j];
                        }
                    }
                }
            }
        }
    }
}
