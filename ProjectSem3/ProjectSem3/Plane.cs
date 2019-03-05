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
    
    public partial class Plane
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plane()
        {
            this.Flights = new HashSet<Flight>();
            this.QuantitySeatClasses = new HashSet<QuantitySeatClass>();
            this.SeatNumbers = new HashSet<SeatNumber>();
        }
    
        public int PlaneId { get; set; }
        public string PlaneName { get; set; }
        public int AirlineId { get; set; }
        public int Capacity { get; set; }
        public string CodeIATAPlane { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual Airline Airline { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flight> Flights { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuantitySeatClass> QuantitySeatClasses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeatNumber> SeatNumbers { get; set; }
    }
}