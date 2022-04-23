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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.businessGrid = new System.Windows.Forms.DataGridView();
            this.name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categories = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.Button();
            this.info_header = new System.Windows.Forms.Label();
            this.infoName = new System.Windows.Forms.Label();
            this.infoAddress = new System.Windows.Forms.Label();
            this.showTips = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.userDataGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.userSearchBox = new System.Windows.Forms.TextBox();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.businessGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // City
            // 
            this.City.AccessibleName = "";
            this.City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.City.FormattingEnabled = true;
            this.City.Location = new System.Drawing.Point(80, 40);
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
            this.State.Location = new System.Drawing.Point(20, 40);
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
            this.Zip.Location = new System.Drawing.Point(185, 40);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(81, 21);
            this.Zip.TabIndex = 2;
            this.Zip.SelectedIndexChanged += new System.EventHandler(this.Zip_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zip Code";
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
            this.businessGrid.Location = new System.Drawing.Point(343, 24);
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
            this.Categories.FormattingEnabled = true;
            this.Categories.Location = new System.Drawing.Point(20, 102);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(246, 319);
            this.Categories.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categories";
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(20, 427);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(104, 26);
            this.Filter.TabIndex = 9;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // info_header
            // 
            this.info_header.AutoSize = true;
            this.info_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.info_header.Location = new System.Drawing.Point(16, 525);
            this.info_header.Name = "info_header";
            this.info_header.Size = new System.Drawing.Size(106, 20);
            this.info_header.TabIndex = 10;
            this.info_header.Text = "Business Info";
            // 
            // infoName
            // 
            this.infoName.AutoSize = true;
            this.infoName.Location = new System.Drawing.Point(17, 556);
            this.infoName.Name = "infoName";
            this.infoName.Size = new System.Drawing.Size(33, 13);
            this.infoName.TabIndex = 11;
            this.infoName.Text = "name";
            this.infoName.Visible = false;
            // 
            // infoAddress
            // 
            this.infoAddress.AutoSize = true;
            this.infoAddress.Location = new System.Drawing.Point(17, 583);
            this.infoAddress.Name = "infoAddress";
            this.infoAddress.Size = new System.Drawing.Size(44, 13);
            this.infoAddress.TabIndex = 12;
            this.infoAddress.Text = "address";
            this.infoAddress.Visible = false;
            // 
            // showTips
            // 
            this.showTips.Location = new System.Drawing.Point(20, 612);
            this.showTips.Name = "showTips";
            this.showTips.Size = new System.Drawing.Size(75, 23);
            this.showTips.TabIndex = 13;
            this.showTips.Text = "Show Tips";
            this.showTips.UseVisualStyleBackColor = true;
            this.showTips.Visible = false;
            this.showTips.Click += new System.EventHandler(this.showTips_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 556);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Click on a business to show the info!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1140, 779);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Categories);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.City);
            this.tabPage1.Controls.Add(this.showTips);
            this.tabPage1.Controls.Add(this.State);
            this.tabPage1.Controls.Add(this.infoAddress);
            this.tabPage1.Controls.Add(this.Zip);
            this.tabPage1.Controls.Add(this.infoName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.info_header);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.businessGrid);
            this.tabPage1.Controls.Add(this.Filter);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1132, 753);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Business Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.userDataGrid);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.userSearchBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1132, 753);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // userDataGrid
            // 
            this.userDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid});
            this.userDataGrid.Location = new System.Drawing.Point(24, 54);
            this.userDataGrid.Name = "userDataGrid";
            this.userDataGrid.RowHeadersVisible = false;
            this.userDataGrid.Size = new System.Drawing.Size(240, 249);
            this.userDataGrid.TabIndex = 3;
            this.userDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGrid_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Set Current User:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // userSearchBox
            // 
            this.userSearchBox.Location = new System.Drawing.Point(24, 28);
            this.userSearchBox.Name = "userSearchBox";
            this.userSearchBox.Size = new System.Drawing.Size(240, 20);
            this.userSearchBox.TabIndex = 1;
            this.userSearchBox.Text = "Enter User Name";
            this.userSearchBox.TextChanged += new System.EventHandler(this.userSearchBox_TextChanged);
            // 
            // userid
            // 
            this.userid.FillWeight = 85F;
            this.userid.HeaderText = "";
            this.userid.MinimumWidth = 100;
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Width = 249;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 794);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "YelpApp";
            ((System.ComponentModel.ISupportInitialize)(this.businessGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox City;
        public System.Windows.Forms.ComboBox State;
        public System.Windows.Forms.ComboBox Zip;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView businessGrid;
        public System.Windows.Forms.CheckedListBox Categories;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button Filter;
        public System.Windows.Forms.Label info_header;
        public System.Windows.Forms.Label infoName;
        public System.Windows.Forms.DataGridViewTextBoxColumn name_col;
        public System.Windows.Forms.DataGridViewTextBoxColumn address_col;
        public System.Windows.Forms.DataGridViewTextBoxColumn rating_col;
        public System.Windows.Forms.Label infoAddress;
        public System.Windows.Forms.Button showTips;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox userSearchBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView userDataGrid;
        public System.Windows.Forms.DataGridViewTextBoxColumn userid;
    }
}

