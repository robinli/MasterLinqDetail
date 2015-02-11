using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterLinqDetail;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasterLinqDetail.Entities;
namespace MasterLinqDetail.Tests
{
    [TestClass()]
    public class DemoDataServiceTests
    {
        [TestMethod()]
        public void GetShapesTest()
        {
            DemoDataService service = new DemoDataService();
            List<MSHAPE> result = service.GetShapesWithLazyLoading(materialId: 1);
            Assert.IsTrue(result.Count == 8);
        }

        [TestMethod()]
        public void GetShapesWithoutLazyLoadingTest()
        {
            DemoDataService service = new DemoDataService();
            List<MSHAPE> result = service.GetShapesWithoutLazyLoading(materialId: 1);
            Assert.IsTrue(result.Count == 8);
        }

        [TestMethod()]
        public void GetUnselectedShapesWithLazyLoadingTest()
        {
            DemoDataService service = new DemoDataService();
            List<MSHAPE> result = service.GetUnselectedShapesWithLazyLoading(materialId: 1);
            Assert.IsTrue(result.Count == 3);
        }

        [TestMethod()]
        public void GetUnselectedShapesWithoutLazyLoadingTest()
        {
            DemoDataService service = new DemoDataService();
            List<MSHAPE> result = service.GetUnselectedShapesWithoutLazyLoading(materialId: 1);
            Assert.IsTrue(result.Count == 3);
        }
    }
}
