using System;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private string guessingWord = "Computer";
    

        public Form1()
        {
            InitializeComponent();
            HideWord();
        }

        private void HideWord()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guess = textBox1.Text;

            if (guess.Equals(guessingWord, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Congratulations! You guessed the word.");
            }
            else
            {
                listBox1.Items.Add(guess); 
                textBox1.Clear();
                MessageBox.Show("Wrong guess! Try again.");
            }
        }
    }
}
