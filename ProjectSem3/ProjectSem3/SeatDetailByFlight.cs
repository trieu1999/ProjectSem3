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
    
    public partial class SeatDetailByFlight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SeatDetailByFlight()
        {
            this.Booking_Ticket = new HashSet<Booking_Ticket>();
        }
    
        public int SeatDetailByFlightId { get; set; }
        public int FlightId { get; set; }
        public int SeatNumberId { get; set; }
        public bool SeatStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking_Ticket> Booking_Ticket { get; set; }
        public virtual Flight Flight { get; set; }
        public virtual SeatNumber SeatNumber { get; set; }
    }
}