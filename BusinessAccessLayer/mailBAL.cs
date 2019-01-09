using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntity;

namespace BusinessAccessLayer
{
    public class mailBAL
    {
        #region "Fields"
        EntMail entMail = new EntMail();
        userBAL obj_UserBAL;
        mailDAL obj_Mail;

        #endregion
        public mailBAL(string pConString)
        {
            obj_Mail = new mailDAL(pConString);
            obj_UserBAL = new userBAL(pConString);
        }
        #region "CRUD"
        public void insert(EntMail pMail)
        {
            obj_Mail.insert_Mail(pMail);
        }
        public int countMailClose(int pm_Recipient)
        {
            return (from i in obj_Mail.Get_Mail()
                    where i.mail_recipientId == pm_Recipient && i.mail_check == false
                    select i.mail_number).Count();

        }
        public object mailMe(int pm_Recipient)
        {
           
            var query = from i in obj_UserBAL.fillDataTable()
                        join l in obj_Mail.Get_MailMe(pm_Recipient) on i.user_numberId equals l.mail_senderId 
                        select new {
                            i.user_nameId,
                            l.mail_text,
                            l.mail_number
                        };
            if (query.Count()>0)
            {
                return query;
            }
            else
            {
                return null;
            }
                     
                      
        }
        public bool statuse_MailMe(int pm_recipient)
        {
            var query = from i in obj_UserBAL.fillDataTable()
                        join l in obj_Mail.Get_MailMe(pm_recipient) on i.user_numberId equals l.mail_senderId
                        select new
                        {
                            i.user_nameId,
                            l.mail_text,
                            l.mail_number
                        };
            if (query.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void delete(int pMailNumber)
        {
            obj_Mail.delete_Mail(pMailNumber);
        }
        public void updateMailCheck(EntMail pMail)
        {
            obj_Mail.updateChecked_Mail(pMail);
        }
        #endregion


    }
}
