using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            listView.Items.Clear();

            PerformanceTests performanceTests = new PerformanceTests();
            var timer = new Stopwatch();

            timer.Start();
            performanceTests.CreateDictionary();
            timer.Stop();
            listView.Items.Add($"Количество тиков создание и заполнение Dictionary: {timer.Elapsed.ToString(@"m\:ss\.fff")}", 0);

            timer.Start();
            performanceTests.CreateArray();
            timer.Stop();
            listView.Items.Add($"Количесвто тиков создание и заполнение Array: {timer.Elapsed.ToString(@"m\:ss\.fff")}", 1);

            timer.Start();
            performanceTests.TakeFromDictionaryInOrder();
            timer.Stop();
            listView.Items.Add($"Количество тиков выборка по порядку Dictionary: {timer.Elapsed.ToString(@"m\:ss\.fff")}", 2);

            timer.Start();
            performanceTests.TakeFromArrayInOrder();
            timer.Stop();
            listView.Items.Add($"Количество тиков выборка по порядку Array: {timer.Elapsed.ToString(@"m\:ss\.fff")}", 3);

            timer.Start();
            performanceTests.TakeFromDictionaryInRandom();
            timer.Stop();
            listView.Items.Add($"Количество тиков выборка в случайном порядке Dictionary: {timer.Elapsed.ToString(@"m\:ss\.fff")}", 4);

            timer.Start();
            performanceTests.TakeFromArrayInRandom();
            timer.Stop();
            listView.Items.Add($"Количество тиков выборка в случайном порядке Array: {timer.Elapsed.ToString(@"m\:ss\.fff")}", 5);
        }
    }
}
