using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blizzard_Wave
{
    public partial class CustomTrackBar : TrackBar
    {
        public new float LargeChange
        {
            get { return base.LargeChange; }
            set { base.LargeChange = (int)(value); }
        }
        public new float Maximum
        { get { return base.Maximum; } set { base.Maximum = (int)(value); } }

        public new float Minimum
        { get { return base.Minimum; } set { base.Minimum = (int)(value); } }

        public new float SmallChange
        { get { return base.SmallChange; } set { base.SmallChange = (int)(value); } }
        public new float Value
        { get { return base.Value; } set { base.Value = (int)(value); } }

        public CustomTrackBar()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
