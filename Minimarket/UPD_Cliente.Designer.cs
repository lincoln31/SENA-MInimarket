namespace Minimarket
{
    partial class UPD_Cliente
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
            this.textBox_TDOCUMENTO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_IDE = new System.Windows.Forms.TextBox();
            this.textBox_EMAIL = new System.Windows.Forms.TextBox();
            this.textBox_NOMBRE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_APELLIDO = new System.Windows.Forms.TextBox();
            this.textBox_TEL = new System.Windows.Forms.TextBox();
            this.Consultar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.ELIMINAR = new System.Windows.Forms.Button();
            this.Enviar = new System.Windows.Forms.Button();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tipoDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 36);
            this.label2.TabIndex = 15;
            this.label2.Text = "TIPO DOCUMENTO :";
            // 
            // textBox_TDOCUMENTO
            // 
            this.textBox_TDOCUMENTO.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TDOCUMENTO.FormattingEnabled = true;
            this.textBox_TDOCUMENTO.Items.AddRange(new object[] {
            "CC",
            "TI",
            "PAS",
            "PEP",
            "PPt",
            "CE",
            "Otro"});
            this.textBox_TDOCUMENTO.Location = new System.Drawing.Point(336, 69);
            this.textBox_TDOCUMENTO.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TDOCUMENTO.Name = "textBox_TDOCUMENTO";
            this.textBox_TDOCUMENTO.Size = new System.Drawing.Size(415, 48);
            this.textBox_TDOCUMENTO.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "IDENTIFICACION :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(164, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 36);
            this.label6.TabIndex = 19;
            this.label6.Text = "EMAIL :";
            // 
            // textBox_IDE
            // 
            this.textBox_IDE.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_IDE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_IDE.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IDE.Location = new System.Drawing.Point(336, 141);
            this.textBox_IDE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_IDE.Name = "textBox_IDE";
            this.textBox_IDE.Size = new System.Drawing.Size(415, 47);
            this.textBox_IDE.TabIndex = 20;
            // 
            // textBox_EMAIL
            // 
            this.textBox_EMAIL.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_EMAIL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_EMAIL.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EMAIL.Location = new System.Drawing.Point(336, 217);
            this.textBox_EMAIL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_EMAIL.Name = "textBox_EMAIL";
            this.textBox_EMAIL.Size = new System.Drawing.Size(415, 47);
            this.textBox_EMAIL.TabIndex = 23;
            // 
            // textBox_NOMBRE
            // 
            this.textBox_NOMBRE.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_NOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_NOMBRE.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NOMBRE.Location = new System.Drawing.Point(1088, 71);
            this.textBox_NOMBRE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_NOMBRE.Name = "textBox_NOMBRE";
            this.textBox_NOMBRE.Size = new System.Drawing.Size(415, 47);
            this.textBox_NOMBRE.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(867, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 36);
            this.label3.TabIndex = 25;
            this.label3.Text = "NOMBRE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(852, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 36);
            this.label5.TabIndex = 26;
            this.label5.Text = "APELLIDO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(851, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 36);
            this.label4.TabIndex = 27;
            this.label4.Text = "TELEFONO :";
            // 
            // textBox_APELLIDO
            // 
            this.textBox_APELLIDO.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_APELLIDO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_APELLIDO.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_APELLIDO.Location = new System.Drawing.Point(1088, 141);
            this.textBox_APELLIDO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_APELLIDO.Name = "textBox_APELLIDO";
            this.textBox_APELLIDO.Size = new System.Drawing.Size(415, 47);
            this.textBox_APELLIDO.TabIndex = 28;
            // 
            // textBox_TEL
            // 
            this.textBox_TEL.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_TEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TEL.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TEL.Location = new System.Drawing.Point(1088, 217);
            this.textBox_TEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TEL.Name = "textBox_TEL";
            this.textBox_TEL.Size = new System.Drawing.Size(415, 47);
            this.textBox_TEL.TabIndex = 29;
            // 
            // Consultar
            // 
            this.Consultar.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar.Location = new System.Drawing.Point(1307, 388);
            this.Consultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(196, 66);
            this.Consultar.TabIndex = 34;
            this.Consultar.Text = "CONSULTAR";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.Location = new System.Drawing.Point(1307, 486);
            this.Actualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(196, 66);
            this.Actualizar.TabIndex = 35;
            this.Actualizar.Text = "ACTUALIZAR";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ELIMINAR.Location = new System.Drawing.Point(1307, 578);
            this.ELIMINAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.Size = new System.Drawing.Size(196, 66);
            this.ELIMINAR.TabIndex = 38;
            this.ELIMINAR.Text = "ELIMINAR";
            this.ELIMINAR.UseVisualStyleBackColor = true;
            // 
            // Enviar
            // 
            this.Enviar.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enviar.Location = new System.Drawing.Point(1307, 676);
            this.Enviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(196, 66);
            this.Enviar.TabIndex = 39;
            this.Enviar.Text = "ENVIAR";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(CL_CapaEntidades.Cliente);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoDocDataGridViewTextBoxColumn,
            this.identificacionDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(42, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1072, 358);
            this.dataGridView1.TabIndex = 40;
            // 
            // tipoDocDataGridViewTextBoxColumn
            // 
            this.tipoDocDataGridViewTextBoxColumn.DataPropertyName = "tipoDoc";
            this.tipoDocDataGridViewTextBoxColumn.HeaderText = "tipoDoc";
            this.tipoDocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDocDataGridViewTextBoxColumn.Name = "tipoDocDataGridViewTextBoxColumn";
            this.tipoDocDataGridViewTextBoxColumn.Width = 125;
            // 
            // identificacionDataGridViewTextBoxColumn
            // 
            this.identificacionDataGridViewTextBoxColumn.DataPropertyName = "identificacion";
            this.identificacionDataGridViewTextBoxColumn.HeaderText = "identificacion";
            this.identificacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.identificacionDataGridViewTextBoxColumn.Name = "identificacionDataGridViewTextBoxColumn";
            this.identificacionDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "nombres";
            this.nombresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.Width = 125;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.Width = 125;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "correo";
            this.correoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.Width = 125;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "celular";
            this.celularDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.Width = 125;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataSource = typeof(CL_CapaEntidades.Cliente);
            // 
            // UPD_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 812);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.ELIMINAR);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.textBox_TEL);
            this.Controls.Add(this.textBox_APELLIDO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_NOMBRE);
            this.Controls.Add(this.textBox_EMAIL);
            this.Controls.Add(this.textBox_IDE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_TDOCUMENTO);
            this.Controls.Add(this.label2);
            this.Name = "UPD_Cliente";
            this.Text = "UPD_Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox textBox_TDOCUMENTO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_IDE;
        private System.Windows.Forms.TextBox textBox_EMAIL;
        private System.Windows.Forms.TextBox textBox_NOMBRE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_APELLIDO;
        private System.Windows.Forms.TextBox textBox_TEL;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button ELIMINAR;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificasionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}