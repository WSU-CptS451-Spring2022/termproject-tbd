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
            this.Categories = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.businessGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // City
            // 
            this.City.AccessibleName = "";
            this.City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.City.FormattingEnabled = true;
            this.City.Location = new System.Drawing.Point(345, 38);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(147, 21);
            this.City.TabIndex = 0;
            this.City.SelectedIndexChanged += new System.EventHandler(this.City_SelectedIndexChanged);
            // 
            // State
            // 
            this.State.AccessibleName = "";
            this.State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.State.FormattingEnabled = true;
            this.State.Location = new System.Drawing.Point(100, 38);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(147, 21);
            this.State.TabIndex = 1;
            this.State.SelectedIndexChanged += new System.EventHandler(this.State_SelectedIndexChanged);
            this.State.SelectionChangeCommitted += new System.EventHandler(this.State_SelectedIndexChanged);
            // 
            // Zip
            // 
            this.Zip.AccessibleName = "";
            this.Zip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Zip.FormattingEnabled = true;
            this.Zip.Location = new System.Drawing.Point(620, 38);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(147, 21);
            this.Zip.TabIndex = 2;
            this.Zip.SelectedIndexChanged += new System.EventHandler(this.Zip_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zip Code";
            // 
            // businessGrid
            // 
            this.businessGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.businessGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.businessGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.state_col,
            this.city_col});
            this.businessGrid.Location = new System.Drawing.Point(12, 89);
            this.businessGrid.Name = "businessGrid";
            this.businessGrid.RowHeadersVisible = false;
            this.businessGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.businessGrid.Size = new System.Drawing.Size(480, 353);
            this.businessGrid.TabIndex = 6;
            // 
            // Categories
            // 
            this.Categories.FormattingEnabled = true;
            this.Categories.Location = new System.Drawing.Point(544, 90);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(246, 319);
            this.Categories.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categories";
            // 
            // name
            // 
            this.name.FillWeight = 85F;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 100;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // state_col
            // 
            this.state_col.HeaderText = "Address";
            this.state_col.MinimumWidth = 100;
            this.state_col.Name = "state_col";
            this.state_col.ReadOnly = true;
            // 
            // city_col
            // 
            this.city_col.FillWeight = 35F;
            this.city_col.HeaderText = "Rating";
            this.city_col.MinimumWidth = 75;
            this.city_col.Name = "city_col";
            this.city_col.ReadOnly = true;
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(686, 416);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(104, 26);
            this.Filter.TabIndex = 9;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.businessGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zip);
            this.Controls.Add(this.State);
            this.Controls.Add(this.City);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.businessGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox City;
        private System.Windows.Forms.ComboBox State;
        private System.Windows.Forms.ComboBox Zip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView businessGrid;
        private System.Windows.Forms.CheckedListBox Categories;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn state_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn city_col;
        private System.Windows.Forms.Button Filter;
    }
}

