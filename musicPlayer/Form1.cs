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


namespace musicPlayer
{

    public partial class Form1 : Form


    {
        
        string MYPathFiles = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()

        {
            InitializeComponent();
        }
       

        private void lb_Artist_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lb_Album_Click(object sender, EventArgs e)
        {

        }

        private void lb_Title_Click(object sender, EventArgs e)
        {

        }

        private void btn_Play_Click(object sender, EventArgs e)
        {// play button
            MyPlayer.Ctlcontrols.play();
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {// pause button
            MyPlayer.Ctlcontrols.pause();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {// stop button
            MyPlayer.Ctlcontrols.stop();
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {// previous button 
            
            
                MyPlayer.Ctlcontrols.previous();
            
        }

        private void btn_Next_Click(object sender, EventArgs e)
            // next button 
        {
            
            
                MyPlayer.Ctlcontrols.next();
            
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {// file directory and media file suppported
            

            OfDialog = new OpenFileDialog();
            OfDialog.InitialDirectory = MYPathFiles;
            OfDialog.FileName = "";
            OfDialog.Multiselect = true;
            OfDialog.Filter = "Media(*.mp3;*.wav;*.snd;*.au;*.aif;*.aifc;.*aiff;*.wma;*.mp2;*.adts;*.adt;*.acc;*.avi;*.wmv;*.mp4;*.mpeg;*.mpg)" +
                "|*.mp3;*.wav;*.snd;*.au;*.aif;*.aifc;.*aiff;*.wma;*.mp2;*.adts;*.adt;*.acc;*.avi;*.wmv;*.mp4;*.mpeg;*.mpg)";
            
                                      
            if (OfDialog.ShowDialog() == DialogResult.OK)
            {
                MyPlayer.URL = OfDialog.FileName;            
                

                infoMedia();
            }


        }

         

        private void infoMedia()
        {
            try
            {// get file info 

                WMPLib.IWMPMedia Cam = MyPlayer.currentMedia;
                lb_Title.Text = MyPlayer.currentMedia.getItemInfo("Title").ToUpper();
                lb_Artist.Text = "Album Artist: " + Cam.getItemInfo("WM/AlbumArtist").ToUpper();
                lb_Gender.Text = Cam.getItemInfo("WM/Gender").ToUpper();

                //setting tracking time 
                trackBar1.Maximum = Convert.ToInt32(MyPlayer.Ctlcontrols.currentItem.duration);
                Pb_Position.Maximum = Convert.ToInt32(MyPlayer.Ctlcontrols.currentItem.duration);
                lb_Duration.Text = MyPlayer.Ctlcontrols.currentItem.durationString;
                lb_Position.Text = MyPlayer.Ctlcontrols.currentPositionString;

                trackBar1.Value = Convert.ToInt32(MyPlayer.Ctlcontrols.currentPosition);
                Pb_Position.Value = trackBar1.Value;



            }
            catch (Exception)
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {// set up playing timer

            TimerRefresh.Interval = 500;
            TimerRefresh.Enabled = true;

            Pb_Volume.Value = 50;
            trackBar2.Value = Pb_Volume.Value;
        }

        private void TimerRefresh_Tick(object sender, EventArgs e)
        {//Calling mediaInfo method
            try
            {
                infoMedia();
            }
            catch (Exception)
            {

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {// tracking playing time 
            try
            {
                MyPlayer.Ctlcontrols.currentPosition = trackBar1.Value;
                Pb_Position.Value = trackBar1.Value;
            }
            catch (Exception)
            {

            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        { // tracking and setting volume level

            MyPlayer.settings.volume = trackBar2.Value;
            Pb_Volume.Value = trackBar2.Value;
            lb_Volume.Text = trackBar2.Value + "%";
            btn_Mute.Text = "Mute OFF";
            btn_Mute.ForeColor = Color.Navy;
            btn_Mute.BackColor = Color.Transparent;
        }

        private void btn_Mute_Click(object sender, EventArgs e)
        {// mute or unmute when audio is playing with color on and off color
            try
            {
                if (MyPlayer.settings.mute == false)
                {
                    btn_Mute.Text = "Mute ON";
                    btn_Mute.ForeColor = Color.Red;
                    btn_Mute.BackColor = Color.Black;
                    MyPlayer.settings.mute = true;
                }
                else
                {
                    MyPlayer.settings.mute = false;
                    btn_Mute.ForeColor = Color.Navy;
                    btn_Mute.BackColor = Color.Transparent;
                    btn_Mute.Text = "Mute OFF";

                }
            }
            catch (Exception)
            {

            }
        }

                       

        
                

            

        
    }
}
