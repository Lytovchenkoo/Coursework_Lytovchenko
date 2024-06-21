using System;
using System.IO;
using System.Windows.Forms;

namespace A_kurs
{
    public partial class Form1 : Form
    {
        private static readonly Random random = new();
        private string fileName = "noname";
        const int NUM_OF_DIGITS = 3;
        const int MAX_ROWS_COLS = 15;
        const int MIN_ROWS_COLS = 2;
        string DBL_FORMAT = "{0,4:F3}";

        public Form1()
        {
            InitializeComponent();
            Grid.ColumnCount = 3;
            Grid.RowCount = 4;
            Grid.AllowUserToAddRows = false;
            setColumnsWidth(70);
            Reset();
        }

        private void UpDownCol_ValueChanged(object sender, EventArgs e)
        {
            if (UpDownCol.Value > MAX_ROWS_COLS)
            {
                MessageBox.Show("Максимальна кількість стовпців - 15");
                UpDownCol.Value = MAX_ROWS_COLS;
                return;
            }

            if (UpDownCol.Value < MIN_ROWS_COLS)
            {
                MessageBox.Show("Мінімальна кількість стовпців - 2");
                UpDownCol.Value = MIN_ROWS_COLS;
                return;
            }

            int n = Grid.ColumnCount;
            int curColumn = Grid.CurrentCell?.ColumnIndex ?? 0;

            if (n < (int)UpDownCol.Value)
            {
                Grid.ColumnCount = (int)UpDownCol.Value;
                for (int i = 0; i < Grid.RowCount; i++)
                {
                    for (int j = Grid.ColumnCount - 1; j > curColumn; j--)
                    {
                        Grid[j, i].Value = Grid[j - 1, i].Value;
                    }
                }
                for (int i = 0; i < Grid.RowCount; i++)
                {
                    Grid[curColumn, i].Value = String.Format(DBL_FORMAT, 0.0);
                }
            }
            else if (n > (int)UpDownCol.Value && n > MIN_ROWS_COLS)
            {
                Grid.Columns.RemoveAt(curColumn);
            }
            setColumnsWidth(70);
        }

        private void UpDownRow_ValueChanged(object sender, EventArgs e)
        {
            if (UpDownRow.Value > MAX_ROWS_COLS)
            {
                MessageBox.Show("Максимальна кількість рядків - 15");
                UpDownRow.Value = MAX_ROWS_COLS;
                return;
            }

            if (UpDownRow.Value < MIN_ROWS_COLS)
            {
                MessageBox.Show("Мінімальна кількість рядків - 2");
                UpDownRow.Value = MIN_ROWS_COLS;
                return;
            }

            int m = Grid.RowCount;

            if (m < (int)UpDownRow.Value)
            {
                int curRow = Grid.CurrentCell?.RowIndex ?? 0;
                Grid.Rows.Insert(curRow, 1);
                for (int j = 0; j < Grid.ColumnCount; j++)
                {
                    Grid[j, curRow].Value = String.Format(DBL_FORMAT, 0.0);
                }
            }
            else if (m > (int)UpDownRow.Value && m > MIN_ROWS_COLS)
            {
                int curRow = Grid.CurrentCell?.RowIndex ?? 0;
                Grid.Rows.RemoveAt(curRow);
            }
        }

        private void setColumnsWidth(int width)
        {
            for (int i = 0; i < Grid.Columns.Count; i++)
            {
                Grid.Columns[i].Width = width;
            }
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            try
            {
                Matrix model = getMatrix();
                int range = model.getMatrixRange();
                double det = model.getDeterminant();
                MessageBox.Show(" Визначник = " + det.ToString("F9"));
                MessageBox.Show(" Ранг = " + range);
            }
            catch (Exception)
            {
                MessageBox.Show("Проблеми з матрицею. Перевірте всі числа.");
            }
        }

