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
    public partial class Form1 : Form
    {
        private void btnketqua_Click(object sender, EventArgs e)
        {
            listBox1 .Items.Clear();
            int so=Convert.ToInt32(txtnhapso.Text);
            for (int i = 1; ; i <= so; i++);
            {
                if (so % i == 0)
                {
                    listBox1.Items .Add (i.ToString());
                }
            }

        }
    }

    public partial class FrmMain : Form
{
    public FrmMain()
    {
        
    }

    
