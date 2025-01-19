using Vektorel.Events.Biletix.Models;

namespace Vektorel.Events.Biletix;

public partial class FrmOrganizer : Form
{
    private Repository dataRepository;
    public FrmOrganizer()
    {
        InitializeComponent();
        dataRepository = Repository.GetRepository();
        dataRepository.OnParticipantAttended += AddNewParticipantToOrganization;
        dataRepository.OnParticipantLeft += RemoveParticipantFromOrganization;
    }

    private void RemoveParticipantFromOrganization(Organization organization)
    {
        organization.Count--;

        var selected = dgvEvents.SelectedRows[0].DataBoundItem as Organization;
        if (selected == null)
        {
            return;
        }

        if (selected.Name == organization.Name)
        {
            prbStatus.Maximum = organization.Limit;
            prbStatus.Value = organization.Count;
        }
    }

    private void AddNewParticipantToOrganization(Organization organization)
    {
        organization.Count++;

        var selected = dgvEvents.SelectedRows[0].DataBoundItem as Organization;
        if (selected == null)
        {
            return;
        }

        if (selected.Name == organization.Name)
        {
            prbStatus.Maximum = organization.Limit;
            prbStatus.Value = organization.Count;
        }
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

        dataRepository.AddOrganization(org);
    }

    private void FrmOrganizer_Load(object sender, EventArgs e)
    {
        dgvEvents.DataSource = dataRepository.GetOrgatizations();
    }

    private void dgvEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        var org = dgvEvents.SelectedRows[0].DataBoundItem as Organization;
        if (org == null)
        {
            return;
        }

        prbStatus.Maximum = org.Limit;
        prbStatus.Value = org.Count;
    }
}
