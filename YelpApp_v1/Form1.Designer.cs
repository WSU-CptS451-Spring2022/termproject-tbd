namespace YelpApp_v1
{
    partial class Form1
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
            this.City = new System.Windows.Forms.ComboBox();
            this.State = new System.Windows.Forms.ComboBox();
            this.Zip = new System.Windows.Forms.ComboBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.businessGrid = new System.Windows.Forms.DataGridView();
            this.name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categories = new System.Windows.Forms.CheckedListBox();
            this.Filter = new System.Windows.Forms.Button();
            this.info_header = new System.Windows.Forms.Label();
            this.infoName = new System.Windows.Forms.Label();
            this.infoAddress = new System.Windows.Forms.Label();
            this.showTips = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceFilter = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AttributeFilter = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MealFilter = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.businessGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // City
            // 
            this.City.AccessibleName = "";
            this.City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.City.FormattingEnabled = true;
            this.City.Location = new System.Drawing.Point(72, 25);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(99, 21);
            this.City.TabIndex = 0;
            this.City.SelectedIndexChanged += new System.EventHandler(this.City_SelectedIndexChanged);
            // 
            // State
            // 
            this.State.AccessibleName = "";
            this.State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.State.FormattingEnabled = true;
            this.State.Location = new System.Drawing.Point(12, 25);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(54, 21);
            this.State.TabIndex = 1;
            this.State.SelectedIndexChanged += new System.EventHandler(this.State_SelectedIndexChanged);
            this.State.SelectionChangeCommitted += new System.EventHandler(this.State_SelectedIndexChanged);
            // 
            // Zip
            // 
            this.Zip.AccessibleName = "";
            this.Zip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Zip.FormattingEnabled = true;
            this.Zip.Location = new System.Drawing.Point(177, 25);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(81, 21);
            this.Zip.TabIndex = 2;
            this.Zip.SelectedIndexChanged += new System.EventHandler(this.Zip_SelectedIndexChanged);
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(21, 9);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(32, 13);
            this.StateLabel.TabIndex = 3;
            this.StateLabel.Text = "State";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(110, 9);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(24, 13);
            this.CityLabel.TabIndex = 4;
            this.CityLabel.Text = "City";
            // 
            // ZipLabel
            // 
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Location = new System.Drawing.Point(193, 9);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(50, 13);
            this.ZipLabel.TabIndex = 5;
            this.ZipLabel.Text = "Zip Code";
            // 
            // businessGrid
            // 
            this.businessGrid.AllowUserToAddRows = false;
            this.businessGrid.AllowUserToDeleteRows = false;
            this.businessGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.businessGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.businessGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_col,
            this.address_col,
            this.rating_col});
            this.businessGrid.Location = new System.Drawing.Point(308, 9);
            this.businessGrid.MultiSelect = false;
            this.businessGrid.Name = "businessGrid";
            this.businessGrid.ReadOnly = true;
            this.businessGrid.RowHeadersVisible = false;
            this.businessGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.businessGrid.Size = new System.Drawing.Size(480, 429);
            this.businessGrid.TabIndex = 6;
            this.businessGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.businessGrid_CellClick);
            // 
            // name_col
            // 
            this.name_col.FillWeight = 85F;
            this.name_col.HeaderText = "Name";
            this.name_col.MinimumWidth = 100;
            this.name_col.Name = "name_col";
            this.name_col.ReadOnly = true;
            // 
            // address_col
            // 
            this.address_col.HeaderText = "Address";
            this.address_col.MinimumWidth = 100;
            this.address_col.Name = "address_col";
            this.address_col.ReadOnly = true;
            // 
            // rating_col
            // 
            this.rating_col.FillWeight = 35F;
            this.rating_col.HeaderText = "Rating";
            this.rating_col.MinimumWidth = 75;
            this.rating_col.Name = "rating_col";
            this.rating_col.ReadOnly = true;
            // 
            // Categories
            // 
            this.Categories.BackColor = System.Drawing.SystemColors.Control;
            this.Categories.FormattingEnabled = true;
            this.Categories.Location = new System.Drawing.Point(12, 90);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(271, 349);
            this.Categories.TabIndex = 7;
            // 
            // Filter
            // 
            this.Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Filter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Filter.Location = new System.Drawing.Point(431, 635);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(245, 77);
            this.Filter.TabIndex = 9;
            this.Filter.Text = "Filter!";
            this.Filter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // info_header
            // 
            this.info_header.AutoSize = true;
            this.info_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.info_header.Location = new System.Drawing.Point(304, 464);
            this.info_header.Name = "info_header";
            this.info_header.Size = new System.Drawing.Size(106, 20);
            this.info_header.TabIndex = 10;
            this.info_header.Text = "Business Info";
            // 
            // infoName
            // 
            this.infoName.AutoSize = true;
            this.infoName.Location = new System.Drawing.Point(305, 493);
            this.infoName.Name = "infoName";
            this.infoName.Size = new System.Drawing.Size(33, 13);
            this.infoName.TabIndex = 11;
            this.infoName.Text = "name";
            this.infoName.Visible = false;
            // 
            // infoAddress
            // 
            this.infoAddress.AutoSize = true;
            this.infoAddress.Location = new System.Drawing.Point(305, 515);
            this.infoAddress.Name = "infoAddress";
            this.infoAddress.Size = new System.Drawing.Size(44, 13);
            this.infoAddress.TabIndex = 12;
            this.infoAddress.Text = "address";
            this.infoAddress.Visible = false;
            // 
            // showTips
            // 
            this.showTips.Location = new System.Drawing.Point(692, 464);
            this.showTips.Name = "showTips";
            this.showTips.Size = new System.Drawing.Size(96, 64);
            this.showTips.TabIndex = 13;
            this.showTips.Text = "Show Tips";
            this.showTips.UseVisualStyleBackColor = true;
            this.showTips.Visible = false;
            this.showTips.Click += new System.EventHandler(this.showTips_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Click on a business to show the info!";
            // 
            // PriceFilter
            // 
            this.PriceFilter.BackColor = System.Drawing.SystemColors.Control;
            this.PriceFilter.ColumnWidth = 170;
            this.PriceFilter.FormattingEnabled = true;
            this.PriceFilter.Location = new System.Drawing.Point(813, 25);
            this.PriceFilter.MultiColumn = true;
            this.PriceFilter.Name = "PriceFilter";
            this.PriceFilter.Size = new System.Drawing.Size(359, 34);
            this.PriceFilter.TabIndex = 15;
            this.PriceFilter.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PriceFilter_ItemCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categories";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(810, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Filter by Price";
            // 
            // AttributeFilter
            // 
            this.AttributeFilter.BackColor = System.Drawing.SystemColors.Control;
            this.AttributeFilter.FormattingEnabled = true;
            this.AttributeFilter.Location = new System.Drawing.Point(813, 91);
            this.AttributeFilter.Name = "AttributeFilter";
            this.AttributeFilter.Size = new System.Drawing.Size(153, 154);
            this.AttributeFilter.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(810, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Filter by Attribute";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(980, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Filter by Meal";
            // 
            // MealFilter
            // 
            this.MealFilter.BackColor = System.Drawing.SystemColors.Control;
            this.MealFilter.FormattingEnabled = true;
            this.MealFilter.Location = new System.Drawing.Point(983, 90);
            this.MealFilter.Name = "MealFilter";
            this.MealFilter.Size = new System.Drawing.Size(189, 154);
            this.MealFilter.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.MealFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AttributeFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PriceFilter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.showTips);
            this.Controls.Add(this.infoAddress);
            this.Controls.Add(this.infoName);
            this.Controls.Add(this.info_header);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.businessGrid);
            this.Controls.Add(this.ZipLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.Zip);
            this.Controls.Add(this.State);
            this.Controls.Add(this.City);
            this.Name = "Form1";
            this.Text = "YelpApp";
            ((System.ComponentModel.ISupportInitialize)(this.businessGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox City;
        public System.Windows.Forms.ComboBox State;
        public System.Windows.Forms.ComboBox Zip;
        public System.Windows.Forms.Label StateLabel;
        public System.Windows.Forms.Label CityLabel;
        public System.Windows.Forms.Label ZipLabel;
        public System.Windows.Forms.DataGridView businessGrid;
        public System.Windows.Forms.CheckedListBox Categories;
        public System.Windows.Forms.Button Filter;
        public System.Windows.Forms.Label info_header;
        public System.Windows.Forms.Label infoName;
        public System.Windows.Forms.DataGridViewTextBoxColumn name_col;
        public System.Windows.Forms.DataGridViewTextBoxColumn address_col;
        public System.Windows.Forms.DataGridViewTextBoxColumn rating_col;
        public System.Windows.Forms.Label infoAddress;
        public System.Windows.Forms.Button showTips;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox PriceFilter;
        private System.Windows.Forms.CheckedListBox AttributeFilter;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox MealFilter;
    }
}

