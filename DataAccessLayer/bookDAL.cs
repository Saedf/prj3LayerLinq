using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
namespace DataAccessLayer
{
   public class bookDAL
    {
        DataSet1TableAdapters.tbl_bookTableAdapter bookTA = new DataSet1TableAdapters.tbl_bookTableAdapter();
        DataSet1.tbl_bookDataTable bookDT = new DataSet1.tbl_bookDataTable();
        DataSet1 DS = new DataSet1();
        EntBook EntBook = new EntBook();

        public bookDAL(string pConnectionString)
        {
            bookTA.Connection.ConnectionString = pConnectionString;
        }

        
        public DataSet1.tbl_bookDataTable Get_book()
        {
            bookTA.ClearBeforeFill = true;
            bookDT = bookTA.GetData();
            return bookDT;
        }
        public DataSet1 FillDataSet_book()
        {
            bookTA.Fill(DS.tbl_book);
            return DS;
        }
        public void insert_Book(EntBook entBook)
        {
            bookTA.spInsertBook(entBook.b_isbn, entBook.b_title, entBook.b_group, entBook.b_print, entBook.b_moalef
                , entBook.b_page, entBook.b_total);

        }
        public void delete_Book(int pb_isbn)
        {
            bookTA.spDeleteBook(pb_isbn);
        }
        public void updateByISBN_Book(EntBook entBook)
        {
            bookTA.spUpdateBook(entBook.b_isbn, entBook.b_title, entBook.b_group, entBook.b_print,
                entBook.b_moalef, entBook.b_page, entBook.b_total);

        }
        public void updateTotal_Book(EntBook entBook)
        {
            bookTA.spUpdateNumberExistBook(entBook.b_isbn, entBook.b_total);
        }

    }
}
