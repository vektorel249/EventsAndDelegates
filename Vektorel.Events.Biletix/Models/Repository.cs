using System.Collections.Generic;
using System.ComponentModel;

namespace Vektorel.Events.Biletix.Models
{
    internal class Repository
    {
        public BindingList<Organization> Organizations { get; set; }
        public BindingList<Participant> Participants { get; set; }
    }
}
