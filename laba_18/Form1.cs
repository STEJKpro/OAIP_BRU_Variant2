namespace laba_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        private void calculateButton_Click(object sender, EventArgs e)
        {
            string result;
            richTextBoxResults.Enabled = false;
            try
            {
                float edge = float.Parse(textBoxEdgeLength.Text);
                result = $"�����: {edge}\n������� �����: {Math.Pow(edge,2):F3}\n������� �����������: {6* Math.Pow(edge, 2):F3}\n����� ����: {Math.Pow(edge,3):F3}";
                richTextBoxResults.BackColor = Color.Green;
            }
            catch (FormatException)
            {
                richTextBoxResults.BackColor = Color.Red;
                result = $"������� �������� ��������!";
            }
            //Console.WriteLine("Click");
            richTextBoxResults.Text = result ;
            richTextBoxResults.Enabled = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
