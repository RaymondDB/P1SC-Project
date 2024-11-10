using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;  // libreria que permite acceder a la base de datos

namespace P1SC08
{
    public partial class frmClientes : Form
    {
        Boolean DataExiste;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            this.Text = "Maestro de Clientes";  // cambia el titulo de formualario en ejecucion
            this.KeyPreview = true;  // activa las teclas de funciones

            txtCliente.Text = Busco.BuscaUltimoNumero("1");  // buscara el ultimo numero en la tabla

            DataExiste = false;
        }

        private void frmClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)  // estoy preguntando si la tecla que presionaste es igual a 27 (es igual tecla ESC)
            {
                this.Close();  // Cierra el formulario 
            }
        }

        // -------------------------------------------------------------------
        // TEXTBOX
        // -------------------------------------------------------------------
        private void txtClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // pregunta si presionaste la tecla Enter
            {
                e.Handled = true; // si presionaste enter tiene valor true el keypresseventargs
                // .Text ==>> se guarda la data escrita en el textbox
                // .Trim ==>> le suprime los espacios en los lados a lo escrito
                // '  12345  '
                // '12345'

                if (txtCliente.Text.Trim() != string.Empty) // pregunta si es diferente de vacio
                {
                    txtNombre.Focus(); // mueve el cursor hacia el siguiente textbox (txtDescripcion)
                }
            }
        }

        private void txtClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)  // estoy preguntando si la tecla que presionaste es igual a 27 (es igual tecla ESC)
            {
                btnCliente.PerformClick();  // ejecuta el evento del boton btnProducto
            }
        }

        private void txtClientes_Leave(object sender, EventArgs e)
        {
            if (txtCliente.Text.Trim() != string.Empty) // pregunta si es diferente de vacio
            {
                BuscarCliente(txtCliente.Text);  // ejecuto el metodo y le envio el valor contenido en el textbox producto
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // pregunta si presionaste la tecla Enter
            {
                e.Handled = true; // si presionaste enter tiene valor true el keypresseventargs
                if (txtNombre.Text.Trim() != string.Empty) // pregunta si es diferente de vacio
                {
                    txtDireccion.Focus(); // mueve el cursor hacia el siguiente textbox (txtDescripcion)
                }
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // pregunta si presionaste la tecla Enter
            {
                e.Handled = true; // si presionaste enter tiene valor true el keypresseventargs
                if (txtDireccion.Text.Trim() != string.Empty) // pregunta si es diferente de vacio
                {
                    txtSector.Focus(); // mueve el cursor hacia el siguiente textbox (txtDescripcion)
                }
            }
        }

        private void txtSector_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // pregunta si presionaste la tecla Enter
            {
                e.Handled = true; // si presionaste enter tiene valor true el keypresseventargs
                if (txtSector.Text.Trim() != string.Empty) // pregunta si es diferente de vacio
                {
                    txtCiudad.Focus(); // mueve el cursor hacia el siguiente textbox (txtDescripcion)
                }
            }
        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // pregunta si presionaste la tecla Enter
            {
                e.Handled = true; // si presionaste enter tiene valor true el keypresseventargs
                if (txtCiudad.Text.Trim() != string.Empty) // pregunta si es diferente de vacio
                {
                    txtTelefono.Focus(); // mueve el cursor hacia el siguiente textbox (txtDescripcion)
                }
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // pregunta si presionaste la tecla Enter
            {
                e.Handled = true; // si presionaste enter tiene valor true el keypresseventargs
                if (txtTelefono.Text.Trim() != string.Empty) // pregunta si es diferente de vacio
                {
                    txtMovil.Focus(); // mueve el cursor hacia el siguiente textbox (txtDescripcion)
                }
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Trim() != string.Empty) // pregunta si es diferente de vacío
            {
                var nPhone1 = txtTelefono.Text.Replace("-", "");
                txtTelefono.Text = nPhone1.ToString();

                var nPhone2 = txtTelefono.Text.Replace("(", "");
                txtTelefono.Text = nPhone2.ToString();

                var nPhone3 = txtTelefono.Text.Replace(",", "");
                txtTelefono.Text = nPhone3.ToString();
            }
        }


        private void txtMovil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // pregunta si presionaste la tecla Enter
            {
                e.Handled = true; // si presionaste enter tiene valor true el keypresseventargs
                if (txtMovil.Text.Trim() != string.Empty) // pregunta si es diferente de vacio
                {
                    btnGuardar.Focus(); // mueve el cursor hacia el siguiente textbox (txtDescripcion)
                }
            }
        }

        private void txtMovil_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Trim() != string.Empty) // pregunta si es diferente de vacío
            {
                var nPhone1 = txtMovil.Text.Replace("-", "");
                txtMovil.Text = nPhone1.ToString();

                var nPhone2 = txtMovil.Text.Replace("(", "");
                txtMovil.Text = nPhone2.ToString();

                var nPhone3 = txtMovil.Text.Replace(",", "");
                txtMovil.Text = nPhone3.ToString();
            }
        }

        // -------------------------------------------------------------------
        // BOTONES
        // -------------------------------------------------------------------
        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmVENPROD frm = new frmVENPROD();  // asignamos un objeto llamado frm cuyo objetivo es ser el formulario
            frm.Show();  // muestra el formulario
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text.Trim() != string.Empty)
            {
                if (txtNombre.Text.Trim() != string.Empty)
                {
                    if (txtDireccion.Text.Trim() != string.Empty)
                    {
                        if (txtSector.Text.Trim() != string.Empty)
                        {
                            if (txtCiudad.Text.Trim() != string.Empty)
                            {
                                if (txtTelefono.Text.Trim() != string.Empty)
                                {
                                    if(txtMovil.Text.Trim() != string.Empty)
                                    {
                                        if(txtCorreo.Text.Trim() != string.Empty)
                                        {
                                            if (txtBalance.Text.Trim() != string.Empty)
                                            {
                                                if (CmbImpuesto.Text.Trim() != string.Empty)
                                                {
                                                    if (DataExiste == false)
                                                    {
                                                        InsertarData();
                                                    }
                                                    else
                                                    {
                                                        ActualizarData();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                // colocar messagebox
                            }
                            // colocar messagebox
                        }
                        // colocar messagebox
                    }
                    // colocar messagebox
                }
                // colocar messagebox
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();  // ejecutara el metodo LimpiarFormulario
            txtCliente.Focus();  // mueve el cursor hacia el textbox indicado
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DataExiste = true;
            if (DataExiste == true)
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro de borrar? ", "ITLA", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    BorrarData(txtCliente.Text);
                    LimpiarFormulario();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // -------------------------------------------------------------------
        // METODOS
        // -------------------------------------------------------------------
        private void LimpiarFormulario()
        {
            txtCliente.Clear(); // .Clear limpia el contenido del textbox
            txtNombre.Clear();
            txtDireccion.Clear();
            txtSector.Clear();
            txtCiudad.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtMovil.Clear();
            txtBalance.Clear();

            DataExiste = false;

            txtCliente.Text = Busco.BuscaUltimoNumero("1");
        }

        private void BuscarCliente(string numCliente)
        {
            DataExiste = false;

            if (pictureBox1.Image != null) // pregunta si picturebox tiene una imagen presente
            {
                pictureBox1.Image.Dispose(); // descompone la imagen que está presente en picturebox
                pictureBox1.Image = null; // aquí la anula
            }

            SqlConnection cnx = new SqlConnection(cnn.db);
            cnx.Open();  // abrimos la conexión a la base de datos
            SqlCommand cmd = new SqlCommand(
                "SELECT Nombre, Direccion, Sector, Ciudad, Telefono01, Telefono02, IDidentificacion, Estatus, MONTO, Correo, Imagen, PagaImpuesto " +
                "FROM CLIENTES WHERE IDcliente = @IDcliente", cnx);
            cmd.Parameters.AddWithValue("@IDcliente", numCliente);
            SqlDataReader rsd = cmd.ExecuteReader();

            if (rsd.Read())  // pregunta si obtuvo algún registro
            {
                DataExiste = true;

                txtCliente.Text = Convert.ToString(rsd[0]);
                txtNombre.Text = Convert.ToString(rsd["Nombre"]);
                txtDireccion.Text = Convert.ToString(rsd["Direccion"]);
                txtSector.Text = Convert.ToString(rsd["Sector"]);
                txtCiudad.Text = Convert.ToString(rsd["Ciudad"]);
                txtTelefono.Text = Convert.ToString(rsd["Telefono01"]);
                txtMovil.Text = Convert.ToString(rsd["Telefono02"]);
                txtCorreo.Text = Convert.ToString(rsd["Correo"]);
                txtBalance.Text = Convert.ToString(rsd["MONTO"]);
                CmbImpuesto.Text = Convert.ToString(rsd["PagaImpuesto"]);
                // Adaptar otros campos según tus necesidades

                try
                {
                    // Convierte el arreglo que viene de la tabla a imagen
                    pictureBox1.Image = ConvertImage.ByteArrayToImage((byte[])rsd["Imagen"]);
                }
                catch
                {
                    // Manejo de errores para la imagen
                }
            }

            cmd.Dispose();
            cnx.Close();
        }

        private void InsertarData()
        {
            string tQuery = "INSERT INTO CLIENTES (Nombre, Direccion, Sector, Ciudad, Telefono01, Telefono02, IDidentificacion, Estatus, MONTO, Correo, PagaImpuesto) " +
                            "VALUES (@Nombre, @Direccion, @Sector, @Ciudad, @Telefono01, @Telefono02, @IDidentificacion, @Estatus, @MONTO, @Correo, @PagaImpuesto)";

            SqlConnection cnx = new SqlConnection(cnn.db);
            cnx.Open();
            SqlCommand cmd = new SqlCommand(tQuery, cnx);

            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
            cmd.Parameters.AddWithValue("@Sector", txtSector.Text);
            cmd.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);
            cmd.Parameters.AddWithValue("@Telefono01", txtTelefono.Text);
            cmd.Parameters.AddWithValue("@Telefono02", txtMovil.Text);
            cmd.Parameters.AddWithValue("@IDidentificacion", txtCliente.Text); // Puedes ajustar según el campo de ID
            cmd.Parameters.AddWithValue("@Estatus", 1); // Ajustar según el valor que quieras usar
            cmd.Parameters.AddWithValue("@MONTO", txtBalance.Text); // Ajustar según tus necesidades
            cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text); // Ajustar según tus necesidades
            cmd.Parameters.AddWithValue("@PagaImpuesto", CmbImpuesto.Text); // Ajustar según tus necesidades

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            cnx.Close();
        }

        private void ActualizarData()
        {
            string tQuery = "UPDATE CLIENTES SET " +
                            "Nombre = @Nombre, Direccion = @Direccion, Sector = @Sector, Ciudad = @Ciudad, " +
                            "Telefono01 = @Telefono01, Telefono02 = @Telefono02, IDidentificacion = @IDidentificacion, " +
                            "Estatus = @Estatus, MONTO = @MONTO, Correo = @Correo, PagaImpuesto = @PagaImpuesto " +
                            "WHERE IDcliente = @IDcliente";

            SqlConnection cnx = new SqlConnection(cnn.db);
            cnx.Open();
            SqlCommand cmd = new SqlCommand(tQuery, cnx);

            cmd.Parameters.AddWithValue("@IDcliente", txtCliente.Text);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
            cmd.Parameters.AddWithValue("@Sector", txtSector.Text);
            cmd.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);
            cmd.Parameters.AddWithValue("@Telefono01", txtTelefono.Text);
            cmd.Parameters.AddWithValue("@Telefono02", txtMovil.Text);
            cmd.Parameters.AddWithValue("@IDidentificacion", txtCliente.Text); // Puedes ajustar según el campo de ID
            cmd.Parameters.AddWithValue("@Estatus", 1); // Ajustar según el valor que quieras usar
            cmd.Parameters.AddWithValue("@MONTO", txtBalance.Text); // Ajustar según tus necesidades
            cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text); // Ajustar según tus necesidades
            cmd.Parameters.AddWithValue("@PagaImpuesto", CmbImpuesto.Text); // Ajustar según tus necesidades

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            cnx.Close();
        }

        private void BorrarData(string numCliente)
        {
            SqlConnection cnx = new SqlConnection(cnn.db);
            cnx.Open();

            string tQuery = "DELETE FROM CLIENTES WHERE IDcliente = @IDcliente";

            SqlCommand cmd = new SqlCommand(tQuery, cnx);
            cmd.Parameters.AddWithValue("@IDcliente", numCliente);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            cnx.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
