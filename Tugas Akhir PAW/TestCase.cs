using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tugas_Akhir_PAW
{
    [TestFixture]
    class TestCase
    {
        [TestCase]
        public void Day()
        {
            Sewakos p = new Sewakos();
            Assert.AreEqual(70000, p.Day(70000,1));
        }

        [TestCase]
        public void Month()
        {
            Sewakos p = new Sewakos();
            Assert.AreEqual(700000, p.Month(70000,1));
        }
    }
}
