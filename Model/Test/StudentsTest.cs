using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Model.Test
{
    [TestFixture]
    public class StudentsTest
    {
        [Test]
        public void AddStudents()
        {
            var context = new StudentContext();


            var cl = context.Classes.FirstOrDefault(p => p.Id == 1);


            var student = new Student() { Name = "Tom", Class = cl };

            context.SaveChanges();

            Assert.AreEqual(1, context.Students.Count());
        }


        [Test]
        public void UpdateStudents()
        {
            var context = new StudentContext();
            var students = context.Students.FirstOrDefault(p => p.Id == 1);
            if (students != null)
                students.Name = "tom";
            context.SaveChanges();
            if (students != null)
                StringAssert.AreEqualIgnoringCase(students.Name, "tom");
        }

        [Test]
        public void DeleteStudents()
        {
            var context = new StudentContext();
           
            context.Students.Remove(context.Students.FirstOrDefault(p => p.Id == 1));
           
            context.SaveChanges();

            Assert.AreEqual(0, context.Students.Count());
        }

    }
}
