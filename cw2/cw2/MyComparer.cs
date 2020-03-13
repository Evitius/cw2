using System;
using System.Collections.Generic;

namespace cw2
{
    public class OwnComparer : IEqualityComparer<Student>

    {
        public bool Equals(Student x, Student y)
        {
            return StringComparer
            .InvariantCultureIgnoreCase
            .Equals($"{x.Name} {x.Surname} {x.Id}",
            $"{y.Name} {y.Surname} {y.Id}");
            throw new NotImplementedException();
        }

        public int GetHashCode(Student s)
        {
            return StringComparer
                .OrdinalIgnoreCase
                .GetHashCode($"{s.Surname} {s.Name} {s.Id}");
        }
    }
}