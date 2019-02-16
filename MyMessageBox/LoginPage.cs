namespace MyMessageBox
{
    public partial class LoginPage : System.Windows.Forms.Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string ErorMessage { get; set; }

        private void exit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void erase_Click(object sender, System.EventArgs e)
        {
            userName.Text = string.Empty;

            password.Text = string.Empty;
        }

        private void login_Click(object sender, System.EventArgs e)
        {
            Password = password.Text;

            UserName = userName.Text;

            Close();
        }
        private void checkPassword_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkPassword.Checked == true)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void LoginPage_Load(object sender, System.EventArgs e)
        {
            if (ErorMessage!=string.Empty)
            {
                messagelabel.Text = ErorMessage;
            }
        }
    }
}
