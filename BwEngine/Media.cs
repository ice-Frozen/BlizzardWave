using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagedBass;
using System.Threading;
using System.Threading.Tasks;
namespace BwEngine
{
    public class Media
    {
        //Event Area
        #region Event
        public event EventHandler SongEnd;
        public event EventHandler SongLoadSuccess;
        public event EventHandler Paused;
        public event EventHandler Played;
        #endregion
        #region Properties
        private int handle;
        private string filename;
        private bool isPlay;
        private float volume;
        private float Balance;
        #endregion
        #region Fields
        public float Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                Bass.ChannelSlideAttribute(handle, ChannelAttribute.Volume, value, 50);
            }
        }//end Volume
        public bool IsPlay
        {
            get { return isPlay; }
            private set { isPlay = value; }
        }
        string FileName
        {
            get { return filename; }
            set {
                    filename = value;
            }
        }//end string filename

int Handle
        {
            get
            {
                    return handle;
            }//end get 
            set
            {
                if (handle != value)
                {
                    handle = value;
                }//end if check
                Bass.ChannelSetSync(Handle, SyncFlags.End, 0 , procedure(() =>
                {
                    SongEnd.Invoke(this, EventArgs.Empty);
                }));//end lamdaSong End
            }//end set
        }//end Handle
        #endregion
        #region Constructor
        public Media() => Bass.Init();//end con
        #endregion
        public void Load(string Name)
        {
            FileName = Name;
            if (Handle != 0)
            {
                Bass.StreamFree(Handle);
            }//end if
                Handle = Bass.CreateStream(filename);
            if (IsPlay) IsPlay = false;
            SongLoadSuccess.Invoke(this,EventArgs.Empty);
        }//end method.load

        public void Play()
        {
            if (handle != 0 && !IsPlay)
            {
                Bass.ChannelPlay(Handle);
                IsPlay = true;
                Bass.ChannelSlideAttribute(Handle, ChannelAttribute.Volume, Volume, 10);
                Played.Invoke(this, EventArgs.Empty);
            } //end if
        }//end method.Play
        public void Pause()
        {
            if (Handle != 0 && IsPlay)
            {
                Bass.ChannelPause(Handle);
                IsPlay = false;
                Paused.Invoke(this, EventArgs.Empty);
            }//end if
}//end method.Pause

        SyncProcedure procedure(Action H)
        {
            return (SyncHandle, Channel, Data, User) =>
            {
                if (H == null)
                {
                    return;
                }//end if
                H();
            };
        }
    }//end class media
}//end name space BwEngine