namespace OtodelDBFirst.Formlar
{
    partial class ExpeditionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpeditionForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ExpeditionIDLWI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TakeOffTimeLWI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CameTimeLWI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceLWI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpeditionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BusPlateLWI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CityTakeOff = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CityToGo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TOTimeCB = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.BusPlateCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BPriceTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TOTimeHCB = new System.Windows.Forms.ComboBox();
            this.TOTimeMCB = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CTCB = new System.Windows.Forms.DateTimePicker();
            this.CTHCB = new System.Windows.Forms.ComboBox();
            this.CTMCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TOTimeCitiesCB = new System.Windows.Forms.ComboBox();
            this.CTCitiesCB = new System.Windows.Forms.ComboBox();
            this.AddExpeditionBTN = new System.Windows.Forms.Button();
            this.UpdateExpeditionBTN = new System.Windows.Forms.Button();
            this.DeleteExpeditionBTN = new System.Windows.Forms.Button();
            this.HiddenExpeditionIDLB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView1.BackgroundImage")));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ExpeditionIDLWI,
            this.TakeOffTimeLWI,
            this.CameTimeLWI,
            this.PriceLWI,
            this.ExpeditionDate,
            this.BusPlateLWI,
            this.CityTakeOff,
            this.CityToGo});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(940, 171);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ExpeditionIDLWI
            // 
            this.ExpeditionIDLWI.Text = "SeferNo";
            this.ExpeditionIDLWI.Width = 80;
            // 
            // TakeOffTimeLWI
            // 
            this.TakeOffTimeLWI.Text = "Ayrılış Zamanı";
            this.TakeOffTimeLWI.Width = 120;
            // 
            // CameTimeLWI
            // 
            this.CameTimeLWI.Text = "Varış Zamanı";
            this.CameTimeLWI.Width = 120;
            // 
            // PriceLWI
            // 
            this.PriceLWI.Text = "Fiyat";
            this.PriceLWI.Width = 35;
            // 
            // ExpeditionDate
            // 
            this.ExpeditionDate.Text = "Sefer Tarihi";
            this.ExpeditionDate.Width = 120;
            // 
            // BusPlateLWI
            // 
            this.BusPlateLWI.Text = "Otobüs Plakası";
            this.BusPlateLWI.Width = 85;
            // 
            // CityTakeOff
            // 
            this.CityTakeOff.Text = "Nereden";
            this.CityTakeOff.Width = 70;
            // 
            // CityToGo
            // 
            this.CityToGo.Text = "Nereye";
            this.CityToGo.Width = 70;
            // 
            // TOTimeCB
            // 
            this.TOTimeCB.Location = new System.Drawing.Point(6, 30);
            this.TOTimeCB.Name = "TOTimeCB";
            this.TOTimeCB.Size = new System.Drawing.Size(200, 22);
            this.TOTimeCB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Plaka:";
            // 
            // BusPlateCB
            // 
            this.BusPlateCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BusPlateCB.FormattingEnabled = true;
            this.BusPlateCB.Location = new System.Drawing.Point(71, 25);
            this.BusPlateCB.Name = "BusPlateCB";
            this.BusPlateCB.Size = new System.Drawing.Size(121, 24);
            this.BusPlateCB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fiyat:";
            // 
            // BPriceTB
            // 
            this.BPriceTB.Location = new System.Drawing.Point(250, 25);
            this.BPriceTB.Name = "BPriceTB";
            this.BPriceTB.Size = new System.Drawing.Size(53, 22);
            this.BPriceTB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "₺";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Dk:";
            // 
            // TOTimeHCB
            // 
            this.TOTimeHCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TOTimeHCB.FormattingEnabled = true;
            this.TOTimeHCB.Location = new System.Drawing.Point(257, 28);
            this.TOTimeHCB.Name = "TOTimeHCB";
            this.TOTimeHCB.Size = new System.Drawing.Size(50, 24);
            this.TOTimeHCB.TabIndex = 15;
            // 
            // TOTimeMCB
            // 
            this.TOTimeMCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TOTimeMCB.FormattingEnabled = true;
            this.TOTimeMCB.Location = new System.Drawing.Point(347, 28);
            this.TOTimeMCB.Name = "TOTimeMCB";
            this.TOTimeMCB.Size = new System.Drawing.Size(50, 24);
            this.TOTimeMCB.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TOTimeCB);
            this.groupBox1.Controls.Add(this.TOTimeHCB);
            this.groupBox1.Controls.Add(this.TOTimeMCB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Azure;
            this.groupBox1.Location = new System.Drawing.Point(12, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 76);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayrılış Zamanı:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.CTCB);
            this.groupBox2.Controls.Add(this.CTHCB);
            this.groupBox2.Controls.Add(this.CTMCB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Azure;
            this.groupBox2.Location = new System.Drawing.Point(12, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 76);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Varış Zamanı:";
            // 
            // CTCB
            // 
            this.CTCB.Location = new System.Drawing.Point(6, 30);
            this.CTCB.Name = "CTCB";
            this.CTCB.Size = new System.Drawing.Size(200, 22);
            this.CTCB.TabIndex = 3;
            // 
            // CTHCB
            // 
            this.CTHCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CTHCB.FormattingEnabled = true;
            this.CTHCB.Location = new System.Drawing.Point(257, 28);
            this.CTHCB.Name = "CTHCB";
            this.CTHCB.Size = new System.Drawing.Size(50, 24);
            this.CTHCB.TabIndex = 15;
            // 
            // CTMCB
            // 
            this.CTMCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CTMCB.FormattingEnabled = true;
            this.CTMCB.Location = new System.Drawing.Point(347, 28);
            this.CTMCB.Name = "CTMCB";
            this.CTMCB.Size = new System.Drawing.Size(50, 24);
            this.CTMCB.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Dk:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.BusPlateCB);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.BPriceTB);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.Azure;
            this.groupBox3.Location = new System.Drawing.Point(440, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 76);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Otobüs:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.TOTimeCitiesCB);
            this.groupBox4.Controls.Add(this.CTCitiesCB);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.Azure;
            this.groupBox4.Location = new System.Drawing.Point(440, 260);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(409, 76);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Şehir:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(212, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Nereye:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Nereden:";
            // 
            // TOTimeCitiesCB
            // 
            this.TOTimeCitiesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TOTimeCitiesCB.FormattingEnabled = true;
            this.TOTimeCitiesCB.Location = new System.Drawing.Point(85, 28);
            this.TOTimeCitiesCB.Name = "TOTimeCitiesCB";
            this.TOTimeCitiesCB.Size = new System.Drawing.Size(121, 24);
            this.TOTimeCitiesCB.TabIndex = 24;
            // 
            // CTCitiesCB
            // 
            this.CTCitiesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CTCitiesCB.FormattingEnabled = true;
            this.CTCitiesCB.Location = new System.Drawing.Point(282, 28);
            this.CTCitiesCB.Name = "CTCitiesCB";
            this.CTCitiesCB.Size = new System.Drawing.Size(121, 24);
            this.CTCitiesCB.TabIndex = 22;
            // 
            // AddExpeditionBTN
            // 
            this.AddExpeditionBTN.Location = new System.Drawing.Point(872, 186);
            this.AddExpeditionBTN.Name = "AddExpeditionBTN";
            this.AddExpeditionBTN.Size = new System.Drawing.Size(80, 40);
            this.AddExpeditionBTN.TabIndex = 22;
            this.AddExpeditionBTN.Text = "Ekle";
            this.AddExpeditionBTN.UseVisualStyleBackColor = true;
            this.AddExpeditionBTN.Click += new System.EventHandler(this.AddExpeditionBTN_Click);
            // 
            // UpdateExpeditionBTN
            // 
            this.UpdateExpeditionBTN.Location = new System.Drawing.Point(872, 240);
            this.UpdateExpeditionBTN.Name = "UpdateExpeditionBTN";
            this.UpdateExpeditionBTN.Size = new System.Drawing.Size(80, 40);
            this.UpdateExpeditionBTN.TabIndex = 23;
            this.UpdateExpeditionBTN.Text = "Güncelle";
            this.UpdateExpeditionBTN.UseVisualStyleBackColor = true;
            this.UpdateExpeditionBTN.Click += new System.EventHandler(this.UpdateExpeditionBTN_Click);
            // 
            // DeleteExpeditionBTN
            // 
            this.DeleteExpeditionBTN.Location = new System.Drawing.Point(872, 294);
            this.DeleteExpeditionBTN.Name = "DeleteExpeditionBTN";
            this.DeleteExpeditionBTN.Size = new System.Drawing.Size(80, 40);
            this.DeleteExpeditionBTN.TabIndex = 24;
            this.DeleteExpeditionBTN.Text = "Sil";
            this.DeleteExpeditionBTN.UseVisualStyleBackColor = true;
            this.DeleteExpeditionBTN.Click += new System.EventHandler(this.DeleteExpeditionBTN_Click);
            // 
            // HiddenExpeditionIDLB
            // 
            this.HiddenExpeditionIDLB.AutoSize = true;
            this.HiddenExpeditionIDLB.Location = new System.Drawing.Point(892, 323);
            this.HiddenExpeditionIDLB.Name = "HiddenExpeditionIDLB";
            this.HiddenExpeditionIDLB.Size = new System.Drawing.Size(0, 17);
            this.HiddenExpeditionIDLB.TabIndex = 25;
            this.HiddenExpeditionIDLB.Visible = false;
            // 
            // ExpeditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 349);
            this.Controls.Add(this.HiddenExpeditionIDLB);
            this.Controls.Add(this.DeleteExpeditionBTN);
            this.Controls.Add(this.UpdateExpeditionBTN);
            this.Controls.Add(this.AddExpeditionBTN);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExpeditionForm";
            this.Text = "Seferler";
            this.Load += new System.EventHandler(this.ExpeditionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DateTimePicker TOTimeCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BusPlateCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BPriceTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TOTimeHCB;
        private System.Windows.Forms.ComboBox TOTimeMCB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker CTCB;
        private System.Windows.Forms.ComboBox CTHCB;
        private System.Windows.Forms.ComboBox CTMCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox TOTimeCitiesCB;
        private System.Windows.Forms.ComboBox CTCitiesCB;
        private System.Windows.Forms.Button AddExpeditionBTN;
        private System.Windows.Forms.Button UpdateExpeditionBTN;
        private System.Windows.Forms.Button DeleteExpeditionBTN;
        private System.Windows.Forms.ColumnHeader ExpeditionIDLWI;
        private System.Windows.Forms.ColumnHeader TakeOffTimeLWI;
        private System.Windows.Forms.ColumnHeader CameTimeLWI;
        private System.Windows.Forms.ColumnHeader PriceLWI;
        private System.Windows.Forms.ColumnHeader ExpeditionDate;
        private System.Windows.Forms.ColumnHeader BusPlateLWI;
        private System.Windows.Forms.ColumnHeader CityTakeOff;
        private System.Windows.Forms.ColumnHeader CityToGo;
        private System.Windows.Forms.Label HiddenExpeditionIDLB;
    }
}