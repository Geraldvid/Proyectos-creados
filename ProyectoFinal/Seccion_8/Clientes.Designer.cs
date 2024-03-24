namespace Seccion_8
{
    partial class Clientes
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
            this.DgCliente = new Bunifu.Framework.UI.BunifuCustomDataGrid();
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
            this.Txtdomifiscal = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtCorreo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Txtcodigopos = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.Gbproveedores = new System.Windows.Forms.GroupBox();
            this.Txttelef2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Txttelef1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Gbgeneral = new System.Windows.Forms.GroupBox();
            this.Txtdomifisico = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Txtnombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Txtcedu = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgCliente)).BeginInit();
            this.Gbbusqueda.SuspendLayout();
            this.Gbacciones.SuspendLayout();
            this.Gbprecios.SuspendLayout();
            this.Gbproveedores.SuspendLayout();
            this.Gbgeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgCliente
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgCliente.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DgCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCliente.DoubleBuffered = true;
            this.DgCliente.EnableHeadersVisualStyles = false;
            this.DgCliente.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DgCliente.HeaderForeColor = System.Drawing.Color.Black;
            this.DgCliente.Location = new System.Drawing.Point(20, 404);
            this.DgCliente.Name = "DgCliente";
            this.DgCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgCliente.Size = new System.Drawing.Size(746, 204);
            this.DgCliente.TabIndex = 26;
            this.DgCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCliente_CellClick);
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
            this.Gbbusqueda.Location = new System.Drawing.Point(457, 216);
            this.Gbbusqueda.Name = "Gbbusqueda";
            this.Gbbusqueda.Size = new System.Drawing.Size(309, 182);
            this.Gbbusqueda.TabIndex = 20;
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
            this.Btnbuscartodo.TabIndex = 14;
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
            this.Btnbuscarid.TabIndex = 13;
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
            this.Txtidbusqueda.TabIndex = 12;
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
            this.Gbacciones.Location = new System.Drawing.Point(457, 44);
            this.Gbacciones.Name = "Gbacciones";
            this.Gbacciones.Size = new System.Drawing.Size(309, 164);
            this.Gbacciones.TabIndex = 21;
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
            this.Btnlimpiar.TabIndex = 11;
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
            this.BtnEleminar.TabIndex = 10;
            this.BtnEleminar.UseVisualStyleBackColor = true;
            this.BtnEleminar.Click += new System.EventHandler(this.BtnEleminar_Click);
            // 
            // Btneditar
            // 
            this.Btneditar.BackgroundImage = global::Seccion_8.Properties.Resources._269074;
            this.Btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btneditar.Location = new System.Drawing.Point(92, 57);
            this.Btneditar.Name = "Btneditar";
            this.Btneditar.Size = new System.Drawing.Size(54, 59);
            this.Btneditar.TabIndex = 9;
            this.Btneditar.UseVisualStyleBackColor = true;
            this.Btneditar.Click += new System.EventHandler(this.Btneditar_Click);
            // 
            // Btnguardar
            // 
            this.Btnguardar.BackgroundImage = global::Seccion_8.Properties.Resources.guardar;
            this.Btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnguardar.Location = new System.Drawing.Point(9, 57);
            this.Btnguardar.Name = "Btnguardar";
            this.Btnguardar.Size = new System.Drawing.Size(54, 59);
            this.Btnguardar.TabIndex = 8;
            this.Btnguardar.UseVisualStyleBackColor = true;
            this.Btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // Gbprecios
            // 
            this.Gbprecios.Controls.Add(this.label8);
            this.Gbprecios.Controls.Add(this.label9);
            this.Gbprecios.Controls.Add(this.Txtdomifiscal);
            this.Gbprecios.Controls.Add(this.TxtCorreo);
            this.Gbprecios.Controls.Add(this.Txtcodigopos);
            this.Gbprecios.Controls.Add(this.label10);
            this.Gbprecios.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Gbprecios.Location = new System.Drawing.Point(20, 270);
            this.Gbprecios.Name = "Gbprecios";
            this.Gbprecios.Size = new System.Drawing.Size(431, 128);
            this.Gbprecios.TabIndex = 5;
            this.Gbprecios.TabStop = false;
            this.Gbprecios.Text = "Datos Fiscales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(11, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Domicilio Fiscal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.Location = new System.Drawing.Point(11, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Correo Elect.";
            // 
            // Txtdomifiscal
            // 
            this.Txtdomifiscal.BorderColorFocused = System.Drawing.Color.Cyan;
            this.Txtdomifiscal.BorderColorIdle = System.Drawing.Color.Black;
            this.Txtdomifiscal.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.Txtdomifiscal.BorderThickness = 3;
            this.Txtdomifiscal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtdomifiscal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Txtdomifiscal.ForeColor = System.Drawing.Color.Black;
            this.Txtdomifiscal.isPassword = false;
            this.Txtdomifiscal.Location = new System.Drawing.Point(178, 84);
            this.Txtdomifiscal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txtdomifiscal.Name = "Txtdomifiscal";
            this.Txtdomifiscal.Size = new System.Drawing.Size(245, 29);
            this.Txtdomifiscal.TabIndex = 7;
            this.Txtdomifiscal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.BorderColorFocused = System.Drawing.Color.Cyan;
            this.TxtCorreo.BorderColorIdle = System.Drawing.Color.Black;
            this.TxtCorreo.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.TxtCorreo.BorderThickness = 3;
            this.TxtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCorreo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtCorreo.ForeColor = System.Drawing.Color.Black;
            this.TxtCorreo.isPassword = false;
            this.TxtCorreo.Location = new System.Drawing.Point(178, 52);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(245, 29);
            this.TxtCorreo.TabIndex = 6;
            this.TxtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txtcodigopos
            // 
            this.Txtcodigopos.BorderColorFocused = System.Drawing.Color.Cyan;
            this.Txtcodigopos.BorderColorIdle = System.Drawing.Color.Black;
            this.Txtcodigopos.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.Txtcodigopos.BorderThickness = 3;
            this.Txtcodigopos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtcodigopos.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Txtcodigopos.ForeColor = System.Drawing.Color.Black;
            this.Txtcodigopos.isPassword = false;
            this.Txtcodigopos.Location = new System.Drawing.Point(178, 20);
            this.Txtcodigopos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txtcodigopos.Name = "Txtcodigopos";
            this.Txtcodigopos.Size = new System.Drawing.Size(245, 29);
            this.Txtcodigopos.TabIndex = 5;
            this.Txtcodigopos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.Location = new System.Drawing.Point(11, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cod. Postal";
            // 
            // Gbproveedores
            // 
            this.Gbproveedores.Controls.Add(this.Txttelef2);
            this.Gbproveedores.Controls.Add(this.Txttelef1);
            this.Gbproveedores.Controls.Add(this.label4);
            this.Gbproveedores.Controls.Add(this.label5);
            this.Gbproveedores.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Gbproveedores.Location = new System.Drawing.Point(20, 158);
            this.Gbproveedores.Name = "Gbproveedores";
            this.Gbproveedores.Size = new System.Drawing.Size(431, 106);
            this.Gbproveedores.TabIndex = 3;
            this.Gbproveedores.TabStop = false;
            this.Gbproveedores.Text = "Contactos";
            // 
            // Txttelef2
            // 
            this.Txttelef2.BorderColorFocused = System.Drawing.Color.Cyan;
            this.Txttelef2.BorderColorIdle = System.Drawing.Color.Black;
            this.Txttelef2.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.Txttelef2.BorderThickness = 3;
            this.Txttelef2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txttelef2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Txttelef2.ForeColor = System.Drawing.Color.Black;
            this.Txttelef2.isPassword = false;
            this.Txttelef2.Location = new System.Drawing.Point(141, 58);
            this.Txttelef2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txttelef2.Name = "Txttelef2";
            this.Txttelef2.Size = new System.Drawing.Size(282, 29);
            this.Txttelef2.TabIndex = 4;
            this.Txttelef2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txttelef1
            // 
            this.Txttelef1.BorderColorFocused = System.Drawing.Color.Cyan;
            this.Txttelef1.BorderColorIdle = System.Drawing.Color.Black;
            this.Txttelef1.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.Txttelef1.BorderThickness = 3;
            this.Txttelef1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txttelef1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Txttelef1.ForeColor = System.Drawing.Color.Black;
            this.Txttelef1.isPassword = false;
            this.Txttelef1.Location = new System.Drawing.Point(141, 21);
            this.Txttelef1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txttelef1.Name = "Txttelef1";
            this.Txttelef1.Size = new System.Drawing.Size(282, 29);
            this.Txttelef1.TabIndex = 3;
            this.Txttelef1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(15, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Teléfono 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(15, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Teléfono 1 ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(414, 31);
            this.label6.TabIndex = 24;
            this.label6.Text = "Mantenimiento de Clientes";
            // 
            // Gbgeneral
            // 
            this.Gbgeneral.Controls.Add(this.Txtdomifisico);
            this.Gbgeneral.Controls.Add(this.Txtnombre);
            this.Gbgeneral.Controls.Add(this.Txtcedu);
            this.Gbgeneral.Controls.Add(this.label3);
            this.Gbgeneral.Controls.Add(this.label2);
            this.Gbgeneral.Controls.Add(this.label1);
            this.Gbgeneral.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Gbgeneral.Location = new System.Drawing.Point(20, 44);
            this.Gbgeneral.Name = "Gbgeneral";
            this.Gbgeneral.Size = new System.Drawing.Size(431, 108);
            this.Gbgeneral.TabIndex = 0;
            this.Gbgeneral.TabStop = false;
            this.Gbgeneral.Text = "Datos General";
            // 
            // Txtdomifisico
            // 
            this.Txtdomifisico.BorderColorFocused = System.Drawing.Color.Cyan;
            this.Txtdomifisico.BorderColorIdle = System.Drawing.Color.Black;
            this.Txtdomifisico.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.Txtdomifisico.BorderThickness = 3;
            this.Txtdomifisico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtdomifisico.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Txtdomifisico.ForeColor = System.Drawing.Color.Black;
            this.Txtdomifisico.isPassword = false;
            this.Txtdomifisico.Location = new System.Drawing.Point(193, 73);
            this.Txtdomifisico.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txtdomifisico.Name = "Txtdomifisico";
            this.Txtdomifisico.Size = new System.Drawing.Size(236, 29);
            this.Txtdomifisico.TabIndex = 2;
            this.Txtdomifisico.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txtnombre
            // 
            this.Txtnombre.BorderColorFocused = System.Drawing.Color.Cyan;
            this.Txtnombre.BorderColorIdle = System.Drawing.Color.Black;
            this.Txtnombre.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.Txtnombre.BorderThickness = 3;
            this.Txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtnombre.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Txtnombre.ForeColor = System.Drawing.Color.Black;
            this.Txtnombre.isPassword = false;
            this.Txtnombre.Location = new System.Drawing.Point(193, 43);
            this.Txtnombre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(236, 29);
            this.Txtnombre.TabIndex = 1;
            this.Txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txtcedu
            // 
            this.Txtcedu.BorderColorFocused = System.Drawing.Color.Cyan;
            this.Txtcedu.BorderColorIdle = System.Drawing.Color.Black;
            this.Txtcedu.BorderColorMouseHover = System.Drawing.Color.Yellow;
            this.Txtcedu.BorderThickness = 3;
            this.Txtcedu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtcedu.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Txtcedu.ForeColor = System.Drawing.Color.Black;
            this.Txtcedu.isPassword = false;
            this.Txtcedu.Location = new System.Drawing.Point(193, 15);
            this.Txtcedu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txtcedu.Name = "Txtcedu";
            this.Txtcedu.Size = new System.Drawing.Size(236, 29);
            this.Txtcedu.TabIndex = 0;
            this.Txtcedu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Domiciliio Fisico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre(Jurídico)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula(Jurídica)";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(73)))), ((int)(((byte)(181)))));
            this.Controls.Add(this.DgCliente);
            this.Controls.Add(this.Gbbusqueda);
            this.Controls.Add(this.Gbacciones);
            this.Controls.Add(this.Gbprecios);
            this.Controls.Add(this.Gbproveedores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Gbgeneral);
            this.Name = "Clientes";
            this.Size = new System.Drawing.Size(786, 619);
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgCliente)).EndInit();
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

        private Bunifu.Framework.UI.BunifuCustomDataGrid DgCliente;
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
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtdomifiscal;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtcodigopos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox Gbproveedores;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txttelef2;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txttelef1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Gbgeneral;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtdomifisico;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtnombre;
        private Bunifu.Framework.UI.BunifuMetroTextbox Txtcedu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtCorreo;
    }
}
