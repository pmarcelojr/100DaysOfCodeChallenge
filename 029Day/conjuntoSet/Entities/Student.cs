using System;

namespace conjuntoSet.Entities
{
    class Student
    {
        public int CodeStudent { get; set; }

        public Student(int codeStudent)
        {
            CodeStudent = codeStudent;
        }

        public override int GetHashCode()
        {
            return CodeStudent.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if(!(obj is Student))
            {
                return false;
            }
            Student other = obj as Student;
            return CodeStudent.Equals(other.CodeStudent);
        }
    }
}