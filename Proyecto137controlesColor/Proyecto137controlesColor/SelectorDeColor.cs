using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto137controlesColor
{
    public partial class SelectorDeColor : UserControl
    {
        private Color colorSeleccionado = Color.Black;
        public Color ColorSeleccionado
        {
            get
            {
                return colorSeleccionado;
            }
            set
            {
                colorSeleccionado = value;
            }
        }

        public SelectorDeColor()
        {
            InitializeComponent();
        }

        private void Actualizar()
        {
            ColorSeleccionado = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            label1.BackColor = ColorSeleccionado;
            label2.Text = hScrollBar1.Value.ToString();
            label3.Text = hScrollBar2.Value.ToString();
            label4.Text = hScrollBar3.Value.ToString();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Actualizar();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            Actualizar();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            Actualizar();
        }
    }
}
