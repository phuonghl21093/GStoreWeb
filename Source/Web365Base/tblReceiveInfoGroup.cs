//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web365Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblReceiveInfoGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblReceiveInfoGroup()
        {
            this.tblReceiveInfo = new HashSet<tblReceiveInfo>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<bool> IsShow { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblReceiveInfo> tblReceiveInfo { get; set; }
    }
}
