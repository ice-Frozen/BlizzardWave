using System;
    using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BwData;
using BwEngine;

namespace Blizzard_Wave
{
    public partial class BlizzardWave : Form
    {
        Media mp = new Media();
        public BlizzardWave bw = null;
        int Index;
        int TempIndex;
        public BlizzardWave()
        {
            InitializeComponent();
            bw = this;
            //Event register area
            mp.SongLoadSuccess += mp_SongLoadSuccess;
            mp.SongEnd += Mp_SongEnd;
            mp.Paused += Mp_Paused;
            mp.Played += Mp_Played;
            //end Event register area
        }

        private void Mp_Played(object sender, EventArgs e)
        {
            playControl1.PlayButton.Text = "Pause";
            playControl1.PlayButton.AccessibleName = "Pause";
            string SongName = Song.GetSongById(Index);
            if (!string.IsNullOrEmpty(SongName))
            {
                SetTitle(Path.GetFileName(SongName));
            }//end if
            }

        private void Mp_Paused(object sender, EventArgs e)
        {
            playControl1.PlayButton.Text = "Play";
            playControl1.PlayButton.AccessibleName = "Play";
        }

        private void Mp_SongEnd(object sender, EventArgs e)
        {
            Index++;
           
            if (Index > -1 && Index <= Song.GetSongCount)
            {
                string Data = Song.GetSongById(Index);
                if (!string.IsNullOrEmpty(Data))
                {
                    mp.Load(Data);
                    mp.Play();
                }//end if check       string
            }//end if
        }

        private void mp_SongLoadSuccess(object sender, EventArgs e)
        {
           
        }
        private void playControl1_playButton(object sender, EventArgs e)
        {
            try
            {
                if (mp.Handle == 0 && !mp.IsPlay)
                {
                    mp.Load(Song.GetSongById(TempIndex));
                    mp.Play();
                }//end if
else                 if (!mp.IsPlay && mp.Handle !=0)
                {
                    mp.Play();
                }//end if
                else if (mp.IsPlay)
                {
                    mp.Pause();
                }
            }//end try
            catch (Exception ex) { MessageBox.Show(ex.Message); }
    }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void BlizzardWave_Load(object sender, EventArgs e)
        {
mp.Volume = 0.5f;
        }

        private void playControl1_playListView_SelectedIndexChanged(object sender, EventArgs e)
        {
for(int i = 0; i<playControl1.PlayListView.SelectedItems.Count; i++)
            {
TempIndex = playControl1.PlayListView.Items.IndexOf(playControl1.PlayListView.SelectedItems[i]);
            }
        }

        private void playControl1_Load(object sender, EventArgs e)
        {

        }
        private void PlayListTab_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void playControl1_playListView_ItemActivate(object sender, EventArgs e)
        {
            if (TempIndex > -1 && TempIndex <= Song.GetSongCount)
            {
                Index = TempIndex;
                string SongData = Song.GetSongById(Index);
                if (!string.IsNullOrEmpty(SongData))
                {
                    mp.Load(SongData);
                    mp.Play();
                }//end if check SongData that there are no empty
            }//end ifcheck Index

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                Song.Add(openFileDialog.FileNames);
            }//end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//end catch

            try
            {
                HashSet<string> SongHash = new HashSet<string>();
foreach(var l in Song.MusicData)
                    {
                    SongHash.Add(l);
                       }//end for.each
                foreach (var h in SongHash)
                {
                    var list = new ListViewItem();
                    list.Text = Path.GetFileName(h);
                    list.SubItems.Add(h);
                    playControl1.PlayListView.Items.Add(list);
                }//end for.each
            }//end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//end catch
        }//end method
        private void SetTitle(string Text)
        {
            if (!this.IsHandleCreated || this.IsDisposed) return;
            if (!string.IsNullOrEmpty(Text) && this.Text != Text)
                {
                this.Invoke((MethodInvoker)delegate
                {
                    this.Text = Text + " Blizzard Wave";
                    this.AccessibleName = Text + " Blizzard Wave";
                });
            }//end if
        }//end Method

        private void mixer1_volumeBar_Scroll(object sender, EventArgs e)
        {
            mp.Volume = Mixer.VolumeBar.Value / 100;
        }
    }//end class
}//end name space
