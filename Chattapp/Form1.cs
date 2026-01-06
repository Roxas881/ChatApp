using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chattapp.Classes;
using Chattapp.Controllers;

namespace Chattapp
{
    public partial class Form1 : Form
    {
        UserController uc = new UserController();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DgvFriends.DataSource = uc.GetListOfUsers();
        }
    }
}
