﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

//using System.ComponentModel;
//using System.Drawing;
using System.Windows.Forms;

namespace _11253006_DBProject
{
    class DBOperation
    {

        SqlConnection connection;   // sql connection variable.
        SqlCommand sqlCmd;          // sql command
        SqlDataAdapter sqlDa;
        string cnnStr;              // sql connection string..

        public DBOperation()
        {
            cnnStr = "Data Source=.;Initial Catalog=DBPROJECT;Integrated Security=true;";
        }

        public DBOperation(string cnnStr)
        {
            this.cnnStr = cnnStr;
        }

        public DataTable SelectTable(String cmdStr)
        {
            connection = new SqlConnection(cnnStr);
            connection.Open();
            sqlCmd = new SqlCommand(cmdStr, connection);
            sqlDa = new SqlDataAdapter(sqlCmd);

            DataTable dt = new DataTable();
            try
            {
                sqlDa.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata oluştu. Nedeni: \n" + e.ToString());
                throw;
            }
            connection.Close();
            return dt;
        }


        public int RunCommand(string cmdStr)
        {
            int numberOfRows = 0;

            connection = new SqlConnection(cnnStr);
            sqlCmd = new SqlCommand(cmdStr, connection);

            try
            {
                connection.Open();
                numberOfRows = sqlCmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            { 
                numberOfRows = -1;
                connection.Close();
                //throw;
                MessageBox.Show("Hata oluştu. Nedeni: \n" + e.ToString());
            }

            return numberOfRows;
        }




    }
}