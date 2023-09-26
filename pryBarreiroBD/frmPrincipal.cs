using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;

namespace pryBarreiroBD
{
    public partial class frmPrincipal : Form
    {
        OleDbConnection ConexionBD;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cmdConectarBase_Click(object sender, EventArgs e)
        {
            ConexionBD = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Alumnos\\source\\repos\\pryBarreiroBD\\pryBarreiroBD\\BaseDatos\\EL_CLUB.accdb");
            ConexionBD.Open();
            lblResultado.Text = "Conectado";
            lblResultado.BackColor = Color.LightGreen;
        }
    }
}
