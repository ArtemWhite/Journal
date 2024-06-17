using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal
{
    partial class Auditories
    {
        public override string ToString()
        {
            return Number.ToString();

        }
    }
    partial class Subjects
    {
        public override string ToString()
        {
            return Name.ToString();

        }
    }
    partial class Groups
    {
        public override string ToString()
        {
            return $"{Id}. {Name}";

        }
    }
    partial class Teacher
    {
        public override string ToString()
        {
            return Name.ToString();

        }
    }
    partial class Student
    {
        public override string ToString()
        {
            return $"{Name}. {GroupId}";

        }
    }
}
