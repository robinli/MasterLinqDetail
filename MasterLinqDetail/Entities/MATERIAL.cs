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
    
    public partial class MATERIAL
    {
        public MATERIAL()
        {
            this.MSHAPE = new HashSet<MSHAPE>();
        }
    
        public int ID { get; set; }
        public string MATERIAL_NAME { get; set; }
    
        public virtual ICollection<MSHAPE> MSHAPE { get; set; }
    }
}
