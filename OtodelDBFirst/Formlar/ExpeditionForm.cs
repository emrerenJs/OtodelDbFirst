using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtodelDBFirst.MyObjects;
namespace OtodelDBFirst.Formlar
{
    public partial class ExpeditionForm : Form
    {
        public ExpeditionForm()
        {
            InitializeComponent();
        }
        /*Functions*/
        private bool DateDiffControl(DateTime TakeOff, DateTime CameTime)
        {
            if(TakeOff > CameTime)
            {
                return false;
            }
            return true;
        }
        public void GetComboBoxValues()
        {
            /*Zamanlar*/
            for (int hours = 0; hours < 24; hours++)
            {
                TOTimeHCB.Items.Add(hours.ToString().Length == 1 ? "0" + hours.ToString() : hours.ToString());
                CTHCB.Items.Add(hours.ToString().Length == 1 ? "0" + hours.ToString() : hours.ToString());
            }

            for (int minute = 0; minute < 60; minute++)
            {
                TOTimeMCB.Items.Add(minute.ToString().Length == 1 ? "0" + minute.ToString() : minute.ToString());
                CTMCB.Items.Add(minute.ToString().Length == 1 ? "0" + minute.ToString() : minute.ToString());
            }

            /*Zamanlar*/
            /*other combos*/
            using (var otodelContext = new OtodelContext())
            {
                /*Şehirleri çekiyor*/
                var CityResult = from cities in otodelContext.Cities
                                 select cities;
                foreach (var city in CityResult)
                {
                    TOTimeCitiesCB.Items.Add(new ComboBoxItem(city.CityID,city.CityName));
                    CTCitiesCB.Items.Add(new ComboBoxItem(city.CityID,city.CityName));
                }
                /*Şehirler çekildi*/
                /*Otobüsler çekiliyor*/
                var BusPlateResult = from plates in otodelContext.Buses
                                     select plates.BusPlate;
                foreach (var busPlate in BusPlateResult)
                {
                    BusPlateCB.Items.Add(busPlate);
                }              
                /*Otobüsler çekiliyor*/
            }
            /*other combos*/
        }



