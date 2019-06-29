using Final_150402003.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_150402003
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Cb_defectosvisualesd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_defectosvisualesd.Text=="SI")
            {
                MessageBox.Show("Rechazo de compras");
            }
            else if (cb_defectosvisualesd.Text =="NO")
            {
                lbl_dimension.Visible = true;
                cb_defectosvisualesd.Visible = true;
              
            }
        }

        private void Cb_dimensioninsp_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(cb_dimensioninsp.Text=="SI")
            {
                lbl_aceptable.Visible = true;
                cb_aceptable.Visible = true;

            }
            else if(cb_dimensioninsp.Text=="NO")
            {
                MessageBox.Show("Agregar a inventario");
            }

        }

        private void Cb_aceptable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_aceptable.Text == "SI")
            {
                MessageBox.Show("Agregar a inventari");
            }
            else if (cb_aceptable.Text == "NO")
            {
                MessageBox.Show("Genere reporte de acción Colectiva");
            }

        }

        private void Mostrar_reporte_Click(object sender, EventArgs e)
        {
            Materiales material_add = new Materiales
            {
                material_nombre = txtb_material.Text,
                material_cotigo = txb_idmaterial.Text,
                material_Proveedor = txtb_proveedor.Text,
                nombre_categoria = txtb_categoria.Text

            };
        }
    }
}
