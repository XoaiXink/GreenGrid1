using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.Media;
using GreenGrid1;
using Green_Grid;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Diagnostics;
namespace Green_Grid
{
    public partial class GreeenGrid : Form // The GreeenGrid class inherits from Form
    {
        // Variables for managing audio playback
        private WaveOutEvent waveOut;// Object for audio playback
        private WaveFileReader audioFile;// Object for reading audio files
        private bool playwithbots;// Variable to check if the mode is playing with bots                                 
        private bool isPlaying = false; // Flag to track the state of music playback
        // Variables to track game state and settings
        Color turn = Color.Red; // Current player's turn
        Color theme = Color.OldLace; // Theme color
        int a, b, c, d, f, g, h, R, Y, moveCounter; // Game-related variables
        string whoWon = "Yellow"; // Stores the winner of the game
        bool redStarts, gameEnded = false; // Flags for game state
        char[] letters = new char[3]; // Character array for game logic
        List<Button> buttons = new List<Button>(); // List of game buttons
        List<Button> redo = new List<Button>(); // List for redo functionality
        HowToPlay how; // Reference to the "How to Play" form
        Info info; // Reference to the "Info" form
        MessageBoxIcon icon = MessageBoxIcon.Error; // Default icon for message boxes
                                                    // Helper function to convert Color to BGR hexadecimal format
        private string ToBgr(Color c) => $"{c.B:X2}{c.G:X2}{c.R:X2}";

        // Importing external DwmApi function for setting window attributes
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        // Constant for the caption color attribute
        const int DWWMA_CAPTION_COLOR = 35;

        // Method to customize the window's caption color
        void CustomWindow(Color captionColor, IntPtr handle)
        {
            try
            {
                IntPtr hWnd = handle;
                // Convert caption color to BGR and apply it to the window
                int[] caption = new int[] { int.Parse(ToBgr(captionColor), System.Globalization.NumberStyles.HexNumber) };
                DwmSetWindowAttribute(hWnd, DWWMA_CAPTION_COLOR, caption, 4);
            }
            catch (Exception ex)
            {
                // Display an error message if setting the caption color fails
                MessageBox.Show($"Failed to set border color attribute: {ex.Message}");
            }
        }

