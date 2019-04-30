using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HaiVu_Final_Project
{
    public static class Utility
    {
        public static bool IsPresent(this TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text) || String.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(textBox.Tag + " is a required field.");
                textBox.Focus();
                return false;
            }
            return true;                  
        }

        public static bool IsDecimal(this TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value.");
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(this TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.");
                textBox.Focus();
                return false;
            }
        }

        public static bool IsWithinRange(this TextBox textBox, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(textBox.Tag + " must be between " + min
                    + " and " + max + ".");
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}

