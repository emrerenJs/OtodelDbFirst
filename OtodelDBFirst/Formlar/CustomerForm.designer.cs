namespace OtodelDBFirst.Formlar
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.CIDLWI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CFirstNameLWI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLastNameLWI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPhoneLWI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CGenderLWI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CAddBT = new System.Windows.Forms.Button();
            this.CUpdateBT = new System.Windows.Forms.Button();
            this.CDeleteBT = new System.Windows.Forms.Button();
            this.CFirstNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CLastNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CPhoneTB = new System.Windows.Forms.TextBox();
            this.CGenderGB = new System.Windows.Forms.GroupBox();
            this.CGenderFRB = new System.Windows.Forms.RadioButton();
            this.CGenderMRB = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.CTCTB = new System.Windows.Forms.TextBox();
            this.CGenderGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView1.BackgroundImage")));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CIDLWI,
            this.CFirstNameLWI,
            this.CLastNameLWI,
            this.CPhoneLWI,
            this.CGenderLWI});
            this.listView1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-5, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(511, 269);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // CIDLWI
            // 
            this.CIDLWI.Text = "TC Kimlik";
            this.CIDLWI.Width = 80;
            // 
            // CFirstNameLWI
            // 
            this.CFirstNameLWI.Text = "İsim";
            this.CFirstNameLWI.Width = 80;
            // 
            // CLastNameLWI
            // 
            this.CLastNameLWI.Text = "Soyisim";
            this.CLastNameLWI.Width = 80;
            // 
            // CPhoneLWI
            // 
            this.CPhoneLWI.Text = "Telefon";
            this.CPhoneLWI.Width = 80;
            // 
            // CGenderLWI
            // 
            this.CGenderLWI.Text = "Cinsiyet";
            // 
            // CAddBT
            // 
            this.CAddBT.Location = new System.Drawing.Point(534, 183);
            this.CAddBT.Name = "CAddBT";
            this.CAddBT.Size = new System.Drawing.Size(161, 23);
            this.CAddBT.TabIndex = 1;
            this.CAddBT.Text = "Ekle";
            this.CAddBT.UseVisualStyleBackColor = true;
            this.CAddBT.Click += new System.EventHandler(this.CAddBT_Click);
            // 
            // CUpdateBT
            // 
            this.CUpdateBT.Location = new System.Drawing.Point(534, 212);
            this.CUpdateBT.Name = "CUpdateBT";
            this.CUpdateBT.Size = new System.Drawing.Size(161, 23);
            this.CUpdateBT.TabIndex = 2;
            this.CUpdateBT.Text = "Güncelle";
            this.CUpdateBT.UseVisualStyleBackColor = true;
            this.CUpdateBT.Click += new System.EventHandler(this.CUpdateBT_Click);
            // 
            // CDeleteBT
            // 
            this.CDeleteBT.Location = new System.Drawing.Point(534, 238);
            this.CDeleteBT.Name = "CDeleteBT";
            this.CDeleteBT.Size = new System.Drawing.Size(161, 23);
            this.CDeleteBT.TabIndex = 3;
            this.CDeleteBT.Text = "Sil";
            this.CDeleteBT.UseVisualStyleBackColor = true;
            this.CDeleteBT.Click += new System.EventHandler(this.CDeleteBT_Click);
            // 
            // CFirstNameTB
            // 
            this.CFirstNameTB.Location = new System.Drawing.Point(595, 43);
            this.CFirstNameTB.Name = "CFirstNameTB";
            this.CFirstNameTB.Size = new System.Drawing.Size(100, 22);
            this.CFirstNameTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(534, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "İsim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(534, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyisim:";
            // 
            // CLastNameTB
            // 
            this.CLastNameTB.Location = new System.Drawing.Point(595, 71);
            this.CLastNameTB.Name = "CLastNameTB";
            this.CLastNameTB.Size = new System.Drawing.Size(100, 22);
            this.CLastNameTB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(534, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefon:";
            // 
            // CPhoneTB
            // 
            this.CPhoneTB.Location = new System.Drawing.Point(595, 99);
            this.CPhoneTB.Name = "CPhoneTB";
            this.CPhoneTB.Size = new System.Drawing.Size(100, 22);
            this.CPhoneTB.TabIndex = 8;
            // 
            // CGenderGB
            // 
            this.CGenderGB.BackColor = System.Drawing.Color.Transparent;
            this.CGenderGB.Controls.Add(this.CGenderFRB);
            this.CGenderGB.Controls.Add(this.CGenderMRB);
            this.CGenderGB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CGenderGB.Location = new System.Drawing.Point(537, 129);
            this.CGenderGB.Name = "CGenderGB";
            this.CGenderGB.Size = new System.Drawing.Size(158, 47);
            this.CGenderGB.TabIndex = 10;
            this.CGenderGB.TabStop = false;
            this.CGenderGB.Text = "Cinsiyet:";
            // 
            // CGenderFRB
            // 
            this.CGenderFRB.AutoSize = true;
            this.CGenderFRB.Location = new System.Drawing.Point(77, 17);
            this.CGenderFRB.Name = "CGenderFRB";
            this.CGenderFRB.Size = new System.Drawing.Size(65, 21);
            this.CGenderFRB.TabIndex = 1;
            this.CGenderFRB.TabStop = true;
            this.CGenderFRB.Text = "Kadın";
            this.CGenderFRB.UseVisualStyleBackColor = true;
            // 
            // CGenderMRB
            // 
            this.CGenderMRB.AutoSize = true;
            this.CGenderMRB.Location = new System.Drawing.Point(3, 18);
            this.CGenderMRB.Name = "CGenderMRB";
            this.CGenderMRB.Size = new System.Drawing.Size(65, 21);
            this.CGenderMRB.TabIndex = 0;
            this.CGenderMRB.TabStop = true;
            this.CGenderMRB.Text = "Erkek";
            this.CGenderMRB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(534, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "TC No:";
            // 
            // CTCTB
            // 
            this.CTCTB.Location = new System.Drawing.Point(595, 15);
            this.CTCTB.Name = "CTCTB";
            this.CTCTB.Size = new System.Drawing.Size(100, 22);
            this.CTCTB.TabIndex = 13;
            this.CTCTB.Click += new System.EventHandler(this.CTCTB_Click);
            this.CTCTB.TextChanged += new System.EventHandler(this.CTCTB_TextChanged);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(718, 267);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CTCTB);
            this.Controls.Add(this.CGenderGB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CPhoneTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CLastNameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CFirstNameTB);
            this.Controls.Add(this.CDeleteBT);
            this.Controls.Add(this.CUpdateBT);
            this.Controls.Add(this.CAddBT);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomerForm";
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.CGenderGB.ResumeLayout(false);
            this.CGenderGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button CAddBT;
        private System.Windows.Forms.Button CUpdateBT;
        private System.Windows.Forms.Button CDeleteBT;
        private System.Windows.Forms.TextBox CFirstNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CLastNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CPhoneTB;
        private System.Windows.Forms.GroupBox CGenderGB;
        private System.Windows.Forms.RadioButton CGenderFRB;
        private System.Windows.Forms.RadioButton CGenderMRB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CTCTB;
        private System.Windows.Forms.ColumnHeader CIDLWI;
        private System.Windows.Forms.ColumnHeader CFirstNameLWI;
        private System.Windows.Forms.ColumnHeader CLastNameLWI;
        private System.Windows.Forms.ColumnHeader CPhoneLWI;
        private System.Windows.Forms.ColumnHeader CGenderLWI;
    }
}