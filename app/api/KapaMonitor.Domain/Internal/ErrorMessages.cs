﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapaMonitor.Domain.Internal
{
    public class Error
    {
        public int Code;
        public string Message;
    }
    public static class ErrorMessages
    {
        public const string DatabaseOperationFailed = "Database operation failed.";

        public static readonly Error CreateContactInfo = new Error { Code = 1, Message = "Failed to add new ContactInfo to database." };
        public static readonly Error UpdateContactInfo = new Error { Code = 2, Message = "Failed to update existing ContactInfo in database." };
        public static readonly Error DeleteContactInfo = new Error { Code = 3, Message = "Failed to remove ContactInfo from database." };
    }
}
