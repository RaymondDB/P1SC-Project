using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1SC08
{
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        Boolean DataExiste;
        private void frmFactura_Load(object sender, EventArgs e)
        {
            this.Text = "Facturacion";
            this.KeyPreview = true;

            txtFecha.Text = DateTime.Now.ToString("ddMMyyy");
            txtFactura.Text = Busco.BuscaUltimoNumero("1");
        }


        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // pregunta si presionaste la tecla Enter
            {
                e.Handled = true; // si presionaste enter tiene valor true el keypresseventargs
                if (txtFecha.Text.Trim() != string.Empty) // pregunta si es diferente de vacio
                {
                    txtArticulo.Focus(); // mueve el cursor hacia el siguiente textbox (txtArticulo)
                }
            }
        }
        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        double zSubtotal;
        double zImpuesto;
        double zTotal;
        
        double lnImpuesto;
        int PagaImpuesto;

        double nmCant;
        double nmPrec;
        
        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtArticulo.Text.Trim() != string.Empty)
            {
                if (txtCantidad.Text.Trim() != string.Empty)
                {
                    CalcularLineaDetalle();
                }
            }    
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtArticulo.Text.Trim() != string.Empty)
            {
                if (txtCantidad.Text.Trim() != string.Empty)
                {
                    InsertarLinea();
                    TotalizarFactura();

                    LimpiarDetalle();
                    txtArticulo.Focus();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtImpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BuscarArticulo(string txtArticulo)
        {
            string sQuery = "SELECT ITEM, DESCRIPCION, PRECIODEVENTA, IMPUESTO, CANTIDADENEXISTENCIA " + " FROM PRODUCTOS " + " WHERE ITEM = '" + txtArticulo + "'";

            SqlConnection cxn = new SqlConnection(cnn.db);   cxn.Open();
            SqlCommand cmd = new SqlCommand(sQuery, cxn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtDescripcion.Text = dr["DESCRIPCION"].ToString();
                txtPrecio.Text = dr["PRECIODEVENTA"].ToString();
                lnImpuesto = Convert.ToDouble(dr["IMPUESTO"].ToString());
            }
        }

        private void BuscarCliente(string txtIDCliente)
        {
            string sQuery = "SELECT NOMBRE, DIRECCION, PAGAIMPUESTO " + " FROM CLIENTES " + " WHERE IDCLIENTE = '" + txtIDCliente + "'";

            SqlConnection cxn = new SqlConnection(cnn.db); cxn.Open();
            SqlCommand cmd = new SqlCommand(sQuery, cxn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtNombre.Text = dr["NOMBRE"].ToString();
                txtDireccion.Text = dr["DIRECCION"].ToString();
                PagaImpuesto = Convert.ToInt32(dr["PAGAIMPUESTO"].ToString());
                if(txtPagaImpuesto.Text == "1")
                {
                    txtPagaImpuesto.Text = "Si paga impuestos";
                }
                else
                {
                    txtPagaImpuesto.Text = "No paga impuestos";
                }
            }
        }

        private void CalcularLineaDetalle()
        {
            nmCant = 0;
            nmPrec = 0;

            nmCant = Convert.ToDouble(txtCantidad.Text.Trim());
            nmPrec = Convert.ToDouble(txtCantidad.Text.Trim());


            if (nmCant > 0)
            {
                if (nmPrec > 0)
                {
                    double LnTotal = nmPrec * nmCant;

                    if (PagaImpuesto == 1)
                    {
                        txtImpuesto.Text = (LnTotal * lnImpuesto).ToString();
                    }
                    else
                    {
                        txtImpuesto.Text = "0";
                    }
                    txtImpuestoFact.Text = (LnTotal * lnImpuesto).ToString();

                    txtTotalLn.Text = LnTotal.ToString();
                }

            }
        }

        private void EstiloDataGridView()
        {
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.RowHeadersVisible = false;

            this.dgv.Columns.Add("col00", "");
            this.dgv.Columns.Add("col01", "");
            this.dgv.Columns.Add("col02", "");
            this.dgv.Columns.Add("col03", "");
            this.dgv.Columns.Add("col04", "");
            this.dgv.Columns.Add("col05", "");
            this.dgv.Columns.Add("col06", "");

            DataGridViewColumn column;
            column = dgv.Columns[0]; column.Width = 100;
            column = dgv.Columns[1]; column.Width = 420;
            column = dgv.Columns[2]; column.Width = 100;
            column = dgv.Columns[3]; column.Width = 100;
            column = dgv.Columns[4]; column.Width = 100;
            column = dgv.Columns[5]; column.Width = 100;
            column = dgv.Columns[6]; column.Width = 0;

            this.dgv.BorderStyle = BorderStyle.None;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            this.dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            this.dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            this.dgv.BackgroundColor = Color.LightGray;

            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
            this.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            this.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }


        private void InsertarLinea()
        {
            dgv.Rows.Add();
            int xRows = dgv.Rows.Count - 1;

            dgv[00, xRows].Value = txtArticulo.Text;
            dgv[01, xRows].Value = txtDescripcion.Text;
            dgv[02, xRows].Value = txtCantidad.Text;
            dgv[03, xRows].Value = txtPrecio.Text;
            dgv[04, xRows].Value = txtImpuesto.Text;
            dgv[05, xRows].Value = txtTotalLn.Text;
            dgv[06, xRows].Value = xRows.ToString();
        }

        private void LimpiarDetalle()
        {
            txtCantidad.Clear();
            txtArticulo.Clear();

            txtDescripcion.Clear();
            txtImpuesto.Clear();
            txtTotalLn.Clear();
        }


        private void LimpiarFormulario() 
        {
            this.dgv.Rows.Clear();
            this.dgv.Refresh();

            LimpiarDetalle();

            txtFactura.Text = "";
            txtIDcliente.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtPagaImpuesto.Text = "";
            txtSubtotal.Text = "";
            txtImpuestoFact.Text = "";
            txtTotal.Text = ""; 


            txtFactura.Text = Busco.BuscaUltimoNumero("1");

            DataExiste = false;
        }

        private void TotalizarFactura()
        {
            zImpuesto = 0;
            zSubtotal = 0;
            zTotal = 0;

            txtSubtotal.Text = "";
            txtImpuestoFact.Text = "";
            txtTotal.Text = "";

            foreach (DataGridViewRow row in dgv.Rows) // RECORRE EL DATAGRIDVIEW
            {
                double nImpuesto = Convert.ToDouble(dgv.CurrentRow.Cells[4].Value.ToString());
                double nSubTotal = Convert.ToDouble(dgv.CurrentRow.Cells[5].Value.ToString());
                double nTotal = nSubTotal + nImpuesto;

                zImpuesto = zImpuesto + nImpuesto;
                zSubtotal = zSubtotal + nSubTotal;
                zTotal = zTotal + nTotal;
            }

            txtSubtotal.Text = zSubtotal.ToString();
            txtImpuestoFact.Text = zImpuesto.ToString();
            txtTotal.Text = zTotal.ToString();
        }

        private void LimpiarParaVerLaFactura()
        {
            this.dgv.Rows.Clear();
            this.dgv.Refresh();

            txtIDcliente.Clear();
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtFecha.Text = "";
            txtSubtotal.Text = "";
            txtImpuestoFact.Text = "";
            txtTotal.Text = "";
        }


        private void BuscarFactura(string nmrFactura)
        {
            DataExiste = false;

            LimpiarParaVerLaFactura();

            SqlConnection cnx = new SqlConnection(cnn.db); cnx.Open(); // abrimos la conexion a la base de datos
            SqlCommand cmd = new SqlCommand("SELECT A.FACTURA, " +
                                             "A.CLIENTE, " +
                                             "B.NOMBRE, " +
                                             "B.DIRECCION, " +
                                             "A.FECHA, " +
                                             "A.SUBTOTAL, " +
                                             "A.IMPUESTO, " +
                                             "A.MONTOFACTURADO " +
                                             "FROM HFACTURA A " +
                                             "INNER JOIN CLIENTES B ON A.CLIENTE = B.IDCLIENTE " +
                                             "WHERE A.FACTURA = '" + nmrFactura + "' AND A.ACTIVO = 0", cnx);

            SqlDataReader rsd = cmd.ExecuteReader();

            if (rsd.Read()) // pregunta si obtuvo algun registro
            {
                DataExiste = true;

                txtFecha.Text = Convert.ToString(rsd["FECHA"]);
                txtIDcliente.Text = Convert.ToString(rsd["CLIENTE"]);
                txtNombre.Text = Convert.ToString(rsd["NOMBRE"]);
                txtDireccion.Text = Convert.ToString(rsd["DIRECCION"]);

                txtSubtotal.Text = Convert.ToString(rsd["SUBTOTAL"]);
                txtImpuestoFact.Text = Convert.ToString(rsd["IMPUESTO"]);
                txtTotal.Text = Convert.ToString(rsd["MONTOFACTURADO"]);
                
                BuscarDetalle(nmrFactura);
                TotalizarFactura();
            }

            cmd.Dispose();
            cnx.Close();
        }

        private void BuscarDetalle(string nmrFactura)
        {
            string tsQuery = "SELECT A.FACTURA, A.SEC, A.ARTICULO, B.DESCRIPCION, A.CANTIDAD, A.PRECIODEVENTA, A.IMPUESTO, A.MONTOPORLINEA " +
                             "FROM DFACTURA A " +
                             "INNER JOIN PRODUCTO B ON A.ARTICULO = B.ITEM " +
                             "WHERE A.FACTURA = '" + nmrFactura + "'";

            SqlConnection cnx = new SqlConnection(cnn.db); cnx.Open(); // abrimos la conexion a la base de datos
            SqlCommand cmd = new SqlCommand(tsQuery, cnx);

            SqlDataReader rsd = cmd.ExecuteReader();

            while (rsd.Read())
            {
                dgv.Rows.Add();
                int xRows = dgv.Rows.Count - 1;

                dgv[0, xRows].Value = rsd["ARTICULO"].ToString();
                dgv[1, xRows].Value = rsd["DESCRIPCION"].ToString();
                dgv[2, xRows].Value = rsd["CANTIDAD"].ToString();
                dgv[3, xRows].Value = rsd["PRECIODEVENTA"].ToString();
                dgv[4, xRows].Value = rsd["IMPUESTO"].ToString();
                dgv[5, xRows].Value = rsd["MONTOPORLINEA"].ToString();
                dgv[6, xRows].Value = rsd["SEC"].ToString();
            }
        }

        private void InsertarFactura()
        {
            if (dgv.RowCount > 0)
            {
                if (txtTotalLn.Text != string.Empty)
                {
                    string stQuery = "INSERT INTO HFACTURA (FACTURA, CLIENTE, FECHA, SUBTOTAL, " +
                                     "IMPUESTO, MONTOFACTURADO, ACTIVO) " +
                                     "VALUES (@A0, @A1, @A2, @A3, @A4, @A5, @A6);";

                    SqlConnection cnt = new SqlConnection(cnn.db); cnt.Open();
                    SqlCommand cmd = new SqlCommand(stQuery, cnt);

                    cmd.Parameters.AddWithValue("@A0", txtFactura.Text);
                    cmd.Parameters.AddWithValue("@A1", txtIDcliente.Text);
                    cmd.Parameters.AddWithValue("@A2", txtFecha.Text);
                    cmd.Parameters.AddWithValue("@A3", txtSubtotal.Text);
                    cmd.Parameters.AddWithValue("@A4", txtImpuesto.Text);
                    cmd.Parameters.AddWithValue("@A5", txtTotal.Text);
                    cmd.Parameters.AddWithValue("@A6", "1");

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cnt.Close();
                }
            }

        }

        private void InsertaDetalleFactura()
        {
            string stQuery = "INSERT INTO DFACTURA (" +
                             "FACTURA, ARTICULO, CANTIDAD, PRECIODEVENTA, IMPUESTO, MONTOPORLINEA, " +
                             "CLIENTE, FECHA, SEC, ACTIVO, SECUENCIA) " +
                             "VALUES (@A0, @A1, @A2, @A3, @A4, @A5, @A6, @A7, @A8, @A9, @C0);";

            SqlConnection cnt = new SqlConnection(cnn.db); cnt.Open();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                string nmArt = row.Cells[0].Value.ToString();
                string nmCan = row.Cells[2].Value.ToString();
                string nmPre = row.Cells[3].Value.ToString();
                string nmImp = row.Cells[4].Value.ToString();
                string nmTot = row.Cells[5].Value.ToString();

                SqlCommand cmd = new SqlCommand(stQuery, cnt);

                cmd.Parameters.AddWithValue("@A0", txtFactura.Text);
                cmd.Parameters.AddWithValue("@A1", nmArt);
                cmd.Parameters.AddWithValue("@A2", nmCan);
                cmd.Parameters.AddWithValue("@A3", nmPre);
                cmd.Parameters.AddWithValue("@A4", nmImp);
                cmd.Parameters.AddWithValue("@A5", nmTot);
                cmd.Parameters.AddWithValue("@A6", txtIDcliente.Text);
                cmd.Parameters.AddWithValue("@A7", txtFecha.Text);
                cmd.Parameters.AddWithValue("@A8", row);

                cmd.ExecuteNonQuery();
            }

            cnt.Close();
        }


        private void ActualizaFactura()
        {
            // Código para actualizar factura
        }

        private void BorrarFactura(string numProducto)
        {
            SqlConnection cnx = new SqlConnection(cnn.db); cnx.Open();
            string tQuery = "UPDATE HFACTURA " +
                            "SET ACTIVO = 1 " +
                            "FROM HFACTURA " +
                            "WHERE FACTURA = '" + numProducto + "'";

            SqlCommand cmd = new SqlCommand(tQuery, cnx);
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            cnx.Close();
        }


        private void BorrarLineaDelDGV()
        {
            // BOBO
        }

        private void btnInsertarLn_Click(object sender, EventArgs e)
        {
            if (txtArticulo.Text.Trim() != string.Empty)
            {
                if (txtCantidad.Text.Trim() != string.Empty)
                {
                    InsertarLinea();
                    TotalizarFactura();

                    LimpiarDetalle();
                    txtArticulo.Focus();
                }
            }

        }

        private void btnEditarLn_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                LimpiarDetalle();

                txtArticulo.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                txtCantidad.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                txtPrecio.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                txtImpuesto.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                txtTotalLn.Text = dgv.CurrentRow.Cells[5].Value.ToString();

                BorrarLineaDelDGV();
                TotalizarFactura();
                txtArticulo.Focus();
            }

        }

        private void btnBorrarLn_Click(object sender, EventArgs e)
        {
            if (DataExiste == true)
            {
                BorrarFactura(txtArticulo.Text);
            }
        }

        private void btnLimpiarLn_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtIDcliente.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
