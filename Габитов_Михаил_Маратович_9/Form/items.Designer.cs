namespace Габитов_Михаил_Маратович_9
{
    partial class items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(items));
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.tbNameItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSortTime = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFiter = new System.Windows.Forms.ComboBox();
            this.bFilter = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Location = new System.Drawing.Point(8, 109);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Size = new System.Drawing.Size(763, 322);
            this.dgvItem.TabIndex = 0;
            // 
            // tbNameItem
            // 
            this.tbNameItem.Location = new System.Drawing.Point(284, 21);
            this.tbNameItem.Name = "tbNameItem";
            this.tbNameItem.Size = new System.Drawing.Size(462, 20);
            this.tbNameItem.TabIndex = 1;
            this.tbNameItem.TextChanged += new System.EventHandler(this.tbNameItem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите наименование товара для поиска";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сортировка по году выпуска";
            // 
            // cbSortTime
            // 
            this.cbSortTime.FormattingEnabled = true;
            this.cbSortTime.Items.AddRange(new object[] {
            "по возрастанию",
            "по убыванию"});
            this.cbSortTime.Location = new System.Drawing.Point(284, 49);
            this.cbSortTime.Name = "cbSortTime";
            this.cbSortTime.Size = new System.Drawing.Size(121, 21);
            this.cbSortTime.TabIndex = 4;
            this.cbSortTime.SelectedIndexChanged += new System.EventHandler(this.cbSortTime_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Показать все";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выберите вид предмета продажи";
            // 
            // cbFiter
            // 
            this.cbFiter.FormattingEnabled = true;
            this.cbFiter.Items.AddRange(new object[] {
            "jewelry",
            "antiques",
            "picture",
            "clothes"});
            this.cbFiter.Location = new System.Drawing.Point(284, 80);
            this.cbFiter.Name = "cbFiter";
            this.cbFiter.Size = new System.Drawing.Size(121, 21);
            this.cbFiter.TabIndex = 7;
            this.cbFiter.SelectedIndexChanged += new System.EventHandler(this.cbFiter_SelectedIndexChanged);
            // 
            // bFilter
            // 
            this.bFilter.Location = new System.Drawing.Point(484, 77);
            this.bFilter.Name = "bFilter";
            this.bFilter.Size = new System.Drawing.Size(75, 23);
            this.bFilter.TabIndex = 8;
            this.bFilter.Text = "Фильтр";
            this.bFilter.UseVisualStyleBackColor = true;
            this.bFilter.Click += new System.EventHandler(this.bFilter_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            ">",
            "<"});
            this.cbFilter.Location = new System.Drawing.Point(565, 78);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(33, 21);
            this.cbFilter.TabIndex = 9;
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(604, 79);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(100, 20);
            this.tbFilter.TabIndex = 10;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(211, 453);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 11;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 480);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.bFilter);
            this.Controls.Add(this.cbFiter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbSortTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNameItem);
            this.Controls.Add(this.dgvItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "items";
            this.Text = "Предметы";
            this.Load += new System.EventHandler(this.item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.TextBox tbNameItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSortTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFiter;
        private System.Windows.Forms.Button bFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button bAdd;
    }
}