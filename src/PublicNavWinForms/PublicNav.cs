using PublicNavWinForms.Models;
using SwissTransport;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PublicNavWinForms
{
    class PublicNav
    {
        Transport transport;

        public PublicNav()
        {
            using (WebClient client = new WebClient())
            {
                client.OpenRead("http://transport.opendata.ch");
            }

            transport = new Transport();
        }

        /// <summary>
        /// Gets a the stations automaticily suggested by the Swiss Transport API.
        /// </summary>
        /// <param name="station">The search term to enter</param>
        /// <returns>A collection of strings automaticly suggested</returns>
        public IEnumerable<string> GetStations(string searchTerm)
        {
            return transport.GetStations(searchTerm).StationList.Select(s => s.Name);
        }

        /// <summary>
        /// Gets the connections between two stations.
        /// </summary>
        /// <param name="stationFrom">The startpoint of the journey</param>
        /// <param name="stationTo">The endpoint of the journey</param>
        /// <returns>A collection of connections between two stations to display</returns>
        public IEnumerable<ConnectionEntry> GetConnections(string stationFrom, string stationTo)
        {
            ConnectionEntry tmpEntry;

            Connections connections = transport.GetConnections(stationFrom, stationTo);
            foreach (Connection connection in connections.ConnectionList)
            {
                tmpEntry = new ConnectionEntry
                {
                    StationFrom = connection.From.Station.Name,
                    StationTo = connection.To.Station.Name,
                    DepartureTime = connection.From.Departure.Value.ToString("HH:mm"),
                    ArrivalTime = connection.To.Arrival.Value.ToString("HH:mm"),
                    Duration = connection.Duration.Substring(3, 5)
                };

                yield return tmpEntry;

                foreach (Section section in connection.Sections)
                {
                    tmpEntry = new ConnectionEntry
                    {
                        DepartureTime = section.Departure.Departure.Value.ToString("HH:mm"),
                        ArrivalTime = section.Arrival.Arrival.Value.ToString("HH:mm"),
                        DepartureStation = section.Departure.Station.Name,
                        ArrivalStation = section.Arrival.Station.Name
                    };

                    if (section.Journey != null)
                    {
                        tmpEntry.Direction = section.Journey.To;
                    }
                    else
                    {
                        tmpEntry.Direction = "";
                    }

                    yield return tmpEntry;
                }
            }
        }

        /// <summary>
        /// Gets the station board entries for the given station.
        /// </summary>
        /// <param name="station">The name of the station</param>
        /// <param name="time">The earliest time the board entries should have</param>
        /// <returns>A collection of entries from the station board to be displayed</returns>
        public IEnumerable<BoardEntry> GetStationBoardEntries(string station, string time = "")
        {
            List<StationBoard> stationBoards = null;

            if (!string.IsNullOrWhiteSpace(station))
            {
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
                    yield return new BoardEntry()
                    {
                        DepartureTime = board.Stop.Departure.ToString("HH:mm"),
                        Direction = board.To,
                        Number = board.Number,
                        Name = board.Name,
                        Platform = board.Stop.Platform
                    };
                }
            }
        }
    }
}
