using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
  public  class EntMember
    {
        public int m_code { get; set; }
        public string m_fname { get; set; }
        public string m_lname { get; set; }
        public int m_sh { get; set; }
        public string m_father { get; set; }
        public string m_birthday { get; set; }
        public string   m_gride  { get; set; }
        public string m_ozviat { get; set; }
        public string m_zamen { get; set; }
        public string m_zamenTell { get; set; }
        public string m_address { get; set; }
        public string m_tell { get; set; }
        public byte[] m_pic { get; set; }
    }
}
