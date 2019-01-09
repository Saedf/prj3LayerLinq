using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BusinessAccessLayer;
using BusinessEntity;
namespace PresentationLayer.Memeber
{
    public partial class frmEditMember : Form
    {
        public frmEditMember()
        {
            InitializeComponent();
        }
        memberBAL obj_memberBAL;
        EntMember entMember;
        BindingSource bs_member = new BindingSource();
        int s_index;
        public void clearAll()
        {
            txtcode.Clear();
            txtfname.Clear();
            txtlname.Clear();
            txtsh.Clear();
            txtfather.Clear();
            txtozviat.Clear();
            cmbgride.Text = "";
            txtbirthday.Clear();
            txtzamen.Clear();
            txtzamentell.Clear();
            txtadress.Clear();
            txttell.Clear();
            picmember.Image = null;
        }
        private void frmEditMember_Load(object sender, EventArgs e)
        {

            obj_memberBAL = new memberBAL(Properties.Settings.Default.conasli);
            entMember = new EntMember();
            bs_member.DataSource = obj_memberBAL.fill();
            DataGridView1.DataSource = bs_member;
            btn_browse.Enabled =btn_delete.Enabled = btn_update.Enabled = false;
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtsearch.Clear();
            btn_browse.Enabled = btn_delete.Enabled = btn_update.Enabled = true;
           // int indexRow = bs_member.Position;
            try
            {
                txtcode.Text= Convert.ToString(DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
              
                txtfname.Text = Convert.ToString(DataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                txtlname.Text = Convert.ToString(DataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                txtsh.Text = Convert.ToString(DataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                txtfather.Text = Convert.ToString(DataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                txtbirthday.Text = Convert.ToString(DataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                cmbgride.Text = Convert.ToString(DataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                txtozviat.Text = Convert.ToString(DataGridView1.SelectedRows[0].Cells[7].Value.ToString());
                txtzamen.Text = Convert.ToString(DataGridView1.SelectedRows[0].Cells[8].Value.ToString());
                txtzamentell.Text= Convert.ToString(DataGridView1.SelectedRows[0].Cells[9].Value.ToString());
                txtadress.Text= Convert.ToString(DataGridView1.SelectedRows[0].Cells[10].Value.ToString());
                txttell.Text = Convert.ToString(DataGridView1.SelectedRows[0].Cells[11].Value.ToString());

                //byte[] imgdata =BitConverter.GetBytes( DataGridView1.SelectedRows[indexRow].Cells[12].Value);
                //byte[] buffer = BitConverter.GetBytes(imgdata);
                //MemoryStream ms = new MemoryStream(buffer);
                //picmember.Image = Image.FromStream(ms);



            }
            catch (Exception ex)
            {

                FMessegeBox.FarsiMessegeBox.Show(ex.Message);
            }
        }

        private void CmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsearch.Clear();
            s_index = CmbSearch.SelectedIndex;
            if (s_index==0)
            {
                Label13.Text = "کد عضویت:";
            }
            else if (s_index==1)
            {
                Label13.Text = "نام خانوادگی:";
            }
            else
            {
                Label13.Text= "جستجو:";

            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                clearAll();
                if (txtsearch.Text != "" && s_index == 0)
                {
                    bs_member.DataSource = obj_memberBAL.filterCode(int.Parse(txtsearch.Text));
                    DataGridView1.DataSource = bs_member;
                }
                else if (txtsearch.Text != "" && s_index == 1)
                {
                    bs_member.DataSource = obj_memberBAL.filterLname(txtsearch.Text);
                    DataGridView1.DataSource = bs_member;
                }
                else
                {
                    bs_member.DataSource = obj_memberBAL.fill();
                    DataGridView1.DataSource = bs_member;
                }
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtsearch, "کد جستجو را درست وارد نمائید");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime resultdt;
                errorProvider1.Clear();
                 errorProvider1.Clear();
                if (txtcode.Text == "")
                {
                    errorProvider1.SetError(txtcode, "کد عضویت  را وارد کنید");
                }
                else if (txtfname.Text == "")
                {
                    errorProvider1.SetError(txtfname, "نام را وارد کنید");
                }
                else if (txtlname.Text == "")
                {
                    errorProvider1.SetError(txtlname, "نام خانوادگی را وارد کنید");
                }
                else if (txtsh.Text == "")
                {
                    errorProvider1.SetError(txtsh, "شماره شناسنامه را  وارد کنید");
                }
                else if (txtfather.Text == "")
                {
                    errorProvider1.SetError(txtfather, "نام پدر را وارد کنید");
                }
                else if (!DateTime.TryParse(txtbirthday.Text, out resultdt))
                {
                    errorProvider1.SetError(txtbirthday, " تاریخ تولد را درست وارد کنید");
                }
                else if (cmbgride.SelectedIndex == -1)
                {
                    errorProvider1.SetError(cmbgride, "مدرک تحصیلی را انتخاب کنید");
                }
                else if (txtzamen.Text == "")
                {
                    errorProvider1.SetError(txtzamen, "نام ضامن را وارد کنید");
                }
                else if (txtzamentell.Text == "")
                {
                    errorProvider1.SetError(txtzamentell, "شماره تلفن ضامن را وارد کنید");
                }
                else if (!DateTime.TryParse(txtozviat.Text, out resultdt))
                {
                    errorProvider1.SetError(txtozviat, "تاریخ عضویت را درست وارد کنید");
                }
                else if (txttell.Text == "")
                {
                    errorProvider1.SetError(txttell, "شماره تلفن عضو را وارد کنید");
                }
                else if (txtadress.Text == "")
                {
                    errorProvider1.SetError(txtadress, "نشانی عضو را وارد کنید");
                }
                //else if (picmember.Image ==null)
                //{
                //    errorProvider1.SetError(btn_browse, "عکس را انتخاب کنید");
                //}
                else
                {
                    //  '''''''''tabdile ax az jpeg be byte''''''''''''
                    MemoryStream strmemory = new MemoryStream();
                    picmember.Image.Save(strmemory, picmember.Image.RawFormat);
                   byte[] buffer = strmemory.GetBuffer();
                    // strmemory.Position = 0;
                    // strmemory.Read(buffer, 0, Convert.ToInt32(strmemory.Length));
                    // '''''''entesabe maghadir member'''''''''''
                    entMember.m_code = int.Parse(DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    entMember.m_lname = txtlname.Text;
                    entMember.m_fname = txtfname.Text;
                    entMember.m_sh = int.Parse(txtsh.Text);
                    entMember.m_father = txtfather.Text;
                    entMember.m_gride = cmbgride.SelectedItem.ToString();
                    entMember.m_birthday = txtbirthday.Text;
                    entMember.m_zamen = txtzamen.Text;
                    entMember.m_zamenTell = txtzamentell.Text;
                    entMember.m_ozviat = txtozviat.Text;
                    entMember.m_tell = txttell.Text;
                    entMember.m_address = txtadress.Text;
                    entMember.m_pic = buffer;
                    obj_memberBAL.update(entMember);
                    bs_member.DataSource = obj_memberBAL.fill();
                    DataGridView1.DataSource = bs_member;
                    clearAll();
                    FMessegeBox.FarsiMessegeBox.Show("اطلاعات عضو جدید با موفقیت ثبت شد", "ثبت اطلاعات", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Information);
                }
            }
            catch (Exception ex)
            {

                FMessegeBox.FarsiMessegeBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = FMessegeBox.FarsiMessegeBox.Show("آیا می خواهید اطلاعات حذف شوند؟","حذف اطلاعات",FMessegeBox.FMessegeBoxButtons.YesNo,FMessegeBox.FMessegeBoxIcons.Question);
            if (result==DialogResult.Yes)
            {
                try
                {
                    entMember.m_code=int.Parse(DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    obj_memberBAL.delete(entMember.m_code);
                    bs_member.DataSource = obj_memberBAL.fill();
                    DataGridView1.DataSource = bs_member;
                    clearAll();
                    txtsearch.Clear();
                }
                catch (Exception ex)
                {

                    FMessegeBox.FarsiMessegeBox.Show(ex.Message);
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
