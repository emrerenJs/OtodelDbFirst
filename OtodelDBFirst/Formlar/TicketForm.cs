using OtodelDBFirst.Models;
using OtodelDBFirst.MyObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtodelDBFirst.Formlar
{
    public partial class TicketForm : Form
    {
        private Customer _customer;
        private OtodelContext otodelContextForSeats = new OtodelContext();
        public TicketForm(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
        }
        /*Fonksiyonlar*/
        private void GetCities()
        {
            using(OtodelContext otodelContext = new OtodelContext())
            {
                var CitiesResult = from cities in otodelContext.Cities
                                   select cities;
                foreach(City city in CitiesResult)
                {
                    ComboBoxItem comboBoxItem = new ComboBoxItem(city.CityID,city.CityName);
                    TOCitiesCB.Items.Add(comboBoxItem);
                    TGCitiesCB.Items.Add(comboBoxItem);
                    TOCitiesDCB.Items.Add(comboBoxItem);
                    TGCitiesDCB.Items.Add(comboBoxItem);
                }
                TOCitiesCB.SelectedIndex = 5;
                TGCitiesCB.SelectedIndex = 33;
                TOCitiesDCB.SelectedIndex = 5;
                TGCitiesDCB.SelectedIndex = 33;
            }
        }
        /*Fonksiyonlar*/
        /*Events*/
        private void TicketForm_Load(object sender, EventArgs e)
        {
            GetCities();
            BackGB.Visible = false;
            this.Text = _customer.FirstName + " " + _customer.LastName;
        }


        private void LineTabLayout_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LineTabLayout.SelectedTab.Text == "Tek yön")
            {
                BackGB.Visible = false;
            }
            else
                BackGB.Visible = true;
        }

        private void GetExpeditionData_Click(object sender, EventArgs e)
        {
            ToGoLW.Items.Clear();
            ToGoLW.View = View.Details;
            ToGoLW.FullRowSelect = true;
            ToGoLW.GridLines = true;
            BackLW.Items.Clear();
            BackLW.View = View.Details;
            BackLW.FullRowSelect = true;
            BackLW.GridLines = true;
            using (OtodelContext otodelContext = new OtodelContext())
            {
                ComboBoxItem comboBoxItemTakeOff = BackGB.Visible ? (ComboBoxItem)TOCitiesDCB.SelectedItem : (ComboBoxItem)TOCitiesCB.SelectedItem;
                ComboBoxItem comboBoxItemToGo = BackGB.Visible ? (ComboBoxItem)TGCitiesDCB.SelectedItem : (ComboBoxItem)TGCitiesCB.SelectedItem;
                City TakeOff = otodelContext.Cities.Find(comboBoxItemTakeOff.key);
                City ToGo = otodelContext.Cities.Find(comboBoxItemToGo.key);
                DateTime OnlyOrDoubleDate = BackGB.Visible ? TTakeOffDDTP.Value : TTakeOffODTP.Value;
                var ExpeditionsList = (from expeditions in otodelContext.Expeditions
                                       join busses in otodelContext.Buses
                                       on expeditions.Bus.BusPlate equals busses.BusPlate
                                       select new { expeditions,busses}).ToList();
                var ExpeditionsResult = ExpeditionsList.Where(expedition =>
                                                              expedition.expeditions.ExpeditionDate.ToShortDateString() == OnlyOrDoubleDate.ToShortDateString()
                                                              &&
                                                              expedition.expeditions.CityTakeOff_CityID == TakeOff.CityID
                                                              &&
                                                              expedition.expeditions.CityToGo_CityID == ToGo.CityID
                                                              ); 
                foreach(var expedition in ExpeditionsResult)
                {
                    string seatType = expedition.expeditions.Bus.SeatType ? "2+1" : "2+2";
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = expedition.expeditions.ExpeditionID;
                    listViewItem.SubItems.Add(expedition.expeditions.TakeOffTime.ToString());
                    listViewItem.SubItems.Add(expedition.expeditions.CameTime.ToString());
                    listViewItem.SubItems.Add(seatType);
                    listViewItem.SubItems.Add(expedition.busses.Wifi ? "Var" : "Yok");
                    listViewItem.SubItems.Add(expedition.busses.Power ? "Var" : "Yok");
                    listViewItem.SubItems.Add(expedition.busses.TV ? "Var" : "Yok");
                    listViewItem.SubItems.Add(expedition.busses.BusPlate.ToString());
                    listViewItem.SubItems.Add("Boş");
                    ToGoLW.Items.Add(listViewItem);
                }
                if (BackGB.Visible)
                {
                    var ExpeditionsResultBack = ExpeditionsList.Where(expedition =>
                                                                  expedition.expeditions.ExpeditionDate.ToShortDateString() == TCameDDTP.Value.ToShortDateString()
                                                                  &&
                                                                  expedition.expeditions.CityTakeOff_CityID == ToGo.CityID
                                                                  &&
                                                                  expedition.expeditions.CityToGo_CityID == TakeOff.CityID
                                                                  );
                    foreach (var expedition in ExpeditionsResultBack)
                    {
                        ListViewItem listViewItem = new ListViewItem();
                        listViewItem.Text = expedition.expeditions.ExpeditionID;
                        listViewItem.SubItems.Add(expedition.expeditions.TakeOffTime.ToString());
                        listViewItem.SubItems.Add(expedition.expeditions.CameTime.ToString());
                        listViewItem.SubItems.Add("2+1");
                        listViewItem.SubItems.Add(expedition.busses.Wifi ? "Var" : "Yok");
                        listViewItem.SubItems.Add(expedition.busses.Power ? "Var" : "Yok");
                        listViewItem.SubItems.Add(expedition.busses.TV ? "Var" : "Yok");
                        listViewItem.SubItems.Add(expedition.busses.BusPlate.ToString());
                        listViewItem.SubItems.Add("Boş");
                        BackLW.Items.Add(listViewItem);
                    }
                }
            }
        }
        public void GetBusSeats(string BusPlate)
        {
                using (OtodelContext otodelContext = new OtodelContext())
                {
                    Bus bus = otodelContext.Buses.Find(BusPlate);
                    int seatCount = bus.SeatCount;//sınır 2+1->54, 2+2->60
                    int r1 = -3;
                    int r2 = -2;
                    int r3 = -1;
                    int r4 = 0;
                    int nextValue = 4;
                    bool seatType = bus.SeatType;//2+1:true, 2+2:false
                    if (seatType)
                    {
                        r1++;
                        r2--;
                        nextValue = 3;
                    }
                    var SeatsResult = from expedition in otodelContext.Expeditions
                                      join buss in otodelContext.Buses
                                      on expedition.Bus.BusPlate equals buss.BusPlate
                                      join tickets in otodelContext.Tickets
                                      on expedition.ExpeditionID equals tickets.Expedition.ExpeditionID
                                      join customers in otodelContext.Customers
                                      on tickets.Customer.CustomerID equals customers.CustomerID
                                      where expedition.ExpeditionID == HiddenExpeditionLB.Text && bus.BusPlate == HiddenBusPlateLB.Text
                                      select new { tickets, customers};
                    for (int i = 1; i <= seatCount; i++)
                    {
                        Button button = new Button();
                        foreach(var seatResult in SeatsResult)
                        {
                            if(seatResult.tickets.SeatNo == i)
                            {
                                button.BackColor = seatResult.customers.Gender ? Color.FromArgb(120,172,250) : Color.FromArgb(250,120,120);
                                button.Enabled = false;
                                break;
                            }
                        }
                        button.Text = i.ToString();
                        button.BackgroundImage = exampleSeatBTN.BackgroundImage;
                        button.ForeColor = exampleSeatBTN.ForeColor;
                        button.BackgroundImageLayout = exampleSeatBTN.BackgroundImageLayout;
                        button.FlatStyle = exampleSeatBTN.FlatStyle;
                        button.Font = exampleSeatBTN.Font;
                        button.Size = exampleSeatBTN.Size;
                        button.Click += (sender, e) =>
                        {
                            if (HiddenExpeditionLB.Text.Trim() == "" || HiddenBusPlateLB.Text.Trim() == "")
                                MessageBox.Show("Lütfen sefer seçin!");
                            else
                            {
                                string CityToGo = BackGB.Visible ? TGCitiesDCB.Text : TGCitiesCB.Text;
                                string CityToTakeOff = BackGB.Visible ? TOCitiesDCB.Text : TOCitiesCB.Text;
                                Expedition expedition = otodelContextForSeats.Expeditions.Find(HiddenExpeditionLB.Text);
                                TicketModel ticketModel = new TicketModel
                                {
                                    CityToGo = CityToGo,
                                    CityToTakeOff = CityToTakeOff,
                                    BusPlate = HiddenBusPlateLB.Text,
                                    Customer = _customer,
                                    Expedition = expedition,
                                    SeatNo = int.Parse(button.Text)
                                };
                                TicketPaper ticketPaper = new TicketPaper(ticketModel,this);
                                ticketPaper.ShowDialog();
                            }
                        };
                        if (i == (r1 + nextValue))
                        {
                            r1 = i;
                            BLrow1.Controls.Add(button);
                        }
                        else if (i == (r2 + nextValue))
                        {
                            r2 = i;
                            BLrow2.Controls.Add(button);
                        }
                        else if (i == (r3 + nextValue))
                        {
                            r3 = i;
                            BLrow3.Controls.Add(button);
                        }
                        else if (i == (r4 + nextValue))
                        {
                            r4 = i;
                            BLrow4.Controls.Add(button);
                        }
                    }
                }
        }
        public void RowCleaner()
        {
            BLrow1.Controls.Clear();
            BLrow2.Controls.Clear();
            BLrow3.Controls.Clear();
            BLrow4.Controls.Clear();
        }
        private void ToGoLW_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RowCleaner();
                HiddenExpeditionLB.Text = ToGoLW.SelectedItems[0].SubItems[0].Text;
                HiddenBusPlateLB.Text = ToGoLW.SelectedItems[0].SubItems[7].Text;
                GetBusSeats(ToGoLW.SelectedItems[0].SubItems[7].Text);
            }
            catch 
            {
                RowCleaner();
                HiddenExpeditionLB.Text = "";
                HiddenBusPlateLB.Text = "";
            }
        }

        private void BackLW_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RowCleaner();
                HiddenExpeditionLB.Text = BackLW.SelectedItems[0].SubItems[0].Text;
                HiddenBusPlateLB.Text = BackLW.SelectedItems[0].SubItems[7].Text;
                GetBusSeats(BackLW.SelectedItems[0].SubItems[7].Text);
            }
            catch 
            {
                RowCleaner();
                HiddenExpeditionLB.Text = "";
                HiddenBusPlateLB.Text = "";
            }
        }
        private void GetMyTickets()
        {
            MyTicketsLW.Items.Clear();
            MyTicketsLW.View = View.Details;
            MyTicketsLW.FullRowSelect = true;
            MyTicketsLW.GridLines = true;
            using (OtodelContext otodelContext = new OtodelContext())
            {
                var ticketsResult = from tickets in otodelContext.Tickets
                                    join customer in otodelContext.Customers
                                    on tickets.Customer.CustomerID equals customer.CustomerID
                                    join expeditions in otodelContext.Expeditions
                                    on tickets.Expedition.ExpeditionID equals expeditions.ExpeditionID
                                    where customer.CustomerID == _customer.CustomerID && tickets.TicketDate > DateTime.Now
                                    select new { tickets, customer, expeditions };
                foreach (var ticketResult in ticketsResult)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = ticketResult.tickets.TicketID.ToString();
                    listViewItem.SubItems.Add(ticketResult.expeditions.ExpeditionID);
                    listViewItem.SubItems.Add(ticketResult.tickets.SeatNo.ToString());
                    listViewItem.SubItems.Add(ticketResult.tickets.TicketDate.ToString());
                    MyTicketsLW.Items.Add(listViewItem);
                }
            }
        }
        private void TicketsTabLayout_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TicketsTabLayout.SelectedTab.Text == "Biletlerim")
            {
                GetMyTickets();
            }
        }

        private void MyTicketsLW_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                HiddenTicketLB.Text = MyTicketsLW.SelectedItems[0].SubItems[0].Text;
            }
            catch
            {
                HiddenTicketLB.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(HiddenTicketLB.Text.Trim() == "")
            {
                MessageBox.Show("Bilet seçilmemiş!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bu bileti iptal etmek istediğinize emin misiniz?",
                                                            "Bilet iptali",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning);
                if(dialogResult == DialogResult.Yes)
                {
                    using(OtodelContext otodelContext = new OtodelContext())
                    {
                        Ticket ticket = otodelContext.Tickets.Find(int.Parse(HiddenTicketLB.Text));
                        otodelContext.Tickets.Remove(ticket);
                        otodelContext.SaveChanges();
                        MessageBox.Show("Bilet iptal işlemi başarılı!");
                        GetMyTickets();
                    }
                }
            }
        }
    }
}
