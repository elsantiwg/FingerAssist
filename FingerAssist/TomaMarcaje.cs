using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Empresarial
{
    public partial class TomaMarcaje : MaterialForm
    {
        private readonly Database db;
        private int empleadoId;

        public TomaMarcaje()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.BlueGrey700, Primary.LightBlue50, Accent.Blue100, TextShade.WHITE);
            marcajeEntrada.Icon = Image.FromFile("public/start.png");
            marcajeIniAlmuerzo.Icon = Image.FromFile("public/lunch.png");
            marcajeFinAlmuerzo.Icon = Image.FromFile("public/lunchend.png");
            marcajeSalida.Icon = Image.FromFile("public/out.png");

            string servidor = ConfigurationManager.AppSettings["servidor"] ?? "";
            string puerto = ConfigurationManager.AppSettings["puerto"] ?? "";
            string usuario = ConfigurationManager.AppSettings["usuario"] ?? "";
            string contraseña = ConfigurationManager.AppSettings["contraseña"] ?? "";
            string baseDatos = ConfigurationManager.AppSettings["baseDatos"] ?? "";
            db = new Database(servidor, puerto, usuario, contraseña, baseDatos);
        }

        private void IngresoHuella_Load(object sender, EventArgs e)
        {
          
           empleadoId = GlobalVariables.EmpleadoIdVerify;
            VerificarMarcajesYDeshabilitarBotones(empleadoId);
        }
        private void VerificarMarcajesYDeshabilitarBotones(int empleadoId)
        {
            string consulta = $"SELECT tipo FROM Marcajes WHERE empleado_id = {empleadoId} AND DATE(fecha) = CURRENT_DATE";
            DataTable dt = db.EjecutarConsulta(consulta);

          
            bool puedeMarcarEntrada = true;
            bool puedeMarcarInicioAlmuerzo = true;
            bool puedeMarcarFinAlmuerzo = true;
            bool puedeMarcarSalida = true;

            foreach (DataRow row in dt.Rows)
            {
                string tipoMarcaje = row["tipo"].ToString();
                switch (tipoMarcaje)
                {
                    case "Entrada":
                        puedeMarcarEntrada = false;
                        break;
                    case "Inicio Almuerzo":
                        puedeMarcarInicioAlmuerzo = false;
                        break;
                    case "Fin Almuerzo":
                        puedeMarcarFinAlmuerzo = false;
                        break;
                    case "Salida":
                        puedeMarcarSalida = false;
                        break;
                }
            }


            marcajeEntrada.Enabled = puedeMarcarEntrada;
            marcajeIniAlmuerzo.Enabled = puedeMarcarInicioAlmuerzo;
            marcajeFinAlmuerzo.Enabled = puedeMarcarFinAlmuerzo;
            marcajeSalida.Enabled = puedeMarcarSalida;
        }
        private bool ValidarMarcajeInicial(int empleadoId, string tipoMarcaje)
        {
            string tipoMarcajeInicial;
            if (tipoMarcaje == "Fin Almuerzo")
                tipoMarcajeInicial = "Inicio Almuerzo";
            else if (tipoMarcaje == "Salida")
                tipoMarcajeInicial = "Entrada";
            else
                return true; // No necesita validación

            string consulta = $"SELECT COUNT(*) FROM Marcajes WHERE empleado_id = {empleadoId} AND DATE(fecha) = CURRENT_DATE AND tipo = '{tipoMarcajeInicial}'";
            DataTable dt = db.EjecutarConsulta(consulta);
            return Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        private void InsertarMarcaje(int empleadoId, string tipoMarcaje)
        {
            if (!ValidarMarcajeInicial(empleadoId, tipoMarcaje))
            {
                MessageBox.Show($"No se puede registrar '{tipoMarcaje}' sin un '{(tipoMarcaje == "Fin Almuerzo" ? "Inicio Almuerzo" : "Entrada")}' previo en el mismo día.");
                return;
            }

            // Usar DateTime.Now para obtener la fecha y hora actual de .NET
            string fechaActual = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Modificar el comando SQL para usar la fecha y hora de .NET
            string comando = $"INSERT INTO Marcajes (empleado_id, fecha, tipo) VALUES ({empleadoId}, '{fechaActual}', '{tipoMarcaje}')";
            db.EjecutarComando(comando);
            MessageBox.Show($"Marcaje de '{tipoMarcaje}' registrado correctamente.");

            // Actualizar el estado de los botones
            VerificarMarcajesYDeshabilitarBotones(empleadoId);
        }
        private void marcajeEntrada_Click(object sender, EventArgs e)
        {
            InsertarMarcaje(empleadoId, "Entrada");
        }

        private void marcajeIniAlmuerzo_Click(object sender, EventArgs e)
        {
            InsertarMarcaje(empleadoId, "Inicio Almuerzo");
        }

        private void marcajeFinAlmuerzo_Click(object sender, EventArgs e)
        {
            InsertarMarcaje(empleadoId, "Fin Almuerzo");
        }

        private void marcajeSalida_Click(object sender, EventArgs e)
        {
            InsertarMarcaje(empleadoId, "Salida");
        }

    }
}
