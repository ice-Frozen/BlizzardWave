namespace Blizzard_Wave
{
    partial class Mixer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.VolumeBar = new Blizzard_Wave.CustomTrackBar();
            this.PanLabel = new System.Windows.Forms.Label();
            this.PanBar = new Blizzard_Wave.CustomTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanBar)).BeginInit();
            this.SuspendLayout();
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AccessibleName = "Volume";
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(0, 0);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(42, 13);
            this.VolumeLabel.TabIndex = 0;
            this.VolumeLabel.Text = "Volume";
            // 
            // VolumeBar
            // 
            this.VolumeBar.AccessibleName = "Volume";
            this.VolumeBar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.VolumeBar.LargeChange = 5F;
            this.VolumeBar.Location = new System.Drawing.Point(8, 8);
            this.VolumeBar.Maximum = 100F;
            this.VolumeBar.Minimum = -1F;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(104, 45);
            this.VolumeBar.SmallChange = 1F;
            this.VolumeBar.TabIndex = 1;
            this.VolumeBar.Value = 50F;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // PanLabel
            // 
            this.PanLabel.AccessibleName = "Pan";
            this.PanLabel.AutoSize = true;
            this.PanLabel.Location = new System.Drawing.Point(16, 16);
            this.PanLabel.Name = "PanLabel";
            this.PanLabel.Size = new System.Drawing.Size(26, 13);
            this.PanLabel.TabIndex = 2;
            this.PanLabel.Text = "Pan";
            // 
            // PanBar
            // 
            this.PanBar.AccessibleName = "Pan";
            this.PanBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanBar.LargeChange = 5F;
            this.PanBar.Location = new System.Drawing.Point(0, 0);
            this.PanBar.Maximum = 100F;
            this.PanBar.Minimum = -100F;
            this.PanBar.Name = "PanBar";
            this.PanBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PanBar.Size = new System.Drawing.Size(150, 45);
            this.PanBar.SmallChange = 1F;
            this.PanBar.TabIndex = 3;
            this.PanBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.PanBar.Value = 0F;
            this.PanBar.Scroll += new System.EventHandler(this.PanBar_Scroll);
            // 
            // Mixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanBar);
            this.Controls.Add(this.PanLabel);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.VolumeLabel);
            this.Name = "Mixer";
            this.Load += new System.EventHandler(this.Mixer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VolumeLabel;
        public CustomTrackBar VolumeBar;
        private System.Windows.Forms.Label PanLabel;
        public CustomTrackBar PanBar;
    }
}
