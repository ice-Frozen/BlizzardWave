using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blizzard_Wave
{
    public partial class Mixer : UserControl
    {
        public event EventHandler volumeBar_Scroll;
        public event EventHandler panBar_Scroll;
        public Mixer()
        {
            InitializeComponent();
        }

        private void Mixer_Load(object sender, EventArgs e)
        {

        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            if (volumeBar_Scroll != null)
            {
                volumeBar_Scroll(sender, e);
                    }//end if

        }

        private void PanBar_Scroll(object sender, EventArgs e)
        {
            if (panBar_Scroll != null)
            {
                panBar_Scroll(sender, e);
            }//end if
            }
    }
}
