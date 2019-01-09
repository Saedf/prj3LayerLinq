using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BusinessAccessLayer;
using BusinessEntity;
using System.Windows.Forms;

namespace PresentationLayer.Memeber
{
    public partial class frmMember : Form
    {
        public frmMember()
        {
            InitializeComponent();
        }
        memberBAL obj_member;
        EntMember entMember;
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

        private void frmMember_Load(object sender, EventArgs e)
        {
            obj_member = new memberBAL(Properties.Settings.Default.conasli);
            entMember = new EntMember();
            DataGridView1.DataSource = obj_member.fill();

        }

        private void txtsh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back));

        }

        private void txtfname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsNumber(e.KeyChar);
        }



        private void txtfname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtlname.Focus();
            }
        }

        private void txtlname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtsh.Focus();
            }
        }

        private void txtsh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtfather.Focus();
            }
        }

        private void txtfather_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtbirthday.Focus();
            }
        }

        private void txtbirthday_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cmbgride.Focus();
            }
        }

        private void cmbgride_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtozviat.Focus();
            }
        }

        private void txtozviat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtzamen.Focus();
            }
        }

        private void txtzamen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtzamentell.Focus();
            }
        }

        private void txtzamentell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txttell.Focus();
            }
        }

        private void txttell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtadress.Focus();
            }
        }

        private void txtadress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btn_browse.Focus();
            }
        }

        private void txtcode_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtcode.Text != "")
            {
                entMember.m_code = int.Parse(txtcode.Text);
                if (obj_member.findCode(entMember.m_code))
                {
                    errorProvider1.SetError(txtcode, "کد عضویت تکراری است");
                    txtcode.SelectAll();
                    btn_insert.Enabled = false;
                }
                else
                {
                    btn_insert.Enabled = true;
                }
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.FilterIndex = 1;
            op.Filter = "Jpg Files|*.Jpg|jpeg Files|*.Jpeg";
            if (op.ShowDialog() == DialogResult.OK)
            {
                picmember.ImageLocation = op.FileName;

            }
            //DialogResult result = openFileDialog1.ShowDialog();
            //Bitmap input;
            //Bitmap output;
            //long size = 100;
            //long wid = 0;
            //long hgt = 0;
            //string picName = openFileDialog1.FileName;
            //if (result == DialogResult.OK)
            //{

            //    try
            //    {
            //        input = (Bitmap)Bitmap.FromFile(picName);

            //    }
            //    catch (Exception ex)
            //    {

            //        input = new Bitmap(150, 150);
            //        Graphics grafinput = Graphics.FromImage(input);
            //        grafinput.FillRectangle(new SolidBrush(Color.FromArgb(255, 204, 204, 204)), 0, 0, 150, 150);
            //        grafinput.Dispose();

            //    }
            //    if (size > 0)
            //    {
            //        if (input.Height > input.Width)
            //        {
            //            wid = (size * input.Width) / input.Height;
            //            hgt = size;
            //        }
            //        else
            //        {
            //            hgt = (size * input.Height) / input.Width;
            //            wid = size;
            //        }
            //    }
            //    else if (hgt > 0)
            //    {
            //        wid = (hgt * input.Width) / input.Height;

            //    }
            //    else if (hgt < 0)
            //    {
            //        hgt = (wid * input.Height) / input.Width;
            //    }

            //    if (hgt < 1)
            //    {
            //        output = input;
            //    }
            //    else
            //    {

            //        output = new Bitmap(input, (int)wid, (int)hgt);
            //    }
            //    picmember.Image = output;
            //    input.Dispose();
            //}
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime resultdt;

                //if (DateTime.TryParse(date_str, out result))
                //{
                //}
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
                    entMember.m_code = int.Parse(txtcode.Text);
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
                    obj_member.insert(entMember);
                    DataGridView1.DataSource = obj_member.fill();
                    clearAll();
                    FMessegeBox.FarsiMessegeBox.Show("اطلاعات عضو جدید با موفقیت ثبت شد", "ثبت اطلاعات", FMessegeBox.FMessegeBoxButtons.Ok, FMessegeBox.FMessegeBoxIcons.Information);
                }
            }
            catch (Exception ex)
            {

                // FMessegeBox.FarsiMessegeBox.Show("اطلاعات عضو را به درستی وارد نمائید","هشدار",FMessegeBox.FMessegeBoxButtons.Ok,FMessegeBox.FMessegeBoxIcons.Error);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
