namespace ABM_Kiosco
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_historial = new System.Windows.Forms.TabPage();
            this.dgv_Historial = new System.Windows.Forms.DataGridView();
            this.ID_Historial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Producto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_row_dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_historial_Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_altabaja = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_eliminarproducto = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_eliminarproducto = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_agregarprod = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_agregarstock = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_agregarprecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_agregarmarca = new System.Windows.Forms.TextBox();
            this.txt_agregarinsumo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_agregarid = new System.Windows.Forms.TextBox();
            this.dgv_productos2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_stock = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbn_activado = new System.Windows.Forms.RadioButton();
            this.rbn_desactivado = new System.Windows.Forms.RadioButton();
            this.btn_aplicar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_modprecio = new System.Windows.Forms.TextBox();
            this.txt_modmarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_modinsumo = new System.Windows.Forms.TextBox();
            this.cmb_modprod = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cantmenos = new System.Windows.Forms.Button();
            this.btn_cantmas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_idprod_compraventa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_modificarstock = new System.Windows.Forms.Button();
            this.txt_cantstock = new System.Windows.Forms.TextBox();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.ID_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tab_historial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Historial)).BeginInit();
            this.tab_altabaja.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos2)).BeginInit();
            this.tab_stock.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.tab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_historial
            // 
            this.tab_historial.Controls.Add(this.dgv_Historial);
            this.tab_historial.Location = new System.Drawing.Point(4, 22);
            this.tab_historial.Name = "tab_historial";
            this.tab_historial.Padding = new System.Windows.Forms.Padding(3);
            this.tab_historial.Size = new System.Drawing.Size(848, 512);
            this.tab_historial.TabIndex = 3;
            this.tab_historial.Text = "Historial";
            this.tab_historial.UseVisualStyleBackColor = true;
            // 
            // dgv_Historial
            // 
            this.dgv_Historial.AllowUserToAddRows = false;
            this.dgv_Historial.AllowUserToDeleteRows = false;
            this.dgv_Historial.AllowUserToResizeColumns = false;
            this.dgv_Historial.AllowUserToResizeRows = false;
            this.dgv_Historial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Historial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Historial,
            this.ID_Producto2,
            this.Descripcion,
            this.dgv_row_dia,
            this.dgv_historial_Hora});
            this.dgv_Historial.Location = new System.Drawing.Point(6, 6);
            this.dgv_Historial.Name = "dgv_Historial";
            this.dgv_Historial.ReadOnly = true;
            this.dgv_Historial.RowHeadersVisible = false;
            this.dgv_Historial.Size = new System.Drawing.Size(836, 500);
            this.dgv_Historial.TabIndex = 0;
            // 
            // ID_Historial
            // 
            this.ID_Historial.HeaderText = "ID Historial";
            this.ID_Historial.Name = "ID_Historial";
            this.ID_Historial.ReadOnly = true;
            // 
            // ID_Producto2
            // 
            this.ID_Producto2.HeaderText = "ID Producto";
            this.ID_Producto2.Name = "ID_Producto2";
            this.ID_Producto2.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // dgv_row_dia
            // 
            this.dgv_row_dia.HeaderText = "Dia";
            this.dgv_row_dia.Name = "dgv_row_dia";
            this.dgv_row_dia.ReadOnly = true;
            // 
            // dgv_historial_Hora
            // 
            this.dgv_historial_Hora.HeaderText = "Hora";
            this.dgv_historial_Hora.Name = "dgv_historial_Hora";
            this.dgv_historial_Hora.ReadOnly = true;
            // 
            // tab_altabaja
            // 
            this.tab_altabaja.Controls.Add(this.groupBox5);
            this.tab_altabaja.Controls.Add(this.groupBox4);
            this.tab_altabaja.Controls.Add(this.dgv_productos2);
            this.tab_altabaja.Location = new System.Drawing.Point(4, 22);
            this.tab_altabaja.Name = "tab_altabaja";
            this.tab_altabaja.Padding = new System.Windows.Forms.Padding(3);
            this.tab_altabaja.Size = new System.Drawing.Size(848, 512);
            this.tab_altabaja.TabIndex = 1;
            this.tab_altabaja.Text = "Alta / Baja";
            this.tab_altabaja.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_eliminarproducto);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.cmb_eliminarproducto);
            this.groupBox5.Location = new System.Drawing.Point(563, 272);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(279, 234);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Eliminar Producto";
            // 
            // btn_eliminarproducto
            // 
            this.btn_eliminarproducto.Location = new System.Drawing.Point(73, 138);
            this.btn_eliminarproducto.Name = "btn_eliminarproducto";
            this.btn_eliminarproducto.Size = new System.Drawing.Size(145, 52);
            this.btn_eliminarproducto.TabIndex = 2;
            this.btn_eliminarproducto.Text = "Eliminar";
            this.btn_eliminarproducto.UseVisualStyleBackColor = true;
            this.btn_eliminarproducto.Click += new System.EventHandler(this.btn_eliminarproducto_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Seleccione el ID del Producto";
            // 
            // cmb_eliminarproducto
            // 
            this.cmb_eliminarproducto.FormattingEnabled = true;
            this.cmb_eliminarproducto.Location = new System.Drawing.Point(6, 76);
            this.cmb_eliminarproducto.Name = "cmb_eliminarproducto";
            this.cmb_eliminarproducto.Size = new System.Drawing.Size(267, 21);
            this.cmb_eliminarproducto.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_agregarprod);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txt_agregarstock);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txt_agregarprecio);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txt_agregarmarca);
            this.groupBox4.Controls.Add(this.txt_agregarinsumo);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txt_agregarid);
            this.groupBox4.Location = new System.Drawing.Point(16, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(528, 234);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agregar Producto";
            // 
            // btn_agregarprod
            // 
            this.btn_agregarprod.Location = new System.Drawing.Point(279, 168);
            this.btn_agregarprod.Name = "btn_agregarprod";
            this.btn_agregarprod.Size = new System.Drawing.Size(204, 50);
            this.btn_agregarprod.TabIndex = 12;
            this.btn_agregarprod.Text = "Agregar";
            this.btn_agregarprod.UseVisualStyleBackColor = true;
            this.btn_agregarprod.Click += new System.EventHandler(this.btn_agregarprod_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(99, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Stock";
            // 
            // txt_agregarstock
            // 
            this.txt_agregarstock.Location = new System.Drawing.Point(15, 184);
            this.txt_agregarstock.Name = "txt_agregarstock";
            this.txt_agregarstock.Size = new System.Drawing.Size(204, 20);
            this.txt_agregarstock.TabIndex = 10;
            this.txt_agregarstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_agregarstock_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(364, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Precio";
            // 
            // txt_agregarprecio
            // 
            this.txt_agregarprecio.Location = new System.Drawing.Point(279, 113);
            this.txt_agregarprecio.Name = "txt_agregarprecio";
            this.txt_agregarprecio.Size = new System.Drawing.Size(204, 20);
            this.txt_agregarprecio.TabIndex = 8;
            this.txt_agregarprecio.Text = "$";
            this.txt_agregarprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_agregarprecio_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Marca";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_agregarmarca
            // 
            this.txt_agregarmarca.Location = new System.Drawing.Point(15, 113);
            this.txt_agregarmarca.Name = "txt_agregarmarca";
            this.txt_agregarmarca.Size = new System.Drawing.Size(204, 20);
            this.txt_agregarmarca.TabIndex = 6;
            // 
            // txt_agregarinsumo
            // 
            this.txt_agregarinsumo.Location = new System.Drawing.Point(279, 45);
            this.txt_agregarinsumo.Name = "txt_agregarinsumo";
            this.txt_agregarinsumo.Size = new System.Drawing.Size(204, 20);
            this.txt_agregarinsumo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Insumo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "ID del Producto";
            // 
            // txt_agregarid
            // 
            this.txt_agregarid.Location = new System.Drawing.Point(15, 45);
            this.txt_agregarid.Name = "txt_agregarid";
            this.txt_agregarid.Size = new System.Drawing.Size(204, 20);
            this.txt_agregarid.TabIndex = 2;
            this.txt_agregarid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_agregarid_keypress);
            // 
            // dgv_productos2
            // 
            this.dgv_productos2.AllowUserToAddRows = false;
            this.dgv_productos2.AllowUserToDeleteRows = false;
            this.dgv_productos2.AllowUserToResizeColumns = false;
            this.dgv_productos2.AllowUserToResizeRows = false;
            this.dgv_productos2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productos2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_productos2.ColumnHeadersHeight = 20;
            this.dgv_productos2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgv_productos2.Location = new System.Drawing.Point(16, 20);
            this.dgv_productos2.Name = "dgv_productos2";
            this.dgv_productos2.ReadOnly = true;
            this.dgv_productos2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_productos2.RowHeadersVisible = false;
            this.dgv_productos2.Size = new System.Drawing.Size(826, 246);
            this.dgv_productos2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Insumo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // tab_stock
            // 
            this.tab_stock.Controls.Add(this.groupBox2);
            this.tab_stock.Controls.Add(this.groupBox1);
            this.tab_stock.Controls.Add(this.dgv_productos);
            this.tab_stock.Location = new System.Drawing.Point(4, 22);
            this.tab_stock.Name = "tab_stock";
            this.tab_stock.Padding = new System.Windows.Forms.Padding(3);
            this.tab_stock.Size = new System.Drawing.Size(848, 512);
            this.tab_stock.TabIndex = 0;
            this.tab_stock.Text = "Stock";
            this.tab_stock.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btn_aplicar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_modprecio);
            this.groupBox2.Controls.Add(this.txt_modmarca);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_modinsumo);
            this.groupBox2.Controls.Add(this.cmb_modprod);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(305, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 212);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar Producto";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbn_activado);
            this.groupBox3.Controls.Add(this.rbn_desactivado);
            this.groupBox3.Location = new System.Drawing.Point(223, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 79);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estado";
            // 
            // rbn_activado
            // 
            this.rbn_activado.AutoSize = true;
            this.rbn_activado.Location = new System.Drawing.Point(21, 25);
            this.rbn_activado.Name = "rbn_activado";
            this.rbn_activado.Size = new System.Drawing.Size(67, 17);
            this.rbn_activado.TabIndex = 16;
            this.rbn_activado.TabStop = true;
            this.rbn_activado.Text = "Activado";
            this.rbn_activado.UseVisualStyleBackColor = true;
            this.rbn_activado.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbn_desactivado
            // 
            this.rbn_desactivado.AutoSize = true;
            this.rbn_desactivado.Location = new System.Drawing.Point(21, 48);
            this.rbn_desactivado.Name = "rbn_desactivado";
            this.rbn_desactivado.Size = new System.Drawing.Size(85, 17);
            this.rbn_desactivado.TabIndex = 17;
            this.rbn_desactivado.TabStop = true;
            this.rbn_desactivado.Text = "Desactivado";
            this.rbn_desactivado.UseVisualStyleBackColor = true;
            // 
            // btn_aplicar
            // 
            this.btn_aplicar.Location = new System.Drawing.Point(406, 136);
            this.btn_aplicar.Name = "btn_aplicar";
            this.btn_aplicar.Size = new System.Drawing.Size(95, 65);
            this.btn_aplicar.TabIndex = 18;
            this.btn_aplicar.Text = "Aplicar";
            this.btn_aplicar.UseVisualStyleBackColor = true;
            this.btn_aplicar.Click += new System.EventHandler(this.btn_aplicar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Precio";
            // 
            // txt_modprecio
            // 
            this.txt_modprecio.Location = new System.Drawing.Point(272, 96);
            this.txt_modprecio.Name = "txt_modprecio";
            this.txt_modprecio.Size = new System.Drawing.Size(169, 20);
            this.txt_modprecio.TabIndex = 14;
            this.txt_modprecio.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_modmarca
            // 
            this.txt_modmarca.Location = new System.Drawing.Point(23, 159);
            this.txt_modmarca.Name = "txt_modmarca";
            this.txt_modmarca.Size = new System.Drawing.Size(169, 20);
            this.txt_modmarca.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Insumo";
            // 
            // txt_modinsumo
            // 
            this.txt_modinsumo.Location = new System.Drawing.Point(23, 96);
            this.txt_modinsumo.Name = "txt_modinsumo";
            this.txt_modinsumo.Size = new System.Drawing.Size(169, 20);
            this.txt_modinsumo.TabIndex = 10;
            // 
            // cmb_modprod
            // 
            this.cmb_modprod.FormattingEnabled = true;
            this.cmb_modprod.Location = new System.Drawing.Point(122, 42);
            this.cmb_modprod.Name = "cmb_modprod";
            this.cmb_modprod.Size = new System.Drawing.Size(270, 21);
            this.cmb_modprod.TabIndex = 9;
            this.cmb_modprod.SelectedIndexChanged += new System.EventHandler(this.cmb_modprod_IndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccione el ID del producto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cantmenos);
            this.groupBox1.Controls.Add(this.btn_cantmas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_idprod_compraventa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_modificarstock);
            this.groupBox1.Controls.Add(this.txt_cantstock);
            this.groupBox1.Location = new System.Drawing.Point(16, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 212);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compra | Venta";
            // 
            // btn_cantmenos
            // 
            this.btn_cantmenos.Location = new System.Drawing.Point(28, 87);
            this.btn_cantmenos.Name = "btn_cantmenos";
            this.btn_cantmenos.Size = new System.Drawing.Size(38, 36);
            this.btn_cantmenos.TabIndex = 9;
            this.btn_cantmenos.Text = "-";
            this.btn_cantmenos.UseVisualStyleBackColor = true;
            this.btn_cantmenos.Click += new System.EventHandler(this.btn_cantmenos_Click);
            // 
            // btn_cantmas
            // 
            this.btn_cantmas.Location = new System.Drawing.Point(199, 87);
            this.btn_cantmas.Name = "btn_cantmas";
            this.btn_cantmas.Size = new System.Drawing.Size(38, 36);
            this.btn_cantmas.TabIndex = 8;
            this.btn_cantmas.Text = "+";
            this.btn_cantmas.UseVisualStyleBackColor = true;
            this.btn_cantmas.Click += new System.EventHandler(this.btn_cantmas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccione el ID del producto:";
            // 
            // cmb_idprod_compraventa
            // 
            this.cmb_idprod_compraventa.FormattingEnabled = true;
            this.cmb_idprod_compraventa.Location = new System.Drawing.Point(6, 42);
            this.cmb_idprod_compraventa.Name = "cmb_idprod_compraventa";
            this.cmb_idprod_compraventa.Size = new System.Drawing.Size(262, 21);
            this.cmb_idprod_compraventa.TabIndex = 6;
            this.cmb_idprod_compraventa.SelectedIndexChanged += new System.EventHandler(this.cmd_idprod_compraventa_IndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad:";
            // 
            // btn_modificarstock
            // 
            this.btn_modificarstock.Location = new System.Drawing.Point(63, 141);
            this.btn_modificarstock.Name = "btn_modificarstock";
            this.btn_modificarstock.Size = new System.Drawing.Size(138, 38);
            this.btn_modificarstock.TabIndex = 5;
            this.btn_modificarstock.Text = "Aplicar";
            this.btn_modificarstock.UseVisualStyleBackColor = true;
            this.btn_modificarstock.Click += new System.EventHandler(this.btn_modificarstock_Click);
            // 
            // txt_cantstock
            // 
            this.txt_cantstock.Location = new System.Drawing.Point(72, 96);
            this.txt_cantstock.Name = "txt_cantstock";
            this.txt_cantstock.Size = new System.Drawing.Size(121, 20);
            this.txt_cantstock.TabIndex = 1;
            this.txt_cantstock.TextChanged += new System.EventHandler(this.txt_cantstock_TextChanged);
            this.txt_cantstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantstock_KeyPress);
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AllowUserToResizeColumns = false;
            this.dgv_productos.AllowUserToResizeRows = false;
            this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_productos.ColumnHeadersHeight = 20;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Producto,
            this.Insumo,
            this.Marca,
            this.Precio,
            this.Stock,
            this.Estado});
            this.dgv_productos.Location = new System.Drawing.Point(16, 19);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.ReadOnly = true;
            this.dgv_productos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_productos.RowHeadersVisible = false;
            this.dgv_productos.Size = new System.Drawing.Size(826, 246);
            this.dgv_productos.TabIndex = 0;
            // 
            // ID_Producto
            // 
            this.ID_Producto.HeaderText = "ID Producto";
            this.ID_Producto.Name = "ID_Producto";
            this.ID_Producto.ReadOnly = true;
            // 
            // Insumo
            // 
            this.Insumo.HeaderText = "Insumo";
            this.Insumo.Name = "Insumo";
            this.Insumo.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tab_stock);
            this.tab1.Controls.Add(this.tab_altabaja);
            this.tab1.Controls.Add(this.tab_historial);
            this.tab1.Location = new System.Drawing.Point(12, 12);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(856, 538);
            this.tab1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 562);
            this.Controls.Add(this.tab1);
            this.Name = "Form1";
            this.Text = "ABM Kiosco";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_historial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Historial)).EndInit();
            this.tab_altabaja.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos2)).EndInit();
            this.tab_stock.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.tab1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tab_historial;
        private System.Windows.Forms.TabPage tab_altabaja;
        private System.Windows.Forms.TabPage tab_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cantstock;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_modificarstock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_idprod_compraventa;
        private System.Windows.Forms.Button btn_cantmenos;
        private System.Windows.Forms.Button btn_cantmas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_modprod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbn_desactivado;
        private System.Windows.Forms.RadioButton rbn_activado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_modprecio;
        private System.Windows.Forms.TextBox txt_modmarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_modinsumo;
        private System.Windows.Forms.Button btn_aplicar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_agregarmarca;
        private System.Windows.Forms.TextBox txt_agregarinsumo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_agregarid;
        private System.Windows.Forms.DataGridView dgv_productos2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_agregarprecio;
        private System.Windows.Forms.Button btn_agregarprod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_agregarstock;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_eliminarproducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_eliminarproducto;
        private System.Windows.Forms.DataGridView dgv_Historial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Historial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Producto2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_row_dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_historial_Hora;

    }
}

