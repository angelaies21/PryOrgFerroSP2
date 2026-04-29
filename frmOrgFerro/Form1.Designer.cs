namespace frmOrgFerro
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.cmbDias = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblFechaIda = new System.Windows.Forms.Label();
            this.lblFechaVuelta = new System.Windows.Forms.Label();
            this.dtFechaIda = new System.Windows.Forms.DateTimePicker();
            this.dtFechaVuelta = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("MS UI Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabel1.Location = new System.Drawing.Point(129, 21);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(121, 24);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "BOLETOS";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(28, 73);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(58, 15);
            this.lblDistancia.TabIndex = 2;
            this.lblDistancia.Text = "Distancia";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(28, 120);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(98, 15);
            this.lblDias.TabIndex = 3;
            this.lblDias.Text = "Días de estancia";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(151, 73);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(200, 20);
            this.txtDistancia.TabIndex = 5;
            this.txtDistancia.TextChanged += new System.EventHandler(this.txtDistancia_TextChanged);
            // 
            // cmbDias
            // 
            this.cmbDias.FormattingEnabled = true;
            this.cmbDias.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbDias.Location = new System.Drawing.Point(151, 120);
            this.cmbDias.Name = "cmbDias";
            this.cmbDias.Size = new System.Drawing.Size(200, 21);
            this.cmbDias.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(279, 276);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 34);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFechaIda
            // 
            this.lblFechaIda.AutoSize = true;
            this.lblFechaIda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIda.Location = new System.Drawing.Point(28, 167);
            this.lblFechaIda.Name = "lblFechaIda";
            this.lblFechaIda.Size = new System.Drawing.Size(86, 16);
            this.lblFechaIda.TabIndex = 10;
            this.lblFechaIda.Text = "Fecha de ida";
            this.lblFechaIda.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFechaVuelta
            // 
            this.lblFechaVuelta.AutoSize = true;
            this.lblFechaVuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVuelta.Location = new System.Drawing.Point(28, 213);
            this.lblFechaVuelta.Name = "lblFechaVuelta";
            this.lblFechaVuelta.Size = new System.Drawing.Size(103, 16);
            this.lblFechaVuelta.TabIndex = 11;
            this.lblFechaVuelta.Text = "Fecha de vuelta";
            // 
            // dtFechaIda
            // 
            this.dtFechaIda.Location = new System.Drawing.Point(151, 167);
            this.dtFechaIda.Name = "dtFechaIda";
            this.dtFechaIda.Size = new System.Drawing.Size(200, 20);
            this.dtFechaIda.TabIndex = 12;
            // 
            // dtFechaVuelta
            // 
            this.dtFechaVuelta.Location = new System.Drawing.Point(151, 213);
            this.dtFechaVuelta.Name = "dtFechaVuelta";
            this.dtFechaVuelta.Size = new System.Drawing.Size(200, 20);
            this.dtFechaVuelta.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(403, 341);
            this.Controls.Add(this.dtFechaVuelta);
            this.Controls.Add(this.dtFechaIda);
            this.Controls.Add(this.lblFechaVuelta);
            this.Controls.Add(this.lblFechaIda);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cmbDias);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Form1";
            this.Text = "Organziación Ferro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.ComboBox cmbDias;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblFechaIda;
        private System.Windows.Forms.Label lblFechaVuelta;
        private System.Windows.Forms.DateTimePicker dtFechaIda;
        private System.Windows.Forms.DateTimePicker dtFechaVuelta;
    }
}

