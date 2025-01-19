using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.Events.Biletix.Models;

namespace Vektorel.Events.Biletix
{
    public partial class FrmParticipant : Form
    {
        private Repository dataRepository;
        private Participant participant;
        public FrmParticipant()
        {
            InitializeComponent();
            
            dataRepository = Repository.GetRepository();
            dataRepository.OnOrganizationCreated += WriteEventOnNotifications;
        }

        private void WriteEventOnNotifications(Organization organization)
        {
            rtbNotifications.AppendText($"[YENİ ORG] - {organization.StartDate} - {organization.Name}\n");
        }

        private void FrmParticipant_Load(object sender, EventArgs e)
        {
            lstOrganizations.DisplayMember = nameof(Organization.Name);
            lstOrganizations.DataSource = dataRepository.GetOrgatizations();
        }

        private void btnAttend_Click(object sender, EventArgs e)
        {
            if (participant != null)
            {
                //Zaten bilet aldı
                return;
            }
            var org = lstOrganizations.SelectedItem as Organization;
            if (org == null)
            {
                MessageBox.Show("Önce bir etkinlik seçmelisiniz");
                return;
            }
            participant = new Participant() { Organization = org };
            dataRepository.AttendToOrganization(participant);
            btnAttend.Enabled = false;
            btnLeave.Enabled = true;
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            if (participant == null)
            {
                //bileti yoksa çık
                return;
            }
            var or = lstOrganizations.SelectedItem as Organization;
            if (or == null)
            {
                MessageBox.Show("Önce bir etkinlik seçmelisiniz");
                return;
            }

            dataRepository.LeaveFromOrganization(participant);
            participant = null; // yeniden bilet alabilir
            btnAttend.Enabled = true;
            btnLeave.Enabled = false;
        }
    }
}
