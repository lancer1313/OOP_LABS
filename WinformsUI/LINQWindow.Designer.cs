namespace WinformsUI
{
    partial class LINQWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.consoleLog = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.Консоль = new System.Windows.Forms.GroupBox();
            this.clearConsoleButton = new System.Windows.Forms.Button();
            this.writeToFileLibCollectionButton = new System.Windows.Forms.Button();
            this.sortLibCollectionButton = new System.Windows.Forms.Button();
            this.libCollectionLINQButton = new System.Windows.Forms.Button();
            this.showLibCollectionButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stringLengthTextBox = new System.Windows.Forms.NumericUpDown();
            this.executeArrayCollectionOperationsButton = new System.Windows.Forms.Button();
            this.collectionLengthTextBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.arrayLengthTextBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toLengthTextBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchValueTextBox = new System.Windows.Forms.TextBox();
            this.fromLengthTextBox = new System.Windows.Forms.NumericUpDown();
            this.createCollectionArrayButton = new System.Windows.Forms.Button();
            this.showColArrayButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Консоль.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stringLengthTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionLengthTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrayLengthTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toLengthTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromLengthTextBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // consoleLog
            // 
            this.consoleLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleLog.Location = new System.Drawing.Point(8, 22);
            this.consoleLog.Multiline = true;
            this.consoleLog.Name = "consoleLog";
            this.consoleLog.ReadOnly = true;
            this.consoleLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.consoleLog.Size = new System.Drawing.Size(394, 433);
            this.consoleLog.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(318, 49);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 32);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Консоль
            // 
            this.Консоль.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Консоль.Controls.Add(this.consoleLog);
            this.Консоль.Location = new System.Drawing.Point(12, 12);
            this.Консоль.Name = "Консоль";
            this.Консоль.Size = new System.Drawing.Size(408, 472);
            this.Консоль.TabIndex = 2;
            this.Консоль.TabStop = false;
            this.Консоль.Text = "Консоль";
            // 
            // clearConsoleButton
            // 
            this.clearConsoleButton.Location = new System.Drawing.Point(6, 49);
            this.clearConsoleButton.Name = "clearConsoleButton";
            this.clearConsoleButton.Size = new System.Drawing.Size(196, 32);
            this.clearConsoleButton.TabIndex = 3;
            this.clearConsoleButton.Text = "Очистить консоль";
            this.clearConsoleButton.UseVisualStyleBackColor = true;
            this.clearConsoleButton.Click += new System.EventHandler(this.clearConsoleButton_Click);
            // 
            // writeToFileLibCollectionButton
            // 
            this.writeToFileLibCollectionButton.Location = new System.Drawing.Point(213, 60);
            this.writeToFileLibCollectionButton.Name = "writeToFileLibCollectionButton";
            this.writeToFileLibCollectionButton.Size = new System.Drawing.Size(196, 32);
            this.writeToFileLibCollectionButton.TabIndex = 4;
            this.writeToFileLibCollectionButton.Text = "Сохранить в файл";
            this.writeToFileLibCollectionButton.UseVisualStyleBackColor = true;
            this.writeToFileLibCollectionButton.Click += new System.EventHandler(this.writeToFileLibCollectionButton_Click);
            // 
            // sortLibCollectionButton
            // 
            this.sortLibCollectionButton.Location = new System.Drawing.Point(6, 60);
            this.sortLibCollectionButton.Name = "sortLibCollectionButton";
            this.sortLibCollectionButton.Size = new System.Drawing.Size(196, 32);
            this.sortLibCollectionButton.TabIndex = 5;
            this.sortLibCollectionButton.Text = "Отсортировать";
            this.sortLibCollectionButton.UseVisualStyleBackColor = true;
            this.sortLibCollectionButton.Click += new System.EventHandler(this.sortLibCollectionButton_Click);
            // 
            // libCollectionLINQButton
            // 
            this.libCollectionLINQButton.Location = new System.Drawing.Point(213, 22);
            this.libCollectionLINQButton.Name = "libCollectionLINQButton";
            this.libCollectionLINQButton.Size = new System.Drawing.Size(196, 32);
            this.libCollectionLINQButton.TabIndex = 6;
            this.libCollectionLINQButton.Text = "Выполнить LINQ запросы";
            this.libCollectionLINQButton.UseVisualStyleBackColor = true;
            this.libCollectionLINQButton.Click += new System.EventHandler(this.libCollectionLINQButton_Click);
            // 
            // showLibCollectionButton
            // 
            this.showLibCollectionButton.Location = new System.Drawing.Point(6, 22);
            this.showLibCollectionButton.Name = "showLibCollectionButton";
            this.showLibCollectionButton.Size = new System.Drawing.Size(196, 32);
            this.showLibCollectionButton.TabIndex = 7;
            this.showLibCollectionButton.Text = "Вывести коллекцию библиотек";
            this.showLibCollectionButton.UseVisualStyleBackColor = true;
            this.showLibCollectionButton.Click += new System.EventHandler(this.showLibCollectionButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.showLibCollectionButton);
            this.groupBox1.Controls.Add(this.sortLibCollectionButton);
            this.groupBox1.Controls.Add(this.libCollectionLINQButton);
            this.groupBox1.Controls.Add(this.writeToFileLibCollectionButton);
            this.groupBox1.Location = new System.Drawing.Point(439, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 108);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Коллекция объектов библиотеки";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.stringLengthTextBox);
            this.groupBox2.Controls.Add(this.executeArrayCollectionOperationsButton);
            this.groupBox2.Controls.Add(this.collectionLengthTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.arrayLengthTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.toLengthTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.searchValueTextBox);
            this.groupBox2.Controls.Add(this.fromLengthTextBox);
            this.groupBox2.Controls.Add(this.createCollectionArrayButton);
            this.groupBox2.Controls.Add(this.showColArrayButton);
            this.groupBox2.Location = new System.Drawing.Point(439, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 255);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Массив объектов LinkedList<string>";
            // 
            // stringLengthTextBox
            // 
            this.stringLengthTextBox.Location = new System.Drawing.Point(233, 174);
            this.stringLengthTextBox.Name = "stringLengthTextBox";
            this.stringLengthTextBox.Size = new System.Drawing.Size(120, 23);
            this.stringLengthTextBox.TabIndex = 16;
            // 
            // executeArrayCollectionOperationsButton
            // 
            this.executeArrayCollectionOperationsButton.Location = new System.Drawing.Point(6, 205);
            this.executeArrayCollectionOperationsButton.Name = "executeArrayCollectionOperationsButton";
            this.executeArrayCollectionOperationsButton.Size = new System.Drawing.Size(196, 32);
            this.executeArrayCollectionOperationsButton.TabIndex = 10;
            this.executeArrayCollectionOperationsButton.Text = "Выполнить все операции";
            this.executeArrayCollectionOperationsButton.UseVisualStyleBackColor = true;
            this.executeArrayCollectionOperationsButton.Click += new System.EventHandler(this.executeArrayCollectionOperationsButton_Click);
            // 
            // collectionLengthTextBox
            // 
            this.collectionLengthTextBox.Location = new System.Drawing.Point(117, 77);
            this.collectionLengthTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.collectionLengthTextBox.Name = "collectionLengthTextBox";
            this.collectionLengthTextBox.Size = new System.Drawing.Size(57, 23);
            this.collectionLengthTextBox.TabIndex = 19;
            this.collectionLengthTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Длина коллекции";
            // 
            // arrayLengthTextBox
            // 
            this.arrayLengthTextBox.Location = new System.Drawing.Point(117, 49);
            this.arrayLengthTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.arrayLengthTextBox.Name = "arrayLengthTextBox";
            this.arrayLengthTextBox.Size = new System.Drawing.Size(57, 23);
            this.arrayLengthTextBox.TabIndex = 17;
            this.arrayLengthTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Длина массива";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Количество строк длины n: введите n";
            // 
            // toLengthTextBox
            // 
            this.toLengthTextBox.Location = new System.Drawing.Point(213, 22);
            this.toLengthTextBox.Name = "toLengthTextBox";
            this.toLengthTextBox.Size = new System.Drawing.Size(57, 23);
            this.toLengthTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Поиск строк: введите значение поиска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "до";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Длина строки от";
            // 
            // searchValueTextBox
            // 
            this.searchValueTextBox.Location = new System.Drawing.Point(233, 144);
            this.searchValueTextBox.Name = "searchValueTextBox";
            this.searchValueTextBox.Size = new System.Drawing.Size(120, 23);
            this.searchValueTextBox.TabIndex = 12;
            // 
            // fromLengthTextBox
            // 
            this.fromLengthTextBox.Location = new System.Drawing.Point(117, 22);
            this.fromLengthTextBox.Name = "fromLengthTextBox";
            this.fromLengthTextBox.Size = new System.Drawing.Size(57, 23);
            this.fromLengthTextBox.TabIndex = 12;
            // 
            // createCollectionArrayButton
            // 
            this.createCollectionArrayButton.Location = new System.Drawing.Point(213, 51);
            this.createCollectionArrayButton.Name = "createCollectionArrayButton";
            this.createCollectionArrayButton.Size = new System.Drawing.Size(196, 32);
            this.createCollectionArrayButton.TabIndex = 0;
            this.createCollectionArrayButton.Text = "Создать массив коллекций";
            this.createCollectionArrayButton.UseVisualStyleBackColor = true;
            this.createCollectionArrayButton.Click += new System.EventHandler(this.createCollectionArrayButton_Click);
            // 
            // showColArrayButton
            // 
            this.showColArrayButton.Location = new System.Drawing.Point(213, 89);
            this.showColArrayButton.Name = "showColArrayButton";
            this.showColArrayButton.Size = new System.Drawing.Size(196, 32);
            this.showColArrayButton.TabIndex = 11;
            this.showColArrayButton.Text = "Вывести массив коллекций";
            this.showColArrayButton.UseVisualStyleBackColor = true;
            this.showColArrayButton.Click += new System.EventHandler(this.showColArrayButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.clearConsoleButton);
            this.groupBox3.Controls.Add(this.exitButton);
            this.groupBox3.Location = new System.Drawing.Point(439, 397);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 87);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Разное";
            // 
            // LINQWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Консоль);
            this.Name = "LINQWindow";
            this.Text = "LINQWindow";
            this.Консоль.ResumeLayout(false);
            this.Консоль.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stringLengthTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionLengthTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrayLengthTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toLengthTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromLengthTextBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox consoleLog;
        private Button exitButton;
        private GroupBox Консоль;
        private Button clearConsoleButton;
        private Button writeToFileLibCollectionButton;
        private Button sortLibCollectionButton;
        private Button libCollectionLINQButton;
        private Button showLibCollectionButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button executeArrayCollectionOperationsButton;
        private Button createCollectionArrayButton;
        private Button showColArrayButton;
        private Label label2;
        private Label label1;
        private TextBox searchValueTextBox;
        private NumericUpDown stringLengthTextBox;
        private NumericUpDown collectionLengthTextBox;
        private Label label6;
        private NumericUpDown arrayLengthTextBox;
        private Label label5;
        private NumericUpDown toLengthTextBox;
        private Label label4;
        private Label label3;
        private NumericUpDown fromLengthTextBox;
        private GroupBox groupBox3;
    }
}