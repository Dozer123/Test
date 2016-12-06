using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using SimpleREST.Models;

namespace SimpleREST
{
    public class PersonResistance
    {
        private string myConnectionStr = "DATA SOURCE=ORCL;PERSIST SECURITY INFO=True;USER ID=MBANK";
        private OracleConnection con;
        // public Models.Person v_contracts;

        public PersonResistance(Models.Person v_contracts)
        {
            con = new OracleConnection(myConnectionStr);
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from contracts";
            //cmd.CommandType = CommandType.text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            con.Dispose();
        }
            
    }
}