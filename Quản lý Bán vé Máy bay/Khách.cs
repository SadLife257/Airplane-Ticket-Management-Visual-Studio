//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quản_lý_Bán_vé_Máy_bay
{
    using System;
    using System.Collections.Generic;
    
    public partial class Khách
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Khách()
        {
            this.Vé = new HashSet<Vé>();
        }
    
        public string Mã_khách { get; set; }
        public string Tên_khách { get; set; }
        public string Số_CMND { get; set; }
        public string Số_điện_thoại { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vé> Vé { get; set; }
    }
}
