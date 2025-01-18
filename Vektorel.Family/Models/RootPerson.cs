using Vektorel.Family.Abstractions;
using Vektorel.Family.Enums;

namespace Vektorel.Family.Models;

public class RootPerson : Person, IPerson
{
    public RootPerson()
    {
        Gender = Gender.Male;
    }

    public void AddSibling(IPerson sibling)
    {
        throw new InvalidOperationException("Bu işlem imkansız");
    }

    public IReadOnlyList<IPerson> GetSiblings()
    {
        return new List<IPerson>();
    }

    public void SetParents(IPerson father, IPerson mother)
    {
        throw new InvalidOperationException("Bu işlem imkansız");
    }
}
