using System.ComponentModel;
using Vektorel.Events.Biletix.Definitions;

namespace Vektorel.Events.Biletix.Models;

public class Repository
{
    private static Repository instance;
    /// <summary>
    /// Bu işlemi kullanamazsınız. Bu işlem için static GetRepository() kullanabilirsiniz
    /// </summary>
    private Repository()
    {
        Organizations = new BindingList<Organization>();
        Participants = new BindingList<Participant>();
    }

    public static Repository GetRepository()
    {
        if (instance == null)
        {
            instance = new Repository();
        }

        return instance;
    }

    #region Properties
    //Burada List de kullanılabilir ama değişkenlik olduğunda list ekranda güncelleme yapacak bildirimleri sağlamaz
    private BindingList<Organization> Organizations { get; set; }
    private BindingList<Participant> Participants { get; set; } 

    public event OrganizationCreated OnOrganizationCreated;
    public event ParticipantAttended OnParticipantAttended;
    public event ParticipantLeft OnParticipantLeft;
    #endregion

    public BindingList<Organization> GetOrgatizations()
    {
        return Organizations;
    }

    public void AddOrganization(Organization organization)
    {
        //listeye organizasyonu ekle
        Organizations.Add(organization);

        // eklendiğini duymak isteyenlere bildir
        OnOrganizationCreated?.Invoke(organization);
    }

    public void AttendToOrganization(Participant participant)
    {
        Participants.Add(participant);
        OnParticipantAttended?.Invoke(participant.Organization);
    }

    public void LeaveFromOrganization(Participant participant)
    {
        Participants.Remove(participant);
        OnParticipantLeft?.Invoke(participant.Organization);
    }
}


//Singleton Pattern