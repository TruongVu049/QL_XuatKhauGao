//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QL_XuatKhauGao.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DangNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DangNhap()
        {
            this.KhachHangs = new HashSet<KhachHang>();
        }
    
        public int id { get; set; }
        public string matkhau { get; set; }
        public Nullable<int> isAdmin { get; set; }
        public string email { get; set; }
    
        public virtual PhanQuyen PhanQuyen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
}
