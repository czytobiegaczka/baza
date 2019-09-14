using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private MySQLDB MyConnect;

        public Form1()
        {
            InitializeComponent();
            MyConnect = new MySQLDB();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            MyConnect.CreateTable();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            MyConnect.CreateTable();
        }

        private void BtnWaga_Click(object sender, EventArgs e)
        {
            MyConnect.CreateTableWaga();
        }

        private void BtnTrening_Click(object sender, EventArgs e)
        {
            MyConnect.CreateTableTrening();
        }

        private void BtnWstaw_Click(object sender, EventArgs e)
        {
            int miesiac = 10;
            MyConnect.WstawDane(DateTime.Now.Year, miesiac);
        }

        private void BtnRozlacz_Click(object sender, EventArgs e)
        {
            MyConnect.Rozlacz();
        }
    }
}
