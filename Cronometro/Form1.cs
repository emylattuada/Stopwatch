using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace Cronometro
{
    public partial class formPrincipal : Form
    {

        public formPrincipal()
        {
            InitializeComponent();

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
                new Point(0, 0), // Punto de inicio del degradado (izquierda superior)
                new Point(panelBar.ClientSize.Width, panelBar.ClientSize.Height), // Punto final del degradado (derecha inferior)
                Color.FromArgb(23, 23, 23), // Color inicial
                Color.FromArgb(13, 13, 13)); // Color final

            // Dibuja el degradado en el área del panel.
            e.Graphics.FillRectangle(gradientBrush, panelBar.ClientRectangle);
        
    }
    }
}
