namespace PublicNavWinForms
{
    partial class PublicNavForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.stationFrom = new System.Windows.Forms.TextBox();
            this.searchResults = new System.Windows.Forms.ListBox();
            this.stationTo = new System.Windows.Forms.TextBox();
            this.exchangeStations = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stationFrom
            // 
            this.stationFrom.Location = new System.Drawing.Point(86, 36);
            this.stationFrom.Name = "stationFrom";
            this.stationFrom.Size = new System.Drawing.Size(242, 22);
            this.stationFrom.TabIndex = 0;
            this.stationFrom.Enter += new System.EventHandler(this.stationFrom_Enter);
            this.stationFrom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stationFrom_KeyUp);
            // 
            // searchResults
            // 
            this.searchResults.FormattingEnabled = true;
            this.searchResults.ItemHeight = 16;
            this.searchResults.Location = new System.Drawing.Point(86, 64);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(242, 68);
            this.searchResults.TabIndex = 1;
            this.searchResults.SelectedIndexChanged += new System.EventHandler(this.searchResults_SelectedIndexChanged);
            // 
            // stationTo
            // 
            this.stationTo.Location = new System.Drawing.Point(86, 138);
            this.stationTo.Name = "stationTo";
            this.stationTo.Size = new System.Drawing.Size(242, 22);
            this.stationTo.TabIndex = 2;
            this.stationTo.Enter += new System.EventHandler(this.stationTo_Enter);
            this.stationTo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stationTo_KeyUp);
            // 
            // exchangeStations
            // 
            this.exchangeStations.Location = new System.Drawing.Point(359, 75);
            this.exchangeStations.Name = "exchangeStations";
            this.exchangeStations.Size = new System.Drawing.Size(47, 46);
            this.exchangeStations.TabIndex = 3;
            this.exchangeStations.UseVisualStyleBackColor = true;
            this.exchangeStations.Click += new System.EventHandler(this.exchangeStations_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Von:";
            // 
            // PublicNavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exchangeStations);
            this.Controls.Add(this.stationTo);
            this.Controls.Add(this.searchResults);
            this.Controls.Add(this.stationFrom);
            this.Name = "PublicNavForm";
            this.Text = "PublicNav";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stationFrom;
        private System.Windows.Forms.ListBox searchResults;
        private System.Windows.Forms.TextBox stationTo;
        private System.Windows.Forms.Button exchangeStations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

