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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.likeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tipsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tipsGrid.Location = new System.Drawing.Point(12, 102);
            this.tipsGrid.MultiSelect = false;
            this.tipsGrid.Name = "tipsGrid";
            this.tipsGrid.ReadOnly = true;
            this.tipsGrid.RowHeadersVisible = false;
            this.tipsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tipsGrid.Size = new System.Drawing.Size(451, 289);
            this.tipsGrid.TabIndex = 7;
            this.tipsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tipsGrid_CellContentClick);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Business Tips";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Friend Tips";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 422);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(451, 121);
            this.dataGridView1.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 20F;
            this.dataGridViewTextBoxColumn2.HeaderText = "User Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 30F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 50F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Text";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // likeButton
            // 
            this.likeButton.Location = new System.Drawing.Point(469, 42);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(58, 23);
            this.likeButton.TabIndex = 11;
            this.likeButton.Text = "Like";
            this.likeButton.UseVisualStyleBackColor = true;
            this.likeButton.Visible = false;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(539, 555);
            this.Controls.Add(this.likeButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tipsGrid);
            this.Controls.Add(this.tipTextBox);
            this.Controls.Add(this.addTip);
            this.Name = "Form2";
            this.Text = "Tips";
            ((System.ComponentModel.ISupportInitialize)(this.tipsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button likeButton;
    }
}

