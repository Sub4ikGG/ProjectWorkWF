﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWorkWF
{
    public class User
    {
        public string first_name;
        public string last_name;
        public string last_last_name;
        public string sex;
        public string birth_date;
        public string email;
        public string password;
        public ArmyTicket ticket;
        public Passport passport;
        public Address address;

        public User(string fn, string ln, string lnn, string s, string bd, string e, string p)
        {
            first_name = fn;
            last_name = ln;
            last_last_name = lnn;
            sex = s;
            email = e;
            password = p;
            birth_date = bd;
        }
    }
}
