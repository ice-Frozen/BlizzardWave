namespace Blizzard_Wave
{
    partial class PlayControl
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
            this.PlayListLabel = new System.Windows.Forms.Label();
            this.PlayListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayButton = new System.Windows.Forms.Button();
            this.NexButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayListLabel
            // 
            this.PlayListLabel.AccessibleName = "Play List";
            this.PlayListLabel.AutoSize = true;
            this.PlayListLabel.Location = new System.Drawing.Point(0, 0);
            this.PlayListLabel.Name = "PlayListLabel";
            this.PlayListLabel.Size = new System.Drawing.Size(46, 13);
            this.PlayListLabel.TabIndex = 0;
            this.PlayListLabel.Text = "Play List";
            // 
            // PlayListView
            // 
            this.PlayListView.AccessibleName = "Play List";
            this.PlayListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.PlayListView.FullRowSelect = true;
            this.PlayListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.PlayListView.HideSelection = false;
            this.PlayListView.Location = new System.Drawing.Point(8, 7);
            this.PlayListView.MultiSelect = false;
            this.PlayListView.Name = "PlayListView";
            this.PlayListView.Size = new System.Drawing.Size(121, 97);
            this.PlayListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.PlayListView.TabIndex = 1;
            this.PlayListView.UseCompatibleStateImageBehavior = false;
            this.PlayListView.View = System.Windows.Forms.View.Tile;
            this.PlayListView.ItemActivate += new System.EventHandler(this.PlayListView_ItemActivate);
            this.PlayListView.SelectedIndexChanged += new System.EventHandler(this.PlayListView_SelectedIndexChanged);
            // 
            // PlayButton
            // 
            this.PlayButton.AccessibleName = "Play";
            this.PlayButton.Location = new System.Drawing.Point(16, 17);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // NexButton
            // 
            this.NexButton.AccessibleName = "Nex";
            this.NexButton.Location = new System.Drawing.Point(24, 25);
            this.NexButton.Name = "NexButton";
            this.NexButton.Size = new System.Drawing.Size(75, 23);
            this.NexButton.TabIndex = 3;
            this.NexButton.Text = "Nex";
            this.NexButton.UseVisualStyleBackColor = true;
            // 
            // PreviousButton
            // 
            this.PreviousButton.AccessibleName = "Previous";
            this.PreviousButton.Location = new System.Drawing.Point(38, 64);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 4;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            // 
            // PlayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NexButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.PlayListView);
            this.Controls.Add(this.PlayListLabel);
            this.Name = "PlayControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayListLabel;
        public System.Windows.Forms.ListView PlayListView;
        public System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button NexButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
