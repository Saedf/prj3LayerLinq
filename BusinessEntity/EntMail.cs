using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
  public  class EntMail
    {
        public int mail_number { get; set; }
        public int mail_senderID { get; set; }
        public int mail_recipientID { get; set; }
        public string mail_text { get; set; }
        public bool mail_check { get; set; }

    }
}
