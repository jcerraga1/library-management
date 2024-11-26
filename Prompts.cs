using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementApp
{
    internal class Prompt
    {
        public static string ShowDialogInt(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 250;
            prompt.Height = 150;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.CenterScreen;


            Label textLabel = new Label() { Left = 10, Top = 20, Width = 200, Text = text };
            TextBox textBox = new TextBox() { Left = 10, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "OK", Left = 10, Width = 200, Top = 80 };

            textBox.KeyPress += (sender, e) =>
            {
                // If the key pressed is not a digit, prevent it
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            };

            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.ShowDialog();

            if (textBox.Text.Length > 0)
            {
                return textBox.Text;
            }
            else
            {
                return "0";
            }
        }
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 250;
            prompt.Height = 150;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.CenterScreen;


            Label textLabel = new Label() { Left = 10, Top = 20, Width = 200, Text = text };
            TextBox textBox = new TextBox() { Left = 10, Top = 50, Width = 200 };
            Button confirmation = new Button() { Text = "OK", Left = 10, Width = 200, Top = 80 };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.ShowDialog();
                
            return textBox.Text; 
        }
    }
}
