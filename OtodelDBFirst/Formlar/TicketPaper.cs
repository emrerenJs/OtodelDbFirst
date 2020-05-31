using OtodelDBFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtodelDBFirst.Formlar
{
    public partial class TicketPaper : Form
    {
        private TicketModel _ticketModel;
        private TicketForm _ticketForm;
        public TicketPaper(TicketModel ticketModel,TicketForm ticketForm)
        {
            InitializeComponent();
            _ticketModel = ticketModel;
            _ticketForm = ticketForm;
        }

        private void TicketPaper_Load(object sender, EventArgs e)
        {
            NameSurnameLB.Text = _ticketModel.Customer.FirstName.ToUpperInvariant() + " " + _ticketModel.Customer.LastName.ToUpper();
            CityTakeOffLB.Text = _ticketModel.CityToTakeOff;
            ToGoCityLB.Text = _ticketModel.CityToGo;
            SeatNoLB.Text = _ticketModel.SeatNo.ToString();
            BusPlateLB.Text = _ticketModel.BusPlate;
            TakeOffTimeLB.Text = _ticketModel.Expedition.TakeOffTime.ToString();
            CameTimeLB.Text = _ticketModel.Expedition.CameTime.ToString();
            ExpeditionNoLB.Text = _ticketModel.Expedition.ExpeditionID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(OtodelContext otodelContext = new OtodelContext())
            {
                Customer customer = otodelContext.Customers.Find(_ticketModel.Customer.CustomerID);
                Expedition expedition = otodelContext.Expeditions.Find(_ticketModel.Expedition.ExpeditionID);
                otodelContext.Tickets.Add(new Ticket
                {
                    Expedition = expedition,
                    Customer = customer,
                    SeatNo = _ticketModel.SeatNo,
                    TicketDate = expedition.TakeOffTime,
                });
                otodelContext.SaveChanges();
                //Print ticket
                MessageBox.Show("Bilet kaydı başarılı!");
                _ticketForm.RowCleaner();
                _ticketForm.GetBusSeats(_ticketModel.BusPlate);
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
