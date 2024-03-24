namespace Seccion_8
{
    partial class Productos
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.DgProductos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Gbbusqueda = new System.Windows.Forms.GroupBox();
            this.Btnbuscartodo = new System.Windows.Forms.Button();
            this.Btnbuscarid = new System.Windows.Forms.Button();
            this.Txtidbusqueda = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Gbacciones = new System.Windows.Forms.GroupBox();
            this.Btnlimpiar = new System.Windows.Forms.Button();
            this.BtnEleminar = new System.Windows.Forms.Button();
            this.Btneditar = new System.Windows.Forms.Button();
            this.Btnguardar = new System.Windows.Forms.Button();
            this.Gbprecios = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Txtprecioconiva = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Txtpreciosiniva = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.Btncalcular = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Cbiva = new System.Windows.Forms.ComboBox();
            this.Gbproveedores = new System.Windows.Forms.GroupBox();
            this.Txtprovee2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Txtprovee1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Gbgeneral = new System.Windows.Forms.GroupBox();
            this.Txtcantidad = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Txtdescripcion = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Txtid = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgProductos)).BeginInit();
            this.Gbbusqueda.SuspendLayout();
            this.Gbacciones.SuspendLayout();
            this.Gbprecios.SuspendLayout();
            this.Gbproveedores.SuspendLayout();
            this.Gbgeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgProductos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgProductos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DgProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProductos.DoubleBuffered = true;
            this.DgProductos.EnableHeadersVisualStyles = false;
            this.DgProductos.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DgProductos.HeaderForeColor = System.Drawing.Color.Black;
            this.DgProductos.Location = new System.Drawing.Point(19, 407);
            this.DgProductos.Name = "DgProductos";
            this.DgProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgProductos.Size = new System.Drawing.Size(746, 204);
            this.DgProductos.TabIndex = 19;
            this.DgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgProductos_CellClick);
            // 
            // Gbbusqueda
            // 
            this.Gbbusqueda.Controls.Add(this.Btnbuscartodo);
            this.Gbbusqueda.Controls.Add(this.Btnbuscarid);
            this.Gbbusqueda.Controls.Add(this.Txtidbusqueda);
            this.Gbbusqueda.Controls.Add(this.label12);
            this.Gbbusqueda.Controls.Add(this.label11);
            this.Gbbusqueda.Controls.Add(this.label7);
            this.Gbbusqueda.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Gbbusqueda.Location = new System.Drawing.Point(456, 219);
            this.Gbbusqueda.Name = "Gbbusqueda";
            this.Gbbusqueda.Size = new System.Drawing.Size(309, 182);
            this.Gbbusqueda.TabIndex = 13;
            this.Gbbusqueda.TabStop = false;
            this.Gbbusqueda.Text = "Busqueda";
            // 
            // Btnbuscartodo
            // 
            this.Btnbuscartodo.BackgroundImage = global::Seccion_8.Properties.Resources.Buscar;
            this.Btnbuscartodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnbuscartodo.Location = new System.Drawing.Point(231, 85);
            this.Btnbuscartodo.Name = "Btnbuscartodo";
            this.Btnbuscartodo.Size = new System.Drawing.Size(70, 69);
            this.Btnbuscartodo.TabIndex = 15;
            this.Btnbuscartodo.UseVisualStyleBackColor = true;
            this.Btnbuscartodo.Click += new System.EventHandler(this.Btnbuscartodo_Click);
            // 
            // Btnbuscarid
            // 
            this.Btnbuscarid.BackgroundImage = global::Seccion_8.Properties.Resources.busqueda__detallada;
            this.Btnbuscarid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnbuscarid.Location = new System.Drawing.Point(76, 85);
            this.Btnbuscarid.Name = "Btnbuscarid";
            this.Btnbuscarid.Size = new System.Drawing.Size(70, 71);
            this.Btnbuscarid.TabIndex = 14;
            this.Btnbuscarid.UseVisualStyleBackColor = true;
            this.Btnbuscarid.Click += new System.EventHandler(this.Btnbuscarid_Click);
            // 
            // Txtidbusqueda
            // 
            this.Txtidbusqueda.BorderColorFocused = System.Drawing.Color.Cyan;
            this.Txtidbusqueda.BorderColorIdle = System.Drawing.Color.Black;
            this.Txtidbusqueda.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.Txtidbusqueda.BorderThickness = 3;
            this.Txtidbusqueda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtidbusqueda.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Txtidbusqueda.ForeColor = System.Drawing.Color.Black;
            this.Txtidbusqueda.isPassword = false;
            this.Txtidbusqueda.Location = new System.Drawing.Point(44, 35);
            this.Txtidbusqueda.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txtidbusqueda.Name = "Txtidbusqueda";
            this.Txtidbusqueda.Size = new System.Drawing.Size(257, 29);
            this.Txtidbusqueda.TabIndex = 13;
            this.Txtidbusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label12.Location = new System.Drawing.Point(6, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 36);
            this.label12.TabIndex = 2;
            this.label12.Text = "Buscar\r\npor id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label11.Location = new System.Drawing.Point(157, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 36);
            this.label11.TabIndex = 2;
            this.label11.Text = "Buscar\r\n todo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(8, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Id";
            // 
            // Gbacciones
            // 
            this.Gbacciones.Controls.Add(this.Btnlimpiar);
            this.Gbacciones.Controls.Add(this.BtnEleminar);
            this.Gbacciones.Controls.Add(this.Btneditar);
            this.Gbacciones.Controls.Add(this.Btnguardar);
            this.Gbacciones.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Gbacciones.Location = new System.Drawing.Point(456, 47);
            this.Gbacciones.Name = "Gbacciones";
            this.Gbacciones.Size = new System.Drawing.Size(309, 164);
            this.Gbacciones.TabIndex = 14;
            this.Gbacciones.TabStop = false;
            this.Gbacciones.Text = "Acciones";
            // 
            // Btnlimpiar
            // 
            this.Btnlimpiar.BackgroundImage = global::Seccion_8.Properties.Resources._419660;
            this.Btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnlimpiar.Location = new System.Drawing.Point(247, 57);
            this.Btnlimpiar.Name = "Btnlimpiar";
            this.Btnlimpiar.Size = new System.Drawing.Size(54, 59);
            this.Btnlimpiar.TabIndex = 12;
            this.Btnlimpiar.UseVisualStyleBackColor = true;
            this.Btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click);
            // 
            // BtnEleminar
            // 
            this.BtnEleminar.BackgroundImage = global::Seccion_8.Properties.Resources._6301508;
            this.BtnEleminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEleminar.Location = new System.Drawing.Point(171, 57);
            this.BtnEleminar.Name = "BtnEleminar";
            this.BtnEleminar.Size = new System.Drawing.Size(54, 59);
            this.BtnEleminar.TabIndex = 11;
            this.BtnEleminar.UseVisualStyleBackColor = true;
            this.BtnEleminar.Click += new System.EventHandler(this.BtnEleminar_Click_1);
            // 
            // Btneditar
            // 
            this.Btneditar.BackgroundImage = global::Seccion_8.Properties.Resources._269074;
            this.Btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btneditar.Location = new System.Drawing.Point(92, 57);
            this.Btneditar.Name = "Btneditar";
            this.Btneditar.Size = new System.Drawing.Size(54, 59);
            this.Btneditar.TabIndex = 10;
            this.Btneditar.UseVisualStyleBackColor = true;
            this.Btneditar.Click += new System.EventHandler(this.Btneditar_Click_1);
            // 
            // Btnguardar
            // 
            this.Btnguardar.BackgroundImage = global::Seccion_8.Properties.Resources.guardar;
            this.Btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnguardar.Location = new System.Drawing.Point(9, 57);
            this.Btnguardar.Name = "Btnguardar";
            this.Btnguardar.Size = new System.Drawing.Size(54, 59);
            this.Btnguardar.TabIndex = 9;
            this.Btnguardar.UseVisualStyleBackColor = true;
            this.Btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // Gbprecios
            // 
            this.Gbprecios.Controls.Add(this.label8);
            this.Gbprecios.Controls.Add(this.label9);
            this.Gbprecios.Controls.Add(this.Txtprecioconiva);
            this.Gbprecios.Controls.Add(this.Txtpreciosiniva);
            this.Gbprecios.Controls.Add(this.label10);
            this.Gbprecios.Controls.Add(this.Btncalcular);
            this.Gbprecios.Controls.Add(this.Cbiva);
            this.Gbprecios.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Gbprecios.Location = new System.Drawing.Point(19, 273);
            this.Gbprecios.Name = "Gbprecios";
            this.Gbprecios.Size = new System.Drawing.Size(431, 128);
            this.Gbprecios.TabIndex = 15;
            this.Gbprecios.TabStop = false;
            this.Gbprecios.Text = "Precios";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(11, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Precio con Iva";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(11, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "IVA";
            // 
            // Txtprecioconiva
            // 
            this.Txtprecioconiva.BorderColorFocused = System.Drawing.Color.Cyan;
            this.Txtprecioconiva.BorderColorIdle = System.Drawing.Color.Black;
            this.Txtprecioconiva.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.Txtprecioconiva.BorderThickness = 3;
            this.Txtprecioconiva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtprecioconiva.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Txtprecioconiva.ForeColor = System.Drawing.Color.Black;
            this.Txtprecioconiva.isPassword = false;
            this.Txtprecioconiva.Location = new System.Drawing.Point(167, 84);
            this.Txtprecioconiva.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txtprecioconiva.Name = "Txtprecioconiva";
            this.Txtprecioconiva.Size = new System.Drawing.Size(256, 29);
            this.Txtprecioconiva.TabIndex = 8;
            this.Txtprecioconiva.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txtpreciosiniva
            // 
            this.Txtpreciosiniva.BorderColorFocused = System.Drawing.Color.Cyan;
            this.Txtpreciosiniva.BorderColorIdle = System.Drawing.Color.Black;
            this.Txtpreciosiniva.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.Txtpreciosiniva.BorderThickness = 3;
            this.Txtpreciosiniva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtpreciosiniva.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Txtpreciosiniva.ForeColor = System.Drawing.Color.Black;
            this.Txtpreciosiniva.isPassword = false;
            this.Txtpreciosiniva.Location = new System.Drawing.Point(167, 20);
            this.Txtpreciosiniva.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txtpreciosiniva.Name = "Txtpreciosiniva";
            this.Txtpreciosiniva.Size = new System.Drawing.Size(256, 29);
            this.Txtpreciosiniva.TabIndex = 5;
            this.Txtpreciosiniva.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.Location = new System.Drawing.Point(11, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Precio sin IVA";
            // 
            // Btncalcular
            // 
            this.Btncalcular.ActiveBorderThickness = 1;
            this.Btncalcular.ActiveCornerRadius = 20;
            this.Btncalcular.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btncalcular.ActiveForecolor = System.Drawing.Color.White;
            this.Btncalcular.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btncalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(73)))), ((int)(((byte)(181)))));
            this.Btncalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btncalcular.BackgroundImage")));
            this.Btncalcular.ButtonText = "Calcular";
            this.Btncalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btncalcular.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Btncalcular.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btncalcular.IdleBorderThickness = 1;
            this.Btncalcular.IdleCornerRadius = 20;
            this.Btncalcular.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.Btncalcular.IdleForecolor = System.Drawing.Color.Yellow;
            this.Btncalcular.IdleLineColor = System.Drawing.Color.DarkBlue;
            this.Btncalcular.Location = new System.Drawing.Point(317, 44);
            this.Btncalcular.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Btncalcular.Name = "Btncalcular";
            this.Btncalcular.Size = new System.Drawing.Size(104, 44);
            this.Btncalcular.TabIndex = 7;
            this.Btncalcular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btncalcular.Click += new System.EventHandler(this.Btncalcular_Click_1);
            // 
            // Cbiva
            // 
            this.Cbiva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(73)))), ((int)(((byte)(181)))));
            this.Cbiva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cbiva.FormattingEnabled = true;
            this.Cbiva.Items.AddRange(new object[] {
            "5",
            "10",
            "13"});
            this.Cbiva.Location = new System.Drawing.Point(55, 54);
            this.Cbiva.Name = "Cbiva";
            this.Cbiva.Size = new System.Drawing.Size(259, 26);
            this.Cbiva.TabIndex = 6;
            // 
            // Gbproveedores
            // 
            this.Gbproveedores.Controls.Add(this.Txtprovee2);
            this.Gbproveedores.Controls.Add(this.Txtprovee1);
            this.Gbproveedores.Controls.Add(this.label4);
            this.Gbproveedores.Controls.Add(this.label5);
            this.Gbproveedores.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Gbproveedores.Location = new System.Drawing.Point(19, 161);
            this.Gbproveedores.Name = "Gbproveedores";
            this.Gbproveedores.Size = new System.Drawing.Size(431, 106);
            this.Gbproveedores.TabIndex = 16;
            this.Gbproveedores.TabStop = false;
            this.Gbproveedores.Text = "Proveedores";
            // 
            // Txtprovee2
            // 
            this.Txtprovee2.BorderColorFocused = System.Drawing.Color.Cyan;
            this.Txtprovee2.BorderColorIdle = System.Drawing.Color.Black;
            this.Txtprovee2.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.Txtprovee2.BorderThickness = 3;
            this.Txtprovee2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtprovee2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Txtprovee2.ForeColor = System.Drawing.Color.Black;
            this.Txtprovee2.isPassword = false;
            this.Txtprovee2.Location = new System.Drawing.Point(141, 58);
            this.Txtprovee2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txtprovee2.Name = "Txtprovee2";
            this.Txtprovee2.Size = new System.Drawing.Size(282, 29);
            this.Txtprovee2.TabIndex = 4;
            this.Txtprovee2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txtprovee1
            // 
            this.Txtprovee1.BorderColorFocused = System.Drawing.Color.Cyan;
            this.Txtprovee1.BorderColorIdle = System.Drawing.Color.Black;
            this.Txtprovee1.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.Txtprovee1.BorderThickness = 3;
            this.Txtprovee1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtprovee1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Txtprovee1.ForeColor = System.Drawing.Color.Black;
            this.Txtprovee1.isPassword = false;
            this.Txtprovee1.Location = new System.Drawing.Point(141, 21);
            this.Txtprovee1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txtprovee1.Name = "Txtprovee1";
            this.Txtprovee1.Size = new System.Drawing.Size(282, 29);
            this.Txtprovee1.TabIndex = 3;
            this.Txtprovee1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(15, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Proveedor 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(15, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Proveedor 1 ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(166, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(430, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mantenimiento de Productos";
            // 
            // Gbgeneral
            // 
            this.Gbgeneral.Controls.Add(this.Txtcantidad);
            this.Gbgeneral.Controls.Add(this.Txtdescripcion);
            this.Gbgeneral.Controls.Add(this.Txtid);
            this.Gbgeneral.Controls.Add(this.label3);
            this.Gbgeneral.Controls.Add(this.label2);
            this.Gbgeneral.Controls.Add(this.label1);
            this.Gbgeneral.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Gbgeneral.Location = new System.Drawing.Point(19, 47);
            this.Gbgeneral.Name = "Gbgeneral";
            this.Gbgeneral.Size = new System.Drawing.Size(431, 108);
            this.Gbgeneral.TabIndex = 18;
            this.Gbgeneral.TabStop = false;
            this.Gbgeneral.Text = "General";
            // 
            // Txtcantidad
            // 
            this.Txtcantidad.BorderColorFocused = System.Drawing.Color.Cyan;
            this.Txtcantidad.BorderColorIdle = System.Drawing.Color.Black;
            this.Txtcantidad.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.Txtcantidad.BorderThickness = 3;
            this.Txtcantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtcantidad.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Txtcantidad.ForeColor = System.Drawing.Color.Black;
            this.Txtcantidad.isPassword = false;
            this.Txtcantidad.Location = new System.Drawing.Point(141, 73);
            this.Txtcantidad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txtcantidad.Name = "Txtcantidad";
            this.Txtcantidad.Size = new System.Drawing.Size(288, 29);
            this.Txtcantidad.TabIndex = 2;
            this.Txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txtdescripcion
            // 
            this.Txtdescripcion.BorderColorFocused = System.Drawing.Color.Cyan;
            this.Txtdescripcion.BorderColorIdle = System.Drawing.Color.Black;
            this.Txtdescripcion.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.Txtdescripcion.BorderThickness = 3;
            this.Txtdescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtdescripcion.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Txtdescripcion.ForeColor = System.Drawing.Color.Black;
            this.Txtdescripcion.isPassword = false;
            this.Txtdescripcion.Location = new System.Drawing.Point(141, 43);
            this.Txtdescripcion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txtdescripcion.Name = "Txtdescripcion";
            this.Txtdescripcion.Size = new System.Drawing.Size(288, 29);
            this.Txtdescripcion.TabIndex = 1;
            this.Txtdescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txtid
            // 
            this.Txtid.BorderColorFocused = System.Drawing.Color.Cyan;
            this.Txtid.BorderColorIdle = System.Drawing.Color.Black;
            this.Txtid.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.Txtid.BorderThickness = 3;
            this.Txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Txtid.ForeColor = System.Drawing.Color.Black;
            this.Txtid.isPassword = false;
            this.Txtid.Location = new System.Drawing.Point(141, 15);
            this.Txtid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(288, 29);
            this.Txtid.TabIndex = 0;
            this.Txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(73)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.DgProductos);
            this.Controls.Add(this.Gbbusqueda);
            this.Controls.Add(this.Gbacciones);
            this.Controls.Add(this.Gbprecios);
            this.Controls.Add(this.Gbproveedores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Gbgeneral);
            this.Name = "Productos";
            this.Size = new System.Drawing.Size(786, 619);
            ((System.ComponentModel.ISupportInitialize)(this.DgProductos)).EndInit();
            this.Gbbusqueda.ResumeLayout(false);
            this.Gbbusqueda.PerformLayout();
            this.Gbacciones.ResumeLayout(false);
            this.Gbprecios.ResumeLayout(false);
            this.Gbprecios.PerformLayout();
            this.Gbproveedores.ResumeLayout(false);
            this.Gbproveedores.PerformLayout();
            this.Gbgeneral.ResumeLayout(false);
            this.Gbgeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DgProductos;
        private System.Windows.Forms.GroupBox Gbbusqueda;
        private System.Windows.Forms.Button Btnbuscartodo;
        private System.Windows.Forms.Button Btnbuscarid;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtidbusqueda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox Gbacciones;
        private System.Windows.Forms.Button Btnlimpiar;
        private System.Windows.Forms.Button BtnEleminar;
        private System.Windows.Forms.Button Btneditar;
        private System.Windows.Forms.Button Btnguardar;
        private System.Windows.Forms.GroupBox Gbprecios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtprecioconiva;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtpreciosiniva;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuThinButton2 Btncalcular;
        private System.Windows.Forms.ComboBox Cbiva;
        private System.Windows.Forms.GroupBox Gbproveedores;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtprovee2;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtprovee1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Gbgeneral;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtcantidad;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtdescripcion;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
