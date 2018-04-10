using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
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
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Добавление пробелов к строке в которую вводится число
        /// </summary>
        private void FilterateStrings()
        {
            string fmt = "000 000 000";
            

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Number_3_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "3";
            UserInputBox.Text = InputUserData;
        }

        private void Number_2_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "2";
            UserInputBox.Text = InputUserData;

        }

        private void Number_1_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "1";
            UserInputBox.Text = InputUserData;

        }

        private void Number_4_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "4";
            UserInputBox.Text = InputUserData;

        }

        private void Number_5_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "5";
            UserInputBox.Text = InputUserData;

        }

        private void Number_6_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "6";
            UserInputBox.Text = InputUserData;

        }

        private void Number_9_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "9";
            UserInputBox.Text = InputUserData;

        }

        private void Number_8_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "8";
            UserInputBox.Text = InputUserData;

        }

        private void Number_7_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "7";
            UserInputBox.Text = InputUserData;

        }

        private void Number_0_Button_Click(object sender, EventArgs e)
        {
            InputUserData += "0";
            UserInputBox.Text = InputUserData;

        }

        private void EquallyButton_Click(object sender, EventArgs e)
        {

        }

        private void PlusButton_Click(object sender, EventArgs e)
        {

        }

        private void MinusButton_Click(object sender, EventArgs e)
        {

        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {

        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
