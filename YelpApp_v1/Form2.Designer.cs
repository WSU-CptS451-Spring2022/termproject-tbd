namespace YelpApp_v1
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
            this.addTip = new System.Windows.Forms.Button();
            this.tipTextBox = new System.Windows.Forms.TextBox();
            this.tipsGrid = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.likes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tipsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addTip
            // 
            this.addTip.Location = new System.Drawing.Point(469, 12);
            this.addTip.Name = "addTip";
            this.addTip.Size = new System.Drawing.Size(58, 23);
            this.addTip.TabIndex = 1;
            this.addTip.Text = "Add Tip";
            this.addTip.UseVisualStyleBackColor = true;
            this.addTip.Click += new System.EventHandler(this.addTip_Click);
            // 
            // tipTextBox
            // 
            this.tipTextBox.Location = new System.Drawing.Point(12, 12);
            this.tipTextBox.Multiline = true;
            this.tipTextBox.Name = "tipTextBox";
            this.tipTextBox.Size = new System.Drawing.Size(451, 62);
            this.tipTextBox.TabIndex = 2;
            // 
            // tipsGrid
            // 
            this.tipsGrid.AllowUserToAddRows = false;
            this.tipsGrid.AllowUserToDeleteRows = false;
            this.tipsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tipsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tipsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.username,
            this.likes,
            this.text});
            this.tipsGrid.Location = new System.Drawing.Point(12, 80);
            this.tipsGrid.MultiSelect = false;
            this.tipsGrid.Name = "tipsGrid";
            this.tipsGrid.ReadOnly = true;
            this.tipsGrid.RowHeadersVisible = false;
            this.tipsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tipsGrid.Size = new System.Drawing.Size(451, 289);
            this.tipsGrid.TabIndex = 7;
            // 
            // date
            // 
            this.date.FillWeight = 30F;
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 10;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // username
            // 
            this.username.FillWeight = 20F;
            this.username.HeaderText = "User Name";
            this.username.MinimumWidth = 10;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // likes
            // 
            this.likes.FillWeight = 9F;
            this.likes.HeaderText = "Likes";
            this.likes.MinimumWidth = 10;
            this.likes.Name = "likes";
            this.likes.ReadOnly = true;
            // 
            // text
            // 
            this.text.FillWeight = 50F;
            this.text.HeaderText = "Text";
            this.text.MinimumWidth = 10;
            this.text.Name = "text";
            this.text.ReadOnly = true;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(539, 381);
            this.Controls.Add(this.tipsGrid);
            this.Controls.Add(this.tipTextBox);
            this.Controls.Add(this.addTip);
            this.Name = "Form2";
            this.Text = "Tips";
            ((System.ComponentModel.ISupportInitialize)(this.tipsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button addTip;
        private System.Windows.Forms.TextBox tipTextBox;
        public System.Windows.Forms.DataGridView tipsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn likes;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
    }
}