        public void GetExpeditions(string expeditionSearch = "")
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            using (var otodelContext = new OtodelContext())
            {
                var ExpeditionResult = from expeditions in otodelContext.Expeditions
                                       join citiesTO in otodelContext.Cities
                                       on expeditions.CityTakeOff_CityID equals citiesTO.CityID
                                       join citiesCT in otodelContext.Cities
                                       on expeditions.CityToGo_CityID equals citiesCT.CityID 
                                       join buses in otodelContext.Buses
                                       on expeditions.Bus.BusPlate equals buses.BusPlate
                                       select new { expeditions,citiesTO,citiesCT,buses};
                foreach (var expedition in ExpeditionResult)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = expedition.expeditions.ExpeditionID;
                    listViewItem.SubItems.Add(expedition.expeditions.TakeOffTime.ToString());
                    listViewItem.SubItems.Add(expedition.expeditions.CameTime.ToString());
                    listViewItem.SubItems.Add(expedition.expeditions.Price.ToString());
                    listViewItem.SubItems.Add(expedition.expeditions.ExpeditionDate.ToString());
                    listViewItem.SubItems.Add(expedition.expeditions.Bus.BusPlate.ToString());
                    listViewItem.SubItems.Add(expedition.citiesTO.CityName.ToString());
                    listViewItem.SubItems.Add(expedition.citiesCT.CityName.ToString());
                    listView1.Items.Add(listViewItem);
                }
            }
        }
        public void ClearAllObjects(){
            BusPlateCB.SelectedIndex = -1;
            TOTimeCB.Text = "";
            TOTimeHCB.SelectedIndex = 0;
            TOTimeMCB.SelectedIndex = 0;
            TOTimeCitiesCB.SelectedIndex = 5;
            CTCB.Text = "";
            CTHCB.SelectedIndex = 0;
            CTMCB.SelectedIndex = 0;
            CTCitiesCB.SelectedIndex = 33;
            BPriceTB.Text = "";
        }
        /*Functions*/
        /*Events*/
        private void ExpeditionForm_Load(object sender, EventArgs e)
        {
            GetComboBoxValues();
            GetExpeditions();
            ClearAllObjects();
        }

        private void AddExpeditionBTN_Click(object sender, EventArgs e)
        {
            if (BusPlateCB.SelectedIndex != -1 || BPriceTB.Text.Trim() != "")
            {
                string TakeOffTimeStr = TOTimeCB.Value.Day + "/" + TOTimeCB.Value.Month + "/" + TOTimeCB.Value.Year + " " + TOTimeHCB.Text + ":" + TOTimeMCB.Text + ":00";
                string CameTimeStr = CTCB.Value.Day + "/" + CTCB.Value.Month + "/" + CTCB.Value.Year + " " + CTHCB.Text + ":" + CTMCB.Text + ":00";
                DateTime TakeOffTime = DateTime.Parse(TakeOffTimeStr);
                DateTime CameTime = DateTime.Parse(CameTimeStr);
                if (DateDiffControl(TakeOffTime, CameTime))
                {
                    Random rand = new Random();
                    using (var otodelContext = new OtodelContext())
                    {
                        otodelContext.Expeditions.Add(new Expedition
                        {
                            ExpeditionID = ((ComboBoxItem)TOTimeCitiesCB.SelectedItem).key + ((ComboBoxItem)CTCitiesCB.SelectedItem).key + BusPlateCB.Text.Substring(0, 2) + rand.Next(10000, 99999),
                            Bus = otodelContext.Buses.Find(BusPlateCB.Text),
                            CameTime = CameTime,
                            CityToGo_CityID = otodelContext.Cities.Find(((ComboBoxItem)CTCitiesCB.SelectedItem).key).CityID,
                            TakeOffTime = TakeOffTime,
                            Price = float.Parse(BPriceTB.Text),
                            ExpeditionDate = TakeOffTime,
                            CityTakeOff_CityID = otodelContext.Cities.Find(((ComboBoxItem)TOTimeCitiesCB.SelectedItem).key).CityID
                        });
                        otodelContext.SaveChanges();
                        GetExpeditions();
                        MessageBox.Show("Kayıt başarılı!");
                    }
                }
                else
                    MessageBox.Show("Varış zamanı, Kalkış zamanından önce olamaz!");
            }
            else
                MessageBox.Show("Boş alan bırakmayınız!");
        }

        private void DeleteExpeditionBTN_Click(object sender, EventArgs e)
        {
            using (var otodelContext = new OtodelContext())
            {
                if(HiddenExpeditionIDLB.Text.Trim() == "")
                    MessageBox.Show("Sefer seçilmemiş!");
                else
                {
                    var TicketsResult = from tickets in otodelContext.Tickets
                                        join expedition in otodelContext.Expeditions
                                        on tickets.Expedition.ExpeditionID equals expedition.ExpeditionID
                                        where expedition.ExpeditionID == HiddenExpeditionIDLB.Text
                                        select tickets;
                    if(TicketsResult.Count() > 0)
                    {
                        DialogResult dialogResult = MessageBox.Show(
                            String.Format("{0} numaralı {1} - {2} sefere ait biletler bulunmakta!!! Eğer bu seferi silerseniz, biletler de silinecek. Hala devam etmek istiyor musunuz?", HiddenExpeditionIDLB.Text, TOTimeCitiesCB.SelectedItem, CTCitiesCB.SelectedItem),
                            "Sefere ait bilet var!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );
                        if (dialogResult == DialogResult.Yes)
                        {
                            Expedition expedition = otodelContext.Expeditions.Find(HiddenExpeditionIDLB.Text);
                            foreach(var ticketResult in TicketsResult)
                            {
                                otodelContext.Tickets.Remove(ticketResult);
                            }
                            otodelContext.Expeditions.Remove(expedition);
                            otodelContext.SaveChanges();
                            HiddenExpeditionIDLB.Text = "";
                            GetExpeditions();
                            MessageBox.Show("Silme işlemi başarılı!");
                        }
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show(
                                                    String.Format("{0} numaralı {1} - {2} seferi silmek istediğinize emin misiniz?", HiddenExpeditionIDLB.Text, TOTimeCitiesCB.SelectedItem, CTCitiesCB.SelectedItem),
                                                    "Dikkat!",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning
                                                );
                        if (dialogResult == DialogResult.Yes)
                        {
                            Expedition expedition = otodelContext.Expeditions.Find(HiddenExpeditionIDLB.Text);
                            otodelContext.Expeditions.Remove(expedition);
                            otodelContext.SaveChanges();
                            HiddenExpeditionIDLB.Text = "";
                            GetExpeditions();
                            MessageBox.Show("Silme işlemi başarılı!");
                        }
                    }
                }
            }
        }
        private void UpdateExpeditionBTN_Click(object sender, EventArgs e)
        {
            if (HiddenExpeditionIDLB.Text.Trim() != "")
            {
                if(BusPlateCB.SelectedIndex == -1 || BPriceTB.Text.Trim() == "")
                {
                    MessageBox.Show("Boş alan bırakmayınız!");
                }
                else
                {
                    string TakeOffTimeStr = TOTimeCB.Value.Day + "/" + TOTimeCB.Value.Month + "/" + TOTimeCB.Value.Year + " " + TOTimeHCB.Text + ":" + TOTimeMCB.Text + ":00";
                    string CameTimeStr = CTCB.Value.Day + "/" + CTCB.Value.Month + "/" + CTCB.Value.Year + " " + CTHCB.Text + ":" + CTMCB.Text + ":00";
                    DateTime TakeOffTime = DateTime.Parse(TakeOffTimeStr);
                    DateTime CameTime = DateTime.Parse(CameTimeStr);
                    if (DateDiffControl(TakeOffTime,CameTime))
                    {
                        using (var otodelContext = new OtodelContext())
                        {
                            Expedition expedition = otodelContext.Expeditions.Find(HiddenExpeditionIDLB.Text);
                            expedition.Bus = otodelContext.Buses.Find(BusPlateCB.Text);
                            expedition.CameTime = CameTime;
                            expedition.CityToGo_CityID = otodelContext.Cities.Find(((ComboBoxItem)CTCitiesCB.SelectedItem).key).CityID;
                            expedition.TakeOffTime = TakeOffTime;
                            expedition.Price = float.Parse(BPriceTB.Text);
                            expedition.ExpeditionDate = TakeOffTime;
                            expedition.CityTakeOff_CityID = otodelContext.Cities.Find(((ComboBoxItem)TOTimeCitiesCB.SelectedItem).key).CityID;
                            otodelContext.SaveChanges();
                            MessageBox.Show("Günceleme başarılı!");
                            GetExpeditions();
                        }
                    } 
                    else
                        MessageBox.Show("Varış zamanı, kalkış zamanından önce olamaz!");
                }
            }else
                MessageBox.Show("Seçim yapmadınız!");
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                HiddenExpeditionIDLB.Text = listView1.SelectedItems[0].SubItems[0].Text;
                TOTimeCB.Value = DateTime.Parse(listView1.SelectedItems[0].SubItems[1].Text);
                TOTimeHCB.Text = DateTime.Parse(listView1.SelectedItems[0].SubItems[1].Text).Hour.ToString().Length == 1 ? "0" + DateTime.Parse(listView1.SelectedItems[0].SubItems[1].Text).Hour.ToString() : DateTime.Parse(listView1.SelectedItems[0].SubItems[1].Text).Hour.ToString();
                TOTimeMCB.Text = DateTime.Parse(listView1.SelectedItems[0].SubItems[1].Text).Minute.ToString().Length == 1 ? "0" + DateTime.Parse(listView1.SelectedItems[0].SubItems[1].Text).Minute.ToString() : DateTime.Parse(listView1.SelectedItems[0].SubItems[1].Text).Minute.ToString();
                CTCB.Value = DateTime.Parse(listView1.SelectedItems[0].SubItems[2].Text);
                CTHCB.Text = DateTime.Parse(listView1.SelectedItems[0].SubItems[2].Text).Hour.ToString().Length == 1 ? "0" + DateTime.Parse(listView1.SelectedItems[0].SubItems[2].Text).Hour.ToString() : DateTime.Parse(listView1.SelectedItems[0].SubItems[2].Text).Hour.ToString();
                CTMCB.Text = DateTime.Parse(listView1.SelectedItems[0].SubItems[2].Text).Minute.ToString().Length == 1 ? "0" + DateTime.Parse(listView1.SelectedItems[0].SubItems[2].Text).Minute.ToString() : DateTime.Parse(listView1.SelectedItems[0].SubItems[2].Text).Minute.ToString();
                BPriceTB.Text = listView1.SelectedItems[0].SubItems[3].Text;
                BusPlateCB.Text = listView1.SelectedItems[0].SubItems[5].Text;
                TOTimeCitiesCB.SelectedIndex = (TOTimeCitiesCB.FindStringExact(listView1.SelectedItems[0].SubItems[6].Text));
                CTCitiesCB.SelectedIndex = CTCitiesCB.FindStringExact(listView1.SelectedItems[0].SubItems[7].Text);
            }
            catch(Exception error)
            {
                HiddenExpeditionIDLB.Text = "";
                ClearAllObjects();
            }
        }

    }
}
