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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            panelBar = new Panel();
            picMinimizar = new PictureBox();
            picCerrar = new PictureBox();
            labelBar = new Label();
            picLogoBar = new PictureBox();
            btnIniciar = new CustomControls.RJControls.RJButton();
            panel1 = new Panel();
            picRestablecer = new PictureBox();
            labelTemporizador = new Label();
            timerCronometro = new System.Windows.Forms.Timer(components);
            panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogoBar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRestablecer).BeginInit();
            SuspendLayout();
            // 
            // panelBar
            // 
            panelBar.BackColor = SystemColors.ActiveCaptionText;
            panelBar.Controls.Add(picMinimizar);
            panelBar.Controls.Add(picCerrar);
            panelBar.Controls.Add(labelBar);
            panelBar.Controls.Add(picLogoBar);
            panelBar.Location = new Point(0, 0);
            panelBar.Name = "panelBar";
            panelBar.Size = new Size(331, 31);
            panelBar.TabIndex = 0;
            panelBar.Paint += panelBar_Paint;
            // 
            // picMinimizar
            // 
            picMinimizar.BackColor = Color.Transparent;
            picMinimizar.Image = (Image)resources.GetObject("picMinimizar.Image");
            picMinimizar.Location = new Point(284, 4);
            picMinimizar.Name = "picMinimizar";
            picMinimizar.Size = new Size(23, 22);
            picMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            picMinimizar.TabIndex = 3;
            picMinimizar.TabStop = false;
            picMinimizar.Click += picMinimizar_Click;
            // 
            // picCerrar
            // 
            picCerrar.BackColor = Color.Transparent;
            picCerrar.Image = (Image)resources.GetObject("picCerrar.Image");
            picCerrar.Location = new Point(305, 4);
            picCerrar.Name = "picCerrar";
            picCerrar.Size = new Size(23, 22);
            picCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picCerrar.TabIndex = 2;
            picCerrar.TabStop = false;
            picCerrar.Click += picCerrar_Click;
            // 
            // labelBar
            // 
            labelBar.AutoSize = true;
            labelBar.BackColor = Color.Transparent;
            labelBar.Enabled = false;
            labelBar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBar.ForeColor = Color.White;
            labelBar.Location = new Point(26, 8);
            labelBar.Name = "labelBar";
            labelBar.Size = new Size(82, 14);
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
            btnIniciar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnIniciar.BackColor = Color.FromArgb(23, 23, 23);
            btnIniciar.BackgroundColor = Color.FromArgb(23, 23, 23);
            btnIniciar.BorderColor = Color.PaleVioletRed;
            btnIniciar.BorderRadius = 15;
            btnIniciar.BorderSize = 0;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = SystemColors.ButtonShadow;
            btnIniciar.Location = new Point(93, 66);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(144, 32);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.TextColor = SystemColors.ButtonShadow;
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(picRestablecer);
            panel1.Controls.Add(labelTemporizador);
            panel1.Controls.Add(btnIniciar);
            panel1.Location = new Point(0, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 110);
            panel1.TabIndex = 3;
            // 
            // picRestablecer
            // 
            picRestablecer.BackColor = Color.Transparent;
            picRestablecer.Image = (Image)resources.GetObject("picRestablecer.Image");
            picRestablecer.Location = new Point(243, 71);
            picRestablecer.Name = "picRestablecer";
            picRestablecer.Size = new Size(31, 31);
            picRestablecer.SizeMode = PictureBoxSizeMode.Zoom;
            picRestablecer.TabIndex = 2;
            picRestablecer.TabStop = false;
            picRestablecer.Visible = false;
            picRestablecer.Click += picRestablecer_Click;
            picRestablecer.MouseHover += picRestablecer_MouseHover;
            // 
            // labelTemporizador
            // 
            labelTemporizador.AutoSize = true;
            labelTemporizador.FlatStyle = FlatStyle.Flat;
            labelTemporizador.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTemporizador.ForeColor = Color.FromArgb(23, 23, 23);
            labelTemporizador.Location = new Point(93, 21);
            labelTemporizador.Name = "labelTemporizador";
            labelTemporizador.Size = new Size(138, 32);
            labelTemporizador.TabIndex = 3;
            labelTemporizador.Text = "00:00.00";
            labelTemporizador.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerCronometro
            // 
            timerCronometro.Tick += timerCronometro_Tick;
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
            ((System.ComponentModel.ISupportInitialize)picMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogoBar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRestablecer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBar;
        private PictureBox picLogoBar;
        private Label labelBar;
        private CustomControls.RJControls.RJButton btnIniciar;
        private Panel panel1;
        private Label labelTemporizador;
        private PictureBox picRestablecer;
        private System.Windows.Forms.Timer timerCronometro;
        private PictureBox picMinimizar;
        private PictureBox picCerrar;
    }
}
