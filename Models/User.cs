using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    [Table("users")]
    public class User : IComparable
    {
        private string _login, _password, lname, discription, name;
        private bool _role;

        public string LName
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;

            }
        }
        public string Discription
        {
            get
            {
                return discription;
            }
            set
            {
                discription = value;


            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;


            }
        }
        [Key]
        public string login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;


            }
        }
        public string password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;


            }
        }
        public bool role
        {
            get
            {
                return _role;
            }
            set
            {
                _role = value;


            }
        }

        public User() { }
        public User(string login, string password, bool Role)
        {
            this.login = login;
            this.password = password;
            this.role = Role;

        }

        public int CompareTo(object user)
        {
            return string.Compare(this.login, (user as User).login);
        }
    }

}
