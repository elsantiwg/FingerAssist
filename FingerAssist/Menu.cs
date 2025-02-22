using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_Empresarial
{
    public partial class Menu : MaterialForm
    {
        #region "Menu"
        private readonly Database db;
        public Menu()
        {
            InitializeComponent();
            string servidor = ConfigurationManager.AppSettings["servidor"] ?? "";
            string puerto = ConfigurationManager.AppSettings["puerto"] ?? "";
            string usuario = ConfigurationManager.AppSettings["usuario"] ?? "";
            string contraseña = ConfigurationManager.AppSettings["contraseña"] ?? "";
            string baseDatos = ConfigurationManager.AppSettings["baseDatos"] ?? "";
            db = new Database(servidor, puerto, usuario, contraseña, baseDatos);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.BlueGrey700, Primary.LightBlue50, Accent.Blue100, TextShade.WHITE);
            materialLabel1.Font = new Font(materialLabel1.Font.FontFamily, 50, FontStyle.Bold);

            materialLabel1.FontType = MaterialSkinManager.fontType.H1;
            materialLabel2.FontType = MaterialSkinManager.fontType.H1;
            Salir.Icon = Image.FromFile("public/out.png");
            btnAgregarSucursal.Icon = Image.FromFile("public/add.png");
            btnEditarSucursal.Icon = Image.FromFile("public/edit.png");
            btnEliminarSucursal.Icon = Image.FromFile("public/delete.png");
            agregarEmpleado.Icon = Image.FromFile("public/add.png");
            editarEmpleado.Icon = Image.FromFile("public/edit.png");
            eliminarEmpleado.Icon = Image.FromFile("public/delete.png");
            BuscarMarcaje.Icon = Image.FromFile("public/search.png");
            btnAgregarUsuario.Icon = Image.FromFile("public/add.png");
            btnEditarUsuario.Icon = Image.FromFile("public/edit.png");
            btnEliminarUsuario.Icon = Image.FromFile("public/delete.png");
            RegisterFingerPrint.Icon = Image.FromFile("public/fingerprint.png");


        }

        private void Menu_Load(object sender, EventArgs e)
        {
            materialLabel2.Text = GlobalVariables.Nombre;
            if (GlobalVariables.RolUsuario == "2")
            {
                TabMenu.TabPages.Remove(tabPage6);
            }


        }
        private void TabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = TabMenu.SelectedIndex;

            // Obtener el TabPage seleccionado
            TabPage selectedTabPage = TabMenu.SelectedTab ?? new TabPage();


            switch (selectedIndex)
            {
                case 0:

                    break;
                case 1:
                    CargarEmpleadosVerificarHuella();
                    break;
                case 2:
                    CargarEmpleadosYSucursales();
                    break;

                case 3:
                    CargarSucursales();
                    btnEditarSucursal.Enabled = false;
                    btnEliminarSucursal.Enabled = false;
                    break;
                case 4:
                    CargarSucursalesCombo();
                    CargarEmpleados();
                    editarEmpleado.Enabled = false;
                    eliminarEmpleado.Enabled = false;
                    break;
                case 5:
                    CargarRolesChkLst();
                    CargarSucursalesUsuarioForm();
                    CargarUsuarios();
                    btnEditarUsuario.Enabled = false;
                    btnEliminarUsuario.Enabled = false;
                    break;

            }
        }
        #endregion
        #region "Sucursales"


        private void CargarSucursales()
        {
            string consulta = "SELECT * FROM sucursal";
            DataTable dt = db.EjecutarConsulta(consulta);
            materialListBox1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string nombre = row["nombre"].ToString() ?? "";
                int id = Convert.ToInt32(row["id"]);

                MaterialListBoxItem item = new MaterialListBoxItem(nombre);
                item.Tag = id;

                materialListBox1.Items.Add(item);
            }

        }


        private void LimpiarCampos()
        {
            idSucursal.Text = "";
            nombreSucursal.Text = "";
            btnEliminarSucursal.Enabled = false;
            btnEditarSucursal.Enabled = false;

        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreSucursal.Text))
            {
                MaterialMessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos requeridos");
                return;
            }

            string nombre = nombreSucursal.Text;
            try
            {
                string comando = $"INSERT INTO sucursal (nombre) VALUES ('{nombre}')";
                db.EjecutarComando(comando);

                CargarSucursales();
                LimpiarCampos();
                MessageBox.Show("Sucursal agregada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la sucursal: " + ex.Message);
            }


        }


        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idSucursal.Text) || string.IsNullOrWhiteSpace(nombreSucursal.Text))
            {
                MaterialMessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos requeridos");
                return;
            }

            int id = Convert.ToInt32(idSucursal.Text);
            string nombre = nombreSucursal.Text;

            try
            {
                string comando = $"UPDATE sucursal SET nombre = '{nombre}' WHERE id = {id}";
                db.EjecutarComando(comando);

                CargarSucursales();
                LimpiarCampos();
                MessageBox.Show("Sucursal actualizada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la sucursal: " + ex.Message);
            }

        }

        private void materialListBox1_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            if (materialListBox1.SelectedIndex >= 0)
            {
                int id = (int)((MaterialListBoxItem)materialListBox1.SelectedItem).Tag;
                string consulta = $"SELECT * FROM sucursal WHERE id = {id}";
                DataTable dt = db.EjecutarConsulta(consulta);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    idSucursal.Text = row["id"].ToString();
                    nombreSucursal.Text = row["nombre"].ToString();


                    btnEditarSucursal.Enabled = true;
                    btnEliminarSucursal.Enabled = true;
                }
            }
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(idSucursal.Text);

                string comando = $"DELETE FROM sucursal WHERE id = {id}";
                db.EjecutarComando(comando);

                CargarSucursales();
                LimpiarCampos();
                MessageBox.Show("Sucursal eliminada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la sucursal: " + ex.Message);
            }
        }
        #endregion

        #region "Usuarios"



        private void CargarRolesChkLst()
        {
            string consulta = "SELECT * FROM roles";
            DataTable dt = db.EjecutarConsulta(consulta);
            roles.DataSource = null;


            roles.DataSource = dt;
            roles.DisplayMember = "rol_name";
            roles.ValueMember = "id";


        }
        private void Salir_Click(object sender, EventArgs e)
        {
            Form form = new Login();
            form.Show();
            this.Hide();
        }

        private void CargarSucursalesUsuarioForm()
        {
            listBoxSucursalesUsuario.DataSource = null;
            DataTable sucursales = db.EjecutarConsulta("SELECT id, nombre FROM Sucursal");
            listBoxSucursalesUsuario.DataSource = sucursales;
            listBoxSucursalesUsuario.DisplayMember = "Nombre";
            listBoxSucursalesUsuario.ValueMember = "Id";



        }
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string usuario = txtUsuario.Text;
            string contrasena = txtPassword.Text;

            // Validar los campos con expresiones regulares
            if (!Regex.IsMatch(nombre, @"^[a-zA-Z]+$") || !Regex.IsMatch(usuario, @"^[a-zA-Z0-9]+$") || !Regex.IsMatch(contrasena, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Los campos no pueden estar vacíos ni contener caracteres especiales.");
                return;
            }
            try
            {
                int rolId = Convert.ToInt32(roles.SelectedValue);

                // Insertar usuario
                string consulta = $"INSERT INTO usuarios (nombre, usuario, contrasena, rol_id) VALUES ('{nombre}', '{usuario}', '{contrasena}', {rolId}) RETURNING id";
                DataTable resultado = db.EjecutarConsulta(consulta);
                int usuarioId = Convert.ToInt32(resultado.Rows[0]["id"]);

                // Insertar relaciones usuario-sucursal
                foreach (DataRowView item in listBoxSucursalesUsuario.CheckedItems)
                {
                    int sucursalId = Convert.ToInt32(item["id"]);
                    string comando = $"INSERT INTO usuario_sucursal (usuario_id, sucursal_id) VALUES ({usuarioId}, {sucursalId})";
                    db.EjecutarComando(comando);
                }

                MessageBox.Show("Usuario guardado exitosamente.");
                LimpiarCamposUsuario();
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el usuario: " + ex.Message);
            }

        }
        private void LimpiarCamposUsuario()
        {
            textBoxIdUsuario.Clear();
            txtNombre.Clear();
            txtUsuario.Clear();
            txtPassword.Clear();
            roles.SelectedIndex = 0;
            btnEditarUsuario.Enabled = false;
            btnEliminarUsuario.Enabled = false;
            CargarSucursalesUsuarioForm();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            int usuarioId = Convert.ToInt32(textBoxIdUsuario.Text);
            string nombre = txtNombre.Text;
            string usuario = txtUsuario.Text;
            string contrasena = txtPassword.Text;

            // Validar los campos con expresiones regulares
            if (!Regex.IsMatch(nombre, @"^[a-zA-Z]+$") || !Regex.IsMatch(usuario, @"^[a-zA-Z0-9]+$") || !Regex.IsMatch(contrasena, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Los campos no pueden estar vacíos ni contener caracteres especiales.");
                return;
            }
            try
            {
                int rolId = Convert.ToInt32(roles.SelectedValue);

                // Actualizar usuario
                string comando = $"UPDATE usuarios SET nombre = '{nombre}', usuario = '{usuario}', contrasena = '{contrasena}', rol_id = {rolId} WHERE id = {usuarioId}";
                db.EjecutarComando(comando);

                // Eliminar relaciones usuario-sucursal existentes
                comando = $"DELETE FROM usuario_sucursal WHERE usuario_id = {usuarioId}";
                db.EjecutarComando(comando);

                // Insertar nuevas relaciones usuario-sucursal
                foreach (DataRowView item in listBoxSucursalesUsuario.CheckedItems)
                {
                    int sucursalId = Convert.ToInt32(item["id"]);
                    comando = $"INSERT INTO usuario_sucursal (usuario_id, sucursal_id) VALUES ({usuarioId}, {sucursalId})";
                    db.EjecutarComando(comando);
                }

                MessageBox.Show("Usuario actualizado exitosamente.");
                LimpiarCamposUsuario();
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
            }


        }
        private void CargarUsuarios()
        {
            dataGridViewUsuarios.DataSource = null;
            string consulta = @"
                                SELECT 
                                    u.id, 
                                    u.nombre, 
                                    u.usuario, 
                                    r.rol_name,
                                    STRING_AGG(s.nombre, ', ') AS sucursales
                                FROM 
                                    usuarios u
                                    JOIN roles r ON u.rol_id = r.id
                                    LEFT JOIN usuario_sucursal us ON u.id = us.usuario_id
                                    LEFT JOIN sucursal s ON us.sucursal_id = s.id
                                GROUP BY 
                                    u.id, 
                                    u.nombre, 
                                    u.usuario, 
                                    r.rol_name";
            DataTable usuarios = db.EjecutarConsulta(consulta);
            dataGridViewUsuarios.DataSource = usuarios;

        }




        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            int usuarioId = Convert.ToInt32(textBoxIdUsuario.Text);
            try
            {
                // Eliminar relaciones usuario-sucursal
                string comando = $"DELETE FROM usuario_sucursal WHERE usuario_id = {usuarioId}";
                db.EjecutarComando(comando);

                // Eliminar usuario
                comando = $"DELETE FROM usuarios WHERE id = {usuarioId}";
                db.EjecutarComando(comando);

                MessageBox.Show("Usuario eliminado exitosamente.");
                LimpiarCamposUsuario();
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }

        }
        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que el usuario no haya hecho clic en el encabezado de la columna
            {
                DataGridViewRow filaSeleccionada = dataGridViewUsuarios.Rows[e.RowIndex];
                int usuarioId = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);

                // Llenar TextBox con los datos del usuario seleccionado
                textBoxIdUsuario.Text = filaSeleccionada.Cells["id"].Value.ToString();
                txtNombre.Text = filaSeleccionada.Cells["nombre"].Value.ToString();
                txtUsuario.Text = filaSeleccionada.Cells["usuario"].Value.ToString();
                txtPassword.Text = "";

                // Seleccionar el rol correspondiente en el ComboBox
                string rolSeleccionado = filaSeleccionada.Cells["rol_name"].Value.ToString();
                roles.SelectedIndex = roles.FindStringExact(rolSeleccionado);


                CargarSucursalesUsuarioForm();
                string consultaSucursales = $"SELECT sucursal_id FROM usuario_sucursal WHERE usuario_id = {usuarioId}";
                DataTable sucursalesUsuario = db.EjecutarConsulta(consultaSucursales);
                foreach (DataRow row in sucursalesUsuario.Rows)
                {
                    int sucursalId = Convert.ToInt32(row["sucursal_id"]);
                    for (int i = 0; i < listBoxSucursalesUsuario.Items.Count; i++)
                    {
                        DataRowView item = (DataRowView)listBoxSucursalesUsuario.Items[i];
                        if (Convert.ToInt32(item["id"]) == sucursalId)
                        {
                            listBoxSucursalesUsuario.SetItemChecked(i, true);
                            break;
                        }
                    }
                }
            }
            btnEditarUsuario.Enabled = true;
            btnEliminarUsuario.Enabled = true;
        }
        #endregion

        #region "Empleados"
        private void CargarSucursalesCombo()
        {
            string consulta = "SELECT * FROM sucursal";
            DataTable dt = db.EjecutarConsulta(consulta);
            sucursalesCombo.DataSource = null;


            sucursalesCombo.DataSource = dt;
            sucursalesCombo.DisplayMember = "nombre";
            sucursalesCombo.ValueMember = "id";


        }
        private void CargarEmpleados()
        {
            string consulta = "SELECT a.id as empleadoid, a.nombre as nombreEmpleado, b.id as idSucursal, b.nombre as nombreSucursal FROM Empleados a INNER JOIN sucursal b ON a.sucursal_id = b.id";
            DataTable dt = db.EjecutarConsulta(consulta);
            listBoxEmpleados.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string nombre = row["nombreEmpleado"].ToString() ?? "";
                string sucursal = row["nombreSucursal"].ToString() ?? "";
                int id = Convert.ToInt32(row["empleadoid"]);

                MaterialListBoxItem item = new MaterialListBoxItem(nombre + " - " + sucursal);
                item.Tag = id;

                listBoxEmpleados.Items.Add(item);
            }

        }
        private void agregarEmpleado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreEmpleado.Text))
            {
                MaterialMessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos requeridos");
                return;
            }
            string nombre = nombreEmpleado.Text;
            string idSucursal = sucursalesCombo.SelectedValue.ToString();
            try
            {
                string comando = $"INSERT INTO Empleados (nombre, sucursal_id ) VALUES ('{nombre}', {idSucursal})";
                db.EjecutarComando(comando);

                CargarEmpleados();
                LimpiarCamposEmpleado();
                MessageBox.Show("Empleado agregado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la sucursal: " + ex.Message);
            }

        }
        private void LimpiarCamposEmpleado()
        {
            nombreEmpleado.Text = "";
            sucursalesCombo.SelectedIndex = 0;
            editarEmpleado.Enabled = false;
            eliminarEmpleado.Enabled = false;

        }

        private void editarEmpleado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idEmpleado.Text) || string.IsNullOrWhiteSpace(nombreEmpleado.Text))
            {
                MaterialMessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos requeridos");
                return;
            }
            int id = Convert.ToInt32(idEmpleado.Text);
            string nombre = nombreEmpleado.Text;
            string idSucursal = sucursalesCombo.SelectedValue.ToString();
            try
            {
                string comando = $"UPDATE Empleados SET nombre = '{nombre}', sucursal_id = {idSucursal} WHERE id = {id}";
                db.EjecutarComando(comando);

                CargarEmpleados();
                LimpiarCamposEmpleado();
                MessageBox.Show("Empleado actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el empleado: " + ex.Message);
            }
        }

        private void eliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idEmpleado.Text))
            {
                MaterialMessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos requeridos");
                return;
            }
            int id = Convert.ToInt32(idEmpleado.Text);
            try
            {
                string comando = $"DELETE FROM Empleados WHERE id = {id}";
                db.EjecutarComando(comando);

                CargarEmpleados();
                LimpiarCamposEmpleado();
                MessageBox.Show("Empleado eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el empleado: " + ex.Message);
            }
        }

        private void listBoxEmpleados_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            if (listBoxEmpleados.SelectedIndex >= 0)
            {
                int id = (int)((MaterialListBoxItem)listBoxEmpleados.SelectedItem).Tag;
                string consulta = $"SELECT * FROM Empleados WHERE id = {id}";
                DataTable dt = db.EjecutarConsulta(consulta);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    idEmpleado.Text = row["id"].ToString();
                    nombreEmpleado.Text = row["nombre"].ToString();
                    sucursalesCombo.SelectedValue = row["sucursal_id"];


                    editarEmpleado.Enabled = true;
                    eliminarEmpleado.Enabled = true;
                }
            }
        }

        #endregion


        #region "Reporte Marcajes"
        private void CargarEmpleadosYSucursales()
        {

            while (checkedListBoxEmpleados.Items.Count > 0)
            {
                checkedListBoxEmpleados.Items.Remove(checkedListBoxEmpleados.Items[0]);
            };

            DataTable empleados = db.EjecutarConsulta("SELECT id, nombre FROM Empleados");
            foreach (DataRow row in empleados.Rows)
            {
                checkedListBoxEmpleados.Items.Add($"{row["nombre"]} -- {row["id"]}");
            }
            while (checkedListBoxSucursales.Items.Count > 0)
            {
                checkedListBoxSucursales.Items.Remove(checkedListBoxSucursales.Items[0]);
            };
            DataTable sucursales = db.EjecutarConsulta("SELECT s.id, s.nombre FROM sucursal s INNER JOIN usuario_sucursal us ON s.id = us.sucursal_id INNER JOIN usuarios u ON us.usuario_id = u.id WHERE u.id =" + GlobalVariables.UsuarioID);
            foreach (DataRow row in sucursales.Rows)
            {
                checkedListBoxSucursales.Items.Add($"{row["nombre"]} -- {row["id"]}");

            }
        }



        private void BuscarMarcaje_Click(object sender, EventArgs e)
        {
            string fechaInicio = dateTimePickerInicio.Value.ToString("yyyy-MM-dd");
            string fechaFin = dateTimePickerFin.Value.ToString("yyyy-MM-dd");

            // Construir la lista de IDs de empleados seleccionados
            List<string> empleadosSeleccionados = new List<string>();
            for (int i = 0; i < checkedListBoxEmpleados.Items.Count; i++)
            {
                if (checkedListBoxEmpleados.GetItemCheckState(i) == CheckState.Checked)
                {
                    string item = checkedListBoxEmpleados.Items[i].Text.ToString();
                    string id = item.Split(new string[] { " -- " }, StringSplitOptions.None).Last();
                    empleadosSeleccionados.Add(id);
                }
            }

            //if (empleadosSeleccionados.Count == 0)
            //{
            //    MessageBox.Show("Debes seleccionar al menos un empleado.");
            //    return;
            //}

            // Construir la lista de IDs de sucursales seleccionadas
            List<string> sucursalesSeleccionadas = new List<string>();
            for (int i = 0; i < checkedListBoxSucursales.Items.Count; i++)
            {
                if (checkedListBoxSucursales.GetItemCheckState(i) == CheckState.Checked)
                {
                    string item = checkedListBoxSucursales.Items[i].Text.ToString();
                    string id = item.Split(new string[] { " -- " }, StringSplitOptions.None).Last();
                    sucursalesSeleccionadas.Add(id);
                }
            }

            if (sucursalesSeleccionadas.Count == 0)
            {
                MessageBox.Show("Debes seleccionar al menos una sucursal.");
                return;
            }

            // Construir la consulta SQL con los IDs de empleados y sucursales
            string consulta = "SELECT m.fecha, m.tipo, e.nombre AS empleado, "
                + "s.nombre AS sucursal FROM Marcajes m "
                + "JOIN Empleados e ON m.empleado_id = e.id "
                + "JOIN Sucursal s ON e.sucursal_id = s.id "
                + "WHERE to_char(m.fecha, 'YYYY-MM-DD') BETWEEN '" + fechaInicio + "' AND '" + fechaFin + "'";

            if (empleadosSeleccionados.Count > 0)
            {
                consulta += " AND e.id IN (" + string.Join(",", empleadosSeleccionados) + ")";
            }

            consulta += " AND s.id IN (" + string.Join(",", sucursalesSeleccionadas) + ")";

            DataTable resultados = db.EjecutarConsulta(consulta);
            listViewResultados.Items.Clear();

            foreach (DataRow row in resultados.Rows)
            {
                object[] items = row.ItemArray;
                ListViewItem listViewItem = new ListViewItem(items[0].ToString());// fecha 
                listViewItem.SubItems.Add(items[1].ToString()); //tipo
                listViewItem.SubItems.Add(items[2].ToString()); // empleado
                listViewItem.SubItems.Add(items[3].ToString()); // sucursal


                listViewResultados.Items.Add(listViewItem);
            }
        }
        #endregion


        #region Registrar Huellas

        private void CargarEmpleadosVerificarHuella()
        {
            string consulta = "SELECT * FROM Empleados";
            DataTable dt = db.EjecutarConsulta(consulta);
            cmbEmpleadosRegister.DataSource = null;


            cmbEmpleadosRegister.DataSource = dt;
            cmbEmpleadosRegister.DisplayMember = "nombre";
            cmbEmpleadosRegister.ValueMember = "id";

        }

        private void RegisterFingerPrint_Click(object sender, EventArgs e)
        {
            int empleadoID = Convert.ToInt32(cmbEmpleadosRegister.SelectedValue);
            GlobalVariables.EmpleadoIdRegister = empleadoID;
            GlobalVariables.BanderaVerRegi= false;
            Form RegistrarHuella = new RegistrarHuella();
            RegistrarHuella.Show();

        }
        #endregion
    }

}