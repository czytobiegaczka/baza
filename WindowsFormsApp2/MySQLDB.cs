using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    class MySQLDB
    {
        private MySqlConnection connection;
        private string datasource;
        private string port;
        private string database;
        private string uid;
        private string password;
        private string ciag;

        //Constructor
        public MySQLDB()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            datasource = "sql7.freesqldatabase.com";
            port = "3306";
            database = "sql7302398";
            uid = "sql7302398";
            password = "HsDmvTJ3Ar";
            string connectionString;
            connectionString = "DATASOURCE=" + datasource + ";" + "PORT=" + port + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "convert zero datetime=True";

            connection = new MySqlConnection(connectionString);
        }
        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void CreateTable()
        {
            string query = "CREATE TABLE miesiac(miesiac_Id INT PRIMARY KEY AUTO_INCREMENT,data VARCHAR(10),dzien VARCHAR(12),waga_Id INT(3),trening_Id INT(3),zawody_Id INT(3))";

            //open connection
            if (OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();

            }

        }

        public void CreateTableWaga()
        {
            string query = "CREATE TABLE waga(waga_Id INT PRIMARY KEY AUTO_INCREMENT,waga DECIMAL(6,2))";

            //open connection
            if (OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();

            }

        }

        public void CreateTableTrening()
        {
            string query = "CREATE TABLE trening(trening_Id INT PRIMARY KEY AUTO_INCREMENT,dystans DECIMAL(6,2))";

            //open connection
            if (OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();

            }
        }

        public void WstawDane(int rok,int miesiac)
        {
            int daysInMounth = System.DateTime.DaysInMonth(rok,miesiac);
            string liczdata;
            string liczdzien;

            //open connection
            if (this.OpenConnection() == true)
            {
                for (int licz=1;licz<=daysInMounth;licz++)
                {
                     MySqlCommand cmd = new MySqlCommand(ciag,connection);
                    //ciag = ;
                    //create command and assign the query and connection from the constructor
                    cmd.CommandText = "INSERT INTO miesiac (data,dzien) VALUES(@wpiszData,@wpiszDzien)";
                    cmd.Prepare();

                    DateTime dt = new DateTime(rok, miesiac, licz);
                    liczdata = dt.ToShortDateString();
                    liczdzien = dt.ToString("dddd");

                    cmd.Parameters.AddWithValue("@wpiszData",liczdata);
                    cmd.Parameters.AddWithValue("@wpiszDzien",liczdzien);

                    cmd.ExecuteNonQuery();
                }               


                 //close connection
                this.CloseConnection();
            }
        }

        public void Rozlacz()
        {
            CloseConnection();
        }
    }
}
