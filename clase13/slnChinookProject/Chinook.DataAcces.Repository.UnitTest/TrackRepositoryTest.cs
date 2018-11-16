using Chinook.DataAccess.Interfaces;
using Chinook.DataAccess.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAcces.Repository.UnitTest
{
    [TestClass]
    public class TrackRepositoryTest
    {
        private readonly DbContext dbcontext;
        private readonly ITrackRepository trackRepository;
        private readonly IUnitOfWork unitOfWork;

        public TrackRepositoryTest()
        {
            this.dbcontext = new ChinookDBModel();
            trackRepository = new TrackRepository(dbcontext);
            unitOfWork = new UnitOfWork(dbcontext);
        }
        [TestMethod]
        public void GetTrackVendidos()
        {
            var cantidad = trackRepository.GetTracksVendidos("bal%").Count();

            Assert.IsTrue(cantidad > 0, "Ok");
        }
    }
}
