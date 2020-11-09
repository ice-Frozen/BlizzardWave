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
    public partial class PlayControl : UserControl
    {
        public event EventHandler playButton;
        public event EventHandler playListView_SelectedIndexChanged;
        public event EventHandler playListView_ItemActivate;
        public PlayControl()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (playButton != null)
            {
                playButton(sender, e);
            }

        }

        private void PlayListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playListView_SelectedIndexChanged != null)
            {
                playListView_SelectedIndexChanged(sender, e);
            }//end if
        }

        private void PlayListView_ItemActivate(object sender, EventArgs e)
        {
            if (playListView_ItemActivate != null)
            {
                playListView_ItemActivate(sender, e);
            }
        }
    }
}
