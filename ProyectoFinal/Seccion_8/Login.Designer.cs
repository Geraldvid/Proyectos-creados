namespace Seccion_8
{
    partial class Login
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.Txtcontra = new System.Windows.Forms.TextBox();
            this.Btningresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ptlogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nuevovende = new System.Windows.Forms.Label();
            this.Olvidocontra = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptlogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TxtUsuario.Location = new System.Drawing.Point(110, 85);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(239, 26);
            this.TxtUsuario.TabIndex = 0;
            // 
            // Txtcontra
            // 
            this.Txtcontra.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Txtcontra.Location = new System.Drawing.Point(110, 148);
            this.Txtcontra.Name = "Txtcontra";
            this.Txtcontra.PasswordChar = '*';
            this.Txtcontra.Size = new System.Drawing.Size(239, 26);
            this.Txtcontra.TabIndex = 1;
            // 
            // Btningresar
            // 
            this.Btningresar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Btningresar.Location = new System.Drawing.Point(135, 200);
            this.Btningresar.Name = "Btningresar";
            this.Btningresar.Size = new System.Drawing.Size(186, 57);
            this.Btningresar.TabIndex = 2;
            this.Btningresar.Text = "Ingresar";
            this.Btningresar.UseVisualStyleBackColor = true;
            this.Btningresar.Click += new System.EventHandler(this.Btningresar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(39)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.Ptlogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 331);
            this.panel1.TabIndex = 3;
            // 
            // Ptlogo
            // 
            this.Ptlogo.BackgroundImage = global::Seccion_8.Properties.Resources.logo;
            this.Ptlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ptlogo.Location = new System.Drawing.Point(-10, 53);
            this.Ptlogo.Name = "Ptlogo";
            this.Ptlogo.Size = new System.Drawing.Size(237, 227);
            this.Ptlogo.TabIndex = 0;
            this.Ptlogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(73)))), ((int)(((byte)(181)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Btningresar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Txtcontra);
            this.panel2.Controls.Add(this.Nuevovende);
            this.panel2.Controls.Add(this.TxtUsuario);
            this.panel2.Controls.Add(this.Olvidocontra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(227, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 331);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Seccion_8.Properties.Resources.x;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(455, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.label2.Location = new System.Drawing.Point(177, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.label1.Location = new System.Drawing.Point(143, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cedula de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.label3.Location = new System.Drawing.Point(163, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "LOGIN";
            // 
            // Nuevovende
            // 
            this.Nuevovende.AutoSize = true;
            this.Nuevovende.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nuevovende.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevovende.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.Nuevovende.Location = new System.Drawing.Point(235, 298);
            this.Nuevovende.Name = "Nuevovende";
            this.Nuevovende.Size = new System.Drawing.Size(248, 18);
            this.Nuevovende.TabIndex = 1;
            this.Nuevovende.Text = "Registrar Nuevo Vendedor";
            this.Nuevovende.Click += new System.EventHandler(this.Nuevovende_Click);
            // 
            // Olvidocontra
            // 
            this.Olvidocontra.AutoSize = true;
            this.Olvidocontra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Olvidocontra.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Olvidocontra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.Olvidocontra.Location = new System.Drawing.Point(3, 298);
            this.Olvidocontra.Name = "Olvidocontra";
            this.Olvidocontra.Size = new System.Drawing.Size(218, 18);
            this.Olvidocontra.TabIndex = 0;
            this.Olvidocontra.Text = "Olvido su Contraseña?";
            this.Olvidocontra.Click += new System.EventHandler(this.Olvidocontra_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 331);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ptlogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Txtcontra;
        private System.Windows.Forms.Button Btningresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nuevovende;
        private System.Windows.Forms.Label Olvidocontra;
        private System.Windows.Forms.PictureBox Ptlogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox TxtUsuario;
    }
}

