//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoAdminPPP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Image
    {
        public string image_id { get; set; }
        public string image_name { get; set; }
        public string product_id { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
