namespace AtYarisiYeni
{
    partial class Form2
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
            this.dtDurum = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            this.dtBahisciler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtDurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBahisciler)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDurum
            // 
            this.dtDurum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDurum.Location = new System.Drawing.Point(13, 47);
            this.dtDurum.Name = "dtDurum";
            this.dtDurum.Size = new System.Drawing.Size(542, 192);
            this.dtDurum.TabIndex = 0;
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnKapat.Location = new System.Drawing.Point(13, 490);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(542, 31);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtBahisciler
            // 
            this.dtBahisciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBahisciler.Location = new System.Drawing.Point(12, 282);
            this.dtBahisciler.Name = "dtBahisciler";
            this.dtBahisciler.Size = new System.Drawing.Size(542, 202);
            this.dtBahisciler.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "BETTOR LIST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "CURRENT STATUS LIST";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtBahisciler);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.dtDurum);
            this.Name = "Form2";
            this.Text = "HorseRaceApp.V1";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBahisciler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtDurum;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridView dtBahisciler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}