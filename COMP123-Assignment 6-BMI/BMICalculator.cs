using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Author : Christopher Ritchil
 * Student # : 300702644
 * Date : August 5th, 2016
 * Description : Body Mass Index Calculator for Assignment #4 
 * Version : Final version 
 */

namespace COMP123_Assignment_6_BMI
{
    /**
    * <summary>
    * This class is the "driver" class for our program
    * </summary>
    * 
    * @class Program
    */
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        /**
         * <summary>
         * This eventhandler clears contents
         * </summary>
         * 
         * @method ClearButton_Click
         * @param {object} sender
         * @param {EventArgs} e
         */
        private void ClearButton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";
            BMIResultBox.Text = "";
            BMIResultBox.BackColor = Color.Bisque;
            BMIScaleBox.Text = "";
            BMIScaleBox.BackColor = Color.Bisque;
            BMIProgressBar.Value = 0;
        }

        /**
         * <summary>
         * This eventhandler calculates
         * </summary>
         * 
         * @method CalculateButton_Click
         * @param {object} sender
         * @param {EventArgs} e
         */
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // local variables
            double height = 0, weight = 0, BMI;

            try
            {
                height = Convert.ToDouble(HeightTextBox.Text);
                weight = Convert.ToDouble(WeightTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Fill out the forms");
            }

            if (HeightTextBox.Text == "" || WeightTextBox.Text == "")
            {
                HeightTextBox.Focus();
                HeightTextBox.SelectAll();
                WeightTextBox.Focus();
                WeightTextBox.SelectAll();
            }
            else if (height < 0 || weight < 0)
            {
                MessageBox.Show("Please provide positive values");
            }
            else if (height > 0 && weight > 0)
            {
                if (ImperialButton.Checked == true)
                {
                    BMI = (weight * 703) / (height * height);
                    if (((BMI / 30) * 100) > 100)
                    {
                        BMIProgressBar.Value = 100;
                    }
                    else
                    {
                        BMIProgressBar.Value = ((int)((BMI / 30) * 100));
                    }

                    BMIResultBox.Text = string.Format("{0:f1}", BMI);
                    BMIResultBox.BackColor = Color.LightSalmon;
                    BMIScaleBox.BackColor = Color.LightSalmon;

                    if (BMI < 18.5)
                    {
                        this.BMIScaleBox.Text = ("Underweight");
                        BMIProgressBar.ForeColor = Color.Yellow;
                    }
                    else if (BMI >= 18.5 && BMI <= 24.9)
                    {
                        this.BMIScaleBox.Text = ("Normal");
                        BMIProgressBar.ForeColor = Color.Green;
                    }
                    else if (BMI >= 25 && BMI <= 29.9)
                    {
                        this.BMIScaleBox.Text = ("Overweight");
                        BMIProgressBar.ForeColor = Color.DarkGreen;
                    }
                    else if (BMI >= 30)
                    {
                        this.BMIScaleBox.Text = ("Obese");
                        BMIProgressBar.ForeColor = Color.Red;
                    }
                }
                else if (MetricUnitsButton.Checked == true)
                {
                    BMI = weight / ((height * height) / 10000);
                    if (((BMI / 30) * 100) > 100)
                    {
                        BMIProgressBar.Value = 100;
                    }
                    else
                    {
                        BMIProgressBar.Value = ((int)((BMI / 30) * 100));
                    }

                    BMIResultBox.Text = string.Format("{0:f1}", BMI);
                    BMIResultBox.BackColor = Color.LightSalmon;
                    BMIScaleBox.BackColor = Color.LightSalmon;
                    BMIProgressBar.Maximum = 100;

                    if (BMI < 18.5)
                    {
                        this.BMIScaleBox.Text = ("Underweight");
                        BMIProgressBar.ForeColor = Color.Yellow;
                    }
                    else if (BMI >= 18.5 && BMI <= 24.9)
                    {
                        this.BMIScaleBox.Text = ("Normal");
                        BMIProgressBar.ForeColor = Color.Green;
                    }
                    else if (BMI >= 25 && BMI <= 29.9)
                    {
                        this.BMIScaleBox.Text = ("Overweight");
                        BMIProgressBar.ForeColor = Color.DarkGreen;
                    }
                    else if (BMI >= 30)
                    {
                        this.BMIScaleBox.Text = ("Obese");
                        BMIProgressBar.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void BMIScaleBox_TextChanged(object sender, EventArgs e)
        {

        }

        /**
         * <summary>
         * This eventhandler set a restriction on input height value
         * </summary>
         * 
         * @method HeightTextBox_KeyPress
         * @param {object} sender
         * @param {KeyPressEventArgs} e
         */
        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        /**
         * <summary>
         * This eventhandler set a restriction on input weight value
         * </summary>
         * 
         * @method WeightTextBox_KeyPress
         * @param {object} sender
         * @param {KeyPressEventArgs} e
         */
        private void WeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void ImperialButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BMIResultBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
