namespace Sistema_Empresarial
{
    partial class RegistrarHuella
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
            reader = new MaterialSkin.Controls.MaterialButton();
            btnCapture = new MaterialSkin.Controls.MaterialButton();
            txtReaderSelected = new MaterialSkin.Controls.MaterialTextBox();
            SuspendLayout();
            // 
            // reader
            // 
            reader.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            reader.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            reader.Depth = 0;
            reader.HighEmphasis = true;
            reader.Icon = null;
            reader.Location = new Point(84, 184);
            reader.Margin = new Padding(4, 6, 4, 6);
            reader.MouseState = MaterialSkin.MouseState.HOVER;
            reader.Name = "reader";
            reader.NoAccentTextColor = Color.Empty;
            reader.Size = new Size(176, 36);
            reader.TabIndex = 0;
            reader.Text = "Seleccionar Lector";
            reader.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            reader.UseAccentColor = false;
            reader.UseVisualStyleBackColor = true;
            reader.Click += reader_Click;
            // 
            // btnCapture
            // 
            btnCapture.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCapture.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCapture.Depth = 0;
            btnCapture.HighEmphasis = true;
            btnCapture.Icon = null;
            btnCapture.Location = new Point(289, 184);
            btnCapture.Margin = new Padding(4, 6, 4, 6);
            btnCapture.MouseState = MaterialSkin.MouseState.HOVER;
            btnCapture.Name = "btnCapture";
            btnCapture.NoAccentTextColor = Color.Empty;
            btnCapture.Size = new Size(155, 36);
            btnCapture.TabIndex = 1;
            btnCapture.Text = "Capturar Huella";
            btnCapture.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCapture.UseAccentColor = false;
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click += btnCapture_Click_1;
            // 
            // txtReaderSelected
            // 
            txtReaderSelected.AnimateReadOnly = false;
            txtReaderSelected.BorderStyle = BorderStyle.None;
            txtReaderSelected.Depth = 0;
            txtReaderSelected.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtReaderSelected.LeadingIcon = null;
            txtReaderSelected.Location = new Point(84, 110);
            txtReaderSelected.MaxLength = 50;
            txtReaderSelected.MouseState = MaterialSkin.MouseState.OUT;
            txtReaderSelected.Multiline = false;
            txtReaderSelected.Name = "txtReaderSelected";
            txtReaderSelected.Size = new Size(360, 50);
            txtReaderSelected.TabIndex = 2;
            txtReaderSelected.Text = "";
            txtReaderSelected.TrailingIcon = null;
            // 
            // RegistrarHuella
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 273);
            Controls.Add(txtReaderSelected);
            Controls.Add(btnCapture);
            Controls.Add(reader);
            Name = "RegistrarHuella";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleccionar Lector";
            Load += RegistrarHuella_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton reader;
        private MaterialSkin.Controls.MaterialButton btnCapture;
        private MaterialSkin.Controls.MaterialTextBox txtReaderSelected;
    }
}