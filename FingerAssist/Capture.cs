using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using DPUruNet;
using MaterialSkin;
using MaterialSkin.Controls;
using Sistema_Empresarial;

namespace UareUSampleCSharp
{
    public partial class Capture : MaterialForm
    {
        /// <summary>
        /// Holds the main form with many functions common to all of SDK actions.
        /// </summary>
        public RegistrarHuella _sender;
        private readonly Database db;
        public RegistrarHuella MainForm { get; set; }
        private void CloseMainForm()
        {
            if (MainForm != null)
            {
                MainForm.Close();
            }
        }
        private void CloseForm()
        {
            CloseMainForm();
            this.Close();  // Cierra el formulario
        }
        
        public Capture()
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

        }

        /// <summary>
        /// Initialize the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Capture_Load(object sender, EventArgs e)
        {
            // Reset variables
            pbFingerprint.Image = null;

            if (!_sender.OpenReader())
            {
                this.Close();
            }

            if (!_sender.StartCaptureAsync(this.OnCaptured))
            {
                this.Close();
            }
        }

        /// <summary>
        /// Handler for when a fingerprint is captured.
        /// </summary>
        /// <param name="captureResult">contains info and data on the fingerprint capture</param>
        public void OnCaptured(CaptureResult captureResult)
        {
            try
            {
                // Check capture quality and throw an error if bad.
                if (!_sender.CheckCaptureResult(captureResult))
                {
                    MessageBox.Show("Error: La calidad de la captura no es buena, intente de nuevo.  ");
                    return;
                }
                    
                   

                // Create bitmap
                foreach (Fid.Fiv fiv in captureResult.Data.Views)
                {
                    SendMessage(Action.SendBitmap, _sender.CreateBitmap(fiv.RawImage, fiv.Width, fiv.Height));
                }

                DataResult<Fmd> resultConversion = FeatureExtraction.CreateFmdFromFid(captureResult.Data, Constants.Formats.Fmd.ANSI);
                if (resultConversion.ResultCode != Constants.ResultCode.DP_SUCCESS)
                {
                    _sender.Reset = true;
                    throw new Exception(resultConversion.ResultCode.ToString());
                }
                // Convertir el objeto Fmd a una cadena Base64
                Fmd fmd = resultConversion.Data;
                if (GlobalVariables.BanderaVerRegi == false) {
                    
                    string base64Fmd = Convert.ToBase64String(fmd.Bytes);

                    // Insertar en la base de datos

                    db.InsertarHuella(GlobalVariables.EmpleadoIdRegister, base64Fmd);

                    MessageBox.Show("Huella Registrada, haga clic en Aceptar para continuar.");
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new MethodInvoker(delegate { CloseForm(); }));
                    }
                    else
                    {
                        CloseForm();
                    }
                }
                else
                {
                    // Comparar la huella capturada con las huellas almacenadas en la base de datos
                    MessageBox.Show("Comparando huellas, espere por favor...");
                    int empleadoId = CompararHuellas(fmd);

                    if (empleadoId == 0)
                    {
                        // No se encontró ninguna huella coincidente
                        MessageBox.Show("No se encontró ninguna huella coincidente.");
                    }
                    else
                    {
                        // Huella coincidente encontrada
                        MessageBox.Show($"Huella coincidente encontrada para el empleado ID {empleadoId}.");
                        GlobalVariables.EmpleadoIdVerify = empleadoId;
                        if (this.InvokeRequired)
                        {
                            this.Invoke(new MethodInvoker(delegate { CloseForm(); }));
                        }
                        else
                        {
                            CloseForm();
                        }



                    }
                }
               
            }
            catch (Exception ex)
            {
                // Send error message, then close form
                SendMessage(Action.SendMessage, "Error:  " + ex.Message);                
            }
        }
        private static void AbrirFormulario()
        {
          
            Application.Run(new TomaMarcaje());  // TomaMarcaje es el nombre de tu formulario
        }
        public int CompararHuellas(Fmd huellaCapturada)
        {
            int empleadoId = 0;

            // Obtener todas las huellas registradas en la base de datos
            List<string> huellasRegistradas = db.ObtenerTodasLasHuellas();

            // Definir la constante PROBABILITY_ONE
            const int PROBABILITY_ONE = 0x7fffffff;

            foreach (string huellaBase64 in huellasRegistradas)
            {
                Fmd huellaAlmacenada = ConvertirHuellaBase64AFmd(huellaCapturada,huellaBase64);
               
                // Comparar la huella capturada con cada huella almacenada
      
                CompareResult compareResult = Comparison.Compare(huellaCapturada, 0, huellaAlmacenada, 0);

                if (compareResult.Score < (PROBABILITY_ONE / 100000))
                {
                    // Las huellas coinciden, obtener el ID del empleado correspondiente
                    empleadoId = db.ObtenerEmpleadoIdPorHuella(huellaBase64);
                    break;
                }
            }

            return empleadoId;
        }
        private Fmd ConvertirHuellaBase64AFmd(Fmd huellaCapturada, string huellaBase64)
        {
            byte[] huellaBytes = Convert.FromBase64String(huellaBase64);
            // Suponiendo que la versión del formato FMD es "1.0"
            int ConversionFormate = Convert.ToInt32(Constants.Formats.Fmd.ANSI);
            Fmd obj = new Fmd(huellaBytes, ConversionFormate, Constants.WRAPPER_VERSION);
            return obj;
        }
        /// <summary>
        /// Close window.
        /// </summary>
        private void btnBack_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Close window.
        /// </summary>
        private void Capture_Closed(object sender, EventArgs e)
        {
            _sender.CancelCaptureAndCloseReader(this.OnCaptured);
        }

        #region SendMessage
        private enum Action
        {
            SendBitmap,
            SendMessage
        }
        private delegate void SendMessageCallback(Action action, object payload);
        private void SendMessage(Action action, object payload)
        {
            try
            {
                if (this.pbFingerprint.InvokeRequired)
                {
                    SendMessageCallback d = new SendMessageCallback(SendMessage);
                    this.Invoke(d, new object[] { action, payload });
                }
                else
                {
                    switch (action)
                    {
                        case Action.SendMessage:
                            MessageBox.Show((string)payload);
                            break;
                        case Action.SendBitmap:
                            pbFingerprint.Image = (Bitmap)payload;
                            pbFingerprint.Refresh();
                            break;
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        #endregion
    }
}