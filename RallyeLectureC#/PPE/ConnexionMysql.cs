﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PPE
{
    static class ConnexionMysql
    {
        static private string scmd = "user=root;password=siojjr;host=HvLampr108p07;database=rallyeLecture";
        static MySqlConnection cnx=new MySqlConnection(scmd);
        static public MySqlConnection GetCnx
        {
            get
            {
                    return cnx;
            }
        }
    }
}
