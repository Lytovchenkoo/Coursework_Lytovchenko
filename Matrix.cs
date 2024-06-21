using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace A_kurs
{
    internal class Matrix
    {
        private int m;
        private int n;
        private double[,] M;

        public Matrix(int m = 3, int n = 3)
        {
            this.m = m;
            this.n = n;
            M = new double[m, n];
        }

        public double this[int i, int j]
        {
            get { return M[i, j]; }
            set { M[i, j] = value; }
        }

        public int getM() { 
            return m; 
        }
        public int getN()
        {
            return n;
        }

        public void appendRow()
        {
            double[,] clone = new double[m+1, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    clone[i, j] = M[i, j];
                }
            }
            M = clone;
            m++;
        }

        public void appendColumn()
        {
            double[,] clone = new double[m, n+1];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    clone[i, j] = M[i, j];
                }
            }
            M = clone;
            n++;
        }

        public Matrix getClone(int from_row, int from_col, int to_row, int to_col)
        {
            if (from_row < 0  || to_row < 0)  return null;
            if (from_row >= m || to_row >= m) return null;
            if (from_col < 0  || to_col < 0)  return null;
            if (from_col >= n || to_col >= n) return null;

            int mc = to_row - from_row + 1;
            int nc = to_col - from_col + 1;

            Matrix clone = new Matrix(mc, nc);
            int ic = 0;
            for (int i = from_row; i <= to_row; i++)
            {
                int jc = 0;
                for (int j = from_col; j <= to_col; j++)
                {
                    clone[ic, jc] = M[i, j];
                    jc++;
                }
                ic++;
            }

            return clone;
        }

        public Matrix getClone()
        {
            Matrix clone = new Matrix(m, n);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    clone[i, j] = M[i, j];
                }
            }
            return clone;
        }

        public Matrix getClone2X()
        {
            Matrix clone = new Matrix(m, m+m);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    clone[i, j] = M[i, j];

                }
            }

            for (int i = 0; i < m; i++)
            {
                clone[i, i + n] = 1;
            }

            return clone;
        }

        public void JordanGaussTransform()
        {
            Tools.JordanGaussTransform(M);
        }
        public Matrix getInvertibleMatrixJordanGauss()
        {
            if (getDeterminant() == 0)
            {
                throw new InvalidOperationException("Визначник матриці дорівнює нулю, тому матриця не може бути оберненою.");
            }

            Matrix MM = getClone2X();
            MM.JordanGaussTransform();

            Matrix ans = new Matrix(m, n);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ans[i, j] = MM[i, n+j];
                }
            }
            return ans;
        }

        public Matrix getInvertibleMatrixOk()
        {
            Matrix MM = getClone();       
            if (m!=n) return MM;

            Matrix ans = new Matrix(1, 1);
            ans[0, 0] = 1.0/MM[0, 0];

            for (int k = 1; k < m; k++)
            {
                Matrix V = getVectorV(k);
                Matrix U = getVectorU(k);
                double akk = MM[k, k];

                double ak = akk - (V * ans * U)[0, 0];
                Matrix rk = (-1.0/ak) * ans * U;
                Matrix qk = (-1.0/ak) * V * ans;
                Matrix B = ans + (1.0 / ak) * ans * U * V * ans;

                B.appendRow();
                B.appendColumn();

                for (int j=0; j<k; j++)
                {
                    B[k, j] = qk[0, j];
                }
                for (int i = 0; i < k; i++)
                {
                    B[i, k] = rk[i, 0];
                }
                B[k, k] = 1.0 / ak;

                ans = B;
            }
            return ans;
        }


        private Matrix getVectorV(int n)
        {
            Matrix ans = new Matrix(1, n);
            for (int j = 0; j < n; j++) ans[0, j] = M[n, j];
            return ans;
        }
        private Matrix getVectorU(int n)
        {
            Matrix ans = new Matrix(n, 1);
            for (int i = 0; i < n; i++) ans[i, 0] = M[i, n];
            return ans;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.m != b.m || a.n != b.n) throw new Exception("Matrix operator+ (a, b) - Error: matrixes have diffrent sizes");

            Matrix c = new Matrix(a.m, a.n);

            for (int i = 0; i < a.m; i++)
            {
                for (int j = 0; j < a.n; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }

            return c;
        }
        public static Matrix operator * (Matrix a, Matrix b)
        {
            if (a.n != b.m) throw new Exception("Matrix operator*(a, b) - Error: a.n != b.m");

            Matrix c = new Matrix(a.m, b.n);

            int t = a.n; // спільний розмір двох матриць
            for (int i=0; i<a.m; i++)
            {
                for (int j=0; j<b.n; j++)
                {
                    double sum = 0;
                    for (int k=0; k<t; k++)
                    {
                        sum += a[i, k] * b[k, j];
                    }
                    c[i, j] = sum;
                }
            }

            return c;
        }

        public static Matrix operator *(double x, Matrix a)
        {
            Matrix c = new Matrix(a.m, a.n);
            for (int i = 0; i < a.m; i++)
            {
                for (int j = 0; j < a.n; j++)
                {
                    c[i, j] = x * a[i, j];
                }
            }
            return c;
        }

        public static Matrix operator *(Matrix a, double x)
        {
            Matrix c = new Matrix(a.m, a.n);
            for (int i = 0; i < a.m; i++)
            {
                for (int j = 0; j < a.n; j++)
                {
                    c[i, j] = a[i, j] * x;
                }
            }
            return c;
        }


        public double getDeterminant()
        {
            return Tools.calcMatrixDeterminant(M);
        }

        public int getMatrixRange()
        {
            return Tools.calcMatrixRange(M);
        }

      
        public bool saveToFile(string filename)
        {
            if (filename == null) return false;
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(m);
            bw.Write(n);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double x = M[i, j];
                    bw.Write(x);
                }
            }

            bw.Close();
            fs.Close();
            return true;
        }

        public bool loadFromFile(string filename)
        {
            if (filename == null) return false;

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            try
            {
                m = br.ReadInt32();
                n = br.ReadInt32();
                M = new double[m, n];

                int N = m * n;
                for (int k = 0; k < N; k++)
                {
                    int i = k / n;
                    int j = k % n;
                    double x = br.ReadDouble();
                    M[i, j] = x;
                }
            }
            catch (Exception)
            {
                br.Close();
                fs.Close();
                return false;
            }
            br.Close();
            fs.Close();
            return true;
        }

    }
}
