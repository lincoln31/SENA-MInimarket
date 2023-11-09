namespace Minimarket
{
    partial class REG_Categoria
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NOMBRE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DESCRIPCION = new System.Windows.Forms.TextBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "NOMBRE :";
            // 
            // textBox_NOMBRE
            // 
            this.textBox_NOMBRE.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_NOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_NOMBRE.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NOMBRE.Location = new System.Drawing.Point(323, 119);
            this.textBox_NOMBRE.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_NOMBRE.Name = "textBox_NOMBRE";
            this.textBox_NOMBRE.Size = new System.Drawing.Size(312, 39);
            this.textBox_NOMBRE.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "DESCRIPCION :";
            // 
            // textBox_DESCRIPCION
            // 
            this.textBox_DESCRIPCION.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_DESCRIPCION.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_DESCRIPCION.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DESCRIPCION.Location = new System.Drawing.Point(323, 188);
            this.textBox_DESCRIPCION.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_DESCRIPCION.Name = "textBox_DESCRIPCION";
            this.textBox_DESCRIPCION.Size = new System.Drawing.Size(312, 39);
            this.textBox_DESCRIPCION.TabIndex = 18;
            // 
            // Registrar
            // 
            this.Registrar.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.Location = new System.Drawing.Point(812, 146);
            this.Registrar.Margin = new System.Windows.Forms.Padding(2);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(147, 54);
            this.Registrar.TabIndex = 24;
            this.Registrar.Text = "REGISTRAR";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // REG_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 660);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.textBox_DESCRIPCION);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_NOMBRE);
            this.Controls.Add(this.label2);
            this.Name = "REG_Categoria";
            this.Text = "REG_Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_NOMBRE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_DESCRIPCION;
        private System.Windows.Forms.Button Registrar;
    }
}