        // Static async method to play a sound file
        public async static void PlaySound(string filePath)
        {
            using (SoundPlayer player = new SoundPlayer(filePath))
            {
                player.Play();
            }
        }
        // Method to play a click sound
        private void PlayClickSound()
        {
            try
            {
                // Prevent playback if music is already playing
                if (isPlaying) return;

                // Use audio resource from the embedded resources
                using (var stream = GreenGrid1.Properties.Resources.button_click) // Read sound file from resources
                {
                    using (var audioFile = new WaveFileReader(stream)) // WaveFileReader for WAV audio files
                    {
                        var waveOut = new WaveOutEvent(); // Initialize audio playback
                        waveOut.Init(audioFile);         // Assign the audio file to the playback device
                        waveOut.Play();                  // Start playing the sound

                        // Mark the music playback state as active
                        isPlaying = true;

                        // Handle the event when playback stops
                        waveOut.PlaybackStopped += (sender, e) =>
                        {
                            isPlaying = false; // Reset the playback state
                            waveOut.Dispose(); // Release audio resources
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                // Display an error message if sound playback fails
                MessageBox.Show($"Error playing sound: {ex.Message}");
            }
        }

        public GreeenGrid(bool playwithbots)
        {
            InitializeComponent(); // Initialize the components (form, controls, etc.)

            // Create RoundButton
            RoundButton roundButton = new RoundButton();

            // Set properties for the button
            roundButton.Size = new Size(100, 100); // Button size
            roundButton.Text = "Click Me"; // Text on the button
            roundButton.Location = new Point(50, 50); // Button position on the form
            roundButton.BackColor = Color.Blue; // Background color
            roundButton.ForeColor = Color.White; // Text color
            roundButton.Font = new Font("Arial", 12); // Font style

            // Add button to the form
            this.Controls.Add(roundButton);


            // Customize the window's caption color to Bisque
            CustomWindow(Color.Bisque, Handle);

            // Initialize the audio output system
            waveOut = new WaveOutEvent();

            // Store the game mode (whether the game will be played with bots or not)
            this.playwithbots = playwithbots;
        }

        private async void BtnColumn1_Click(object sender, EventArgs e)
        {
            if (gameEnded == false && a < 6) // Check if the game has ended and if the column has been filled with discs
            {
                if (playwithbots)
                {
                    ToggleButtons(false);
                }
                // List of buttons representing the rows of the first column
                Button[] buttonsArray = { b11, b12, b13, b14, b15, b16 };

                // Loop through the buttons in the column
                foreach (var btn in buttonsArray)
                {
                    if (btn.BackColor == theme) // Find the first empty button (its background color is set to the theme color)
                    {
                        // Set the button's background image based on the current turn (Yellow or Red)
                        Image image = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle;
                        btn.BackgroundImage = image;
                        btn.BackgroundImageLayout = ImageLayout.Stretch; // Set image layout to stretch to fill the button
                        btn.BackColor = turn; // Set the button's background color to the current player's color
                        btn.FlatAppearance.MouseOverBackColor = turn; // Change mouse-over color
                        btn.FlatAppearance.MouseDownBackColor = turn; // Change mouse-down color
                        buttons.Add(btn); // Add the button to the list of buttons clicked

                        break; // Exit the loop after finding the first empty button and placing the piece
                    }
                }

                // Play the click sound for button interaction
                PlayClickSound();

                // Increment the move counter and the total move count
                a++;
                moveCounter++;

                // Clear the redo list (reset the state for undo/redo functionality)
                redo.Clear();

                // Change the turn to the next player
                changeTurn();

                // Check if there's a winner after this move
                CheckForWinner();

                // If the game is being played with bots and the game hasn't ended, trigger a bot move after a short delay
                if (playwithbots && gameEnded == false)
                {
                    await Task.Delay(2000); // Wait for 2 seconds before making the bot's move
                    BotMove(); // Trigger the bot's move
                }
                if (playwithbots)
                {
                    ToggleButtons(true);
                }
            }
        }

        private async void BtnColumn2_Click(object sender, EventArgs e)
        {
            if (gameEnded == false && a < 6) //Check if the game has ended and if the column has been filled with discs
            {
                if (playwithbots)
                {
                    ToggleButtons(false);
                }
                // List of buttons representing the rows of the second column
                Button[] buttonsArray = { b21, b22, b23, b24, b25, b26 };

                // Loop through the buttons in the column
                foreach (var btn in buttonsArray)
                {
                    if (btn.BackColor == theme) // Find the first empty button (its background color is set to the theme color)
                    {
                        // Set the button's background image based on the current turn (Yellow or Red)
                        Image image = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle;
                        btn.BackgroundImage = image;
                        btn.BackgroundImageLayout = ImageLayout.Stretch; // Set image layout to stretch to fill the button
                        btn.BackColor = turn; // Set the button's background color to the current player's color
                        btn.FlatAppearance.MouseOverBackColor = turn; // Change mouse-over color
                        btn.FlatAppearance.MouseDownBackColor = turn; // Change mouse-down color
                        buttons.Add(btn); // Add the button to the list of buttons clicked

                        break; // Exit the loop after finding the first empty button and placing the piece
                    }
                }

                // Play the click sound for button interaction
                PlayClickSound();

                // Increment the move counter and the total move count
                b++;
                moveCounter++;

                // Clear the redo list (reset the state for undo/redo functionality)
                redo.Clear();

                // Change the turn to the next player
                changeTurn();

                // Check if there's a winner after this move
                CheckForWinner();

                // If the game is being played with bots and the game hasn't ended, trigger a bot move after a short delay
                if (playwithbots && gameEnded == false)
                {
                    await Task.Delay(2000); // Wait for 2 seconds before making the bot's move
                    BotMove(); // Trigger the bot's move
                }
                if (playwithbots)
                {
                    ToggleButtons(true);
                }
            }
        }

        private async void BtnColumn3_Click(object sender, EventArgs e)
        {
            if (playwithbots)
            {
                ToggleButtons(false);
            }
            if (gameEnded == false && c < 6) //Check if the game has ended and if the column has been filled with discs
            {
                // List of buttons representing the rows of the third column
                Button[] buttonsArray = { b31, b32, b33, b34, b35, b36 };

                // Loop through the buttons in the column
                foreach (var btn in buttonsArray)
                {
                    if (btn.BackColor == theme) // Find the first empty button (its background color is set to the theme color)
                    {
                        // Set the button's background image based on the current turn (Yellow or Red)
                        Image image = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle;
                        btn.BackgroundImage = image;
                        btn.BackgroundImageLayout = ImageLayout.Stretch; // Set image layout to stretch to fill the button
                        btn.BackColor = turn; // Set the button's background color to the current player's color
                        btn.FlatAppearance.MouseOverBackColor = turn; // Change mouse-over color
                        btn.FlatAppearance.MouseDownBackColor = turn; // Change mouse-down color
                        buttons.Add(btn); // Add the button to the list of buttons clicked

                        break; // Exit the loop after finding the first empty button and placing the piece
                    }
                }

                // Play the click sound for button interaction
                PlayClickSound();

                // Increment the move counter and the total move count
                c++;
                moveCounter++;

                // Clear the redo list (reset the state for undo/redo functionality)
                redo.Clear();

                // Change the turn to the next player
                changeTurn();

                // Check if there's a winner after this move
                CheckForWinner();

                // If the game is being played with bots and the game hasn't ended, trigger a bot move after a short delay
                if (playwithbots && gameEnded == false)
                {
                    await Task.Delay(2000); // Wait for 2 seconds before making the bot's move
                    BotMove(); // Trigger the bot's move
                }
                if (playwithbots)
                {
                    ToggleButtons(true);
                }
            }
        }

        private async void BtnColumn4_Click(object sender, EventArgs e)
        {
            if (playwithbots)
            {
                ToggleButtons(false);
            }
            if (gameEnded == false && d < 6) //Check if the game has ended and if the column has been filled with discs
            {
                // List of buttons representing the rows in the fourth column
                Button[] buttonsArray = { b41, b42, b43, b44, b45, b46 };

                // Loop through the buttons in the column
                foreach (var btn in buttonsArray)
                {
                    if (btn.BackColor == theme) // Find the first empty button (its background color is the theme color, indicating an empty spot)
                    {
                        // Set the button's background image based on the current player's color (Yellow or Red)
                        Image image = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle;
                        btn.BackgroundImage = image;
                        btn.BackgroundImageLayout = ImageLayout.Stretch; // Stretch the image to fill the button's area
                        btn.BackColor = turn; // Set the button's background color to the current player's color
                        btn.FlatAppearance.MouseOverBackColor = turn; // Set the mouse-over background color to the current player's color
                        btn.FlatAppearance.MouseDownBackColor = turn; // Set the mouse-down background color to the current player's color
                        buttons.Add(btn); // Add the button to the list of clicked buttons

                        break; // Exit the loop after finding and filling the first empty button
                    }
                }

                // Play the click sound when a move is made
                PlayClickSound();

                // Increment the move counter and the total number of moves
                d++;
                moveCounter++;

                // Clear the redo stack (reset the state for any potential undo/redo functionality)
                redo.Clear();

                // Switch turns to the other player
                changeTurn();

                // Check if the current move results in a win
                CheckForWinner();

                // If playing against bots and the game is still ongoing, wait for 2 seconds before making a bot's move
                if (playwithbots && gameEnded == false)
                {
                    await Task.Delay(2000); // Wait for 2 seconds before the bot moves
                    BotMove(); // Execute the bot's move
                }
                if (playwithbots)
                {
                    ToggleButtons(true);
                }
            }
        }
        private async void BtnColumn5_Click(object sender, EventArgs e)
        {
            if (playwithbots)
            {
                ToggleButtons(false);
            }
            if (gameEnded == false && f < 6) //Check if the game has ended and if the column has been filled with discs
            {
                // List of buttons representing the rows in the fifth column
                Button[] buttonsArray = { b51, b52, b53, b54, b55, b56 };

                // Loop through the buttons in the column
                foreach (var btn in buttonsArray)
                {
                    if (btn.BackColor == theme) // Find the first empty button (its background color is the theme color, indicating an empty spot)
                    {
                        // Set the button's background image based on the current player's color (Yellow or Red)
                        Image image = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle;
                        btn.BackgroundImage = image;
                        btn.BackgroundImageLayout = ImageLayout.Stretch; // Stretch the image to fill the button's area
                        btn.BackColor = turn; // Set the button's background color to the current player's color
                        btn.FlatAppearance.MouseOverBackColor = turn; // Set the mouse-over background color to the current player's color
                        btn.FlatAppearance.MouseDownBackColor = turn; // Set the mouse-down background color to the current player's color
                        buttons.Add(btn); // Add the button to the list of clicked buttons

                        break; // Exit the loop after finding and filling the first empty button
                    }
                }

                // Play the click sound when a move is made
                PlayClickSound();

                // Increment the move counter and the total number of moves
                f++;
                moveCounter++;

                // Clear the redo stack (reset the state for any potential undo/redo functionality)
                redo.Clear();

                // Switch turns to the other player
                changeTurn();

                // Check if the current move results in a win
                CheckForWinner();

                // If playing against bots and the game is still ongoing, wait for 2 seconds before making a bot's move
                if (playwithbots && gameEnded == false)
                {
                    await Task.Delay(2000); // Wait for 2 seconds before the bot moves
                    BotMove(); // Execute the bot's move
                }
                if (playwithbots)
                {
                    ToggleButtons(true);
                }
            }
        }

        private async void btnColumn6_Click(object sender, EventArgs e)
        {
            if (playwithbots)
            {
                ToggleButtons(false);
            }
            if (gameEnded == false && g < 6) //Check if the game has ended and if the column has been filled with discs
            {
                // List of buttons representing the rows in the sixth column
                Button[] buttonsArray = { b61, b62, b63, b64, b65, b66 };

                // Loop through the buttons in the column
                foreach (var btn in buttonsArray)
                {
                    if (btn.BackColor == theme) // Find the first empty button (its background color is the theme color, indicating an empty spot)
                    {
                        // Set the button's background image based on the current player's color (Yellow or Red)
                        Image image = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle;
                        btn.BackgroundImage = image;
                        btn.BackgroundImageLayout = ImageLayout.Stretch; // Stretch the image to fill the button's area
                        btn.BackColor = turn; // Set the button's background color to the current player's color
                        btn.FlatAppearance.MouseOverBackColor = turn; // Set the mouse-over background color to the current player's color
                        btn.FlatAppearance.MouseDownBackColor = turn; // Set the mouse-down background color to the current player's color
                        buttons.Add(btn); // Add the button to the list of clicked buttons

                        break; // Exit the loop after finding and filling the first empty button
                    }
                }

                // Play the click sound when a move is made
                PlayClickSound();

                // Increment the move counter and the total number of moves
                g++;
                moveCounter++;

                // Clear the redo stack (reset the state for any potential undo/redo functionality)
                redo.Clear();

                // Switch turns to the other player
                changeTurn();

                // Check if the current move results in a win
                CheckForWinner();

                // If playing against bots and the game is still ongoing, wait for 2 seconds before making a bot's move
                if (playwithbots && gameEnded == false)
                {
                    await Task.Delay(2000); // Wait for 2 seconds before the bot moves
                    BotMove(); // Execute the bot's move
                }
                if (playwithbots)
                {
                    ToggleButtons(true);
                }
            }
        }
        private async void btnColumn7_Click(object sender, EventArgs e)
        {
            if (playwithbots)
            {
                ToggleButtons(false);
            }
            if (gameEnded == false && h < 6) //Check if the game has ended and if the column has been filled with discs
            {
                // List of buttons representing the rows in the seventh column
                Button[] buttonsArray = { b71, b72, b73, b74, b75, b76 };

                // Loop through the buttons in the column
                foreach (var btn in buttonsArray)
                {
                    if (btn.BackColor == theme) // Find the first empty button (its background color is the theme color, indicating an empty spot)
                    {
                        // Set the button's background image based on the current player's color (Yellow or Red)
                        Image image = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle;
                        btn.BackgroundImage = image;
                        btn.BackgroundImageLayout = ImageLayout.Stretch; // Stretch the image to fill the button's area
                        btn.BackColor = turn; // Set the button's background color to the current player's color
                        btn.FlatAppearance.MouseOverBackColor = turn; // Set the mouse-over background color to the current player's color
                        btn.FlatAppearance.MouseDownBackColor = turn; // Set the mouse-down background color to the current player's color
                        buttons.Add(btn); // Add the button to the list of clicked buttons

                        break; // Exit the loop after finding and filling the first empty button
                    }
                }

                // Play the click sound when a move is made
                PlayClickSound();

                // Increment the move counter and the total number of moves
                h++;
                moveCounter++;

                // Clear the redo stack (reset the state for any potential undo/redo functionality)
                redo.Clear();

                // Switch turns to the other player
                changeTurn();

                // Check if the current move results in a win
                CheckForWinner();

                // If playing against bots and the game is still ongoing, wait for 2 seconds before making a bot's move
                if (playwithbots && gameEnded == false)
                {
                    await Task.Delay(2000); // Wait for 2 seconds before the bot moves
                    BotMove(); // Execute the bot's move
                }
                if (playwithbots)
                {
                    ToggleButtons(true);
                }
            }
        }

        private void BotMove()
        {
            Random rand = new Random(); // Create a new Random object to generate random numbers
            int column = rand.Next(1, 8); // Randomly choose a column between 1 and 7

            // Depending on the chosen column, find the first available empty space in that column
            if (column == 1 && a < 6) // If the chosen column is 1 and there are fewer than 6 moves made in this column
            {
                Button[] buttonsArray1 = { b11, b12, b13, b14, b15, b16 }; // List of buttons in column 1

                foreach (var btn in buttonsArray1)
                {
                    if (btn.BackColor == theme) // Check if the button is empty (its background color matches the theme)
                    {
                        // Set the button's background image and color based on the current player's turn (Yellow or Red)
                        Image image = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle;
                        btn.BackgroundImage = image;
                        btn.BackgroundImageLayout = ImageLayout.Stretch; // Stretch the image to fit the button
                        btn.BackColor = turn; // Set the button's background color to the current player's color
                        btn.FlatAppearance.MouseOverBackColor = turn; // Set the mouse-over color to match the player's color
                        btn.FlatAppearance.MouseDownBackColor = turn; // Set the mouse-down color to match the player's color
                        buttons.Add(btn); // Add the button to the list of buttons that have been clicked

                        break; // Exit the loop once the first available empty button is found and filled
                    }
                }
                a++; // Increment the move counter for column 1
            }
            else if (column == 2 && b < 6) // If the chosen column is 2 and there are fewer than 6 moves made in this column
            {
                Button[] buttonsArray2 = { b21, b22, b23, b24, b25, b26 }; // List of buttons in column 2

                foreach (var btn in buttonsArray2)
                {
                    if (btn.BackColor == theme) // Check if the button is empty
                    {
                        // Set the button's background image and color based on the current player's turn
                        Image image = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle;
                        btn.BackgroundImage = image;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackColor = turn;
                        btn.FlatAppearance.MouseOverBackColor = turn;
                        btn.FlatAppearance.MouseDownBackColor = turn;
                        buttons.Add(btn);

                        break; // Exit the loop after filling the first available button
                    }
                }
                b++; // Increment the move counter for column 2
            }
            else if (column == 3 && c < 6) // If the chosen column is 3 and there are fewer than 6 moves made in this column
            {
                Button[] buttonsArray3 = { b31, b32, b33, b34, b35, b36 }; // List of buttons in column 3

                foreach (var btn in buttonsArray3)
                {
                    if (btn.BackColor == theme) // Check if the button is empty
                    {
                        // Set the button's background image and color based on the current player's turn
                        Image image = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle;
                        btn.BackgroundImage = image;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackColor = turn;
                        btn.FlatAppearance.MouseOverBackColor = turn;
                        btn.FlatAppearance.MouseDownBackColor = turn;
                        buttons.Add(btn);

                        break; // Exit the loop after filling the first available button
                    }
                }
                c++; // Increment the move counter for column 3
            }
            else if (column == 4 && d < 6) // If the chosen column is 4 and there are fewer than 6 moves made in this column
            {
                Button[] buttonsArray4 = { b41, b42, b43, b44, b45, b46 }; // List of buttons in column 4

                foreach (var btn in buttonsArray4)
                {
                    if (btn.BackColor == theme) // Check if the button is empty
                    {
                        // Set the button's background image and color based on the current player's turn
                        Image image = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle;
                        btn.BackgroundImage = image;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackColor = turn;
                        btn.FlatAppearance.MouseOverBackColor = turn;
                        btn.FlatAppearance.MouseDownBackColor = turn;
                        buttons.Add(btn);

                        break; // Exit the loop after filling the first available button
                    }
                }
                d++; // Increment the move counter for column 4
            }
            else if (column == 5 && f < 6) // If the chosen column is 5 and there are fewer than 6 moves made in this column
            {
                Button[] buttonsArray5 = { b51, b52, b53, b54, b55, b56 }; // List of buttons in column 5
                foreach (var btn in buttonsArray5)
                {
                    if (btn.BackColor == theme) // Check if the button is empty
                    {
                        // Set the button's background image and color based on the current player's turn
                        Image image = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle;
                        btn.BackgroundImage = image;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackColor = turn;
                        btn.FlatAppearance.MouseOverBackColor = turn;
                        btn.FlatAppearance.MouseDownBackColor = turn;
                        buttons.Add(btn);

                        break; // Exit the loop after filling the first available button
                    }
                }
                f++; // Increment the move counter for column 5
            }
            else if (column == 6 && g < 6) // If the chosen column is 6 and there are fewer than 6 moves made in this column
            {
                Button[] buttonsArray6 = { b61, b62, b63, b64, b65, b66 }; // List of buttons in column 6

                foreach (var btn in buttonsArray6)
                {
                    if (btn.BackColor == theme) // Check if the button is empty
                    {
                        // Set the button's background image and color based on the current player's turn
                        Image image = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle;
                        btn.BackgroundImage = image;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackColor = turn;
                        btn.FlatAppearance.MouseOverBackColor = turn;
                        btn.FlatAppearance.MouseDownBackColor = turn;
                        buttons.Add(btn);

                        break; // Exit the loop after filling the first available button
                    }
                }
                g++; // Increment the move counter for column 6
            }
            else if (column == 7 && h < 6) // If the chosen column is 7 and there are fewer than 6 moves made in this column
            {
                Button[] buttonsArray7 = { b71, b72, b73, b74, b75, b76 }; // List of buttons in column 7

                foreach (var btn in buttonsArray7)
                {
                    if (btn.BackColor == theme) // Check if the button is empty
                    {
                        // Set the button's background image and color based on the current player's turn
                        Image image = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle;
                        btn.BackgroundImage = image;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;
                        btn.BackColor = turn;
                        btn.FlatAppearance.MouseOverBackColor = turn;
                        btn.FlatAppearance.MouseDownBackColor = turn;
                        buttons.Add(btn);

                        break; // Exit the loop after filling the first available button
                    }
                }
                h++; // Increment the move counter for column 7
            }

            // After the bot makes its move, increment the move counter, clear the redo stack, switch turns, and check for a winner
            moveCounter++;
            redo.Clear(); // Clear the redo stack
            changeTurn(); // Change the turn to the other player
            CheckForWinner(); // Check if the bot's move results in a win
        }
        private void ToggleButtons(bool enable)
        {
            // Disable or enable all buttons in the grid
            b11.Enabled = enable; b12.Enabled = enable; b13.Enabled = enable; b14.Enabled = enable; b15.Enabled = enable; b16.Enabled = enable;
            b21.Enabled = enable; b22.Enabled = enable; b23.Enabled = enable; b24.Enabled = enable; b25.Enabled = enable; b26.Enabled = enable;
            b31.Enabled = enable; b32.Enabled = enable; b33.Enabled = enable; b34.Enabled = enable; b35.Enabled = enable; b36.Enabled = enable;
            b41.Enabled = enable; b42.Enabled = enable; b43.Enabled = enable; b44.Enabled = enable; b45.Enabled = enable; b46.Enabled = enable;
            b51.Enabled = enable; b52.Enabled = enable; b53.Enabled = enable; b54.Enabled = enable; b55.Enabled = enable; b56.Enabled = enable;
            b61.Enabled = enable; b62.Enabled = enable; b63.Enabled = enable; b64.Enabled = enable; b65.Enabled = enable; b66.Enabled = enable;
            b71.Enabled = enable; b72.Enabled = enable; b73.Enabled = enable; b74.Enabled = enable; b75.Enabled = enable; b76.Enabled = enable;

            // Add other buttons here if needed

        }

        int undoCountPlayer1 = 0; // Keeps track of the number of undo moves for Player 1
        int undoCountPlayer2 = 0; // Keeps track of the number of undo moves for Player 2
        int totalUndoCount = 0; // Tracks the total number of undo moves (for both Player 1 and the Bot)

        private void bUndo_Click(object sender, EventArgs e)
        {
            // Check if there are moves to undo and if the buttons list is not empty
            if (moveCounter > 0 && buttons.Count != 0)
            {
                if (playwithbots)
                {
                    // When playing with a bot, check the total number of undos
                    if (totalUndoCount < 3)
                    {
                        UndoBotAndPlayer(); // Undo both the bot's and the player's moves
                    }
                    else
                    {
                        MessageBox.Show("You have reached the maximum number of undos (3 moves)!");
                    }
                }
                else
                {
                    // When playing with another player, check the current turn and undo count
                    if (turn == Color.Red && undoCountPlayer1 < 3)
                    {
                        UndoMove(); // Undo the move for Player 1
                        undoCountPlayer1++; // Increment Player 1's undo count
                    }
                    else if (turn == Color.Yellow && undoCountPlayer2 < 3)
                    {
                        UndoMove(); // Undo the move for Player 2
                        undoCountPlayer2++; // Increment Player 2's undo count
                    }
                    else
                    {
                        MessageBox.Show("You have reached the maximum number of undos for this player.");
                    }
                }
            }
        }

        private void UndoBotAndPlayer()
        {
            // Undo the bot's move
            UndoMove();
            // Undo the player's move if there are moves left
            if (buttons.Count > 0)
            {
                UndoMove();
            }

            // Increment the total undo count
            totalUndoCount++;
        }
        private void UndoMove()
        {
            // Decrease the count of played cells based on the position of the last button clicked
            if (buttons.Last() == b11 || buttons.Last() == b12 || buttons.Last() == b13 || buttons.Last() == b14 || buttons.Last() == b15 || buttons.Last() == b16)
            {
                a--; // Decrement count for row 1
            }
            else if (buttons.Last() == b21 || buttons.Last() == b22 || buttons.Last() == b23 || buttons.Last() == b24 || buttons.Last() == b25 || buttons.Last() == b26)
            {
                b--; // Decrement count for row 2
            }
            else if (buttons.Last() == b31 || buttons.Last() == b32 || buttons.Last() == b33 || buttons.Last() == b34 || buttons.Last() == b35 || buttons.Last() == b36)
            {
                c--; // Decrement count for row 3
            }
            else if (buttons.Last() == b41 || buttons.Last() == b42 || buttons.Last() == b43 || buttons.Last() == b44 || buttons.Last() == b45 || buttons.Last() == b46)
            {
                d--; // Decrement count for row 4
            }
            else if (buttons.Last() == b51 || buttons.Last() == b52 || buttons.Last() == b53 || buttons.Last() == b54 || buttons.Last() == b55 || buttons.Last() == b56)
            {
                f--; // Decrement count for row 5
            }
            else if (buttons.Last() == b61 || buttons.Last() == b62 || buttons.Last() == b63 || buttons.Last() == b64 || buttons.Last() == b65 || buttons.Last() == b66)
            {
                g--; // Decrement count for row 6
            }
            else if (buttons.Last() == b71 || buttons.Last() == b72 || buttons.Last() == b73 || buttons.Last() == b74 || buttons.Last() == b75 || buttons.Last() == b76)
            {
                h--; // Decrement count for row 7
            }

            // Clear the background image and reset the button's state
            Button lastButton = buttons.Last();
            lastButton.BackgroundImage = null; // Remove the image
            lastButton.BackColor = theme; // Reset the background color
            lastButton.FlatAppearance.MouseOverBackColor = theme; // Reset mouse-over color
            lastButton.FlatAppearance.MouseDownBackColor = theme; // Reset mouse-down color

            redo.Add(lastButton);// Add the last button to the redo list
            buttons.RemoveAt(buttons.Count - 1); // Remove the last button from the buttons list
            moveCounter--; // Decrease the move counter

            // Change the turn to the other player
            changeTurn();
        }
        private void ResetBoard()
        {
            // Reset each button on the board to its initial state
            foreach (Button btn in buttons)
            {
                btn.BackColor = theme; // Reset background color
                btn.BackgroundImage = null; // Remove any image
                btn.FlatAppearance.MouseOverBackColor = theme; // Reset mouse-over color
                btn.FlatAppearance.MouseDownBackColor = theme; // Reset mouse-down color
            }
        }
        private void lblTitle_Click(object sender, EventArgs e)
        {
            // Placeholder for title label click event 
        }

        private void tblButtons_Paint(object sender, PaintEventArgs e)
        {
            // Placeholder for table buttons paint event 
        }

        private void btnTurn_Click(object sender, EventArgs e)
        {
            //Determine the bot's image based on the current turn
            Image image = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle;
            btnTurn.BackgroundImage = image; // Set the background image
            btnTurn.BackgroundImageLayout = ImageLayout.Stretch; // Stretch the image to fit
        }


        private void lblRedScore_Click(object sender, EventArgs e)
        {
            // Placeholder for red score label click event
        }

        private void bRedo_Click(object sender, EventArgs e)
        {
            // Handle the redo functionality
            if (redo.Count != 0)// Check if there are any moves to redo
            {
                if (playwithbots)// Check if playing against a bot
                {
                    // If playing against a bot, redo needs to handle both player and bot moves
                    if (redo.Count >= 2)
                    {
                        // Redo the player's last move

                        Button userMove = redo.Last();// Get the last move of the player
                        Image userImage = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle;
                        redo.Last().BackColor = turn;
                        redo.Last().FlatAppearance.MouseOverBackColor = turn;
                        redo.Last().FlatAppearance.MouseDownBackColor = turn;
                        userMove.BackgroundImage = userImage; // Set the player's image
                        userMove.BackgroundImageLayout = ImageLayout.Stretch; // Stretch the image to fit
                        buttons.Add(userMove); // Add the button back to the buttons list
                        redo.RemoveAt(redo.Count - 1); // Remove the player's move from the redo list

                        // Change turn and redo the bot's move
                        changeTurn();

                        int botMoveIndex = redo.Count - 1; // Index for the bot's move
                        Button botMove = redo[botMoveIndex];// Get the last move of the bot
                        Image botImage = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle;
                        botMove.BackColor = turn;
                        botMove.FlatAppearance.MouseOverBackColor = turn;
                        botMove.FlatAppearance.MouseDownBackColor = turn;
                        botMove.BackgroundImage = botImage; // Set the bot's image
                        botMove.BackgroundImageLayout = ImageLayout.Stretch; // Stretch the image to fit the button
                        buttons.Add(botMove); // Add the bot's button back to the buttons list
                        redo.RemoveAt(botMoveIndex); // Remove the bot's move from the redo list

                        moveCounter += 2; // Increase the move counter for both moves
                        changeTurn(); // Return the turn to the correct player
                    }
                    else
                    {
                        MessageBox.Show("No more moves to redo!"); // Notify if no moves are available to redo
                    }
                }
                else
                {
                    // If playing against another player, redo only applies to the current player
                    Button lastMove = redo.Last(); // Get the last move from the redo list
                    Image playerImage = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle;
                    redo.Last().BackColor = turn;
                    redo.Last().FlatAppearance.MouseOverBackColor = turn;
                    redo.Last().FlatAppearance.MouseDownBackColor = turn;
                    lastMove.BackgroundImage = playerImage; // Set the current player's image
                    lastMove.BackgroundImageLayout = ImageLayout.Stretch; // Stretch the image to fit
                    buttons.Add(lastMove); // Add the last move back to the buttons list
                    redo.RemoveAt(redo.Count - 1); // Remove the last move from the redo list

                    moveCounter++; // Increase the move counter
                    changeTurn(); // Change the turn to the other player
                }

            }

            else
            {
                MessageBox.Show("No moves to redo!"); // Notify if there are no moves to redo
            }
        }

        private void GreeenGrid_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle keyboard input for making moves
            switch (e.KeyCode)
            {
                case Keys.D1:
                case Keys.NumPad1:
                    b11.PerformClick(); // Simulate click on button 1
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    b21.PerformClick(); // Simulate click on button 2
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    b31.PerformClick(); // Simulate click on button 3
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    b41.PerformClick(); // Simulate click on button 4
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    b51.PerformClick(); // Simulate click on button 5
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    b61.PerformClick(); // Simulate click on button 6
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    b71.PerformClick(); // Simulate click on button 7
                    break;
                case Keys.R:
                    btnRestart.PerformClick(); // Simulate click on restart button
                    break;
                default://Ensure that only specific key presses trigger actions
                    break; // Exit the switch statement for unhandled keys
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Process command keys for undo and redo actions
            switch (keyData)
            {
                case Keys.Left:
                    bUndo.PerformClick(); // Simulate click on undo button
                    break;
                case Keys.Right:
                    bRedo.PerformClick(); // Simulate click on redo button
                    break;
                default://This ensures that only specific key presses trigger actions

                    break; // Exit the switch statement for unhandled keys
            }
            return base.ProcessCmdKey(ref msg, keyData); // Call base method
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form

            // Show the main menu form
            HomePage.Instance.Show();
        }

        private void GreeenGrid_Load(object sender, EventArgs e)
        {

        }
        private void changeTurn()
        {
            // Switch the turn between players
            if (turn == Color.Red)
            {
                turn = Color.Yellow; // Change turn to Yellow(Recycle)
                whoWon = "Tree"; // Update who won
            }
            else
            {
                turn = Color.Red; // Change turn to Red(Tree)
                whoWon = "Recycle"; // Update who won
            }

            UpdateStatus(); // Update the game
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            foreach (Button b in tblGreeenGrid.Controls)
            {
                if (b.BackgroundImage != null || b.BackColor != theme)
                {
                    b.BackgroundImage = null; // Clear the background image of each button in the button list
                    b.BackColor = theme; // Reset the background color
                    b.FlatAppearance.MouseOverBackColor = theme; // Reset the hover background color
                    b.FlatAppearance.MouseDownBackColor = theme; // Reset the mouse-down background color
                }
            }

            a = 0; b = 0; c = 0; d = 0; f = 0; g = 0; h = 0; moveCounter = 0; // Reset move counters
            gameEnded = false; // Reset the game state to not ended
            buttons.Clear(); // Clear the list of clicked buttons
            redo.Clear(); // Clear the redo stack

            // Reset undo counts for each player
            if (playwithbots)
            {
                totalUndoCount = 0; // Reset the undo count in play-with-bot mode
            }
            else
            {
                undoCountPlayer1 = 0;
                undoCountPlayer2 = 0; // Reset the undo count for each player
            }

            // Switch the starting player and reset turn color
            if (redStarts == false)
            {
                turn = Color.Yellow; // Set turn to Yellow
                whoWon = "Red"; // Set previous winner to Red
                redStarts = true; // Set Red as the starting player
            }
            else
            {
                turn = Color.Red; // Set turn to Red
                whoWon = "Yellow"; // Set previous winner to Yellow
                redStarts = false; // Set Yellow as the starting player
            }

            UpdateStatus(); // Update the game status display
        }

        int treeWins = 0; // Number of wins for "Tree" team
        int recycleWins = 0; // Number of wins for "Recycle" team

        private void CheckForWinner()
        {
            #region Rows 
            // Check rows for a win condition: If four consecutive buttons in a row have the same non-theme color.
            // (repeat similar conditions for each horizontal sequence of 4 cells)
            if ((b11.BackColor == b21.BackColor && b21.BackColor == b31.BackColor && b31.BackColor == b41.BackColor && b11.BackColor != theme) ||
                (b21.BackColor == b31.BackColor && b31.BackColor == b41.BackColor && b41.BackColor == b51.BackColor && b21.BackColor != theme) ||
                (b31.BackColor == b41.BackColor && b41.BackColor == b51.BackColor && b51.BackColor == b61.BackColor && b31.BackColor != theme) ||
                (b41.BackColor == b51.BackColor && b51.BackColor == b61.BackColor && b61.BackColor == b71.BackColor && b41.BackColor != theme) ||
                (b12.BackColor == b22.BackColor && b22.BackColor == b32.BackColor && b32.BackColor == b42.BackColor && b12.BackColor != theme) ||
                (b22.BackColor == b32.BackColor && b32.BackColor == b42.BackColor && b42.BackColor == b52.BackColor && b22.BackColor != theme) ||
                (b32.BackColor == b42.BackColor && b42.BackColor == b52.BackColor && b52.BackColor == b62.BackColor && b32.BackColor != theme) ||
                (b42.BackColor == b52.BackColor && b52.BackColor == b62.BackColor && b62.BackColor == b72.BackColor && b42.BackColor != theme) ||
                (b13.BackColor == b23.BackColor && b23.BackColor == b33.BackColor && b33.BackColor == b43.BackColor && b13.BackColor != theme) ||
                (b23.BackColor == b33.BackColor && b33.BackColor == b43.BackColor && b43.BackColor == b53.BackColor && b23.BackColor != theme) ||
                (b33.BackColor == b43.BackColor && b43.BackColor == b53.BackColor && b53.BackColor == b63.BackColor && b33.BackColor != theme) ||
                (b43.BackColor == b53.BackColor && b53.BackColor == b63.BackColor && b63.BackColor == b73.BackColor && b43.BackColor != theme) ||
                (b14.BackColor == b24.BackColor && b24.BackColor == b34.BackColor && b34.BackColor == b44.BackColor && b14.BackColor != theme) ||
                (b24.BackColor == b34.BackColor && b34.BackColor == b44.BackColor && b44.BackColor == b54.BackColor && b24.BackColor != theme) ||
                (b34.BackColor == b44.BackColor && b44.BackColor == b54.BackColor && b54.BackColor == b64.BackColor && b34.BackColor != theme) ||
                (b44.BackColor == b54.BackColor && b54.BackColor == b64.BackColor && b64.BackColor == b74.BackColor && b44.BackColor != theme) ||
                (b15.BackColor == b25.BackColor && b25.BackColor == b35.BackColor && b35.BackColor == b45.BackColor && b15.BackColor != theme) ||
                (b25.BackColor == b35.BackColor && b35.BackColor == b45.BackColor && b45.BackColor == b55.BackColor && b25.BackColor != theme) ||
                (b35.BackColor == b45.BackColor && b45.BackColor == b55.BackColor && b55.BackColor == b65.BackColor && b35.BackColor != theme) ||
                (b45.BackColor == b55.BackColor && b55.BackColor == b65.BackColor && b65.BackColor == b75.BackColor && b45.BackColor != theme) ||
                (b16.BackColor == b26.BackColor && b26.BackColor == b36.BackColor && b36.BackColor == b46.BackColor && b16.BackColor != theme) ||
                (b26.BackColor == b36.BackColor && b36.BackColor == b46.BackColor && b46.BackColor == b56.BackColor && b26.BackColor != theme) ||
                (b36.BackColor == b46.BackColor && b46.BackColor == b56.BackColor && b56.BackColor == b66.BackColor && b36.BackColor != theme) ||
                (b46.BackColor == b56.BackColor && b56.BackColor == b66.BackColor && b66.BackColor == b76.BackColor && b46.BackColor != theme) ||
            #endregion
            #region Columns
                // Check columns for a win condition: If four consecutive buttons in a column have the same non-theme color.
                // (repeat similar conditions for vertical sequences)
                (b11.BackColor == b12.BackColor && b12.BackColor == b13.BackColor && b13.BackColor == b14.BackColor && b11.BackColor != theme) ||
                (b12.BackColor == b13.BackColor && b13.BackColor == b14.BackColor && b14.BackColor == b15.BackColor && b12.BackColor != theme) ||
                (b13.BackColor == b14.BackColor && b14.BackColor == b15.BackColor && b15.BackColor == b16.BackColor && b13.BackColor != theme) ||
                (b21.BackColor == b22.BackColor && b22.BackColor == b23.BackColor && b23.BackColor == b24.BackColor && b21.BackColor != theme) ||
                (b22.BackColor == b23.BackColor && b23.BackColor == b24.BackColor && b24.BackColor == b25.BackColor && b22.BackColor != theme) ||
                (b23.BackColor == b24.BackColor && b24.BackColor == b25.BackColor && b25.BackColor == b26.BackColor && b23.BackColor != theme) ||
                (b31.BackColor == b32.BackColor && b32.BackColor == b33.BackColor && b33.BackColor == b34.BackColor && b31.BackColor != theme) ||
                (b32.BackColor == b33.BackColor && b33.BackColor == b34.BackColor && b34.BackColor == b35.BackColor && b32.BackColor != theme) ||
                (b33.BackColor == b34.BackColor && b34.BackColor == b35.BackColor && b35.BackColor == b36.BackColor && b33.BackColor != theme) ||
                (b41.BackColor == b42.BackColor && b42.BackColor == b43.BackColor && b43.BackColor == b44.BackColor && b41.BackColor != theme) ||
                (b42.BackColor == b43.BackColor && b43.BackColor == b44.BackColor && b44.BackColor == b45.BackColor && b42.BackColor != theme) ||
                (b43.BackColor == b44.BackColor && b44.BackColor == b45.BackColor && b45.BackColor == b46.BackColor && b43.BackColor != theme) ||
                (b51.BackColor == b52.BackColor && b52.BackColor == b53.BackColor && b53.BackColor == b54.BackColor && b51.BackColor != theme) ||
                (b52.BackColor == b53.BackColor && b53.BackColor == b54.BackColor && b54.BackColor == b55.BackColor && b52.BackColor != theme) ||
                (b53.BackColor == b54.BackColor && b54.BackColor == b55.BackColor && b55.BackColor == b56.BackColor && b53.BackColor != theme) ||
                (b61.BackColor == b62.BackColor && b62.BackColor == b63.BackColor && b63.BackColor == b64.BackColor && b61.BackColor != theme) ||
                (b62.BackColor == b63.BackColor && b63.BackColor == b64.BackColor && b64.BackColor == b65.BackColor && b62.BackColor != theme) ||
                (b63.BackColor == b64.BackColor && b64.BackColor == b65.BackColor && b65.BackColor == b66.BackColor && b63.BackColor != theme) ||
                (b71.BackColor == b72.BackColor && b72.BackColor == b73.BackColor && b73.BackColor == b74.BackColor && b71.BackColor != theme) ||
                (b72.BackColor == b73.BackColor && b73.BackColor == b74.BackColor && b74.BackColor == b75.BackColor && b72.BackColor != theme) ||
                (b73.BackColor == b74.BackColor && b74.BackColor == b75.BackColor && b75.BackColor == b76.BackColor && b73.BackColor != theme) ||
            #endregion
            #region Diagonals Right 
                // Check diagonals (top-left to bottom-right) for a win condition. 
                // (repeat similar conditions for all possible diagonal sequences)
                (b11.BackColor == b22.BackColor && b22.BackColor == b33.BackColor && b33.BackColor == b44.BackColor && b11.BackColor != theme) ||
                (b12.BackColor == b23.BackColor && b23.BackColor == b34.BackColor && b34.BackColor == b45.BackColor && b12.BackColor != theme) ||
                (b13.BackColor == b24.BackColor && b24.BackColor == b35.BackColor && b35.BackColor == b46.BackColor && b13.BackColor != theme) ||
                (b21.BackColor == b32.BackColor && b32.BackColor == b43.BackColor && b43.BackColor == b54.BackColor && b21.BackColor != theme) ||
                (b22.BackColor == b33.BackColor && b33.BackColor == b44.BackColor && b44.BackColor == b55.BackColor && b22.BackColor != theme) ||
                (b23.BackColor == b34.BackColor && b34.BackColor == b45.BackColor && b45.BackColor == b56.BackColor && b23.BackColor != theme) ||
                (b31.BackColor == b42.BackColor && b42.BackColor == b53.BackColor && b53.BackColor == b64.BackColor && b31.BackColor != theme) ||
                (b32.BackColor == b43.BackColor && b43.BackColor == b54.BackColor && b54.BackColor == b65.BackColor && b32.BackColor != theme) ||
                (b33.BackColor == b44.BackColor && b44.BackColor == b55.BackColor && b55.BackColor == b66.BackColor && b33.BackColor != theme) ||
                (b41.BackColor == b52.BackColor && b52.BackColor == b63.BackColor && b63.BackColor == b74.BackColor && b41.BackColor != theme) ||
                (b42.BackColor == b53.BackColor && b53.BackColor == b64.BackColor && b64.BackColor == b75.BackColor && b42.BackColor != theme) ||
                (b43.BackColor == b54.BackColor && b54.BackColor == b65.BackColor && b65.BackColor == b76.BackColor && b43.BackColor != theme) ||
            #endregion
            #region Diagonals Left
                // Check diagonals (top-right to bottom-left) for a win condition.
                // (repeat similar conditions for all possible diagonal sequences)
                (b71.BackColor == b62.BackColor && b62.BackColor == b53.BackColor && b53.BackColor == b44.BackColor && b71.BackColor != theme) ||
                (b72.BackColor == b63.BackColor && b63.BackColor == b54.BackColor && b54.BackColor == b45.BackColor && b72.BackColor != theme) ||
                (b73.BackColor == b64.BackColor && b64.BackColor == b55.BackColor && b55.BackColor == b46.BackColor && b73.BackColor != theme) ||
                (b61.BackColor == b52.BackColor && b52.BackColor == b43.BackColor && b43.BackColor == b34.BackColor && b61.BackColor != theme) ||
                (b62.BackColor == b53.BackColor && b53.BackColor == b44.BackColor && b44.BackColor == b35.BackColor && b62.BackColor != theme) ||
                (b63.BackColor == b54.BackColor && b54.BackColor == b45.BackColor && b45.BackColor == b36.BackColor && b63.BackColor != theme) ||
                (b51.BackColor == b42.BackColor && b42.BackColor == b33.BackColor && b33.BackColor == b24.BackColor && b51.BackColor != theme) ||
                (b52.BackColor == b43.BackColor && b43.BackColor == b34.BackColor && b34.BackColor == b25.BackColor && b52.BackColor != theme) ||
                (b53.BackColor == b44.BackColor && b44.BackColor == b35.BackColor && b35.BackColor == b26.BackColor && b53.BackColor != theme) ||
                (b41.BackColor == b32.BackColor && b32.BackColor == b23.BackColor && b23.BackColor == b14.BackColor && b41.BackColor != theme) ||
                (b42.BackColor == b33.BackColor && b33.BackColor == b24.BackColor && b24.BackColor == b15.BackColor && b42.BackColor != theme) ||
                (b43.BackColor == b34.BackColor && b34.BackColor == b25.BackColor && b25.BackColor == b16.BackColor && b43.BackColor != theme))
            #endregion
            {
                if (!gameEnded)
                {
                    gameEnded = true; // Flag indicating the game has ended.

                    if (whoWon == "Tree")
                    {
                        R++; // Increment the "Tree" player's win count.
                        treeWins++;  // Increment the internal "Tree" win counter.
                        lblRedScore.Text = $"Tree : {R}"; // Update the score label for "Tree."
                        icon = MessageBoxIcon.Error; // Set an error icon for the message box.
                    }
                    else if (whoWon == "Recycle")
                    {
                        Y++; // Increment the "Recycle" player's win count.
                        recycleWins++; // Increment the internal "Recycle" win counter.
                        lblYellowScore.Text = $"Recycle : {Y}"; // Update the score label for "Recycle."
                        icon = MessageBoxIcon.Warning;// Set a warning icon for the message box.
                    }
                }
                // List of environmental facts to display after a win.
                List<string> environmentalFacts = new List<string>
                {
    "Protecting the environment is the responsibility and pride of UEH students.",
    "Every UEH student should learn how to classify waste to minimize the risk of spreading pathogens.",
    "Act today, protect tomorrow.",
    "Some waste can become useful materials by reusing them for other purposes in a creative way.",
    "A clean environment is an important factor in the development of UEH.",
    "UEH encourages the choice and use of public transportation, UEH Shuttle Bus to travel to UEH facilities."
};

                int winCount = 0; // Track the number of times a player has won.
                HashSet<string> collectedFacts = new HashSet<string>(); // Keep track of unique facts already shown.

                winCount++;// Increment the win count for this game.

                Random random = new Random();// Random number generator for selecting a fact.
                string fact = environmentalFacts[random.Next(environmentalFacts.Count)];// Pick a random fact.

                // Ensure the fact is unique and not already shown.
                while (collectedFacts.Contains(fact) && collectedFacts.Count < environmentalFacts.Count)
                {
                    fact = environmentalFacts[random.Next(environmentalFacts.Count)];// Keep picking new facts until unique.
                }

                // Add the selected fact to the collected facts.
                collectedFacts.Add(fact);
                if (treeWins == 2)
                {
                    // If "Tree" wins 2 games, declare it the overall winner.
                    MessageBox.Show($"Tree is the overall winner ! Congratulations!\n" +
                                      $"Your message: {fact}\n" +
                                               $"Tree have received 2 messages", "Overall Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetGame();// Reset the game.
                }
                else if (recycleWins == 2)
                {
                    // If "Recycle" wins 2 games, declare it the overall winner.
                    MessageBox.Show($"Recycle is the overall winner! Congratulations!\n" + $"Your message: {fact}\n" +
                                                   $"Recycle have received 2 messages", "Overall Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetGame();// Reset the game.
                }
                else
                {
                    // Display a message for the current game's winner.
                    string message = $"{whoWon} Won The Game !!!\n" +
                                 $"You won the game {winCount} time.\n" +
                                 $"Your message: {fact}\n" +
                                 $"You have received {collectedFacts.Count} message.\n\n" +
                                 "Start a New Game?";
                    DialogResult result = MessageBox.Show(message, $"{whoWon} Wins", MessageBoxButtons.YesNo, icon);

                    if (result == DialogResult.Yes)
                        btnRestart.PerformClick(); // Restart the game if "Yes" is clicked.
                }
            }

            if (moveCounter == 42 && gameEnded == false)
            {
                // If all moves are used and there's no winner, declare a draw.
                DialogResult result;
                result = MessageBox.Show("Game Ended In a Draw !!!\nStart a New Game ?", "Draw", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    btnRestart.PerformClick();// Restart the game if "Yes" is clicked.
            }
        }
        private void ResetGame()
        {
            // Reset the win counters for both players to 0
            treeWins = 0;
            recycleWins = 0;

            // Trigger a game restart through the restart button
            btnRestart.PerformClick(); // Restart the game

            // Update the UI labels to reflect the reset scores
            lblRedScore.Text = "Tree: 0";
            lblYellowScore.Text = "Recycle: 0";

            // Reset additional score variables
            R = 0; // Reset score for "Tree"
            Y = 0; // Reset score for "Recycle"
        }

        private void UpdateStatus()
        {
            if (buttons.Count != 0) // Check if there are any moves
            {
                // Get the name of the last button clicked and extract the row and column info
                letters = buttons.Last().Name.ToCharArray();
                lblLastMove.Text = $"Last Move : C{letters[1]} R{letters[2]}";// Update the label with the last move
            }
            else
                lblLastMove.Text = "Last Move : N/A";// Show "N/A" if no moves have been made

            // Display the move counnt
            lblMove.Text = $"Move : {moveCounter}";
            // Update the player's turn indicator (Tree or Recycle image)
            Image image = (turn == Color.Red) ? GreenGrid1.Properties.Resources.tree : GreenGrid1.Properties.Resources.recycle; // hiển thị lượt của người chơi nào
            btnTurn.BackgroundImage = image;
            btnTurn.BackgroundImageLayout = ImageLayout.Stretch;// Adjust the image layout
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            if (theme == Color.OldLace)// Check the current theme color
            {
                theme = Color.FromArgb(35, 35, 35);// Switch to dark theme

                #region Change Button Color
                // Update the colors for various UI elements
                pnlInfo.BackColor = theme;
                pnlInfo.ForeColor = Color.WhiteSmoke;
                btnRestart.BackColor = Color.Gray;
                btnRestart.ForeColor = Color.Black;
                bUndo.BackColor = Color.DimGray;
                bRedo.BackColor = Color.DimGray;
                btnTheme.BackColor = Color.DimGray;
                bUndo.FlatAppearance.BorderColor = Color.Gray;
                bRedo.FlatAppearance.BorderColor = Color.Gray;
                btnTheme.FlatAppearance.BorderColor = Color.Gray;
                lblYellowScore.ForeColor = Color.Gold;
                lblLine.BackColor = Color.Gray;
                btnHome.BackColor = Color.Gray;
                btnHome.ForeColor = Color.Black;
                #endregion

                // Update the colors of the game grid buttons
                foreach (Button b in tblGreeenGrid.Controls)
                {
                    if (b.BackColor == Color.OldLace)// Change only buttons with the default theme
                    {
                        b.BackColor = theme;
                        b.FlatAppearance.MouseOverBackColor = theme;
                        b.FlatAppearance.MouseDownBackColor = theme;
                    }
                }
                // Update the window's custom theme
                CustomWindow(Color.FromArgb(45, 45, 45), Handle);
            }
            else
            {
                theme = Color.OldLace;// Switch back to light theme

                #region Change Button Color
                // Update the colors for various UI elements
                pnlInfo.BackColor = theme;
                pnlInfo.ForeColor = Color.Black;
                btnRestart.BackColor = Color.White;
                bUndo.BackColor = Color.Bisque;
                bRedo.BackColor = Color.Bisque;
                btnTheme.BackColor = Color.Bisque;
                bUndo.FlatAppearance.BorderColor = Color.DarkKhaki;
                bRedo.FlatAppearance.BorderColor = Color.DarkKhaki;
                btnTheme.FlatAppearance.BorderColor = Color.DarkKhaki;
                lblYellowScore.ForeColor = Color.DarkGoldenrod;
                lblLine.BackColor = Color.Black;
                btnHome.BackColor = Color.White;
                btnHome.ForeColor = Color.Black;
                #endregion

                // Update the colors of the game grid buttons
                foreach (Button b in tblGreeenGrid.Controls)
                {
                    if (b.BackColor == Color.FromArgb(35, 35, 35))// Change only buttons with the dark theme
                    {
                        b.BackColor = theme;
                        b.FlatAppearance.MouseOverBackColor = theme;
                        b.FlatAppearance.MouseDownBackColor = theme;
                    }
                }
                // Update the window's custom theme
                CustomWindow(Color.Bisque, Handle);
            }
        }

        private void btnHow_Click(object sender, EventArgs e)
        {
            if (how == null)// Check if the "How to Play" window is not open
            {
                how = new HowToPlay(this.Location, this.Size);// Create a new instance of the "How to Play" window
                how.Show();// Show the window
            }
            else
            {
                how.Hide();// Hide the current window
                how = new HowToPlay(this.Location, this.Size); // Create a new instance
                how.Show();// Show the new instance
                how.Activate();// Bring the window to focus
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (info == null)// Check if the "Info" window is not open
            {
                info = new Info(this.Location, this.Size);// Create a new instance of the "Info" window
                info.Show();// Show the window
            }
            else
            {
                info.Hide();// Hide the current window
                info = new Info(this.Location, this.Size);// Create a new instance
                info.Show();// Show the new instance
                info.Activate();// Bring the window to focus
            }
        }


    }
}