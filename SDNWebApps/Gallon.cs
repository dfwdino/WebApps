//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDNWebApps
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gallon
    {
        public int ID { get; set; }
        public int AutoID { get; set; }
        public int TotalMiles { get; set; }
        public int DrivenMiles { get; set; }
        public double TotalGallons { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<System.DateTime> GasDate { get; set; }
        public bool TankFilled { get; set; }
    
        public virtual Auto Auto { get; set; }
    }
}
