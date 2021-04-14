using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idiomas_boton
{
    public partial class boton : UserControl
    {

        public int state;
        public boton()
        {
            InitializeComponent();
            button1.BackgroundImage = Image.FromFile("C:/Users/lolac/source/repos/GourmetteRestaurante/assets/bandera_spain.png");
            state = 1;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                button1.BackgroundImage = Image.FromFile("C:/Users/lolac/source/repos/GourmetteRestaurante/assets/bandera_ing.png");
                state = 2;
            }
            else if (state == 2)
            {
                button1.BackgroundImage = Image.FromFile("C:/Users/lolac/source/repos/GourmetteRestaurante/assets/bandera_spain.png");
                state = 1;
            }

        }
    }
}
