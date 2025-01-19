using Vektorel.Events.Biletix.Models;

namespace Vektorel.Events.Biletix
{
    public partial class FrmOrganizer : Form
    {
        public FrmOrganizer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var org = new Organization
            {
                Name = txtName.Text,
                StartDate = dtpStart.Value,
                EndDate = dtpEnd.Value,
                Limit = (int)nudLimit.Value
            };
        }
    }
}
