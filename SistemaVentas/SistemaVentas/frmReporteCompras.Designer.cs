﻿namespace CapaPresentacion
{
    partial class frmReporteCompras
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dtInicio = new DateTimePicker();
            lblRegistrar = new Label();
            label1 = new Label();
            lblFechaInicio = new Label();
            lblFechaFin = new Label();
            dtFechaFin = new DateTimePicker();
            lblProveedor = new Label();
            btnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            cbProveedor = new ComboBox();
            label2 = new Label();
            dgvData = new DataGridView();
            FechaRegistro = new DataGridViewTextBoxColumn();
            TipoDocumento = new DataGridViewTextBoxColumn();
            NumeroDocumento = new DataGridViewTextBoxColumn();
            MontoTotal = new DataGridViewTextBoxColumn();
            UsuarioRegistrado = new DataGridViewTextBoxColumn();
            DocumentoProveedor = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            CodigoProducto = new DataGridViewTextBoxColumn();
            NombreProducto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btnExcel = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnBusqueda = new FontAwesome.Sharp.IconButton();
            txtBusqueda = new TextBox();
            cbBusqueda = new ComboBox();
            lblBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // dtInicio
            // 
            dtInicio.CustomFormat = "dd/MM/yyyy";
            dtInicio.Format = DateTimePickerFormat.Short;
            dtInicio.Location = new Point(106, 61);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(125, 23);
            dtInicio.TabIndex = 0;
            dtInicio.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblRegistrar
            // 
            lblRegistrar.AutoSize = true;
            lblRegistrar.BackColor = SystemColors.Window;
            lblRegistrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistrar.Location = new Point(27, 22);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(195, 25);
            lblRegistrar.TabIndex = 46;
            lblRegistrar.Text = "Reporte de Compras";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1019, 96);
            label1.TabIndex = 45;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(27, 67);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(73, 15);
            lblFechaInicio.TabIndex = 47;
            lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(278, 65);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(60, 15);
            lblFechaFin.TabIndex = 49;
            lblFechaFin.Text = "Fecha Fin:";
            // 
            // dtFechaFin
            // 
            dtFechaFin.CustomFormat = "dd/MM/yyyy";
            dtFechaFin.Format = DateTimePickerFormat.Short;
            dtFechaFin.Location = new Point(357, 59);
            dtFechaFin.Name = "dtFechaFin";
            dtFechaFin.Size = new Size(125, 23);
            dtFechaFin.TabIndex = 48;
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(505, 63);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(64, 15);
            lblProveedor.TabIndex = 51;
            lblProveedor.Text = "Proveedor:";
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.BackColor = Color.White;
            btnBuscarProveedor.Cursor = Cursors.Hand;
            btnBuscarProveedor.FlatAppearance.BorderColor = Color.Black;
            btnBuscarProveedor.FlatStyle = FlatStyle.Flat;
            btnBuscarProveedor.ForeColor = Color.Black;
            btnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarProveedor.IconColor = Color.Black;
            btnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarProveedor.IconSize = 15;
            btnBuscarProveedor.Location = new Point(777, 61);
            btnBuscarProveedor.Margin = new Padding(3, 2, 3, 2);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(77, 24);
            btnBuscarProveedor.TabIndex = 50;
            btnBuscarProveedor.Text = "Buscar ";
            btnBuscarProveedor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscarProveedor.UseVisualStyleBackColor = false;
            btnBuscarProveedor.Click += btnBuscarProveedor_Click;
            // 
            // cbProveedor
            // 
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(575, 59);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(196, 23);
            cbProveedor.TabIndex = 52;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(12, 116);
            label2.Name = "label2";
            label2.Size = new Size(1019, 502);
            label2.TabIndex = 53;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { FechaRegistro, TipoDocumento, NumeroDocumento, MontoTotal, UsuarioRegistrado, DocumentoProveedor, RazonSocial, CodigoProducto, NombreProducto, Categoria, PrecioCompra, PrecioVenta, Cantidad, SubTotal });
            dgvData.GridColor = Color.White;
            dgvData.Location = new Point(27, 174);
            dgvData.Margin = new Padding(3, 2, 3, 2);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 28;
            dgvData.Size = new Size(991, 409);
            dgvData.TabIndex = 54;
            // 
            // FechaRegistro
            // 
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.MinimumWidth = 6;
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.ReadOnly = true;
            FechaRegistro.Width = 125;
            // 
            // TipoDocumento
            // 
            TipoDocumento.HeaderText = "TipoDocumento";
            TipoDocumento.MinimumWidth = 6;
            TipoDocumento.Name = "TipoDocumento";
            TipoDocumento.ReadOnly = true;
            TipoDocumento.Width = 150;
            // 
            // NumeroDocumento
            // 
            NumeroDocumento.HeaderText = "Numero Documento";
            NumeroDocumento.MinimumWidth = 6;
            NumeroDocumento.Name = "NumeroDocumento";
            NumeroDocumento.ReadOnly = true;
            NumeroDocumento.Width = 150;
            // 
            // MontoTotal
            // 
            MontoTotal.HeaderText = "Monto Total";
            MontoTotal.MinimumWidth = 6;
            MontoTotal.Name = "MontoTotal";
            MontoTotal.ReadOnly = true;
            MontoTotal.Width = 125;
            // 
            // UsuarioRegistrado
            // 
            UsuarioRegistrado.HeaderText = "Usuario Registrado";
            UsuarioRegistrado.Name = "UsuarioRegistrado";
            UsuarioRegistrado.ReadOnly = true;
            // 
            // DocumentoProveedor
            // 
            DocumentoProveedor.HeaderText = "Documento Proveedor";
            DocumentoProveedor.Name = "DocumentoProveedor";
            DocumentoProveedor.ReadOnly = true;
            // 
            // RazonSocial
            // 
            RazonSocial.HeaderText = "Razon Social";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
            // 
            // CodigoProducto
            // 
            CodigoProducto.HeaderText = "Codigo Producto";
            CodigoProducto.Name = "CodigoProducto";
            CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            NombreProducto.HeaderText = "Nombre Producto";
            NombreProducto.Name = "NombreProducto";
            NombreProducto.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "PrecioVenta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "Sub Total";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.White;
            btnExcel.Cursor = Cursors.Hand;
            btnExcel.FlatAppearance.BorderColor = Color.Black;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcel.ForeColor = Color.Black;
            btnExcel.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnExcel.IconColor = Color.Black;
            btnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExcel.IconSize = 27;
            btnExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcel.Location = new Point(27, 131);
            btnExcel.Margin = new Padding(3, 2, 3, 2);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(172, 22);
            btnExcel.TabIndex = 60;
            btnExcel.Text = "Descargar Excel";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderColor = Color.Black;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 27;
            btnLimpiar.Location = new Point(980, 131);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(38, 22);
            btnLimpiar.TabIndex = 59;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBusqueda
            // 
            btnBusqueda.BackColor = Color.White;
            btnBusqueda.Cursor = Cursors.Hand;
            btnBusqueda.FlatAppearance.BorderColor = Color.Black;
            btnBusqueda.FlatStyle = FlatStyle.Flat;
            btnBusqueda.ForeColor = Color.White;
            btnBusqueda.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBusqueda.IconColor = Color.Black;
            btnBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBusqueda.IconSize = 27;
            btnBusqueda.Location = new Point(931, 131);
            btnBusqueda.Margin = new Padding(3, 2, 3, 2);
            btnBusqueda.Name = "btnBusqueda";
            btnBusqueda.Size = new Size(43, 22);
            btnBusqueda.TabIndex = 58;
            btnBusqueda.UseVisualStyleBackColor = false;
            btnBusqueda.Click += btnBusqueda_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(750, 133);
            txtBusqueda.Margin = new Padding(3, 2, 3, 2);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(176, 23);
            txtBusqueda.TabIndex = 57;
            // 
            // cbBusqueda
            // 
            cbBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBusqueda.FormattingEnabled = true;
            cbBusqueda.Location = new Point(573, 133);
            cbBusqueda.Margin = new Padding(3, 2, 3, 2);
            cbBusqueda.Name = "cbBusqueda";
            cbBusqueda.Size = new Size(172, 23);
            cbBusqueda.TabIndex = 56;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = Color.White;
            lblBuscar.Location = new Point(496, 135);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(66, 15);
            lblBuscar.TabIndex = 55;
            lblBuscar.Text = "Buscar por:";
            // 
            // frmReporteCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 644);
            Controls.Add(btnExcel);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBusqueda);
            Controls.Add(txtBusqueda);
            Controls.Add(cbBusqueda);
            Controls.Add(lblBuscar);
            Controls.Add(dgvData);
            Controls.Add(label2);
            Controls.Add(cbProveedor);
            Controls.Add(lblProveedor);
            Controls.Add(btnBuscarProveedor);
            Controls.Add(lblFechaFin);
            Controls.Add(dtFechaFin);
            Controls.Add(lblFechaInicio);
            Controls.Add(lblRegistrar);
            Controls.Add(dtInicio);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmReporteCompras";
            Text = "frmReporteCompras";
            Load += frmReporteCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtInicio;
        private Label lblRegistrar;
        private Label label1;
        private Label lblFechaInicio;
        private Label lblFechaFin;
        private DateTimePicker dtFechaFin;
        private Label lblProveedor;
        private FontAwesome.Sharp.IconButton btnBuscarProveedor;
        private ComboBox cbProveedor;
        private Label label2;
        private DataGridView dgvData;
        private FontAwesome.Sharp.IconButton btnExcel;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBusqueda;
        private TextBox txtBusqueda;
        private ComboBox cbBusqueda;
        private Label lblBuscar;
        private DataGridViewTextBoxColumn FechaRegistro;
        private DataGridViewTextBoxColumn TipoDocumento;
        private DataGridViewTextBoxColumn NumeroDocumento;
        private DataGridViewTextBoxColumn MontoTotal;
        private DataGridViewTextBoxColumn UsuarioRegistrado;
        private DataGridViewTextBoxColumn DocumentoProveedor;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn CodigoProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
    }
}