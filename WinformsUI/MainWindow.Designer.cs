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
            this.listView = new System.Windows.Forms.ListView();
            this.makeCollectionsTestButton = new System.Windows.Forms.Button();
            this.openObjsWindow = new System.Windows.Forms.Button();
            this.clearLogButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.getInheritedExceptionButton = new System.Windows.Forms.Button();
            this.getClassInfoButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.outputLog.ReadOnly = true;
            this.outputLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputLog.Size = new System.Drawing.Size(449, 481);
            this.outputLog.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView);
            this.groupBox2.Controls.Add(this.makeCollectionsTestButton);
            this.groupBox2.Controls.Add(this.openObjsWindow);
            this.groupBox2.Controls.Add(this.clearLogButton);
            this.groupBox2.Controls.Add(this.exitButton);
            this.groupBox2.Controls.Add(this.getInheritedExceptionButton);
            this.groupBox2.Controls.Add(this.getClassInfoButton);
            this.groupBox2.Location = new System.Drawing.Point(479, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 499);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Функционал";
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(17, 239);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(408, 154);
            this.listView.TabIndex = 22;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Tile;
            // 
            // makeCollectionsTestButton
            // 
            this.makeCollectionsTestButton.Location = new System.Drawing.Point(17, 167);
            this.makeCollectionsTestButton.Name = "makeCollectionsTestButton";
            this.makeCollectionsTestButton.Size = new System.Drawing.Size(195, 34);
            this.makeCollectionsTestButton.TabIndex = 21;
            this.makeCollectionsTestButton.Text = "Провести тест коллекций";
            this.makeCollectionsTestButton.UseVisualStyleBackColor = true;
            this.makeCollectionsTestButton.Click += new System.EventHandler(this.makeCollectionsTestButton_Click);
            // 
            // openObjsWindow
            // 
            this.openObjsWindow.Location = new System.Drawing.Point(17, 65);
            this.openObjsWindow.Name = "openObjsWindow";
            this.openObjsWindow.Size = new System.Drawing.Size(195, 34);
            this.openObjsWindow.TabIndex = 20;
            this.openObjsWindow.Text = "Управление объектами";
            this.openObjsWindow.UseVisualStyleBackColor = true;
            this.openObjsWindow.Click += new System.EventHandler(this.openObjsWindow_Click);
            // 
            // clearLogButton
            // 
            this.clearLogButton.Location = new System.Drawing.Point(234, 65);
            this.clearLogButton.Name = "clearLogButton";
            this.clearLogButton.Size = new System.Drawing.Size(191, 34);
            this.clearLogButton.TabIndex = 19;
            this.clearLogButton.Text = "Очистить окно вывода";
            this.clearLogButton.UseVisualStyleBackColor = true;
            this.clearLogButton.Click += new System.EventHandler(this.clearLogButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(237, 459);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(186, 34);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // getInheritedExceptionButton
            // 
            this.getInheritedExceptionButton.Location = new System.Drawing.Point(232, 22);
            this.getInheritedExceptionButton.Name = "getInheritedExceptionButton";
            this.getInheritedExceptionButton.Size = new System.Drawing.Size(193, 37);
            this.getInheritedExceptionButton.TabIndex = 1;
            this.getInheritedExceptionButton.Text = "Получить ошибку";
            this.getInheritedExceptionButton.UseVisualStyleBackColor = true;
            this.getInheritedExceptionButton.Click += new System.EventHandler(this.getInheritedExceptionButton_Click);
            // 
            // getClassInfoButton
            // 
            this.getClassInfoButton.Location = new System.Drawing.Point(17, 22);
            this.getClassInfoButton.Name = "getClassInfoButton";
            this.getClassInfoButton.Size = new System.Drawing.Size(195, 37);
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
            this.Text = "Лабораторная работа 2 Левин Семичев (главное окно)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox outputLog;
        private GroupBox groupBox2;
        private Button getClassInfoButton;
        private Button getInheritedExceptionButton;
        private Button clearLogButton;
        private Button exitButton;
        private Button openObjsWindow;
        private Button makeCollectionsTestButton;
        private ListView listView;
    }
}