using System;
using System.Data.Entity;
using System.Linq;
using Chinook.DataAcces.Interface;
using Chinook.Entities.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chinook.DataAcces.Repository.UnitTest
{
    [TestClass]
    public class InvoiceRespositoryTest
    {
        private readonly DbContext dbcontext;
        private readonly IInvoiceRepository invoiceRepository;
        private readonly IUnitOfWork unitOfWork;

        public InvoiceRespositoryTest()
        {
            this.dbcontext = new Model1();
            invoiceRepository = new InvoiceRepository(dbcontext);
            unitOfWork = new UnitOfWork(dbcontext);
        }
        [TestMethod]
        public void BuscarCustomerAddres()
        {
            var listado = unitOfWork.InvoiceRepository.GetCustosmerId_Invoice(1);
            Assert.IsTrue(listado.Count() > 0, "Ok");
        }
        [TestMethod]
        public void Add()
        {
            var invoice = new Invoice();
            invoice.CustomerId = 1;
            invoice.InvoiceDate = DateTime.Now;
            invoice.BillingAddress = "Remigio Silva 510";
            invoice.BillingCity = "Jesus Maria";
            invoice.BillingState = "Lima";
            invoice.BillingCountry = "Peru";
            invoice.BillingPostalCode = "Lima 12";
            //Agregando Items 
            invoice.InvoiceLine.Add(
                new InvoiceLine()
                {
                    TrackId = 1,
                    Quantity = 2,
                    UnitPrice = 10
                }
            );
            invoice.InvoiceLine.Add(
                new InvoiceLine()
                {
                    TrackId = 1,
                    Quantity = 2,
                    UnitPrice = 10
                }
            );
            //Sumando Totales 
            invoice.Total = invoice.InvoiceLine.Sum(item => item.UnitPrice * item.Quantity);

            unitOfWork.InvoiceRepository.Add(invoice);
            unitOfWork.Complete();
            unitOfWork.Dispose();
            Assert.IsTrue(invoice.InvoiceId > 0, "ok");
        }
    }
}
