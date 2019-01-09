using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_editAza_Click(object sender, EventArgs e)
        {

        }

        private void rbtn_NewOzv_Click(object sender, EventArgs e)
        {
            Memeber.frmMember frmMember = new Memeber.frmMember();
            frmMember.ShowDialog();
        }

        private void rbtn_editAza_Click(object sender, EventArgs e)
        {
            Memeber.frmEditMember frmEdit = new Memeber.frmEditMember();
            frmEdit.ShowDialog();
        }
    }
}
