using Microsoft.VisualStudio.TestTools.UnitTesting;
using Лаба_1.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_1.AppData.Tests
{
    [TestClass()]
    public class ConDBTests
    {
        [TestMethod()]
        public void CheckTest()
        {
            spravochniki sp = new spravochniki() { aadress = "asd", full_name="asd", id_schet=1 };

            bool actual = ConDB.Check(sp);

            Assert.AreEqual(true, actual);
        }

        [TestMethod()]
        public void CheckTest1()
        {
            spravochniki sp = new spravochniki() { aadress = "", full_name = "", id_schet = 1 };

            bool actual = ConDB.Check(sp);

            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void CheckTest2()
        {
            spravochniki sp = new spravochniki() { aadress = null, full_name = "asd", id_schet = 1 };

            bool actual = ConDB.Check(sp);

            Assert.AreEqual(false, actual);
        }

        [TestMethod()]
        public void CheckTest3()
        {
            spravochniki sp = new spravochniki() { aadress = "asd", full_name = null, id_schet = 1 };

            bool actual = ConDB.Check(sp);

            Assert.AreEqual(false, actual);
        }

        [TestMethod()]

        public void CheckTestUchet()
        {
            uchetnaya uch = new uchetnaya() { id_litsscheta = 1, tarif = 100, month_of_payment = "Май", quantity_of_kvatt=10, id_zapisi=1 };

            bool actual = ConDB.CheckUchet(uch);

            Assert.AreEqual(true, actual);
        }
        [TestMethod()]
        public void CheckTestUchet1()
        {
            uchetnaya uch = new uchetnaya() { id_litsscheta = 1, tarif = 0, month_of_payment = "Май", quantity_of_kvatt = 10, id_zapisi = 1 };

            bool actual = ConDB.CheckUchet(uch);

            Assert.AreEqual(false, actual);
        }
        [TestMethod()]
        public void CheckTestUchet2()
        {
            uchetnaya uch = new uchetnaya() { id_litsscheta = 0, tarif = 100, month_of_payment = "Май", quantity_of_kvatt = 10, id_zapisi = 1 };

            bool actual = ConDB.CheckUchet(uch);

            Assert.AreEqual(false, actual);
        }
        [TestMethod()]
        public void CheckTestUchet3()
        {
            uchetnaya uch = new uchetnaya() { id_litsscheta = 1, tarif = 100, month_of_payment = null, quantity_of_kvatt = 1000, id_zapisi = 1 };

            bool actual = ConDB.CheckUchet(uch);

            Assert.AreEqual(false, actual);
        }
    }
}