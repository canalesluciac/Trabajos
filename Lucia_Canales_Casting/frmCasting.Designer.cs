namespace Lucia_Canales_Casting
{
    partial class frmCasting
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
            this.btnCastImplicito = new System.Windows.Forms.Button();
            this.btnCasteoExplicito = new System.Windows.Forms.Button();
            this.lblInt = new System.Windows.Forms.Label();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCastImplicito
            // 
            this.btnCastImplicito.Location = new System.Drawing.Point(308, 224);
            this.btnCastImplicito.Name = "btnCastImplicito";
            this.btnCastImplicito.Size = new System.Drawing.Size(131, 23);
            this.btnCastImplicito.TabIndex = 0;
            this.btnCastImplicito.Text = "Casteo Implicito";
            this.btnCastImplicito.UseVisualStyleBackColor = true;
            this.btnCastImplicito.Click += new System.EventHandler(this.btnCastImplicito_Click);
            // 
            // btnCasteoExplicito
            // 
            this.btnCasteoExplicito.Location = new System.Drawing.Point(308, 268);
            this.btnCasteoExplicito.Name = "btnCasteoExplicito";
            this.btnCasteoExplicito.Size = new System.Drawing.Size(131, 23);
            this.btnCasteoExplicito.TabIndex = 1;
            this.btnCasteoExplicito.Text = "Casteo Explicito";
            this.btnCasteoExplicito.UseVisualStyleBackColor = true;
            this.btnCasteoExplicito.Click += new System.EventHandler(this.btnCasteoExplicito_Click);
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(260, 172);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(98, 13);
            this.lblInt.TabIndex = 2;
            this.lblInt.Text = "Ingrese entero (int):";
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(381, 169);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(100, 20);
            this.txtInt.TabIndex = 3;
            // 
            // frmCasting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.btnCasteoExplicito);
            this.Controls.Add(this.btnCastImplicito);
            this.Name = "frmCasting";
            this.Text = "Casteo (casting)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCastImplicito;
        private System.Windows.Forms.Button btnCasteoExplicito;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.TextBox txtInt;
    }
}

