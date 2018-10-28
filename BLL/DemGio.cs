using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public partial class DemGio : UserControl
    {
        public DemGio()
        {
            InitializeComponent();
            demh.Start();
        }
        int m = 15;
        int s = 00;

        private void demh_Tick(object sender, EventArgs e)
        {
            s--;
            if (s <= 0)
            {
                s = 59;
                m--;
            }
            if (s < 10)
            {
                giay.Text = "0" + s.ToString();
            }
            else { giay.Text = s.ToString(); }
            if (m < 10)
            {
                phut.Text = "0" + m.ToString();
            }
            else { phut.Text = m.ToString(); }
        }
    }
}
