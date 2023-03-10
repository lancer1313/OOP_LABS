using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinformsUI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void getClassInfoButton_Click(object sender, EventArgs e)
        {
            Utils.FillOutputLog(Library.GetClassInfo(), outputLog);
        }

        private void getInheritedExceptionButton_Click(object sender, EventArgs e)
        {
            try
            {
                GetStackOverflowException();
            }
            catch(StackOverflowException ex)
            {
                Utils.MessageBox(IntPtr.Zero, ex.Message, "Ошибка", 0);
            }
        }
        
        private void GetStackOverflowException()
        {
            throw new StackOverflowException("Ты вызвал бесконечную рекурсию, пользователь");
        }

        private void clearLogButton_Click(object sender, EventArgs e)
        {
            outputLog.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openObjsWindow_Click(object sender, EventArgs e)
        {
            ObjectsManipulatorWindow objsWindow = new ObjectsManipulatorWindow();
            objsWindow.Show();
        }

        private void makeCollectionsTestButton_Click(object sender, EventArgs e)
        {
            int startTimeDictionary = Environment.TickCount;
            Dictionary<int, Library> map = new Dictionary<int, Library>();
            for (int i = 0; i < 100000; i++)
            {
                map.Add(i, new Library());
            }
            int timeDictionary = Environment.TickCount - startTimeDictionary;

            int startTimeArray = Environment.TickCount;
            Library[] libraries = new Library[100000];
            for (int i = 0; i < 100000; i++)
            {
                libraries[i] = new Library();   
            }
            int timeArray = Environment.TickCount - startTimeArray;

            listView.Items.Add($"Количество тиков создание и заполнение Dictionary: {timeDictionary}", 0);
            listView.Items.Add($"Количесвто тиков создание и заполнение Array: {timeArray}", 1);
        }
    }
}
