using Chattapp.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IdentityModel.Selectors;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Chattapp.Controllers
{
    internal class UserController
    {
        private static string connectionstring = @"Data Source=.\SQLEXPRESS ; Initial Catalog=ChatApp; Integrated Security=True";
        public List<UserClass> GetListOfUsers()
        {
            try
            {
                List<UserClass> Users = new List<UserClass>();
                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Users";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    Users.Add(new UserClass(row["userId"].ToString(), row["userName"].ToString(), row["userPassword"].ToString(), row["Email"].ToString(), row["firstName"].ToString(), row["lastName"].ToString(), Convert.ToBoolean(row["isAdmin"])));
                }
                if (Users.Count() > 0) {
                    return Users;
                }
                return null;
            }
            catch (Exception ex) {
                return null;
            }
        }
        public UserClass GetUser(int id)
        {
            return new UserClass();
        }
        public bool CreateUser(UserClass user)
        {
            return true;
        }
        public bool UpdateUser(UserClass user)
        {
            return true;
        }
        public bool DeleteUser(int id)
        {
            return true;
        }
        public UserClass login(string UserName, string Password)
        {
            return new UserClass();
        }
    }
}
