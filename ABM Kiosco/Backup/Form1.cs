using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ABM_Kiosco
{
    public partial class Form1 : Form
    {
        public string dia, hora;
        public OleDbConnection ConexionConBD;
        public OleDbCommand Orden;
        public OleDbDataReader Lector;
        private string strConexion = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\ABM Kiosco\\Kiosco.mdb";
        public string Consulta;
        public string Consulta2;
        public Form1()
        {
            InitializeComponent();
        }
        public void cargartodo() 
        {
            cmb_eliminarproducto.Items.Clear();
            cmb_idprod_compraventa.Items.Clear();
            cmb_modprod.Items.Clear();
            dgv_productos2.Rows.Clear();
            dgv_productos.Rows.Clear();
            cmb_eliminarproducto.Text = "";
            ConexionConBD = new OleDbConnection(strConexion);
            Consulta = "SELECT * FROM Productos ";
            Orden = new OleDbCommand(Consulta, ConexionConBD);
            ConexionConBD.Open();
            Lector = Orden.ExecuteReader();
            while (Lector.Read())
            {
                dgv_productos.Rows.Add(Lector["ID_Producto"], Lector["Insumo"], Lector["Marca"], Lector["Precio"], Lector["Stock"], Lector["Estado"]);
                dgv_productos2.Rows.Add(Lector["ID_Producto"], Lector["Insumo"], Lector["Marca"], Lector["Precio"], Lector["Stock"], Lector["Estado"]);
                cmb_idprod_compraventa.Items.Add(Lector["ID_Producto"]);
                cmb_modprod.Items.Add(Lector["ID_Producto"]);
                cmb_eliminarproducto.Items.Add(Lector["ID_Producto"]);
            }
            ConexionConBD.Close();
            txt_agregarprecio.Text = "$";
            dgv_Historial.Rows.Clear();
            ConexionConBD = new OleDbConnection(strConexion);
            Consulta = "SELECT * FROM Historial ";
            Orden = new OleDbCommand(Consulta, ConexionConBD);
            ConexionConBD.Open();
            Lector = Orden.ExecuteReader();
            while (Lector.Read())
            {
                dgv_Historial.Rows.Add(Lector["ID_Historial"], Lector["ID_Producto"], Lector["Descripcion"], Lector["Dia"], Lector["Hora"]);
            }
            ConexionConBD.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargartodo();
        }

        private void txt_cantstock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cantstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(8))
            {
                e.Handled = false;
            }

        }

        private void chk_venta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_modificarstock_Click(object sender, EventArgs e)
        {
            string estadox = "";
            ConexionConBD = new OleDbConnection(strConexion);
            Consulta = ("SELECT Estado FROM Productos WHERE ID_Producto=" + cmb_idprod_compraventa.Text + "");
            Orden = new OleDbCommand(Consulta, ConexionConBD);
            ConexionConBD.Open();
            Lector = Orden.ExecuteReader();
            while (Lector.Read())
            {
                estadox = Convert.ToString(Lector["Estado"]);
            }
            ConexionConBD.Close();
            if (estadox == "Activado")
            {
                ConexionConBD = new OleDbConnection(strConexion);
                Consulta = ("UPDATE Productos SET Stock='" + txt_cantstock.Text + "' WHERE ID_Producto=" + cmb_idprod_compraventa.Text + "");
                Orden = new OleDbCommand(Consulta, ConexionConBD);
                ConexionConBD.Open();
                Lector = Orden.ExecuteReader();
                while (Lector.Read())
                {
                    txt_cantstock.Text = Convert.ToString(Lector["Stock"]);
                }
                ConexionConBD.Close();
                dia = DateTime.Now.ToString("dd/MM/yyyy");
                hora = DateTime.Now.ToShortTimeString();
                DialogResult exito = MessageBox.Show("Se ha modificado el Stock correctamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConexionConBD = new OleDbConnection(strConexion);
                Consulta = ("INSERT INTO Historial (ID_Producto, Descripcion, Dia, Hora) values ('" + cmb_idprod_compraventa.Text + "','Modificacion stock','" + dia + "','" + hora + "')");
                Orden = new OleDbCommand(Consulta, ConexionConBD);
                ConexionConBD.Open();
                Lector = Orden.ExecuteReader();
                ConexionConBD.Close();
                cargartodo();
            }
            if (estadox == "Desactivado")
            {
                DialogResult error = MessageBox.Show("El articulo esta actualente desactivado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmd_idprod_compraventa_IndexChanged(object sender, EventArgs e)
        {
            ConexionConBD = new OleDbConnection(strConexion);
            Consulta = ("SELECT Stock FROM Productos WHERE ID_Producto =" + cmb_idprod_compraventa.Text + "");
            Orden = new OleDbCommand(Consulta, ConexionConBD);
            ConexionConBD.Open();
            Lector = Orden.ExecuteReader();
            while (Lector.Read())
            {
                txt_cantstock.Text = Convert.ToString(Lector["Stock"]);
            }
            ConexionConBD.Close();
        }

        private void btn_cantmenos_Click(object sender, EventArgs e)
        {
            int menos = 0;
            menos = Convert.ToInt16(txt_cantstock.Text);
            menos = menos - 1;
            txt_cantstock.Text = Convert.ToString(menos);
        }

        private void btn_cantmas_Click(object sender, EventArgs e)
        {
            int mas = 0;
            mas = Convert.ToInt16(txt_cantstock.Text);
            mas = mas + 1;
            txt_cantstock.Text = Convert.ToString(mas);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_modprod_IndexChanged(object sender, EventArgs e)
        {
            string act = "";
            ConexionConBD = new OleDbConnection(strConexion);
            Consulta = ("SELECT * FROM Productos WHERE ID_Producto =" + cmb_modprod.Text + "");
            Orden = new OleDbCommand(Consulta, ConexionConBD);
            ConexionConBD.Open();
            Lector = Orden.ExecuteReader();
            while (Lector.Read())
            {
                txt_modinsumo.Text = Convert.ToString(Lector["Insumo"]);
                txt_modmarca.Text = Convert.ToString(Lector["Marca"]);
                txt_modprecio.Text = Convert.ToString(Lector["Precio"]);
                act = Convert.ToString(Lector["Estado"]);
            }
            if (act == "Activado")
            {
                rbn_activado.Checked = true;
            }
            else rbn_desactivado.Checked = true;
            ConexionConBD.Close();
        }

        private void btn_aplicar_Click(object sender, EventArgs e)
        {
            string check = "";
            if (rbn_activado.Checked == true) {
                check = "Activado";
            } else check = "Desactivado";
            DialogResult seguro = MessageBox.Show("Seguro desea aplicar los cambios?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (seguro)
            {
                case DialogResult.Yes:
                    ConexionConBD = new OleDbConnection(strConexion);
                    Consulta = ("UPDATE Productos SET Insumo='" + txt_modinsumo.Text + "', Marca='" + txt_modmarca.Text + "', Precio ='" + txt_modprecio.Text + "' WHERE ID_Producto=" + cmb_modprod.Text +"");
                    Orden = new OleDbCommand(Consulta, ConexionConBD);
                    ConexionConBD.Open();
                    Lector = Orden.ExecuteReader();
                    ConexionConBD.Close();
                    if (check == "Activado")
                    {
                        ConexionConBD = new OleDbConnection(strConexion);
                        Consulta = ("UPDATE Productos SET Estado='" + check + "' WHERE ID_Producto=" + cmb_modprod.Text + "");
                        Orden = new OleDbCommand(Consulta, ConexionConBD);
                        ConexionConBD.Open();
                        Lector = Orden.ExecuteReader();
                        ConexionConBD.Close();
                        dia = DateTime.Now.ToString("dd/MM/yyyy");
                        hora = DateTime.Now.ToShortTimeString();
                        ConexionConBD = new OleDbConnection(strConexion);
                        Consulta = ("INSERT INTO Historial (ID_Producto, Descripcion, Dia, Hora) values ('" + cmb_modprod.Text + "','Modificacion Producto (Activado)','" + dia + "','" + hora + "')");
                        Orden = new OleDbCommand(Consulta, ConexionConBD);
                        ConexionConBD.Open();
                        Lector = Orden.ExecuteReader();
                        ConexionConBD.Close();
                        cargartodo();
                    }
                    else if (check == "Desactivado")
                    {
                        ConexionConBD = new OleDbConnection(strConexion);
                        Consulta = ("UPDATE Productos SET Estado='" + check + "' WHERE ID_Producto=" + cmb_modprod.Text + "");
                        Orden = new OleDbCommand(Consulta, ConexionConBD);
                        ConexionConBD.Open();
                        Lector = Orden.ExecuteReader();
                        ConexionConBD.Close();
                        dia = DateTime.Now.ToString("dd/MM/yyyy");
                        hora = DateTime.Now.ToShortTimeString();
                        ConexionConBD = new OleDbConnection(strConexion);
                        Consulta = ("INSERT INTO Historial (ID_Producto, Descripcion, Dia, Hora) values ('" + cmb_modprod.Text + "','Modificacion Producto (Desactivado)','" + dia + "','" + hora + "')");
                        Orden = new OleDbCommand(Consulta, ConexionConBD);
                        ConexionConBD.Open();
                        Lector = Orden.ExecuteReader();
                        ConexionConBD.Close();
                        cargartodo();
                    }
                    cargartodo();
                    DialogResult exito = MessageBox.Show("Se ha modificado el producto correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public string idproducto = "";
        public void tomarvalor()
        {
            ConexionConBD = new OleDbConnection(strConexion);
            Consulta = ("SELECT * from Productos WHERE ID_Producto=" + txt_agregarid.Text + "");
            Orden = new OleDbCommand(Consulta, ConexionConBD);
            ConexionConBD.Open();
            Lector = Orden.ExecuteReader();
            while (Lector.Read())
            {
                idproducto = Convert.ToString(Lector["ID_Producto"]);
            }
            ConexionConBD.Close();
        }
        private void btn_agregarprod_Click(object sender, EventArgs e)
        {
            ConexionConBD = new OleDbConnection(strConexion);
            Consulta = ("INSERT INTO Productos (ID_Producto, Insumo, Marca, Precio, Stock, Estado) values ('" + txt_agregarid.Text + "','" + txt_agregarinsumo.Text + "','" + txt_agregarmarca.Text + "','" + txt_agregarprecio.Text + "','" + txt_agregarstock.Text + "', 'Activado')");
            Orden = new OleDbCommand(Consulta, ConexionConBD);
            ConexionConBD.Open();
            Lector = Orden.ExecuteReader();
            ConexionConBD.Close();
            tomarvalor();
            dia = DateTime.Now.ToString("dd/MM/yyyy");
            hora = DateTime.Now.ToShortTimeString();
            ConexionConBD = new OleDbConnection(strConexion);
            Consulta = ("INSERT INTO Historial (ID_Producto, Descripcion, Dia, Hora) values ('" + idproducto + "','Agregacion Producto','" + dia + "','" + hora + "')");
            Orden = new OleDbCommand(Consulta, ConexionConBD);
            ConexionConBD.Open();
            Lector = Orden.ExecuteReader();
            ConexionConBD.Close();
            cargartodo();
            DialogResult exito = MessageBox.Show("El producto se agrego correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txt_agregarid_keypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(8))
            {
                e.Handled = false;
            }
        }

        private void btn_eliminarproducto_Click(object sender, EventArgs e)
        {
            DialogResult seguro = MessageBox.Show("Esta seguro que desea eliminar el Producto?", "Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (seguro)
            {
                case DialogResult.Yes:
                    ConexionConBD = new OleDbConnection(strConexion);
                    Consulta = ("DELETE FROM Historial WHERE ID_Producto=" + cmb_eliminarproducto.Text + "");
                    Orden = new OleDbCommand(Consulta, ConexionConBD);
                    ConexionConBD.Open();
                    Lector = Orden.ExecuteReader();
                    ConexionConBD.Close();
                    ConexionConBD = new OleDbConnection(strConexion);
                    Consulta = ("DELETE FROM Productos WHERE ID_Producto=" + cmb_eliminarproducto.Text + "");
                    Orden = new OleDbCommand(Consulta, ConexionConBD);
                    ConexionConBD.Open();
                    Lector = Orden.ExecuteReader();
                    ConexionConBD.Close();
                    DialogResult exito = MessageBox.Show("El Producto ha sido eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargartodo();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void txt_agregarprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(8))
            {
                e.Handled = false;
            }
            if (e.KeyChar == '$')
            {
                TextBox ObjtextBox = (TextBox)sender;
                if (ObjtextBox.SelectionLength == ObjtextBox.TextLength)
                {
                    e.Handled = false;
                }
                else if (ObjtextBox.TextLength != 0)
                {
                    e.Handled = true;
                }
            }


        }

        private void txt_agregarstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(8))
            {
                e.Handled = false;
            }
        }
    }
}
