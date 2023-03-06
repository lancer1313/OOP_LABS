using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsUI
{
    public partial class MainWindow : Form
    {
        private Dictionary<int, Library> _libraryDict = new Dictionary<int, Library>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void getClassInfoButton_Click(object sender, EventArgs e)
        {
            FillOutputLog(Library.GetClassInfo());
        }

        private void getInheritedExceptionButton_Click(object sender, EventArgs e)
        {
            try
            {
                GetStackOverflowException();
            }
            catch(StackOverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillOutputLog(string[] multilineMessage)
        {
            foreach (var str in multilineMessage)
            {
                outputLog.Text += str + "\r" + "\n";
                outputLog.Text += "---------------------------------------" + "\r" + "\n";
            }
            outputLog.Text += "===========================================" + "\r" + "\n";
        }

        private void FillOutputLog(string message)
        {
            outputLog.Text += message + "\r" + "\n";
            outputLog.Text += "===========================================" + "\r" + "\n";
        }

        private void GetStackOverflowException()
        {
            throw new StackOverflowException("Ты вызвал бесконечную рекурсию балбес");
        }

        private void createObjButton_Click(object sender, EventArgs e)
        {
            string name = newObjName.Text == "" ? "Безымянная" : newObjName.Text;
            string description = newObjDescription.Text;
            string type = newObjType.Text == "" ? "Обычная" : newObjType.Text;
            decimal rating = newObjRating.Value;
            long booksNumber = (long)newObjBooksNumber.Value;
            int readingRooms = (int)newObjReadingRooms.Value;


            _libraryDict.Add(_libraryDict.Count + 1, new Library(name, description, booksNumber, readingRooms, type, withWiFiCheckBox.Checked, rating));
        }

        private void clearLogButton_Click(object sender, EventArgs e)
        {
            outputLog.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void getAllObjsButton_Click(object sender, EventArgs e)
        {
            string[] objs = new string[_libraryDict.Count];
            int i = 0;
            foreach (var lib in _libraryDict)
            {
                objs[i++] = $"ID: {lib.Key}, {lib.Value}";
            }
            FillOutputLog(objs);
        }

        private void changePropertyButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(changePropertyID.Text, out int key))
            {
                if (_libraryDict.ContainsKey(key))
                {
                    _libraryDict.TryGetValue(key, out var lib);
                    try
                    {
                        lib.TryChangeProperty(changePropertyName.Text, changePropertyValue.Text);
                        FillOutputLog("Объект изменен успешно");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Такого ID не существует");
                }
            }
            else
            {
                MessageBox.Show("Неправильный тип ключа");
            }
            
        }

        private void printPropertyButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(printPropertyID.Text, out int key))
            {
                if (_libraryDict.ContainsKey(key))
                {
                    _libraryDict.TryGetValue(key, out var lib);
                    if (inHexCheckBox.Checked)
                    {
                        try
                        {
                            FillOutputLog(lib.GetPropertyInHexMessage(printPropertyName.Text));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        try
                        {
                            FillOutputLog(lib.GetPropertyMessage(printPropertyName.Text));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Такого ID не существует");
                }
            }
            else
            {
                MessageBox.Show("Неправильный тип ключа");
            }
        }
    }
}
