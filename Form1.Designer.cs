namespace A_kurs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UpDownRow = new NumericUpDown();
            UpDownCol = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            Grid = new DataGridView();
            buttonTask1 = new Button();
            buttonTask2 = new Button();
            buttonFillRND = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            FillRnd = new ToolStripMenuItem();
            AddRow = new ToolStripMenuItem();
            AddRowBelow = new ToolStripMenuItem();
            DelRow = new ToolStripMenuItem();
            AddColumn = new ToolStripMenuItem();
            AddColumnAfter = new ToolStripMenuItem();
            DelColumn = new ToolStripMenuItem();
            workToolStripMenuItem = new ToolStripMenuItem();
            CalcRangeOfMatrix = new ToolStripMenuItem();
            CalcInverseMatrix = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            buttonReset = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            richTextBox2 = new RichTextBox();
            label6 = new Label();
            richTextBox3 = new RichTextBox();
            buttonTask3 = new Button();
            ((System.ComponentModel.ISupportInitialize)UpDownRow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownCol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // UpDownRow
            // 
            UpDownRow.Location = new Point(240, 37);
            UpDownRow.Margin = new Padding(3, 4, 3, 4);
            UpDownRow.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownRow.Name = "UpDownRow";
            UpDownRow.ReadOnly = true;
            UpDownRow.Size = new Size(91, 27);
            UpDownRow.TabIndex = 0;
            UpDownRow.Value = new decimal(new int[] { 3, 0, 0, 0 });
            UpDownRow.ValueChanged += UpDownRow_ValueChanged;
            // 
            // UpDownCol
            // 
            UpDownCol.Location = new Point(240, 99);
            UpDownCol.Margin = new Padding(3, 4, 3, 4);
            UpDownCol.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UpDownCol.Name = "UpDownCol";
            UpDownCol.ReadOnly = true;
            UpDownCol.Size = new Size(91, 27);
            UpDownCol.TabIndex = 1;
            UpDownCol.Value = new decimal(new int[] { 3, 0, 0, 0 });
            UpDownCol.ValueChanged += UpDownCol_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 40);
            label1.Name = "label1";
            label1.Size = new Size(178, 20);
            label1.TabIndex = 2;
            label1.Text = "Кількість рядків матриці";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 100);
            label2.Name = "label2";
            label2.Size = new Size(209, 20);
            label2.TabIndex = 3;
            label2.Text = "Кількість стовпчиків матриці";
            // 
            // Grid
            // 
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid.ColumnHeadersVisible = false;
            Grid.Location = new Point(14, 136);
            Grid.Margin = new Padding(3, 4, 3, 4);
            Grid.Name = "Grid";
            Grid.RowHeadersVisible = false;
            Grid.RowHeadersWidth = 51;
            Grid.RowTemplate.Height = 25;
            Grid.Size = new Size(994, 443);
            Grid.TabIndex = 4;
            Grid.CellValueChanged += Grid_CellValueChanged;
            // 
            // buttonTask1
            // 
            buttonTask1.Location = new Point(350, 40);
            buttonTask1.Margin = new Padding(3, 4, 3, 4);
            buttonTask1.Name = "buttonTask1";
            buttonTask1.Size = new Size(220, 31);
            buttonTask1.TabIndex = 7;
            buttonTask1.Text = "Знайти ранг і визначник";
            buttonTask1.UseVisualStyleBackColor = true;
            buttonTask1.Click += buttonTask1_Click;
            // 
            // buttonTask2
            // 
            buttonTask2.Location = new Point(350, 95);
            buttonTask2.Margin = new Padding(3, 4, 3, 4);
            buttonTask2.Name = "buttonTask2";
            buttonTask2.Size = new Size(329, 31);
            buttonTask2.TabIndex = 8;
            buttonTask2.Text = "Обернена матриця (Метод Жордана-Гауса)";
            buttonTask2.UseVisualStyleBackColor = true;
            buttonTask2.Click += buttonTask2_Click;
            // 
            // buttonFillRND
            // 
            buttonFillRND.Location = new Point(576, 40);
            buttonFillRND.Margin = new Padding(3, 4, 3, 4);
            buttonFillRND.Name = "buttonFillRND";
            buttonFillRND.Size = new Size(220, 31);
            buttonFillRND.TabIndex = 9;
            buttonFillRND.Text = "Заповнити випадковими числами";
            buttonFillRND.UseVisualStyleBackColor = true;
            buttonFillRND.Click += buttonFillRND_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, workToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1022, 30);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 24);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(174, 26);
            newToolStripMenuItem.Text = "Новий";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(174, 26);
            openToolStripMenuItem.Text = "Відкрити";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(174, 26);
            saveToolStripMenuItem.Text = "Зберегти";
            saveToolStripMenuItem.Click += saveToolStripMenuItem1_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(174, 26);
            saveAsToolStripMenuItem.Text = "Зберегти як";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(171, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(174, 26);
            exitToolStripMenuItem.Text = "Вийти";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FillRnd, AddRow, AddRowBelow, DelRow, AddColumn, AddColumnAfter, DelColumn });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(79, 24);
            editToolStripMenuItem.Text = "Змінити";
            // 
            // FillRnd
            // 
            FillRnd.Name = "FillRnd";
            FillRnd.Size = new Size(330, 26);
            FillRnd.Text = "Заповнити випадковими числами";
            FillRnd.Click += buttonFillRND_Click;
            // 
            // AddRow
            // 
            AddRow.Name = "AddRow";
            AddRow.Size = new Size(330, 26);
            AddRow.Text = "Додати рядок вище";
            AddRow.Click += AddRow_Click;
            // 
            // AddRowBelow
            // 
            AddRowBelow.Name = "AddRowBelow";
            AddRowBelow.Size = new Size(330, 26);
            AddRowBelow.Text = "Додати рядок нижче";
            AddRowBelow.Click += AddRowBelow_Click;
            // 
            // DelRow
            // 
            DelRow.Name = "DelRow";
            DelRow.Size = new Size(330, 26);
            DelRow.Text = "Прибрати рядок";
            DelRow.Click += DelRow_Click;
            // 
            // AddColumn
            // 
            AddColumn.Name = "AddColumn";
            AddColumn.Size = new Size(330, 26);
            AddColumn.Text = "Додати стовпчик перед";
            AddColumn.Click += AddColumn_Click;
            // 
            // AddColumnAfter
            // 
            AddColumnAfter.Name = "AddColumnAfter";
            AddColumnAfter.Size = new Size(330, 26);
            AddColumnAfter.Text = "Додати стовпчик після";
            AddColumnAfter.Click += AddColumnAfter_Click;
            // 
            // DelColumn
            // 
            DelColumn.Name = "DelColumn";
            DelColumn.Size = new Size(330, 26);
            DelColumn.Text = "Прибрати стовпчик";
            DelColumn.Click += DelColumn_Click;
            // 
            // workToolStripMenuItem
            // 
            workToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CalcRangeOfMatrix, CalcInverseMatrix });
            workToolStripMenuItem.Name = "workToolStripMenuItem";
            workToolStripMenuItem.Size = new Size(72, 24);
            workToolStripMenuItem.Text = "Робота";
            // 
            // CalcRangeOfMatrix
            // 
            CalcRangeOfMatrix.Name = "CalcRangeOfMatrix";
            CalcRangeOfMatrix.Size = new Size(281, 26);
            CalcRangeOfMatrix.Text = "Знайти ранг матриці";
            CalcRangeOfMatrix.Click += buttonTask1_Click;
            // 
            // CalcInverseMatrix
            // 
            CalcInverseMatrix.Name = "CalcInverseMatrix";
            CalcInverseMatrix.Size = new Size(281, 26);
            CalcInverseMatrix.Text = "Знайти обернену матрицю";
            CalcInverseMatrix.Click += buttonTask2_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(94, 24);
            helpToolStripMenuItem.Text = "Допомога";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(193, 26);
            aboutToolStripMenuItem.Text = "Про програму";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(802, 40);
            buttonReset.Margin = new Padding(3, 4, 3, 4);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(220, 31);
            buttonReset.TabIndex = 11;
            buttonReset.Text = "Заповнити нулями";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(337, 656);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(342, 188);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "Числа повинні вводитись з використанням коми, а не крапки як десяткового роздільника.\nЧисла не можуть починатися з коми.\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 595);
            label3.Name = "label3";
            label3.Size = new Size(205, 26);
            label3.TabIndex = 13;
            label3.Text = "Пам'ятай правила:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(14, 625);
            label4.Name = "label4";
            label4.Size = new Size(170, 28);
            label4.TabIndex = 14;
            label4.Text = "Введення чисел:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(395, 625);
            label5.Name = "label5";
            label5.Size = new Size(190, 28);
            label5.TabIndex = 15;
            label5.Text = "Межі вводу чисел:";
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(0, 656);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(331, 188);
            richTextBox2.TabIndex = 16;
            richTextBox2.Text = "Числа повинні знаходитись у межах від -100000 до 100000.\nЧисла занадто великі або занадто маленькі будуть автоматично обмежені до цих значень.\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(760, 625);
            label6.Name = "label6";
            label6.Size = new Size(212, 28);
            label6.TabIndex = 17;
            label6.Text = "Робота з матрицями:";
            // 
            // richTextBox3
            // 
            richTextBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.Location = new Point(685, 656);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(337, 187);
            richTextBox3.TabIndex = 18;
            richTextBox3.Text = "Матриці повинні бути квадратними для знаходження обернених.\nМаксимальний розмір матриці - 15x15;\nМінімальний - 2x2.";
            // 
            // buttonTask3
            // 
            buttonTask3.Location = new Point(685, 95);
            buttonTask3.Margin = new Padding(3, 4, 3, 4);
            buttonTask3.Name = "buttonTask3";
            buttonTask3.Size = new Size(323, 31);
            buttonTask3.TabIndex = 19;
            buttonTask3.Text = "Обернена матриця (Метод окаймлення)";
            buttonTask3.UseVisualStyleBackColor = true;
            buttonTask3.Click += buttonTask3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 861);
            Controls.Add(buttonTask3);
            Controls.Add(richTextBox3);
            Controls.Add(label6);
            Controls.Add(richTextBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(buttonReset);
            Controls.Add(buttonFillRND);
            Controls.Add(buttonTask2);
            Controls.Add(buttonTask1);
            Controls.Add(Grid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UpDownCol);
            Controls.Add(UpDownRow);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Курсова робота - Литовченко Ангеліна";
            ((System.ComponentModel.ISupportInitialize)UpDownRow).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownCol).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown UpDownRow;
        private NumericUpDown UpDownCol;
        private Label label1;
        private Label label2;
        private DataGridView Grid;
        private Button buttonTask1;
        private Button buttonTask2;
        private Button buttonFillRND;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem FillRnd;
        private ToolStripMenuItem AddRow;
        private ToolStripMenuItem DelRow;
        private ToolStripMenuItem workToolStripMenuItem;
        private ToolStripMenuItem CalcRangeOfMatrix;
        private ToolStripMenuItem CalcInverseMatrix;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem AddColumn;
        private ToolStripMenuItem DelColumn;
        private Button buttonReset;
        private ToolStripMenuItem AddRowBelow;
        private ToolStripMenuItem AddColumnAfter;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private RichTextBox richTextBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox richTextBox2;
        private Label label6;
        private RichTextBox richTextBox3;
        private Button buttonTask3;
    }
}