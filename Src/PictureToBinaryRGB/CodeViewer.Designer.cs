namespace PictureToBinaryRGB
{
    partial class CodeViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeViewer));
            this.LineNumbersList_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.CodePad_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.CopyCode_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LineNumbersList_RichTextBox
            // 
            this.LineNumbersList_RichTextBox.BackColor = System.Drawing.Color.Silver;
            this.LineNumbersList_RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LineNumbersList_RichTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LineNumbersList_RichTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LineNumbersList_RichTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineNumbersList_RichTextBox.Location = new System.Drawing.Point(0, 0);
            this.LineNumbersList_RichTextBox.Name = "LineNumbersList_RichTextBox";
            this.LineNumbersList_RichTextBox.ReadOnly = true;
            this.LineNumbersList_RichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LineNumbersList_RichTextBox.Size = new System.Drawing.Size(24, 661);
            this.LineNumbersList_RichTextBox.TabIndex = 3;
            this.LineNumbersList_RichTextBox.TabStop = false;
            this.LineNumbersList_RichTextBox.Text = "000";
            this.LineNumbersList_RichTextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LineNumbersList_RichTextBox_MouseMove);
            // 
            // CodePad_RichTextBox
            // 
            this.CodePad_RichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CodePad_RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodePad_RichTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodePad_RichTextBox.Location = new System.Drawing.Point(24, 0);
            this.CodePad_RichTextBox.Name = "CodePad_RichTextBox";
            this.CodePad_RichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.CodePad_RichTextBox.Size = new System.Drawing.Size(1360, 661);
            this.CodePad_RichTextBox.TabIndex = 0;
            this.CodePad_RichTextBox.Text = resources.GetString("CodePad_RichTextBox.Text");
            this.CodePad_RichTextBox.VScroll += new System.EventHandler(this.CodePad_RichTextBox_VScroll);
            this.CodePad_RichTextBox.TextChanged += new System.EventHandler(this.CodePad_RichTextBox_TextChanged);
            // 
            // CopyCode_Button
            // 
            this.CopyCode_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyCode_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyCode_Button.Location = new System.Drawing.Point(1309, 638);
            this.CopyCode_Button.Name = "CopyCode_Button";
            this.CopyCode_Button.Size = new System.Drawing.Size(75, 23);
            this.CopyCode_Button.TabIndex = 1;
            this.CopyCode_Button.Text = "Copy Code";
            this.CopyCode_Button.UseVisualStyleBackColor = true;
            this.CopyCode_Button.Click += new System.EventHandler(this.CopyCode_Button_Click);
            // 
            // CodeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.CopyCode_Button);
            this.Controls.Add(this.CodePad_RichTextBox);
            this.Controls.Add(this.LineNumbersList_RichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CodeViewer";
            this.Text = "Terraria Code Viewer";
            this.Load += new System.EventHandler(this.CodeViewer_Load);
            this.Shown += new System.EventHandler(this.CodeViewer_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox LineNumbersList_RichTextBox;
        private System.Windows.Forms.RichTextBox CodePad_RichTextBox;
        private System.Windows.Forms.Button CopyCode_Button;
    }
}