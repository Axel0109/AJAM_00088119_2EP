using System.ComponentModel;

namespace Parcial_2.Properties.Vista
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.generalTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.UserTab = new System.Windows.Forms.TabPage();
            this.bttnDeletUser = new System.Windows.Forms.Button();
            this.textDeleteUser = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bttnCreateUser = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtagusertype = new System.Windows.Forms.TextBox();
            this.txtagpassword = new System.Windows.Forms.TextBox();
            this.txtagusername = new System.Windows.Forms.TextBox();
            this.txtagfullname = new System.Windows.Forms.TextBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.DireccionesTab = new System.Windows.Forms.TabPage();
            this.bttnCreateAddress = new System.Windows.Forms.Button();
            this.txtaggdireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUserd = new System.Windows.Forms.ComboBox();
            this.dgvDirecciones = new System.Windows.Forms.DataGridView();
            this.NegociosTab = new System.Windows.Forms.TabPage();
            this.dgvNegocio = new System.Windows.Forms.DataGridView();
            this.bttnDeletNegocio = new System.Windows.Forms.Button();
            this.textDeleteNegocio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bttnAddNegocio = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddNegocio = new System.Windows.Forms.TextBox();
            this.productsTab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdempresa = new System.Windows.Forms.TextBox();
            this.bttnAddProducto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewProduct = new System.Windows.Forms.TextBox();
            this.OrdenesAtab = new System.Windows.Forms.TabPage();
            this.bttnOrdenesA = new System.Windows.Forms.Button();
            this.dgvOrdenesA = new System.Windows.Forms.DataGridView();
            this.OrdenesUtab = new System.Windows.Forms.TabPage();
            this.dgvOrdenesU = new System.Windows.Forms.DataGridView();
            this.bttnDeleteOrden = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIdOrden = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdDireccion = new System.Windows.Forms.TextBox();
            this.bttnAddPedido = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.generalTab.SuspendLayout();
            this.UserTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvUser)).BeginInit();
            this.DireccionesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDirecciones)).BeginInit();
            this.NegociosTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvNegocio)).BeginInit();
            this.productsTab.SuspendLayout();
            this.OrdenesAtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrdenesA)).BeginInit();
            this.OrdenesUtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrdenesU)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.generalTab);
            this.tabControl1.Controls.Add(this.UserTab);
            this.tabControl1.Controls.Add(this.DireccionesTab);
            this.tabControl1.Controls.Add(this.NegociosTab);
            this.tabControl1.Controls.Add(this.productsTab);
            this.tabControl1.Controls.Add(this.OrdenesAtab);
            this.tabControl1.Controls.Add(this.OrdenesUtab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(889, 562);
            this.tabControl1.TabIndex = 2;
            // 
            // generalTab
            // 
            this.generalTab.BackColor = System.Drawing.Color.Transparent;
            this.generalTab.Controls.Add(this.label1);
            this.generalTab.Location = new System.Drawing.Point(4, 34);
            this.generalTab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.generalTab.Name = "generalTab";
            this.generalTab.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.generalTab.Size = new System.Drawing.Size(881, 524);
            this.generalTab.TabIndex = 0;
            this.generalTab.Text = "General";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserTab
            // 
            this.UserTab.Controls.Add(this.bttnDeletUser);
            this.UserTab.Controls.Add(this.textDeleteUser);
            this.UserTab.Controls.Add(this.label12);
            this.UserTab.Controls.Add(this.bttnCreateUser);
            this.UserTab.Controls.Add(this.label16);
            this.UserTab.Controls.Add(this.label14);
            this.UserTab.Controls.Add(this.label15);
            this.UserTab.Controls.Add(this.label13);
            this.UserTab.Controls.Add(this.label2);
            this.UserTab.Controls.Add(this.txtagusertype);
            this.UserTab.Controls.Add(this.txtagpassword);
            this.UserTab.Controls.Add(this.txtagusername);
            this.UserTab.Controls.Add(this.txtagfullname);
            this.UserTab.Controls.Add(this.dgvUser);
            this.UserTab.Location = new System.Drawing.Point(4, 34);
            this.UserTab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.UserTab.Name = "UserTab";
            this.UserTab.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.UserTab.Size = new System.Drawing.Size(881, 524);
            this.UserTab.TabIndex = 1;
            this.UserTab.Text = "Crear/eliminar usuario";
            this.UserTab.UseVisualStyleBackColor = true;
            // 
            // bttnDeletUser
            // 
            this.bttnDeletUser.Location = new System.Drawing.Point(743, 79);
            this.bttnDeletUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bttnDeletUser.Name = "bttnDeletUser";
            this.bttnDeletUser.Size = new System.Drawing.Size(130, 42);
            this.bttnDeletUser.TabIndex = 6;
            this.bttnDeletUser.Text = "Eliminar";
            this.bttnDeletUser.UseVisualStyleBackColor = true;
            this.bttnDeletUser.Click += new System.EventHandler(this.bttnDeletUser_Click);
            // 
            // textDeleteUser
            // 
            this.textDeleteUser.Location = new System.Drawing.Point(492, 85);
            this.textDeleteUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textDeleteUser.Name = "textDeleteUser";
            this.textDeleteUser.Size = new System.Drawing.Size(245, 31);
            this.textDeleteUser.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(510, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 25);
            this.label12.TabIndex = 4;
            this.label12.Text = "Usuario a eliminar";
            // 
            // bttnCreateUser
            // 
            this.bttnCreateUser.Location = new System.Drawing.Point(284, 74);
            this.bttnCreateUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bttnCreateUser.Name = "bttnCreateUser";
            this.bttnCreateUser.Size = new System.Drawing.Size(130, 42);
            this.bttnCreateUser.TabIndex = 3;
            this.bttnCreateUser.Text = "Agregar";
            this.bttnCreateUser.UseVisualStyleBackColor = true;
            this.bttnCreateUser.Click += new System.EventHandler(this.bttnCreateUser_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 158);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "userType";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 25);
            this.label14.TabIndex = 2;
            this.label14.Text = "username";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "password";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "fullname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nuevo usuario";
            // 
            // txtagusertype
            // 
            this.txtagusertype.Location = new System.Drawing.Point(111, 158);
            this.txtagusertype.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtagusertype.Name = "txtagusertype";
            this.txtagusertype.Size = new System.Drawing.Size(146, 31);
            this.txtagusertype.TabIndex = 1;
            // 
            // txtagpassword
            // 
            this.txtagpassword.Location = new System.Drawing.Point(111, 119);
            this.txtagpassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtagpassword.Name = "txtagpassword";
            this.txtagpassword.Size = new System.Drawing.Size(146, 31);
            this.txtagpassword.TabIndex = 1;
            // 
            // txtagusername
            // 
            this.txtagusername.Location = new System.Drawing.Point(111, 79);
            this.txtagusername.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtagusername.Name = "txtagusername";
            this.txtagusername.Size = new System.Drawing.Size(146, 31);
            this.txtagusername.TabIndex = 1;
            // 
            // txtagfullname
            // 
            this.txtagfullname.Location = new System.Drawing.Point(111, 40);
            this.txtagfullname.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtagfullname.Name = "txtagfullname";
            this.txtagfullname.Size = new System.Drawing.Size(146, 31);
            this.txtagfullname.TabIndex = 1;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUser.Location = new System.Drawing.Point(3, 209);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.Size = new System.Drawing.Size(875, 310);
            this.dgvUser.TabIndex = 0;
            // 
            // DireccionesTab
            // 
            this.DireccionesTab.Controls.Add(this.bttnCreateAddress);
            this.DireccionesTab.Controls.Add(this.txtaggdireccion);
            this.DireccionesTab.Controls.Add(this.label3);
            this.DireccionesTab.Controls.Add(this.label4);
            this.DireccionesTab.Controls.Add(this.cmbUserd);
            this.DireccionesTab.Controls.Add(this.dgvDirecciones);
            this.DireccionesTab.Location = new System.Drawing.Point(4, 34);
            this.DireccionesTab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DireccionesTab.Name = "DireccionesTab";
            this.DireccionesTab.Size = new System.Drawing.Size(881, 524);
            this.DireccionesTab.TabIndex = 2;
            this.DireccionesTab.Text = "Direcciones";
            this.DireccionesTab.UseVisualStyleBackColor = true;
           
            // 
            // bttnCreateAddress
            // 
            this.bttnCreateAddress.Location = new System.Drawing.Point(771, 88);
            this.bttnCreateAddress.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bttnCreateAddress.Name = "bttnCreateAddress";
            this.bttnCreateAddress.Size = new System.Drawing.Size(216, 36);
            this.bttnCreateAddress.TabIndex = 7;
            this.bttnCreateAddress.Text = "Agregar";
            this.bttnCreateAddress.UseVisualStyleBackColor = true;
            this.bttnCreateAddress.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtaggdireccion
            // 
            this.txtaggdireccion.Location = new System.Drawing.Point(528, 88);
            this.txtaggdireccion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtaggdireccion.Name = "txtaggdireccion";
            this.txtaggdireccion.Size = new System.Drawing.Size(168, 31);
            this.txtaggdireccion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Usuario";
            // 
            // cmbUserd
            // 
            this.cmbUserd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserd.FormattingEnabled = true;
            this.cmbUserd.Location = new System.Drawing.Point(154, 84);
            this.cmbUserd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbUserd.Name = "cmbUserd";
            this.cmbUserd.Size = new System.Drawing.Size(173, 33);
            this.cmbUserd.TabIndex = 3;
            // 
            // dgvDirecciones
            // 
            this.dgvDirecciones.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirecciones.Location = new System.Drawing.Point(20, 174);
            this.dgvDirecciones.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvDirecciones.Name = "dgvDirecciones";
            this.dgvDirecciones.RowHeadersWidth = 51;
            this.dgvDirecciones.RowTemplate.Height = 24;
            this.dgvDirecciones.Size = new System.Drawing.Size(1031, 360);
            this.dgvDirecciones.TabIndex = 0;
            
                
            // 
            // NegociosTab
            // 
            this.NegociosTab.Controls.Add(this.dgvNegocio);
            this.NegociosTab.Controls.Add(this.bttnDeletNegocio);
            this.NegociosTab.Controls.Add(this.textDeleteNegocio);
            this.NegociosTab.Controls.Add(this.label5);
            this.NegociosTab.Controls.Add(this.bttnAddNegocio);
            this.NegociosTab.Controls.Add(this.label6);
            this.NegociosTab.Controls.Add(this.txtAddNegocio);
            this.NegociosTab.Location = new System.Drawing.Point(4, 29);
            this.NegociosTab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.NegociosTab.Name = "NegociosTab";
            this.NegociosTab.Size = new System.Drawing.Size(881, 529);
            this.NegociosTab.TabIndex = 4;
            this.NegociosTab.Text = "Aniadir/Eliminar negocios";
            this.NegociosTab.UseVisualStyleBackColor = true;
            // 
            // dgvNegocio
            // 
            this.dgvNegocio.AllowUserToAddRows = false;
            this.dgvNegocio.AllowUserToDeleteRows = false;
            this.dgvNegocio.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNegocio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNegocio.Location = new System.Drawing.Point(0, 157);
            this.dgvNegocio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvNegocio.Name = "dgvNegocio";
            this.dgvNegocio.ReadOnly = true;
            this.dgvNegocio.RowHeadersWidth = 51;
            this.dgvNegocio.RowTemplate.Height = 24;
            this.dgvNegocio.Size = new System.Drawing.Size(881, 372);
            this.dgvNegocio.TabIndex = 13;
            // 
            // bttnDeletNegocio
            // 
            this.bttnDeletNegocio.Location = new System.Drawing.Point(744, 109);
            this.bttnDeletNegocio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bttnDeletNegocio.Name = "bttnDeletNegocio";
            this.bttnDeletNegocio.Size = new System.Drawing.Size(130, 42);
            this.bttnDeletNegocio.TabIndex = 12;
            this.bttnDeletNegocio.Text = "Eliminar";
            this.bttnDeletNegocio.UseVisualStyleBackColor = true;
            // 
            // textDeleteNegocio
            // 
            this.textDeleteNegocio.Location = new System.Drawing.Point(433, 109);
            this.textDeleteNegocio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textDeleteNegocio.Name = "textDeleteNegocio";
            this.textDeleteNegocio.Size = new System.Drawing.Size(245, 31);
            this.textDeleteNegocio.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Negocio a eliminar";
            // 
            // bttnAddNegocio
            // 
            this.bttnAddNegocio.Location = new System.Drawing.Point(744, 45);
            this.bttnAddNegocio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bttnAddNegocio.Name = "bttnAddNegocio";
            this.bttnAddNegocio.Size = new System.Drawing.Size(130, 42);
            this.bttnAddNegocio.TabIndex = 9;
            this.bttnAddNegocio.Text = "Agregar";
            this.bttnAddNegocio.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nuevo negocio";
            // 
            // txtAddNegocio
            // 
            this.txtAddNegocio.Location = new System.Drawing.Point(433, 56);
            this.txtAddNegocio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAddNegocio.Name = "txtAddNegocio";
            this.txtAddNegocio.Size = new System.Drawing.Size(245, 31);
            this.txtAddNegocio.TabIndex = 7;
            // 
            // productsTab
            // 
            this.productsTab.Controls.Add(this.label8);
            this.productsTab.Controls.Add(this.txtIdempresa);
            this.productsTab.Controls.Add(this.bttnAddProducto);
            this.productsTab.Controls.Add(this.label7);
            this.productsTab.Controls.Add(this.txtNewProduct);
            this.productsTab.Location = new System.Drawing.Point(4, 29);
            this.productsTab.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.productsTab.Name = "productsTab";
            this.productsTab.Size = new System.Drawing.Size(881, 529);
            this.productsTab.TabIndex = 3;
            this.productsTab.Text = "Agregar productos";
            this.productsTab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "en(id empresa)";
            // 
            // txtIdempresa
            // 
            this.txtIdempresa.Location = new System.Drawing.Point(462, 261);
            this.txtIdempresa.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtIdempresa.Name = "txtIdempresa";
            this.txtIdempresa.Size = new System.Drawing.Size(245, 31);
            this.txtIdempresa.TabIndex = 13;
            // 
            // bttnAddProducto
            // 
            this.bttnAddProducto.Location = new System.Drawing.Point(761, 222);
            this.bttnAddProducto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bttnAddProducto.Name = "bttnAddProducto";
            this.bttnAddProducto.Size = new System.Drawing.Size(130, 42);
            this.bttnAddProducto.TabIndex = 12;
            this.bttnAddProducto.Text = "Agregar";
            this.bttnAddProducto.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nuevo producto";
            // 
            // txtNewProduct
            // 
            this.txtNewProduct.Location = new System.Drawing.Point(462, 192);
            this.txtNewProduct.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNewProduct.Name = "txtNewProduct";
            this.txtNewProduct.Size = new System.Drawing.Size(245, 31);
            this.txtNewProduct.TabIndex = 10;
            // 
            // OrdenesAtab
            // 
            this.OrdenesAtab.Controls.Add(this.bttnOrdenesA);
            this.OrdenesAtab.Controls.Add(this.dgvOrdenesA);
            this.OrdenesAtab.Location = new System.Drawing.Point(4, 29);
            this.OrdenesAtab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrdenesAtab.Name = "OrdenesAtab";
            this.OrdenesAtab.Size = new System.Drawing.Size(881, 529);
            this.OrdenesAtab.TabIndex = 5;
            this.OrdenesAtab.Text = "OrdenesA";
            this.OrdenesAtab.UseVisualStyleBackColor = true;
            // 
            // bttnOrdenesA
            // 
            this.bttnOrdenesA.Location = new System.Drawing.Point(432, 38);
            this.bttnOrdenesA.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bttnOrdenesA.Name = "bttnOrdenesA";
            this.bttnOrdenesA.Size = new System.Drawing.Size(146, 71);
            this.bttnOrdenesA.TabIndex = 13;
            this.bttnOrdenesA.Text = "Ver ordenes";
            this.bttnOrdenesA.UseVisualStyleBackColor = true;
            // 
            // dgvOrdenesA
            // 
            this.dgvOrdenesA.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenesA.Location = new System.Drawing.Point(0, 141);
            this.dgvOrdenesA.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvOrdenesA.Name = "dgvOrdenesA";
            this.dgvOrdenesA.RowHeadersWidth = 51;
            this.dgvOrdenesA.RowTemplate.Height = 24;
            this.dgvOrdenesA.Size = new System.Drawing.Size(1031, 360);
            this.dgvOrdenesA.TabIndex = 1;
            // 
            // OrdenesUtab
            // 
            this.OrdenesUtab.Controls.Add(this.dgvOrdenesU);
            this.OrdenesUtab.Controls.Add(this.bttnDeleteOrden);
            this.OrdenesUtab.Controls.Add(this.label11);
            this.OrdenesUtab.Controls.Add(this.txtIdOrden);
            this.OrdenesUtab.Controls.Add(this.label9);
            this.OrdenesUtab.Controls.Add(this.txtIdDireccion);
            this.OrdenesUtab.Controls.Add(this.bttnAddPedido);
            this.OrdenesUtab.Controls.Add(this.label10);
            this.OrdenesUtab.Controls.Add(this.txtIdProducto);
            this.OrdenesUtab.Location = new System.Drawing.Point(4, 29);
            this.OrdenesUtab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrdenesUtab.Name = "OrdenesUtab";
            this.OrdenesUtab.Size = new System.Drawing.Size(881, 529);
            this.OrdenesUtab.TabIndex = 6;
            this.OrdenesUtab.Text = "OrdenesU";
            this.OrdenesUtab.UseVisualStyleBackColor = true;
            // 
            // dgvOrdenesU
            // 
            this.dgvOrdenesU.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenesU.Location = new System.Drawing.Point(0, 256);
            this.dgvOrdenesU.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvOrdenesU.Name = "dgvOrdenesU";
            this.dgvOrdenesU.RowHeadersWidth = 51;
            this.dgvOrdenesU.RowTemplate.Height = 24;
            this.dgvOrdenesU.Size = new System.Drawing.Size(1020, 325);
            this.dgvOrdenesU.TabIndex = 23;
            // 
            // bttnDeleteOrden
            // 
            this.bttnDeleteOrden.Location = new System.Drawing.Point(427, 204);
            this.bttnDeleteOrden.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bttnDeleteOrden.Name = "bttnDeleteOrden";
            this.bttnDeleteOrden.Size = new System.Drawing.Size(157, 42);
            this.bttnDeleteOrden.TabIndex = 22;
            this.bttnDeleteOrden.Text = "EliminarOrden";
            this.bttnDeleteOrden.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "idOrden";
            // 
            // txtIdOrden
            // 
            this.txtIdOrden.Location = new System.Drawing.Point(157, 204);
            this.txtIdOrden.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtIdOrden.Name = "txtIdOrden";
            this.txtIdOrden.Size = new System.Drawing.Size(245, 31);
            this.txtIdOrden.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "idDireccion";
            // 
            // txtIdDireccion
            // 
            this.txtIdDireccion.Location = new System.Drawing.Point(157, 112);
            this.txtIdDireccion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtIdDireccion.Name = "txtIdDireccion";
            this.txtIdDireccion.Size = new System.Drawing.Size(245, 31);
            this.txtIdDireccion.TabIndex = 18;
            // 
            // bttnAddPedido
            // 
            this.bttnAddPedido.Location = new System.Drawing.Point(427, 72);
            this.bttnAddPedido.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bttnAddPedido.Name = "bttnAddPedido";
            this.bttnAddPedido.Size = new System.Drawing.Size(150, 42);
            this.bttnAddPedido.TabIndex = 17;
            this.bttnAddPedido.Text = "AgregarPedido";
            this.bttnAddPedido.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "idProducto";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(157, 45);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(245, 31);
            this.txtIdProducto.TabIndex = 15;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 562);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            this.UserTab.ResumeLayout(false);
            this.UserTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvUser)).EndInit();
            this.DireccionesTab.ResumeLayout(false);
            this.DireccionesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDirecciones)).EndInit();
            this.NegociosTab.ResumeLayout(false);
            this.NegociosTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvNegocio)).EndInit();
            this.productsTab.ResumeLayout(false);
            this.productsTab.PerformLayout();
            this.OrdenesAtab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrdenesA)).EndInit();
            this.OrdenesUtab.ResumeLayout(false);
            this.OrdenesUtab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrdenesU)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnCreateUser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage generalTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage UserTab;
        private System.Windows.Forms.Button bttnDeletUser;
        private System.Windows.Forms.TextBox textDeleteUser;
        private System.Windows.Forms.TabPage DireccionesTab;
        private System.Windows.Forms.DataGridView dgvDirecciones;
        private System.Windows.Forms.TabPage NegociosTab;
        private System.Windows.Forms.DataGridView dgvNegocio;
        private System.Windows.Forms.Button bttnDeletNegocio;
        private System.Windows.Forms.TextBox textDeleteNegocio;
        private System.Windows.Forms.Button bttnAddNegocio;
        private System.Windows.Forms.TextBox txtAddNegocio;
        private System.Windows.Forms.TabPage productsTab;
        private System.Windows.Forms.TextBox txtIdempresa;
        private System.Windows.Forms.Button bttnAddPedido;
        private System.Windows.Forms.TextBox txtNewProduct;
        private System.Windows.Forms.TabPage OrdenesAtab;
        private System.Windows.Forms.Button bttnOrdenesA;
        private System.Windows.Forms.DataGridView dgvOrdenesA;
        private System.Windows.Forms.TextBox txtIdOrden;
        private System.Windows.Forms.TextBox txtIdDireccion;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button bttnAddProducto;
        private System.Windows.Forms.TabPage OrdenesUtab;
        private System.Windows.Forms.DataGridView dgvOrdenesU;
        private System.Windows.Forms.Button bttnDeleteOrden;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtagusername;
        private System.Windows.Forms.TextBox txtagpassword;
        private System.Windows.Forms.TextBox txtagusertype;
        private System.Windows.Forms.TextBox txtagfullname;
        private System.Windows.Forms.Button bttnCreateAddress;
        private System.Windows.Forms.TextBox txtaggdireccion;
        private System.Windows.Forms.ComboBox cmbUserd;
    }
}