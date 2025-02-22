namespace Sistema_Empresarial
{
    partial class TomaMarcaje
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
            marcajeIniAlmuerzo = new MaterialSkin.Controls.MaterialButton();
            marcajeFinAlmuerzo = new MaterialSkin.Controls.MaterialButton();
            marcajeSalida = new MaterialSkin.Controls.MaterialButton();
            marcajeEntrada = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // marcajeIniAlmuerzo
            // 
            marcajeIniAlmuerzo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            marcajeIniAlmuerzo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            marcajeIniAlmuerzo.Depth = 0;
            marcajeIniAlmuerzo.HighEmphasis = true;
            marcajeIniAlmuerzo.Icon = null;
            marcajeIniAlmuerzo.Location = new Point(257, 254);
            marcajeIniAlmuerzo.Margin = new Padding(4, 6, 4, 6);
            marcajeIniAlmuerzo.MouseState = MaterialSkin.MouseState.HOVER;
            marcajeIniAlmuerzo.Name = "marcajeIniAlmuerzo";
            marcajeIniAlmuerzo.NoAccentTextColor = Color.Empty;
            marcajeIniAlmuerzo.Size = new Size(145, 36);
            marcajeIniAlmuerzo.TabIndex = 1;
            marcajeIniAlmuerzo.Text = "Inicio Almuerzo";
            marcajeIniAlmuerzo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            marcajeIniAlmuerzo.UseAccentColor = false;
            marcajeIniAlmuerzo.UseVisualStyleBackColor = true;
            marcajeIniAlmuerzo.Click += marcajeIniAlmuerzo_Click;
            // 
            // marcajeFinAlmuerzo
            // 
            marcajeFinAlmuerzo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            marcajeFinAlmuerzo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            marcajeFinAlmuerzo.Depth = 0;
            marcajeFinAlmuerzo.HighEmphasis = true;
            marcajeFinAlmuerzo.Icon = null;
            marcajeFinAlmuerzo.Location = new Point(257, 354);
            marcajeFinAlmuerzo.Margin = new Padding(4, 6, 4, 6);
            marcajeFinAlmuerzo.MouseState = MaterialSkin.MouseState.HOVER;
            marcajeFinAlmuerzo.Name = "marcajeFinAlmuerzo";
            marcajeFinAlmuerzo.NoAccentTextColor = Color.Empty;
            marcajeFinAlmuerzo.Size = new Size(125, 36);
            marcajeFinAlmuerzo.TabIndex = 2;
            marcajeFinAlmuerzo.Text = "Fin Almuerzo";
            marcajeFinAlmuerzo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            marcajeFinAlmuerzo.UseAccentColor = false;
            marcajeFinAlmuerzo.UseVisualStyleBackColor = true;
            marcajeFinAlmuerzo.Click += marcajeFinAlmuerzo_Click;
            // 
            // marcajeSalida
            // 
            marcajeSalida.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            marcajeSalida.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            marcajeSalida.Depth = 0;
            marcajeSalida.HighEmphasis = true;
            marcajeSalida.Icon = null;
            marcajeSalida.Location = new Point(257, 450);
            marcajeSalida.Margin = new Padding(4, 6, 4, 6);
            marcajeSalida.MouseState = MaterialSkin.MouseState.HOVER;
            marcajeSalida.Name = "marcajeSalida";
            marcajeSalida.NoAccentTextColor = Color.Empty;
            marcajeSalida.Size = new Size(133, 36);
            marcajeSalida.TabIndex = 3;
            marcajeSalida.Text = "FIN DE LABORES";
            marcajeSalida.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            marcajeSalida.UseAccentColor = false;
            marcajeSalida.UseVisualStyleBackColor = true;
            marcajeSalida.Click += marcajeSalida_Click;
            // 
            // marcajeEntrada
            // 
            marcajeEntrada.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            marcajeEntrada.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            marcajeEntrada.Depth = 0;
            marcajeEntrada.HighEmphasis = true;
            marcajeEntrada.Icon = null;
            marcajeEntrada.Location = new Point(257, 148);
            marcajeEntrada.Margin = new Padding(4, 6, 4, 6);
            marcajeEntrada.MouseState = MaterialSkin.MouseState.HOVER;
            marcajeEntrada.Name = "marcajeEntrada";
            marcajeEntrada.NoAccentTextColor = Color.Empty;
            marcajeEntrada.Size = new Size(153, 36);
            marcajeEntrada.TabIndex = 0;
            marcajeEntrada.Text = "Inicio de Labores";
            marcajeEntrada.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            marcajeEntrada.UseAccentColor = false;
            marcajeEntrada.UseVisualStyleBackColor = true;
            marcajeEntrada.Click += marcajeEntrada_Click;
            // 
            // TomaMarcaje
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 606);
            Controls.Add(marcajeSalida);
            Controls.Add(marcajeFinAlmuerzo);
            Controls.Add(marcajeIniAlmuerzo);
            Controls.Add(marcajeEntrada);
            Name = "TomaMarcaje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Toma de marcaje";
            Load += IngresoHuella_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton marcajeIniAlmuerzo;
        private MaterialSkin.Controls.MaterialButton marcajeFinAlmuerzo;
        private MaterialSkin.Controls.MaterialButton marcajeSalida;
        private MaterialSkin.Controls.MaterialButton marcajeEntrada;
    }
}