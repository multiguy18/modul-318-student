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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublicNavForm));
            this.stationFrom = new System.Windows.Forms.TextBox();
            this.searchResults = new System.Windows.Forms.ListBox();
            this.stationTo = new System.Windows.Forms.TextBox();
            this.exchangeStations = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.queryConnections = new System.Windows.Forms.Button();
            this.connectionsGrid = new System.Windows.Forms.DataGridView();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationBoardsGrid = new System.Windows.Forms.DataGridView();
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoardDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConnectionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.stationLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBoardsGrid)).BeginInit();
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
            this.exchangeStations.Image = ((System.Drawing.Image)(resources.GetObject("exchangeStations.Image")));
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
            this.queryConnections.Location = new System.Drawing.Point(35, 178);
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
            this.Time,
            this.ArrivalTime,
            this.Duration,
            this.Station,
            this.Direction,
            this.EndStation});
            this.connectionsGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.connectionsGrid.Location = new System.Drawing.Point(35, 256);
            this.connectionsGrid.MultiSelect = false;
            this.connectionsGrid.Name = "connectionsGrid";
            this.connectionsGrid.ReadOnly = true;
            this.connectionsGrid.RowHeadersVisible = false;
            this.connectionsGrid.RowTemplate.Height = 24;
            this.connectionsGrid.Size = new System.Drawing.Size(908, 253);
            this.connectionsGrid.TabIndex = 7;
            this.connectionsGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.connectionsGrid_RowEnter);
            // 
            // From
            // 
            this.From.HeaderText = "Von";
            this.From.Name = "From";
            this.From.ReadOnly = true;
            // 
            // To
            // 
            this.To.HeaderText = "Bis";
            this.To.Name = "To";
            this.To.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Abfahrt";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 50;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.HeaderText = "Ankunft";
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.ReadOnly = true;
            this.ArrivalTime.Width = 50;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Dauer";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 50;
            // 
            // Station
            // 
            this.Station.HeaderText = "Station";
            this.Station.Name = "Station";
            this.Station.ReadOnly = true;
            // 
            // Direction
            // 
            this.Direction.HeaderText = "Richtung";
            this.Direction.Name = "Direction";
            this.Direction.ReadOnly = true;
            // 
            // EndStation
            // 
            this.EndStation.HeaderText = "Endstation";
            this.EndStation.Name = "EndStation";
            this.EndStation.ReadOnly = true;
            // 
            // stationBoardsGrid
            // 
            this.stationBoardsGrid.AllowUserToAddRows = false;
            this.stationBoardsGrid.AllowUserToDeleteRows = false;
            this.stationBoardsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stationBoardsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureTime,
            this.BoardDirection,
            this.Number,
            this.ConnectionName,
            this.Platform});
            this.stationBoardsGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.stationBoardsGrid.Location = new System.Drawing.Point(438, 36);
            this.stationBoardsGrid.MultiSelect = false;
            this.stationBoardsGrid.Name = "stationBoardsGrid";
            this.stationBoardsGrid.ReadOnly = true;
            this.stationBoardsGrid.RowHeadersVisible = false;
            this.stationBoardsGrid.RowTemplate.Height = 24;
            this.stationBoardsGrid.Size = new System.Drawing.Size(505, 188);
            this.stationBoardsGrid.TabIndex = 8;
            // 
            // DepartureTime
            // 
            this.DepartureTime.HeaderText = "Abfahrt";
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.ReadOnly = true;
            this.DepartureTime.Width = 50;
            // 
            // BoardDirection
            // 
            this.BoardDirection.HeaderText = "Richtung";
            this.BoardDirection.Name = "BoardDirection";
            this.BoardDirection.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.HeaderText = "Nummer";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 70;
            // 
            // ConnectionName
            // 
            this.ConnectionName.HeaderText = "Name";
            this.ConnectionName.Name = "ConnectionName";
            this.ConnectionName.ReadOnly = true;
            this.ConnectionName.Width = 70;
            // 
            // Platform
            // 
            this.Platform.HeaderText = "Gleis / Kante";
            this.Platform.Name = "Platform";
            this.Platform.ReadOnly = true;
            this.Platform.Width = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Abfahrtstafel:";
            // 
            // stationLabel
            // 
            this.stationLabel.AutoSize = true;
            this.stationLabel.Location = new System.Drawing.Point(533, 16);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(0, 17);
            this.stationLabel.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Verbindungen:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(529, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Auf eine Zeile mit einem Eintrag in Station klicken, um die Abfahrtstafel anzuzei" +
    "gen";
            // 
            // PublicNavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 540);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stationLabel);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.DataGridView connectionsGrid;
        private System.Windows.Forms.DataGridView stationBoardsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Station;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndStation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label stationLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoardDirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConnectionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
        private System.Windows.Forms.Label label5;
    }
}

