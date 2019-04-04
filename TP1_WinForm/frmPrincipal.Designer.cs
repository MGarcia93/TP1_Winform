namespace TP1_WinForm
{
    partial class FrmPrincipal
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
            this.accionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDePersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeObjetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accionesToolStripMenuItem
            // 
            this.accionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDePersonaToolStripMenuItem,
            this.listadoDeObjetosToolStripMenuItem});
            this.accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            this.accionesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accionesToolStripMenuItem.Text = "Acciones";
            // 
            // listadoDePersonaToolStripMenuItem
            // 
            this.listadoDePersonaToolStripMenuItem.Name = "listadoDePersonaToolStripMenuItem";
            this.listadoDePersonaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoDePersonaToolStripMenuItem.Text = "Listado de &Persona";
            this.listadoDePersonaToolStripMenuItem.Click += new System.EventHandler(this.listadoDePersonaToolStripMenuItem_Click);
            // 
            // listadoDeObjetosToolStripMenuItem
            // 
            this.listadoDeObjetosToolStripMenuItem.Name = "listadoDeObjetosToolStripMenuItem";
            this.listadoDeObjetosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoDeObjetosToolStripMenuItem.Text = "Listado de &Objetos";
            this.listadoDeObjetosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeObjetosToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 471);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TP 1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDePersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeObjetosToolStripMenuItem;
    }
}

