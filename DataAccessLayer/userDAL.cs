using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
namespace DataAccessLayer
{
   public class userDAL
    {
        DataSet1TableAdapters.tbl_UserTableAdapter userTA = new DataSet1TableAdapters.tbl_UserTableAdapter();
        DataSet1.tbl_UserDataTable userDT = new DataSet1.tbl_UserDataTable();
        EntUser EntUser = new EntUser();
        public userDAL(string pConnectionString) { userTA.Connection.ConnectionString = pConnectionString; }
        public DataSet1.tbl_UserDataTable Get_User()
        {
            userTA.ClearBeforeFill = true;
            return userTA.GetData();
        }
        public void insert_user(EntUser entUser)
        {
            userTA.spInsertUser(entUser.user_nameID, entUser.user_passID, entUser.user_name,
                entUser.user_access, entUser.user_note);

        }
        public void delete_user(string u_nameID)
        {
            userTA.spDeleteUser(u_nameID);
        }
        public void updateAccess_name_user(EntUser entUser)
        {
            userTA.spUpdateUserAccessUser(entUser.user_nameID, entUser.user_access, entUser.user_name);
        }
        public void updateNote_user(
            EntUser entUser)
        {
            userTA.spUpdateNoteUser(entUser.user_nameID, entUser.user_note);
        }
        public void updatePassword_user(EntUser entUser)
        {
            userTA.spUpdateUser(entUser.user_nameID, entUser.user_passID);
        }

    }
}