        private void buttonFillRND_Click(object sender, EventArgs e)
        {
            int from = -10;
            int to = 20;
            int m = (int)UpDownRow.Value;
            int n = (int)UpDownCol.Value;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Grid[j, i].Value = String.Format(DBL_FORMAT, from + random.NextDouble() * (to - from));
                }
            }
        }

        private Matrix getMatrix()
        {
            int m = (int)UpDownRow.Value;
            int n = (int)UpDownCol.Value;
            Matrix model = new Matrix(m, n);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    model[i, j] = Convert.ToDouble(Grid[j, i].Value);
                }
            }

            return model;
        }

        private void showMatrix(Matrix model)
        {
            int m = model.getM();
            int n = model.getN();
            UpDownRow.Value = m;
            UpDownCol.Value = n;
            Grid.RowCount = m;
            Grid.ColumnCount = n;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Grid[j, i].Value = String.Format(DBL_FORMAT, model[i, j]);
                }
            }
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            int m = (int)UpDownRow.Value;
            int n = (int)UpDownCol.Value;
            if (m != n)
            {
                MessageBox.Show("Матриця має бути квадратною");
                return;
            }

            try
            {
                Matrix model = getMatrix();
                double det = model.getDeterminant();
                MessageBox.Show(" Визначник = " + det.ToString("F9"));
                if (det == 0)
                {
                    MessageBox.Show("Матриця є виродженою (визначник дорівнює нулю), тому вона не має оберненої.");
                    return;
                }
                Matrix InvertMatr = model.getInvertibleMatrixJordanGauss();
                showMatrix(InvertMatr);
                MessageBox.Show("На екрані показано обернену матрицю.");
            }
            catch (Exception)
            {
                MessageBox.Show("Проблеми з матрицею. Перевірте всі числа.");
            }
        }
        private void AddRow_Click(object sender, EventArgs e)
        {
            UpDownRow.Value++;
        }

        private void Reset()
        {
            for (int i = 0; i < Grid.RowCount; i++)
            {
                for (int j = 0; j < Grid.ColumnCount; j++)
                {
                    Grid[j, i].Value = String.Format(DBL_FORMAT, 0.0);
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void AddColumnAfter_Click(object sender, EventArgs e)
        {
            UpDownCol.Value++;
            int curCol = Grid.CurrentCell?.ColumnIndex ?? 0;
            for (int i = 0; i < Grid.RowCount; i++)
            {
                string tmp = (string)Grid[curCol, i].Value;
                Grid[curCol, i].Value = Grid[curCol + 1, i].Value;
                Grid[curCol + 1, i].Value = tmp;
            }
        }

        private void DelRow_Click(object sender, EventArgs e)
        {
            if (Grid.RowCount > MIN_ROWS_COLS)
            {
                UpDownRow.Value--;
            }
        }

        private void AddRowBelow_Click(object sender, EventArgs e)
        {
            UpDownRow.Value++;
            int curRow = Grid.CurrentCell?.RowIndex ?? 0;
            for (int j = 0; j < Grid.ColumnCount; j++)
            {
                string tmp = (string)Grid[j, curRow].Value;
                Grid[j, curRow].Value = Grid[j, curRow - 1].Value;
                Grid[j, curRow - 1].Value = tmp;
            }
        }

        private void AddColumn_Click(object sender, EventArgs e)
        {
            UpDownCol.Value++;
        }

        private void DelColumn_Click(object sender, EventArgs e)
        {
            if (Grid.ColumnCount > MIN_ROWS_COLS)
            {
                UpDownCol.Value--;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = saveFileDialog1.FileName;
            fileName = filename;
            Matrix model = getMatrix();

            if (model.saveToFile(filename))
            {
                MessageBox.Show("Матрицю збережено у файлі");
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fileName == "noname")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                fileName = saveFileDialog1.FileName;
            }

            Matrix model = getMatrix();

            if (model.saveToFile(fileName))
            {
                MessageBox.Show("Матрицю збережено у файлі");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string filename = openFileDialog1.FileName;
            Matrix model = new Matrix();
            if (model.loadFromFile(filename))
            {
                MessageBox.Show("Матрицю завантажено з файлу");
                showMatrix(model);
            }
        }

        private void Grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            const double MAX = 100000.0;
            const double MIN = -100000.0;

            if (Grid.CurrentCell == null) return;

            double val = 0;
            string cellValue = Grid.CurrentCell.Value.ToString();

            if (cellValue.Contains("."))
            {
                MessageBox.Show(cellValue + " <-- Число повинно використовувати кому, а не крапку.");
                Grid.CurrentCell.Value = String.Format(DBL_FORMAT, 0.0);
                return;
            }

            if (cellValue.StartsWith(","))
            {
                MessageBox.Show(cellValue + " <-- Число не може починатися з коми.");
                Grid.CurrentCell.Value = String.Format(DBL_FORMAT, 0.0);
                return;
            }

            try
            {
                val = Convert.ToDouble(cellValue);
            }
            catch
            {
                MessageBox.Show(cellValue + " <-- це не число.");
                Grid.CurrentCell.Value = String.Format(DBL_FORMAT, 0.0);
                return;
            }

            if (val > MAX)
            {
                MessageBox.Show(cellValue + " <-- Це число занадто велике.");
                Grid.CurrentCell.Value = String.Format(DBL_FORMAT, 0.0);
                return;
            }

            if (val < MIN)
            {
                MessageBox.Show(cellValue + " <-- Це число занадто маленьке.");
                Grid.CurrentCell.Value = String.Format(DBL_FORMAT, 0.0);
                return;
            }

            string s = cellValue;
            int pos_comma = s.IndexOf(',');
            if (pos_comma != -1)
            {
                s = s.Substring(pos_comma + 1);
                if (s.Length > NUM_OF_DIGITS)
                {
                    MessageBox.Show(cellValue + " <-- Занадто багато цифр після коми. Це буде зменшено.");
                    Grid.CurrentCell.Value = String.Format(DBL_FORMAT, val);
                    return;
                }
            }
        }

        //Обернена матриця за методом окаймлення.
        private void buttonTask3_Click(object sender, EventArgs e)
        {
            int m = (int)UpDownRow.Value;
            int n = (int)UpDownCol.Value;
            if (m != n)
            {
                MessageBox.Show("Матриця має бути квадратною");
                return;
            }

            try
            {
                Matrix model = getMatrix();
          
                if (model[0,0] == 0)
                {
                    MessageBox.Show("Проблема: нуль на діагоналі");
                    return;
                }


                double det = model.getDeterminant();
                MessageBox.Show(" Визначник = " + det.ToString("F9"));
                if (det == 0)
                {
                    MessageBox.Show("Матриця є виродженою (визначник дорівнює нулю), тому вона не має оберненої.");
                    return;
                }
                Matrix InvertMatr = model.getInvertibleMatrixOk();
                showMatrix(InvertMatr);
                MessageBox.Show("На екрані показано обернену матрицю.");
            }
            catch (Exception)
            {
                MessageBox.Show("Проблеми з матрицею. Перевірте всі числа.");
            }
        }
    }
}

 
