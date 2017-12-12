using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;
using System.Globalization;

namespace PublicNavWinForms
{
    public partial class PublicNavForm : Form
    {
        enum StationInputs
        {
            None,
            StationFrom,
            StationTo
        }

        Transport transport;
        StationInputs fieldEntered;

        public PublicNavForm()
        {
            InitializeComponent();
            transport = new Transport();
        }

        private void searchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (fieldEntered)
            {
                case StationInputs.StationFrom:
                    stationFrom.Text = searchResults.Text;
                    break;
                case StationInputs.StationTo:
                    stationTo.Text = searchResults.Text;
                    break;
            }
        }

        private void stationFrom_KeyUp(object sender, KeyEventArgs e)
        {
            ListStations(stationFrom.Text);
        }

        private void stationTo_KeyUp(object sender, KeyEventArgs e)
        {
            ListStations(stationTo.Text);
        }

        private void stationFrom_Enter(object sender, EventArgs e)
        {
            ListStations(stationFrom.Text);

            fieldEntered = StationInputs.StationFrom;
        }

        private void stationTo_Enter(object sender, EventArgs e)
        {
            ListStations(stationTo.Text);

            fieldEntered = StationInputs.StationTo;
        }

        private void ListStations(string stationQuery)
        {
            searchResults.Items.Clear();
            List<Station> stations = transport.GetStations(stationQuery).StationList;
            foreach (Station station in stations)
            {
                searchResults.Items.Add(station.Name);
            }
        }

        private void exchangeStations_Click(object sender, EventArgs e)
        {
            string tempStationFrom = stationFrom.Text;
            stationFrom.Text = stationTo.Text;
            stationTo.Text = tempStationFrom;
        }

        private void queryConnections_Click(object sender, EventArgs e)
        {
            connectionsGrid.Rows.Clear();

            Connections connections = transport.GetConnections(stationFrom.Text, stationTo.Text);
            foreach (Connection connection in connections.ConnectionList)
            {
                connectionsGrid.Rows.Add(new object[]
                {
                    connection.From.Station.Name,
                    connection.To.Station.Name,
                    connection.From.Departure.Value.ToString("HH:mm"),
                    connection.To.Arrival.Value.ToString("HH:mm"),
                    connection.Duration.Substring(3, 5),
                    "",
                    "",
                    ""
                });

                foreach (Section section in connection.Sections)
                {
                    string sectionDirection;
                    string sectionArrival = section.Arrival.Arrival.Value.ToString("HH:mm");

                    if (section.Journey != null)
                    {
                        sectionDirection = section.Journey.To;
                    }
                    else
                    {
                        sectionDirection = "";
                    }

                    connectionsGrid.Rows.Add(new object[]
                    {
                        "",
                        "",
                        section.Departure.Departure.Value.ToString("HH:mm"),
                        section.Arrival.Arrival.Value.ToString("HH:mm"),
                        "",
                        section.Departure.Station.Name,
                        sectionDirection,
                        section.Arrival.Station.Name
                    });
                }
            }

            DisplayStationBoard(stationFrom.Text);
        }

        private void connectionsGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string station = connectionsGrid.Rows[e.RowIndex].Cells["Station"].Value.ToString();
            string strtime = connectionsGrid.Rows[e.RowIndex].Cells["Time"].Value.ToString();

            DisplayStationBoard(station, strtime);
        }

        private void DisplayStationBoard(string station, string time = "")
        {
            List<StationBoard> stationBoards = null;

            stationLabel.Text = "";
            stationBoardsGrid.Rows.Clear();

            if (!string.IsNullOrWhiteSpace(station))
            {
                stationLabel.Text = station;

                if (!string.IsNullOrWhiteSpace(time))
                {
                    DateTime departureTime = DateTime.ParseExact(time, "HH:mm", CultureInfo.InvariantCulture);
                    stationBoards = transport.GetStationBoard(station, departureTime).Entries;
                }
                else
                {
                    stationBoards = transport.GetStationBoard(station).Entries;
                }

                foreach (StationBoard board in stationBoards)
                {
                    stationBoardsGrid.Rows.Add(new object[]
                    {
                        board.Stop.Departure.ToString("HH:mm"),
                        board.To,
                        board.Number,
                        board.Name,
                        board.Stop.Platform
                    });
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
