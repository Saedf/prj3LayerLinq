using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;

namespace DataAccessLayer
{
    public class amanatDAL
    {
        DataSet1TableAdapters.tbl_AmanatTableAdapter amanatTA = new DataSet1TableAdapters.tbl_AmanatTableAdapter();
        DataSet1.tbl_AmanatDataTable amanatDT = new DataSet1.tbl_AmanatDataTable();
        DataSet1 DS = new DataSet1();
        DataSet1TableAdapters.View_rptAmanatMemberTableAdapter rptAmanatMemberTA = new DataSet1TableAdapters.View_rptAmanatMemberTableAdapter();
        EntAmanat EntAmanat = new EntAmanat();
        public amanatDAL(string pConnectionString) {
            amanatTA.Connection.ConnectionString = pConnectionString;
            rptAmanatMemberTA.Connection.ConnectionString = pConnectionString;
        }
        public void newConnection(string pConnectionString)
        {
            
        }
        public DataSet1.tbl_AmanatDataTable Get_Amanat()
        {
            amanatTA.ClearBeforeFill = true;
            return amanatTA.GetData();
        }
        public DataSet1 FillDataSet_Amanat()
        {
            amanatTA.Fill(DS.tbl_Amanat);
            return DS;
        }
        public void insert_Amanat(EntAmanat entAmanat)
        {
            amanatTA.spInsertAmanat(entAmanat.am_member_code, entAmanat.am_book_isbn, entAmanat.am_start,
                entAmanat.am_end, entAmanat.am_resid);

        }
        public void update_Amanat(EntAmanat entAmanat)
        {
            amanatTA.spUpdateAmanat(entAmanat.am_member_code, entAmanat.am_book_isbn, entAmanat.am_start,
                entAmanat.am_end, entAmanat.am_resid, entAmanat.am_id);
        }
        public void delete_Amanat(int pAm_id)
        {
            amanatTA.spDeleteAmanat(pAm_id);
        }
        public DataSet1.View_rptAmanatMemberDataTable FillRptAmanat()
        {
            return rptAmanatMemberTA.GetData();
        }

    }
}
