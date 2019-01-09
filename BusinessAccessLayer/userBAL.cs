using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLayer;
namespace BusinessAccessLayer
{
    public class userBAL
    {

        private userDAL obj_userDAL;
        private EntUser entUser;
        #region "User Access"
        struct bookS
        {
            public bool insert_book;
            public bool edit_book;
        }
        struct Azas
        {
            public bool insert_Aza;
            public bool edit_Aza;
        }

        struct amanatS
        {
            public bool insert_amanat;
            public bool edit_amanat;
        }

        struct userS
        {
            public bool insert_user;
            public bool edit_user;
        }
        struct reportS
        {
            public bool print;
        }

        bookS Access_Book;
        Azas Access_Aza;
        amanatS Access_Amanat;
        userS Access_User;
        reportS Access_report;

        public userBAL(string pConString)
        {
            obj_userDAL = new userDAL(pConString);
        }
        public string strAccess()
        {
            string s = "";
            if (Access_Book.insert_book == true)
            {
                s += 1;
            }
            else
            {
                s += 0;
            }

            if (Access_Book.edit_book == true)
            {
                s += 1;
            }
            else
            {
                s += 0;
            }


            if (Access_Aza.insert_Aza == true)
            {
                s += 1;
            }
            else
            {
                s += 0;
            }
            if (Access_Aza.edit_Aza == true)
            {
                s += 1;
            }
            else
            {
                s += 0;
            }

            if (Access_Amanat.insert_amanat == true)
            {
                s += 1;
            }
            else
            {
                s += 0;
            }
            if (Access_Amanat.edit_amanat == true)
            {
                s += 1;
            }
            else
            {
                s += 0;
            }


            if (Access_User.insert_user == true)
            {
                s += 1;
            }
            else
            {
                s += 0;
            }
            if (Access_User.edit_user == true)
            {
                s += 1;
            }
            else
            {
                s += 0;
            }

            if (Access_report.print == true)
            {
                s += 1;
            }
            else
            {
                s += 0;
            }


            return s;


        }


        public void permissionAccess(string s)
        {
            string sTemp;
            sTemp = s.Substring(1, 2);
            if (sTemp[0].ToString() == "1")
            {
                Access_Book.insert_book = true;
            }
            else
            {
                Access_Book.insert_book = false;
            }
            if (sTemp[1].ToString() == "1")
            {
                Access_Book.edit_book = true;

            }
            else
            {
                Access_Book.edit_book = false;
            }

            sTemp = s.Substring(3, 2);
            if (sTemp[0].ToString() == "1")
            {
                Access_Aza.insert_Aza = true;
            }
            else
            {
                Access_Aza.insert_Aza = false;
            }
            if (sTemp[1].ToString() == "1")
            {
                Access_Aza.edit_Aza = true;

            }
            else
            {
                Access_Aza.edit_Aza = false;
            }

            sTemp = s.Substring(5, 2);
            if (sTemp[0].ToString() == "1")
            {
                Access_Amanat.insert_amanat = true;
            }
            else
            {
                Access_Amanat.insert_amanat = false;
            }
            if (sTemp[1].ToString() == "1")
            {
                Access_Amanat.edit_amanat = true;

            }
            else
            {
                Access_Amanat.edit_amanat = false;
            }

            sTemp = s.Substring(7, 2);
            if (sTemp[0].ToString() == "1")
            {
                Access_User.insert_user = true;
            }
            else
            {
                Access_User.insert_user = false;
            }
            if (sTemp[1].ToString() == "1")
            {
                Access_User.edit_user = true;

            }
            else
            {
                Access_User.edit_user = false;
            }

            sTemp = s.Substring(9, 1);
            if (sTemp[0].ToString() == "1")
            {
                Access_report.print = true;
            }
            else
            {
                Access_report.print = false;
            }


        }

        #endregion
        #region "CRUD"
        public object fill()
        {
            return (from i in obj_userDAL.Get_User()
                    select new
                    {
                        codeKarbar = i.user_nameId,
                        UserNameKarbar = i.user_name,
                        shenaseKarbar = i.user_nameId,
                        kalamehObor = i.user_passId
                    }).ToList();
        }
        public DataSet1.tbl_UserDataTable fillDataTable()
        {
            return obj_userDAL.Get_User();
        }
        public object filter(string searchCode)
        {
            return (from i in obj_userDAL.Get_User()
                    where i.user_nameId.Contains(searchCode)
                    select new
                    {
                        codeKarbar = i.user_nameId,
                        UserNameKarbar = i.user_name,
                        shenaseKarbar = i.user_nameId,
                        kalamehObor = i.user_passId
                    }).ToList();
        }
        public void insert(EntUser entUser)
        {
            entUser.user_access = strAccess();
            obj_userDAL.insert_user(entUser);
        }
        public void delete(string pNameId)
        {
            obj_userDAL.delete_user(pNameId);
        }
        public void updateAccessAndName(EntUser entUser)
        {
            obj_userDAL.updateAccess_name_user(entUser);

        }
        public void updateNote(EntUser entUser)
        {
            obj_userDAL.updateNote_user(entUser);
        }
        public void updatePassword(EntUser entUser)
        {
            obj_userDAL.updatePassword_user(entUser);
        }


        //>>>>> Find User For Login               
        public bool findUser(string pu_nameID, string pu_passID)
        {
            var queryFind = (from i in obj_userDAL.Get_User()
                             where i.user_nameId == pu_nameID && i.user_passId == pu_passID select new { i.user_passId,i.user_nameId})
                           .Count();
            if (queryFind > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //>>>>>> Duplicate  NameID
        public bool findIdUser(string pUNameID)
        {
            var queryFind = (from i in obj_userDAL.Get_User()
                             where i.user_nameId.Contains(pUNameID)
                             select i.user_nameId)
                           .Count();
            if (queryFind > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // '>>>>>> Find Info User

        //>>>1 -NumberID User
        public int findNumberIDUser(string pU_NameID)
        {
            return Convert.ToInt32((from i in obj_userDAL.Get_User()
                                    where i.user_nameId == pU_NameID
                                    select i.user_numberId
                                    ).Single());
        }
        // >>>2 -Name User
        public string findNameUser(string pU_NameID)
        {
            return (from i in obj_userDAL.Get_User()
                    where i.user_nameId == pU_NameID
                    select i.user_name).Single();
        }
        //>>>3 - Note User
        public string findNoteUser(string pU_NameID)
        {
           var queryNote= (from i in obj_userDAL.Get_User()
                    where i.user_nameId.Contains(pU_NameID)
                    select i.user_note).Single();
            return queryNote.ToString();
        }
        // >>>4 - Access User
        public void findAccess(string pU_NameID)
        {
            var queryAccess = (from i in obj_userDAL.Get_User()
                             where i.user_nameId == pU_NameID
                               select i.user_Access).Single();
            permissionAccess(queryAccess.ToString());
        }
        //>>>> 5 Find NameID
        public string findNameIDUser(string pU_NameID)
        {
            return (from i in obj_userDAL.Get_User()
                    where i.user_nameId == pU_NameID
                    select i.user_nameId).Single();
        }
        #endregion


    }
}
