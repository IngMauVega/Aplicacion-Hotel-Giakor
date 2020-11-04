namespace Giakor
{
    partial class Nueva_Reservacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Salida = new System.Windows.Forms.DateTimePicker();
            this.llegada = new System.Windows.Forms.DateTimePicker();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.txthab = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnoches = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.metodo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del huesped";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Dia de salida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Dia de llegada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(12, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Monto";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.DarkGray;
            this.txtNombre.Location = new System.Drawing.Point(208, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(260, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // Salida
            // 
            this.Salida.Location = new System.Drawing.Point(208, 103);
            this.Salida.MaxDate = new System.DateTime(2060, 12, 31, 0, 0, 0, 0);
            this.Salida.MinDate = new System.DateTime(2020, 10, 10, 0, 0, 0, 0);
            this.Salida.Name = "Salida";
            this.Salida.Size = new System.Drawing.Size(200, 20);
            this.Salida.TabIndex = 12;
            this.Salida.Value = new System.DateTime(2020, 10, 10, 0, 0, 0, 0);
            // 
            // llegada
            // 
            this.llegada.Location = new System.Drawing.Point(208, 129);
            this.llegada.MaxDate = new System.DateTime(2060, 12, 31, 0, 0, 0, 0);
            this.llegada.MinDate = new System.DateTime(2020, 10, 10, 0, 0, 0, 0);
            this.llegada.Name = "llegada";
            this.llegada.Size = new System.Drawing.Size(200, 20);
            this.llegada.TabIndex = 13;
            this.llegada.Value = new System.DateTime(2020, 10, 10, 0, 0, 0, 0);
            // 
            // txtmonto
            // 
            this.txtmonto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtmonto.Location = new System.Drawing.Point(196, 222);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(121, 20);
            this.txtmonto.TabIndex = 14;
            this.txtmonto.Text = "0";
            // 
            // txthab
            // 
            this.txthab.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txthab.FormattingEnabled = true;
            this.txthab.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "201",
            "202",
            "301",
            "302",
            "303",
            "304",
            "401",
            "402",
            "501",
            "502",
            "503",
            "601",
            "602",
            "603"});
            this.txthab.Location = new System.Drawing.Point(208, 62);
            this.txthab.Name = "txthab";
            this.txthab.Size = new System.Drawing.Size(121, 21);
            this.txthab.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "N. de Noches";
            // 
            // lblnoches
            // 
            this.lblnoches.AutoSize = true;
            this.lblnoches.BackColor = System.Drawing.Color.Transparent;
            this.lblnoches.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoches.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnoches.Location = new System.Drawing.Point(205, 160);
            this.lblnoches.Name = "lblnoches";
            this.lblnoches.Size = new System.Drawing.Size(18, 17);
            this.lblnoches.TabIndex = 17;
            this.lblnoches.Text = "0";
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(335, 277);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(145, 35);
            this.btnvolver.TabIndex = 18;
            this.btnvolver.Text = "Reservacion Terminada";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Metodo de Pago";
            // 
            // metodo
            // 
            this.metodo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.metodo.FormattingEnabled = true;
            this.metodo.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta de Credito",
            "Transferencia",
            "Tarjeta de Debito"});
            this.metodo.Location = new System.Drawing.Point(196, 180);
            this.metodo.Name = "metodo";
            this.metodo.Size = new System.Drawing.Size(121, 21);
            this.metodo.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-5, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Mas detalles de reservacon";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Habitacion";
            // 
            // Nueva_Reservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Giakor.Properties.Resources._104;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.lblnoches);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthab);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.llegada);
            this.Controls.Add(this.Salida);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Nueva_Reservacion";
            this.Text = "Nueva_Reservacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker Salida;
        private System.Windows.Forms.DateTimePicker llegada;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.ComboBox txthab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnoches;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox metodo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}