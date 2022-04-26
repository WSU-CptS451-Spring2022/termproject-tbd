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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Attributes");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Categories");
            this.City = new System.Windows.Forms.ComboBox();
            this.State = new System.Windows.Forms.ComboBox();
            this.Zip = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.businessGrid = new System.Windows.Forms.DataGridView();
            this.name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distance_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tips_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categories = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Filter = new System.Windows.Forms.Button();
            this.info_header = new System.Windows.Forms.Label();
            this.infoName = new System.Windows.Forms.Label();
            this.infoAddress = new System.Windows.Forms.Label();
            this.showTips = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.refreshButton = new System.Windows.Forms.Button();
            this.userinfoFans = new System.Windows.Forms.TextBox();
            this.userinfoStars = new System.Windows.Forms.TextBox();
            this.userinfoUseful = new System.Windows.Forms.TextBox();
            this.userinfoCool = new System.Windows.Forms.TextBox();
            this.userinfoFunny = new System.Windows.Forms.TextBox();
            this.userinfoDate = new System.Windows.Forms.TextBox();
            this.userinfoName = new System.Windows.Forms.TextBox();
            this.userinfoTipCount = new System.Windows.Forms.TextBox();
            this.userinfoTipLikes = new System.Windows.Forms.TextBox();
            this.userLat = new System.Windows.Forms.TextBox();
            this.userLong = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.userDataGrid = new System.Windows.Forms.DataGridView();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.userSearchBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.infoHours = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.SortBy = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.MealFilter = new System.Windows.Forms.CheckedListBox();
            this.AttributeFilter = new System.Windows.Forms.CheckedListBox();
            this.PriceFilter = new System.Windows.Forms.CheckedListBox();
            this.checkinsButton = new System.Windows.Forms.Button();
            this.AttriCatView = new System.Windows.Forms.TreeView();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.businessGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
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
            this.businessGrid.AllowUserToResizeColumns = false;
            this.businessGrid.AllowUserToResizeRows = false;
            this.businessGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.businessGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.businessGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_col,
            this.address_col,
            this.city_col,
            this.state_col,
            this.distance_col,
            this.rating_col,
            this.tips_col,
            this.check_col});
            this.businessGrid.Location = new System.Drawing.Point(294, 24);
            this.businessGrid.Margin = new System.Windows.Forms.Padding(25, 25, 25, 25);
            this.businessGrid.MultiSelect = false;
            this.businessGrid.Name = "businessGrid";
            this.businessGrid.ReadOnly = true;
            this.businessGrid.RowHeadersVisible = false;
            this.businessGrid.RowHeadersWidth = 72;
            this.businessGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.businessGrid.Size = new System.Drawing.Size(569, 432);
            this.businessGrid.TabIndex = 6;
            this.businessGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.businessGrid_CellClick);
            // 
            // name_col
            // 
            this.name_col.FillWeight = 85F;
            this.name_col.HeaderText = "Name";
            this.name_col.MinimumWidth = 85;
            this.name_col.Name = "name_col";
            this.name_col.ReadOnly = true;
            // 
            // address_col
            // 
            this.address_col.HeaderText = "Address";
            this.address_col.MinimumWidth = 105;
            this.address_col.Name = "address_col";
            this.address_col.ReadOnly = true;
            // 
            // city_col
            // 
            this.city_col.HeaderText = "City";
            this.city_col.MinimumWidth = 9;
            this.city_col.Name = "city_col";
            this.city_col.ReadOnly = true;
            // 
            // state_col
            // 
            this.state_col.HeaderText = "State";
            this.state_col.MinimumWidth = 9;
            this.state_col.Name = "state_col";
            this.state_col.ReadOnly = true;
            // 
            // distance_col
            // 
            this.distance_col.HeaderText = "Distance (miles)";
            this.distance_col.MinimumWidth = 55;
            this.distance_col.Name = "distance_col";
            this.distance_col.ReadOnly = true;
            // 
            // rating_col
            // 
            this.rating_col.FillWeight = 35F;
            this.rating_col.HeaderText = "Stars";
            this.rating_col.MinimumWidth = 55;
            this.rating_col.Name = "rating_col";
            this.rating_col.ReadOnly = true;
            // 
            // tips_col
            // 
            this.tips_col.HeaderText = "# of Tips";
            this.tips_col.MinimumWidth = 45;
            this.tips_col.Name = "tips_col";
            this.tips_col.ReadOnly = true;
            // 
            // check_col
            // 
            this.check_col.HeaderText = "Check Ins";
            this.check_col.MinimumWidth = 45;
            this.check_col.Name = "check_col";
            this.check_col.ReadOnly = true;
            // 
            // Categories
            // 
            this.Categories.FormattingEnabled = true;
            this.Categories.Location = new System.Drawing.Point(20, 102);
            this.Categories.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(246, 349);
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
            this.Filter.Location = new System.Drawing.Point(754, 467);
            this.Filter.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(109, 27);
            this.Filter.TabIndex = 9;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // info_header
            // 
            this.info_header.AutoSize = true;
            this.info_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.info_header.Location = new System.Drawing.Point(291, 477);
            this.info_header.Name = "info_header";
            this.info_header.Size = new System.Drawing.Size(106, 20);
            this.info_header.TabIndex = 10;
            this.info_header.Text = "Business Info";
            // 
            // infoName
            // 
            this.infoName.AutoSize = true;
            this.infoName.Location = new System.Drawing.Point(291, 501);
            this.infoName.Name = "infoName";
            this.infoName.Size = new System.Drawing.Size(33, 13);
            this.infoName.TabIndex = 11;
            this.infoName.Text = "name";
            this.infoName.Visible = false;
            // 
            // infoAddress
            // 
            this.infoAddress.AutoSize = true;
            this.infoAddress.Location = new System.Drawing.Point(291, 520);
            this.infoAddress.Name = "infoAddress";
            this.infoAddress.Size = new System.Drawing.Size(45, 13);
            this.infoAddress.TabIndex = 12;
            this.infoAddress.Text = "Address";
            this.infoAddress.Visible = false;
            // 
            // showTips
            // 
            this.showTips.Location = new System.Drawing.Point(770, 501);
            this.showTips.Name = "showTips";
            this.showTips.Size = new System.Drawing.Size(93, 22);
            this.showTips.TabIndex = 13;
            this.showTips.Text = "Show Tips";
            this.showTips.UseVisualStyleBackColor = true;
            this.showTips.Visible = false;
            this.showTips.Click += new System.EventHandler(this.showTips_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 501);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Click on a business to show the info!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1340, 779);
            this.tabControl1.TabIndex = 15;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.refreshButton);
            this.tabPage2.Controls.Add(this.userinfoFans);
            this.tabPage2.Controls.Add(this.userinfoStars);
            this.tabPage2.Controls.Add(this.userinfoUseful);
            this.tabPage2.Controls.Add(this.userinfoCool);
            this.tabPage2.Controls.Add(this.userinfoFunny);
            this.tabPage2.Controls.Add(this.userinfoDate);
            this.tabPage2.Controls.Add(this.userinfoName);
            this.tabPage2.Controls.Add(this.userinfoTipCount);
            this.tabPage2.Controls.Add(this.userinfoTipLikes);
            this.tabPage2.Controls.Add(this.userLat);
            this.tabPage2.Controls.Add(this.userLong);
            this.tabPage2.Controls.Add(this.updateButton);
            this.tabPage2.Controls.Add(this.editButton);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.userDataGrid);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.userSearchBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1332, 753);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Enabled = false;
            this.refreshButton.Location = new System.Drawing.Point(430, 315);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(58, 23);
            this.refreshButton.TabIndex = 37;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // userinfoFans
            // 
            this.userinfoFans.Location = new System.Drawing.Point(430, 72);
            this.userinfoFans.Name = "userinfoFans";
            this.userinfoFans.ReadOnly = true;
            this.userinfoFans.Size = new System.Drawing.Size(53, 20);
            this.userinfoFans.TabIndex = 36;
            // 
            // userinfoStars
            // 
            this.userinfoStars.Location = new System.Drawing.Point(331, 72);
            this.userinfoStars.Name = "userinfoStars";
            this.userinfoStars.ReadOnly = true;
            this.userinfoStars.Size = new System.Drawing.Size(53, 20);
            this.userinfoStars.TabIndex = 35;
            // 
            // userinfoUseful
            // 
            this.userinfoUseful.Location = new System.Drawing.Point(443, 156);
            this.userinfoUseful.Name = "userinfoUseful";
            this.userinfoUseful.ReadOnly = true;
            this.userinfoUseful.Size = new System.Drawing.Size(40, 20);
            this.userinfoUseful.TabIndex = 34;
            // 
            // userinfoCool
            // 
            this.userinfoCool.Location = new System.Drawing.Point(396, 156);
            this.userinfoCool.Name = "userinfoCool";
            this.userinfoCool.ReadOnly = true;
            this.userinfoCool.Size = new System.Drawing.Size(40, 20);
            this.userinfoCool.TabIndex = 33;
            // 
            // userinfoFunny
            // 
            this.userinfoFunny.Location = new System.Drawing.Point(351, 156);
            this.userinfoFunny.Name = "userinfoFunny";
            this.userinfoFunny.ReadOnly = true;
            this.userinfoFunny.Size = new System.Drawing.Size(40, 20);
            this.userinfoFunny.TabIndex = 32;
            // 
            // userinfoDate
            // 
            this.userinfoDate.Location = new System.Drawing.Point(378, 107);
            this.userinfoDate.Name = "userinfoDate";
            this.userinfoDate.ReadOnly = true;
            this.userinfoDate.Size = new System.Drawing.Size(105, 20);
            this.userinfoDate.TabIndex = 31;
            // 
            // userinfoName
            // 
            this.userinfoName.Location = new System.Drawing.Point(336, 32);
            this.userinfoName.Name = "userinfoName";
            this.userinfoName.ReadOnly = true;
            this.userinfoName.Size = new System.Drawing.Size(147, 20);
            this.userinfoName.TabIndex = 30;
            // 
            // userinfoTipCount
            // 
            this.userinfoTipCount.Location = new System.Drawing.Point(378, 183);
            this.userinfoTipCount.Name = "userinfoTipCount";
            this.userinfoTipCount.ReadOnly = true;
            this.userinfoTipCount.Size = new System.Drawing.Size(109, 20);
            this.userinfoTipCount.TabIndex = 29;
            // 
            // userinfoTipLikes
            // 
            this.userinfoTipLikes.Location = new System.Drawing.Point(379, 217);
            this.userinfoTipLikes.Name = "userinfoTipLikes";
            this.userinfoTipLikes.ReadOnly = true;
            this.userinfoTipLikes.Size = new System.Drawing.Size(109, 20);
            this.userinfoTipLikes.TabIndex = 28;
            // 
            // userLat
            // 
            this.userLat.Location = new System.Drawing.Point(323, 263);
            this.userLat.Name = "userLat";
            this.userLat.ReadOnly = true;
            this.userLat.Size = new System.Drawing.Size(100, 20);
            this.userLat.TabIndex = 27;
            // 
            // userLong
            // 
            this.userLong.Location = new System.Drawing.Point(323, 287);
            this.userLong.Name = "userLong";
            this.userLong.ReadOnly = true;
            this.userLong.Size = new System.Drawing.Size(100, 20);
            this.userLong.TabIndex = 26;
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Location = new System.Drawing.Point(430, 287);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(58, 23);
            this.updateButton.TabIndex = 25;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(430, 261);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(58, 23);
            this.editButton.TabIndex = 24;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.edit_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(292, 290);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(27, 13);
            this.label22.TabIndex = 23;
            this.label22.Text = "long";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(292, 266);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 13);
            this.label21.TabIndex = 22;
            this.label21.Text = "lat";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(292, 247);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Location:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(292, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "Total Tip Likes:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(292, 183);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Tip Count:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(440, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "useful:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(292, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Votes:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(348, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "funny:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(393, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "cool:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(292, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Yelping Since:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(390, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Fans:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(292, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Stars:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Name:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView2.Location = new System.Drawing.Point(24, 344);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 72;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(472, 386);
            this.dataGridView2.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 35F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 75;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 15F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Stars";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 60F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Yelping Since";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 75;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Friends";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Latest tips of my friends?";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.TipText,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(528, 28);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(576, 702);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 85F;
            this.dataGridViewTextBoxColumn1.HeaderText = "User Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Business";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 35F;
            this.dataGridViewTextBoxColumn3.HeaderText = "City";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 75;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // TipText
            // 
            this.TipText.HeaderText = "Tip Text";
            this.TipText.MinimumWidth = 9;
            this.TipText.Name = "TipText";
            this.TipText.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 9;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "User Information:";
            // 
            // userDataGrid
            // 
            this.userDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid});
            this.userDataGrid.Location = new System.Drawing.Point(24, 54);
            this.userDataGrid.MultiSelect = false;
            this.userDataGrid.Name = "userDataGrid";
            this.userDataGrid.RowHeadersVisible = false;
            this.userDataGrid.RowHeadersWidth = 72;
            this.userDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDataGrid.Size = new System.Drawing.Size(253, 249);
            this.userDataGrid.TabIndex = 3;
            this.userDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGrid_CellContentClick);
            this.userDataGrid.SelectionChanged += new System.EventHandler(this.userDataGrid_SelectionChanged);
            // 
            // userid
            // 
            this.userid.FillWeight = 85F;
            this.userid.HeaderText = "";
            this.userid.MinimumWidth = 100;
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Width = 251;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 12);
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
            this.userSearchBox.Size = new System.Drawing.Size(253, 20);
            this.userSearchBox.TabIndex = 1;
            this.userSearchBox.Text = "Enter User Name";
            this.userSearchBox.Click += new System.EventHandler(this.userSearchBox_Click);
            this.userSearchBox.TextChanged += new System.EventHandler(this.userSearchBox_TextChanged);
            this.userSearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userSearchBox_KeyPress);
            this.userSearchBox.Leave += new System.EventHandler(this.userSearchBox_Leave);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.infoHours);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.SortBy);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.MealFilter);
            this.tabPage1.Controls.Add(this.AttributeFilter);
            this.tabPage1.Controls.Add(this.PriceFilter);
            this.tabPage1.Controls.Add(this.checkinsButton);
            this.tabPage1.Controls.Add(this.AttriCatView);
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
            this.tabPage1.Enabled = false;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1332, 753);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Business Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // infoHours
            // 
            this.infoHours.AutoSize = true;
            this.infoHours.Location = new System.Drawing.Point(291, 537);
            this.infoHours.Name = "infoHours";
            this.infoHours.Size = new System.Drawing.Size(35, 13);
            this.infoHours.TabIndex = 23;
            this.infoHours.Text = "Hours";
            this.infoHours.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(889, 422);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(82, 13);
            this.label26.TabIndex = 22;
            this.label26.Text = "Sort Results By:";
            // 
            // SortBy
            // 
            this.SortBy.AccessibleName = "";
            this.SortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortBy.FormattingEnabled = true;
            this.SortBy.Location = new System.Drawing.Point(891, 439);
            this.SortBy.Name = "SortBy";
            this.SortBy.Size = new System.Drawing.Size(223, 21);
            this.SortBy.TabIndex = 21;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(888, 287);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 13);
            this.label25.TabIndex = 20;
            this.label25.Text = "Filter by Meal:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(891, 99);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 13);
            this.label24.TabIndex = 19;
            this.label24.Text = "Filter by Attribute:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(891, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 13);
            this.label23.TabIndex = 18;
            this.label23.Text = "Filter by Price:";
            // 
            // MealFilter
            // 
            this.MealFilter.FormattingEnabled = true;
            this.MealFilter.Location = new System.Drawing.Point(891, 302);
            this.MealFilter.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.MealFilter.Name = "MealFilter";
            this.MealFilter.Size = new System.Drawing.Size(223, 94);
            this.MealFilter.TabIndex = 17;
            // 
            // AttributeFilter
            // 
            this.AttributeFilter.FormattingEnabled = true;
            this.AttributeFilter.Location = new System.Drawing.Point(891, 115);
            this.AttributeFilter.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.AttributeFilter.Name = "AttributeFilter";
            this.AttributeFilter.Size = new System.Drawing.Size(223, 154);
            this.AttributeFilter.TabIndex = 16;
            // 
            // PriceFilter
            // 
            this.PriceFilter.ColumnWidth = 100;
            this.PriceFilter.FormattingEnabled = true;
            this.PriceFilter.Location = new System.Drawing.Point(891, 40);
            this.PriceFilter.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.PriceFilter.MultiColumn = true;
            this.PriceFilter.Name = "PriceFilter";
            this.PriceFilter.Size = new System.Drawing.Size(223, 34);
            this.PriceFilter.TabIndex = 15;
            // 
            // checkinsButton
            // 
            this.checkinsButton.Location = new System.Drawing.Point(770, 529);
            this.checkinsButton.Name = "checkinsButton";
            this.checkinsButton.Size = new System.Drawing.Size(93, 22);
            this.checkinsButton.TabIndex = 16;
            this.checkinsButton.Text = "Show Checkins";
            this.checkinsButton.UseVisualStyleBackColor = true;
            this.checkinsButton.Click += new System.EventHandler(this.checkinsButton_Click);
            // 
            // AttriCatView
            // 
            this.AttriCatView.Location = new System.Drawing.Point(891, 462);
            this.AttriCatView.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.AttriCatView.Name = "AttriCatView";
            treeNode5.Name = "Attributes";
            treeNode5.Text = "Attributes";
            treeNode6.Name = "Categories";
            treeNode6.Text = "Categories";
            this.AttriCatView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.AttriCatView.ShowRootLines = false;
            this.AttriCatView.Size = new System.Drawing.Size(223, 173);
            this.AttriCatView.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 786);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "YelpApp";
            ((System.ComponentModel.ISupportInitialize)(this.businessGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        public System.Windows.Forms.Label infoAddress;
        public System.Windows.Forms.Button showTips;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox userSearchBox;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView userDataGrid;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox userinfoFans;
        private System.Windows.Forms.TextBox userinfoStars;
        private System.Windows.Forms.TextBox userinfoUseful;
        private System.Windows.Forms.TextBox userinfoCool;
        private System.Windows.Forms.TextBox userinfoFunny;
        private System.Windows.Forms.TextBox userinfoDate;
        private System.Windows.Forms.TextBox userinfoName;
        private System.Windows.Forms.TextBox userinfoTipCount;
        private System.Windows.Forms.TextBox userinfoTipLikes;
        private System.Windows.Forms.TextBox userLat;
        private System.Windows.Forms.TextBox userLong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipText;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn city_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn state_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn distance_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn rating_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn tips_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn check_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        public System.Windows.Forms.CheckedListBox PriceFilter;
        public System.Windows.Forms.CheckedListBox AttributeFilter;
        public System.Windows.Forms.CheckedListBox MealFilter;
        public System.Windows.Forms.Label label24;
        public System.Windows.Forms.Label label23;
        public System.Windows.Forms.Label label25;
        private System.Windows.Forms.TreeView AttriCatView;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button checkinsButton;
        public System.Windows.Forms.ComboBox SortBy;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.Label infoHours;
    }
}

