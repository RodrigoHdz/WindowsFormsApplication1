namespace WindowsFormsApplication1.GUI.Menu
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_almacen = new System.Windows.Forms.Button();
            this.btn_proveedores = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.btn_sucursales = new System.Windows.Forms.Button();
            this.btn_usuario = new System.Windows.Forms.Button();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_pventa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 82);
            this.panel1.TabIndex = 8;
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Other_Power_Standby_Metro_icon;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(643, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(64, 64);
            this.btn_salir.TabIndex = 800;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 82);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.negrigoicono;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(643, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 64);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu principal";
            // 
            // btn_almacen
            // 
            this.btn_almacen.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Apps_RegEdit_Metro_icon;
            this.btn_almacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_almacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_almacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_almacen.Location = new System.Drawing.Point(570, 88);
            this.btn_almacen.Name = "btn_almacen";
            this.btn_almacen.Size = new System.Drawing.Size(96, 96);
            this.btn_almacen.TabIndex = 400;
            this.toolTip1.SetToolTip(this.btn_almacen, "Administrar almacenes");
            this.btn_almacen.UseVisualStyleBackColor = true;
            this.btn_almacen.Click += new System.EventHandler(this.btn_almacen_Click);
            // 
            // btn_proveedores
            // 
            this.btn_proveedores.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.truck_icon;
            this.btn_proveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_proveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proveedores.Location = new System.Drawing.Point(137, 217);
            this.btn_proveedores.Name = "btn_proveedores";
            this.btn_proveedores.Size = new System.Drawing.Size(96, 96);
            this.btn_proveedores.TabIndex = 500;
            this.toolTip1.SetToolTip(this.btn_proveedores, "Administrar proveedores");
            this.btn_proveedores.UseVisualStyleBackColor = true;
            this.btn_proveedores.Click += new System.EventHandler(this.btn_proveedores_Click);
            // 
            // btn_productos
            // 
            this.btn_productos.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Apps_Spaces_Metro_icon;
            this.btn_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productos.Location = new System.Drawing.Point(223, 88);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(96, 96);
            this.btn_productos.TabIndex = 200;
            this.toolTip1.SetToolTip(this.btn_productos, "Administrar productos");
            this.btn_productos.UseVisualStyleBackColor = true;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // btn_sucursales
            // 
            this.btn_sucursales.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Apps_Calendar_Metro_icon;
            this.btn_sucursales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sucursales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sucursales.Location = new System.Drawing.Point(311, 217);
            this.btn_sucursales.Name = "btn_sucursales";
            this.btn_sucursales.Size = new System.Drawing.Size(96, 96);
            this.btn_sucursales.TabIndex = 600;
            this.toolTip1.SetToolTip(this.btn_sucursales, "Administrar sucursales");
            this.btn_sucursales.UseVisualStyleBackColor = true;
            this.btn_sucursales.Click += new System.EventHandler(this.btn_sucursales_Click);
            // 
            // btn_usuario
            // 
            this.btn_usuario.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Web_myspace_alt_Metro_icon;
            this.btn_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuario.Location = new System.Drawing.Point(486, 217);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.Size = new System.Drawing.Size(96, 96);
            this.btn_usuario.TabIndex = 700;
            this.toolTip1.SetToolTip(this.btn_usuario, "Administrar usuarios");
            this.btn_usuario.UseVisualStyleBackColor = true;
            this.btn_usuario.Click += new System.EventHandler(this.btn_usuario_Click);
            // 
            // btn_clientes
            // 
            this.btn_clientes.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Web_Reddit_Metro_icon;
            this.btn_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientes.Location = new System.Drawing.Point(399, 88);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(96, 96);
            this.btn_clientes.TabIndex = 300;
            this.toolTip1.SetToolTip(this.btn_clientes, "Administrar clientes");
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // btn_pventa
            // 
            this.btn_pventa.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Apps_Calculator_Metro_icon;
            this.btn_pventa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pventa.Location = new System.Drawing.Point(51, 88);
            this.btn_pventa.Name = "btn_pventa";
            this.btn_pventa.Size = new System.Drawing.Size(96, 96);
            this.btn_pventa.TabIndex = 100;
            this.toolTip1.SetToolTip(this.btn_pventa, "Punto de venta");
            this.btn_pventa.UseVisualStyleBackColor = true;
            this.btn_pventa.Click += new System.EventHandler(this.btn_pventa_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelButton = this.btn_salir;
            this.ClientSize = new System.Drawing.Size(719, 401);
            this.ControlBox = false;
            this.Controls.Add(this.btn_almacen);
            this.Controls.Add(this.btn_proveedores);
            this.Controls.Add(this.btn_productos);
            this.Controls.Add(this.btn_sucursales);
            this.Controls.Add(this.btn_usuario);
            this.Controls.Add(this.btn_clientes);
            this.Controls.Add(this.btn_pventa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMenu";
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pventa;
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_usuario;
        private System.Windows.Forms.Button btn_sucursales;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Button btn_proveedores;
        private System.Windows.Forms.Button btn_almacen;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}