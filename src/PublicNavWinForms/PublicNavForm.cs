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
using System.Net;
using PublicNavWinForms.Models;

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
        PublicNav publicNav;
        StationInputs fieldEntered;

        public PublicNavForm()
        {
            InitializeComponent();

            try
            {
                publicNav = new PublicNav();
            }
            catch (WebException)
            {
                ShowConnectionError();
                Close();
            }
            
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

            try
            {
                searchResults.Items.AddRange(publicNav.GetStations(stationQuery).ToArray());
            }
            catch
            {
                ShowConnectionError();
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

            IEnumerable<ConnectionEntry> connections = null;

            try
            {
                connections = publicNav.GetConnections(stationFrom.Text, stationTo.Text);
            }
            catch (WebException)
            {
                ShowConnectionError();
                return;
            }

            foreach (ConnectionEntry connection in connections)
            {
                connectionsGrid.Rows.Add(new object[] {
                    connection.StationFrom,
                    connection.StationTo,
                    connection.DepartureTime,
                    connection.ArrivalTime,
                    connection.Duration,
                    connection.DepartureStation,
                    connection.Direction,
                    connection.ArrivalStation
                });
            }

            DisplayStationBoard(stationFrom.Text);
        }

        private void connectionsGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string station = "";
            string strtime = "";

            if (connectionsGrid.Rows[e.RowIndex].Cells["Station"].Value != null)
            {
                station = connectionsGrid.Rows[e.RowIndex].Cells["Station"].Value.ToString();
                strtime = connectionsGrid.Rows[e.RowIndex].Cells["Time"].Value.ToString();
            }

            DisplayStationBoard(station, strtime);
        }

        private void DisplayStationBoard(string station, string time = "")
        {
            stationLabel.Text = "";
            stationBoardsGrid.Rows.Clear();

            stationLabel.Text = station;

            IEnumerable<BoardEntry> boardEntrys = null;

            try
            {
                boardEntrys = publicNav.GetStationBoardEntries(station, time);
            }
            catch (WebException)
            {
                ShowConnectionError();
                return;
            }

            foreach (BoardEntry boardEntry in boardEntrys)
            {
                stationBoardsGrid.Rows.Add(new object[] {
                    boardEntry.DepartureTime,
                    boardEntry.Direction,
                    boardEntry.Number,
                    boardEntry.Name,
                    boardEntry.Platform
                });
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ShowConnectionError()
        {
            MessageBox.Show("http://transport.opendata.ch ist nicht verfügbar. " +
                "Bitte überprüfen sie ihre Internetverbindung oder ihre Proxy-Einstellungen. " +
                "Sollte das Problem weiterhin bestehen, dann wenden sie sich an den Author der Anwendung unter: " +
                "https://github.com/multiguy18/modul-318-student", "Netzwerkfehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Close();
        }
    }
}
