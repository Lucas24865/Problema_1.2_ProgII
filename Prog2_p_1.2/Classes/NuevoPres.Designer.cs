namespace Prog2_p_1._2
{
    partial class NuevoPres
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
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Cliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_FormaPago = new System.Windows.Forms.ComboBox();
            this.btn_nueva = new System.Windows.Forms.Button();
            this.dgv_artsAniadidos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.dgv_arts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_artsAniadidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arts)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Cliente";
            // 
            // cb_Cliente
            // 
            this.cb_Cliente.FormattingEnabled = true;
            this.cb_Cliente.Location = new System.Drawing.Point(379, 15);
            this.cb_Cliente.Name = "cb_Cliente";
            this.cb_Cliente.Size = new System.Drawing.Size(184, 23);
            this.cb_Cliente.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Forma Pago";
            // 
            // cb_FormaPago
            // 
            this.cb_FormaPago.FormattingEnabled = true;
            this.cb_FormaPago.Location = new System.Drawing.Point(102, 15);
            this.cb_FormaPago.Name = "cb_FormaPago";
            this.cb_FormaPago.Size = new System.Drawing.Size(184, 23);
            this.cb_FormaPago.TabIndex = 15;
            this.cb_FormaPago.SelectedIndexChanged += new System.EventHandler(this.cb_FormaPago_SelectedIndexChanged);
            // 
            // btn_nueva
            // 
            this.btn_nueva.Location = new System.Drawing.Point(888, 15);
            this.btn_nueva.Name = "btn_nueva";
            this.btn_nueva.Size = new System.Drawing.Size(102, 23);
            this.btn_nueva.TabIndex = 17;
            this.btn_nueva.Text = "Nueva Factura";
            this.btn_nueva.UseVisualStyleBackColor = true;
            this.btn_nueva.Click += new System.EventHandler(this.btn_nueva_Click);
            // 
            // dgv_artsAniadidos
            // 
            this.dgv_artsAniadidos.AllowUserToAddRows = false;
            this.dgv_artsAniadidos.AllowUserToDeleteRows = false;
            this.dgv_artsAniadidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_artsAniadidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nombre,
            this.pUnitario,
            this.cantidad,
            this.subtotal,
            this.borrar});
            this.dgv_artsAniadidos.Location = new System.Drawing.Point(429, 57);
            this.dgv_artsAniadidos.Name = "dgv_artsAniadidos";
            this.dgv_artsAniadidos.ReadOnly = true;
            this.dgv_artsAniadidos.RowTemplate.Height = 25;
            this.dgv_artsAniadidos.Size = new System.Drawing.Size(561, 421);
            this.dgv_artsAniadidos.TabIndex = 20;
            this.dgv_artsAniadidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_artAniadidos_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // pUnitario
            // 
            this.pUnitario.HeaderText = "Precio Unitario";
            this.pUnitario.Name = "pUnitario";
            this.pUnitario.ReadOnly = true;
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
            // borrar
            // 
            this.borrar.HeaderText = "Borrar";
            this.borrar.Name = "borrar";
            this.borrar.ReadOnly = true;
            this.borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.borrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(184, 62);
            this.numericQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(120, 23);
            this.numericQuantity.TabIndex = 22;
            this.numericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgv_arts
            // 
            this.dgv_arts.AllowUserToAddRows = false;
            this.dgv_arts.AllowUserToDeleteRows = false;
            this.dgv_arts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_arts.Location = new System.Drawing.Point(17, 112);
            this.dgv_arts.MultiSelect = false;
            this.dgv_arts.Name = "dgv_arts";
            this.dgv_arts.ReadOnly = true;
            this.dgv_arts.RowTemplate.Height = 25;
            this.dgv_arts.Size = new System.Drawing.Size(388, 298);
            this.dgv_arts.TabIndex = 24;
            this.dgv_arts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_arts_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Articulos";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(321, 60);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 23;
            this.btn_add.Text = "Agregar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(82, 445);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(96, 15);
            this.lbl_Total.TabIndex = 28;
            this.lbl_Total.Text = "placeHolderTotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Total:";
            // 
            // NuevoPres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 511);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.dgv_arts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgv_artsAniadidos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_Cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_FormaPago);
            this.Controls.Add(this.btn_nueva);
            this.Name = "NuevoPres";
            this.Text = "NuevoPres";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_artsAniadidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_FormaPago;
        private System.Windows.Forms.Button btn_nueva;
        private System.Windows.Forms.DataGridView dgv_artsAniadidos;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.DataGridView dgv_arts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn borrar;
    }
}