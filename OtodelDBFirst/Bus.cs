//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtodelDBFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bus()
        {
            this.Expeditions = new HashSet<Expedition>();
        }
    
        public string BusPlate { get; set; }
        public int SeatCount { get; set; }
        public bool Wifi { get; set; }
        public bool TV { get; set; }
        public bool Power { get; set; }
        public bool SeatType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expedition> Expeditions { get; set; }
    }
}
