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
                    connection.Duration.Substring(3),
                    ""
                });

                foreach (Section section in connection.Sections)
                {
                    connectionsGrid.Rows.Add(new object[]
                {
                    "",
                    "",
                    "",
                    section.Arrival.Station.Name
                });
                }
            }
        }
    }
}
