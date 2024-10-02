namespace Practica5_LedARDUINO
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
            this.lbl_Tittle = new System.Windows.Forms.Label();
            this.btn_On = new System.Windows.Forms.Button();
            this.btn_Off = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Tittle
            // 
            this.lbl_Tittle.AutoSize = true;
            this.lbl_Tittle.Location = new System.Drawing.Point(343, 51);
            this.lbl_Tittle.Name = "lbl_Tittle";
            this.lbl_Tittle.Size = new System.Drawing.Size(96, 13);
            this.lbl_Tittle.TabIndex = 0;
            this.lbl_Tittle.Text = "Control de Luz Led";
            // 
            // btn_On
            // 
            this.btn_On.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_On.Location = new System.Drawing.Point(243, 182);
            this.btn_On.Name = "btn_On";
            this.btn_On.Size = new System.Drawing.Size(101, 73);
            this.btn_On.TabIndex = 1;
            this.btn_On.Text = "On";
            this.btn_On.UseVisualStyleBackColor = false;
            this.btn_On.Click += new System.EventHandler(this.btn_On_Click);
            // 
            // btn_Off
            // 
            this.btn_Off.BackColor = System.Drawing.Color.Crimson;
            this.btn_Off.Location = new System.Drawing.Point(441, 182);
            this.btn_Off.Name = "btn_Off";
            this.btn_Off.Size = new System.Drawing.Size(101, 73);
            this.btn_Off.TabIndex = 2;
            this.btn_Off.Text = "Off";
            this.btn_Off.UseVisualStyleBackColor = false;
            this.btn_Off.Click += new System.EventHandler(this.btn_Off_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Off);
            this.Controls.Add(this.btn_On);
            this.Controls.Add(this.lbl_Tittle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Tittle;
        private System.Windows.Forms.Button btn_On;
        private System.Windows.Forms.Button btn_Off;
    }
}

