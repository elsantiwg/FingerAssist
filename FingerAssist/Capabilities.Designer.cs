namespace UareUSampleCSharp
{
    partial class Capabilities
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
            btnSelect = new Button();
            lstCaps = new ListBox();
            txtName = new TextBox();
            Label1 = new Label();
            txtReaderSelected = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(244, 427);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(115, 32);
            btnSelect.TabIndex = 14;
            btnSelect.Text = "Cerrar";
            btnSelect.Click += btnSelect_Click;
            // 
            // lstCaps
            // 
            lstCaps.ItemHeight = 25;
            lstCaps.Location = new Point(99, 256);
            lstCaps.Name = "lstCaps";
            lstCaps.Size = new Size(260, 154);
            lstCaps.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Font = new Font("Tahoma", 8F);
            txtName.Location = new Point(99, 124);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 28);
            txtName.TabIndex = 16;
            // 
            // Label1
            // 
            Label1.Location = new Point(99, 93);
            Label1.Name = "Label1";
            Label1.Size = new Size(236, 28);
            Label1.TabIndex = 21;
            Label1.Text = "Nombre";
            // 
            // txtReaderSelected
            // 
            txtReaderSelected.Font = new Font("Tahoma", 8F);
            txtReaderSelected.Location = new Point(99, 200);
            txtReaderSelected.Name = "txtReaderSelected";
            txtReaderSelected.Size = new Size(260, 28);
            txtReaderSelected.TabIndex = 19;
            // 
            // label2
            // 
            label2.Location = new Point(99, 171);
            label2.Name = "label2";
            label2.Size = new Size(236, 26);
            label2.TabIndex = 20;
            label2.Text = "Seleccionar Lector";
            // 
            // Capabilities
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(500, 492);
            Controls.Add(txtReaderSelected);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(Label1);
            Controls.Add(btnSelect);
            Controls.Add(lstCaps);
            MaximizeBox = false;
            MaximumSize = new Size(500, 500);
            MinimizeBox = false;
            MinimumSize = new Size(304, 333);
            Name = "Capabilities";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Capacidades";
            Load += Capabilities_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.Button btnSelect;
        internal System.Windows.Forms.ListBox lstCaps;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtReaderSelected;
        internal System.Windows.Forms.Label label2;
    }
}


//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
//            this.ClientSize = new System.Drawing.Size(284, 283);
//            this.Controls.Add(this.btnSelect);
//            this.Controls.Add(this.lstCaps);
//            this.MaximizeBox = false;
//            this.MinimizeBox = false;
//#if !WindowsCE
//            this.MaximumSize = new System.Drawing.Size(304, 333);
//            this.MinimumSize = new System.Drawing.Size(304, 333);
//        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
//#endif
//            this.Name = "Capabilities";
//            this.Text = "Capabilities";
//            this.Load += new System.EventHandler(this.Capabilities_Load);
//            this.ResumeLayout(false);