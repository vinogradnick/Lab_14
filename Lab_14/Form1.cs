using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_14
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Входная строка в которую производится ввод
        /// </summary>
        private string InputUserData;

        private string symbol = "";

        private string[] Values = new string[2]{"",""};
        public Form1()
        {
            InitializeComponent();
            
        }

       
        /// <summary>
        /// Обновление данных
        /// </summary>
        private void RefreshData()
        {
            InputUserData = UserInputBox.Text;
            Values[0] = InputUserData;
            InputUserData = "";
            UserInputBox.Text = InputUserData;
        }

        private string parse(string val)
        {
            try
            {
                return decimal.Parse(val).ToString("N0");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return val;
        }

        /// <summary>
        /// Добавление пробелов к строке в которую вводится число
        /// </summary>
        private void FilterateStrings()
        {
            
            

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void Number_3_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "3";
            UserInputBox.Text = parse(InputUserData);
        }

        private void Number_2_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "2";
            UserInputBox.Text = parse(InputUserData);

        }

        private void Number_1_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "1";
            UserInputBox.Text = parse(InputUserData);

        }

        private void Number_4_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "4";
            UserInputBox.Text = parse(InputUserData);

        }

        private void Number_5_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "5";
            UserInputBox.Text = parse(InputUserData);

        }

        private void Number_6_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "6";
            UserInputBox.Text = parse(InputUserData);

        }

        private void Number_9_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "9";
            UserInputBox.Text = parse(InputUserData);

        }

        private void Number_8_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "8";
            UserInputBox.Text = parse(InputUserData);

        }

        private void Number_7_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "7";
            UserInputBox.Text = parse(InputUserData);

        }

        private void Number_0_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "0";
            UserInputBox.Text = parse(InputUserData);

        }

        private void EquallyButton_Click(object sender, EventArgs e)
        {
            if (Values[0].Length > 0 && InputUserData.Length > 0 && symbol.Length > 0) {
                UserInputBox.Text = InputUserData;
                Values[1] = InputUserData;
                InputUserData = "";
                UserInputBox.Text = InputUserData;
                try
                {
                    String[] results = Controllers.Calc.Calculate(Values[0], Values[1], symbol);
                    UserInputBox.Text = results[2];
                    RedrawHistoryBox();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }else
            {
                if (Values[0].Length == 0)
                {
                    MessageBox.Show("Первое число должно быть заполнено");
                    return;
                }
                if (InputUserData.Length == 0)
                {
                    MessageBox.Show("Второе число должно быть заполнено");
                    return;
                }
                if (symbol.Length == 0)
                {
                    MessageBox.Show("Команда должна быть выбрана");
                }
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            symbol = "+";
            RefreshData();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            symbol = "-";
            RefreshData();
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            symbol = "*";
            RefreshData();
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            symbol = "/";
            RefreshData();
        }

        private void UserInputBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                Values[0] = Controllers.Calc.Reset()[2];
                UserInputBox.Text = Values[0];
                Values[1] = "";
                symbol = "";
            }
            catch (Exception) {
                ClearAllData();
            }
            RedrawHistoryBox();
        }

        private void HistoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void RedrawHistoryBox()
        {
            HistoryListBox.Items.Clear();
            foreach (var item in Controllers.Calc.history)
            {
                HistoryListBox.Items.Add($"{item.ToStringArray()[0]}{item.ToStringArray()[3]} {item.ToStringArray()[1]} = {item.ToStringArray()[2]}");
            }
            
        }

        private void ClearAllData()
        {
            Controllers.Calc.history.Clear();
            RedrawHistoryBox();
            Values[0] = "";
            Values[1] = "";
            RefreshData();
            symbol = "";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

        private void RDivisionButton_Click(object sender, EventArgs e)
        {
            symbol = "%";
            RefreshData();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var code = e.KeyCode;
            switch (code)
            {
                   case Keys.Add:
                       PlusButton_Click(sender,null);
                       break;
                case Keys.Multiply:
                    MultiplicationButton_Click(sender,null);
                    break;
                case Keys.Divide:
                    DivisionButton_Click(sender,null);
                    break;
                case Keys.OemMinus:
                    MinusButton_Click(sender,null);
                    break;
                case Keys.D0:
                    Number_0_Button_Click(sender, null);
                    break;
                case Keys.D1:
                    Number_1_Button_Click(sender,null);
                    break;
                case Keys.D2:
                    Number_2_Button_Click(sender,null);
                    break;
                case Keys.D3:
                    Number_3_Button_Click(sender,null);
                    break;
                case Keys.D4:
                    Number_4_Button_Click(sender,null);
                    break;
                case Keys.D5:
                    Number_5_Button_Click(sender,null);
                    break;
                case Keys.D6:
                    Number_6_Button_Click(sender,null);
                    break;
                case Keys.D7:
                    Number_7_Button_Click(sender, null);
                    break;
                case Keys.D8:
                    Number_8_Button_Click(sender, null);
                    break;
                case Keys.D9:
                    Number_9_Button_Click(sender, null);
                    break;
                case Keys.NumPad0:
                    Number_0_Button_Click(sender, null);
                    break;
                case Keys.NumPad1:
                    Number_1_Button_Click(sender, null);
                    break;
                case Keys.NumPad2:
                    Number_2_Button_Click(sender, null);
                    break;
                case Keys.NumPad3:
                    Number_3_Button_Click(sender, null);
                    break;
                case Keys.NumPad4:
                    Number_4_Button_Click(sender, null);
                    break;
                case Keys.NumPad5:
                    Number_5_Button_Click(sender, null);
                    break;
                case Keys.NumPad6:
                    Number_6_Button_Click(sender, null);
                    break;
                case Keys.NumPad7:
                    Number_7_Button_Click(sender, null);
                    break;
                case Keys.NumPad8:
                    Number_8_Button_Click(sender, null);
                    break;
                case Keys.NumPad9:
                    Number_9_Button_Click(sender, null);
                    break;
                case Keys.Back:
                    RefreshButton_Click(sender,null);
                    break;
                
                default:
                    break;
            }
        }
    }
}
