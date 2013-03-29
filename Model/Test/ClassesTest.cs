using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Model.Test
{
    [TestFixture]
    public class ClassesTest
    {
        [Test]
        public void AddClasses()
        {
            var context = new StudentContext();
            context.Classes.Add(new Class { Name = "Grade One" });
            context.SaveChanges();
            Assert.AreEqual(1, context.Classes.Count());
        }

        [Test]
        public void UpdateClasses()
        {
            var context = new StudentContext();
            var classes = context.Classes.FirstOrDefault(p => p.Id == 1);
            if (classes != null)
                classes.Name = "中班";
            context.SaveChanges();
            if (classes != null)
                StringAssert.AreEqualIgnoringCase(classes.Name, "中班");
        }

        [Test]
        public void DeleteClasses()
        {
            var context = new StudentContext();
            context.Classes.Remove(context.Classes.FirstOrDefault(p => p.Id == 1));
            context.SaveChanges();

            Assert.AreEqual(0, context.Classes.Count());
        }

    }
}
