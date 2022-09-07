namespace Prog2_p_1._2
{
    partial class ConsultaPres
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
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_factura = new System.Windows.Forms.ComboBox();
            this.dgv_arts_aniadidos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arts_aniadidos)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(678, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Presupuesto";
            // 
            // cb_factura
            // 
            this.cb_factura.FormattingEnabled = true;
            this.cb_factura.Location = new System.Drawing.Point(150, 13);
            this.cb_factura.Name = "cb_factura";
            this.cb_factura.Size = new System.Drawing.Size(346, 23);
            this.cb_factura.TabIndex = 12;
            this.cb_factura.SelectedIndexChanged += new System.EventHandler(this.cb_factura_SelectedIndexChanged);
            // 
            // dgv_arts_aniadidos
            // 
            this.dgv_arts_aniadidos.AllowUserToAddRows = false;
            this.dgv_arts_aniadidos.AllowUserToDeleteRows = false;
            this.dgv_arts_aniadidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_arts_aniadidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.cantidad,
            this.subtotal});
            this.dgv_arts_aniadidos.Location = new System.Drawing.Point(12, 58);
            this.dgv_arts_aniadidos.Name = "dgv_arts_aniadidos";
            this.dgv_arts_aniadidos.ReadOnly = true;
            this.dgv_arts_aniadidos.RowTemplate.Height = 25;
            this.dgv_arts_aniadidos.Size = new System.Drawing.Size(758, 338);
            this.dgv_arts_aniadidos.TabIndex = 13;
            this.dgv_arts_aniadidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_arts_aniadidos_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre Articulo";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // ConsultaPres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_arts_aniadidos);
            this.Controls.Add(this.cb_factura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Name = "ConsultaPres";
            this.Text = "ConsultaPres";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arts_aniadidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_factura;
        private System.Windows.Forms.DataGridView dgv_arts_aniadidos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}