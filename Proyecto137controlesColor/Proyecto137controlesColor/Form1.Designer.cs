namespace Proyecto137controlesColor
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
            this.selectorDeColor1 = new Proyecto137controlesColor.SelectorDeColor();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectorDeColor1
            // 
            this.selectorDeColor1.ColorSeleccionado = System.Drawing.Color.Black;
            this.selectorDeColor1.Location = new System.Drawing.Point(13, 13);
            this.selectorDeColor1.Name = "selectorDeColor1";
            this.selectorDeColor1.Size = new System.Drawing.Size(633, 150);
            this.selectorDeColor1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Colorear botón";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 212);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectorDeColor1);
            this.Name = "Form1";
            this.Text = "R / G / B";
            this.ResumeLayout(false);

        }

        #endregion

        private SelectorDeColor selectorDeColor1;
        private System.Windows.Forms.Button button1;
    }
}

