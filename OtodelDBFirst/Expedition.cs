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
    
    public partial class Expedition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Expedition()
        {
            this.Tickets = new HashSet<Ticket>();
        }
    
        public string ExpeditionID { get; set; }
        public System.DateTime TakeOffTime { get; set; }
        public System.DateTime CameTime { get; set; }
        public float Price { get; set; }
        public System.DateTime ExpeditionDate { get; set; }
        public string Bus_BusPlate { get; set; }
        public string CityTakeOff_CityID { get; set; }
        public string CityToGo_CityID { get; set; }
    
        public virtual Bus Bus { get; set; }
        public virtual City City { get; set; }
        public virtual City City1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
