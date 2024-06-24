using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_from
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            //kiểm tra username và password đúng thì mở form main, ngược lại thì hiện messgerbox
            if (txtdangnhap .Text=="admin"&&txtbaomat .Text =="123")
            {
                
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("sai rồi nhập lại đi","lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
