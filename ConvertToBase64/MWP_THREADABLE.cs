//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConvertToBase64
{
    using System;
    using System.Collections.Generic;
    
    public partial class MWP_THREADABLE
    {
        public decimal THREADID { get; set; }
        public decimal THREADCATEGORYID { get; set; }
        public string THREADTITLE { get; set; }
        public System.DateTime THREADTIMESTAMP { get; set; }
        public string THREADABLEAUTHOR { get; set; }
        public string THREADCONTENT { get; set; }
        public short THREADISPUBLISHED { get; set; }
    
        public virtual MWP_THREADCATEGORY MWP_THREADCATEGORY { get; set; }
    }
}
