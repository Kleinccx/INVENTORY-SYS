namespace InventorySys
{
    partial class StocksInventory
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
            this.StocksDataGrid = new System.Windows.Forms.DataGridView();
            this.Stocksbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Refreshbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StocksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StocksDataGrid
            // 
            this.StocksDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.StocksDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StocksDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StocksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StocksDataGrid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.StocksDataGrid.Location = new System.Drawing.Point(18, 83);
            this.StocksDataGrid.Name = "StocksDataGrid";
            this.StocksDataGrid.Size = new System.Drawing.Size(635, 323);
            this.StocksDataGrid.TabIndex = 0;
            this.StocksDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StocksDataGrid_CellContentClick);
            // 
            // Stocksbtn
            // 
            this.Stocksbtn.Location = new System.Drawing.Point(578, 54);
            this.Stocksbtn.Name = "Stocksbtn";
            this.Stocksbtn.Size = new System.Drawing.Size(75, 23);
            this.Stocksbtn.TabIndex = 1;
            this.Stocksbtn.Text = "Add";
            this.Stocksbtn.UseVisualStyleBackColor = true;
            this.Stocksbtn.Click += new System.EventHandler(this.Stocksbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "STOCKS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSalmon;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 31);
            this.label7.TabIndex = 18;
            this.label7.Text = "<";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Location = new System.Drawing.Point(483, 54);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.Refreshbtn.TabIndex = 19;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // StocksInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 411);
            this.Controls.Add(this.Refreshbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stocksbtn);
            this.Controls.Add(this.StocksDataGrid);
            this.Name = "StocksInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StocksInventory";
            ((System.ComponentModel.ISupportInitialize)(this.StocksDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StocksDataGrid;
        private System.Windows.Forms.Button Stocksbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Refreshbtn;
    }
}