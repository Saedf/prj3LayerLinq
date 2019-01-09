using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntity;
using System.Data;
namespace BusinessAccessLayer
{
    public class bookBAL
    {
        bookDAL obj_bookDAL;
        EntBook entBook = new EntBook();
        DataSet1 ds = new DataSet1();

        public bookBAL(string pConString)
        {
            obj_bookDAL = new bookDAL(pConString);
        }
        public void insert(EntBook entBook)
        {
            obj_bookDAL.insert_Book(entBook);
        }
        public void updateByIsbn(EntBook entBook)
        {
            obj_bookDAL.updateByISBN_Book(entBook);
        }
        public void updateTotalBook(EntBook entBook)
        {
            obj_bookDAL.updateTotal_Book(entBook);
        }
        public void delete(int del_isbn)
        {
            obj_bookDAL.delete_Book(del_isbn);
        }
        public object fill()
        {
            var queryFill = from i in obj_bookDAL.Get_book()
                            select new
                            {
                                isbn = i.b_isbn,
                                title = i.b_title,
                                moalef = i.b_moalef,
                                chap = i.b_print,
                                grooh = i.b_group,
                                page = i.b_page,
                                mojood = i.b_total
                            };
            return queryFill.ToList();
        }
        public object fillBookAmanat()
        {
            var queryfill = from i in obj_bookDAL.Get_book()
                            where i.b_total > 0
                            select new
                            {
                                isbn = i.b_isbn,
                                title = i.b_title,
                                moalef = i.b_moalef,
                                chap = i.b_print,
                                grooh = i.b_group,
                                page = i.b_page,
                                mojood = i.b_total
                            };
            return queryfill.ToList();
        }
        public DataSet1.tbl_bookDataTable fillDataTable()
        {
            return obj_bookDAL.Get_book();
        }
        public DataSet1 fillDataSet()
        {
            return obj_bookDAL.FillDataSet_book();
        }
        public DataSet1 fillDataSet(string pb_group)
        {

            var query = from i in obj_bookDAL.Get_book()
                        where i.b_group.Contains(pb_group)
                        select i;
            if (query.Count() > 0)
            {
                DataTable dataTable = query.CopyToDataTable();
                ds.tbl_book.Clear();
                foreach (DataRow i in dataTable.Rows)
                {
                    ds.tbl_book.ImportRow(i);
                }
                return ds;
            }
            else
            {
                ds.tbl_book.Clear();
                return ds;
            }
        }
        public object filterISBN(int pSearch)
        {
            return (from i in obj_bookDAL.Get_book()
                    where i.b_isbn.ToString().Contains(pSearch.ToString())
                    select new
                    {
                        isbn = i.b_isbn,
                        title = i.b_title,
                        moalef = i.b_moalef,
                        chap = i.b_print,
                        grooh = i.b_group,
                        page = i.b_page,
                        mojood = i.b_total
                    }).ToList();
        }
        public object filterIsbnAmanat(int pSearch)
        {
            return (from i in obj_bookDAL.Get_book()
                    where (i.b_isbn.ToString().Contains(pSearch.ToString()) && i.b_total > 0)
                    select new
                    {
                        isbn = i.b_isbn,
                        title = i.b_title,
                        moalef = i.b_moalef,
                        chap = i.b_print,
                        grooh = i.b_group,
                        page = i.b_page,
                        mojood = i.b_total
                    }).ToList();

        }
        public object filterTitle(string pSearch)
        {
            return (from i in obj_bookDAL.Get_book()
                    where i.b_title.Contains(pSearch)
                    select new
                    {
                        isbn = i.b_isbn,
                        title = i.b_title,
                        moalef = i.b_moalef,
                        chap = i.b_print,
                        grooh = i.b_group,
                        page = i.b_page,
                        mojood = i.b_total
                    }).ToList();
        }
        public object filterMoalef(string pSearch)
        {
            return (from i in obj_bookDAL.Get_book()
                    where i.b_moalef.Contains(pSearch)
                    select new
                    {
                        isbn = i.b_isbn,
                        title = i.b_title,
                        moalef = i.b_moalef,
                        chap = i.b_print,
                        grooh = i.b_group,
                        page = i.b_page,
                        mojood = i.b_total
                    }).ToList();
        }
        public bool find_ISBN(int pSearchISBN)
        {
            var queryFind = (from i in obj_bookDAL.Get_book() where i.b_isbn.Equals(pSearchISBN)select i).Count();
            if (queryFind>0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
