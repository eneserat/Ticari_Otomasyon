using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
            this.xtraTabPage1.Controls.Add(reportViewer1);
            reportViewer1.Dock = DockStyle.Fill; // Ekranı kapla
            reportViewer1.BringToFront();
        }
    }
}
