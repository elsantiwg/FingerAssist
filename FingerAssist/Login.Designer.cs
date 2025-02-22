namespace Sistema_Empresarial
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usertxt = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            floatingActionButton = new MaterialSkin.Controls.MaterialButton();
            passwordtxt = new MaterialSkin.Controls.MaterialTextBox();
            SuspendLayout();
            // 
            // usertxt
            // 
            usertxt.AnimateReadOnly = false;
            usertxt.BorderStyle = BorderStyle.None;
            usertxt.Depth = 0;
            usertxt.Font = new Font("Microsoft Sans Serif", 7.45F);
            usertxt.LeadingIcon = null;
            usertxt.Location = new Point(230, 183);
            usertxt.MaxLength = 50;
            usertxt.MouseState = MaterialSkin.MouseState.OUT;
            usertxt.Multiline = false;
            usertxt.Name = "usertxt";
            usertxt.Size = new Size(331, 50);
            usertxt.TabIndex = 0;
            usertxt.Text = "admin";
            usertxt.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(231, 142);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(55, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Usuario";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(230, 270);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(82, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Contraseña";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(322, 394);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(128, 36);
            materialButton1.TabIndex = 4;
            materialButton1.Text = "Iniciar Sesión";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // floatingActionButton
            // 
            floatingActionButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            floatingActionButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            floatingActionButton.Depth = 0;
            floatingActionButton.HighEmphasis = true;
            floatingActionButton.Icon = null;
            floatingActionButton.Location = new Point(322, 522);
            floatingActionButton.Margin = new Padding(4, 6, 4, 6);
            floatingActionButton.MouseState = MaterialSkin.MouseState.HOVER;
            floatingActionButton.Name = "floatingActionButton";
            floatingActionButton.NoAccentTextColor = Color.Empty;
            floatingActionButton.Size = new Size(89, 36);
            floatingActionButton.TabIndex = 5;
            floatingActionButton.Text = "Marcaje";
            floatingActionButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            floatingActionButton.UseAccentColor = false;
            floatingActionButton.UseVisualStyleBackColor = true;
            floatingActionButton.Click += FloatingActionButton_Click;
            // 
            // passwordtxt
            // 
            passwordtxt.AnimateReadOnly = false;
            passwordtxt.BorderStyle = BorderStyle.None;
            passwordtxt.Depth = 0;
            passwordtxt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordtxt.LeadingIcon = null;
            passwordtxt.Location = new Point(231, 321);
            passwordtxt.MaxLength = 50;
            passwordtxt.MouseState = MaterialSkin.MouseState.OUT;
            passwordtxt.Multiline = false;
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Password = true;
            passwordtxt.Size = new Size(330, 50);
            passwordtxt.TabIndex = 6;
            passwordtxt.Text = "1234";
            passwordtxt.TrailingIcon = null;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(787, 660);
            Controls.Add(passwordtxt);
            Controls.Add(floatingActionButton);
            Controls.Add(materialButton1);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(usertxt);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox usertxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton floatingActionButton;
        private MaterialSkin.Controls.MaterialTextBox passwordtxt;
    }
}
