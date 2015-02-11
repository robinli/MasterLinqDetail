using MasterLinqDetail.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLinqDetail
{
    public class DemoDataService
    {
        #region Fields
        private DemoDBEntities db = new DemoDBEntities();
        #endregion

        #region 針對單一個 Material，找出已選取的 MSHAPE
        public List<MSHAPE> GetShapesWithLazyLoading(int materialId)
        {
            db.Configuration.ProxyCreationEnabled = true;

            var collection = db.MATERIAL.Find(materialId).MSHAPE;
            return new List<MSHAPE>(collection);
        }

        public List<MSHAPE> GetShapesWithoutLazyLoading(int materialId)
        {
            db.Configuration.ProxyCreationEnabled = false;

            var collection = db.MATERIAL.Include("MSHAPE")
                .FirstOrDefault(r=>r.ID==materialId).MSHAPE;

            return new List<MSHAPE>(collection);
        }
        #endregion

        #region 針對單一個 Material，找出尚未選取的 MSHAPE
        public List<MSHAPE> GetUnselectedShapesWithLazyLoading(int materialId)
        {
            db.Configuration.ProxyCreationEnabled = true;

            var result = (from q in db.MSHAPE
                          where !(
                          db.MATERIAL.Where(m => m.ID.Equals(materialId)).FirstOrDefault()
                          .MSHAPE.Any(s => s.ID == q.ID)
                          )
                          select q
                  );
            return new List<MSHAPE>(result);
        }

        public List<MSHAPE> GetUnselectedShapesWithoutLazyLoading(int materialId)
        {
            db.Configuration.ProxyCreationEnabled = false;

            var result = (from q in db.MSHAPE
                          where !(
                          db.MATERIAL.Where(m => m.ID.Equals(materialId)).FirstOrDefault()
                          .MSHAPE.Any(s => s.ID == q.ID)
                          )
                          select q
                  );
            return new List<MSHAPE>(result);
        }
        #endregion
    }
}
