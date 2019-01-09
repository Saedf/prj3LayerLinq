using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
   public class EntAmanat
    {
        public int am_id { get; set; }
        public int am_member_code { get; set; }
        public int am_book_isbn { get; set; }
        public string am_start { get; set; }
        public string am_end { get; set; }
        public bool am_resid { get; set; }
    }
}
