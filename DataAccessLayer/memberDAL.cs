using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
namespace DataAccessLayer
{
    public class memberDAL
    {
         
        DataSet1TableAdapters.tbl_memberTableAdapter memberTA = new DataSet1TableAdapters.tbl_memberTableAdapter();
        DataSet1.tbl_memberDataTable memberDT = new DataSet1.tbl_memberDataTable();
        DataSet1 DS = new DataSet1();
        EntMember EntMember = new EntMember();
        public memberDAL(string pConnectionString) { memberTA.Connection.ConnectionString = pConnectionString; }
        
        public DataSet1.tbl_memberDataTable get_member(){
            memberTA.Fill(DS.tbl_member);
            return memberTA.GetData();
        }
        public DataSet1 fill_dataset_Member()
        {
            memberTA.Fill(DS.tbl_member);
            return DS;
        }
        public void insert_member(EntMember pmember)
        {
            memberTA.spInsertMember(pmember.m_code, pmember.m_fname, pmember.m_lname, pmember.m_sh, pmember.m_father,
                pmember.m_birthday, pmember.m_gride, pmember.m_ozviat, pmember.m_zamen, pmember.m_zamenTell, pmember.m_address,
                pmember.m_tell, pmember.m_pic);
        }
        public void update_member(EntMember pmember)
        {
            memberTA.spUpdateMember(pmember.m_code, pmember.m_fname, pmember.m_lname, pmember.m_sh, pmember.m_father,
                pmember.m_birthday, pmember.m_gride, pmember.m_ozviat, pmember.m_zamen, pmember.m_zamenTell,
                pmember.m_address, pmember.m_tell, pmember.m_pic);
        }
        public void delete_memberByCode(int pm_code)
        {
            memberTA.spDeleteMember(pm_code);
        }
        
    }
}
