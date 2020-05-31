using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtodelDBFirst.Formlar
{
    public partial class BusForm : Form
    {
        //Constructor
        public BusForm()
        {
            InitializeComponent();
        }
        /*Functions*/
        private void GetBusData(string busPlate = "")
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            using (OtodelContext otodelContext = new OtodelContext())
            {
                var BusesResult = from buses in otodelContext.Buses
                                  where buses.BusPlate.Contains(busPlate)
                                  select buses;
                foreach (var Bus in BusesResult)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = Bus.BusPlate;
                    listViewItem.SubItems.Add(Bus.SeatCount.ToString());
                    listViewItem.SubItems.Add(Bus.Wifi ? "Var" : "Yok");
                    listViewItem.SubItems.Add(Bus.TV ? "Var" : "Yok");
                    listViewItem.SubItems.Add(Bus.Power ? "Var" : "Yok");
                    listViewItem.SubItems.Add(Bus.SeatType ? "2+1" : "2+2");
                    listView1.Items.Add(listViewItem);
                }
            }
        }
        /*Functions*/
        /*Events*/
        private void BAddBT_Click(object sender, EventArgs e)
        {
            if (BPlakaTB.Text.Trim() != "" || BSeatCountTB.Text != "")
            {
                using (OtodelContext otodelContext = new OtodelContext())
                {
                    try
                    {
                        int test = int.Parse(BSeatCountTB.Text);
                        otodelContext.Buses.Add(new Bus
                        {
                            BusPlate = BPlakaTB.Text,
                            Power = BPowerCHB.Checked,
                            TV = BTvCHB.Checked,
                            SeatCount = int.Parse(BSeatCountTB.Text),
                            Wifi = BWifiCHB.Checked,
                            SeatType = TPTRB.Checked ? false : true
                        });
                        otodelContext.SaveChanges();
                        GetBusData();
                    }
                    catch (FormatException formatException)
                    {
                        MessageBox.Show("Koltuk sayısı sayısal veri almak zorundadır!");
                    }
                    catch(DbUpdateException error)
                    {
                        MessageBox.Show("Bu plakada bir araç zaten mevcut!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Koltuk sayısı ve Plaka boş kalamaz!");
            }
        }

        private void BUpdateBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (BPlakaTB.Text.Trim() != "")
                    using (var otodelContext = new OtodelContext())
                    {
                        var ticketResult = from tickets in otodelContext.Tickets
                                           join expedition in otodelContext.Expeditions
                                           on tickets.Expedition.ExpeditionID equals expedition.ExpeditionID
                                           join busses in otodelContext.Buses
                                           on expedition.Bus.BusPlate equals busses.BusPlate
                                           select tickets;
                        if(ticketResult.Count() > 0 && int.Parse(BSeatCountTB.Text) < int.Parse(HiddenSeatCount.Text))
                        {
                            MessageBox.Show("Bu otobüslerin çıkacağı seferler için bilet kesilmiş. Koltuk sayısı olduğu sayıdan daha küçük bir adete dönüştürülemez! Önce seferi iptal edin!");
                        }
                        else
                        {
                            Bus bus = otodelContext.Buses.Find(BPlakaTB.Text);
                            if (bus == null)
                            {
                                MessageBox.Show("Bu araç bulunamadı!");
                            }
                            else
                            {
                                if (BSeatCountLB.Text.Trim() != "")
                                {
                                    bus.SeatCount = int.Parse(BSeatCountTB.Text);
                                    bus.Power = BPowerCHB.Checked;
                                    bus.TV = BTvCHB.Checked;
                                    bus.Wifi = BWifiCHB.Checked;
                                    bus.SeatType = TPTRB.Checked ? false : true;
                                    otodelContext.SaveChanges();
                                    MessageBox.Show("Günceleme başarılı!");
                                    GetBusData();
                                }
                                else
                                    MessageBox.Show("Koltuk adedi boş kalamaz!");
                            }
                        }
                    }
                else
                    MessageBox.Show("Seçim işlemi yapmadınız!!");
            }
            catch (InvalidOperationException InOpException)
            {
                MessageBox.Show("Araç plakaları değiştirilemez!");
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Araç koltukları, sayısal değer almak zorundadır!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void BDeleteBT_Click(object sender, EventArgs e)
        {
                try
            {
                if (BPlakaTB.Text.Trim() != "")
                    using (var otodelContext = new OtodelContext())
                    {
                        Bus bus = otodelContext.Buses.Find(BPlakaTB.Text);
                        if (bus == null)
                            MessageBox.Show("Bu plakada araç bulunamadı!");
                        else
                        {
                            var ExpeditionsResult = from expeditions in otodelContext.Expeditions
                                                    join buses in otodelContext.Buses
                                                    on expeditions.Bus.BusPlate equals buses.BusPlate
                                                    where buses.BusPlate == BPlakaTB.Text && expeditions.CameTime > DateTime.Now
                                                    select new { expeditions, buses };
                            DialogResult dialogResult;
                            if(ExpeditionsResult.Count() > 0)
                            {
                                MessageBox.Show("Bu aracın mensubu olduğu seferler mevcut. Önce bu seferleri silmelisiniz!");
                            }
                            else
                            {
                                dialogResult = MessageBox.Show(String.Format("{0} plakalı aracı silmek istediğinize emin misiniz?",
                                                                        BPlakaTB.Text), "Otobüs siliniyor!",
                                                                        MessageBoxButtons.YesNo,
                                                                        MessageBoxIcon.Warning);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    otodelContext.Buses.Remove(bus);
                                    otodelContext.SaveChanges();
                                    MessageBox.Show("Silme işlemi başarılı!");
                                }
                            }
                            GetBusData();
                        }
                    }
                else
                    MessageBox.Show("Seçim işlemi yapmadınız!!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void BusForm_Load(object sender, EventArgs e)
        {
            GetBusData();
            TPORB.Checked = true;
        }

        private void BSearchTB_TextChanged(object sender, EventArgs e)
        {
            GetBusData(BSearchTB.Text);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BPlakaTB.Text = listView1.SelectedItems[0].SubItems[0].Text;
                HiddenSeatCount.Text = listView1.SelectedItems[0].SubItems[1].Text;
                BSeatCountTB.Text = listView1.SelectedItems[0].SubItems[1].Text;
                BWifiCHB.Checked = listView1.SelectedItems[0].SubItems[2].Text == "Var" ? true : false;
                BTvCHB.Checked = listView1.SelectedItems[0].SubItems[3].Text == "Var" ? true : false;
                BPowerCHB.Checked = listView1.SelectedItems[0].SubItems[4].Text == "Var" ? true : false;
                if (listView1.SelectedItems[0].SubItems[5].Text == "2+1")
                    TPORB.Checked = true;
                else
                    TPTRB.Checked = true;
            }
            catch
            {
                BPlakaTB.Text = "";
                BSeatCountTB.Text = "";
                HiddenSeatCount.Text = "";
                BWifiCHB.Checked = false;
                BTvCHB.Checked = false;
                BPowerCHB.Checked = false;
                TPORB.Checked = true;
            }
        }
        /*Events*/
    }
}
