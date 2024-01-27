namespace WebForms3
{
    public partial class DateTimeForm : Form
    {
        public DateTimeForm()
        {
            InitializeComponent();
        }

        DateTimeForm E = new DateTimeForm();

        private void ShowDateTime()
        {
            lblDate1.Text = DateTime.Now.ToString();
            lblDate2.Text = DateTime.Now.ToLongDateString();
            lblDate3.Text = DateTime.Now.ToShortDateString();
            lblTime1.Text = DateTime.Now.ToLongTimeString();
            lblTime2.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowDateTime();

        }

        private void DateTimeForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                E.Hide();
            }
        }
    }
}
