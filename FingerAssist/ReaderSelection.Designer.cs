namespace UareUSampleCSharp
{
    partial class ReaderSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false</param>
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
            btnBack = new Button();
            btnSelect = new Button();
            btnCaps = new Button();
            btnRefresh = new Button();
            cboReaders = new ComboBox();
            lblSelectReader = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(262, 290);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(130, 43);
            btnBack.TabIndex = 18;
            btnBack.Text = "Atras";
            btnBack.Click += btnBack_Click;
            // 
            // btnSelect
            // 
            btnSelect.Enabled = false;
            btnSelect.Location = new Point(87, 290);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(126, 42);
            btnSelect.TabIndex = 17;
            btnSelect.Text = "Seleccionar";
            btnSelect.Click += btnReaderSelect_Click;
            // 
            // btnCaps
            // 
            btnCaps.Enabled = false;
            btnCaps.Location = new Point(262, 212);
            btnCaps.Name = "btnCaps";
            btnCaps.Size = new Size(130, 43);
            btnCaps.TabIndex = 16;
            btnCaps.Text = "Capacidades";
            btnCaps.Click += btnCaps_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(87, 212);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(126, 43);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "Refrescar Lista";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cboReaders
            // 
            cboReaders.Font = new Font("Tahoma", 8F);
            cboReaders.Location = new Point(87, 148);
            cboReaders.Name = "cboReaders";
            cboReaders.Size = new Size(305, 29);
            cboReaders.TabIndex = 14;
            // 
            // lblSelectReader
            // 
            lblSelectReader.Location = new Point(87, 111);
            lblSelectReader.Name = "lblSelectReader";
            lblSelectReader.Size = new Size(296, 34);
            lblSelectReader.TabIndex = 13;
            lblSelectReader.Text = "Seleccionar Lector";
            // 
            // ReaderSelection
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(500, 400);
            Controls.Add(btnBack);
            Controls.Add(btnSelect);
            Controls.Add(btnCaps);
            Controls.Add(btnRefresh);
            Controls.Add(cboReaders);
            Controls.Add(lblSelectReader);
            MaximizeBox = false;
            MaximumSize = new Size(500, 400);
            MinimizeBox = false;
            MinimumSize = new Size(500, 400);
            Name = "ReaderSelection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select Reader";
            Load += ReaderSelection_Load;
            ResumeLayout(false);
        }

        #endregion

        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Button btnSelect;
        internal System.Windows.Forms.Button btnCaps;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.ComboBox cboReaders;
        internal System.Windows.Forms.Label lblSelectReader;
    }
}