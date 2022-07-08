namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculateRevenue_Click(object sender, EventArgs e)
        {
            try
            {
                int classASeats = int.Parse(textBoxClassA.Text);
                int classBSeats = int.Parse(textBoxClassB.Text);
                int classCSeats = int.Parse(textBoxClassC.Text);

                decimal classARevenue = classASeats * 15;
                decimal classBRevenue = classBSeats * 12;
                decimal classCRevenue = classCSeats * 9;

                decimal totalRevenue = classARevenue + classBRevenue + classCRevenue;

                labelClassARevenue.Text = classARevenue.ToString();
                labelClassBRevenue.Text = classBRevenue.ToString();
                labelClassCRevenue.Text = classCRevenue.ToString();
                labelTotalRevenue.Text = totalRevenue.ToString();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxClassA.Text = "";
            textBoxClassB.Text = "";
            textBoxClassC.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}