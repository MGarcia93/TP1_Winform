namespace TP1_WinForm
{
    partial class frmListaObjeto
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
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNuevoObjeto = new System.Windows.Forms.Label();
            this.lbxIzquierda = new System.Windows.Forms.ListBox();
            this.lbxDereacha = new System.Windows.Forms.ListBox();
            this.btnEnviarTodos = new System.Windows.Forms.Button();
            this.btnEnviarUno = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblCantidadResgistoI = new System.Windows.Forms.Label();
            this.lblCntIzq = new System.Windows.Forms.Label();
            this.lblCntDer = new System.Windows.Forms.Label();
            this.lblCantidadRegistroD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNuevo
            // 
            this.txtNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevo.Location = new System.Drawing.Point(150, 33);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.Size = new System.Drawing.Size(137, 22);
            this.txtNuevo.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(293, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 31);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNuevoObjeto
            // 
            this.lblNuevoObjeto.AutoSize = true;
            this.lblNuevoObjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoObjeto.Location = new System.Drawing.Point(56, 37);
            this.lblNuevoObjeto.Name = "lblNuevoObjeto";
            this.lblNuevoObjeto.Size = new System.Drawing.Size(94, 16);
            this.lblNuevoObjeto.TabIndex = 2;
            this.lblNuevoObjeto.Text = "Nuevo Objeto:";
            // 
            // lbxIzquierda
            // 
            this.lbxIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxIzquierda.FormattingEnabled = true;
            this.lbxIzquierda.ItemHeight = 24;
            this.lbxIzquierda.Location = new System.Drawing.Point(29, 69);
            this.lbxIzquierda.Name = "lbxIzquierda";
            this.lbxIzquierda.Size = new System.Drawing.Size(359, 268);
            this.lbxIzquierda.TabIndex = 3;
            // 
            // lbxDereacha
            // 
            this.lbxDereacha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDereacha.FormattingEnabled = true;
            this.lbxDereacha.ItemHeight = 24;
            this.lbxDereacha.Location = new System.Drawing.Point(467, 69);
            this.lbxDereacha.Name = "lbxDereacha";
            this.lbxDereacha.Size = new System.Drawing.Size(350, 268);
            this.lbxDereacha.TabIndex = 4;
            // 
            // btnEnviarTodos
            // 
            this.btnEnviarTodos.Location = new System.Drawing.Point(414, 135);
            this.btnEnviarTodos.Name = "btnEnviarTodos";
            this.btnEnviarTodos.Size = new System.Drawing.Size(28, 28);
            this.btnEnviarTodos.TabIndex = 5;
            this.btnEnviarTodos.Text = ">>";
            this.btnEnviarTodos.UseVisualStyleBackColor = true;
            this.btnEnviarTodos.Click += new System.EventHandler(this.btnEnviarTodos_Click);
            // 
            // btnEnviarUno
            // 
            this.btnEnviarUno.Location = new System.Drawing.Point(414, 169);
            this.btnEnviarUno.Name = "btnEnviarUno";
            this.btnEnviarUno.Size = new System.Drawing.Size(28, 28);
            this.btnEnviarUno.TabIndex = 6;
            this.btnEnviarUno.Text = ">";
            this.btnEnviarUno.UseVisualStyleBackColor = true;
            this.btnEnviarUno.Click += new System.EventHandler(this.btnEnviarUno_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(414, 203);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(28, 28);
            this.btnDevolver.TabIndex = 7;
            this.btnDevolver.Text = "<";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(414, 237);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(28, 28);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "...";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblCantidadResgistoI
            // 
            this.lblCantidadResgistoI.AutoSize = true;
            this.lblCantidadResgistoI.Location = new System.Drawing.Point(26, 353);
            this.lblCantidadResgistoI.Name = "lblCantidadResgistoI";
            this.lblCantidadResgistoI.Size = new System.Drawing.Size(109, 13);
            this.lblCantidadResgistoI.TabIndex = 9;
            this.lblCantidadResgistoI.Text = "Cantidad de Registro:";
            // 
            // lblCntIzq
            // 
            this.lblCntIzq.AutoSize = true;
            this.lblCntIzq.Location = new System.Drawing.Point(142, 353);
            this.lblCntIzq.Name = "lblCntIzq";
            this.lblCntIzq.Size = new System.Drawing.Size(13, 13);
            this.lblCntIzq.TabIndex = 10;
            this.lblCntIzq.Text = "0";
            // 
            // lblCntDer
            // 
            this.lblCntDer.AutoSize = true;
            this.lblCntDer.Location = new System.Drawing.Point(580, 353);
            this.lblCntDer.Name = "lblCntDer";
            this.lblCntDer.Size = new System.Drawing.Size(13, 13);
            this.lblCntDer.TabIndex = 12;
            this.lblCntDer.Text = "0";
            // 
            // lblCantidadRegistroD
            // 
            this.lblCantidadRegistroD.AutoSize = true;
            this.lblCantidadRegistroD.Location = new System.Drawing.Point(464, 353);
            this.lblCantidadRegistroD.Name = "lblCantidadRegistroD";
            this.lblCantidadRegistroD.Size = new System.Drawing.Size(109, 13);
            this.lblCantidadRegistroD.TabIndex = 11;
            this.lblCantidadRegistroD.Text = "Cantidad de Registro:";
            // 
            // frmListaObjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.lblCntDer);
            this.Controls.Add(this.lblCantidadRegistroD);
            this.Controls.Add(this.lblCntIzq);
            this.Controls.Add(this.lblCantidadResgistoI);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnEnviarUno);
            this.Controls.Add(this.btnEnviarTodos);
            this.Controls.Add(this.lbxDereacha);
            this.Controls.Add(this.lbxIzquierda);
            this.Controls.Add(this.lblNuevoObjeto);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaObjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaObjeto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNuevoObjeto;
        private System.Windows.Forms.ListBox lbxIzquierda;
        private System.Windows.Forms.ListBox lbxDereacha;
        private System.Windows.Forms.Button btnEnviarTodos;
        private System.Windows.Forms.Button btnEnviarUno;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblCantidadResgistoI;
        private System.Windows.Forms.Label lblCntIzq;
        private System.Windows.Forms.Label lblCntDer;
        private System.Windows.Forms.Label lblCantidadRegistroD;
    }
}