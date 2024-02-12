namespace Cronometro
{
    partial class formPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            panelBar = new Panel();
            labelBar = new Label();
            picLogoBar = new PictureBox();
            btnIniciar = new CustomControls.RJControls.RJButton();
            panel1 = new Panel();
            panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoBar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelBar
            // 
            panelBar.BackColor = SystemColors.ActiveCaptionText;
            panelBar.Controls.Add(labelBar);
            panelBar.Controls.Add(picLogoBar);
            panelBar.Location = new Point(0, 0);
            panelBar.Name = "panelBar";
            panelBar.Size = new Size(331, 31);
            panelBar.TabIndex = 0;
            panelBar.Paint += panelBar_Paint;
            // 
            // labelBar
            // 
            labelBar.AutoSize = true;
            labelBar.BackColor = Color.Transparent;
            labelBar.Enabled = false;
            labelBar.ForeColor = Color.White;
            labelBar.Location = new Point(26, 8);
            labelBar.Name = "labelBar";
            labelBar.Size = new Size(72, 15);
            labelBar.TabIndex = 1;
            labelBar.Text = "Cronómetro";
            // 
            // picLogoBar
            // 
            picLogoBar.BackColor = Color.Transparent;
            picLogoBar.Image = (Image)resources.GetObject("picLogoBar.Image");
            picLogoBar.Location = new Point(3, 4);
            picLogoBar.Name = "picLogoBar";
            picLogoBar.Size = new Size(23, 22);
            picLogoBar.SizeMode = PictureBoxSizeMode.Zoom;
            picLogoBar.TabIndex = 0;
            picLogoBar.TabStop = false;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(23, 23, 23);
            btnIniciar.BackgroundColor = Color.FromArgb(23, 23, 23);
            btnIniciar.BorderColor = Color.PaleVioletRed;
            btnIniciar.BorderRadius = 10;
            btnIniciar.BorderSize = 0;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(107, 75);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(144, 32);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.TextColor = Color.White;
            btnIniciar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnIniciar);
            panel1.Location = new Point(0, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 110);
            panel1.TabIndex = 3;
            // 
            // formPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 147);
            Controls.Add(panel1);
            Controls.Add(panelBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "formPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cronómetro";
            panelBar.ResumeLayout(false);
            panelBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoBar).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBar;
        private PictureBox picLogoBar;
        private Label labelBar;
        private CustomControls.RJControls.RJButton btnIniciar;
        private Panel panel1;
    }
}
