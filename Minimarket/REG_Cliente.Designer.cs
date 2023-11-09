namespace Minimarket
{
    partial class REG_Cliente
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
            this.textBox_IDE = new System.Windows.Forms.TextBox();
            this.textBox_TDOCUMENTO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_APELLIDO = new System.Windows.Forms.TextBox();
            this.textBox_NOMBRE = new System.Windows.Forms.TextBox();
            this.textBox_TEL = new System.Windows.Forms.TextBox();
            this.textBox_EMAIL = new System.Windows.Forms.TextBox();
            this.Registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "IDENTIFICACION :";
            // 
            // textBox_IDE
            // 
            this.textBox_IDE.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_IDE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_IDE.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IDE.Location = new System.Drawing.Point(452, 176);
            this.textBox_IDE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_IDE.Name = "textBox_IDE";
            this.textBox_IDE.Size = new System.Drawing.Size(415, 47);
            this.textBox_IDE.TabIndex = 12;
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
            this.textBox_TDOCUMENTO.Location = new System.Drawing.Point(452, 111);
            this.textBox_TDOCUMENTO.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_TDOCUMENTO.Name = "textBox_TDOCUMENTO";
            this.textBox_TDOCUMENTO.Size = new System.Drawing.Size(415, 48);
            this.textBox_TDOCUMENTO.TabIndex = 13;
            this.textBox_TDOCUMENTO.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "TIPO DOCUMENTO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 36);
            this.label3.TabIndex = 15;
            this.label3.Text = "NOMBRE :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 36);
            this.label4.TabIndex = 16;
            this.label4.Text = "TELEFONO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "APELLIDO :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bernard MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(187, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 36);
            this.label6.TabIndex = 18;
            this.label6.Text = "EMAIL :";
            // 
            // textBox_APELLIDO
            // 
            this.textBox_APELLIDO.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_APELLIDO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_APELLIDO.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_APELLIDO.Location = new System.Drawing.Point(452, 306);
            this.textBox_APELLIDO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_APELLIDO.Name = "textBox_APELLIDO";
            this.textBox_APELLIDO.Size = new System.Drawing.Size(415, 47);
            this.textBox_APELLIDO.TabIndex = 19;
            // 
            // textBox_NOMBRE
            // 
            this.textBox_NOMBRE.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_NOMBRE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_NOMBRE.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NOMBRE.Location = new System.Drawing.Point(452, 242);
            this.textBox_NOMBRE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_NOMBRE.Name = "textBox_NOMBRE";
            this.textBox_NOMBRE.Size = new System.Drawing.Size(415, 47);
            this.textBox_NOMBRE.TabIndex = 20;
            // 
            // textBox_TEL
            // 
            this.textBox_TEL.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_TEL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TEL.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_TEL.Location = new System.Drawing.Point(452, 369);
            this.textBox_TEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TEL.Name = "textBox_TEL";
            this.textBox_TEL.Size = new System.Drawing.Size(415, 47);
            this.textBox_TEL.TabIndex = 21;
            // 
            // textBox_EMAIL
            // 
            this.textBox_EMAIL.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_EMAIL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_EMAIL.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EMAIL.Location = new System.Drawing.Point(452, 436);
            this.textBox_EMAIL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_EMAIL.Name = "textBox_EMAIL";
            this.textBox_EMAIL.Size = new System.Drawing.Size(415, 47);
            this.textBox_EMAIL.TabIndex = 22;
            // 
            // Registrar
            // 
            this.Registrar.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.Location = new System.Drawing.Point(1173, 281);
            this.Registrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(196, 66);
            this.Registrar.TabIndex = 23;
            this.Registrar.Text = "REGISTRAR";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // REG_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 812);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.textBox_EMAIL);
            this.Controls.Add(this.textBox_TEL);
            this.Controls.Add(this.textBox_NOMBRE);
            this.Controls.Add(this.textBox_APELLIDO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_TDOCUMENTO);
            this.Controls.Add(this.textBox_IDE);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "REG_Cliente";
            this.Text = "REG_Cliente";
            this.Load += new System.EventHandler(this.REG_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_IDE;
        private System.Windows.Forms.ComboBox textBox_TDOCUMENTO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_APELLIDO;
        private System.Windows.Forms.TextBox textBox_NOMBRE;
        private System.Windows.Forms.TextBox textBox_TEL;
        private System.Windows.Forms.TextBox textBox_EMAIL;
        private System.Windows.Forms.Button Registrar;
    }
}