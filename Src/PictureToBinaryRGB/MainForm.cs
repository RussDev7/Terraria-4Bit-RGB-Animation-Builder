using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using System.Linq;
using System.IO;
using System;

namespace PictureToBinaryRGB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Attach the checkbox to the parent container for transparency.
            UseDefualt_CheckBox.Parent = Main_Picturebox;
            UseDefualt_CheckBox.Location = new Point(3, 2);
        }

        #region Loading Events

        // Do form loading events.
        private void MainForm_Load(object sender, EventArgs e)
        {
            #region Tooltips

            // Initialize tooltip.
            ToolTip toolTip = new ToolTip
            {
                AutoPopDelay = 5000,  // Tooltip stays visible for 5 seconds
                InitialDelay = 1000,  // Delay before the tooltip appears
                ReshowDelay = 500     // Delay before the tooltip reappears
            };

            // Set controls.
            toolTip.SetToolTip(ColorBox1, "Click to set a custom pixel color from the image.");
            toolTip.SetToolTip(ColorBox2, "Click to set a custom pixel color from the image.");
            toolTip.SetToolTip(ColorBox3, "Click to set a custom pixel color from the image.");
            toolTip.SetToolTip(ColorBox4, "Click to set a custom pixel color from the image.");
            toolTip.SetToolTip(ColorBox5, "Click to set a custom pixel color from the image.");
            toolTip.SetToolTip(ColorBox6, "Click to set a custom pixel color from the image.");
            toolTip.SetToolTip(ColorBox7, "Click to set a custom pixel color from the image.");
            toolTip.SetToolTip(ColorBox8, "Click to set a custom pixel color from the image.");
            toolTip.SetToolTip(ColorBox9, "Click to set a custom pixel color from the image.");
            toolTip.SetToolTip(ColorBox10, "Click to set a custom pixel color from the image.");
            toolTip.SetToolTip(ColorBox11, "Click to set a custom pixel color from the image.");
            toolTip.SetToolTip(ColorBox12, "Click to set a custom pixel color from the image.");
            toolTip.SetToolTip(ColorBox13, "Click to set a custom pixel color from the image.");
            toolTip.SetToolTip(ColorBox14, "Click to set a custom pixel color from the image.");
            toolTip.SetToolTip(ColorBox15, "Click to set a custom pixel color from the image.");
            toolTip.SetToolTip(ColorBox16, "Click to set a custom pixel color from the image.");

            toolTip.SetToolTip(AddPhotos_Button, "Select all the photos you wish to convert.");
            toolTip.SetToolTip(SaveLocation_Button, "Select a location to save the data.");
            toolTip.SetToolTip(ConvertImages_Button, "Start or stop the conversion process.");
            toolTip.SetToolTip(GeneratePalette_Button, "Generate a 16-bit color palette from the loaded image.");
            toolTip.SetToolTip(AddPhotos_Button, "Automatically generate a wirebulb texture sprite.");
            toolTip.SetToolTip(InGameCode_Button, "Shows the code to use in-game.");
            toolTip.SetToolTip(GenerateTexture_Button, "Create a custom wire bulb texture from the current palette.");

            toolTip.SetToolTip(UseDefualt_CheckBox, "Use the closest palette to vanilla textures.");
            toolTip.SetToolTip(GeneratePalette_CheckBox, "Create a custom wire bulb texture from palette.");
            toolTip.SetToolTip(ImageFlipMode_CheckBox, "Chooses the direction of 'X' while processing the image.");

            #endregion
        }
        #endregion

        #region Main

        // Public Vars
        public string[] PhotosLoc = { "" };
        public string SaveLoc = "";

        // Declare a CancellationTokenSource at the class level
        private CancellationTokenSource _cts;

        #region Main Controls

        #region Code Explorer Button '?'

        // Launch the Terraria code.
        private void InGameCode_Button_Click(object sender, EventArgs e)
        {
            #region Test Code

            /*
            string code = @"
            using System;

            class Program {
                static void Main() {
                    Console.WriteLine(""Hello World"");
                }
            }
            ";

            // Process the code: remove the first newline, trim the first 12 chars of each line, and remove the last newline
            string formattedCode = string.Join("\n",
                code.Split('\n')
                    .Skip(1) // Skip the first new line
                    .Select(line => line.Length >= 12 ? line.Substring(12) : line) // Remove first 12 chars
                    .Where(line => !string.IsNullOrWhiteSpace(line))               // Remove any empty trailing lines
            ).TrimEnd(); // Trim any remaining trailing new lines
            */
            #endregion

            // Open the code editor form
            CodeViewer codeEditor = new CodeViewer();
            codeEditor.ShowDialog();
        }
        #endregion

        #region Generate Texture Button

        // Generate custom texture from custom palette.
        private void GenerateTexture_Button_Click(object sender, EventArgs e)
        {
            CreateCustomWireBulbBitmap().Save(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Tiles_429.png", ImageFormat.Png);

            // Job Finished.
            MessageBox.Show("Saved a custom Wirebulb texture to the desktop!");
        }
        #endregion

        #region Import / Export Buttons

        // Get Images Folder.
        private void AddPhotos_Button_Click(object sender, EventArgs e)
        {
            AddPhotos_Textbox.Text = "";
            OpenFileDialog x = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Png Files|*.png|Jpg Files|*.jpg",
                Title = "Select Photos To Convert"
            };
            x.ShowDialog();
            PhotosLoc = x.FileNames;

            int PhotoCount = 0;

            // Sort Textbox
            foreach (string s in x.FileNames)
            {
                if (AddPhotos_Textbox.Text == "")
                {
                    // Get Dir Count
                    PhotoCount++;
                    AddPhotos_Textbox.Text = s;
                }
                else
                {
                    // Get Dir Count
                    PhotoCount++;
                    AddPhotos_Textbox.Text = s + ", " + AddPhotos_Textbox.Text;
                }
            }

        }

        // Export File Location.
        private void SaveLocation_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "P2B Schem Files|*.p2b",
                Title = "Picture To Binary Schematic Save Name"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SaveLoc = dialog.FileName;
                SaveLocation_Textbox.Text = dialog.FileName;
            }
        }
        #endregion

        #region Main Convert Button

        // Convert Images Button.
        private async void ConvertImages_Button_Click(object sender, EventArgs e)
        {
            // Check if locations are populated.
            if (AddPhotos_Textbox.Text == "")
            {
                MessageBox.Show("ERROR: Please select some photos to convert!");
                return;
            }
            else if (SaveLocation_Textbox.Text == "")
            {
                MessageBox.Show("ERROR: Please select a location to save your conversion!");
                return;
            }
            else if (ConvertImages_Button.Text == "Cancle Conversion")
            {
                // Cancel the task
                _cts?.Cancel();

                // Ensure _cts is cleared
                _cts = null;

                // Enable controls.
                Main_Picturebox.Enabled = true;
                UseDefualt_CheckBox.Enabled = true;
                ColorPalette_Groupbox.Enabled = true;
                Offsets_Groupbox.Enabled = true;
                AddPhotos_Textbox.Enabled = true;
                AddPhotos_Button.Enabled = true;
                SaveLocation_Textbox.Enabled = true;
                SaveLocation_Button.Enabled = true;
                ImageFlipMode_CheckBox.Enabled = true;

                // Reset UI elements
                ConvertImages_Button.Text = "Convert Images";
                ProgressBar.Value = 0;

                MessageBox.Show("Conversion was canceled!");
                return;
            }
            else
            {
                // Disable controls.
                Main_Picturebox.Enabled = false;
                UseDefualt_CheckBox.Enabled = false;
                ColorPalette_Groupbox.Enabled = false;
                Offsets_Groupbox.Enabled = false;
                AddPhotos_Textbox.Enabled = false;
                AddPhotos_Button.Enabled = false;
                SaveLocation_Textbox.Enabled = false;
                SaveLocation_Button.Enabled = false;
                ImageFlipMode_CheckBox.Enabled = false;

                // Change buttons text.
                ConvertImages_Button.Text = "Cancle Conversion";

                // Create a new CancellationTokenSource
                _cts = new CancellationTokenSource();

                try
                {
                    // Convert Images with cancellation support.
                    await Task.Run(() => ConvertToBinary(PhotosLoc, _cts.Token));
                }
                catch (OperationCanceledException)
                {
                    // Exit function immediately
                    return;
                }

                if (_cts != null)
                {
                    // Ensure _cts is cleared after successful execution
                    _cts = null;

                    // Reset progressbar.
                    ProgressBar.Value = 0;

                    // Change buttons text back to default.
                    ConvertImages_Button.Text = "Convert Images";

                    // Enable controls.
                    Main_Picturebox.Enabled = true;
                    UseDefualt_CheckBox.Enabled = true;
                    ColorPalette_Groupbox.Enabled = true;
                    Offsets_Groupbox.Enabled = true;
                    AddPhotos_Textbox.Enabled = true;
                    AddPhotos_Button.Enabled = true;
                    SaveLocation_Textbox.Enabled = true;
                    SaveLocation_Button.Enabled = true;
                    ImageFlipMode_CheckBox.Enabled = false;

                    // Job Finished.
                    MessageBox.Show("Conversion Has Completed!");

                    // Check if we need to make a texture palette.
                    if (GeneratePalette_CheckBox.Checked)
                    {
                        CreateCustomWireBulbBitmap().Save(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Tiles_429.png", ImageFormat.Png);

                        // Job Finished.
                        MessageBox.Show("Saved a custom Wirebulb texture to the desktop!");
                    }
                }
            }
        }
        #endregion

        #endregion

        #region Create Custom WireBulb Texture

        public Bitmap CreateCustomWireBulbBitmap()
        {
            // Create a 286x34 pixel image with a transparent background
            Bitmap bitmap = new Bitmap(286, 34, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                List<Color> colors = new List<Color>
                {
                    ColorBox1.BackColor,
                    ColorBox2.BackColor,
                    ColorBox3.BackColor,
                    ColorBox4.BackColor,
                    ColorBox5.BackColor,
                    ColorBox6.BackColor,
                    ColorBox7.BackColor,
                    ColorBox8.BackColor,
                    ColorBox9.BackColor,
                    ColorBox10.BackColor,
                    ColorBox11.BackColor,
                    ColorBox12.BackColor,
                    ColorBox13.BackColor,
                    ColorBox14.BackColor,
                    ColorBox15.BackColor,
                    ColorBox16.BackColor
                };

                // Set the background to transparent
                g.Clear(Color.Transparent);

                // Define the size of each square and spacing
                int squareSize = 16;
                int spacing = 2;
                int totalSquares = 16;
                // int squaresPerRow = 16; // In this case, all squares will fit in a single row

                // Generate 16 squares with colors in order
                for (int i = 0; i < totalSquares; i++)
                {
                    // Calculate the position for the square
                    int x = i * (squareSize + spacing);
                    int y = 0; // All squares will be in the same row, so y is constant

                    // Draw the square at the calculated position
                    using (Brush brush = new SolidBrush(colors[i]))
                    {
                        g.FillRectangle(brush, x, y, squareSize, squareSize);
                    }
                }
            }

            return bitmap;
        }
        #endregion

        #region Dynamically Get 16-Bit Colors

        // Generate the palette colors automatically.
        private async void GeneratePalette_Button_Click(object sender, EventArgs e)
        {
            // Disable controls.
            Main_Picturebox.Enabled = false;
            UseDefualt_CheckBox.Enabled = false;
            ColorPalette_Groupbox.Enabled = false;
            Offsets_Groupbox.Enabled = false;
            MassConversion_Groupbox.Enabled = false;

            // Initialize ProgressBar
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = 100; // Set this to the number of steps you expect in your process
            ProgressBar.Value = 0;
            ProgressBar.Step = 1;      // Define how much the bar should move each time

            // Load the image from ImageBox (assuming ImageBox is a PictureBox control)
            Bitmap image = new Bitmap(Main_Picturebox.Image);

            // Define offsets.
            int maxWidth = (int)MaxWidth_NumericUpDown.Value;
            int maxHeight = (int)MaxHeight_NumericUpDown.Value;

            // Resize the image to using nearest neighbor interpolation.
            image = ResizeImage(image, maxWidth, maxHeight);

            // Step 1: Get the list of pixels
            List<Color> pixels = new List<Color>();
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    pixels.Add(image.GetPixel(x, y));
                }
            }

            // Step 2: Apply K-means clustering to get 16 distinct colors
            var distinctColors = await Task.Run(() => GetKMeansColors(pixels, 16));

            // Step 3: Ensure there are at least 16 colors
            // If there are fewer than 16 colors, fill the remaining ones with a default color (e.g., White)
            while (distinctColors.Count < 16)
            {
                distinctColors.Add(Color.White); // You can change this to any default color
            }

            // Assign each extracted color to the BackColor of a TextBox
            ColorBox1.BackColor = distinctColors[0];
            ColorBox2.BackColor = distinctColors[1];
            ColorBox3.BackColor = distinctColors[2];
            ColorBox4.BackColor = distinctColors[3];
            ColorBox5.BackColor = distinctColors[4];
            ColorBox6.BackColor = distinctColors[5];
            ColorBox7.BackColor = distinctColors[6];
            ColorBox8.BackColor = distinctColors[7];
            ColorBox9.BackColor = distinctColors[8];
            ColorBox10.BackColor = distinctColors[9];
            ColorBox11.BackColor = distinctColors[10];
            ColorBox12.BackColor = distinctColors[11];
            ColorBox13.BackColor = distinctColors[12];
            ColorBox14.BackColor = distinctColors[13];
            ColorBox15.BackColor = distinctColors[14];
            ColorBox16.BackColor = distinctColors[15];

            // Reset progressbar.
            ProgressBar.Value = 0;

            // Enable controls.
            Main_Picturebox.Enabled = true;
            UseDefualt_CheckBox.Enabled = true;
            ColorPalette_Groupbox.Enabled = true;
            Offsets_Groupbox.Enabled = true;
            MassConversion_Groupbox.Enabled = true;
        }
        #endregion

        #region Get Color Code

        private static double ColorDiff(Color c1, Color c2)
        {
            int rDiff = c1.R - c2.R;
            int gDiff = c1.G - c2.G;
            int bDiff = c1.B - c2.B;
            return rDiff * rDiff + gDiff * gDiff + bDiff * bDiff;  // Avoid using Math.Pow for speed
        }
        public int GetData(Color inputColor)
        {
            List<Color> colors = new List<Color>
            {
                ColorBox1.BackColor,
                ColorBox2.BackColor,
                ColorBox3.BackColor,
                ColorBox4.BackColor,
                ColorBox5.BackColor,
                ColorBox6.BackColor,
                ColorBox7.BackColor,
                ColorBox8.BackColor,
                ColorBox9.BackColor,
                ColorBox10.BackColor,
                ColorBox11.BackColor,
                ColorBox12.BackColor,
                ColorBox13.BackColor,
                ColorBox14.BackColor,
                ColorBox15.BackColor,
                ColorBox16.BackColor
            };

            int closestId = -1;
            double minDistance = double.MaxValue;

            for (int i = 0; i < colors.Count; i++)
            {
                double distance = ColorDiff(inputColor, colors[i]);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestId = i;
                }
            }

            return closestId;
        }
        #endregion

        #region Main Conversion

        // Convert Images To Binary
        public void ConvertToBinary(string[] files, CancellationToken token)
        {
            try
            {
                // Delete Old Binary File if Exists.
                if (File.Exists(SaveLocation_Textbox.Text))
                {
                    File.Delete(SaveLocation_Textbox.Text);
                }

                // Define offsets.
                int maxWidth = (int)MaxWidth_NumericUpDown.Value;
                int maxHeight = (int)MaxHeight_NumericUpDown.Value;
                int maxFrames = (int)MaxFrame_NumericUpDown.Value;

                int offsetX = (int)OffsetX_NumericUpDown.Value;
                int offsetY = (int)OffsetY_NumericUpDown.Value;

                int stepX = (int)StepX_NumericUpDown.Value;
                int stepY = (int)StepY_NumericUpDown.Value;

                int loopAmount = (files.Length <= maxFrames) ? files.Length : maxFrames;

                // Initialize ProgressBar.
                ProgressBar.Invoke(new Action(() =>
                {
                    ProgressBar.Minimum = 0;
                    ProgressBar.Maximum = loopAmount;
                    ProgressBar.Value = 0;
                }));

                // Loop through all images.
                for (int frame = 0; frame < loopAmount; frame++)
                {
                    // Define the image from the list.
                    Bitmap img = new Bitmap(files[frame]);

                    // Resize the image to using nearest neighbor interpolation.
                    img = ResizeImage(img, maxWidth, maxHeight);

                    int x = 0, y = 0;

                    // Open the binary file for appending data.
                    using (FileStream fs = new FileStream(SaveLocation_Textbox.Text, FileMode.Append, FileAccess.Write))
                    using (BinaryWriter writer = new BinaryWriter(fs))
                    {
                        int getWidth = (img.Width <= maxWidth) ? img.Width : maxWidth;
                        int getHeight = (img.Height <= maxHeight) ? img.Height : maxHeight;

                        int imageX_Start = ImageFlipMode_CheckBox.Checked ? getWidth - 1 : 0; // Read the image direction based on checkbox.
                        int imageX_End = ImageFlipMode_CheckBox.Checked   ? -1 : getWidth;
                        int imageX_Step = ImageFlipMode_CheckBox.Checked  ? -1 : 1;

                        for (int imageX = imageX_Start; imageX != imageX_End; imageX += imageX_Step)
                        {
                            int line = frame / 4;
                            int color = frame % 4;
                            int carry = 0;

                            for (int imageY = 0; imageY < getHeight; imageY++)
                            {
                                // Check for cancellation request.
                                if (token.IsCancellationRequested)
                                    token.ThrowIfCancellationRequested();

                                // Get color and placement data.
                                int data = 0, dataGray = 0;

                                // Define a color map to adjust for incorrect control wiring.
                                int[] color_map = new int[] { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 };

                                Color pixelColor = img.GetPixel(imageX, imageY);
                                data = color_map[GetData(pixelColor)];

                                dataGray = (data ^ (data << 1) ^ carry) & 15;
                                carry = (data >> 3) & 1;

                                // Write the data as bytes (one byte per pixel data).
                                for (int bit = 0; bit < 4; bit++)
                                {
                                    int ROM_Split = 0, row = 0;
                                    if (ImageFlipMode_CheckBox.Checked)
                                    {   // Right to left.
                                        ROM_Split = 3 - (imageX / (getWidth / 4));            // Reverse ROM_Split order (0 → 3)
                                        row = (getWidth / 4 - 1) - (imageX % (getWidth / 4)); // Reverse row count within each segment.
                                    }
                                    else
                                    {   // Left to right.
                                        ROM_Split = imageX / (getWidth / 4);                  // Divide the image into 4 parts.
                                        row = imageX % (getWidth / 4);                        // Ensure x always counts 0 to 1/4 of the width.
                                    }

                                    // Offset   | Column + Step       | ROM Line Placement | Move x for each of the four bits.
                                    x = offsetX + (row * stepX)       + (imageY * 4)       + bit;
                                    y = offsetY + (ROM_Split * stepY) + (line * 3);

                                    byte byteValue = (byte)(((dataGray & (1 << bit)) == 0 ? 1 : 0) & 0xFF);

                                    writer.Write((short)x);    // Writing X position as short.
                                    writer.Write((short)y);    // Writing Y position as short.
                                    writer.Write((byte)color); // Writing color as byte.
                                    writer.Write(byteValue);   // Writing pixel data as byte.
                                }
                            }
                        }
                    }

                    // Dispose of the image.
                    img.Dispose();

                    // Update ProgressBar.
                    ProgressBar.Invoke(new Action(() => ProgressBar.Value = frame + 1));
                }
            }
            catch (OperationCanceledException)
            {
                // Task canceled, return.
                return;
            }
            catch (Exception Ex)
            {
                // Catch all other errors.
                MessageBox.Show($"Error: {Ex}", "Mass Convert Function:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion

        #endregion

        #region Control Helpers

        #region Resize Image

        private Bitmap ResizeImage(Bitmap img, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.DrawImage(img, 0, 0, width, height);
            }
            return resizedImage;
        }
        #endregion

        #region Use Defualt Colors

        // Create a list to store the original colors of the ColorBoxes
        private readonly List<Color> originalColors = new List<Color>();

        // Set or unset the defualt colors.
        private void UseDefualt_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UseDefualt_CheckBox.Checked)
            {
                // Disable controls.
                GeneratePalette_Button.Enabled = false;

                // Save the current colors to restore later
                originalColors.Clear(); // Clear the list to avoid old values
                originalColors.Add(ColorBox1.BackColor);
                originalColors.Add(ColorBox2.BackColor);
                originalColors.Add(ColorBox3.BackColor);
                originalColors.Add(ColorBox4.BackColor);
                originalColors.Add(ColorBox5.BackColor);
                originalColors.Add(ColorBox6.BackColor);
                originalColors.Add(ColorBox7.BackColor);
                originalColors.Add(ColorBox8.BackColor);
                originalColors.Add(ColorBox9.BackColor);
                originalColors.Add(ColorBox10.BackColor);
                originalColors.Add(ColorBox11.BackColor);
                originalColors.Add(ColorBox12.BackColor);
                originalColors.Add(ColorBox13.BackColor);
                originalColors.Add(ColorBox14.BackColor);
                originalColors.Add(ColorBox15.BackColor);
                originalColors.Add(ColorBox16.BackColor);

                // Change to default values
                ColorBox1.BackColor = ColorTranslator.FromHtml("#000000");
                ColorBox2.BackColor = ColorTranslator.FromHtml("#D0281D");
                ColorBox3.BackColor = ColorTranslator.FromHtml("#34C457");
                ColorBox4.BackColor = ColorTranslator.FromHtml("#CD764E");
                ColorBox5.BackColor = ColorTranslator.FromHtml("#3657D5");
                ColorBox6.BackColor = ColorTranslator.FromHtml("#AB2AC3");
                ColorBox7.BackColor = ColorTranslator.FromHtml("#31C49A");
                ColorBox8.BackColor = ColorTranslator.FromHtml("#B8C1D3");
                ColorBox9.BackColor = ColorTranslator.FromHtml("#CAA926");
                ColorBox10.BackColor = ColorTranslator.FromHtml("#CF2A7B");
                ColorBox11.BackColor = ColorTranslator.FromHtml("#8EC551");
                ColorBox12.BackColor = ColorTranslator.FromHtml("#EC912B");
                ColorBox13.BackColor = ColorTranslator.FromHtml("#2595D5");
                ColorBox14.BackColor = ColorTranslator.FromHtml("#CF35E2");
                ColorBox15.BackColor = ColorTranslator.FromHtml("#00D6E8");
                ColorBox16.BackColor = ColorTranslator.FromHtml("#E6E7EB");
            }
            else
            {
                // Enable controls.
                GeneratePalette_Button.Enabled = true;

                // Restore the previous values
                ColorBox1.BackColor = originalColors[0];
                ColorBox2.BackColor = originalColors[1];
                ColorBox3.BackColor = originalColors[2];
                ColorBox4.BackColor = originalColors[3];
                ColorBox5.BackColor = originalColors[4];
                ColorBox6.BackColor = originalColors[5];
                ColorBox7.BackColor = originalColors[6];
                ColorBox8.BackColor = originalColors[7];
                ColorBox9.BackColor = originalColors[8];
                ColorBox10.BackColor = originalColors[9];
                ColorBox11.BackColor = originalColors[10];
                ColorBox12.BackColor = originalColors[11];
                ColorBox13.BackColor = originalColors[12];
                ColorBox14.BackColor = originalColors[13];
                ColorBox15.BackColor = originalColors[14];
                ColorBox16.BackColor = originalColors[15];
            }
        }
        #endregion

        #region Color Textboxes

        private TextBox selectedTextBox; // Store the last clicked TextBox
        private void ColorBox_Enter(object sender, EventArgs e)
        {
            selectedTextBox = sender as TextBox;

            // Ensure we do not use this function if defualt palette is enabled.
            if (UseDefualt_CheckBox.Checked)
            {
                // Unselect the TextBox
                selectedTextBox.Parent.Focus();  // Option 1: Give focus to the parent container
                                                 // pictureBox.Focus(); // Option 2: Focus on PictureBox (if TabStop is enabled)

                selectedTextBox = null; // Clear selection
                return;
            }
            
            selectedTextBox.Text = "Scaning...";
        }

        private void Main_Picturebox_MouseClick(object sender, MouseEventArgs e)
        {
            // Ensure we do not use this function if defualt palette is enabled.
            if (UseDefualt_CheckBox.Checked)
                return;

            if (selectedTextBox != null && Main_Picturebox.Image is Bitmap bmp)
            {
                // Convert mouse position to image coordinates
                float scaleX = (float)bmp.Width / Main_Picturebox.Width;
                float scaleY = (float)bmp.Height / Main_Picturebox.Height;

                int imgX = (int)(e.X * scaleX);
                int imgY = (int)(e.Y * scaleY);

                if (imgX >= 0 && imgY >= 0 && imgX < bmp.Width && imgY < bmp.Height)
                {
                    Color pixelColor;
                    int A = bmp.GetPixel(imgX, imgY).A;
                    int R = bmp.GetPixel(imgX, imgY).R;
                    int G = bmp.GetPixel(imgX, imgY).G;
                    int B = bmp.GetPixel(imgX, imgY).B;

                    // If the color is transparent, use white or any solid color as fallback
                    if (A < 255) pixelColor = Color.White;
                    else pixelColor = Color.FromArgb(A, R, G, B);

                    selectedTextBox.BackColor = pixelColor;

                    // Adjust text color for readability
                    selectedTextBox.ForeColor = pixelColor.GetBrightness() < 0.5 ? Color.White : Color.Black;

                    // Show hex code in the textbox (optional)
                    // selectedTextBox.Text = $"#{pixelColor.R:X2}{pixelColor.G:X2}{pixelColor.B:X2}";
                    selectedTextBox.Text = "";
                }

                // Unselect the TextBox
                selectedTextBox.Parent.Focus();  // Option 1: Give focus to the parent container
                                                 // pictureBox.Focus(); // Option 2: Focus on PictureBox (if TabStop is enabled)

                selectedTextBox = null; // Clear selection
            }
        }

        private void Main_Picturebox_MouseMove(object sender, MouseEventArgs e)
        {
            // Ensure we do not use this function if defualt palette is enabled.
            if (UseDefualt_CheckBox.Checked)
                return;

            if (selectedTextBox != null && Main_Picturebox.Image is Bitmap bmp)
            {
                // Convert mouse position to image coordinates
                float scaleX = (float)bmp.Width / Main_Picturebox.Width;
                float scaleY = (float)bmp.Height / Main_Picturebox.Height;

                int imgX = (int)(e.X * scaleX);
                int imgY = (int)(e.Y * scaleY);

                if (imgX >= 0 && imgY >= 0 && imgX < bmp.Width && imgY < bmp.Height)
                {
                    Color pixelColor;
                    int A = bmp.GetPixel(imgX, imgY).A;
                    int R = bmp.GetPixel(imgX, imgY).R;
                    int G = bmp.GetPixel(imgX, imgY).G;
                    int B = bmp.GetPixel(imgX, imgY).B;

                    // If the color is transparent, use white or any solid color as fallback
                    if (A < 255) pixelColor = Color.White;
                    else pixelColor = Color.FromArgb(A, R, G, B);

                    // Preview color in TextBox background
                    selectedTextBox.BackColor = pixelColor;

                    // Optional: Update text color for readability
                    selectedTextBox.ForeColor = pixelColor.GetBrightness() < 0.5 ? Color.White : Color.Black;

                    // Show hex code in the textbox (optional)
                    selectedTextBox.Text = $"#{pixelColor.R:X2}{pixelColor.G:X2}{pixelColor.B:X2}";
                }
            }
        }
        #endregion

        #region Nearest Neighbor PictureBox

        private void Main_Picturebox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy; // Show copy cursor
            }
        }

        private void Main_Picturebox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                try
                {
                    Image img = Image.FromFile(files[0]);
                    Main_Picturebox.Image = img; // Set the dropped image
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid image file: " + ex.Message);
                }
            }
        }

        private void Main_Picturebox_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadImage(openFileDialog.FileName);
                }
            }
        }

        // Load image into PictureBox.
        private void LoadImage(string filePath)
        {
            try
            {
                Image img = Image.FromFile(filePath);
                Main_Picturebox.Image = img;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }
        #endregion

        #endregion

        #region Palette Algorithm

        // K-means clustering to get `k` distinct colors from the list of pixels
        public List<Color> GetKMeansColors(List<Color> pixels, int k)
        {
            // Step 1: Use the first `k` distinct colors from the image as the initial centroids
            List<Color> centroids = pixels.Distinct().Take(k).ToList();

            bool centroidsChanged = true;
            List<int> assignments = new List<int>(new int[pixels.Count]);

            int iteration = 0;

            // Step 2: Run the k-means algorithm until convergence
            while (centroidsChanged)
            {
                centroidsChanged = false;
                iteration++;

                // Step 2a: Assign each pixel to the closest centroid
                for (int i = 0; i < pixels.Count; i++)
                {
                    int closestCentroid = GetClosestCentroid(pixels[i], centroids);
                    if (assignments[i] != closestCentroid)
                    {
                        assignments[i] = closestCentroid;
                        centroidsChanged = true;
                    }
                }

                // Step 2b: Recompute the centroids of each cluster
                var newCentroids = new List<Color>();
                for (int i = 0; i < k; i++)
                {
                    var cluster = pixels.Where((p, index) => assignments[index] == i).ToList();
                    if (cluster.Any())
                    {
                        newCentroids.Add(AverageColor(cluster));
                    }
                }
                centroids = newCentroids;

                // Update progress bar after each iteration (or after every few iterations)
                int progress = (int)((float)iteration / 10 * 100); // 10 is a rough guess.
                ProgressBar.Invoke(new Action(() => ProgressBar.Value = Math.Min(progress, ProgressBar.Maximum)));
            }

            ProgressBar.Invoke(new Action(() => ProgressBar.Value = 100));
            return centroids;
        }

        // Step 3: Get the closest centroid to a pixel
        private int GetClosestCentroid(Color pixel, List<Color> centroids)
        {
            int closestIndex = 0;
            double minDistance = double.MaxValue;
            for (int i = 0; i < centroids.Count; i++)
            {
                double distance = GetColorDistance(pixel, centroids[i]);
                if (distance < minDistance)
                {
                    closestIndex = i;
                    minDistance = distance;
                }
            }
            return closestIndex;
        }

        // Step 4: Compute the Euclidean distance between two colors
        private double GetColorDistance(Color color1, Color color2)
        {
            int rDiff = color1.R - color2.R;
            int gDiff = color1.G - color2.G;
            int bDiff = color1.B - color2.B;
            return Math.Sqrt(rDiff * rDiff + gDiff * gDiff + bDiff * bDiff);
        }

        // Step 5: Compute the average color of a list of colors
        private Color AverageColor(List<Color> colors)
        {
            int r = (int)colors.Average(c => c.R);
            int g = (int)colors.Average(c => c.G);
            int b = (int)colors.Average(c => c.B);
            return Color.FromArgb(r, g, b);
        }
        #endregion
    }

    #region Define Custom NearestNeighbor PictureBox

    public class NearestNeighborPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            if (Image != null)
            {
                pe.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor; // Force Nearest Neighbor
                pe.Graphics.PixelOffsetMode = PixelOffsetMode.Half; // Prevent pixel blurring
                pe.Graphics.DrawImage(Image, new Rectangle(0, 0, Width, Height)); // Stretch image
            }
            else
            {
                base.OnPaint(pe);
            }
        }
    }
    #endregion

    #region Define Custom Transparent CheckBox

    public class TransparentCheckBox : CheckBox
    {
        public TransparentCheckBox()
        {
            // Enable transparency support
            this.SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            this.BackColor = Color.Transparent;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20; // WS_EX_TRANSPARENT (makes control see-through)
                return cp;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Prevent background flickering
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }
    #endregion
}