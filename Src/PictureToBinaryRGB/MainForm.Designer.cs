namespace PictureToBinaryRGB
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MassConversion_Groupbox = new System.Windows.Forms.GroupBox();
            this.ImageFlipMode_CheckBox = new System.Windows.Forms.CheckBox();
            this.AddPhotos_Textbox = new System.Windows.Forms.TextBox();
            this.SaveLocation_Textbox = new System.Windows.Forms.TextBox();
            this.ConvertImages_Button = new System.Windows.Forms.Button();
            this.SaveLocation_Button = new System.Windows.Forms.Button();
            this.AddPhotos_Button = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ColorPalette_Groupbox = new System.Windows.Forms.GroupBox();
            this.ColorBox16 = new System.Windows.Forms.TextBox();
            this.ColorBox15 = new System.Windows.Forms.TextBox();
            this.ColorBox14 = new System.Windows.Forms.TextBox();
            this.ColorBox13 = new System.Windows.Forms.TextBox();
            this.ColorBox12 = new System.Windows.Forms.TextBox();
            this.ColorBox11 = new System.Windows.Forms.TextBox();
            this.ColorBox10 = new System.Windows.Forms.TextBox();
            this.ColorBox9 = new System.Windows.Forms.TextBox();
            this.ColorBox8 = new System.Windows.Forms.TextBox();
            this.ColorBox7 = new System.Windows.Forms.TextBox();
            this.ColorBox6 = new System.Windows.Forms.TextBox();
            this.ColorBox5 = new System.Windows.Forms.TextBox();
            this.ColorBox4 = new System.Windows.Forms.TextBox();
            this.ColorBox3 = new System.Windows.Forms.TextBox();
            this.ColorBox2 = new System.Windows.Forms.TextBox();
            this.ColorBox1 = new System.Windows.Forms.TextBox();
            this.Main_Picturebox = new PictureToBinaryRGB.NearestNeighborPictureBox();
            this.Offsets_Groupbox = new System.Windows.Forms.GroupBox();
            this.GenerateTexture_Button = new System.Windows.Forms.Button();
            this.InGameCode_Button = new System.Windows.Forms.Button();
            this.GeneratePalette_Button = new System.Windows.Forms.Button();
            this.MaxFrame_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaxHeight_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaxWidth_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaxFrame_Label = new System.Windows.Forms.Label();
            this.MaxHeight_Label = new System.Windows.Forms.Label();
            this.MaxWidth_Label = new System.Windows.Forms.Label();
            this.GeneratePalette_CheckBox = new System.Windows.Forms.CheckBox();
            this.StepY_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StepX_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OffsetY_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OffsetX_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StepY_Label = new System.Windows.Forms.Label();
            this.StepX_Label = new System.Windows.Forms.Label();
            this.OffsetY_Label = new System.Windows.Forms.Label();
            this.OffsetX_Label = new System.Windows.Forms.Label();
            this.UseDefualt_CheckBox = new PictureToBinaryRGB.TransparentCheckBox();
            this.MassConversion_Groupbox.SuspendLayout();
            this.ColorPalette_Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Picturebox)).BeginInit();
            this.Offsets_Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFrame_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxHeight_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWidth_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepY_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepX_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetY_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetX_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // MassConversion_Groupbox
            // 
            this.MassConversion_Groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MassConversion_Groupbox.Controls.Add(this.ImageFlipMode_CheckBox);
            this.MassConversion_Groupbox.Controls.Add(this.AddPhotos_Textbox);
            this.MassConversion_Groupbox.Controls.Add(this.SaveLocation_Textbox);
            this.MassConversion_Groupbox.Controls.Add(this.ConvertImages_Button);
            this.MassConversion_Groupbox.Controls.Add(this.SaveLocation_Button);
            this.MassConversion_Groupbox.Controls.Add(this.AddPhotos_Button);
            this.MassConversion_Groupbox.Controls.Add(this.ProgressBar);
            this.MassConversion_Groupbox.Location = new System.Drawing.Point(288, 458);
            this.MassConversion_Groupbox.Name = "MassConversion_Groupbox";
            this.MassConversion_Groupbox.Size = new System.Drawing.Size(249, 149);
            this.MassConversion_Groupbox.TabIndex = 6;
            this.MassConversion_Groupbox.TabStop = false;
            this.MassConversion_Groupbox.Text = "Mass Conversion";
            // 
            // ImageFlipMode_CheckBox
            // 
            this.ImageFlipMode_CheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ImageFlipMode_CheckBox.AutoSize = true;
            this.ImageFlipMode_CheckBox.Checked = true;
            this.ImageFlipMode_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ImageFlipMode_CheckBox.Location = new System.Drawing.Point(186, -1);
            this.ImageFlipMode_CheckBox.Name = "ImageFlipMode_CheckBox";
            this.ImageFlipMode_CheckBox.Size = new System.Drawing.Size(57, 17);
            this.ImageFlipMode_CheckBox.TabIndex = 18;
            this.ImageFlipMode_CheckBox.Text = "R → L";
            this.ImageFlipMode_CheckBox.UseVisualStyleBackColor = true;
            // 
            // AddPhotos_Textbox
            // 
            this.AddPhotos_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPhotos_Textbox.Location = new System.Drawing.Point(6, 19);
            this.AddPhotos_Textbox.Name = "AddPhotos_Textbox";
            this.AddPhotos_Textbox.ReadOnly = true;
            this.AddPhotos_Textbox.Size = new System.Drawing.Size(144, 20);
            this.AddPhotos_Textbox.TabIndex = 14;
            // 
            // SaveLocation_Textbox
            // 
            this.SaveLocation_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveLocation_Textbox.Location = new System.Drawing.Point(6, 45);
            this.SaveLocation_Textbox.Name = "SaveLocation_Textbox";
            this.SaveLocation_Textbox.ReadOnly = true;
            this.SaveLocation_Textbox.Size = new System.Drawing.Size(144, 20);
            this.SaveLocation_Textbox.TabIndex = 17;
            // 
            // ConvertImages_Button
            // 
            this.ConvertImages_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertImages_Button.Location = new System.Drawing.Point(6, 71);
            this.ConvertImages_Button.Name = "ConvertImages_Button";
            this.ConvertImages_Button.Size = new System.Drawing.Size(237, 36);
            this.ConvertImages_Button.TabIndex = 12;
            this.ConvertImages_Button.Text = "Convert Images";
            this.ConvertImages_Button.UseVisualStyleBackColor = true;
            this.ConvertImages_Button.Click += new System.EventHandler(this.ConvertImages_Button_Click);
            // 
            // SaveLocation_Button
            // 
            this.SaveLocation_Button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveLocation_Button.Location = new System.Drawing.Point(156, 43);
            this.SaveLocation_Button.Name = "SaveLocation_Button";
            this.SaveLocation_Button.Size = new System.Drawing.Size(87, 23);
            this.SaveLocation_Button.TabIndex = 16;
            this.SaveLocation_Button.Text = "Save Location";
            this.SaveLocation_Button.UseVisualStyleBackColor = true;
            this.SaveLocation_Button.Click += new System.EventHandler(this.SaveLocation_Button_Click);
            // 
            // AddPhotos_Button
            // 
            this.AddPhotos_Button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AddPhotos_Button.Location = new System.Drawing.Point(156, 17);
            this.AddPhotos_Button.Name = "AddPhotos_Button";
            this.AddPhotos_Button.Size = new System.Drawing.Size(87, 23);
            this.AddPhotos_Button.TabIndex = 13;
            this.AddPhotos_Button.Text = "Add Photos";
            this.AddPhotos_Button.UseVisualStyleBackColor = true;
            this.AddPhotos_Button.Click += new System.EventHandler(this.AddPhotos_Button_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(6, 113);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(237, 23);
            this.ProgressBar.TabIndex = 15;
            // 
            // ColorPalette_Groupbox
            // 
            this.ColorPalette_Groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ColorPalette_Groupbox.Controls.Add(this.ColorBox16);
            this.ColorPalette_Groupbox.Controls.Add(this.ColorBox15);
            this.ColorPalette_Groupbox.Controls.Add(this.ColorBox14);
            this.ColorPalette_Groupbox.Controls.Add(this.ColorBox13);
            this.ColorPalette_Groupbox.Controls.Add(this.ColorBox12);
            this.ColorPalette_Groupbox.Controls.Add(this.ColorBox11);
            this.ColorPalette_Groupbox.Controls.Add(this.ColorBox10);
            this.ColorPalette_Groupbox.Controls.Add(this.ColorBox9);
            this.ColorPalette_Groupbox.Controls.Add(this.ColorBox8);
            this.ColorPalette_Groupbox.Controls.Add(this.ColorBox7);
            this.ColorPalette_Groupbox.Controls.Add(this.ColorBox6);
            this.ColorPalette_Groupbox.Controls.Add(this.ColorBox5);
            this.ColorPalette_Groupbox.Controls.Add(this.ColorBox4);
            this.ColorPalette_Groupbox.Controls.Add(this.ColorBox3);
            this.ColorPalette_Groupbox.Controls.Add(this.ColorBox2);
            this.ColorPalette_Groupbox.Controls.Add(this.ColorBox1);
            this.ColorPalette_Groupbox.Location = new System.Drawing.Point(12, 12);
            this.ColorPalette_Groupbox.Name = "ColorPalette_Groupbox";
            this.ColorPalette_Groupbox.Size = new System.Drawing.Size(79, 440);
            this.ColorPalette_Groupbox.TabIndex = 8;
            this.ColorPalette_Groupbox.TabStop = false;
            this.ColorPalette_Groupbox.Text = "ColorPalette";
            // 
            // ColorBox16
            // 
            this.ColorBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox16.BackColor = System.Drawing.Color.Orange;
            this.ColorBox16.Location = new System.Drawing.Point(6, 409);
            this.ColorBox16.Name = "ColorBox16";
            this.ColorBox16.ReadOnly = true;
            this.ColorBox16.Size = new System.Drawing.Size(67, 20);
            this.ColorBox16.TabIndex = 10;
            this.ColorBox16.Enter += new System.EventHandler(this.ColorBox_Enter);
            // 
            // ColorBox15
            // 
            this.ColorBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox15.BackColor = System.Drawing.Color.White;
            this.ColorBox15.Location = new System.Drawing.Point(6, 383);
            this.ColorBox15.Name = "ColorBox15";
            this.ColorBox15.ReadOnly = true;
            this.ColorBox15.Size = new System.Drawing.Size(67, 20);
            this.ColorBox15.TabIndex = 14;
            this.ColorBox15.Enter += new System.EventHandler(this.ColorBox_Enter);
            // 
            // ColorBox14
            // 
            this.ColorBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox14.BackColor = System.Drawing.Color.Black;
            this.ColorBox14.Location = new System.Drawing.Point(6, 357);
            this.ColorBox14.Name = "ColorBox14";
            this.ColorBox14.ReadOnly = true;
            this.ColorBox14.Size = new System.Drawing.Size(67, 20);
            this.ColorBox14.TabIndex = 13;
            this.ColorBox14.Enter += new System.EventHandler(this.ColorBox_Enter);
            // 
            // ColorBox13
            // 
            this.ColorBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox13.BackColor = System.Drawing.Color.Gray;
            this.ColorBox13.Location = new System.Drawing.Point(6, 331);
            this.ColorBox13.Name = "ColorBox13";
            this.ColorBox13.ReadOnly = true;
            this.ColorBox13.Size = new System.Drawing.Size(67, 20);
            this.ColorBox13.TabIndex = 12;
            this.ColorBox13.Enter += new System.EventHandler(this.ColorBox_Enter);
            // 
            // ColorBox12
            // 
            this.ColorBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox12.BackColor = System.Drawing.Color.Teal;
            this.ColorBox12.Location = new System.Drawing.Point(6, 305);
            this.ColorBox12.Name = "ColorBox12";
            this.ColorBox12.ReadOnly = true;
            this.ColorBox12.Size = new System.Drawing.Size(67, 20);
            this.ColorBox12.TabIndex = 11;
            this.ColorBox12.Enter += new System.EventHandler(this.ColorBox_Enter);
            // 
            // ColorBox11
            // 
            this.ColorBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox11.BackColor = System.Drawing.Color.Purple;
            this.ColorBox11.Location = new System.Drawing.Point(6, 279);
            this.ColorBox11.Name = "ColorBox11";
            this.ColorBox11.ReadOnly = true;
            this.ColorBox11.Size = new System.Drawing.Size(67, 20);
            this.ColorBox11.TabIndex = 10;
            this.ColorBox11.Enter += new System.EventHandler(this.ColorBox_Enter);
            // 
            // ColorBox10
            // 
            this.ColorBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox10.BackColor = System.Drawing.Color.DarkGreen;
            this.ColorBox10.Location = new System.Drawing.Point(6, 253);
            this.ColorBox10.Name = "ColorBox10";
            this.ColorBox10.ReadOnly = true;
            this.ColorBox10.Size = new System.Drawing.Size(67, 20);
            this.ColorBox10.TabIndex = 9;
            this.ColorBox10.Enter += new System.EventHandler(this.ColorBox_Enter);
            // 
            // ColorBox9
            // 
            this.ColorBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox9.BackColor = System.Drawing.Color.Olive;
            this.ColorBox9.Location = new System.Drawing.Point(6, 227);
            this.ColorBox9.Name = "ColorBox9";
            this.ColorBox9.ReadOnly = true;
            this.ColorBox9.Size = new System.Drawing.Size(67, 20);
            this.ColorBox9.TabIndex = 8;
            this.ColorBox9.Enter += new System.EventHandler(this.ColorBox_Enter);
            // 
            // ColorBox8
            // 
            this.ColorBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox8.BackColor = System.Drawing.Color.Maroon;
            this.ColorBox8.Location = new System.Drawing.Point(6, 201);
            this.ColorBox8.Name = "ColorBox8";
            this.ColorBox8.ReadOnly = true;
            this.ColorBox8.Size = new System.Drawing.Size(67, 20);
            this.ColorBox8.TabIndex = 7;
            this.ColorBox8.Enter += new System.EventHandler(this.ColorBox_Enter);
            // 
            // ColorBox7
            // 
            this.ColorBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox7.BackColor = System.Drawing.Color.Silver;
            this.ColorBox7.Location = new System.Drawing.Point(6, 175);
            this.ColorBox7.Name = "ColorBox7";
            this.ColorBox7.ReadOnly = true;
            this.ColorBox7.Size = new System.Drawing.Size(67, 20);
            this.ColorBox7.TabIndex = 6;
            this.ColorBox7.Enter += new System.EventHandler(this.ColorBox_Enter);
            // 
            // ColorBox6
            // 
            this.ColorBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox6.BackColor = System.Drawing.Color.Magenta;
            this.ColorBox6.Location = new System.Drawing.Point(6, 149);
            this.ColorBox6.Name = "ColorBox6";
            this.ColorBox6.ReadOnly = true;
            this.ColorBox6.Size = new System.Drawing.Size(67, 20);
            this.ColorBox6.TabIndex = 5;
            this.ColorBox6.Enter += new System.EventHandler(this.ColorBox_Enter);
            // 
            // ColorBox5
            // 
            this.ColorBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox5.BackColor = System.Drawing.Color.Cyan;
            this.ColorBox5.Location = new System.Drawing.Point(6, 123);
            this.ColorBox5.Name = "ColorBox5";
            this.ColorBox5.ReadOnly = true;
            this.ColorBox5.Size = new System.Drawing.Size(67, 20);
            this.ColorBox5.TabIndex = 4;
            this.ColorBox5.Enter += new System.EventHandler(this.ColorBox_Enter);
            // 
            // ColorBox4
            // 
            this.ColorBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox4.BackColor = System.Drawing.Color.Yellow;
            this.ColorBox4.Location = new System.Drawing.Point(6, 97);
            this.ColorBox4.Name = "ColorBox4";
            this.ColorBox4.ReadOnly = true;
            this.ColorBox4.Size = new System.Drawing.Size(67, 20);
            this.ColorBox4.TabIndex = 3;
            this.ColorBox4.Enter += new System.EventHandler(this.ColorBox_Enter);
            // 
            // ColorBox3
            // 
            this.ColorBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox3.BackColor = System.Drawing.Color.Blue;
            this.ColorBox3.Location = new System.Drawing.Point(6, 71);
            this.ColorBox3.Name = "ColorBox3";
            this.ColorBox3.ReadOnly = true;
            this.ColorBox3.Size = new System.Drawing.Size(67, 20);
            this.ColorBox3.TabIndex = 2;
            this.ColorBox3.Enter += new System.EventHandler(this.ColorBox_Enter);
            // 
            // ColorBox2
            // 
            this.ColorBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox2.BackColor = System.Drawing.Color.Green;
            this.ColorBox2.Location = new System.Drawing.Point(6, 45);
            this.ColorBox2.Name = "ColorBox2";
            this.ColorBox2.ReadOnly = true;
            this.ColorBox2.Size = new System.Drawing.Size(67, 20);
            this.ColorBox2.TabIndex = 1;
            this.ColorBox2.Enter += new System.EventHandler(this.ColorBox_Enter);
            // 
            // ColorBox1
            // 
            this.ColorBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorBox1.BackColor = System.Drawing.Color.Red;
            this.ColorBox1.Location = new System.Drawing.Point(6, 19);
            this.ColorBox1.Name = "ColorBox1";
            this.ColorBox1.ReadOnly = true;
            this.ColorBox1.Size = new System.Drawing.Size(67, 20);
            this.ColorBox1.TabIndex = 0;
            this.ColorBox1.Enter += new System.EventHandler(this.ColorBox_Enter);
            // 
            // Main_Picturebox
            // 
            this.Main_Picturebox.AllowDrop = global::PictureToBinaryRGB.Properties.Settings.Default.True;
            this.Main_Picturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_Picturebox.DataBindings.Add(new System.Windows.Forms.Binding("AllowDrop", global::PictureToBinaryRGB.Properties.Settings.Default, "True", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Main_Picturebox.Image = ((System.Drawing.Image)(resources.GetObject("Main_Picturebox.Image")));
            this.Main_Picturebox.Location = new System.Drawing.Point(97, 12);
            this.Main_Picturebox.Name = "Main_Picturebox";
            this.Main_Picturebox.Size = new System.Drawing.Size(440, 440);
            this.Main_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Main_Picturebox.TabIndex = 9;
            this.Main_Picturebox.TabStop = false;
            this.Main_Picturebox.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_Picturebox_DragDrop);
            this.Main_Picturebox.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_Picturebox_DragEnter);
            this.Main_Picturebox.DoubleClick += new System.EventHandler(this.Main_Picturebox_DoubleClick);
            this.Main_Picturebox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_Picturebox_MouseClick);
            this.Main_Picturebox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_Picturebox_MouseMove);
            // 
            // Offsets_Groupbox
            // 
            this.Offsets_Groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Offsets_Groupbox.Controls.Add(this.GenerateTexture_Button);
            this.Offsets_Groupbox.Controls.Add(this.InGameCode_Button);
            this.Offsets_Groupbox.Controls.Add(this.GeneratePalette_Button);
            this.Offsets_Groupbox.Controls.Add(this.MaxFrame_NumericUpDown);
            this.Offsets_Groupbox.Controls.Add(this.MaxHeight_NumericUpDown);
            this.Offsets_Groupbox.Controls.Add(this.MaxWidth_NumericUpDown);
            this.Offsets_Groupbox.Controls.Add(this.MaxFrame_Label);
            this.Offsets_Groupbox.Controls.Add(this.MaxHeight_Label);
            this.Offsets_Groupbox.Controls.Add(this.MaxWidth_Label);
            this.Offsets_Groupbox.Controls.Add(this.GeneratePalette_CheckBox);
            this.Offsets_Groupbox.Controls.Add(this.StepY_NumericUpDown);
            this.Offsets_Groupbox.Controls.Add(this.StepX_NumericUpDown);
            this.Offsets_Groupbox.Controls.Add(this.OffsetY_NumericUpDown);
            this.Offsets_Groupbox.Controls.Add(this.OffsetX_NumericUpDown);
            this.Offsets_Groupbox.Controls.Add(this.StepY_Label);
            this.Offsets_Groupbox.Controls.Add(this.StepX_Label);
            this.Offsets_Groupbox.Controls.Add(this.OffsetY_Label);
            this.Offsets_Groupbox.Controls.Add(this.OffsetX_Label);
            this.Offsets_Groupbox.Location = new System.Drawing.Point(12, 458);
            this.Offsets_Groupbox.Name = "Offsets_Groupbox";
            this.Offsets_Groupbox.Size = new System.Drawing.Size(270, 149);
            this.Offsets_Groupbox.TabIndex = 10;
            this.Offsets_Groupbox.TabStop = false;
            this.Offsets_Groupbox.Text = "Offsets";
            // 
            // GenerateTexture_Button
            // 
            this.GenerateTexture_Button.Location = new System.Drawing.Point(238, 119);
            this.GenerateTexture_Button.Name = "GenerateTexture_Button";
            this.GenerateTexture_Button.Size = new System.Drawing.Size(23, 23);
            this.GenerateTexture_Button.TabIndex = 19;
            this.GenerateTexture_Button.Text = "/";
            this.GenerateTexture_Button.UseVisualStyleBackColor = true;
            this.GenerateTexture_Button.Click += new System.EventHandler(this.GenerateTexture_Button_Click);
            // 
            // InGameCode_Button
            // 
            this.InGameCode_Button.Location = new System.Drawing.Point(238, 94);
            this.InGameCode_Button.Name = "InGameCode_Button";
            this.InGameCode_Button.Size = new System.Drawing.Size(23, 23);
            this.InGameCode_Button.TabIndex = 18;
            this.InGameCode_Button.Text = "?";
            this.InGameCode_Button.UseVisualStyleBackColor = true;
            this.InGameCode_Button.Click += new System.EventHandler(this.InGameCode_Button_Click);
            // 
            // GeneratePalette_Button
            // 
            this.GeneratePalette_Button.Location = new System.Drawing.Point(133, 94);
            this.GeneratePalette_Button.Name = "GeneratePalette_Button";
            this.GeneratePalette_Button.Size = new System.Drawing.Size(99, 23);
            this.GeneratePalette_Button.TabIndex = 15;
            this.GeneratePalette_Button.Text = "Generate Palette";
            this.GeneratePalette_Button.UseVisualStyleBackColor = true;
            this.GeneratePalette_Button.Click += new System.EventHandler(this.GeneratePalette_Button_Click);
            // 
            // MaxFrame_NumericUpDown
            // 
            this.MaxFrame_NumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaxFrame_NumericUpDown.Location = new System.Drawing.Point(194, 71);
            this.MaxFrame_NumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MaxFrame_NumericUpDown.Name = "MaxFrame_NumericUpDown";
            this.MaxFrame_NumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.MaxFrame_NumericUpDown.TabIndex = 14;
            this.MaxFrame_NumericUpDown.Value = new decimal(new int[] {
            768,
            0,
            0,
            0});
            // 
            // MaxHeight_NumericUpDown
            // 
            this.MaxHeight_NumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaxHeight_NumericUpDown.Location = new System.Drawing.Point(194, 45);
            this.MaxHeight_NumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaxHeight_NumericUpDown.Name = "MaxHeight_NumericUpDown";
            this.MaxHeight_NumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.MaxHeight_NumericUpDown.TabIndex = 13;
            this.MaxHeight_NumericUpDown.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            // 
            // MaxWidth_NumericUpDown
            // 
            this.MaxWidth_NumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MaxWidth_NumericUpDown.Location = new System.Drawing.Point(194, 19);
            this.MaxWidth_NumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaxWidth_NumericUpDown.Name = "MaxWidth_NumericUpDown";
            this.MaxWidth_NumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.MaxWidth_NumericUpDown.TabIndex = 12;
            this.MaxWidth_NumericUpDown.Value = new decimal(new int[] {
            116,
            0,
            0,
            0});
            // 
            // MaxFrame_Label
            // 
            this.MaxFrame_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MaxFrame_Label.AutoSize = true;
            this.MaxFrame_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.MaxFrame_Label.Location = new System.Drawing.Point(130, 73);
            this.MaxFrame_Label.Name = "MaxFrame_Label";
            this.MaxFrame_Label.Size = new System.Drawing.Size(59, 13);
            this.MaxFrame_Label.TabIndex = 11;
            this.MaxFrame_Label.Text = "MaxFrame:";
            // 
            // MaxHeight_Label
            // 
            this.MaxHeight_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MaxHeight_Label.AutoSize = true;
            this.MaxHeight_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.MaxHeight_Label.Location = new System.Drawing.Point(130, 48);
            this.MaxHeight_Label.Name = "MaxHeight_Label";
            this.MaxHeight_Label.Size = new System.Drawing.Size(61, 13);
            this.MaxHeight_Label.TabIndex = 10;
            this.MaxHeight_Label.Text = "MaxHeight:";
            // 
            // MaxWidth_Label
            // 
            this.MaxWidth_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MaxWidth_Label.AutoSize = true;
            this.MaxWidth_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.MaxWidth_Label.Location = new System.Drawing.Point(130, 22);
            this.MaxWidth_Label.Name = "MaxWidth_Label";
            this.MaxWidth_Label.Size = new System.Drawing.Size(58, 13);
            this.MaxWidth_Label.TabIndex = 9;
            this.MaxWidth_Label.Text = "MaxWidth:";
            // 
            // GeneratePalette_CheckBox
            // 
            this.GeneratePalette_CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GeneratePalette_CheckBox.AutoSize = true;
            this.GeneratePalette_CheckBox.Checked = true;
            this.GeneratePalette_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GeneratePalette_CheckBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.GeneratePalette_CheckBox.Location = new System.Drawing.Point(9, 123);
            this.GeneratePalette_CheckBox.Name = "GeneratePalette_CheckBox";
            this.GeneratePalette_CheckBox.Size = new System.Drawing.Size(234, 17);
            this.GeneratePalette_CheckBox.TabIndex = 8;
            this.GeneratePalette_CheckBox.Text = "Create Custom WireBulb Texture Via Palette";
            this.GeneratePalette_CheckBox.UseVisualStyleBackColor = true;
            // 
            // StepY_NumericUpDown
            // 
            this.StepY_NumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StepY_NumericUpDown.Location = new System.Drawing.Point(57, 97);
            this.StepY_NumericUpDown.Maximum = new decimal(new int[] {
            2400,
            0,
            0,
            0});
            this.StepY_NumericUpDown.Name = "StepY_NumericUpDown";
            this.StepY_NumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.StepY_NumericUpDown.TabIndex = 7;
            this.StepY_NumericUpDown.Value = new decimal(new int[] {
            598,
            0,
            0,
            0});
            // 
            // StepX_NumericUpDown
            // 
            this.StepX_NumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StepX_NumericUpDown.Location = new System.Drawing.Point(57, 71);
            this.StepX_NumericUpDown.Maximum = new decimal(new int[] {
            8400,
            0,
            0,
            0});
            this.StepX_NumericUpDown.Name = "StepX_NumericUpDown";
            this.StepX_NumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.StepX_NumericUpDown.TabIndex = 6;
            this.StepX_NumericUpDown.Value = new decimal(new int[] {
            260,
            0,
            0,
            0});
            // 
            // OffsetY_NumericUpDown
            // 
            this.OffsetY_NumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OffsetY_NumericUpDown.Location = new System.Drawing.Point(57, 45);
            this.OffsetY_NumericUpDown.Maximum = new decimal(new int[] {
            2400,
            0,
            0,
            0});
            this.OffsetY_NumericUpDown.Name = "OffsetY_NumericUpDown";
            this.OffsetY_NumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.OffsetY_NumericUpDown.TabIndex = 5;
            this.OffsetY_NumericUpDown.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // OffsetX_NumericUpDown
            // 
            this.OffsetX_NumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OffsetX_NumericUpDown.Location = new System.Drawing.Point(57, 19);
            this.OffsetX_NumericUpDown.Maximum = new decimal(new int[] {
            8400,
            0,
            0,
            0});
            this.OffsetX_NumericUpDown.Name = "OffsetX_NumericUpDown";
            this.OffsetX_NumericUpDown.Size = new System.Drawing.Size(67, 20);
            this.OffsetX_NumericUpDown.TabIndex = 4;
            this.OffsetX_NumericUpDown.Value = new decimal(new int[] {
            814,
            0,
            0,
            0});
            // 
            // StepY_Label
            // 
            this.StepY_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StepY_Label.AutoSize = true;
            this.StepY_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.StepY_Label.Location = new System.Drawing.Point(6, 99);
            this.StepY_Label.Name = "StepY_Label";
            this.StepY_Label.Size = new System.Drawing.Size(39, 13);
            this.StepY_Label.TabIndex = 3;
            this.StepY_Label.Text = "StepY:";
            // 
            // StepX_Label
            // 
            this.StepX_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StepX_Label.AutoSize = true;
            this.StepX_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.StepX_Label.Location = new System.Drawing.Point(6, 73);
            this.StepX_Label.Name = "StepX_Label";
            this.StepX_Label.Size = new System.Drawing.Size(39, 13);
            this.StepX_Label.TabIndex = 2;
            this.StepX_Label.Text = "StepX:";
            // 
            // OffsetY_Label
            // 
            this.OffsetY_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OffsetY_Label.AutoSize = true;
            this.OffsetY_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.OffsetY_Label.Location = new System.Drawing.Point(6, 48);
            this.OffsetY_Label.Name = "OffsetY_Label";
            this.OffsetY_Label.Size = new System.Drawing.Size(45, 13);
            this.OffsetY_Label.TabIndex = 1;
            this.OffsetY_Label.Text = "OffsetY:";
            // 
            // OffsetX_Label
            // 
            this.OffsetX_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OffsetX_Label.AutoSize = true;
            this.OffsetX_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.OffsetX_Label.Location = new System.Drawing.Point(6, 22);
            this.OffsetX_Label.Name = "OffsetX_Label";
            this.OffsetX_Label.Size = new System.Drawing.Size(45, 13);
            this.OffsetX_Label.TabIndex = 0;
            this.OffsetX_Label.Text = "OffsetX:";
            // 
            // UseDefualt_CheckBox
            // 
            this.UseDefualt_CheckBox.AutoSize = true;
            this.UseDefualt_CheckBox.BackColor = System.Drawing.Color.Transparent;
            this.UseDefualt_CheckBox.FlatAppearance.BorderSize = 0;
            this.UseDefualt_CheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.UseDefualt_CheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.UseDefualt_CheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.UseDefualt_CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseDefualt_CheckBox.ForeColor = System.Drawing.Color.Red;
            this.UseDefualt_CheckBox.Location = new System.Drawing.Point(101, 15);
            this.UseDefualt_CheckBox.Name = "UseDefualt_CheckBox";
            this.UseDefualt_CheckBox.Size = new System.Drawing.Size(82, 17);
            this.UseDefualt_CheckBox.TabIndex = 12;
            this.UseDefualt_CheckBox.TabStop = false;
            this.UseDefualt_CheckBox.Text = "Use Defualt";
            this.UseDefualt_CheckBox.UseVisualStyleBackColor = false;
            this.UseDefualt_CheckBox.CheckedChanged += new System.EventHandler(this.UseDefualt_CheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 616);
            this.Controls.Add(this.UseDefualt_CheckBox);
            this.Controls.Add(this.Offsets_Groupbox);
            this.Controls.Add(this.Main_Picturebox);
            this.Controls.Add(this.ColorPalette_Groupbox);
            this.Controls.Add(this.MassConversion_Groupbox);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "PictureToBinaryRGB | Coders: dannyruss, yfdyzjt.";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MassConversion_Groupbox.ResumeLayout(false);
            this.MassConversion_Groupbox.PerformLayout();
            this.ColorPalette_Groupbox.ResumeLayout(false);
            this.ColorPalette_Groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Picturebox)).EndInit();
            this.Offsets_Groupbox.ResumeLayout(false);
            this.Offsets_Groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxFrame_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxHeight_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWidth_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepY_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepX_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetY_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffsetX_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox MassConversion_Groupbox;
        private System.Windows.Forms.GroupBox ColorPalette_Groupbox;
        private System.Windows.Forms.TextBox ColorBox1;
        private System.Windows.Forms.TextBox ColorBox16;
        private System.Windows.Forms.TextBox ColorBox15;
        private System.Windows.Forms.TextBox ColorBox14;
        private System.Windows.Forms.TextBox ColorBox13;
        private System.Windows.Forms.TextBox ColorBox12;
        private System.Windows.Forms.TextBox ColorBox11;
        private System.Windows.Forms.TextBox ColorBox10;
        private System.Windows.Forms.TextBox ColorBox9;
        private System.Windows.Forms.TextBox ColorBox8;
        private System.Windows.Forms.TextBox ColorBox7;
        private System.Windows.Forms.TextBox ColorBox6;
        private System.Windows.Forms.TextBox ColorBox5;
        private System.Windows.Forms.TextBox ColorBox4;
        private System.Windows.Forms.TextBox ColorBox3;
        private System.Windows.Forms.TextBox ColorBox2;
        private NearestNeighborPictureBox Main_Picturebox;
        private System.Windows.Forms.TextBox AddPhotos_Textbox;
        private System.Windows.Forms.TextBox SaveLocation_Textbox;
        private System.Windows.Forms.Button ConvertImages_Button;
        private System.Windows.Forms.Button SaveLocation_Button;
        private System.Windows.Forms.Button AddPhotos_Button;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.GroupBox Offsets_Groupbox;
        private System.Windows.Forms.NumericUpDown StepY_NumericUpDown;
        private System.Windows.Forms.NumericUpDown StepX_NumericUpDown;
        private System.Windows.Forms.NumericUpDown OffsetY_NumericUpDown;
        private System.Windows.Forms.NumericUpDown OffsetX_NumericUpDown;
        private System.Windows.Forms.Label StepY_Label;
        private System.Windows.Forms.Label StepX_Label;
        private System.Windows.Forms.Label OffsetY_Label;
        private System.Windows.Forms.Label OffsetX_Label;
        private System.Windows.Forms.CheckBox GeneratePalette_CheckBox;
        private System.Windows.Forms.NumericUpDown MaxFrame_NumericUpDown;
        private System.Windows.Forms.NumericUpDown MaxHeight_NumericUpDown;
        private System.Windows.Forms.NumericUpDown MaxWidth_NumericUpDown;
        private System.Windows.Forms.Label MaxFrame_Label;
        private System.Windows.Forms.Label MaxHeight_Label;
        private System.Windows.Forms.Label MaxWidth_Label;
        private System.Windows.Forms.Button GeneratePalette_Button;
        private System.Windows.Forms.Button InGameCode_Button;
        private TransparentCheckBox UseDefualt_CheckBox;
        private System.Windows.Forms.Button GenerateTexture_Button;
        private System.Windows.Forms.CheckBox ImageFlipMode_CheckBox;
    }
}

