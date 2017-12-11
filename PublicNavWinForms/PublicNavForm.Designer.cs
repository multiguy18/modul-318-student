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
            this.components = new System.ComponentModel.Container();
            this.stationFrom = new System.Windows.Forms.TextBox();
            this.searchResults = new System.Windows.Forms.ListBox();
            this.stationTo = new System.Windows.Forms.TextBox();
            this.exchangeStations = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.queryConnections = new System.Windows.Forms.Button();
            this.connectionsGrid = new System.Windows.Forms.DataGridView();
            this.stationBoardsGrid = new System.Windows.Forms.DataGridView();
            this.connectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBoardsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).BeginInit();
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
            // queryConnections
            // 
            this.queryConnections.Location = new System.Drawing.Point(35, 188);
            this.queryConnections.Name = "queryConnections";
            this.queryConnections.Size = new System.Drawing.Size(371, 46);
            this.queryConnections.TabIndex = 6;
            this.queryConnections.Text = "Suchen";
            this.queryConnections.UseVisualStyleBackColor = true;
            this.queryConnections.Click += new System.EventHandler(this.queryConnections_Click);
            // 
            // connectionsGrid
            // 
            this.connectionsGrid.AllowUserToAddRows = false;
            this.connectionsGrid.AllowUserToDeleteRows = false;
            this.connectionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.connectionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.From,
            this.To,
            this.Duration,
            this.Station});
            this.connectionsGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.connectionsGrid.Location = new System.Drawing.Point(35, 259);
            this.connectionsGrid.MultiSelect = false;
            this.connectionsGrid.Name = "connectionsGrid";
            this.connectionsGrid.ReadOnly = true;
            this.connectionsGrid.RowHeadersVisible = false;
            this.connectionsGrid.RowTemplate.Height = 24;
            this.connectionsGrid.Size = new System.Drawing.Size(687, 297);
            this.connectionsGrid.TabIndex = 7;
            this.connectionsGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.connectionsGrid_RowEnter);
            // 
            // stationBoardsGrid
            // 
            this.stationBoardsGrid.AllowUserToAddRows = false;
            this.stationBoardsGrid.AllowUserToDeleteRows = false;
            this.stationBoardsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationBoardsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureTime,
            this.ToStation,
            this.Number,
            this.ConnectionName});
            this.stationBoardsGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.stationBoardsGrid.Location = new System.Drawing.Point(759, 259);
            this.stationBoardsGrid.MultiSelect = false;
            this.stationBoardsGrid.Name = "stationBoardsGrid";
            this.stationBoardsGrid.ReadOnly = true;
            this.stationBoardsGrid.RowHeadersVisible = false;
            this.stationBoardsGrid.RowTemplate.Height = 24;
            this.stationBoardsGrid.Size = new System.Drawing.Size(648, 297);
            this.stationBoardsGrid.TabIndex = 8;
            // 
            // connectionBindingSource
            // 
            this.connectionBindingSource.DataSource = typeof(SwissTransport.Connection);
            // 
            // DepartureTime
            // 
            this.DepartureTime.HeaderText = "Abfahrtszeit";
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.ReadOnly = true;
            this.DepartureTime.Width = 80;
            // 
            // ToStation
            // 
            this.ToStation.HeaderText = "Nach";
            this.ToStation.Name = "ToStation";
            this.ToStation.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.HeaderText = "Nummer";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // ConnectionName
            // 
            this.ConnectionName.HeaderText = "Name";
            this.ConnectionName.Name = "ConnectionName";
            this.ConnectionName.ReadOnly = true;
            // 
            // From
            // 
            this.From.HeaderText = "Von";
            this.From.Name = "From";
            this.From.ReadOnly = true;
            // 
            // To
            // 
            this.To.HeaderText = "Nach";
            this.To.Name = "To";
            this.To.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Länge";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 80;
            // 
            // Station
            // 
            this.Station.HeaderText = "Station";
            this.Station.Name = "Station";
            this.Station.ReadOnly = true;
            // 
            // PublicNavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 579);
            this.Controls.Add(this.stationBoardsGrid);
            this.Controls.Add(this.connectionsGrid);
            this.Controls.Add(this.queryConnections);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exchangeStations);
            this.Controls.Add(this.stationTo);
            this.Controls.Add(this.searchResults);
            this.Controls.Add(this.stationFrom);
            this.Name = "PublicNavForm";
            this.Text = "PublicNav";
            ((System.ComponentModel.ISupportInitialize)(this.connectionsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBoardsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).EndInit();
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
        private System.Windows.Forms.Button queryConnections;
        private System.Windows.Forms.BindingSource connectionBindingSource;
        private System.Windows.Forms.DataGridView connectionsGrid;
        private System.Windows.Forms.DataGridView stationBoardsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Station;
    }
}

