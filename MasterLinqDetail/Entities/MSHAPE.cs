//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterLinqDetail.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class MSHAPE
    {
        public MSHAPE()
        {
            this.MATERIAL = new HashSet<MATERIAL>();
        }
    
        public int ID { get; set; }
        public string SHAPE_NAME { get; set; }
    
        public virtual ICollection<MATERIAL> MATERIAL { get; set; }
    }
}
