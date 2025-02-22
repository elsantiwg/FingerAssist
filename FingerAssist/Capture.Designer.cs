namespace UareUSampleCSharp
{
    partial class Capture
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
            lblPlaceFinger = new Label();
            btnBack = new Button();
            pbFingerprint = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbFingerprint).BeginInit();
            SuspendLayout();
            // 
            // lblPlaceFinger
            // 
            lblPlaceFinger.Location = new Point(21, 448);
            lblPlaceFinger.Name = "lblPlaceFinger";
            lblPlaceFinger.Size = new Size(335, 30);
            lblPlaceFinger.TabIndex = 5;
            lblPlaceFinger.Text = "Porfavor colocar el dedo en el lector";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(362, 448);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(111, 34);
            btnBack.TabIndex = 4;
            btnBack.Text = "Atras";
            btnBack.Click += btnBack_Click;
            // 
            // pbFingerprint
            // 
            pbFingerprint.Location = new Point(21, 77);
            pbFingerprint.Name = "pbFingerprint";
            pbFingerprint.Size = new Size(452, 351);
            pbFingerprint.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFingerprint.TabIndex = 6;
            pbFingerprint.TabStop = false;
            // 
            // Capture
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(500, 500);
            Controls.Add(btnBack);
            Controls.Add(lblPlaceFinger);
            Controls.Add(pbFingerprint);
            MaximizeBox = false;
            MaximumSize = new Size(500, 500);
            MinimizeBox = false;
            MinimumSize = new Size(500, 500);
            Name = "Capture";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Capture";
            Closed += Capture_Closed;
            Load += Capture_Load;
            ((System.ComponentModel.ISupportInitialize)pbFingerprint).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal System.Windows.Forms.Label lblPlaceFinger;
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.PictureBox pbFingerprint;
    }
}