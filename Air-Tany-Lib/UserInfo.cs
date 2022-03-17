using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air_Tany_Lib
{
    public class UserInfo
    {
        private int _id;
        private string _lastname;
        private string _firstname;
        private string _username;
        private string _email;
        
        public UserInfo(int id, string lastanme, string firstname, string username, string email)
        {
            _id = id;
            _lastname = lastanme;
            _firstname = firstname;
            _username = username;
            _email = email;
        }

        public int id
        {
            get => _id;
        }

        public string lastname
        {
            get => _lastname;
        }

        public string firstname
        {
            get => _firstname;
        }

        public string username
        {
            get => _username;
        }

        public string email
        {
            get => _email;
        }

        public int id
        {
            get => _id;
        }
    }
}
