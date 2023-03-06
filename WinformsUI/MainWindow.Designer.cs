namespace WinformsUI
{
    partial class MainWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputLog = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.getAllObjsButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.withWiFiCheckBox = new System.Windows.Forms.CheckBox();
            this.createObjButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.newObjRating = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.newObjType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.newObjReadingRooms = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.newObjBooksNumber = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.newObjDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.newObjName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.inHexCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.printPropertyName = new System.Windows.Forms.TextBox();
            this.printPropertyButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.printPropertyID = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.changePropertyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.changePropertyValue = new System.Windows.Forms.TextBox();
            this.changePropertyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.changePropertyID = new System.Windows.Forms.TextBox();
            this.getInheritedExceptionButton = new System.Windows.Forms.Button();
            this.getClassInfoButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newObjRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newObjReadingRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newObjBooksNumber)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputLog);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 509);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Окно вывода";
            // 
            // outputLog
            // 
            this.outputLog.Location = new System.Drawing.Point(6, 22);
            this.outputLog.Multiline = true;
            this.outputLog.Name = "outputLog";
            this.outputLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputLog.Size = new System.Drawing.Size(449, 481);
            this.outputLog.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearLogButton);
            this.groupBox2.Controls.Add(this.exitButton);
            this.groupBox2.Controls.Add(this.getAllObjsButton);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.getInheritedExceptionButton);
            this.groupBox2.Controls.Add(this.getClassInfoButton);
            this.groupBox2.Location = new System.Drawing.Point(479, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 499);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Функционал";
            // 
            // clearLogButton
            // 
            this.clearLogButton.Location = new System.Drawing.Point(196, 111);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(175, 34);
            this.clearLogButton.TabIndex = 19;
            this.clearLogButton.Text = "Очистить окно вывода";
            this.clearLogButton.UseVisualStyleBackColor = true;
            this.clearLogButton.Click += new System.EventHandler(this.clearLogButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(336, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 35);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // getAllObjsButton
            // 
            this.getAllObjsButton.Location = new System.Drawing.Point(6, 111);
            this.getAllObjsButton.Name = "getAllObjsButton";
            this.getAllObjsButton.Size = new System.Drawing.Size(184, 34);
            this.getAllObjsButton.TabIndex = 17;
            this.getAllObjsButton.Text = "Вывести все объекты";
            this.getAllObjsButton.UseVisualStyleBackColor = true;
            this.getAllObjsButton.Click += new System.EventHandler(this.getAllObjsButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.withWiFiCheckBox);
            this.groupBox5.Controls.Add(this.createObjButton);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.newObjRating);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.newObjType);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.newObjReadingRooms);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.newObjBooksNumber);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.newObjDescription);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.newObjName);
            this.groupBox5.Location = new System.Drawing.Point(6, 329);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(425, 164);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Новый объект";
            // 
            // withWiFiCheckBox
            // 
            this.withWiFiCheckBox.AutoSize = true;
            this.withWiFiCheckBox.Location = new System.Drawing.Point(12, 125);
            this.withWiFiCheckBox.Name = "withWiFiCheckBox";
            this.withWiFiCheckBox.Size = new System.Drawing.Size(75, 19);
            this.withWiFiCheckBox.TabIndex = 14;
            this.withWiFiCheckBox.Text = "Есть WiFi";
            this.withWiFiCheckBox.UseVisualStyleBackColor = true;
            // 
            // createObjButton
            // 
            this.createObjButton.Location = new System.Drawing.Point(177, 125);
            this.createObjButton.Name = "createObjButton";
            this.createObjButton.Size = new System.Drawing.Size(113, 30);
            this.createObjButton.TabIndex = 13;
            this.createObjButton.Text = "Создать объект";
            this.createObjButton.UseVisualStyleBackColor = true;
            this.createObjButton.Click += new System.EventHandler(this.createObjButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(179, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Рейтинг";
            // 
            // newObjRating
            // 
            this.newObjRating.DecimalPlaces = 1;
            this.newObjRating.Location = new System.Drawing.Point(293, 90);
            this.newObjRating.Name = "newObjRating";
            this.newObjRating.Size = new System.Drawing.Size(120, 23);
            this.newObjRating.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Тип";
            // 
            // newObjType
            // 
            this.newObjType.Location = new System.Drawing.Point(73, 87);
            this.newObjType.Name = "newObjType";
            this.newObjType.Size = new System.Drawing.Size(100, 23);
            this.newObjType.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Читальных комнат";
            // 
            // newObjReadingRooms
            // 
            this.newObjReadingRooms.Location = new System.Drawing.Point(293, 59);
            this.newObjReadingRooms.Name = "newObjReadingRooms";
            this.newObjReadingRooms.Size = new System.Drawing.Size(120, 23);
            this.newObjReadingRooms.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Количество книг";
            // 
            // newObjBooksNumber
            // 
            this.newObjBooksNumber.Location = new System.Drawing.Point(293, 29);
            this.newObjBooksNumber.Name = "newObjBooksNumber";
            this.newObjBooksNumber.Size = new System.Drawing.Size(120, 23);
            this.newObjBooksNumber.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Описание";
            // 
            // newObjDescription
            // 
            this.newObjDescription.Location = new System.Drawing.Point(73, 58);
            this.newObjDescription.Name = "newObjDescription";
            this.newObjDescription.Size = new System.Drawing.Size(100, 23);
            this.newObjDescription.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Название";
            // 
            // newObjName
            // 
            this.newObjName.Location = new System.Drawing.Point(73, 29);
            this.newObjName.Name = "newObjName";
            this.newObjName.Size = new System.Drawing.Size(100, 23);
            this.newObjName.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.inHexCheckBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.printPropertyName);
            this.groupBox4.Controls.Add(this.printPropertyButton);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.printPropertyID);
            this.groupBox4.Location = new System.Drawing.Point(6, 248);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(419, 75);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вывести свойство на экран";
            // 
            // inHexCheckBox
            // 
            this.inHexCheckBox.AutoSize = true;
            this.inHexCheckBox.Location = new System.Drawing.Point(214, 38);
            this.inHexCheckBox.Name = "inHexCheckBox";
            this.inHexCheckBox.Size = new System.Drawing.Size(96, 19);
            this.inHexCheckBox.TabIndex = 15;
            this.inHexCheckBox.Text = "В 16 системе";
            this.inHexCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Название свойства";
            // 
            // printPropertyName
            // 
            this.printPropertyName.Location = new System.Drawing.Point(93, 37);
            this.printPropertyName.Name = "printPropertyName";
            this.printPropertyName.Size = new System.Drawing.Size(111, 23);
            this.printPropertyName.TabIndex = 9;
            // 
            // printPropertyButton
            // 
            this.printPropertyButton.Location = new System.Drawing.Point(330, 36);
            this.printPropertyButton.Name = "printPropertyButton";
            this.printPropertyButton.Size = new System.Drawing.Size(83, 21);
            this.printPropertyButton.TabIndex = 13;
            this.printPropertyButton.Text = "Вывести";
            this.printPropertyButton.UseVisualStyleBackColor = true;
            this.printPropertyButton.Click += new System.EventHandler(this.printPropertyButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID объекта";
            // 
            // printPropertyID
            // 
            this.printPropertyID.Location = new System.Drawing.Point(8, 37);
            this.printPropertyID.Name = "printPropertyID";
            this.printPropertyID.Size = new System.Drawing.Size(79, 23);
            this.printPropertyID.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.changePropertyName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.changePropertyValue);
            this.groupBox3.Controls.Add(this.changePropertyButton);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.changePropertyID);
            this.groupBox3.Location = new System.Drawing.Point(6, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 79);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Изменить значение свойства";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название свойства";
            // 
            // changePropertyName
            // 
            this.changePropertyName.Location = new System.Drawing.Point(93, 37);
            this.changePropertyName.Name = "changePropertyName";
            this.changePropertyName.Size = new System.Drawing.Size(111, 23);
            this.changePropertyName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Новое значение";
            // 
            // changePropertyValue
            // 
            this.changePropertyValue.Location = new System.Drawing.Point(210, 37);
            this.changePropertyValue.Name = "changePropertyValue";
            this.changePropertyValue.Size = new System.Drawing.Size(100, 23);
            this.changePropertyValue.TabIndex = 5;
            // 
            // changePropertyButton
            // 
            this.changePropertyButton.Location = new System.Drawing.Point(330, 37);
            this.changePropertyButton.Name = "changePropertyButton";
            this.changePropertyButton.Size = new System.Drawing.Size(83, 23);
            this.changePropertyButton.TabIndex = 6;
            this.changePropertyButton.Text = "Изменить";
            this.changePropertyButton.UseVisualStyleBackColor = true;
            this.changePropertyButton.Click += new System.EventHandler(this.changePropertyButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID объекта";
            // 
            // changePropertyID
            // 
            this.changePropertyID.Location = new System.Drawing.Point(8, 37);
            this.changePropertyID.Name = "changePropertyID";
            this.changePropertyID.Size = new System.Drawing.Size(79, 23);
            this.changePropertyID.TabIndex = 8;
            // 
            // getInheritedExceptionButton
            // 
            this.getInheritedExceptionButton.Location = new System.Drawing.Point(196, 68);
            this.getInheritedExceptionButton.Name = "getInheritedExceptionButton";
            this.getInheritedExceptionButton.Size = new System.Drawing.Size(120, 37);
            this.getInheritedExceptionButton.TabIndex = 1;
            this.getInheritedExceptionButton.Text = "Получить ошибку";
            this.getInheritedExceptionButton.UseVisualStyleBackColor = true;
            this.getInheritedExceptionButton.Click += new System.EventHandler(this.getInheritedExceptionButton_Click);
            // 
            // getClassInfoButton
            // 
            this.getClassInfoButton.Location = new System.Drawing.Point(6, 68);
            this.getClassInfoButton.Name = "getClassInfoButton";
            this.getClassInfoButton.Size = new System.Drawing.Size(184, 37);
            this.getClassInfoButton.TabIndex = 0;
            this.getClassInfoButton.Text = "Вывести содержимое класса";
            this.getClassInfoButton.UseVisualStyleBackColor = true;
            this.getClassInfoButton.Click += new System.EventHandler(this.getClassInfoButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 533);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newObjRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newObjReadingRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newObjBooksNumber)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox outputLog;
        private GroupBox groupBox2;
        private Button getClassInfoButton;
        private Button getInheritedExceptionButton;
        private GroupBox groupBox5;
        private TextBox newObjDescription;
        private Label label6;
        private TextBox newObjName;
        private GroupBox groupBox4;
        private Label label5;
        private TextBox printPropertyName;
        private Button printPropertyButton;
        private Label label4;
        private TextBox printPropertyID;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox changePropertyName;
        private Label label2;
        private TextBox changePropertyValue;
        private Button changePropertyButton;
        private Label label3;
        private TextBox changePropertyID;
        private Label label9;
        private NumericUpDown newObjReadingRooms;
        private Label label8;
        private NumericUpDown newObjBooksNumber;
        private Label label7;
        private Label label10;
        private TextBox newObjType;
        private Button clearLogButton;
        private Button exitButton;
        private Button getAllObjsButton;
        private Button createObjButton;
        private Label label11;
        private NumericUpDown newObjRating;
        private CheckBox withWiFiCheckBox;
        private CheckBox inHexCheckBox;
    }
}