﻿using ExercicioCrudWinForms.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCrudWinForms.Model
{
    public class Connection:Iconnection
    {
        const string connection = @"Data Source=DESKTOP-I3T263P\SQLEXPRESS;Initial Catalog=ENGENHARIA;Integrated Security=True";
        public SqlConnection Conexao()
        {
            SqlConnection conn = new SqlConnection(connection);
            return conn;
        }
    }
}
