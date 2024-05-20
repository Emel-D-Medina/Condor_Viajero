namespace Condor_Viajero
{
    partial class Frm_Mapa
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
            this.dtGMisRutas = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtGRutasSiva = new System.Windows.Forms.DataGridView();
            this.LlegarBtn = new System.Windows.Forms.Button();
            this.dtGLugares = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLongitud = new System.Windows.Forms.TextBox();
            this.TxtLatitud = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.Mapa = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtGMisRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGRutasSiva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGLugares)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGMisRutas
            // 
            this.dtGMisRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGMisRutas.Location = new System.Drawing.Point(1004, 311);
            this.dtGMisRutas.Name = "dtGMisRutas";
            this.dtGMisRutas.RowHeadersWidth = 51;
            this.dtGMisRutas.RowTemplate.Height = 24;
            this.dtGMisRutas.Size = new System.Drawing.Size(179, 254);
            this.dtGMisRutas.TabIndex = 72;
            this.dtGMisRutas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGMisRutas_CellContentClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnGuardar.Location = new System.Drawing.Point(998, 572);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(192, 52);
            this.btnGuardar.TabIndex = 71;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(635, 93);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(556, 22);
            this.TxtDescripcion.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 673);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 69;
            this.label5.Text = "Distancia Minima";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(757, 667);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 22);
            this.textBox1.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 460);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 67;
            this.label4.Text = "Ruta SIVA";
            // 
            // dtGRutasSiva
            // 
            this.dtGRutasSiva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGRutasSiva.Location = new System.Drawing.Point(638, 496);
            this.dtGRutasSiva.Margin = new System.Windows.Forms.Padding(4);
            this.dtGRutasSiva.Name = "dtGRutasSiva";
            this.dtGRutasSiva.ReadOnly = true;
            this.dtGRutasSiva.RowHeadersWidth = 51;
            this.dtGRutasSiva.RowTemplate.Height = 24;
            this.dtGRutasSiva.Size = new System.Drawing.Size(292, 128);
            this.dtGRutasSiva.TabIndex = 66;
            this.dtGRutasSiva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosRutaSiva_CellContentClick);
            // 
            // LlegarBtn
            // 
            this.LlegarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LlegarBtn.Location = new System.Drawing.Point(1004, 236);
            this.LlegarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LlegarBtn.Name = "LlegarBtn";
            this.LlegarBtn.Size = new System.Drawing.Size(179, 60);
            this.LlegarBtn.TabIndex = 65;
            this.LlegarBtn.Text = "Como LLEGAR";
            this.LlegarBtn.UseVisualStyleBackColor = false;
            this.LlegarBtn.Click += new System.EventHandler(this.LlegarBtn_Click);
            // 
            // dtGLugares
            // 
            this.dtGLugares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGLugares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGLugares.Location = new System.Drawing.Point(636, 311);
            this.dtGLugares.Margin = new System.Windows.Forms.Padding(4);
            this.dtGLugares.Name = "dtGLugares";
            this.dtGLugares.ReadOnly = true;
            this.dtGLugares.RowHeadersWidth = 51;
            this.dtGLugares.RowTemplate.Height = 24;
            this.dtGLugares.Size = new System.Drawing.Size(294, 130);
            this.dtGLugares.TabIndex = 64;
            this.dtGLugares.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLugares_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(632, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Longitud";
            // 
            // TxtLongitud
            // 
            this.TxtLongitud.Location = new System.Drawing.Point(631, 202);
            this.TxtLongitud.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLongitud.Name = "TxtLongitud";
            this.TxtLongitud.Size = new System.Drawing.Size(559, 22);
            this.TxtLongitud.TabIndex = 62;
            // 
            // TxtLatitud
            // 
            this.TxtLatitud.Location = new System.Drawing.Point(635, 147);
            this.TxtLatitud.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLatitud.Name = "TxtLatitud";
            this.TxtLatitud.Size = new System.Drawing.Size(555, 22);
            this.TxtLatitud.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "Latitud";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "Descripcion";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnAgregar.Location = new System.Drawing.Point(631, 236);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(179, 60);
            this.BtnAgregar.TabIndex = 58;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.BtnEliminar.Location = new System.Drawing.Point(818, 236);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(179, 60);
            this.BtnEliminar.TabIndex = 57;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // Mapa
            // 
            this.Mapa.Bearing = 0F;
            this.Mapa.CanDragMap = true;
            this.Mapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.Mapa.GrayScaleMode = false;
            this.Mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Mapa.LevelsKeepInMemory = 5;
            this.Mapa.Location = new System.Drawing.Point(43, 46);
            this.Mapa.Margin = new System.Windows.Forms.Padding(4);
            this.Mapa.MarkersEnabled = true;
            this.Mapa.MaxZoom = 2;
            this.Mapa.MinZoom = 2;
            this.Mapa.MouseWheelZoomEnabled = true;
            this.Mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Mapa.Name = "Mapa";
            this.Mapa.NegativeMode = false;
            this.Mapa.PolygonsEnabled = true;
            this.Mapa.RetryLoadTile = 0;
            this.Mapa.RoutesEnabled = true;
            this.Mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Mapa.ShowTileGridLines = false;
            this.Mapa.Size = new System.Drawing.Size(567, 664);
            this.Mapa.TabIndex = 56;
            this.Mapa.Zoom = 0D;
            this.Mapa.Load += new System.EventHandler(this.Mapa_Load);
            this.Mapa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Mapa_MouseDoubleClick);
            // 
            // Frm_Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 759);
            this.Controls.Add(this.dtGMisRutas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtGRutasSiva);
            this.Controls.Add(this.LlegarBtn);
            this.Controls.Add(this.dtGLugares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtLongitud);
            this.Controls.Add(this.TxtLatitud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.Mapa);
            this.Name = "Frm_Mapa";
            this.Text = "Frm_Mapa";
            ((System.ComponentModel.ISupportInitialize)(this.dtGMisRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGRutasSiva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGLugares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGMisRutas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtGRutasSiva;
        private System.Windows.Forms.Button LlegarBtn;
        private System.Windows.Forms.DataGridView dtGLugares;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtLongitud;
        private System.Windows.Forms.TextBox TxtLatitud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private GMap.NET.WindowsForms.GMapControl Mapa;
    }
}