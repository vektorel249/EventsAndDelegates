using Vektorel.Family.Models;

namespace Vektorel.Family.Abstractions;

public interface IPerson
{
    public void SetParents(IPerson father, IPerson mother);
    public void AddSibling(IPerson sibling);
    public IReadOnlyList<IPerson> GetSiblings();
}

public interface IHaveChildren
{
    public void AddChild(FamilyPerson child);
}

public delegate void SiblingAdded(FamilyPerson sibling);
