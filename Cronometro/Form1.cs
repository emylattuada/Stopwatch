using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace Cronometro
{
    public partial class formPrincipal : Form
    {
        private bool cronometroActivo = false;
        private DateTime tiempoInicio;
        private TimeSpan tiempoTranscurrido;

        public formPrincipal()
        {
            InitializeComponent();
            CentrarBotonEnPanel();
            int x = (panel1.Width - labelTemporizador.Width) / 2;
            int y = (panel1.Height - labelTemporizador.Height) * 1 / 4;
            labelTemporizador.Location = new System.Drawing.Point(x, y);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(ClientSize.Width, ClientSize.Height),
                Color.FromArgb(3, 239, 254),
                Color.FromArgb(78, 173, 254));

            e.Graphics.FillRectangle(gradientBrush, ClientRectangle);
        }

        private void panelBar_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(panelBar.ClientSize.Width, panelBar.ClientSize.Height),
                Color.FromArgb(23, 23, 23),
                Color.FromArgb(13, 13, 13));

            e.Graphics.FillRectangle(gradientBrush, panelBar.ClientRectangle);

        }

        private void CentrarBotonEnPanel()
        {
            int x = (panel1.Width - btnIniciar.Width) / 2;
            int y = (panel1.Height - btnIniciar.Height) * 10 / 11;

            btnIniciar.Location = new Point(x, y);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!cronometroActivo)
            {
                if (tiempoTranscurrido == TimeSpan.Zero)
                {
                    tiempoInicio = DateTime.Now;
                }
                else
                {
                    tiempoInicio = DateTime.Now - tiempoTranscurrido;
                }
                cronometroActivo = true;
                timerCronometro.Start();
                btnIniciar.Text = "Detener";
            }
            else
            {
                cronometroActivo = !cronometroActivo;
                if (cronometroActivo)
                {
                    tiempoInicio = DateTime.Now - tiempoTranscurrido;
                    timerCronometro.Start();
                    btnIniciar.Text = "Detener";
                }
                else
                {
                    timerCronometro.Stop();
                    btnIniciar.Text = "Reanudar";
                }
            }

        }

        private void timerCronometro_Tick(object sender, EventArgs e)
        {
            tiempoTranscurrido = DateTime.Now - tiempoInicio;
            labelTemporizador.Text = tiempoTranscurrido.ToString(@"mm\:ss\.ff");
        }
    }
}
