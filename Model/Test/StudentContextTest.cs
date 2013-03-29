using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Model.Test
{
    [TestFixture]
    public class StudentContextTest
    {
        [Test]
        public void CreateDataBase()
        {
            var context = new StudentContext();
            context.Database.Delete();
            context.Database.Create();
        }  
    }
}
