using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.Windows.Forms;
using System.IO;

namespace Green_Grid
{
    public partial class HomePage : Form
    {
        // A static instance of HomePage for global access
        public static HomePage Instance { get; private set; }
        // Fields for audio playback
        private IWavePlayer waveOut; // Interface for audio output device
        private AudioFileReader audioFile; // Reader for audio files
        private bool isPlaying = false; // Flag to check if audio is playing
        // Constructor to initialize the form
        public HomePage()
        {
            InitializeComponent(); // Initializes UI components
            Instance = this; // Sets the static instance to this object
            waveOut = new WaveOutEvent(); // Initializes the audio output device
            // Sets the image for the audio button
            btnAudio.Image = GreenGrid1.Properties.Resources.sound_on;
            btnAudio.ImageAlign = ContentAlignment.MiddleCenter; // Aligns the image to the center
        }
        private void btnPlayWithBots_Click(object sender, EventArgs e)
        {
            // Opens a new form for playing with bots
            GreeenGrid GreeenGridForm = new GreeenGrid(true);
            GreeenGridForm.Show(); // Displays the GreeenGrid form
            this.Hide(); // Hides the current form
        }
        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            // Opens the HowToPlay form
            HowToPlay howToPlayForm = new HowToPlay(this.Location, this.Size);
            howToPlayForm.Show(); // Displays the HowToPlay form

        }

        private void btn2Players_Click(object sender, EventArgs e)
        {
            // Opens a new GreeenGrid form for two players
            GreeenGrid GreeenGridForm = new GreeenGrid(false);
            GreeenGridForm.Show(); // Displays the GreeenGrid form
            this.Hide(); // Hides the current form
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            // Opens the Info form and passes current form's location and size
            Point parentTopLeft = this.Location;
            Size parentSize = this.Size;

            Info infoForm = new Info(parentTopLeft, parentSize);
            infoForm.Show(); // Displays the Info form
        }
        private void btnAudio_Click(object sender, EventArgs e)
        {
            try
            {
                // Access audio resources and images from the application
                var soundStream = GreenGrid1.Properties.Resources.background_music; // Audio resource
                var soundOffImage = GreenGrid1.Properties.Resources.sound_off; // Image for sound off

                int newWidth = 1000;  // Width for resizing the image
                int newHeight = 1000; // Height for resizing the image

                // Resize the sound-off image
                Bitmap resizedImage = new Bitmap(soundOffImage, newWidth, newHeight);

                // Image for sound on
                var soundOnImage = GreenGrid1.Properties.Resources.sound_on;

                if (isPlaying)
                {
                    // Stops and disposes the audio if it's playing
                    waveOut?.Stop();
                    waveOut?.Dispose();
                    audioFile?.Dispose();

                    waveOut = null;
                    audioFile = null;

                    isPlaying = false; // Update the playing flag
                    btnAudio.Image = soundOffImage; // Change button image to sound off
                }
                else
                {
                    if (soundStream != null)
                    {
                        // Write the sound stream to a temporary file
                        string tempFilePath = Path.GetTempFileName();
                        using (var fileStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                        {
                            soundStream.CopyTo(fileStream); // Copy sound data to the file
                        }
                        // Initialize audio playback
                        audioFile = new AudioFileReader(tempFilePath);
                        waveOut = new WaveOutEvent();

                        // Subscribe to PlaybackStopped event for looping
                        waveOut.PlaybackStopped += (s, ev) =>
                        {
                            if (isPlaying) // Check if still in "playing" state
                            {
                                audioFile.Position = 0; // Reset the position to the start
                                waveOut.Play(); // Replay the audio
                            }
                        };

                        waveOut.Init(audioFile);
                        waveOut.Play(); // Start audio playback
                    }

                    isPlaying = true; // Update the playing flag
                    btnAudio.Image = soundOnImage; // Change button image to sound on
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show("Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


    }
