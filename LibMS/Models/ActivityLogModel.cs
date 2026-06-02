using System;
using System.Collections.Generic;
using System.Text;

namespace LibMS.Models
{
    public class ActivityLogModel
    {
        public int RequestID { get; set; }

        public string Title { get; set; } = "";

        public DateTime BorrowDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public string Status { get; set; } = "";

        public string SlipNumber { get; set; } = "";
    }
}