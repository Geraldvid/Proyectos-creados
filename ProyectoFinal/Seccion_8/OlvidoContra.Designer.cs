namespace Seccion_8
{
    partial class OlvidoContra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ptlogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.Dgcontra = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Cbpreguntasecreta = new System.Windows.Forms.ComboBox();
            this.Txtrespuestasecreta = new System.Windows.Forms.TextBox();
            this.Txtcedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btnregistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ptlogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgcontra)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(39)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.Ptlogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 411);
            this.panel1.TabIndex = 6;
            // 
            // Ptlogo
            // 
            this.Ptlogo.BackgroundImage = global::Seccion_8.Properties.Resources.logo;
            this.Ptlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ptlogo.Location = new System.Drawing.Point(-4, 92);
            this.Ptlogo.Name = "Ptlogo";
            this.Ptlogo.Size = new System.Drawing.Size(237, 227);
            this.Ptlogo.TabIndex = 0;
            this.Ptlogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(73)))), ((int)(((byte)(181)))));
            this.panel2.Controls.Add(this.Limpiar);
            this.panel2.Controls.Add(this.Salir);
            this.panel2.Controls.Add(this.Dgcontra);
            this.panel2.Controls.Add(this.Cbpreguntasecreta);
            this.panel2.Controls.Add(this.Txtrespuestasecreta);
            this.panel2.Controls.Add(this.Txtcedula);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Btnregistrar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(227, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 411);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Limpiar
            // 
            this.Limpiar.BackgroundImage = global::Seccion_8.Properties.Resources._419660;
            this.Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Limpiar.Location = new System.Drawing.Point(260, 169);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(29, 28);
            this.Limpiar.TabIndex = 5;
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Salir
            // 
            this.Salir.BackgroundImage = global::Seccion_8.Properties.Resources.salir1;
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Salir.Location = new System.Drawing.Point(295, 169);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(29, 28);
            this.Salir.TabIndex = 6;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dgcontra
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dgcontra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgcontra.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Dgcontra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgcontra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgcontra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgcontra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgcontra.DoubleBuffered = true;
            this.Dgcontra.EnableHeadersVisualStyles = false;
            this.Dgcontra.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.Dgcontra.HeaderForeColor = System.Drawing.Color.Black;
            this.Dgcontra.Location = new System.Drawing.Point(6, 206);
            this.Dgcontra.Name = "Dgcontra";
            this.Dgcontra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgcontra.Size = new System.Drawing.Size(573, 196);
            this.Dgcontra.TabIndex = 10;
            // 
            // Cbpreguntasecreta
            // 
            this.Cbpreguntasecreta.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Cbpreguntasecreta.FormattingEnabled = true;
            this.Cbpreguntasecreta.Items.AddRange(new object[] {
            "Color favorito?",
            "Nombre de madre?",
            "Nombre de mascota?",
            "Canción favorita?",
            "Instrumento favorito?"});
            this.Cbpreguntasecreta.Location = new System.Drawing.Point(339, 101);
            this.Cbpreguntasecreta.Name = "Cbpreguntasecreta";
            this.Cbpreguntasecreta.Size = new System.Drawing.Size(240, 26);
            this.Cbpreguntasecreta.TabIndex = 1;
            // 
            // Txtrespuestasecreta
            // 
            this.Txtrespuestasecreta.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Txtrespuestasecreta.Location = new System.Drawing.Point(340, 137);
            this.Txtrespuestasecreta.Name = "Txtrespuestasecreta";
            this.Txtrespuestasecreta.Size = new System.Drawing.Size(239, 26);
            this.Txtrespuestasecreta.TabIndex = 3;
            // 
            // Txtcedula
            // 
            this.Txtcedula.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Txtcedula.Location = new System.Drawing.Point(340, 67);
            this.Txtcedula.Name = "Txtcedula";
            this.Txtcedula.Size = new System.Drawing.Size(239, 26);
            this.Txtcedula.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.label6.Location = new System.Drawing.Point(15, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Digite el numero cédula";
            // 
            // Btnregistrar
            // 
            this.Btnregistrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnregistrar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Btnregistrar.Location = new System.Drawing.Point(340, 169);
            this.Btnregistrar.Name = "Btnregistrar";
            this.Btnregistrar.Size = new System.Drawing.Size(239, 31);
            this.Btnregistrar.TabIndex = 4;
            this.Btnregistrar.Text = "Registrar";
            this.Btnregistrar.UseVisualStyleBackColor = false;
            this.Btnregistrar.Click += new System.EventHandler(this.Btnregistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.label3.Location = new System.Drawing.Point(105, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recuperar Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.label5.Location = new System.Drawing.Point(15, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Digite la respuesta secreta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seleccione una pregunta secreta";
            // 
            // OlvidoContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 411);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OlvidoContra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OlvidoContra";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ptlogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgcontra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Ptlogo;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid Dgcontra;
        private System.Windows.Forms.ComboBox Cbpreguntasecreta;
        private System.Windows.Forms.TextBox Txtrespuestasecreta;
        private System.Windows.Forms.TextBox Txtcedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btnregistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Salir;
    }
}