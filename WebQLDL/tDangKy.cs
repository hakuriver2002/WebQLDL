//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebQLDL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tDangKy
    {
        public string MaChuyen { get; set; }
        public string MaKhach { get; set; }
        public Nullable<System.DateTime> NgayDKy { get; set; }
        public Nullable<double> STDTra { get; set; }
    
        public virtual tChuyenDuLich tChuyenDuLich { get; set; }
        public virtual tKhach tKhach { get; set; }
    }
}
