﻿using System;
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

        private string symbol = "";

        private string[] Values = new string[2];
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
            UserInputBox.Text = InputUserData;
            Values[1] = InputUserData;
            InputUserData = "";
            UserInputBox.Text = InputUserData;
            MessageBox.Show($"{Values[0]}   {Values[1]}");
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
