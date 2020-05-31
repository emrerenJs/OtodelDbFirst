using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtodelDBFirst.Models
{
    public class TicketModel
    {
        public Customer Customer { get; set; }
        public string CityToTakeOff { get; set; }
        public string CityToGo { get; set; }
        public int SeatNo { get; set; }
        public string BusPlate { get; set; }
        public Expedition Expedition { get; set; }
    }
}
