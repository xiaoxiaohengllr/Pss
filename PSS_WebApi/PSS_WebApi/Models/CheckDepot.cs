//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSS_WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CheckDepot
    {
        public string CDID { get; set; }
        public string DepotID { get; set; }
        public Nullable<System.DateTime> CDDate { get; set; }
        public Nullable<int> UserID { get; set; }
        public string CDDesc { get; set; }
        public Nullable<int> CDState { get; set; }
    }
}
