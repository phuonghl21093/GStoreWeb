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
    
    public partial class tblTypePicture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTypePicture()
        {
            this.tblPicture = new HashSet<tblPicture>();
            this.tblTypePicture1 = new HashSet<tblTypePicture>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string NameAscii { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<int> Parent { get; set; }
        public Nullable<int> PictureID { get; set; }
        public string Detail { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string SEOTitle { get; set; }
        public string SEODescription { get; set; }
        public string SEOKeyword { get; set; }
        public Nullable<bool> IsShow { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> LanguageId { get; set; }
        public Nullable<int> RootId { get; set; }
    
        public virtual tblLanguage tblLanguage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPicture> tblPicture { get; set; }
        public virtual tblPicture tblPicture1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTypePicture> tblTypePicture1 { get; set; }
        public virtual tblTypePicture tblTypePicture2 { get; set; }
    }
}
