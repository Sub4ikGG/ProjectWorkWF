﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWorkWF
{
    public class Notification
    {
        public string sender;
        public string recipient;
        public string message;

        public Notification(string sender, string recipient, string messasge)
        {
            this.sender = sender;
            this.recipient = recipient;
            this.message = messasge;
        }
    }
}
