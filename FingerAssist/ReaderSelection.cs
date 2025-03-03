﻿using System;
using System.Windows.Forms;
using DPUruNet;
using MaterialSkin;
using MaterialSkin.Controls;
using Sistema_Empresarial;

namespace UareUSampleCSharp
{
    public partial class ReaderSelection : MaterialForm
    {
        private ReaderCollection _readers;

        private RegistrarHuella _sender;

        public RegistrarHuella Sender
        {
            get { return _sender; }
            set { _sender = value; }
        }
    
        private Reader _reader;

        public Reader CurrentReader
        {
            get { return _reader; }
            set { _reader = value; }
        }
                
        public ReaderSelection()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.BlueGrey700, Primary.LightBlue50, Accent.Blue100, TextShade.WHITE);

        }

        /// <summary>
        /// Clear the control of readers, get readers and display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(System.Object sender, System.EventArgs e)
        {
            cboReaders.Text = string.Empty;
            cboReaders.Items.Clear();
            cboReaders.SelectedIndex = -1;

            try
            {
                _readers = ReaderCollection.GetReaders();

                foreach (Reader Reader in _readers)
                {
                    cboReaders.Items.Add(Reader.Description.SerialNumber);
                }

                if (cboReaders.Items.Count > 0)
                {
                    cboReaders.SelectedIndex = 0;
                    btnCaps.Enabled = true;
                    btnSelect.Enabled = true;
                }
                else
                {
                    btnSelect.Enabled = false;
                    btnCaps.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                //message box:
                String text = ex.Message;
                text += "\r\n\r\nPlease check if DigitalPersona service has been started";
                String caption = "Cannot access readers";
                MessageBox.Show(text, caption);
            }
        }

        private Capabilities _caps;
        private void btnCaps_Click(System.Object sender, System.EventArgs e)
        {
            _reader = _readers[cboReaders.SelectedIndex];

            if (_caps == null)
            {
                _caps = new Capabilities();
                _caps.Sender = this;
            }

            _caps.ShowDialog();
        }

        private void btnReaderSelect_Click(System.Object sender, System.EventArgs e)
        {
            if (_sender.CurrentReader != null)
            {
                _sender.CurrentReader.Dispose();
                _sender.CurrentReader = null;
            }
            _sender.CurrentReader = _readers[cboReaders.SelectedIndex];
            this.Close();
        }

        private void btnBack_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void ReaderSelection_Load(object sender, System.EventArgs e)
        {
            btnRefresh_Click(this, new System.EventArgs());
        }
    }
}
