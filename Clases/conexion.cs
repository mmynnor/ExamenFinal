using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Final_150402003.Clases
{
    class conexion
    {
        //se creo la variable para la conexion con la base de datos
        SqlConnection conn;
        SqlCommand cmd2;
        SqlDataReader dr2;

        //metodo para la conexion

        public void Conectar()
        {
            conn = new SqlConnection("Data Source=DESKTOP-IT0QNE7\\SQLEXPRESS;Initial Catalog=Examen_150402003;Integrated Security=True");
            conn.Open();
        }

        //metodo para desconectar
        public void Desconectar()
        {
            conn.Close();
        }

    }
}
