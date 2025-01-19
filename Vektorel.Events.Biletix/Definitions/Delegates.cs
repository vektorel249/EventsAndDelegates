using Vektorel.Events.Biletix.Models;

namespace Vektorel.Events.Biletix.Definitions;

public delegate void OrganizationCreated(Organization organization);
public delegate void ParticipantAttended(Organization organization);
public delegate void ParticipantLeft(Organization organization);
