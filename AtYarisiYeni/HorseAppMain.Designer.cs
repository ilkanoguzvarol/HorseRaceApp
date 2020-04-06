namespace AtYarisiYeni
{
    partial class HorseAppMain
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbBahisciler = new System.Windows.Forms.ComboBox();
            this.btnGuncelDurum = new System.Windows.Forms.Button();
            this.btnOyna = new System.Windows.Forms.Button();
            this.btnYatir = new System.Windows.Forms.Button();
            this.txtYatir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.finish = new System.Windows.Forms.PictureBox();
            this.at4 = new System.Windows.Forms.PictureBox();
            this.at3 = new System.Windows.Forms.PictureBox();
            this.at2 = new System.Windows.Forms.PictureBox();
            this.at1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.at4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.at3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.at2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.at1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "SÜRE:";
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblZaman.Location = new System.Drawing.Point(86, 9);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(26, 27);
            this.lblZaman.TabIndex = 4;
            this.lblZaman.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbBahisciler);
            this.groupBox1.Controls.Add(this.btnGuncelDurum);
            this.groupBox1.Controls.Add(this.btnOyna);
            this.groupBox1.Controls.Add(this.btnYatir);
            this.groupBox1.Controls.Add(this.txtYatir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("DS-Digital", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 545);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1209, 189);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BETTING";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(820, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 141);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 80);
            this.label2.TabIndex = 9;
            this.label2.Text = "No rights are reserved.\r\n\r\nYou can use it without permission.\r\n\r\nHopefully it ben" +
    "efits your business.\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AtYarisiYeni.Properties.Resources.ilkan;
            this.pictureBox1.Location = new System.Drawing.Point(7, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 99);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // cmbBahisciler
            // 
            this.cmbBahisciler.FormattingEnabled = true;
            this.cmbBahisciler.Location = new System.Drawing.Point(18, 33);
            this.cmbBahisciler.Name = "cmbBahisciler";
            this.cmbBahisciler.Size = new System.Drawing.Size(196, 24);
            this.cmbBahisciler.TabIndex = 12;
            this.cmbBahisciler.SelectedIndexChanged += new System.EventHandler(this.cmbBahisciler_SelectedIndexChanged);
            // 
            // btnGuncelDurum
            // 
            this.btnGuncelDurum.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGuncelDurum.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuncelDurum.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnGuncelDurum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuncelDurum.Location = new System.Drawing.Point(617, 20);
            this.btnGuncelDurum.Name = "btnGuncelDurum";
            this.btnGuncelDurum.Size = new System.Drawing.Size(197, 141);
            this.btnGuncelDurum.TabIndex = 11;
            this.btnGuncelDurum.Text = "CURRENT STATUS";
            this.btnGuncelDurum.UseVisualStyleBackColor = false;
            this.btnGuncelDurum.Click += new System.EventHandler(this.btnGuncelDurum_Click);
            // 
            // btnOyna
            // 
            this.btnOyna.BackColor = System.Drawing.Color.DarkBlue;
            this.btnOyna.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOyna.FlatAppearance.BorderSize = 0;
            this.btnOyna.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOyna.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnOyna.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOyna.Location = new System.Drawing.Point(384, 19);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(227, 142);
            this.btnOyna.TabIndex = 6;
            this.btnOyna.Text = "START RACE";
            this.btnOyna.UseVisualStyleBackColor = false;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // btnYatir
            // 
            this.btnYatir.BackColor = System.Drawing.Color.DarkBlue;
            this.btnYatir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnYatir.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnYatir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnYatir.Location = new System.Drawing.Point(18, 92);
            this.btnYatir.Name = "btnYatir";
            this.btnYatir.Size = new System.Drawing.Size(196, 70);
            this.btnYatir.TabIndex = 5;
            this.btnYatir.Text = "BETS";
            this.btnYatir.UseVisualStyleBackColor = false;
            this.btnYatir.Click += new System.EventHandler(this.btnYatir_Click);
            // 
            // txtYatir
            // 
            this.txtYatir.Location = new System.Drawing.Point(91, 63);
            this.txtYatir.Name = "txtYatir";
            this.txtYatir.Size = new System.Drawing.Size(122, 23);
            this.txtYatir.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(220, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(158, 142);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Horse";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rate";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // finish
            // 
            this.finish.Image = global::AtYarisiYeni.Properties.Resources.finish;
            this.finish.Location = new System.Drawing.Point(1171, 9);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(38, 530);
            this.finish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.finish.TabIndex = 7;
            this.finish.TabStop = false;
            // 
            // at4
            // 
            this.at4.Image = global::AtYarisiYeni.Properties.Resources.at;
            this.at4.Location = new System.Drawing.Point(12, 419);
            this.at4.Name = "at4";
            this.at4.Size = new System.Drawing.Size(123, 120);
            this.at4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.at4.TabIndex = 1;
            this.at4.TabStop = false;
            // 
            // at3
            // 
            this.at3.Image = global::AtYarisiYeni.Properties.Resources.at;
            this.at3.Location = new System.Drawing.Point(12, 293);
            this.at3.Name = "at3";
            this.at3.Size = new System.Drawing.Size(123, 120);
            this.at3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.at3.TabIndex = 1;
            this.at3.TabStop = false;
            // 
            // at2
            // 
            this.at2.Image = global::AtYarisiYeni.Properties.Resources.at;
            this.at2.Location = new System.Drawing.Point(12, 167);
            this.at2.Name = "at2";
            this.at2.Size = new System.Drawing.Size(123, 120);
            this.at2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.at2.TabIndex = 1;
            this.at2.TabStop = false;
            // 
            // at1
            // 
            this.at1.Image = global::AtYarisiYeni.Properties.Resources.at;
            this.at1.Location = new System.Drawing.Point(12, 41);
            this.at1.Name = "at1";
            this.at1.Size = new System.Drawing.Size(123, 120);
            this.at1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.at1.TabIndex = 0;
            this.at1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1212, 746);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.at4);
            this.Controls.Add(this.at3);
            this.Controls.Add(this.at2);
            this.Controls.Add(this.at1);
            this.Name = "Form1";
            this.Text = "HorseRaceApp.V1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.at4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.at3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.at2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.at1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox at1;
        private System.Windows.Forms.PictureBox at2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOyna;
        private System.Windows.Forms.Button btnYatir;
        private System.Windows.Forms.TextBox txtYatir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox finish;
        private System.Windows.Forms.PictureBox at3;
        private System.Windows.Forms.PictureBox at4;
        private System.Windows.Forms.Button btnGuncelDurum;
        private System.Windows.Forms.ComboBox cmbBahisciler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

