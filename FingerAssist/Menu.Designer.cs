namespace Sistema_Empresarial
{
    partial class Menu
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
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            ListViewItem listViewItem3 = new ListViewItem("");
            ListViewItem listViewItem4 = new ListViewItem("");
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TabMenu = new MaterialSkin.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            Salir = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            tabPage2 = new TabPage();
            cmbEmpleadosRegister = new MaterialSkin.Controls.MaterialComboBox();
            RegisterFingerPrint = new MaterialSkin.Controls.MaterialButton();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            tabPage3 = new TabPage();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            checkedListBoxSucursales = new MaterialSkin.Controls.MaterialCheckedListBox();
            BuscarMarcaje = new MaterialSkin.Controls.MaterialButton();
            checkedListBoxEmpleados = new MaterialSkin.Controls.MaterialCheckedListBox();
            dateTimePickerFin = new DateTimePicker();
            dateTimePickerInicio = new DateTimePicker();
            listViewResultados = new MaterialSkin.Controls.MaterialListView();
            Fecha = new ColumnHeader();
            Tipo = new ColumnHeader();
            Empleado = new ColumnHeader();
            Sucursal = new ColumnHeader();
            tabPage4 = new TabPage();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            btnEliminarSucursal = new MaterialSkin.Controls.MaterialButton();
            nombreSucursal = new MaterialSkin.Controls.MaterialTextBox();
            idSucursal = new MaterialSkin.Controls.MaterialTextBox();
            btnEditarSucursal = new MaterialSkin.Controls.MaterialButton();
            btnAgregarSucursal = new MaterialSkin.Controls.MaterialButton();
            materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            tabPage5 = new TabPage();
            materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            sucursalesCombo = new MaterialSkin.Controls.MaterialComboBox();
            eliminarEmpleado = new MaterialSkin.Controls.MaterialButton();
            nombreEmpleado = new MaterialSkin.Controls.MaterialTextBox();
            idEmpleado = new MaterialSkin.Controls.MaterialTextBox();
            editarEmpleado = new MaterialSkin.Controls.MaterialButton();
            agregarEmpleado = new MaterialSkin.Controls.MaterialButton();
            listBoxEmpleados = new MaterialSkin.Controls.MaterialListBox();
            tabPage6 = new TabPage();
            textBoxIdUsuario = new TextBox();
            listBoxSucursalesUsuario = new CheckedListBox();
            dataGridViewUsuarios = new DataGridView();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            btnEliminarUsuario = new MaterialSkin.Controls.MaterialButton();
            btnEditarUsuario = new MaterialSkin.Controls.MaterialButton();
            btnAgregarUsuario = new MaterialSkin.Controls.MaterialButton();
            roles = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            TabMenu.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            materialCard1.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            SuspendLayout();
            // 
            // TabMenu
            // 
            TabMenu.Controls.Add(tabPage1);
            TabMenu.Controls.Add(tabPage2);
            TabMenu.Controls.Add(tabPage3);
            TabMenu.Controls.Add(tabPage4);
            TabMenu.Controls.Add(tabPage5);
            TabMenu.Controls.Add(tabPage6);
            TabMenu.Depth = 0;
            TabMenu.Dock = DockStyle.Fill;
            TabMenu.Location = new Point(3, 64);
            TabMenu.MouseState = MaterialSkin.MouseState.HOVER;
            TabMenu.Multiline = true;
            TabMenu.Name = "TabMenu";
            TabMenu.SelectedIndex = 0;
            TabMenu.Size = new Size(1246, 614);
            TabMenu.TabIndex = 0;
            TabMenu.SelectedIndexChanged += TabMenu_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Salir);
            tabPage1.Controls.Add(materialLabel2);
            tabPage1.Controls.Add(materialLabel1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1238, 576);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Inicio";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Salir
            // 
            Salir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Salir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Salir.Depth = 0;
            Salir.HighEmphasis = true;
            Salir.Icon = null;
            Salir.Location = new Point(1117, 28);
            Salir.Margin = new Padding(4, 6, 4, 6);
            Salir.MouseState = MaterialSkin.MouseState.HOVER;
            Salir.Name = "Salir";
            Salir.NoAccentTextColor = Color.Empty;
            Salir.Size = new Size(64, 36);
            Salir.TabIndex = 2;
            Salir.Text = "Salir";
            Salir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Salir.UseAccentColor = false;
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(76, 270);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(107, 19);
            materialLabel2.TabIndex = 1;
            materialLabel2.Text = "materialLabel2";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.ForeColor = Color.Transparent;
            materialLabel1.Location = new Point(62, 121);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(79, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Bienvenido";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(materialCard1);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1238, 576);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Huellas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbEmpleadosRegister
            // 
            cmbEmpleadosRegister.AutoResize = false;
            cmbEmpleadosRegister.BackColor = Color.FromArgb(255, 255, 255);
            cmbEmpleadosRegister.Depth = 0;
            cmbEmpleadosRegister.DrawMode = DrawMode.OwnerDrawVariable;
            cmbEmpleadosRegister.DropDownHeight = 174;
            cmbEmpleadosRegister.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpleadosRegister.DropDownWidth = 121;
            cmbEmpleadosRegister.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbEmpleadosRegister.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbEmpleadosRegister.FormattingEnabled = true;
            cmbEmpleadosRegister.IntegralHeight = false;
            cmbEmpleadosRegister.ItemHeight = 43;
            cmbEmpleadosRegister.Location = new Point(167, 134);
            cmbEmpleadosRegister.MaxDropDownItems = 4;
            cmbEmpleadosRegister.MouseState = MaterialSkin.MouseState.OUT;
            cmbEmpleadosRegister.Name = "cmbEmpleadosRegister";
            cmbEmpleadosRegister.Size = new Size(412, 49);
            cmbEmpleadosRegister.StartIndex = 0;
            cmbEmpleadosRegister.TabIndex = 1;
            // 
            // RegisterFingerPrint
            // 
            RegisterFingerPrint.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RegisterFingerPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            RegisterFingerPrint.Depth = 0;
            RegisterFingerPrint.HighEmphasis = true;
            RegisterFingerPrint.Icon = null;
            RegisterFingerPrint.Location = new Point(292, 235);
            RegisterFingerPrint.Margin = new Padding(4, 6, 4, 6);
            RegisterFingerPrint.MouseState = MaterialSkin.MouseState.HOVER;
            RegisterFingerPrint.Name = "RegisterFingerPrint";
            RegisterFingerPrint.NoAccentTextColor = Color.Empty;
            RegisterFingerPrint.Size = new Size(157, 36);
            RegisterFingerPrint.TabIndex = 0;
            RegisterFingerPrint.Text = "Registrar Huella";
            RegisterFingerPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            RegisterFingerPrint.UseAccentColor = false;
            RegisterFingerPrint.UseVisualStyleBackColor = true;
            RegisterFingerPrint.Click += RegisterFingerPrint_Click;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(RegisterFingerPrint);
            materialCard1.Controls.Add(cmbEmpleadosRegister);
            materialCard1.Controls.Add(materialLabel15);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(260, 37);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(762, 346);
            materialCard1.TabIndex = 3;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(materialLabel6);
            tabPage3.Controls.Add(materialLabel5);
            tabPage3.Controls.Add(materialLabel4);
            tabPage3.Controls.Add(materialLabel3);
            tabPage3.Controls.Add(checkedListBoxSucursales);
            tabPage3.Controls.Add(BuscarMarcaje);
            tabPage3.Controls.Add(checkedListBoxEmpleados);
            tabPage3.Controls.Add(dateTimePickerFin);
            tabPage3.Controls.Add(dateTimePickerInicio);
            tabPage3.Controls.Add(listViewResultados);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1238, 576);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Reporte de Marcajes";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(916, 22);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(79, 19);
            materialLabel6.TabIndex = 13;
            materialLabel6.Text = "Sucursales";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(575, 22);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(80, 19);
            materialLabel5.TabIndex = 12;
            materialLabel5.Text = "Empleados";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(56, 105);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(83, 19);
            materialLabel4.TabIndex = 11;
            materialLabel4.Text = "Fecha Final";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(56, 22);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(86, 19);
            materialLabel3.TabIndex = 10;
            materialLabel3.Text = "Fecha Incial";
            // 
            // checkedListBoxSucursales
            // 
            checkedListBoxSucursales.AutoScroll = true;
            checkedListBoxSucursales.BackColor = Color.Transparent;
            checkedListBoxSucursales.Depth = 0;
            checkedListBoxSucursales.Location = new Point(916, 55);
            checkedListBoxSucursales.MouseState = MaterialSkin.MouseState.HOVER;
            checkedListBoxSucursales.Name = "checkedListBoxSucursales";
            checkedListBoxSucursales.Size = new Size(254, 141);
            checkedListBoxSucursales.Striped = false;
            checkedListBoxSucursales.StripeDarkColor = Color.Empty;
            checkedListBoxSucursales.TabIndex = 9;
            // 
            // BuscarMarcaje
            // 
            BuscarMarcaje.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BuscarMarcaje.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BuscarMarcaje.Depth = 0;
            BuscarMarcaje.HighEmphasis = true;
            BuscarMarcaje.Icon = null;
            BuscarMarcaje.Location = new Point(566, 230);
            BuscarMarcaje.Margin = new Padding(4, 6, 4, 6);
            BuscarMarcaje.MouseState = MaterialSkin.MouseState.HOVER;
            BuscarMarcaje.Name = "BuscarMarcaje";
            BuscarMarcaje.NoAccentTextColor = Color.Empty;
            BuscarMarcaje.Size = new Size(77, 36);
            BuscarMarcaje.TabIndex = 8;
            BuscarMarcaje.Text = "Buscar";
            BuscarMarcaje.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BuscarMarcaje.UseAccentColor = false;
            BuscarMarcaje.UseVisualStyleBackColor = true;
            BuscarMarcaje.Click += BuscarMarcaje_Click;
            // 
            // checkedListBoxEmpleados
            // 
            checkedListBoxEmpleados.AutoScroll = true;
            checkedListBoxEmpleados.BackColor = Color.Transparent;
            checkedListBoxEmpleados.Depth = 0;
            checkedListBoxEmpleados.Location = new Point(575, 55);
            checkedListBoxEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            checkedListBoxEmpleados.Name = "checkedListBoxEmpleados";
            checkedListBoxEmpleados.Size = new Size(261, 141);
            checkedListBoxEmpleados.Striped = false;
            checkedListBoxEmpleados.StripeDarkColor = Color.Empty;
            checkedListBoxEmpleados.TabIndex = 6;
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Location = new Point(57, 138);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(321, 33);
            dateTimePickerFin.TabIndex = 5;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(57, 55);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(321, 33);
            dateTimePickerInicio.TabIndex = 4;
            // 
            // listViewResultados
            // 
            listViewResultados.AutoSizeTable = false;
            listViewResultados.BackColor = Color.FromArgb(255, 255, 255);
            listViewResultados.BorderStyle = BorderStyle.None;
            listViewResultados.Columns.AddRange(new ColumnHeader[] { Fecha, Tipo, Empleado, Sucursal });
            listViewResultados.Depth = 0;
            listViewResultados.FullRowSelect = true;
            listViewResultados.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            listViewResultados.Location = new Point(164, 286);
            listViewResultados.MinimumSize = new Size(200, 100);
            listViewResultados.MouseLocation = new Point(-1, -1);
            listViewResultados.MouseState = MaterialSkin.MouseState.OUT;
            listViewResultados.Name = "listViewResultados";
            listViewResultados.OwnerDraw = true;
            listViewResultados.Size = new Size(957, 284);
            listViewResultados.TabIndex = 0;
            listViewResultados.UseCompatibleStateImageBehavior = false;
            listViewResultados.View = View.Details;
            // 
            // Fecha
            // 
            Fecha.Text = "Fecha";
            Fecha.Width = 200;
            // 
            // Tipo
            // 
            Tipo.Text = "Tipo";
            Tipo.Width = 150;
            // 
            // Empleado
            // 
            Empleado.Text = "Empleado";
            Empleado.Width = 300;
            // 
            // Sucursal
            // 
            Sucursal.Text = "Sucursal";
            Sucursal.Width = 300;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(materialLabel12);
            tabPage4.Controls.Add(btnEliminarSucursal);
            tabPage4.Controls.Add(nombreSucursal);
            tabPage4.Controls.Add(idSucursal);
            tabPage4.Controls.Add(btnEditarSucursal);
            tabPage4.Controls.Add(btnAgregarSucursal);
            tabPage4.Controls.Add(materialListBox1);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1238, 576);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Sucursales";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(299, 77);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(57, 19);
            materialLabel12.TabIndex = 6;
            materialLabel12.Text = "Nombre";
            // 
            // btnEliminarSucursal
            // 
            btnEliminarSucursal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminarSucursal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminarSucursal.Depth = 0;
            btnEliminarSucursal.HighEmphasis = true;
            btnEliminarSucursal.Icon = null;
            btnEliminarSucursal.Location = new Point(721, 219);
            btnEliminarSucursal.Margin = new Padding(4, 6, 4, 6);
            btnEliminarSucursal.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminarSucursal.Name = "btnEliminarSucursal";
            btnEliminarSucursal.NoAccentTextColor = Color.Empty;
            btnEliminarSucursal.Size = new Size(88, 36);
            btnEliminarSucursal.TabIndex = 5;
            btnEliminarSucursal.Text = "Eliminar";
            btnEliminarSucursal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEliminarSucursal.UseAccentColor = false;
            btnEliminarSucursal.UseVisualStyleBackColor = true;
            btnEliminarSucursal.Click += materialButton1_Click_1;
            // 
            // nombreSucursal
            // 
            nombreSucursal.AnimateReadOnly = false;
            nombreSucursal.BorderStyle = BorderStyle.None;
            nombreSucursal.Depth = 0;
            nombreSucursal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nombreSucursal.LeadingIcon = null;
            nombreSucursal.Location = new Point(299, 110);
            nombreSucursal.MaxLength = 50;
            nombreSucursal.MouseState = MaterialSkin.MouseState.OUT;
            nombreSucursal.Multiline = false;
            nombreSucursal.Name = "nombreSucursal";
            nombreSucursal.Size = new Size(613, 50);
            nombreSucursal.TabIndex = 4;
            nombreSucursal.Text = "";
            nombreSucursal.TrailingIcon = null;
            // 
            // idSucursal
            // 
            idSucursal.AnimateReadOnly = false;
            idSucursal.BorderStyle = BorderStyle.None;
            idSucursal.Depth = 0;
            idSucursal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            idSucursal.LeadingIcon = null;
            idSucursal.Location = new Point(25, 24);
            idSucursal.MaxLength = 50;
            idSucursal.MouseState = MaterialSkin.MouseState.OUT;
            idSucursal.Multiline = false;
            idSucursal.Name = "idSucursal";
            idSucursal.Size = new Size(160, 50);
            idSucursal.TabIndex = 3;
            idSucursal.Text = "";
            idSucursal.TrailingIcon = null;
            idSucursal.Visible = false;
            // 
            // btnEditarSucursal
            // 
            btnEditarSucursal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarSucursal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarSucursal.Depth = 0;
            btnEditarSucursal.HighEmphasis = true;
            btnEditarSucursal.Icon = null;
            btnEditarSucursal.Location = new Point(547, 219);
            btnEditarSucursal.Margin = new Padding(4, 6, 4, 6);
            btnEditarSucursal.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditarSucursal.Name = "btnEditarSucursal";
            btnEditarSucursal.NoAccentTextColor = Color.Empty;
            btnEditarSucursal.Size = new Size(71, 36);
            btnEditarSucursal.TabIndex = 2;
            btnEditarSucursal.Text = "Editar";
            btnEditarSucursal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditarSucursal.UseAccentColor = false;
            btnEditarSucursal.UseVisualStyleBackColor = true;
            btnEditarSucursal.Click += materialButton2_Click;
            // 
            // btnAgregarSucursal
            // 
            btnAgregarSucursal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarSucursal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarSucursal.Depth = 0;
            btnAgregarSucursal.HighEmphasis = true;
            btnAgregarSucursal.Icon = null;
            btnAgregarSucursal.Location = new Point(372, 219);
            btnAgregarSucursal.Margin = new Padding(4, 6, 4, 6);
            btnAgregarSucursal.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarSucursal.Name = "btnAgregarSucursal";
            btnAgregarSucursal.NoAccentTextColor = Color.Empty;
            btnAgregarSucursal.Size = new Size(88, 36);
            btnAgregarSucursal.TabIndex = 1;
            btnAgregarSucursal.Text = "Agregar";
            btnAgregarSucursal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregarSucursal.UseAccentColor = false;
            btnAgregarSucursal.UseVisualStyleBackColor = true;
            btnAgregarSucursal.Click += materialButton1_Click;
            // 
            // materialListBox1
            // 
            materialListBox1.BackColor = Color.White;
            materialListBox1.BorderColor = Color.LightGray;
            materialListBox1.Depth = 0;
            materialListBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBox1.Location = new Point(286, 279);
            materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialListBox1.Name = "materialListBox1";
            materialListBox1.SelectedIndex = -1;
            materialListBox1.SelectedItem = null;
            materialListBox1.Size = new Size(626, 237);
            materialListBox1.TabIndex = 0;
            materialListBox1.SelectedIndexChanged += materialListBox1_SelectedIndexChanged;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(materialLabel14);
            tabPage5.Controls.Add(materialLabel13);
            tabPage5.Controls.Add(sucursalesCombo);
            tabPage5.Controls.Add(eliminarEmpleado);
            tabPage5.Controls.Add(nombreEmpleado);
            tabPage5.Controls.Add(idEmpleado);
            tabPage5.Controls.Add(editarEmpleado);
            tabPage5.Controls.Add(agregarEmpleado);
            tabPage5.Controls.Add(listBoxEmpleados);
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1238, 576);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Empleados";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // materialLabel14
            // 
            materialLabel14.AutoSize = true;
            materialLabel14.Depth = 0;
            materialLabel14.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel14.Location = new Point(725, 96);
            materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel14.Name = "materialLabel14";
            materialLabel14.Size = new Size(79, 19);
            materialLabel14.TabIndex = 14;
            materialLabel14.Text = "Sucursales";
            // 
            // materialLabel13
            // 
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel13.Location = new Point(301, 97);
            materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(57, 19);
            materialLabel13.TabIndex = 13;
            materialLabel13.Text = "Nombre";
            // 
            // sucursalesCombo
            // 
            sucursalesCombo.AutoResize = false;
            sucursalesCombo.BackColor = Color.FromArgb(255, 255, 255);
            sucursalesCombo.Depth = 0;
            sucursalesCombo.DrawMode = DrawMode.OwnerDrawVariable;
            sucursalesCombo.DropDownHeight = 174;
            sucursalesCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sucursalesCombo.DropDownWidth = 121;
            sucursalesCombo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            sucursalesCombo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sucursalesCombo.FormattingEnabled = true;
            sucursalesCombo.IntegralHeight = false;
            sucursalesCombo.ItemHeight = 43;
            sucursalesCombo.Location = new Point(725, 118);
            sucursalesCombo.MaxDropDownItems = 4;
            sucursalesCombo.MouseState = MaterialSkin.MouseState.OUT;
            sucursalesCombo.Name = "sucursalesCombo";
            sucursalesCombo.Size = new Size(202, 49);
            sucursalesCombo.StartIndex = 0;
            sucursalesCombo.TabIndex = 12;
            // 
            // eliminarEmpleado
            // 
            eliminarEmpleado.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            eliminarEmpleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            eliminarEmpleado.Depth = 0;
            eliminarEmpleado.HighEmphasis = true;
            eliminarEmpleado.Icon = null;
            eliminarEmpleado.Location = new Point(736, 226);
            eliminarEmpleado.Margin = new Padding(4, 6, 4, 6);
            eliminarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            eliminarEmpleado.Name = "eliminarEmpleado";
            eliminarEmpleado.NoAccentTextColor = Color.Empty;
            eliminarEmpleado.Size = new Size(88, 36);
            eliminarEmpleado.TabIndex = 11;
            eliminarEmpleado.Text = "Eliminar";
            eliminarEmpleado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            eliminarEmpleado.UseAccentColor = false;
            eliminarEmpleado.UseVisualStyleBackColor = true;
            eliminarEmpleado.Click += eliminarEmpleado_Click;
            // 
            // nombreEmpleado
            // 
            nombreEmpleado.AnimateReadOnly = false;
            nombreEmpleado.BorderStyle = BorderStyle.None;
            nombreEmpleado.Depth = 0;
            nombreEmpleado.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nombreEmpleado.LeadingIcon = null;
            nombreEmpleado.Location = new Point(301, 119);
            nombreEmpleado.MaxLength = 50;
            nombreEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            nombreEmpleado.Multiline = false;
            nombreEmpleado.Name = "nombreEmpleado";
            nombreEmpleado.Size = new Size(332, 50);
            nombreEmpleado.TabIndex = 10;
            nombreEmpleado.Text = "";
            nombreEmpleado.TrailingIcon = null;
            // 
            // idEmpleado
            // 
            idEmpleado.AnimateReadOnly = false;
            idEmpleado.BorderStyle = BorderStyle.None;
            idEmpleado.Depth = 0;
            idEmpleado.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            idEmpleado.LeadingIcon = null;
            idEmpleado.Location = new Point(33, 28);
            idEmpleado.MaxLength = 50;
            idEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            idEmpleado.Multiline = false;
            idEmpleado.Name = "idEmpleado";
            idEmpleado.Size = new Size(160, 50);
            idEmpleado.TabIndex = 9;
            idEmpleado.Text = "";
            idEmpleado.TrailingIcon = null;
            idEmpleado.Visible = false;
            // 
            // editarEmpleado
            // 
            editarEmpleado.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            editarEmpleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            editarEmpleado.Depth = 0;
            editarEmpleado.HighEmphasis = true;
            editarEmpleado.Icon = null;
            editarEmpleado.Location = new Point(562, 226);
            editarEmpleado.Margin = new Padding(4, 6, 4, 6);
            editarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            editarEmpleado.Name = "editarEmpleado";
            editarEmpleado.NoAccentTextColor = Color.Empty;
            editarEmpleado.Size = new Size(71, 36);
            editarEmpleado.TabIndex = 8;
            editarEmpleado.Text = "Editar";
            editarEmpleado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            editarEmpleado.UseAccentColor = false;
            editarEmpleado.UseVisualStyleBackColor = true;
            editarEmpleado.Click += editarEmpleado_Click;
            // 
            // agregarEmpleado
            // 
            agregarEmpleado.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            agregarEmpleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            agregarEmpleado.Depth = 0;
            agregarEmpleado.HighEmphasis = true;
            agregarEmpleado.Icon = null;
            agregarEmpleado.Location = new Point(387, 226);
            agregarEmpleado.Margin = new Padding(4, 6, 4, 6);
            agregarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            agregarEmpleado.Name = "agregarEmpleado";
            agregarEmpleado.NoAccentTextColor = Color.Empty;
            agregarEmpleado.Size = new Size(88, 36);
            agregarEmpleado.TabIndex = 7;
            agregarEmpleado.Text = "Agregar";
            agregarEmpleado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            agregarEmpleado.UseAccentColor = false;
            agregarEmpleado.UseVisualStyleBackColor = true;
            agregarEmpleado.Click += agregarEmpleado_Click;
            // 
            // listBoxEmpleados
            // 
            listBoxEmpleados.BackColor = Color.White;
            listBoxEmpleados.BorderColor = Color.LightGray;
            listBoxEmpleados.Depth = 0;
            listBoxEmpleados.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            listBoxEmpleados.Location = new Point(301, 286);
            listBoxEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            listBoxEmpleados.Name = "listBoxEmpleados";
            listBoxEmpleados.SelectedIndex = -1;
            listBoxEmpleados.SelectedItem = null;
            listBoxEmpleados.Size = new Size(626, 237);
            listBoxEmpleados.TabIndex = 6;
            listBoxEmpleados.SelectedIndexChanged += listBoxEmpleados_SelectedIndexChanged;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(textBoxIdUsuario);
            tabPage6.Controls.Add(listBoxSucursalesUsuario);
            tabPage6.Controls.Add(dataGridViewUsuarios);
            tabPage6.Controls.Add(materialLabel11);
            tabPage6.Controls.Add(txtNombre);
            tabPage6.Controls.Add(materialLabel10);
            tabPage6.Controls.Add(materialLabel9);
            tabPage6.Controls.Add(materialLabel8);
            tabPage6.Controls.Add(txtUsuario);
            tabPage6.Controls.Add(materialLabel7);
            tabPage6.Controls.Add(txtPassword);
            tabPage6.Controls.Add(btnEliminarUsuario);
            tabPage6.Controls.Add(btnEditarUsuario);
            tabPage6.Controls.Add(btnAgregarUsuario);
            tabPage6.Controls.Add(roles);
            tabPage6.Location = new Point(4, 34);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1238, 576);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Usuarios";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // textBoxIdUsuario
            // 
            textBoxIdUsuario.Location = new Point(184, 0);
            textBoxIdUsuario.Name = "textBoxIdUsuario";
            textBoxIdUsuario.Size = new Size(160, 33);
            textBoxIdUsuario.TabIndex = 29;
            textBoxIdUsuario.Visible = false;
            // 
            // listBoxSucursalesUsuario
            // 
            listBoxSucursalesUsuario.FormattingEnabled = true;
            listBoxSucursalesUsuario.Location = new Point(83, 453);
            listBoxSucursalesUsuario.Name = "listBoxSucursalesUsuario";
            listBoxSucursalesUsuario.Size = new Size(401, 94);
            listBoxSucursalesUsuario.TabIndex = 28;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.883117F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.InfoText;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.883117F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewUsuarios.GridColor = SystemColors.ControlLightLight;
            dataGridViewUsuarios.Location = new Point(662, 41);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersWidth = 66;
            dataGridViewUsuarios.Size = new Size(536, 512);
            dataGridViewUsuarios.TabIndex = 27;
            dataGridViewUsuarios.CellClick += dataGridViewUsuarios_CellClick;
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(85, 210);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(57, 19);
            materialLabel11.TabIndex = 26;
            materialLabel11.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.AnimateReadOnly = false;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Depth = 0;
            txtNombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombre.LeadingIcon = null;
            txtNombre.Location = new Point(85, 232);
            txtNombre.MaxLength = 50;
            txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(399, 50);
            txtNombre.TabIndex = 25;
            txtNombre.Text = "";
            txtNombre.TrailingIcon = null;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(85, 416);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(79, 19);
            materialLabel10.TabIndex = 24;
            materialLabel10.Text = "Sucursales";
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(85, 302);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(40, 19);
            materialLabel9.TabIndex = 23;
            materialLabel9.Text = "Roles";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(83, 14);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(55, 19);
            materialLabel8.TabIndex = 22;
            materialLabel8.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.AnimateReadOnly = false;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Depth = 0;
            txtUsuario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsuario.LeadingIcon = null;
            txtUsuario.Location = new Point(85, 45);
            txtUsuario.MaxLength = 50;
            txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            txtUsuario.Multiline = false;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(399, 50);
            txtUsuario.TabIndex = 21;
            txtUsuario.Text = "";
            txtUsuario.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(83, 113);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(82, 19);
            materialLabel7.TabIndex = 20;
            materialLabel7.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.AnimateReadOnly = false;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(85, 148);
            txtPassword.MaxLength = 50;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Password = true;
            txtPassword.Size = new Size(399, 50);
            txtPassword.TabIndex = 19;
            txtPassword.Text = "";
            txtPassword.TrailingIcon = null;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEliminarUsuario.Depth = 0;
            btnEliminarUsuario.HighEmphasis = true;
            btnEliminarUsuario.Icon = null;
            btnEliminarUsuario.Location = new Point(524, 382);
            btnEliminarUsuario.Margin = new Padding(4, 6, 4, 6);
            btnEliminarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.NoAccentTextColor = Color.Empty;
            btnEliminarUsuario.Size = new Size(88, 36);
            btnEliminarUsuario.TabIndex = 15;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEliminarUsuario.UseAccentColor = false;
            btnEliminarUsuario.UseVisualStyleBackColor = true;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarUsuario.Depth = 0;
            btnEditarUsuario.HighEmphasis = true;
            btnEditarUsuario.Icon = null;
            btnEditarUsuario.Location = new Point(524, 222);
            btnEditarUsuario.Margin = new Padding(4, 6, 4, 6);
            btnEditarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.NoAccentTextColor = Color.Empty;
            btnEditarUsuario.Size = new Size(71, 36);
            btnEditarUsuario.TabIndex = 14;
            btnEditarUsuario.Text = "Editar";
            btnEditarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditarUsuario.UseAccentColor = false;
            btnEditarUsuario.UseVisualStyleBackColor = true;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregarUsuario.Depth = 0;
            btnAgregarUsuario.HighEmphasis = true;
            btnAgregarUsuario.Icon = null;
            btnAgregarUsuario.Location = new Point(524, 59);
            btnAgregarUsuario.Margin = new Padding(4, 6, 4, 6);
            btnAgregarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.NoAccentTextColor = Color.Empty;
            btnAgregarUsuario.Size = new Size(88, 36);
            btnAgregarUsuario.TabIndex = 13;
            btnAgregarUsuario.Text = "Agregar";
            btnAgregarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregarUsuario.UseAccentColor = false;
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // roles
            // 
            roles.AutoResize = false;
            roles.BackColor = Color.FromArgb(255, 255, 255);
            roles.Depth = 0;
            roles.DrawMode = DrawMode.OwnerDrawVariable;
            roles.DropDownHeight = 174;
            roles.DropDownStyle = ComboBoxStyle.DropDownList;
            roles.DropDownWidth = 121;
            roles.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            roles.ForeColor = Color.FromArgb(222, 0, 0, 0);
            roles.FormattingEnabled = true;
            roles.IntegralHeight = false;
            roles.ItemHeight = 43;
            roles.Location = new Point(85, 341);
            roles.MaxDropDownItems = 4;
            roles.MouseState = MaterialSkin.MouseState.OUT;
            roles.Name = "roles";
            roles.Size = new Size(194, 49);
            roles.StartIndex = 0;
            roles.TabIndex = 0;
            // 
            // materialLabel15
            // 
            materialLabel15.AutoSize = true;
            materialLabel15.Depth = 0;
            materialLabel15.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel15.Location = new Point(167, 71);
            materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel15.Name = "materialLabel15";
            materialLabel15.Size = new Size(162, 19);
            materialLabel15.TabIndex = 0;
            materialLabel15.Text = "Seleccionar Empleado:";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 681);
            Controls.Add(TabMenu);
            DrawerTabControl = TabMenu;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            TabMenu.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabMenu;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private TabPage tabPage4;
        private MaterialSkin.Controls.MaterialListBox materialListBox1;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private MaterialSkin.Controls.MaterialTextBox nombreSucursal;
        private MaterialSkin.Controls.MaterialTextBox idSucursal;
        private MaterialSkin.Controls.MaterialButton btnEditarSucursal;
        private MaterialSkin.Controls.MaterialButton btnAgregarSucursal;
        private MaterialSkin.Controls.MaterialButton btnEliminarSucursal;
        private MaterialSkin.Controls.MaterialComboBox roles;
        private MaterialSkin.Controls.MaterialButton eliminarEmpleado;
        private MaterialSkin.Controls.MaterialTextBox nombreEmpleado;
        private MaterialSkin.Controls.MaterialTextBox idEmpleado;
        private MaterialSkin.Controls.MaterialButton editarEmpleado;
        private MaterialSkin.Controls.MaterialButton agregarEmpleado;
        private MaterialSkin.Controls.MaterialListBox listBoxEmpleados;
        private MaterialSkin.Controls.MaterialComboBox sucursalesCombo;
        private DateTimePicker dateTimePickerFin;
        private DateTimePicker dateTimePickerInicio;
        private MaterialSkin.Controls.MaterialListView listViewResultados;
        private MaterialSkin.Controls.MaterialButton BuscarMarcaje;
        private MaterialSkin.Controls.MaterialCheckedListBox checkedListBoxEmpleados;
        private MaterialSkin.Controls.MaterialCheckedListBox checkedListBoxSucursales;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private ColumnHeader Fecha;
        private ColumnHeader Tipo;
        private ColumnHeader Empleado;
        private ColumnHeader Sucursal;
        private MaterialSkin.Controls.MaterialButton Salir;
        private MaterialSkin.Controls.MaterialButton btnEliminarUsuario;
        private MaterialSkin.Controls.MaterialButton btnEditarUsuario;
        private MaterialSkin.Controls.MaterialButton btnAgregarUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private CheckedListBox listBoxSucursalesUsuario;
        private DataGridView dataGridViewUsuarios;
        private TextBox textBoxIdUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialComboBox cmbEmpleadosRegister;
        private MaterialSkin.Controls.MaterialButton RegisterFingerPrint;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
    }
}