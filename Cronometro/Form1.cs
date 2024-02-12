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
            CentrarBotonEnPanel();

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
    }
}
