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
    
    public partial class BookingDescription
    {
        public int DesBookingID { get; set; }
        public int BookingID { get; set; }
        public Nullable<int> BookRice { get; set; }
        public string Description { get; set; }
        public Nullable<double> RiceQuantity { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<double> TotalPrice { get; set; }
        public string PaymentStatus { get; set; }
        public Nullable<double> DesPrice { get; set; }
    
        public virtual BookingForm BookingForm { get; set; }
        public virtual Rice Rice { get; set; }
    }
}
