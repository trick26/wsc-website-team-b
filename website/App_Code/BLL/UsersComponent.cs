using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

namespace BLL
{
    /// <summary>
    /// Summary description for UserComponent
    /// </summary>
    public class UsersComponent
    {
        public UsersComponent()
        {
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            DataSet ds = new DataSet();
            DataSetTableAdapters.usersTableAdapter adapter = new DataSetTableAdapters.usersTableAdapter();
            adapter.Fill(ds.users);
            DataSet.usersDataTable table = adapter.GetUserData();

            // load all users into the list
            foreach (DataSet.usersRow row in table.Rows)
            {
                // create memory for new user & fill in properties
                User u = new User();
                u.Name = row.userName;
                u.Password = row.userPassword;
                u.Email = row.userEmail;
                u.ClientId = row.clientId;

                // add this user to the list
                users.Add(u);
            }
            // returns the list w/ 0 or more Users
            return users;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns>A user if found; null if user not found</returns>
        public User GetUserByName(String name)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.usersTableAdapter adapter = new DataSetTableAdapters.usersTableAdapter();
            adapter.Fill(ds.users);
            User u = new User();

            // find the user
            DataSet.usersDataTable table = adapter.GetUserByName(name);

            // if a user was found, then fill in the details 
            if (table.Rows.Count > 0)
            {
                // use the 1st row's data
                DataSet.usersRow row = (DataSet.usersRow)table.Rows[0];
                u.Name = row.userName;
                u.Password = row.userPassword;
                u.Email = row.userEmail;
                u.ClientId = row.clientId;
                return u;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Validates a user trying to login
        /// </summary>
        /// <param name="username">the supplied username</param>
        /// <param name="password">the supplied password</param>
        /// <returns>successful: a User
        /// unsuccessful: null</returns>
        public User ValidateLogin(String username, String password)
    {
        List<User> users = GetUsers();
        User validUser = null;
        foreach (User u in users)
        {
            if ((String.Equals(u.Name, username)) && (String.Equals(u.Password, password)))
            {
                validUser = u;
                break;
            }
        }
        return validUser;
    }

        public int UpdateUser(User u)
        {
            return UpdateUser(u.Name, u.Password, u.Email, u.ClientId);
        }

        public int UpdateUser(String name, String password, String email, int clientId)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.usersTableAdapter adapter = new DataSetTableAdapters.usersTableAdapter();

            return adapter.Update(name, password, email, clientId, name);
        }

        public int InsertUser(User u)
        {
            return InsertUser(u.Name, u.Password, u.Email, u.ClientId);
        }

        public int InsertUser(String name, String password, String email, int clientId)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.usersTableAdapter adapter = new DataSetTableAdapters.usersTableAdapter();

            return adapter.Insert(name, password, email, clientId);
        }

        public int DeleteUser(User u)
        {
            return DeleteUser(u.Name);
        }

        public int DeleteUser(String name)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.usersTableAdapter adapter = new DataSetTableAdapters.usersTableAdapter();

            return adapter.Delete(name);
        }
    }
}
