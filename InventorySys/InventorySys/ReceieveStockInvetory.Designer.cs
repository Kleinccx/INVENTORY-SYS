namespace InventorySys
{
    partial class ReceieveStockInvetory
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
            this.RecieveStocksDataGrid = new System.Windows.Forms.DataGridView();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Stocksbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RecieveStocksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RecieveStocksDataGrid
            // 
            this.RecieveStocksDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.RecieveStocksDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RecieveStocksDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecieveStocksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecieveStocksDataGrid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.RecieveStocksDataGrid.Location = new System.Drawing.Point(38, 77);
            this.RecieveStocksDataGrid.Name = "RecieveStocksDataGrid";
            this.RecieveStocksDataGrid.Size = new System.Drawing.Size(562, 323);
            this.RecieveStocksDataGrid.TabIndex = 2;
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Location = new System.Drawing.Point(444, 48);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.Refreshbtn.TabIndex = 23;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSalmon;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 31);
            this.label7.TabIndex = 22;
            this.label7.Text = "<";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 35);
            this.label1.TabIndex = 21;
            this.label1.Text = "RECEIVE STOCKS";
            // 
            // Stocksbtn
            // 
            this.Stocksbtn.Location = new System.Drawing.Point(525, 48);
            this.Stocksbtn.Name = "Stocksbtn";
            this.Stocksbtn.Size = new System.Drawing.Size(75, 23);
            this.Stocksbtn.TabIndex = 20;
            this.Stocksbtn.Text = "Add";
            this.Stocksbtn.UseVisualStyleBackColor = true;
            this.Stocksbtn.Click += new System.EventHandler(this.Stocksbtn_Click);
            // 
            // ReceieveStockInvetory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 419);
            this.Controls.Add(this.Refreshbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Stocksbtn);
            this.Controls.Add(this.RecieveStocksDataGrid);
            this.Name = "ReceieveStockInvetory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceieveStockInvetory";
            ((System.ComponentModel.ISupportInitialize)(this.RecieveStocksDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RecieveStocksDataGrid;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Stocksbtn;
    }
}