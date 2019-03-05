//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectSem3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight()
        {
            this.Booking_Ticket = new HashSet<Booking_Ticket>();
            this.Booking_Ticket1 = new HashSet<Booking_Ticket>();
            this.DiscountDetails = new HashSet<DiscountDetail>();
            this.Prices = new HashSet<Price>();
            this.SeatDetailByFlights = new HashSet<SeatDetailByFlight>();
        }
    
        public int Flightid { get; set; }
        public int RouterId { get; set; }
        public System.DateTime Dept_Time { get; set; }
        public System.DateTime Arr_Time { get; set; }
        public Nullable<int> Status { get; set; }
        public int PlaneId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking_Ticket> Booking_Ticket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking_Ticket> Booking_Ticket1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiscountDetail> DiscountDetails { get; set; }
        public virtual Plane Plane { get; set; }
        public virtual Router Router { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Price> Prices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeatDetailByFlight> SeatDetailByFlights { get; set; }
    }
}