using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_9
{
    public partial class Form1 : Form
    {

        Empleados Empleado = new Empleados();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   

        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            int ID;

            if (!int.TryParse(txtID.Text, out ID))

            {
                errorProvider1.SetError(txtID, "No ingresó un ID válido");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtID, "");


            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "No ingresó el nombre");
                txtNombre.Focus();
                return;
            }

            errorProvider1.SetError(txtNombre, "");

            if (txtDUI.Text == "")
            {
                errorProvider1.SetError(txtDUI, "No ingresó el DUI");
                txtNombre.Focus();
                return;
            }

            errorProvider1.SetError(txtNombre, "");


            double Salario;

            if (!double.TryParse(txtSalario.Text, out Salario))

            {
                errorProvider1.SetError(txtSalario, "No ingresó el salario de forma correcta");
                txtSalario.Focus();
                return;
            }
            errorProvider1.SetError(txtID, "");

            Empleado.Id = Convert.ToInt32(txtID.Text);
            Empleado.Nombre = txtNombre.Text;
            Empleado.Dui = txtDUI.Text;
            Empleado.Salario = Convert.ToDouble(txtSalario.Text);
            labelRegistro.Text = "¡Registro guardado!";
        }

        private void txtDUI_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textAFP.Text = Empleado.AFP(Empleado.Salario).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textISSS.Text = Empleado.ISSS(Empleado.Salario).ToString();
        }

        private void btNeto_Click(object sender, EventArgs e)
        {
            textNeto.Text = Empleado.neto(Empleado.Salario, Empleado.ISSS(Empleado.Salario), Empleado.AFP(Empleado.Salario)).ToString();
        }
    }
}

