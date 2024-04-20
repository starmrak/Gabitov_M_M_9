
namespace Габитов_Михаил_Маратович_9
{
    partial class add
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lDate = new System.Windows.Forms.Label();
            this.lPrice = new System.Windows.Forms.Label();
            this.lYN = new System.Windows.Forms.Label();
            this.bADD = new System.Windows.Forms.Button();
            this.cbYN = new System.Windows.Forms.ComboBox();
            this.lPriceS = new System.Windows.Forms.Label();
            this.lPred = new System.Windows.Forms.Label();
            this.cbPerd = new System.Windows.Forms.ComboBox();
            this.tbPS = new System.Windows.Forms.MaskedTextBox();
            this.tbPL = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(235, 218);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 6;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(165, 218);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(64, 13);
            this.lDate.TabIndex = 14;
            this.lDate.Text = "Дата торга";
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(139, 270);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(90, 13);
            this.lPrice.TabIndex = 15;
            this.lPrice.Text = "Последняя цена";
            // 
            // lYN
            // 
            this.lYN.AutoSize = true;
            this.lYN.Location = new System.Drawing.Point(131, 296);
            this.lYN.Name = "lYN";
            this.lYN.Size = new System.Drawing.Size(98, 13);
            this.lYN.TabIndex = 16;
            this.lYN.Text = "Признак продажи";
            // 
            // bADD
            // 
            this.bADD.Location = new System.Drawing.Point(307, 323);
            this.bADD.Name = "bADD";
            this.bADD.Size = new System.Drawing.Size(75, 23);
            this.bADD.TabIndex = 17;
            this.bADD.Text = "Добавить";
            this.bADD.UseVisualStyleBackColor = true;
            this.bADD.Click += new System.EventHandler(this.bADD_Click);
            // 
            // cbYN
            // 
            this.cbYN.FormattingEnabled = true;
            this.cbYN.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.cbYN.Location = new System.Drawing.Point(235, 296);
            this.cbYN.Name = "cbYN";
            this.cbYN.Size = new System.Drawing.Size(200, 21);
            this.cbYN.TabIndex = 21;
            // 
            // lPriceS
            // 
            this.lPriceS.AutoSize = true;
            this.lPriceS.Location = new System.Drawing.Point(140, 244);
            this.lPriceS.Name = "lPriceS";
            this.lPriceS.Size = new System.Drawing.Size(89, 13);
            this.lPriceS.TabIndex = 22;
            this.lPriceS.Text = "Начальная цена";
            // 
            // lPred
            // 
            this.lPred.AutoSize = true;
            this.lPred.Location = new System.Drawing.Point(151, 192);
            this.lPred.Name = "lPred";
            this.lPred.Size = new System.Drawing.Size(78, 13);
            this.lPred.TabIndex = 26;
            this.lPred.Text = "Код предмета";
            // 
            // cbPerd
            // 
            this.cbPerd.FormattingEnabled = true;
            this.cbPerd.Items.AddRange(new object[] {
            "jacket",
            "necklace",
            "watch",
            "ballerina_painting",
            "oil_painting",
            "big_watch",
            "ring",
            "pants"});
            this.cbPerd.Location = new System.Drawing.Point(236, 192);
            this.cbPerd.Name = "cbPerd";
            this.cbPerd.Size = new System.Drawing.Size(199, 21);
            this.cbPerd.TabIndex = 28;
            this.cbPerd.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbPS
            // 
            this.tbPS.Location = new System.Drawing.Point(235, 244);
            this.tbPS.Mask = "9999999999";
            this.tbPS.Name = "tbPS";
            this.tbPS.Size = new System.Drawing.Size(200, 20);
            this.tbPS.TabIndex = 29;
            this.tbPS.ValidatingType = typeof(int);
            // 
            // tbPL
            // 
            this.tbPL.Location = new System.Drawing.Point(236, 270);
            this.tbPL.Mask = "9999999999";
            this.tbPL.Name = "tbPL";
            this.tbPL.Size = new System.Drawing.Size(200, 20);
            this.tbPL.TabIndex = 30;
            this.tbPL.ValidatingType = typeof(int);
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPL);
            this.Controls.Add(this.tbPS);
            this.Controls.Add(this.cbPerd);
            this.Controls.Add(this.lPred);
            this.Controls.Add(this.lPriceS);
            this.Controls.Add(this.cbYN);
            this.Controls.Add(this.bADD);
            this.Controls.Add(this.lYN);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.dtpDate);
            this.Name = "add";
            this.Text = "add";
            this.Load += new System.EventHandler(this.add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Label lYN;
        private System.Windows.Forms.Button bADD;
        private System.Windows.Forms.ComboBox cbYN;
        private System.Windows.Forms.Label lPriceS;
        private System.Windows.Forms.Label lPred;
        private System.Windows.Forms.ComboBox cbPerd;
        private System.Windows.Forms.MaskedTextBox tbPS;
        private System.Windows.Forms.MaskedTextBox tbPL;
    }
}