using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anijobs0.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Usuario u = new Usuario("s", "m", "1", "sm@g.com", 23456, new DateTime(2013, 12, 20));
            Assert.AreEqual("m", u.Apellido);
            //Assert.AreEqual("s", u.Apellido);

        }
    }
}
