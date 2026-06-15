namespace LiveSplit.UI.Components
{
    partial class ImOutSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblComparison = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbComparison = new System.Windows.Forms.ComboBox();
            this.gbAccuracy = new System.Windows.Forms.GroupBox();
            this.tblComparison.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblComparison
            // 
            this.tblComparison.AutoSize = true;
            this.tblComparison.ColumnCount = 2;
            this.tblComparison.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblComparison.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblComparison.Controls.Add(this.label1, 0, 0);
            this.tblComparison.Controls.Add(this.cmbComparison, 1, 0);
            this.tblComparison.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblComparison.Location = new System.Drawing.Point(7, 7);
            this.tblComparison.Name = "tblComparison";
            this.tblComparison.RowCount = 1;
            this.tblComparison.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblComparison.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblComparison.Size = new System.Drawing.Size(462, 27);
            this.tblComparison.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comparison:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbComparison
            // 
            this.cmbComparison.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbComparison.FormattingEnabled = true;
            this.cmbComparison.Location = new System.Drawing.Point(234, 3);
            this.cmbComparison.Name = "cmbComparison";
            this.cmbComparison.Size = new System.Drawing.Size(225, 21);
            this.cmbComparison.TabIndex = 1;
            // 
            // gbAccuracy
            // 
            this.gbAccuracy.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAccuracy.Location = new System.Drawing.Point(7, 34);
            this.gbAccuracy.Name = "gbAccuracy";
            this.gbAccuracy.Size = new System.Drawing.Size(462, 100);
            this.gbAccuracy.TabIndex = 1;
            this.gbAccuracy.TabStop = false;
            this.gbAccuracy.Text = "Delta Accuracy";
            // 
            // ImOutSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.gbAccuracy);
            this.Controls.Add(this.tblComparison);
            this.Name = "ImOutSettings";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(476, 388);
            this.tblComparison.ResumeLayout(false);
            this.tblComparison.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblComparison;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbComparison;
        private System.Windows.Forms.GroupBox gbAccuracy;
    }
}
