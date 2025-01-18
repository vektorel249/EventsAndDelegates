using Vektorel.Family.Abstractions;

namespace Vektorel.Family.Models;

public class FamilyPerson : Person, IPerson
{
    private List<FamilyPerson> siblings;

    public FamilyPerson()
    {
        siblings = new List<FamilyPerson>();
        OnSiblingAdded += AddSiblingToSent;
    }
    public IPerson Father { get; private set; }
    public IPerson Mother { get; private set; }
    public event SiblingAdded OnSiblingAdded;

    public void AddSibling(IPerson sibling)
    {
        if (sibling is FamilyPerson s)
        {
            siblings.Add(s);
            s.OnSiblingAdded.Invoke(this);
        }
    }

    private void AddSiblingToSent(FamilyPerson familyPerson)
    {
        siblings.Add(familyPerson);
    }

    public IReadOnlyList<IPerson> GetSiblings()
    {
        return siblings;
    }

    public void SetParents(IPerson father, IPerson mother)
    {
        if (father is not null)
        {
            Father = father;
            (father as IHaveChildren).AddChild(this);
        }
        if (mother is not null)
        {
            Mother = mother;
            (mother as IHaveChildren).AddChild(this);
        }
    }
}
