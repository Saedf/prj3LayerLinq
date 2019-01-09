using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
namespace DataAccessLayer
{
   public class mailDAL
    {
        DataSet1TableAdapters.tbl_mailTableAdapter mailTA = new DataSet1TableAdapters.tbl_mailTableAdapter();
        DataSet1.tbl_mailDataTable mailDT = new DataSet1.tbl_mailDataTable();
        EntMail Entmail = new EntMail();
        public mailDAL(string pConnectionString) { mailTA.Connection.ConnectionString = pConnectionString; }
        public DataSet1.tbl_mailDataTable Get_Mail()
        {
            mailTA.ClearBeforeFill = true;
            mailDT = mailTA.GetData();
            return mailDT;
        }
        public DataSet1.tbl_mailDataTable Get_MailMe(int pm_Recipient)
        {
            return mailTA.GetMailMe(pm_Recipient);
        }
        public void insert_Mail(EntMail entMail)
        {
            mailTA.spInsertMail(entMail.mail_senderID, entMail.mail_recipientID, entMail.mail_text, false);
        }
        public void delete_Mail(int pM_numberID)
        {
            mailTA.spDeleteMail(pM_numberID);
        }
        public void updateChecked_Mail(EntMail entMail)
        {
            mailTA.spUpdateStatusMail(entMail.mail_number, entMail.mail_check);
        }
    }
}
