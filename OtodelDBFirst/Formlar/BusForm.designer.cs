namespace OtodelDBFirst.Formlar
{
    partial class BusForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusForm));
            this.BPlakaLB = new System.Windows.Forms.Label();
            this.BPlakaTB = new System.Windows.Forms.TextBox();
            this.BSeatCountTB = new System.Windows.Forms.TextBox();
            this.BSeatCountLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTvCHB = new System.Windows.Forms.CheckBox();
            this.BWifiCHB = new System.Windows.Forms.CheckBox();
            this.BPowerCHB = new System.Windows.Forms.CheckBox();
            this.BAddBT = new System.Windows.Forms.Button();
            this.BUpdateBT = new System.Windows.Forms.Button();
            this.BDeleteBT = new System.Windows.Forms.Button();
            this.BSearchTB = new System.Windows.Forms.TextBox();
            this.BSearchLB = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BusPlateLWI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SeatCountLWI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WifiLWI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TvLWI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PowerLWI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SeatTypeLWI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.busPlateHiddenLB = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TPTRB = new System.Windows.Forms.RadioButton();
            this.TPORB = new System.Windows.Forms.RadioButton();
            this.HiddenSeatCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BPlakaLB
            // 
            this.BPlakaLB.AutoSize = true;
            this.BPlakaLB.BackColor = System.Drawing.Color.Transparent;
            this.BPlakaLB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BPlakaLB.Location = new System.Drawing.Point(477, 37);
            this.BPlakaLB.Name = "BPlakaLB";
            this.BPlakaLB.Size = new System.Drawing.Size(47, 17);
            this.BPlakaLB.TabIndex = 1;
            this.BPlakaLB.Text = "Plaka:";
            // 
            // BPlakaTB
            // 
            this.BPlakaTB.Location = new System.Drawing.Point(573, 34);
            this.BPlakaTB.Name = "BPlakaTB";
            this.BPlakaTB.Size = new System.Drawing.Size(85, 22);
            this.BPlakaTB.TabIndex = 2;
            // 
            // BSeatCountTB
            // 
            this.BSeatCountTB.Location = new System.Drawing.Point(573, 62);
            this.BSeatCountTB.Name = "BSeatCountTB";
            this.BSeatCountTB.Size = new System.Drawing.Size(57, 22);
            this.BSeatCountTB.TabIndex = 4;
            // 
            // BSeatCountLB
            // 
            this.BSeatCountLB.AutoSize = true;
            this.BSeatCountLB.BackColor = System.Drawing.Color.Transparent;
            this.BSeatCountLB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BSeatCountLB.Location = new System.Drawing.Point(477, 65);
            this.BSeatCountLB.Name = "BSeatCountLB";
            this.BSeatCountLB.Size = new System.Drawing.Size(90, 17);
            this.BSeatCountLB.TabIndex = 3;
            this.BSeatCountLB.Text = "Koltuk sayısı:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BTvCHB);
            this.groupBox1.Controls.Add(this.BWifiCHB);
            this.groupBox1.Controls.Add(this.BPowerCHB);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(480, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otobüs özellikleri";
            // 
            // BTvCHB
            // 
            this.BTvCHB.AutoSize = true;
            this.BTvCHB.Location = new System.Drawing.Point(128, 29);
            this.BTvCHB.Name = "BTvCHB";
            this.BTvCHB.Size = new System.Drawing.Size(48, 21);
            this.BTvCHB.TabIndex = 7;
            this.BTvCHB.Text = "TV";
            this.BTvCHB.UseVisualStyleBackColor = true;
            // 
            // BWifiCHB
            // 
            this.BWifiCHB.AutoSize = true;
            this.BWifiCHB.Location = new System.Drawing.Point(69, 29);
            this.BWifiCHB.Name = "BWifiCHB";
            this.BWifiCHB.Size = new System.Drawing.Size(53, 21);
            this.BWifiCHB.TabIndex = 6;
            this.BWifiCHB.Text = "Wifi";
            this.BWifiCHB.UseVisualStyleBackColor = true;
            // 
            // BPowerCHB
            // 
            this.BPowerCHB.AutoSize = true;
            this.BPowerCHB.Location = new System.Drawing.Point(9, 29);
            this.BPowerCHB.Name = "BPowerCHB";
            this.BPowerCHB.Size = new System.Drawing.Size(54, 21);
            this.BPowerCHB.TabIndex = 6;
            this.BPowerCHB.Text = "Priz";
            this.BPowerCHB.UseVisualStyleBackColor = true;
            // 
            // BAddBT
            // 
            this.BAddBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BAddBT.BackgroundImage")));
            this.BAddBT.Location = new System.Drawing.Point(479, 211);
            this.BAddBT.Name = "BAddBT";
            this.BAddBT.Size = new System.Drawing.Size(178, 31);
            this.BAddBT.TabIndex = 6;
            this.BAddBT.Text = "Ekle";
            this.BAddBT.UseVisualStyleBackColor = true;
            this.BAddBT.Click += new System.EventHandler(this.BAddBT_Click);
            // 
            // BUpdateBT
            // 
            this.BUpdateBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BUpdateBT.BackgroundImage")));
            this.BUpdateBT.Location = new System.Drawing.Point(480, 246);
            this.BUpdateBT.Name = "BUpdateBT";
            this.BUpdateBT.Size = new System.Drawing.Size(177, 31);
            this.BUpdateBT.TabIndex = 7;
            this.BUpdateBT.Text = "Güncelle";
            this.BUpdateBT.UseVisualStyleBackColor = true;
            this.BUpdateBT.Click += new System.EventHandler(this.BUpdateBT_Click);
            // 
            // BDeleteBT
            // 
            this.BDeleteBT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BDeleteBT.BackgroundImage")));
            this.BDeleteBT.Location = new System.Drawing.Point(480, 281);
            this.BDeleteBT.Name = "BDeleteBT";
            this.BDeleteBT.Size = new System.Drawing.Size(178, 31);
            this.BDeleteBT.TabIndex = 8;
            this.BDeleteBT.Text = "Sil";
            this.BDeleteBT.UseVisualStyleBackColor = true;
            this.BDeleteBT.Click += new System.EventHandler(this.BDeleteBT_Click);
            // 
            // BSearchTB
            // 
            this.BSearchTB.Location = new System.Drawing.Point(103, 9);
            this.BSearchTB.Name = "BSearchTB";
            this.BSearchTB.Size = new System.Drawing.Size(100, 22);
            this.BSearchTB.TabIndex = 9;
            this.BSearchTB.TextChanged += new System.EventHandler(this.BSearchTB_TextChanged);
            // 
            // BSearchLB
            // 
            this.BSearchLB.AutoSize = true;
            this.BSearchLB.BackColor = System.Drawing.Color.Transparent;
            this.BSearchLB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BSearchLB.Location = new System.Drawing.Point(18, 10);
            this.BSearchLB.Name = "BSearchLB";
            this.BSearchLB.Size = new System.Drawing.Size(79, 17);
            this.BSearchLB.TabIndex = 10;
            this.BSearchLB.Text = "Ara(Plaka):";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView1.BackgroundImage")));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BusPlateLWI,
            this.SeatCountLWI,
            this.WifiLWI,
            this.TvLWI,
            this.PowerLWI,
            this.SeatTypeLWI});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(466, 270);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // BusPlateLWI
            // 
            this.BusPlateLWI.Text = "Otobüs Plaka";
            this.BusPlateLWI.Width = 80;
            // 
            // SeatCountLWI
            // 
            this.SeatCountLWI.Text = "Koltuk Sayısı";
            this.SeatCountLWI.Width = 80;
            // 
            // WifiLWI
            // 
            this.WifiLWI.Text = "Wifi";
            this.WifiLWI.Width = 40;
            // 
            // TvLWI
            // 
            this.TvLWI.Text = "TV";
            this.TvLWI.Width = 40;
            // 
            // PowerLWI
            // 
            this.PowerLWI.Text = "Priz";
            this.PowerLWI.Width = 40;
            // 
            // SeatTypeLWI
            // 
            this.SeatTypeLWI.Text = "Koltuk Tipi";
            this.SeatTypeLWI.Width = 65;
            // 
            // busPlateHiddenLB
            // 
            this.busPlateHiddenLB.AutoSize = true;
            this.busPlateHiddenLB.Location = new System.Drawing.Point(477, 9);
            this.busPlateHiddenLB.Name = "busPlateHiddenLB";
            this.busPlateHiddenLB.Size = new System.Drawing.Size(0, 17);
            this.busPlateHiddenLB.TabIndex = 12;
            this.busPlateHiddenLB.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.TPTRB);
            this.groupBox2.Controls.Add(this.TPORB);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(502, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 42);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Koltuk Tipi";
            // 
            // TPTRB
            // 
            this.TPTRB.AutoSize = true;
            this.TPTRB.Location = new System.Drawing.Point(72, 16);
            this.TPTRB.Name = "TPTRB";
            this.TPTRB.Size = new System.Drawing.Size(53, 21);
            this.TPTRB.TabIndex = 1;
            this.TPTRB.TabStop = true;
            this.TPTRB.Text = "2+2";
            this.TPTRB.UseVisualStyleBackColor = true;
            // 
            // TPORB
            // 
            this.TPORB.AutoSize = true;
            this.TPORB.Location = new System.Drawing.Point(13, 17);
            this.TPORB.Name = "TPORB";
            this.TPORB.Size = new System.Drawing.Size(53, 21);
            this.TPORB.TabIndex = 0;
            this.TPORB.TabStop = true;
            this.TPORB.Text = "2+1";
            this.TPORB.UseVisualStyleBackColor = true;
            // 
            // HiddenSeatCount
            // 
            this.HiddenSeatCount.AutoSize = true;
            this.HiddenSeatCount.Location = new System.Drawing.Point(277, 9);
            this.HiddenSeatCount.Name = "HiddenSeatCount";
            this.HiddenSeatCount.Size = new System.Drawing.Size(0, 17);
            this.HiddenSeatCount.TabIndex = 14;
            this.HiddenSeatCount.Visible = false;
            // 
            // BusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 322);
            this.Controls.Add(this.HiddenSeatCount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.busPlateHiddenLB);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BSearchLB);
            this.Controls.Add(this.BSearchTB);
            this.Controls.Add(this.BDeleteBT);
            this.Controls.Add(this.BUpdateBT);
            this.Controls.Add(this.BAddBT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BSeatCountTB);
            this.Controls.Add(this.BSeatCountLB);
            this.Controls.Add(this.BPlakaTB);
            this.Controls.Add(this.BPlakaLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BusForm";
            this.Text = "Otobüsler";
            this.Load += new System.EventHandler(this.BusForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BPlakaLB;
        private System.Windows.Forms.TextBox BPlakaTB;
        private System.Windows.Forms.TextBox BSeatCountTB;
        private System.Windows.Forms.Label BSeatCountLB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox BTvCHB;
        private System.Windows.Forms.CheckBox BWifiCHB;
        private System.Windows.Forms.CheckBox BPowerCHB;
        private System.Windows.Forms.Button BAddBT;
        private System.Windows.Forms.Button BUpdateBT;
        private System.Windows.Forms.Button BDeleteBT;
        private System.Windows.Forms.TextBox BSearchTB;
        private System.Windows.Forms.Label BSearchLB;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader BusPlateLWI;
        private System.Windows.Forms.ColumnHeader SeatCountLWI;
        private System.Windows.Forms.ColumnHeader WifiLWI;
        private System.Windows.Forms.ColumnHeader TvLWI;
        private System.Windows.Forms.ColumnHeader PowerLWI;
        private System.Windows.Forms.Label busPlateHiddenLB;
        private System.Windows.Forms.ColumnHeader SeatTypeLWI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton TPTRB;
        private System.Windows.Forms.RadioButton TPORB;
        private System.Windows.Forms.Label HiddenSeatCount;
    }
}