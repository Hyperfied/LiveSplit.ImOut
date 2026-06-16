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
            this.gbDeltaAccuracy = new System.Windows.Forms.GroupBox();
            this.cbDropDecimal = new System.Windows.Forms.CheckBox();
            this.gbAccuracy = new System.Windows.Forms.GroupBox();
            this.tblAccuracy = new System.Windows.Forms.TableLayoutPanel();
            this.rdoSeconds = new System.Windows.Forms.RadioButton();
            this.rdoTenths = new System.Windows.Forms.RadioButton();
            this.rdoHundredths = new System.Windows.Forms.RadioButton();
            this.rdoMilliseconds = new System.Windows.Forms.RadioButton();
            this.tblComparison.SuspendLayout();
            this.gbDeltaAccuracy.SuspendLayout();
            this.gbAccuracy.SuspendLayout();
            this.tblAccuracy.SuspendLayout();
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
            this.tblComparison.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
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
            // gbDeltaAccuracy
            // 
            this.gbDeltaAccuracy.AutoSize = true;
            this.gbDeltaAccuracy.Controls.Add(this.gbAccuracy);
            this.gbDeltaAccuracy.Controls.Add(this.cbDropDecimal);
            this.gbDeltaAccuracy.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDeltaAccuracy.Location = new System.Drawing.Point(7, 34);
            this.gbDeltaAccuracy.Margin = new System.Windows.Forms.Padding(7);
            this.gbDeltaAccuracy.Name = "gbDeltaAccuracy";
            this.gbDeltaAccuracy.Padding = new System.Windows.Forms.Padding(7);
            this.gbDeltaAccuracy.Size = new System.Drawing.Size(462, 94);
            this.gbDeltaAccuracy.TabIndex = 1;
            this.gbDeltaAccuracy.TabStop = false;
            this.gbDeltaAccuracy.Text = "Delta Accuracy";
            // 
            // cbDropDecimal
            // 
            this.cbDropDecimal.AutoSize = true;
            this.cbDropDecimal.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDropDecimal.Location = new System.Drawing.Point(7, 20);
            this.cbDropDecimal.Name = "cbDropDecimal";
            this.cbDropDecimal.Size = new System.Drawing.Size(448, 17);
            this.cbDropDecimal.TabIndex = 0;
            this.cbDropDecimal.Text = "Drop Decimals When More Than 1 Minute";
            this.cbDropDecimal.UseVisualStyleBackColor = true;
            // 
            // gbAccuracy
            // 
            this.gbAccuracy.AutoSize = true;
            this.gbAccuracy.Controls.Add(this.tblAccuracy);
            this.gbAccuracy.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAccuracy.Location = new System.Drawing.Point(7, 37);
            this.gbAccuracy.Margin = new System.Windows.Forms.Padding(7);
            this.gbAccuracy.Name = "gbAccuracy";
            this.gbAccuracy.Padding = new System.Windows.Forms.Padding(7);
            this.gbAccuracy.Size = new System.Drawing.Size(448, 50);
            this.gbAccuracy.TabIndex = 1;
            this.gbAccuracy.TabStop = false;
            this.gbAccuracy.Text = "Accuracy";
            // 
            // tblAccuracy
            // 
            this.tblAccuracy.AutoSize = true;
            this.tblAccuracy.ColumnCount = 4;
            this.tblAccuracy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAccuracy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAccuracy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAccuracy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblAccuracy.Controls.Add(this.rdoSeconds, 0, 0);
            this.tblAccuracy.Controls.Add(this.rdoTenths, 1, 0);
            this.tblAccuracy.Controls.Add(this.rdoHundredths, 2, 0);
            this.tblAccuracy.Controls.Add(this.rdoMilliseconds, 3, 0);
            this.tblAccuracy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblAccuracy.Location = new System.Drawing.Point(7, 20);
            this.tblAccuracy.Name = "tblAccuracy";
            this.tblAccuracy.RowCount = 1;
            this.tblAccuracy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblAccuracy.Size = new System.Drawing.Size(434, 23);
            this.tblAccuracy.TabIndex = 0;
            // 
            // rdoSeconds
            // 
            this.rdoSeconds.AutoSize = true;
            this.rdoSeconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoSeconds.Location = new System.Drawing.Point(3, 3);
            this.rdoSeconds.Name = "rdoSeconds";
            this.rdoSeconds.Size = new System.Drawing.Size(102, 17);
            this.rdoSeconds.TabIndex = 0;
            this.rdoSeconds.TabStop = true;
            this.rdoSeconds.Text = "Seconds";
            this.rdoSeconds.UseVisualStyleBackColor = true;
            // 
            // rdoTenths
            // 
            this.rdoTenths.AutoSize = true;
            this.rdoTenths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoTenths.Location = new System.Drawing.Point(111, 3);
            this.rdoTenths.Name = "rdoTenths";
            this.rdoTenths.Size = new System.Drawing.Size(102, 17);
            this.rdoTenths.TabIndex = 1;
            this.rdoTenths.TabStop = true;
            this.rdoTenths.Text = "Tenths";
            this.rdoTenths.UseVisualStyleBackColor = true;
            // 
            // rdoHundredths
            // 
            this.rdoHundredths.AutoSize = true;
            this.rdoHundredths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoHundredths.Location = new System.Drawing.Point(219, 3);
            this.rdoHundredths.Name = "rdoHundredths";
            this.rdoHundredths.Size = new System.Drawing.Size(102, 17);
            this.rdoHundredths.TabIndex = 2;
            this.rdoHundredths.TabStop = true;
            this.rdoHundredths.Text = "Hundredths";
            this.rdoHundredths.UseVisualStyleBackColor = true;
            // 
            // rdoMilliseconds
            // 
            this.rdoMilliseconds.AutoSize = true;
            this.rdoMilliseconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdoMilliseconds.Location = new System.Drawing.Point(327, 3);
            this.rdoMilliseconds.Name = "rdoMilliseconds";
            this.rdoMilliseconds.Size = new System.Drawing.Size(104, 17);
            this.rdoMilliseconds.TabIndex = 3;
            this.rdoMilliseconds.TabStop = true;
            this.rdoMilliseconds.Text = "Milliseconds";
            this.rdoMilliseconds.UseVisualStyleBackColor = true;
            // 
            // ImOutSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.gbDeltaAccuracy);
            this.Controls.Add(this.tblComparison);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "ImOutSettings";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(476, 388);
            this.tblComparison.ResumeLayout(false);
            this.tblComparison.PerformLayout();
            this.gbDeltaAccuracy.ResumeLayout(false);
            this.gbDeltaAccuracy.PerformLayout();
            this.gbAccuracy.ResumeLayout(false);
            this.gbAccuracy.PerformLayout();
            this.tblAccuracy.ResumeLayout(false);
            this.tblAccuracy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblComparison;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbComparison;
        private System.Windows.Forms.GroupBox gbDeltaAccuracy;
        private System.Windows.Forms.GroupBox gbAccuracy;
        private System.Windows.Forms.CheckBox cbDropDecimal;
        private System.Windows.Forms.TableLayoutPanel tblAccuracy;
        private System.Windows.Forms.RadioButton rdoSeconds;
        private System.Windows.Forms.RadioButton rdoTenths;
        private System.Windows.Forms.RadioButton rdoHundredths;
        private System.Windows.Forms.RadioButton rdoMilliseconds;
    }
}
