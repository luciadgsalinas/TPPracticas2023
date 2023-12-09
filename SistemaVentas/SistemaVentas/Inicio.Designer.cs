﻿using CapaEntidad;

namespace SistemaVentas
{
    partial class Inicio

    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Menu = new MenuStrip();
            MenuUsuario = new FontAwesome.Sharp.IconMenuItem();
            MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            btnRegistrarVenta = new FontAwesome.Sharp.IconMenuItem();
            btnVerDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            MenuCompras = new FontAwesome.Sharp.IconMenuItem();
            btnRegistrarCompra = new FontAwesome.Sharp.IconMenuItem();
            btnVerDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            MenuClientes = new FontAwesome.Sharp.IconMenuItem();
            MenuProveedores = new FontAwesome.Sharp.IconMenuItem();
            MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            MenuConfiguracion = new FontAwesome.Sharp.IconMenuItem();
            subCategoria = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            MenuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            subNegocio = new ToolStripMenuItem();
            MenuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            MenuTitulo = new MenuStrip();
            Contenedor = new Panel();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            lblUsuario = new Label();
            txtNUsuario = new Label();
            Menu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Dock = DockStyle.None;
            Menu.ImageScalingSize = new Size(20, 20);
            Menu.Items.AddRange(new ToolStripItem[] { MenuUsuario, MenuVentas, MenuCompras, MenuClientes, MenuProveedores, MenuReportes, MenuConfiguracion, MenuMantenedor, MenuAcercaDe });
            Menu.Location = new Point(0, 39);
            Menu.Name = "Menu";
            Menu.Padding = new Padding(5, 2, 0, 2);
            Menu.Size = new Size(977, 68);
            Menu.TabIndex = 0;
            Menu.Text = "menuStrip1";
            // 
            // MenuUsuario
            // 
            MenuUsuario.AutoSize = false;
            MenuUsuario.IconChar = FontAwesome.Sharp.IconChar.Users;
            MenuUsuario.IconColor = Color.Black;
            MenuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuUsuario.IconSize = 40;
            MenuUsuario.ImageScaling = ToolStripItemImageScaling.None;
            MenuUsuario.Name = "MenuUsuario";
            MenuUsuario.Size = new Size(100, 64);
            MenuUsuario.Text = "Usuarios";
            MenuUsuario.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuUsuario.Click += btnUsuarios_Click;
            // 
            // MenuVentas
            // 
            MenuVentas.AutoSize = false;
            MenuVentas.DropDownItems.AddRange(new ToolStripItem[] { btnRegistrarVenta, btnVerDetalleVenta });
            MenuVentas.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            MenuVentas.IconColor = Color.Black;
            MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuVentas.IconSize = 40;
            MenuVentas.ImageScaling = ToolStripItemImageScaling.None;
            MenuVentas.Name = "MenuVentas";
            MenuVentas.Size = new Size(100, 64);
            MenuVentas.Text = "Ventas";
            MenuVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRegistrarVenta.IconColor = Color.Black;
            btnRegistrarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(67, 22);
            // 
            // btnVerDetalleVenta
            // 
            btnVerDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            btnVerDetalleVenta.IconColor = Color.Black;
            btnVerDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerDetalleVenta.Name = "btnVerDetalleVenta";
            btnVerDetalleVenta.Size = new Size(67, 22);
            // 
            // MenuCompras
            // 
            MenuCompras.AutoSize = false;
            MenuCompras.DropDownItems.AddRange(new ToolStripItem[] { btnRegistrarCompra, btnVerDetalleCompra });
            MenuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            MenuCompras.IconColor = Color.Black;
            MenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuCompras.IconSize = 40;
            MenuCompras.ImageScaling = ToolStripItemImageScaling.None;
            MenuCompras.Name = "MenuCompras";
            MenuCompras.Size = new Size(100, 64);
            MenuCompras.Text = "Compras";
            MenuCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnRegistrarCompra
            // 
            btnRegistrarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRegistrarCompra.IconColor = Color.Black;
            btnRegistrarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarCompra.Name = "btnRegistrarCompra";
            btnRegistrarCompra.Size = new Size(184, 26);
            btnRegistrarCompra.Text = "Registrar";
            btnRegistrarCompra.Click += btnRegistrarCompra_Click;
            // 
            // btnVerDetalleCompra
            // 
            btnVerDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            btnVerDetalleCompra.IconColor = Color.Black;
            btnVerDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerDetalleCompra.Name = "btnVerDetalleCompra";
            btnVerDetalleCompra.Size = new Size(184, 26);
            btnVerDetalleCompra.Text = "Ver Detalle";
            btnVerDetalleCompra.Click += btnVerDetalleCompra_Click;
            // 
            // MenuClientes
            // 
            MenuClientes.AutoSize = false;
            MenuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            MenuClientes.IconColor = Color.Black;
            MenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuClientes.IconSize = 40;
            MenuClientes.ImageScaling = ToolStripItemImageScaling.None;
            MenuClientes.Name = "MenuClientes";
            MenuClientes.Size = new Size(100, 64);
            MenuClientes.Text = "Clientes";
            MenuClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuClientes.Click += MenuClientes_Click;
            // 
            // MenuProveedores
            // 
            MenuProveedores.AutoSize = false;
            MenuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            MenuProveedores.IconColor = Color.Black;
            MenuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuProveedores.IconSize = 40;
            MenuProveedores.ImageScaling = ToolStripItemImageScaling.None;
            MenuProveedores.Name = "MenuProveedores";
            MenuProveedores.Size = new Size(100, 64);
            MenuProveedores.Text = "Proveedores";
            MenuProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuProveedores.Click += MenuProveedores_Click;
            // 
            // MenuReportes
            // 
            MenuReportes.AutoSize = false;
            MenuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            MenuReportes.IconColor = Color.Black;
            MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuReportes.IconSize = 40;
            MenuReportes.ImageScaling = ToolStripItemImageScaling.None;
            MenuReportes.Name = "MenuReportes";
            MenuReportes.Size = new Size(100, 64);
            MenuReportes.Text = "Reportes";
            MenuReportes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // MenuConfiguracion
            // 
            MenuConfiguracion.AutoSize = false;
            MenuConfiguracion.DropDownItems.AddRange(new ToolStripItem[] { subCategoria, iconMenuItem2 });
            MenuConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Tools;
            MenuConfiguracion.IconColor = Color.Black;
            MenuConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuConfiguracion.IconSize = 40;
            MenuConfiguracion.ImageScaling = ToolStripItemImageScaling.None;
            MenuConfiguracion.Name = "MenuConfiguracion";
            MenuConfiguracion.Size = new Size(80, 64);
            MenuConfiguracion.Text = "Stock";
            MenuConfiguracion.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuConfiguracion.Click += MenuConfiguracion_Click;
            // 
            // subCategoria
            // 
            subCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            subCategoria.IconColor = Color.Black;
            subCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            subCategoria.Name = "subCategoria";
            subCategoria.Size = new Size(128, 22);
            subCategoria.Text = "Categoria";
            subCategoria.Click += subCategoria_Click;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(128, 22);
            iconMenuItem2.Text = "Productos";
            iconMenuItem2.Click += iconMenuItem2_Click;
            // 
            // MenuMantenedor
            // 
            MenuMantenedor.AutoSize = false;
            MenuMantenedor.DropDownItems.AddRange(new ToolStripItem[] { subNegocio });
            MenuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            MenuMantenedor.IconColor = Color.Black;
            MenuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuMantenedor.IconSize = 40;
            MenuMantenedor.ImageScaling = ToolStripItemImageScaling.None;
            MenuMantenedor.Name = "MenuMantenedor";
            MenuMantenedor.Size = new Size(90, 64);
            MenuMantenedor.Text = "Mantenedor";
            MenuMantenedor.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuMantenedor.Click += btnMantenedor_Click;
            // 
            // subNegocio
            // 
            subNegocio.Name = "subNegocio";
            subNegocio.Size = new Size(119, 22);
            subNegocio.Text = "Negocio";
            subNegocio.Click += subNegocio_Click;
            // 
            // MenuAcercaDe
            // 
            MenuAcercaDe.AutoSize = false;
            MenuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            MenuAcercaDe.IconColor = Color.Black;
            MenuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuAcercaDe.IconSize = 40;
            MenuAcercaDe.ImageScaling = ToolStripItemImageScaling.None;
            MenuAcercaDe.Name = "MenuAcercaDe";
            MenuAcercaDe.Size = new Size(80, 64);
            MenuAcercaDe.Text = "Acerca de";
            MenuAcercaDe.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // MenuTitulo
            // 
            MenuTitulo.AutoSize = false;
            MenuTitulo.BackColor = Color.DarkOrange;
            MenuTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MenuTitulo.ImageScalingSize = new Size(20, 20);
            MenuTitulo.Location = new Point(0, 0);
            MenuTitulo.Name = "MenuTitulo";
            MenuTitulo.Padding = new Padding(5, 2, 0, 2);
            MenuTitulo.RightToLeft = RightToLeft.Yes;
            MenuTitulo.Size = new Size(1366, 23);
            MenuTitulo.TabIndex = 1;
            MenuTitulo.Text = "SistemaVentas";
            // 
            // Contenedor
            // 
            Contenedor.Location = new Point(0, 109);
            Contenedor.Margin = new Padding(3, 2, 3, 2);
            Contenedor.Name = "Contenedor";
            Contenedor.Size = new Size(1355, 498);
            Contenedor.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 0;
            label1.Text = "Ferreteria Neyte";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(txtNUsuario);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MenuTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 37);
            panel1.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(582, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(80, 20);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "lblUsuario";
            // 
            // txtNUsuario
            // 
            txtNUsuario.AutoSize = true;
            txtNUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNUsuario.ForeColor = Color.White;
            txtNUsuario.Location = new Point(513, 9);
            txtNUsuario.Name = "txtNUsuario";
            txtNUsuario.Size = new Size(67, 20);
            txtNUsuario.TabIndex = 2;
            txtNUsuario.Text = "Usuario:";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 616);
            Controls.Add(panel1);
            Controls.Add(Contenedor);
            Controls.Add(Menu);
            MainMenuStrip = Menu;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Inicio_Load;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private FontAwesome.Sharp.IconMenuItem MenuAcercaDe;
        private MenuStrip MenuTitulo;
        private FontAwesome.Sharp.IconMenuItem MenuUsuario;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem MenuCompras;
        private FontAwesome.Sharp.IconMenuItem MenuClientes;
        private FontAwesome.Sharp.IconMenuItem MenuProveedores;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private FontAwesome.Sharp.IconMenuItem MenuConfiguracion;
        private Panel Contenedor;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private Label txtNUsuario;
        private Label lblUsuario;
        private FontAwesome.Sharp.IconMenuItem subCategoria;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem btnRegistrarVenta;
        private FontAwesome.Sharp.IconMenuItem btnVerDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem btnRegistrarCompra;
        private FontAwesome.Sharp.IconMenuItem btnVerDetalleCompra;
        private FontAwesome.Sharp.IconMenuItem MenuMantenedor;
        private ToolStripMenuItem subNegocio;
    }
}