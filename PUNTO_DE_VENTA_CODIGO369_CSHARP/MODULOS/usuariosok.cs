using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PRUEBA_SISTEMA.CONECCION;
namespace PUNTO_DE_VENTA_CODIGO369_CSHARP
{
    public partial class usuariosok : Form
    {
        public usuariosok()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (textNombre.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONECCIONMAESTRA.conexion;
                con.Open();
                SqlCommand cnn = new SqlCommand();
                cnn = new SqlCommand("insertar_usuario", con);
                cnn.CommandType = CommandType.StoredProcedure;
                cnn.Parameters.AddWithValue("@",);
            }
        }
    }
}
