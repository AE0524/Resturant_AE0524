namespace Resturant_AE0524
{
    public partial class fr : Form
    {
        private List<User>  Userslist = new List<User>();
        public fr()
        {
            InitializeComponent();

            User user = new User(1,"SABA AQEL","SA","1234");
            Userslist.Add(user);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            foreach (User user in Userslist)
            {
                if (username == user.Username && password == user.Password)
                {
                   frmWelcome frm = new frmWelcome();
                   frm.ShowDialog();
                    return;
                }
            }

            MessageBox.Show("Wrong username or password");
        }
    }
}