//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaoMatCSDL
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHANVIEN
    {
        public NHANVIEN()
        {
            this.LOPs = new HashSet<LOP>();
        }
    
        public string MANV { get; set; }
        public string HOTEN { get; set; }
        public string EMAIL { get; set; }
        public byte[] LUONG { get; set; }
        public string TENDN { get; set; }
        public byte[] MATKHAU { get; set; }
    
        public virtual ICollection<LOP> LOPs { get; set; }
    }
}
