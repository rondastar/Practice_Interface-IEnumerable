using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Interface_IEnumerable
{
    internal class SchoolClass : IEnumerable
    {

        List<Student> _classRoster = new List<Student>();

        public List<Student> ClassRoster { get => _classRoster; }

        public void AddStudent(Student student)
        {
            _classRoster.Add(student);
        }

        public void AddStudent(string name)
        {
            ClassRoster.Add(new Student(name));
        }

        // IEnumerable Method
        public IEnumerator GetEnumerator()
        {
            // pass in arguement with ref keyword
            return new ClassRosterEnumerator(ref _classRoster);
        }

        // Internal Class
        private class ClassRosterEnumerator : IEnumerator
        {
            // Fields
            int index = -1;
            List<Student> Students;

            // Constructor
            // place ref in front of parameter
            public ClassRosterEnumerator(ref List<Student> students)
            {
                Students = students;
            }

            // Property
            public object Current => Students[index];

            // MoveNext is called to iterate to the next index
            public bool MoveNext()
            {
                // Increments to the next index
                index++; 
                
                // Indicates if at the end of the collection
                // If no more elements to look at, return false; else return true
                if(index >= Students.Count)
                {
                    return false;
                }

                else
                {
                    return true;
                }
            }

            // Reset sets the index back to before the first element
            public void Reset()
            {
                index = -1;
            }
        }

    } // class
} // namespace
