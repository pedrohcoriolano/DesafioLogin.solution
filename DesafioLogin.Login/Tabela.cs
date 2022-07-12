using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioLogin.Login
{
    public partial class Tabela : Form
    {
        public Tabela()
        {
            InitializeComponent();
        }

        private void bntExibir_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = PegarDados();
        }

        public static DataTable PegarDados()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Nome:");
            dt.Columns.Add("Função:");
            dt.Columns.Add("Nacionalidade:");

            dt.Rows.Add("BRIMSTONE", "CONTROLADOR", "EUA");
            dt.Rows.Add("PHOENIX", "DUELISTA", "UK");
            dt.Rows.Add("RAZE", "DUELISTA", "BR");
            dt.Rows.Add("YORU", "DUELISTA", "JP");
            dt.Rows.Add("SKYE", "INICIADORA", "AU");

            return dt;
        }
    }
}
