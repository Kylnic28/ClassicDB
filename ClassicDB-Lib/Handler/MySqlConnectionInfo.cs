﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicDB_Lib.Handler
{
    public class MySqlConnectionInfo
    {
        public string? Host { get; init; }
        public ushort Port { get; init; }
        public string? Username { get; init; }
        public string? Password { get; init; }
        public string? Database { get; init; }

        public MySqlConnectionInfo(string host, ushort port, string username, string password, string database)
        {
            this.Host = host;
            this.Port = port;
            this.Username = username;
            this.Password = password;
            this.Database = database;
        }

        public MySqlConnection GetConnection() => new($"server={Host};uid={Username};pwd={Password};database={Database}");

    }
}
