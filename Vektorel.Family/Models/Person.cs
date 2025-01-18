using Vektorel.Family.Abstractions;
using Vektorel.Family.Enums;

namespace Vektorel.Family.Models
{
    public abstract class Person : IHaveChildren
    {
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public List<FamilyPerson> Children { get; private set; }

        public void AddChild(FamilyPerson child)
        {
            if (Children == null)
            {
                Children = new List<FamilyPerson>();
            }
            Children.Add(child);
        }
    }
}
