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
            this.dtMisRutas = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DatosRutaSiva = new System.Windows.Forms.DataGridView();
            this.LlegarBtn = new System.Windows.Forms.Button();
            this.dtLugares = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLongitud = new System.Windows.Forms.TextBox();
            this.TxtLatitud = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.Mapa = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtMisRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosRutaSiva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLugares)).BeginInit();
            this.SuspendLayout();
            // 
            // dtMisRutas
            // 
            this.dtMisRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMisRutas.Location = new System.Drawing.Point(753, 253);
            this.dtMisRutas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtMisRutas.Name = "dtMisRutas";
            this.dtMisRutas.RowHeadersWidth = 51;
            this.dtMisRutas.RowTemplate.Height = 24;
            this.dtMisRutas.Size = new System.Drawing.Size(134, 206);
            this.dtMisRutas.TabIndex = 72;
            this.dtMisRutas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMisRutas_CellClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnGuardar.Location = new System.Drawing.Point(748, 465);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(144, 42);
            this.btnGuardar.TabIndex = 71;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(476, 76);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(418, 20);
            this.TxtDescripcion.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 547);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Distancia Minima";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(568, 542);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Rutas SIVA";
            // 
            // DatosRutaSiva
            // 
            this.DatosRutaSiva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosRutaSiva.Location = new System.Drawing.Point(478, 403);
            this.DatosRutaSiva.Name = "DatosRutaSiva";
            this.DatosRutaSiva.ReadOnly = true;
            this.DatosRutaSiva.RowHeadersWidth = 51;
            this.DatosRutaSiva.RowTemplate.Height = 24;
            this.DatosRutaSiva.Size = new System.Drawing.Size(219, 104);
            this.DatosRutaSiva.TabIndex = 66;
            this.DatosRutaSiva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosRutaSiva_CellContentClick);
            // 
            // LlegarBtn
            // 
            this.LlegarBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LlegarBtn.Location = new System.Drawing.Point(753, 192);
            this.LlegarBtn.Name = "LlegarBtn";
            this.LlegarBtn.Size = new System.Drawing.Size(134, 49);
            this.LlegarBtn.TabIndex = 65;
            this.LlegarBtn.Text = "Como LLEGAR";
            this.LlegarBtn.UseVisualStyleBackColor = false;
            this.LlegarBtn.Click += new System.EventHandler(this.LlegarBtn_Click);
            // 
            // dtLugares
            // 
            this.dtLugares.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtLugares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLugares.Location = new System.Drawing.Point(477, 253);
            this.dtLugares.Name = "dtLugares";
            this.dtLugares.ReadOnly = true;
            this.dtLugares.RowHeadersWidth = 51;
            this.dtLugares.RowTemplate.Height = 24;
            this.dtLugares.Size = new System.Drawing.Size(220, 106);
            this.dtLugares.TabIndex = 64;
            this.dtLugares.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLugares_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Longitud";
            // 
            // TxtLongitud
            // 
            this.TxtLongitud.Location = new System.Drawing.Point(473, 164);
            this.TxtLongitud.Name = "TxtLongitud";
            this.TxtLongitud.Size = new System.Drawing.Size(420, 20);
            this.TxtLongitud.TabIndex = 62;
            // 
            // TxtLatitud
            // 
            this.TxtLatitud.Location = new System.Drawing.Point(476, 119);
            this.TxtLatitud.Name = "TxtLatitud";
            this.TxtLatitud.Size = new System.Drawing.Size(417, 20);
            this.TxtLatitud.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Latitud";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Descripcion";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.PaleGreen;
            this.BtnAgregar.Location = new System.Drawing.Point(473, 192);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(134, 49);
            this.BtnAgregar.TabIndex = 58;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.BtnEliminar.Location = new System.Drawing.Point(614, 192);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(134, 49);
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
            this.Mapa.Location = new System.Drawing.Point(32, 37);
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
            this.Mapa.Size = new System.Drawing.Size(425, 540);
            this.Mapa.TabIndex = 56;
            this.Mapa.Zoom = 0D;
            this.Mapa.Load += new System.EventHandler(this.Mapa_Load);
            this.Mapa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Mapa_MouseDoubleClick);
            // 
            // Frm_Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 609);
            this.Controls.Add(this.dtMisRutas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DatosRutaSiva);
            this.Controls.Add(this.LlegarBtn);
            this.Controls.Add(this.dtLugares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtLongitud);
            this.Controls.Add(this.TxtLatitud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.Mapa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Mapa";
            this.Text = "Frm_Mapa";
            ((System.ComponentModel.ISupportInitialize)(this.dtMisRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosRutaSiva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLugares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtMisRutas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DatosRutaSiva;
        private System.Windows.Forms.Button LlegarBtn;
        private System.Windows.Forms.DataGridView dtLugares;
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