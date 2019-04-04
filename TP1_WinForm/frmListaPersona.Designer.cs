namespace TP1_WinForm
{
    partial class frmListaPersona
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtOtro = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rbnMasculino = new System.Windows.Forms.RadioButton();
            this.gbxEstiloMusical = new System.Windows.Forms.GroupBox();
            this.chkClasica = new System.Windows.Forms.CheckBox();
            this.chkElectronica = new System.Windows.Forms.CheckBox();
            this.chkReggaeton = new System.Windows.Forms.CheckBox();
            this.chkReggae = new System.Windows.Forms.CheckBox();
            this.chkCumbia = new System.Windows.Forms.CheckBox();
            this.chkRock = new System.Windows.Forms.CheckBox();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lbFechaNac = new System.Windows.Forms.Label();
            this.lblColoroFavorito = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblEdadEtq = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.gbxSexo.SuspendLayout();
            this.gbxEstiloMusical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(194, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(113, 62);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(194, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(113, 87);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(113, 20);
            this.dtpFechaNac.TabIndex = 2;
            this.dtpFechaNac.ValueChanged += new System.EventHandler(this.dtpFechaNac_ValueChanged);
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtOtro);
            this.gbxSexo.Controls.Add(this.rdbFemenino);
            this.gbxSexo.Controls.Add(this.rbnMasculino);
            this.gbxSexo.Location = new System.Drawing.Point(25, 127);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(346, 44);
            this.gbxSexo.TabIndex = 3;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtOtro
            // 
            this.rbtOtro.AutoSize = true;
            this.rbtOtro.Location = new System.Drawing.Point(275, 16);
            this.rbtOtro.Name = "rbtOtro";
            this.rbtOtro.Size = new System.Drawing.Size(45, 17);
            this.rbtOtro.TabIndex = 2;
            this.rbtOtro.TabStop = true;
            this.rbtOtro.Text = "Otro";
            this.rbtOtro.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(135, 16);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbnMasculino
            // 
            this.rbnMasculino.AutoSize = true;
            this.rbnMasculino.Location = new System.Drawing.Point(6, 16);
            this.rbnMasculino.Name = "rbnMasculino";
            this.rbnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbnMasculino.TabIndex = 0;
            this.rbnMasculino.TabStop = true;
            this.rbnMasculino.Text = "Masculino";
            this.rbnMasculino.UseVisualStyleBackColor = true;
            // 
            // gbxEstiloMusical
            // 
            this.gbxEstiloMusical.Controls.Add(this.chkClasica);
            this.gbxEstiloMusical.Controls.Add(this.chkElectronica);
            this.gbxEstiloMusical.Controls.Add(this.chkReggaeton);
            this.gbxEstiloMusical.Controls.Add(this.chkReggae);
            this.gbxEstiloMusical.Controls.Add(this.chkCumbia);
            this.gbxEstiloMusical.Controls.Add(this.chkRock);
            this.gbxEstiloMusical.Location = new System.Drawing.Point(25, 177);
            this.gbxEstiloMusical.Name = "gbxEstiloMusical";
            this.gbxEstiloMusical.Size = new System.Drawing.Size(345, 95);
            this.gbxEstiloMusical.TabIndex = 4;
            this.gbxEstiloMusical.TabStop = false;
            this.gbxEstiloMusical.Text = "Estilo Musical";
            // 
            // chkClasica
            // 
            this.chkClasica.AutoSize = true;
            this.chkClasica.Location = new System.Drawing.Point(241, 60);
            this.chkClasica.Name = "chkClasica";
            this.chkClasica.Size = new System.Drawing.Size(60, 17);
            this.chkClasica.TabIndex = 5;
            this.chkClasica.Text = "Clasica";
            this.chkClasica.UseVisualStyleBackColor = true;
            // 
            // chkElectronica
            // 
            this.chkElectronica.AutoSize = true;
            this.chkElectronica.Location = new System.Drawing.Point(241, 24);
            this.chkElectronica.Name = "chkElectronica";
            this.chkElectronica.Size = new System.Drawing.Size(79, 17);
            this.chkElectronica.TabIndex = 4;
            this.chkElectronica.Text = "Electronica";
            this.chkElectronica.UseVisualStyleBackColor = true;
            // 
            // chkReggaeton
            // 
            this.chkReggaeton.AutoSize = true;
            this.chkReggaeton.Location = new System.Drawing.Point(122, 60);
            this.chkReggaeton.Name = "chkReggaeton";
            this.chkReggaeton.Size = new System.Drawing.Size(79, 17);
            this.chkReggaeton.TabIndex = 3;
            this.chkReggaeton.Text = "Reggaeton";
            this.chkReggaeton.UseVisualStyleBackColor = true;
            // 
            // chkReggae
            // 
            this.chkReggae.AutoSize = true;
            this.chkReggae.Location = new System.Drawing.Point(122, 24);
            this.chkReggae.Name = "chkReggae";
            this.chkReggae.Size = new System.Drawing.Size(64, 17);
            this.chkReggae.TabIndex = 2;
            this.chkReggae.Text = "Reggae";
            this.chkReggae.UseVisualStyleBackColor = true;
            // 
            // chkCumbia
            // 
            this.chkCumbia.AutoSize = true;
            this.chkCumbia.Location = new System.Drawing.Point(6, 60);
            this.chkCumbia.Name = "chkCumbia";
            this.chkCumbia.Size = new System.Drawing.Size(61, 17);
            this.chkCumbia.TabIndex = 1;
            this.chkCumbia.Text = "Cumbia";
            this.chkCumbia.UseVisualStyleBackColor = true;
            // 
            // chkRock
            // 
            this.chkRock.AutoSize = true;
            this.chkRock.Location = new System.Drawing.Point(6, 24);
            this.chkRock.Name = "chkRock";
            this.chkRock.Size = new System.Drawing.Size(52, 17);
            this.chkRock.TabIndex = 0;
            this.chkRock.Text = "Rock";
            this.chkRock.UseVisualStyleBackColor = true;
            // 
            // cbxColor
            // 
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(132, 291);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(194, 21);
            this.cbxColor.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(57, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(60, 62);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            // 
            // lbFechaNac
            // 
            this.lbFechaNac.AutoSize = true;
            this.lbFechaNac.Location = new System.Drawing.Point(12, 91);
            this.lbFechaNac.Name = "lbFechaNac";
            this.lbFechaNac.Size = new System.Drawing.Size(93, 13);
            this.lbFechaNac.TabIndex = 8;
            this.lbFechaNac.Text = "Fecha Nacimiento";
            // 
            // lblColoroFavorito
            // 
            this.lblColoroFavorito.AutoSize = true;
            this.lblColoroFavorito.Location = new System.Drawing.Point(51, 294);
            this.lblColoroFavorito.Name = "lblColoroFavorito";
            this.lblColoroFavorito.Size = new System.Drawing.Size(75, 13);
            this.lblColoroFavorito.TabIndex = 9;
            this.lblColoroFavorito.Text = "Color Favorito:";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(377, 36);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(518, 276);
            this.dgvLista.TabIndex = 10;
            this.dgvLista.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLista_RowHeaderMouseClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(82, 333);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(205, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(512, 333);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(674, 333);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblEdadEtq
            // 
            this.lblEdadEtq.AutoSize = true;
            this.lblEdadEtq.Location = new System.Drawing.Point(253, 91);
            this.lblEdadEtq.Name = "lblEdadEtq";
            this.lblEdadEtq.Size = new System.Drawing.Size(32, 13);
            this.lblEdadEtq.TabIndex = 15;
            this.lblEdadEtq.Text = "Edad";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(291, 91);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(0, 13);
            this.lblEdad.TabIndex = 16;
            // 
            // frmListaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 440);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblEdadEtq);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.lblColoroFavorito);
            this.Controls.Add(this.lbFechaNac);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.gbxEstiloMusical);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaPersona";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaPersona";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.gbxEstiloMusical.ResumeLayout(false);
            this.gbxEstiloMusical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtOtro;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rbnMasculino;
        private System.Windows.Forms.GroupBox gbxEstiloMusical;
        private System.Windows.Forms.CheckBox chkClasica;
        private System.Windows.Forms.CheckBox chkElectronica;
        private System.Windows.Forms.CheckBox chkReggaeton;
        private System.Windows.Forms.CheckBox chkReggae;
        private System.Windows.Forms.CheckBox chkCumbia;
        private System.Windows.Forms.CheckBox chkRock;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lbFechaNac;
        private System.Windows.Forms.Label lblColoroFavorito;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblEdadEtq;
        private System.Windows.Forms.Label lblEdad;
    }
}