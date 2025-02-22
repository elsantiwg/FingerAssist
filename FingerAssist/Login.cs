using MaterialSkin;
using MaterialSkin.Controls;
using System.Configuration;
using System.Data;

namespace Sistema_Empresarial
{

    public partial class Login : MaterialForm
    {
     
        private readonly Database db;
  
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.BlueGrey700, Primary.LightBlue50, Accent.Blue100, TextShade.WHITE);


            string servidor = ConfigurationManager.AppSettings["servidor"] ?? "";
            string puerto = ConfigurationManager.AppSettings["puerto"] ?? "";
            string usuario = ConfigurationManager.AppSettings["usuario"] ?? "";
            string contraseña = ConfigurationManager.AppSettings["contraseña"] ?? "";
            string baseDatos = ConfigurationManager.AppSettings["baseDatos"] ?? "";
             db = new Database(servidor, puerto, usuario, contraseña, baseDatos);
           

            floatingActionButton.Icon = Image.FromFile("public/fingerprint.png");
            floatingActionButton.AutoSize = false;
            floatingActionButton.Size = new Size(140, 50);



        }
   
        private void materialButton1_Click(object sender, EventArgs e)
        {


            if (usertxt.Text == "" || passwordtxt.Text == "")
            {
                MessageBox.Show("Debe ingresar usuario y contraseña");
                return;
            }

            string consulta = $"SELECT * FROM usuarios WHERE usuario = '{usertxt.Text}' AND contrasena = '{passwordtxt.Text}'";
            DataTable resultado = db.EjecutarConsulta(consulta);


            if (resultado.Rows.Count == 0)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }
            else
            {
                GlobalVariables.RolUsuario = resultado.Rows[0]["rol_id"].ToString() ?? "";
                GlobalVariables.Nombre = resultado.Rows[0]["nombre"].ToString() ?? "";
                GlobalVariables.UsuarioID= resultado.Rows[0]["id"].ToString() ?? "";
                Form Menu = new Menu();
                Menu.Show();
                this.Hide();
               
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void FloatingActionButton_Click(object sender, EventArgs e)
        {
            GlobalVariables.BanderaVerRegi = true;
            GlobalVariables.EmpleadoIdVerify = 0;
            RegistrarHuella registrarHuella = new RegistrarHuella();    
            registrarHuella.Show();
            
          
           
                registrarHuella.FormClosed += (sender, e) => {
                    if (GlobalVariables.EmpleadoIdVerify != 0)
                    {
                        TomaMarcaje tomaMarcaje = new TomaMarcaje();
                        tomaMarcaje.Show();
                    }
                };
           
            

        }
    }
}
