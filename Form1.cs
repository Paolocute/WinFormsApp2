using System.Drawing.Text;
using System.Text;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private string guessingWord = "Computer";
        private StringBuilder wrongGuess = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
            HideWord();
        }
        private void HideWord()
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guess = textBox1.Text;

            if(guess.Equals (guessingWord ))
            {
                textBox1.Text = guessingWord;
                MessageBox.Show("Congratulations! You guess the word." + "\n" + " Wrong guess. Try Again " + wrongGuess);
            }
            else
            {
                wrongGuess.AppendLine(guessingWord);
                listBox1.Items.Add(wrongGuess);
                textBox1.Clear();
              
            }

        }
    }
}
