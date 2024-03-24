namespace Seccion_8
{
    partial class Menu_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Panelmenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NombreVendedor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panelencabe = new System.Windows.Forms.Panel();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Btnsalir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btningreso = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btnfactura = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btnproducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btnveendedor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panelmenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Panelencabe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panelmenu
            // 
            this.Panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(39)))), ((int)(((byte)(96)))));
            this.Panelmenu.Controls.Add(this.panel3);
            this.Panelmenu.Controls.Add(this.Btningreso);
            this.Panelmenu.Controls.Add(this.Btnfactura);
            this.Panelmenu.Controls.Add(this.Btnproducto);
            this.Panelmenu.Controls.Add(this.Btnveendedor);
            this.Panelmenu.Controls.Add(this.panel1);
            this.Panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panelmenu.Location = new System.Drawing.Point(0, 0);
            this.Panelmenu.Name = "Panelmenu";
            this.Panelmenu.Size = new System.Drawing.Size(194, 695);
            this.Panelmenu.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.NombreVendedor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 550);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 145);
            this.panel3.TabIndex = 5;
            // 
            // NombreVendedor
            // 
            this.NombreVendedor.AutoSize = true;
            this.NombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreVendedor.ForeColor = System.Drawing.Color.White;
            this.NombreVendedor.Location = new System.Drawing.Point(45, 102);
            this.NombreVendedor.Name = "NombreVendedor";
            this.NombreVendedor.Size = new System.Drawing.Size(79, 20);
            this.NombreVendedor.TabIndex = 0;
            this.NombreVendedor.Text = "Vendedor";
            this.NombreVendedor.Click += new System.EventHandler(this.NombreVendedor_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 129);
            this.panel1.TabIndex = 2;
            // 
            // Panelencabe
            // 
            this.Panelencabe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(39)))), ((int)(((byte)(96)))));
            this.Panelencabe.Controls.Add(this.bunifuDatepicker1);
            this.Panelencabe.Controls.Add(this.Btnsalir);
            this.Panelencabe.Controls.Add(this.label1);
            this.Panelencabe.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panelencabe.Location = new System.Drawing.Point(194, 0);
            this.Panelencabe.Name = "Panelencabe";
            this.Panelencabe.Size = new System.Drawing.Size(786, 75);
            this.Panelencabe.TabIndex = 1;
            this.Panelencabe.Paint += new System.Windows.Forms.PaintEventHandler(this.Panelencabe_Paint);
            this.Panelencabe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panelencabe_MouseMove);
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 5;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(1526, 48);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(708, 102);
            this.bunifuDatepicker1.TabIndex = 14;
            this.bunifuDatepicker1.Value = new System.DateTime(2023, 3, 22, 21, 28, 56, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Punto Venta Prism";
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(73)))), ((int)(((byte)(181)))));
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(194, 75);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(786, 620);
            this.Contenedor.TabIndex = 60;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Btnsalir
            // 
            this.Btnsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnsalir.BackgroundImage = global::Seccion_8.Properties.Resources.x;
            this.Btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnsalir.FlatAppearance.BorderSize = 0;
            this.Btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnsalir.Location = new System.Drawing.Point(720, 17);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(45, 42);
            this.Btnsalir.TabIndex = 13;
            this.Btnsalir.UseVisualStyleBackColor = true;
            this.Btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Seccion_8.Properties.Resources.pngtree_vector_users_icon_png_image_856952;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(49, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 87);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Btningreso
            // 
            this.Btningreso.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.Btningreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btningreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.Btningreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btningreso.BorderRadius = 0;
            this.Btningreso.ButtonText = "Ingreso de Vendedores";
            this.Btningreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btningreso.DisabledColor = System.Drawing.Color.Gray;
            this.Btningreso.Iconcolor = System.Drawing.Color.Transparent;
            this.Btningreso.Iconimage = global::Seccion_8.Properties.Resources.proveedores_m;
            this.Btningreso.Iconimage_right = null;
            this.Btningreso.Iconimage_right_Selected = null;
            this.Btningreso.Iconimage_Selected = null;
            this.Btningreso.IconMarginLeft = 0;
            this.Btningreso.IconMarginRight = 0;
            this.Btningreso.IconRightVisible = true;
            this.Btningreso.IconRightZoom = 0D;
            this.Btningreso.IconVisible = true;
            this.Btningreso.IconZoom = 90D;
            this.Btningreso.IsTab = false;
            this.Btningreso.Location = new System.Drawing.Point(0, 273);
            this.Btningreso.Name = "Btningreso";
            this.Btningreso.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.Btningreso.OnHovercolor = System.Drawing.Color.DarkCyan;
            this.Btningreso.OnHoverTextColor = System.Drawing.Color.Black;
            this.Btningreso.selected = false;
            this.Btningreso.Size = new System.Drawing.Size(194, 50);
            this.Btningreso.TabIndex = 3;
            this.Btningreso.Text = "Ingreso de Vendedores";
            this.Btningreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btningreso.Textcolor = System.Drawing.Color.Black;
            this.Btningreso.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btningreso.Click += new System.EventHandler(this.Btningreso_Click);
            // 
            // Btnfactura
            // 
            this.Btnfactura.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.Btnfactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnfactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.Btnfactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnfactura.BorderRadius = 0;
            this.Btnfactura.ButtonText = "Facturación";
            this.Btnfactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnfactura.DisabledColor = System.Drawing.Color.Gray;
            this.Btnfactura.Iconcolor = System.Drawing.Color.Transparent;
            this.Btnfactura.Iconimage = global::Seccion_8.Properties.Resources._2557649;
            this.Btnfactura.Iconimage_right = null;
            this.Btnfactura.Iconimage_right_Selected = null;
            this.Btnfactura.Iconimage_Selected = null;
            this.Btnfactura.IconMarginLeft = 0;
            this.Btnfactura.IconMarginRight = 0;
            this.Btnfactura.IconRightVisible = true;
            this.Btnfactura.IconRightZoom = 0D;
            this.Btnfactura.IconVisible = true;
            this.Btnfactura.IconZoom = 90D;
            this.Btnfactura.IsTab = false;
            this.Btnfactura.Location = new System.Drawing.Point(0, 329);
            this.Btnfactura.Name = "Btnfactura";
            this.Btnfactura.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.Btnfactura.OnHovercolor = System.Drawing.Color.DarkCyan;
            this.Btnfactura.OnHoverTextColor = System.Drawing.Color.Black;
            this.Btnfactura.selected = false;
            this.Btnfactura.Size = new System.Drawing.Size(194, 50);
            this.Btnfactura.TabIndex = 2;
            this.Btnfactura.Text = "Facturación";
            this.Btnfactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnfactura.Textcolor = System.Drawing.Color.Black;
            this.Btnfactura.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnfactura.Click += new System.EventHandler(this.Btnfactura_Click);
            // 
            // Btnproducto
            // 
            this.Btnproducto.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.Btnproducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.Btnproducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnproducto.BorderRadius = 0;
            this.Btnproducto.ButtonText = "Mantenimiento de productos";
            this.Btnproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnproducto.DisabledColor = System.Drawing.Color.Gray;
            this.Btnproducto.Iconcolor = System.Drawing.Color.Transparent;
            this.Btnproducto.Iconimage = global::Seccion_8.Properties.Resources.productos_b;
            this.Btnproducto.Iconimage_right = null;
            this.Btnproducto.Iconimage_right_Selected = null;
            this.Btnproducto.Iconimage_Selected = null;
            this.Btnproducto.IconMarginLeft = 0;
            this.Btnproducto.IconMarginRight = 0;
            this.Btnproducto.IconRightVisible = true;
            this.Btnproducto.IconRightZoom = 0D;
            this.Btnproducto.IconVisible = true;
            this.Btnproducto.IconZoom = 90D;
            this.Btnproducto.IsTab = false;
            this.Btnproducto.Location = new System.Drawing.Point(0, 217);
            this.Btnproducto.Name = "Btnproducto";
            this.Btnproducto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.Btnproducto.OnHovercolor = System.Drawing.Color.DarkCyan;
            this.Btnproducto.OnHoverTextColor = System.Drawing.Color.Black;
            this.Btnproducto.selected = false;
            this.Btnproducto.Size = new System.Drawing.Size(194, 50);
            this.Btnproducto.TabIndex = 1;
            this.Btnproducto.Text = "Mantenimiento de productos";
            this.Btnproducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnproducto.Textcolor = System.Drawing.Color.Black;
            this.Btnproducto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnproducto.Click += new System.EventHandler(this.Btnproducto_Click);
            // 
            // Btnveendedor
            // 
            this.Btnveendedor.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.Btnveendedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnveendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.Btnveendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnveendedor.BorderRadius = 0;
            this.Btnveendedor.ButtonText = "Mantenimiento de Cliente";
            this.Btnveendedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnveendedor.DisabledColor = System.Drawing.Color.Gray;
            this.Btnveendedor.Iconcolor = System.Drawing.Color.Transparent;
            this.Btnveendedor.Iconimage = global::Seccion_8.Properties.Resources.User2;
            this.Btnveendedor.Iconimage_right = null;
            this.Btnveendedor.Iconimage_right_Selected = null;
            this.Btnveendedor.Iconimage_Selected = null;
            this.Btnveendedor.IconMarginLeft = 0;
            this.Btnveendedor.IconMarginRight = 0;
            this.Btnveendedor.IconRightVisible = true;
            this.Btnveendedor.IconRightZoom = 0D;
            this.Btnveendedor.IconVisible = true;
            this.Btnveendedor.IconZoom = 90D;
            this.Btnveendedor.IsTab = false;
            this.Btnveendedor.Location = new System.Drawing.Point(0, 161);
            this.Btnveendedor.Name = "Btnveendedor";
            this.Btnveendedor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(126)))), ((int)(((byte)(187)))));
            this.Btnveendedor.OnHovercolor = System.Drawing.Color.DarkCyan;
            this.Btnveendedor.OnHoverTextColor = System.Drawing.Color.Black;
            this.Btnveendedor.selected = false;
            this.Btnveendedor.Size = new System.Drawing.Size(194, 50);
            this.Btnveendedor.TabIndex = 0;
            this.Btnveendedor.Text = "Mantenimiento de Cliente";
            this.Btnveendedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnveendedor.Textcolor = System.Drawing.Color.Black;
            this.Btnveendedor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnveendedor.Click += new System.EventHandler(this.Btnveendedor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Seccion_8.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 129);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 695);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.Panelencabe);
            this.Controls.Add(this.Panelmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Principal";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.Panelmenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Panelencabe.ResumeLayout(false);
            this.Panelencabe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panelmenu;
        private System.Windows.Forms.Panel Panelencabe;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Button Btnsalir;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton Btningreso;
        private Bunifu.Framework.UI.BunifuFlatButton Btnfactura;
        private Bunifu.Framework.UI.BunifuFlatButton Btnproducto;
        private Bunifu.Framework.UI.BunifuFlatButton Btnveendedor;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label NombreVendedor;
    }
}