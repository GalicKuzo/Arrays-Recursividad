namespace Arrays_Recursividad
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_dato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Ordenar = new System.Windows.Forms.Button();
            this.listB_datos = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Agregar);
            this.groupBox1.Controls.Add(this.txt_dato);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Array";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(29, 122);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(227, 34);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.Text = "Agregar Dato";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_dato
            // 
            this.txt_dato.Location = new System.Drawing.Point(54, 76);
            this.txt_dato.Name = "txt_dato";
            this.txt_dato.Size = new System.Drawing.Size(252, 22);
            this.txt_dato.TabIndex = 3;
            this.txt_dato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dato_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dato";
            // 
            // btn_Ordenar
            // 
            this.btn_Ordenar.Location = new System.Drawing.Point(386, 212);
            this.btn_Ordenar.Name = "btn_Ordenar";
            this.btn_Ordenar.Size = new System.Drawing.Size(227, 34);
            this.btn_Ordenar.TabIndex = 5;
            this.btn_Ordenar.Text = "Ordenar";
            this.btn_Ordenar.UseVisualStyleBackColor = true;
            this.btn_Ordenar.Click += new System.EventHandler(this.btn_Ordenar_Click);
            // 
            // listB_datos
            // 
            this.listB_datos.FormattingEnabled = true;
            this.listB_datos.ItemHeight = 16;
            this.listB_datos.Location = new System.Drawing.Point(335, 19);
            this.listB_datos.Name = "listB_datos";
            this.listB_datos.Size = new System.Drawing.Size(335, 180);
            this.listB_datos.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 258);
            this.Controls.Add(this.listB_datos);
            this.Controls.Add(this.btn_Ordenar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txt_dato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Ordenar;
        private System.Windows.Forms.ListBox listB_datos;
    }
}

