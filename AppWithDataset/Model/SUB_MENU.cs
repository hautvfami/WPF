//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppWithDataset.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SUB_MENU
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string LINK { get; set; }
        public Nullable<int> IDMAIN { get; set; }
    
        public virtual MENU MENU { get; set; }
    }
}
