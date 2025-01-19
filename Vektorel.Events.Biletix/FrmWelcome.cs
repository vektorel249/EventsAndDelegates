using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.Events.Biletix
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void btnOrganizer_Click(object sender, EventArgs e)
        {
            var f = new FrmOrganizer();
            f.Show();
        }

        private void btnParticipant_Click(object sender, EventArgs e)
        {
            var f = new FrmParticipant();
            f.Show();
        }
    }
}
