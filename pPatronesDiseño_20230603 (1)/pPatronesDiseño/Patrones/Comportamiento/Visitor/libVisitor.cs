using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pPatronesDiseño.Patrones.Comportamiento.Visitor
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
    public interface IVisitor
    {
        void Visit(IElement element);
    }
    public class Student : IElement
    {
        public string StudentName { get; set; }

        public Student(string name)
        {
            StudentName = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    public class Physician : IVisitor
    {
        public string Name { get; set; }

        public Physician(string name)
        {
            Name = name;
        }

        public void Visit(IElement element)
        {
            Student student = (Student)element;
            MessageBox.Show($"Physician: {Name} conducted a " +
                $"health checkup of the student: {student.StudentName}");
        }
    }
    class Cook : IVisitor
    {
        public string Name { get; set; }

        public Cook(string name)
        {
            Name = name;
        }

        public void Visit(IElement element)
        {
            Student student = (Student)element;
            MessageBox.Show($"Cook: {Name} gave the healthy " +
                $"meal to the student: {student.StudentName}");
        }
    }
    public class College
    {
        private readonly List<IElement> elements;
        public College()
        {
            elements = new List<IElement>
            {
               new Student("Todd"),
               new Student("Maggie"),
               new Student("Stella")
            };
        }

        public void PerformOperation(IVisitor visitor)
        {
            foreach (var student in elements)
            {
                student.Accept(visitor);
            }
        }
    }

}
