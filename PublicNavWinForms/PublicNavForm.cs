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
            StationForm,
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
                case StationInputs.StationForm:
                    stationFrom.Text = searchResults.Text;
                    break;
                case StationInputs.StationTo:
                    stationTo.Text = searchResults.Text;
                    break;
            }
        }

        private void stationFrom_KeyUp(object sender, KeyEventArgs e)
        {
            searchResults.Items.Clear();
            List<Station> stations = transport.GetStations(stationFrom.Text).StationList;
            foreach (Station station in stations)
            {
                searchResults.Items.Add(station.Name);
            }

            fieldEntered = StationInputs.StationForm;
        }

        private void stationTo_KeyUp(object sender, KeyEventArgs e)
        {
            searchResults.Items.Clear();
            List<Station> stations = transport.GetStations(stationFrom.Text).StationList;
            foreach (Station station in stations)
            {
                searchResults.Items.Add(station.Name);
            }

            fieldEntered = StationInputs.StationForm;
        }
    }
}
