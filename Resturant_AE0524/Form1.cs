
using System.Collections.Generic;
using System.Data.OleDb;

namespace Resturant_AE0524
{
    public partial class fr : Form
    {
        public static string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\user\Documents\Welcome.accdb;Persist Security Info=False;";
       // private static OleDbConnection Connection = new OleDbConnection(ConnectionString); 
        
        

        private List<User>  Userslist = new List<User>();
        public fr()
        {
            InitializeComponent();

            User user = new User( "Saba","1234");
            Userslist.Add(user);

        }
    
        //
        /*OleDbPermission ocn =new OleDbPermission();
        String acon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Welcome.accdb;Persist Security Info=False;";
        OleDbPermission ocn1 = new OleDbPermission(); */

        

        private void frmLogin_Load(object sender, EventArgs e)
        {
           // String connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Welcome.accdb;Persist Security Info=False;";
            
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
                    frm.user2 = " Welcome "+txtUsername.Text;
                    frm.ShowDialog();
                    return;
                }

                else
                {

                    MessageBox.Show("Wrong username or password");
                }
            }
         
         }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
   
}