using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;

namespace PictureToBinaryRGB
{
    public partial class CodeViewer : Form
    {
        #region Scrolling Helper Class

        // Import WinAPI functions
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern int GetScrollPos(IntPtr hWnd, int nBar);

        private const int WM_VSCROLL = 0x0115;
        private const int SB_THUMBPOSITION = 4;
        private const int SB_VERT = 1;

        private void SyncScroll(RichTextBox source, RichTextBox target)
        {
            int scrollPos = GetScrollPos(source.Handle, SB_VERT);
            SendMessage(target.Handle, WM_VSCROLL, (IntPtr)(SB_THUMBPOSITION + 0x10000 * scrollPos), IntPtr.Zero);
        }
        #endregion

        public CodeViewer()
        {
            InitializeComponent();

            // Initially populate the line numbers.
            UpdateLineNumbers();
        }

        #region Loading Events

        // Do loading events.
        private void CodeViewer_Load(object sender, EventArgs e)
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
            toolTip.SetToolTip(CopyCode_Button, "Copy the code to the clipboard.");

            #endregion
        }
        #endregion

        #region Form Controls

        // Show a pop-up after the form laods.
        private void CodeViewer_Shown(object sender, EventArgs e)
        {
            // Display message.
            MessageBox.Show("The following code needs to be added to:\n\n" +
                "'Terraria.Chat' > 'ChatCommandProcessor' > 'ProcessIncomingMessage()'\n\n" +
                "Its suggested to use DnSpy to edit the games function.\n" +
                "This code is copy / paste ready.", "Terraria Code Viewer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Copy code.
        private void CopyCode_Button_Click(object sender, EventArgs e)
        {
            // Set the codepad text to the clipboard.
            Clipboard.SetText(CodePad_RichTextBox.Text);

            // Announce.
            MessageBox.Show("The code was successfully copied to the clipboard.", "Terraria Code Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateLineNumbers()
        {
            // Clear the current line numbers in the list before updating
            LineNumbersList_RichTextBox.Clear();

            // Initialize a variable to track the start index of each line in the code editor
            int firstCharIndex = 0;

            // Initialize the line number starting from 1
            int lineNumber = 1;

            // Loop through all the lines in the CodePad, as long as there are characters left to process
            while (firstCharIndex < CodePad_RichTextBox.TextLength)
            {
                // Retrieve the text of the current line if it exists, otherwise set it to an empty string
                string lineText = CodePad_RichTextBox.Lines.Length > lineNumber - 1 ? CodePad_RichTextBox.Lines[lineNumber - 1] : "";

                // Check if the line length is less than 190 characters
                // If it is, append the line number followed by a new line to the list
                // If the line is long (190 characters or more), add an additional empty line for better readability
                if (lineText.Length < 190)
                    LineNumbersList_RichTextBox.AppendText(lineNumber.ToString() + Environment.NewLine);
                else
                    LineNumbersList_RichTextBox.AppendText(lineNumber.ToString() + Environment.NewLine + Environment.NewLine);

                // Get the starting index of the first character in the current line
                firstCharIndex = CodePad_RichTextBox.GetFirstCharIndexFromLine(lineNumber);

                // If the first character index is -1, it means there are no more valid lines, so break the loop
                if (firstCharIndex == -1) break;

                // Increment the line number for the next iteration
                lineNumber++;
            }
        }
        #endregion

        #region Event Helpers

        private void CodePad_RichTextBox_TextChanged(object sender, EventArgs e)
        {
            // Update line numbers when the content changes.
            UpdateLineNumbers();
        }

        private void CodePad_RichTextBox_VScroll(object sender, EventArgs e)
        {
            // Synchronize scrolling with the line numbers
            SyncScroll(CodePad_RichTextBox, LineNumbersList_RichTextBox);
        }

        // Prevent hovering causing the iBeam cursor flicker.
        private void LineNumbersList_RichTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!LineNumbersList_RichTextBox.ClientRectangle.Contains(e.Location))
            {
                LineNumbersList_RichTextBox.Capture = false;
            }
            else if (!LineNumbersList_RichTextBox.Capture)
            {
                LineNumbersList_RichTextBox.Capture = true;
            }
        }
        #endregion
    }
}