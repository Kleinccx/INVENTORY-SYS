﻿namespace InventorySys
{
    partial class ReleaseStockInventory
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
            this.ReleaseStocksDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ReleaseStckbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Refreshbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseStocksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ReleaseStocksDataGrid
            // 
            this.ReleaseStocksDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ReleaseStocksDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ReleaseStocksDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReleaseStocksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReleaseStocksDataGrid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.ReleaseStocksDataGrid.Location = new System.Drawing.Point(45, 64);
            this.ReleaseStocksDataGrid.Name = "ReleaseStocksDataGrid";
            this.ReleaseStocksDataGrid.Size = new System.Drawing.Size(658, 323);
            this.ReleaseStocksDataGrid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "RELEASE STOCKS";
            // 
            // ReleaseStckbtn
            // 
            this.ReleaseStckbtn.Location = new System.Drawing.Point(628, 35);
            this.ReleaseStckbtn.Name = "ReleaseStckbtn";
            this.ReleaseStckbtn.Size = new System.Drawing.Size(75, 23);
            this.ReleaseStckbtn.TabIndex = 4;
            this.ReleaseStckbtn.Text = "Add";
            this.ReleaseStckbtn.UseVisualStyleBackColor = true;
            this.ReleaseStckbtn.Click += new System.EventHandler(this.ReleaseStckbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSalmon;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "<";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Location = new System.Drawing.Point(543, 35);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.Refreshbtn.TabIndex = 20;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click_1);
            // 
            // ReleaseStockInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 407);
            this.Controls.Add(this.Refreshbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ReleaseStckbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReleaseStocksDataGrid);
            this.Name = "ReleaseStockInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReleaseStockInventory";
            ((System.ComponentModel.ISupportInitialize)(this.ReleaseStocksDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReleaseStocksDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReleaseStckbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Refreshbtn;
    }
}