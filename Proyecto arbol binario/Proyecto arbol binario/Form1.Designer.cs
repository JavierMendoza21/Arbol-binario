namespace Proyecto_arbol_binario
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exprecionAArbolBinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolBinarioExprecionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCambio = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelCambio.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionToolStripMenuItem
            // 
            this.opcionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exprecionAArbolBinarioToolStripMenuItem,
            this.arbolBinarioExprecionToolStripMenuItem});
            this.opcionToolStripMenuItem.Name = "opcionToolStripMenuItem";
            this.opcionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.opcionToolStripMenuItem.Text = "Opcion";
            // 
            // exprecionAArbolBinarioToolStripMenuItem
            // 
            this.exprecionAArbolBinarioToolStripMenuItem.Name = "exprecionAArbolBinarioToolStripMenuItem";
            this.exprecionAArbolBinarioToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.exprecionAArbolBinarioToolStripMenuItem.Text = "Exprecion ---> Arbol binario";
            this.exprecionAArbolBinarioToolStripMenuItem.Click += new System.EventHandler(this.exprecionAArbolBinarioToolStripMenuItem_Click);
            // 
            // arbolBinarioExprecionToolStripMenuItem
            // 
            this.arbolBinarioExprecionToolStripMenuItem.Name = "arbolBinarioExprecionToolStripMenuItem";
            this.arbolBinarioExprecionToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.arbolBinarioExprecionToolStripMenuItem.Text = "Arbol binario ---> Exprecion";
            this.arbolBinarioExprecionToolStripMenuItem.Click += new System.EventHandler(this.arbolBinarioExprecionToolStripMenuItem_Click);
            // 
            // panelCambio
            // 
            this.panelCambio.BackColor = System.Drawing.Color.Khaki;
            this.panelCambio.Controls.Add(this.label1);
            this.panelCambio.Controls.Add(this.label2);
            this.panelCambio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCambio.Location = new System.Drawing.Point(0, 24);
            this.panelCambio.Name = "panelCambio";
            this.panelCambio.Size = new System.Drawing.Size(933, 426);
            this.panelCambio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Instituto tecnologico superior de poza rica.";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 143);
            this.label2.TabIndex = 0;
            this.label2.Text = "\r\n\r\nAlumno : Javier Alexis Mendoza Garcia\r\nCarrera : ISC\r\nSemestre : 7 semestre\r\n" +
    "";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.panelCambio);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Arbol binario";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelCambio.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exprecionAArbolBinarioToolStripMenuItem;
        private System.Windows.Forms.Panel panelCambio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem arbolBinarioExprecionToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

