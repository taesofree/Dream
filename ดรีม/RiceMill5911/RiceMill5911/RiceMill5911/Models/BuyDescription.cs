//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RiceMill5911.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BuyDescription
    {
        public int DesBuyID { get; set; }
        public int BuyID { get; set; }
        public Nullable<int> BuyRice { get; set; }
        public Nullable<double> BuyAmount { get; set; }
        public Nullable<double> BuyPrice { get; set; }
        public Nullable<double> BuyTotal { get; set; }
        public Nullable<int> ConditionID { get; set; }
        public Nullable<int> StatusRiceID { get; set; }
    
        public virtual BuyForm BuyForm { get; set; }
        public virtual Condition Condition { get; set; }
        public virtual Rice Rice { get; set; }
        public virtual StatusRice StatusRice { get; set; }
    }
}
