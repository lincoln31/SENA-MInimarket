namespace Minimarket
{
    partial class UPD_Categoria
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NOMBRE = new System.Windows.Forms.TextBox();
            this.textBox_DESCRIPCION = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Consultar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.ELIMINAR = new System.Windows.Forms.Button();
            this.Enviar = new System.Windows.Forms.Button();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "NOMBRE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "DESCRIPCION :";
            // 
            // textBox_NOMBRE
            // 
            this.textBox_NOMBRE.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_NOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_NOMBRE.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NOMBRE.Location = new System.Drawing.Point(302, 90);
            this.textBox_NOMBRE.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NOMBRE.Name = "textBox_NOMBRE";
            this.textBox_NOMBRE.Size = new System.Drawing.Size(312, 39);
            this.textBox_NOMBRE.TabIndex = 19;
            // 
            // textBox_DESCRIPCION
            // 
            this.textBox_DESCRIPCION.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_DESCRIPCION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_DESCRIPCION.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DESCRIPCION.Location = new System.Drawing.Point(302, 162);
            this.textBox_DESCRIPCION.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_DESCRIPCION.Name = "textBox_DESCRIPCION";
            this.textBox_DESCRIPCION.Size = new System.Drawing.Size(312, 39);
            this.textBox_DESCRIPCION.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoriaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoriaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(328, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(245, 150);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(CL_CapaEntidades.Categoria);
            // 
            // Consultar
            // 
            this.Consultar.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar.Location = new System.Drawing.Point(857, 200);
            this.Consultar.Margin = new System.Windows.Forms.Padding(2);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(147, 54);
            this.Consultar.TabIndex = 35;
            this.Consultar.Text = "CONSULTAR";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.Location = new System.Drawing.Point(857, 285);
            this.Actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(147, 54);
            this.Actualizar.TabIndex = 36;
            this.Actualizar.Text = "ACTUALIZAR";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ELIMINAR.Location = new System.Drawing.Point(857, 366);
            this.ELIMINAR.Margin = new System.Windows.Forms.Padding(2);
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.Size = new System.Drawing.Size(147, 54);
            this.ELIMINAR.TabIndex = 39;
            this.ELIMINAR.Text = "ELIMINAR";
            this.ELIMINAR.UseVisualStyleBackColor = true;
            // 
            // Enviar
            // 
            this.Enviar.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enviar.Location = new System.Drawing.Point(857, 446);
            this.Enviar.Margin = new System.Windows.Forms.Padding(2);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(147, 54);
            this.Enviar.TabIndex = 40;
            this.Enviar.Text = "ENVIAR";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            this.idCategoriaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // UPD_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 660);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.ELIMINAR);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_DESCRIPCION);
            this.Controls.Add(this.textBox_NOMBRE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "UPD_Categoria";
            this.Text = "UPD_Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NOMBRE;
        private System.Windows.Forms.TextBox textBox_DESCRIPCION;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button ELIMINAR;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}