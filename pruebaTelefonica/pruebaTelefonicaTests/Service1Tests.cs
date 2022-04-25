using Microsoft.VisualStudio.TestTools.UnitTesting;
using pruebaTelefonica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaTelefonica.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void getCalcularFormulaCuadraticaTest()
        {
            Service1 service1 = new Service1();
            try
            {
                service1.getCalcularFormulaCuadratica();
            }
            catch (ArgumentOutOfRangeException e)
            {

                StringAssert.Contains(e.Message, "Prueba Fallida");
                return;
            }
        }

        [TestMethod()]
        public void getListaFibonacci()
        {
            Service1 service1 = new Service1();
            try
            {
                service1.getListaFibonacci(10);
            }
            catch (ArgumentOutOfRangeException e)
            {

                StringAssert.Contains(e.Message, "Prueba Fallida");
                return;
            }
        }
    }
}