using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLayer;
namespace BusinessAccessLayer
{
   public class amanatBAL
    {
        private EntAmanat entAmanat = new EntAmanat();
        private bookDAL obj_book;
        private amanatDAL obj_amanat;
        private memberDAL obj_member;

        public amanatBAL(string pConString)
        {
            obj_amanat = new amanatDAL(pConString);
            obj_member = new memberDAL(pConString);
            obj_book = new bookDAL(pConString);

        }
        public void insert(EntAmanat entAmanat)
        {
            obj_amanat.insert_Amanat(entAmanat);

        }
        public void update(EntAmanat entAmanat)
        {
            obj_amanat.update_Amanat(entAmanat);
        }
        public void delete(int pDelID)
        {
            obj_amanat.delete_Amanat(pDelID);
        }
        public object fillAmanat()
        {
            var queryFill = from i in obj_amanat.Get_Amanat()
                            where i.am_resid = false
                            join j in obj_member.get_member() on i.am_member_code equals j.m_code
                            join k in obj_book.Get_book() on i.am_book_isbn equals k.b_isbn
                            
                            select new
                            {
                                codeAmanat = i.am_id,
                                codOzviat = i.am_member_code,
                                name = j.m_fname,
                                lastName = j.m_lname,
                                bookIsbn = k.b_isbn,
                                titleBook = k.b_title,
                                dateGiveBook = i.am_start,
                                dateBackBook = i.am_end
                            };
            return queryFill.ToList();
        }
        public object filterTitleBook(string pTitle)
        {
            var queryFill = from i in obj_amanat.Get_Amanat()
            where i.am_resid = false
            join j in obj_member.get_member() on i.am_member_code equals j.m_code 
            join k in obj_book.Get_book() on i.am_book_isbn equals k.b_isbn
            where  k.b_title.Contains(pTitle)
            select new
            {
                codeAmanat = i.am_id,
                codOzviat = i.am_member_code,
                name = j.m_fname,
                lastName = j.m_lname,
                bookIsbn = k.b_isbn,
                titleBook = k.b_title,
                dateGiveBook = i.am_start,
                dateBackBook = i.am_end
            };
            return queryFill.ToList();
        }
        public object filterISBNBook(int pISBN)
        {
            var queryFill = from i in obj_amanat.Get_Amanat()
                            where i.am_resid = false
                            join j in obj_member.get_member() on i.am_member_code equals j.m_code
                            join k in obj_book.Get_book() on i.am_book_isbn equals k.b_isbn
                            where  k.b_isbn.ToString().Contains(pISBN.ToString())
                            select new
                            {
                                codeAmanat = i.am_id,
                                codOzviat = i.am_member_code,
                                name = j.m_fname,
                                lastName = j.m_lname,
                                bookIsbn = k.b_isbn,
                                titleBook = k.b_title,
                                dateGiveBook = i.am_start,
                                dateBackBook = i.am_end
                            };
            return queryFill.ToList();
        }
        public object filterLastNameMember(string pLname)
        {
            var queryFill = from i in obj_amanat.Get_Amanat()
                            where i.am_resid = false
                            join j in obj_member.get_member() on i.am_member_code equals j.m_code
                            join k in obj_book.Get_book() on i.am_book_isbn equals k.b_isbn
                            where j.m_lname.Contains(pLname)
                            select new
                            {
                                codeAmanat = i.am_id,
                                codOzviat = i.am_member_code,
                                name = j.m_fname,
                                lastName = j.m_lname,
                                bookIsbn = k.b_isbn,
                                titleBook = k.b_title,
                                dateGiveBook = i.am_start,
                                dateBackBook = i.am_end
                            };
            return queryFill.ToList();
        }
        public object filterCodeMember(int pCode)
        {
            var queryFill = from i in obj_amanat.Get_Amanat()
                            where i.am_resid = false
                            join j in obj_member.get_member() on i.am_member_code equals j.m_code
                            join k in obj_book.Get_book() on i.am_book_isbn equals k.b_isbn
                            where i.am_member_code.ToString().Contains(pCode.ToString())
                            select new
                            {
                                codeAmanat = i.am_id,
                                codOzviat = i.am_member_code,
                                name = j.m_fname,
                                lastName = j.m_lname,
                                bookIsbn = k.b_isbn,
                                titleBook = k.b_title,
                                dateGiveBook = i.am_start,
                                dateBackBook = i.am_end
                            };
            return queryFill.ToList();
        }
        public DataSet1.tbl_AmanatDataTable fillDataTable()
        {
            return obj_amanat.Get_Amanat();
        }
        public DataSet1 fillDataSet()
        {
            return obj_amanat.FillDataSet_Amanat();
        }
        public DataSet1.View_rptAmanatMemberDataTable fillRptAmanatMember()
        {
            return obj_amanat.FillRptAmanat();
        }

    }
}
