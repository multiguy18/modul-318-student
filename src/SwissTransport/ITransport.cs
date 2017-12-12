using System;

namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, DateTime? datetime = null);
        Connections GetConnections(string fromStation, string toStattion);
    }
}