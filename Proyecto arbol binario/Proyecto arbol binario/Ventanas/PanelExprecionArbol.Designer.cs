namespace Proyecto_arbol_binario.Ventanas
{
    partial class PanelExprecionArbol
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtExprecion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDibujo = new System.Windows.Forms.Panel();
            this.horizontal = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1.SuspendLayout();
            this.panelDibujo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtExprecion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 69);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(363, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular arbol.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtExprecion
            // 
            this.txtExprecion.Location = new System.Drawing.Point(205, 25);
            this.txtExprecion.Name = "txtExprecion";
            this.txtExprecion.Size = new System.Drawing.Size(152, 20);
            this.txtExprecion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa la exprecion:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDibujo
            // 
            this.panelDibujo.BackColor = System.Drawing.Color.FloralWhite;
            this.panelDibujo.Controls.Add(this.horizontal);
            this.panelDibujo.Controls.Add(this.vScrollBar1);
            this.panelDibujo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDibujo.Location = new System.Drawing.Point(0, 69);
            this.panelDibujo.Name = "panelDibujo";
            this.panelDibujo.Size = new System.Drawing.Size(884, 418);
            this.panelDibujo.TabIndex = 1;
            this.panelDibujo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDibujo_Paint);
            // 
            // horizontal
            // 
            this.horizontal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horizontal.Location = new System.Drawing.Point(0, 401);
            this.horizontal.Maximum = 500;
            this.horizontal.Minimum = 100;
            this.horizontal.Name = "horizontal";
            this.horizontal.Size = new System.Drawing.Size(867, 17);
            this.horizontal.TabIndex = 1;
            this.horizontal.Value = 100;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(867, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 418);
            this.vScrollBar1.TabIndex = 0;
            // 
            // PanelExprecionArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 487);
            this.Controls.Add(this.panelDibujo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelExprecionArbol";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDibujo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtExprecion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDibujo;
        private System.Windows.Forms.HScrollBar horizontal;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}
