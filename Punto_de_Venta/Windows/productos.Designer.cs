namespace Punto_de_Venta
{
    partial class productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productos));
            this.lblproductos = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bar_btn_ventas = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bar_btn_compras = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bar_btn_productos = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bar_btn_clientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_categoria = new System.Windows.Forms.ComboBox();
            this.tb_departamento = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lbldepartanamento = new System.Windows.Forms.Label();
            this.tbprecio_mayoreo = new System.Windows.Forms.TextBox();
            this.lblprecio_mayoreo = new System.Windows.Forms.Label();
            this.tbprecio_unidad = new System.Windows.Forms.TextBox();
            this.lblprecio_unidad = new System.Windows.Forms.Label();
            this.tbdescripcion = new System.Windows.Forms.TextBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.dt_producto1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.disponible = new System.Windows.Forms.Button();
            this.no_disponible = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtn_codigo = new System.Windows.Forms.RadioButton();
            this.rbtn_nombre = new System.Windows.Forms.RadioButton();
            this.tbbuscar = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_producto1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblproductos
            // 
            this.lblproductos.AutoSize = true;
            this.lblproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductos.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblproductos.Location = new System.Drawing.Point(62, 74);
            this.lblproductos.Name = "lblproductos";
            this.lblproductos.Size = new System.Drawing.Size(162, 37);
            this.lblproductos.TabIndex = 66;
            this.lblproductos.Text = "Productos";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Green;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Location = new System.Drawing.Point(50, 708);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(88, 33);
            this.btnguardar.TabIndex = 84;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Khaki;
            this.btncancelar.ForeColor = System.Drawing.Color.Black;
            this.btncancelar.Location = new System.Drawing.Point(171, 709);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(80, 33);
            this.btncancelar.TabIndex = 86;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bar_btn_ventas,
            this.toolStripLabel1,
            this.toolStripSeparator4,
            this.bar_btn_compras,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.bar_btn_productos,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.bar_btn_clientes,
            this.toolStripLabel4,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1858, 25);
            this.toolStrip1.TabIndex = 117;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bar_btn_ventas
            // 
            this.bar_btn_ventas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bar_btn_ventas.Image = ((System.Drawing.Image)(resources.GetObject("bar_btn_ventas.Image")));
            this.bar_btn_ventas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bar_btn_ventas.Name = "bar_btn_ventas";
            this.bar_btn_ventas.Size = new System.Drawing.Size(23, 22);
            this.bar_btn_ventas.Tag = "";
            this.bar_btn_ventas.Text = "Ventas";
            this.bar_btn_ventas.Click += new System.EventHandler(this.bar_btn_ventas_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel1.Text = "Ventas";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bar_btn_compras
            // 
            this.bar_btn_compras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bar_btn_compras.Image = ((System.Drawing.Image)(resources.GetObject("bar_btn_compras.Image")));
            this.bar_btn_compras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bar_btn_compras.Name = "bar_btn_compras";
            this.bar_btn_compras.Size = new System.Drawing.Size(23, 22);
            this.bar_btn_compras.Text = "toolStripButton1";
            this.bar_btn_compras.Click += new System.EventHandler(this.bar_btn_compras_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabel2.Text = "Compras";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bar_btn_productos
            // 
            this.bar_btn_productos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bar_btn_productos.Image = ((System.Drawing.Image)(resources.GetObject("bar_btn_productos.Image")));
            this.bar_btn_productos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bar_btn_productos.Name = "bar_btn_productos";
            this.bar_btn_productos.Size = new System.Drawing.Size(23, 22);
            this.bar_btn_productos.Click += new System.EventHandler(this.bar_btn_productos_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(61, 22);
            this.toolStripLabel3.Text = "Productos";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bar_btn_clientes
            // 
            this.bar_btn_clientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bar_btn_clientes.Image = ((System.Drawing.Image)(resources.GetObject("bar_btn_clientes.Image")));
            this.bar_btn_clientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bar_btn_clientes.Name = "bar_btn_clientes";
            this.bar_btn_clientes.Size = new System.Drawing.Size(23, 22);
            this.bar_btn_clientes.Text = "toolStripButton1";
            this.bar_btn_clientes.Click += new System.EventHandler(this.bar_btn_clientes_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(49, 22);
            this.toolStripLabel4.Text = "Clientes";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1858, 24);
            this.menuStrip1.TabIndex = 116;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_categoria);
            this.groupBox1.Controls.Add(this.tb_departamento);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.lblcategoria);
            this.groupBox1.Controls.Add(this.lbldepartanamento);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.tbprecio_mayoreo);
            this.groupBox1.Controls.Add(this.lblprecio_mayoreo);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.tbprecio_unidad);
            this.groupBox1.Controls.Add(this.lblprecio_unidad);
            this.groupBox1.Controls.Add(this.tbdescripcion);
            this.groupBox1.Controls.Add(this.lbldescripcion);
            this.groupBox1.Controls.Add(this.tbcodigo);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Coral;
            this.groupBox1.Location = new System.Drawing.Point(33, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 762);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Llene la informacion del nuevo rpoducto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tb_categoria
            // 
            this.tb_categoria.FormattingEnabled = true;
            this.tb_categoria.Location = new System.Drawing.Point(50, 646);
            this.tb_categoria.Name = "tb_categoria";
            this.tb_categoria.Size = new System.Drawing.Size(170, 28);
            this.tb_categoria.TabIndex = 135;
            // 
            // tb_departamento
            // 
            this.tb_departamento.FormattingEnabled = true;
            this.tb_departamento.Location = new System.Drawing.Point(50, 555);
            this.tb_departamento.Name = "tb_departamento";
            this.tb_departamento.Size = new System.Drawing.Size(170, 28);
            this.tb_departamento.TabIndex = 134;
            this.tb_departamento.SelectedIndexChanged += new System.EventHandler(this.tb_departamento_SelectedIndexChanged);
            // 
            // txtid
            // 
            this.txtid.AutoSize = true;
            this.txtid.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.Color.Red;
            this.txtid.Location = new System.Drawing.Point(91, 121);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(0, 20);
            this.txtid.TabIndex = 133;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(52, 121);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(33, 20);
            this.lblid.TabIndex = 132;
            this.lblid.Text = "ID:";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblcategoria.Location = new System.Drawing.Point(52, 623);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(78, 20);
            this.lblcategoria.TabIndex = 129;
            this.lblcategoria.Text = "Categoria";
            // 
            // lbldepartanamento
            // 
            this.lbldepartanamento.AutoSize = true;
            this.lbldepartanamento.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbldepartanamento.Location = new System.Drawing.Point(52, 517);
            this.lbldepartanamento.Name = "lbldepartanamento";
            this.lbldepartanamento.Size = new System.Drawing.Size(112, 20);
            this.lbldepartanamento.TabIndex = 128;
            this.lbldepartanamento.Text = "Departamento";
            // 
            // tbprecio_mayoreo
            // 
            this.tbprecio_mayoreo.Location = new System.Drawing.Point(50, 465);
            this.tbprecio_mayoreo.Name = "tbprecio_mayoreo";
            this.tbprecio_mayoreo.Size = new System.Drawing.Size(170, 26);
            this.tbprecio_mayoreo.TabIndex = 127;
            this.tbprecio_mayoreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbprecio_mayoreo_KeyPress);
            // 
            // lblprecio_mayoreo
            // 
            this.lblprecio_mayoreo.AutoSize = true;
            this.lblprecio_mayoreo.Location = new System.Drawing.Point(46, 431);
            this.lblprecio_mayoreo.Name = "lblprecio_mayoreo";
            this.lblprecio_mayoreo.Size = new System.Drawing.Size(118, 20);
            this.lblprecio_mayoreo.TabIndex = 126;
            this.lblprecio_mayoreo.Text = "Precio mayoreo";
            // 
            // tbprecio_unidad
            // 
            this.tbprecio_unidad.Location = new System.Drawing.Point(50, 379);
            this.tbprecio_unidad.Name = "tbprecio_unidad";
            this.tbprecio_unidad.Size = new System.Drawing.Size(170, 26);
            this.tbprecio_unidad.TabIndex = 125;
            // 
            // lblprecio_unidad
            // 
            this.lblprecio_unidad.AutoSize = true;
            this.lblprecio_unidad.Location = new System.Drawing.Point(46, 347);
            this.lblprecio_unidad.Name = "lblprecio_unidad";
            this.lblprecio_unidad.Size = new System.Drawing.Size(105, 20);
            this.lblprecio_unidad.TabIndex = 124;
            this.lblprecio_unidad.Text = "Precio unidad";
            // 
            // tbdescripcion
            // 
            this.tbdescripcion.Location = new System.Drawing.Point(50, 289);
            this.tbdescripcion.Name = "tbdescripcion";
            this.tbdescripcion.Size = new System.Drawing.Size(170, 26);
            this.tbdescripcion.TabIndex = 123;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(46, 258);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(92, 20);
            this.lbldescripcion.TabIndex = 122;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // tbcodigo
            // 
            this.tbcodigo.Location = new System.Drawing.Point(50, 206);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(170, 26);
            this.tbcodigo.TabIndex = 121;
            this.tbcodigo.TextChanged += new System.EventHandler(this.tbcodigo_TextChanged);
            this.tbcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbcodigo_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(46, 172);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 120;
            this.lblCodigo.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_eliminar);
            this.groupBox2.Controls.Add(this.dt_producto1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox2.Location = new System.Drawing.Point(344, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1476, 823);
            this.groupBox2.TabIndex = 121;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos en stock";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Tomato;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(1087, 774);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(162, 33);
            this.btn_eliminar.TabIndex = 89;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // dt_producto1
            // 
            this.dt_producto1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_producto1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_producto1.Location = new System.Drawing.Point(23, 38);
            this.dt_producto1.Name = "dt_producto1";
            this.dt_producto1.Size = new System.Drawing.Size(1427, 724);
            this.dt_producto1.TabIndex = 88;
            this.dt_producto1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_producto1_CellContentClick);
            this.dt_producto1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_producto1_CellContentDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.disponible);
            this.groupBox3.Controls.Add(this.no_disponible);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox3.Location = new System.Drawing.Point(1220, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(600, 79);
            this.groupBox3.TabIndex = 122;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuracion del producto";
            // 
            // disponible
            // 
            this.disponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disponible.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.disponible.Location = new System.Drawing.Point(127, 31);
            this.disponible.Name = "disponible";
            this.disponible.Size = new System.Drawing.Size(162, 33);
            this.disponible.TabIndex = 93;
            this.disponible.Text = "Disponible";
            this.disponible.UseVisualStyleBackColor = true;
            this.disponible.Click += new System.EventHandler(this.disponible_Click);
            // 
            // no_disponible
            // 
            this.no_disponible.ForeColor = System.Drawing.Color.DarkOrange;
            this.no_disponible.Location = new System.Drawing.Point(320, 31);
            this.no_disponible.Name = "no_disponible";
            this.no_disponible.Size = new System.Drawing.Size(162, 33);
            this.no_disponible.TabIndex = 92;
            this.no_disponible.Text = "No disponible";
            this.no_disponible.UseVisualStyleBackColor = true;
            this.no_disponible.Click += new System.EventHandler(this.no_disponible_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtn_codigo);
            this.groupBox4.Controls.Add(this.rbtn_nombre);
            this.groupBox4.Controls.Add(this.tbbuscar);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox4.Location = new System.Drawing.Point(631, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(395, 79);
            this.groupBox4.TabIndex = 124;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar";
            // 
            // rbtn_codigo
            // 
            this.rbtn_codigo.AutoSize = true;
            this.rbtn_codigo.Location = new System.Drawing.Point(309, 34);
            this.rbtn_codigo.Name = "rbtn_codigo";
            this.rbtn_codigo.Size = new System.Drawing.Size(77, 24);
            this.rbtn_codigo.TabIndex = 96;
            this.rbtn_codigo.TabStop = true;
            this.rbtn_codigo.Text = "Codigo";
            this.rbtn_codigo.UseVisualStyleBackColor = true;
            // 
            // rbtn_nombre
            // 
            this.rbtn_nombre.AutoSize = true;
            this.rbtn_nombre.Location = new System.Drawing.Point(220, 32);
            this.rbtn_nombre.Name = "rbtn_nombre";
            this.rbtn_nombre.Size = new System.Drawing.Size(83, 24);
            this.rbtn_nombre.TabIndex = 95;
            this.rbtn_nombre.TabStop = true;
            this.rbtn_nombre.Text = "Nombre";
            this.rbtn_nombre.UseVisualStyleBackColor = true;
            // 
            // tbbuscar
            // 
            this.tbbuscar.Location = new System.Drawing.Point(23, 32);
            this.tbbuscar.Name = "tbbuscar";
            this.tbbuscar.Size = new System.Drawing.Size(182, 26);
            this.tbbuscar.TabIndex = 93;
            this.tbbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbbuscar_KeyPress_1);
            // 
            // productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1858, 1061);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblproductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esta ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.productos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_producto1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblproductos;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bar_btn_ventas;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton bar_btn_compras;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton bar_btn_productos;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton bar_btn_clientes;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lbldepartanamento;
        private System.Windows.Forms.TextBox tbprecio_mayoreo;
        private System.Windows.Forms.Label lblprecio_mayoreo;
        private System.Windows.Forms.TextBox tbprecio_unidad;
        private System.Windows.Forms.Label lblprecio_unidad;
        private System.Windows.Forms.TextBox tbdescripcion;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dt_producto1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label txtid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ComboBox tb_categoria;
        private System.Windows.Forms.ComboBox tb_departamento;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button disponible;
        private System.Windows.Forms.Button no_disponible;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtn_codigo;
        private System.Windows.Forms.RadioButton rbtn_nombre;
        private System.Windows.Forms.TextBox tbbuscar;
    }
}