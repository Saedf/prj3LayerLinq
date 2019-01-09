using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLayer;
namespace BusinessAccessLayer
{
    public class memberBAL
    {
        memberDAL obj_memberDAL;
        EntMember entMember = new EntMember();
        public memberBAL(string pConStr)
        {
            obj_memberDAL = new memberDAL(pConStr);
        }

        public void insert(EntMember entMember)
        {
            obj_memberDAL.insert_member(entMember);
        }
        public void update(EntMember entMember)
        {
            obj_memberDAL.update_member(entMember);
        }
        public void delete(int pDelCode)
        {
            obj_memberDAL.delete_memberByCode(pDelCode);
        }
        public object fill()
        {
            var queryFill = from member in obj_memberDAL.get_member()
                            select
                  new
                  {
                      codeOzviat = member.m_code,
                      firstname = member.m_fname,
                      lastName = member.m_lname,
                      shNumber = member.m_sh,
                      NameFather = member.m_father,
                      birthday = member.m_birthday,
                      gride = member.m_gride,
                      dateOzviat = member.m_ozviat,
                      nameZamen = member.m_zamen,
                      tellZamen = member.m_zamenTell,
                      address = member.m_address,
                      phoneNumber = member.m_tell,
                      picture = member.m_pic
                  };
            return queryFill.ToList();
        }
        public DataSet1.tbl_memberDataTable fillDataTable()
        {
            return obj_memberDAL.get_member();
        }
        public DataSet1 fillDataSet()
        {
            return obj_memberDAL.fill_dataset_Member();
        }
        public object filterCode(int pSearchCode)
        {
            return (from i in obj_memberDAL.get_member()
                    where (i.m_code.ToString().Contains(pSearchCode.ToString()))
                    select new
                    {
                        codeOzviat = i.m_code,
                        firstname = i.m_fname,
                        lastName = i.m_lname,
                        shNumber = i.m_sh,
                        NameFather = i.m_father,
                        birthday = i.m_birthday,
                        gride = i.m_gride,
                        dateOzviat = i.m_ozviat,
                        nameZamen = i.m_zamen,
                        tellZamen = i.m_zamenTell,
                        address = i.m_address,
                        phoneNumber = i.m_tell,
                        picture = i.m_pic
                    }).ToList();
        }
        public object filterLname(string pSearchLname)
        {
            return (from i in obj_memberDAL.get_member()
                    where (i.m_lname.ToString().Contains(pSearchLname.ToString()))
                    select new
                    {
                        codeOzviat = i.m_code,
                        firstname = i.m_fname,
                        lastName = i.m_lname,
                        shNumber = i.m_sh,
                        NameFather = i.m_father,
                        birthday = i.m_birthday,
                        gride = i.m_gride,
                        dateOzviat = i.m_ozviat,
                        nameZamen = i.m_zamen,
                        tellZamen = i.m_zamenTell,
                        address = i.m_address,
                        phoneNumber = i.m_tell,
                        picture = i.m_pic
                    }).ToList();
        }
        public bool findCode(int searchCode)
        {
            var queryFind = (from i in obj_memberDAL.get_member() where i.m_code == searchCode select i).Count();
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
