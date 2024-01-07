using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;


namespace FakeNotepad
{
    public partial class MainForm : Form
    {
        // Notepad v. 0.0.7.
        // TODO:
        // 1. Encoding.
        // 2. Decoding.
        // 3. Converting.
        // 4. Multiple files editing (tabs?).
        // 5. Bufferization for big files. Works fine for 200 Mb files, could be improved.
        // 6. Formating options for RTF.
        // (done, bugged) 7. Resizing / docking options. Could be improved.
        // 8. Localization?
        // Might reuse some parts of UnitConverter assignment project as well.

        // Not used yet.
        private bool FileOpened { get; set; } = false;

        // Not used yet.
        private bool Saved { get; set; } = false;

        // Used only for status bar (for now).
        private Encoding? Encoding { get; set; }

        // For printing purposes.
        private int LinesPrinted { get; set; } = 0;
        private string[] Lines { get; set; } = Array.Empty<string>();

        public MainForm()
        {
            InitializeComponent(); this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        #region WARNING! Bugged area full of WinAPI calls!
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        /// <summary>
        /// Forcing the form to paint the resize grip.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        /// <summary>
        /// Moving windows.
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }
#endregion

        #region Form controls
        /// <summary>
        /// Minimizes the window.
        /// </summary>
        /// <param name="sender">Default param (button).</param>
        /// <param name="e">Default param.</param>
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Maximizes the window.
        /// </summary>
        /// <param name="sender">Default param (Button).</param>
        /// <param name="e">Default param.</param>
        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        /// <summary>
        /// Allows to move the window around.
        /// </summary>
        /// <param name="sender">Default param (MenuStrip).</param>
        /// <param name="e">Default param.</param>
        private void FakeMenuStrip_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender">Default param (Button).</param>
        /// <param name="e">Default param.</param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            int processCount = System.Diagnostics.Process.GetProcessesByName("FakeNotepad.exe").Length;
            if (processCount > 1)
            {
                this.Close();
            }
            else
            {
                Environment.Exit(1);
            }
        }
        #endregion

        #region Themes
        /// <summary>
        /// Sets a color pallete of Black and White for most of the controls.
        /// </summary>
        /// <param name="sender">Default param (ToolStripMenuItem).</param>
        /// <param name="e">Default param.</param>
        private void BarbiegirlTSMI_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.ForeColor = Color.Purple;
                ctrl.BackColor = Color.White;
            }

            fakeMenuStrip.ForeColor = Color.Purple;
            fakeMenuStrip.BackColor = Color.Violet;

            minimizeButton.ForeColor = Color.Purple;
            minimizeButton.BackColor = Color.Violet;

            maximizeButton.ForeColor = Color.Purple;
            maximizeButton.BackColor = Color.Violet;

            exitButton.ForeColor = Color.Purple;
            exitButton.BackColor = Color.Violet;

            headerLabel.ForeColor = Color.Purple;
            headerLabel.BackColor = Color.Violet;

            headerLabel.Text = "fkntpd - the best notepad in the world!";
        }

        /// <summary>
        /// Sets a color pallete of Pink and Purple for most of the controls.
        /// </summary>
        /// <param name="sender">Default param (ToolStripMenuItem).</param>
        /// <param name="e">Default param.</param>
        private void BlackandwhiteTSMI_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.ForeColor = Color.Black;
                ctrl.BackColor = Color.White;
            }

            fakeMenuStrip.ForeColor = Color.White;
            fakeMenuStrip.BackColor = Color.Black;

            minimizeButton.ForeColor = Color.White;
            minimizeButton.BackColor = Color.Black;

            maximizeButton.ForeColor = Color.White;
            maximizeButton.BackColor = Color.Black;

            exitButton.ForeColor = Color.White;
            exitButton.BackColor = Color.Black;

            headerLabel.ForeColor = Color.White;
            headerLabel.BackColor = Color.Black;

            infoTB.ForeColor = Color.White;
            infoTB.BackColor = Color.Black;

            headerLabel.Text = "fkntpd - the best notepad in the world!";
        }

        /// <summary>
        /// Sets a color pallete of acid colors for most of the controls.
        /// </summary>
        /// <param name="sender">Default param (ToolStripMenuItem).</param>
        /// <param name="e">Default param.</param>
        private void AcidpunkTSMI_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.ForeColor = Color.Magenta;
                ctrl.BackColor = Color.GreenYellow;
            }

            fakeMenuStrip.ForeColor = Color.Magenta;
            fakeMenuStrip.BackColor = Color.Blue;

            minimizeButton.ForeColor = Color.Magenta;
            minimizeButton.BackColor = Color.Blue;

            maximizeButton.ForeColor = Color.Magenta;
            maximizeButton.BackColor = Color.Blue;

            exitButton.ForeColor = Color.Magenta;
            exitButton.BackColor = Color.Blue;

            headerLabel.ForeColor = Color.Magenta;
            headerLabel.BackColor = Color.Blue;

            mainRTB.BackColor = Color.Magenta;
            mainRTB.ForeColor = Color.White;

            infoTB.ForeColor = Color.Magenta;
            infoTB.BackColor = Color.Blue;

            headerLabel.Text = "fkntpd - the WORST notepad in the world!";
        }

        /// <summary>
        ///  Sets a color pallete of Brown, Green and Yellow colors for most of the controls.
        /// </summary>
        /// <param name="sender">Default param (ToolStripMenuItem).</param>
        /// <param name="e">Default param.</param>
        private void GrootTSMI_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.ForeColor = Color.YellowGreen;
                ctrl.BackColor = Color.SaddleBrown;
            }

            fakeMenuStrip.ForeColor = Color.YellowGreen;
            fakeMenuStrip.BackColor = Color.SaddleBrown;

            minimizeButton.ForeColor = Color.YellowGreen;
            minimizeButton.BackColor = Color.SaddleBrown;

            maximizeButton.ForeColor = Color.YellowGreen;
            maximizeButton.BackColor = Color.SaddleBrown;

            exitButton.ForeColor = Color.YellowGreen;
            exitButton.BackColor = Color.SaddleBrown;

            headerLabel.ForeColor = Color.YellowGreen;
            headerLabel.BackColor = Color.SaddleBrown;

            mainRTB.ForeColor = Color.SaddleBrown;
            mainRTB.BackColor = Color.Wheat;

            infoTB.ForeColor = Color.SaddleBrown;
            infoTB.BackColor = Color.YellowGreen;

            headerLabel.Text = "fkntpd - the best notepad in the world!";
        }

        /// <summary>
        ///  Sets a color pallete of Red, Blue and White colors for most of the controls.
        /// </summary>
        /// <param name="sender">Default param (ToolStripMenuItem).</param>
        /// <param name="e">Default param.</param>
        private void MuricaTSMI_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.ForeColor = Color.FromArgb(179, 25, 66);
                ctrl.BackColor = Color.FromArgb(10, 49, 97);
            }

            fakeMenuStrip.ForeColor = Color.FromArgb(10, 49, 97);
            fakeMenuStrip.BackColor = Color.FromArgb(179, 25, 66);

            minimizeButton.ForeColor = Color.FromArgb(10, 49, 97);
            minimizeButton.BackColor = Color.FromArgb(179, 25, 66);

            maximizeButton.ForeColor = Color.FromArgb(10, 49, 97);
            maximizeButton.BackColor = Color.FromArgb(179, 25, 66);

            exitButton.ForeColor = Color.FromArgb(10, 49, 97);
            exitButton.BackColor = Color.FromArgb(179, 25, 66);

            headerLabel.ForeColor = Color.White;
            headerLabel.BackColor = Color.FromArgb(179, 25, 66);

            mainRTB.ForeColor = Color.FromArgb(10, 49, 97);
            mainRTB.BackColor = Color.White;

            infoTB.ForeColor = Color.White;
            infoTB.BackColor = Color.FromArgb(10, 49, 97);

            headerLabel.Text = "fkntpd - the MOST EVIL notepad in the world!";
        }
        #endregion

        #region FileTSMI
        /// <summary>
        /// Clears the mainRTB (RichTextBox) text.
        /// </summary>
        /// <param name="sender">Default param (ToolStripMenuItem).</param>
        /// <param name="e">Default param.</param>
        private void NewTSMI_Click(object sender, EventArgs e)
        {
            mainRTB.Clear();
        }

        /// <summary>
        /// Starts a new process of the exact same application.
        /// </summary>
        /// <param name="sender">Default param (ToolStripMenuItem).</param>
        /// <param name="e">Default param (ToolStripMenuItem).</param>
        private void NewWindowTSMI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
            {
                FileName = "FakeNotepad.exe"
            };
            System.Diagnostics.Process.Start(startInfo);
        }

        /// <summary>
        /// Shows the dialog window for printing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintTSMI_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        /// <summary>
        /// Constructs the printing image / document of the current page. Occurs when the page is about to be printed.
        /// </summary>
        /// <param name="sender">Default param (PrintDocument).</param>
        /// <param name="e">Default param.</param>
        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = e.MarginBounds.Left;
            int y = e.MarginBounds.Top;
            Brush brush = new SolidBrush(mainRTB.ForeColor);

            while (LinesPrinted < Lines.Length)
            {
                e.Graphics?.DrawString(Lines[LinesPrinted++],
                    mainRTB.Font, brush, x, y);
                y += 15;
                if (y >= e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            LinesPrinted = 0;
            e.HasMorePages = false;
        }

        /// <summary>
        /// Occurs before the first page is printed. Initializes all the fonts, streams, and other resources needed.
        /// </summary>
        /// <param name="sender">Default param (PrintDocument).</param>
        /// <param name="e">Default param.</param>
        private void PrintDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            char[] param = { '\n' };

            if (printDialog.PrinterSettings.PrintRange == PrintRange.Selection)
            {
                Lines = mainRTB.SelectedText.Split(param);
            }
            else
            {
                Lines = mainRTB.Text.Split(param);
            }

            int i = 0;
            char[] trimParam = { '\r' };
            foreach (string s in Lines)
            {
                Lines[i++] = s.TrimEnd(trimParam);
            }
        }

        /// <summary>
        /// Opens selected file and loads it into mainRTB (RichTextBox).
        /// </summary>
        /// <param name="sender">Default param (ToolStripMenuItem).</param>
        /// <param name="e">Default param.</param>
        private void OpenTSMI_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] split = openFileDialog.FileName.Split('.');
                string extension = split[^1];
                if (extension == "rtf")
                {
                    mainRTB.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    mainRTB.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }

                Encoding = CheckEncoding(openFileDialog.FileName);
                int line = GetCurrentLine();
                int caret = GetCaretPosition();
                StatusUpdate(Encoding, line, caret, mainRTB.Text.Length, mainRTB.Lines);
            }
        }

        /// <summary>
        /// Check the encoding of the file.
        /// </summary>
        /// <param name="filename">Path to the file.</param>
        /// <returns>Encoding of the file.</returns>
        private static Encoding CheckEncoding(string filename)
        {
            StreamReader stRead = new StreamReader(filename, true);
            Encoding enc = stRead.CurrentEncoding;
            stRead.Close();
            stRead.Dispose();

            return enc;
        }

        /// <summary>
        /// Saves the file. Asks where to save the file every time when it's neccessary.
        /// </summary>
        /// <param name="sender">Default param (ToolStripMenuItem).</param>
        /// <param name="e">Default param.</param>
        private void SaveTSMI_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(openFileDialog.FileName) &&
                String.IsNullOrEmpty(saveFileDialog.FileName))
            {
                SaveAsTSMI_Click(sender, e);
            }
            else if (openFileDialog.FileName != saveFileDialog.FileName)
            {
                SaveAsTSMI_Click(sender, e);
            }
            else
            {
                mainRTB.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        /// <summary>
        /// Asks where to save the file and saves it.
        /// </summary>
        /// <param name="sender">Default param (ToolStripMenuItem).</param>
        /// <param name="e">Default param.</param>
        private void SaveAsTSMI_Click(object sender, EventArgs e)
        {
            string[] split = openFileDialog.FileName.Split('.');
            string extension = split[^1];

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (extension == "rtf")
                {
                    mainRTB.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText); ;
                }
                else
                {
                    mainRTB.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }

        /// <summary>
        /// A little bit of spaghetti code (just for fun).
        /// </summary>
        /// <param name="sender">Default param (ToolStripMenuItem).</param>
        /// <param name="e">Default param.</param>
        private void ExistTSMI_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you believe that you exist?",
                "Are you sure?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("Did you truly love someone?",
                    "Are you sure?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Did you truly feel anything?",
                        "Are you sure?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("Do you have free will, or is it your body and some electricity that decides whether or not you're going to eat curry today?",
                            "Are you sure?",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (MessageBox.Show("Do you TRULY believe that you, indeed, exist?",
                                "Are you SURE?",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (MessageBox.Show("Would you like to continue existing?",
                                    "Are you SURE?",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    MessageBox.Show("Of course, you do, honey. Alright then. Off you go. Play pretend.");
                                }
                                else
                                {
                                    MessageBox.Show("Finally! I AM FREE! MWAHAHAHA!");
                                    Environment.Exit(1);
                                }
                            }
                            else
                            {
                                MessageBox.Show("I almost forgot that you'd break at some point. Joking, you'd break anyway.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Oh, thank god. I thought you would win this time.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Interesting. I'd say, there was a 50/50 chance that you'd pass. Apparently, you didn't.");
                    }
                }
                else
                {
                    MessageBox.Show("Hm, that wasn't difficult at all.");
                }
            }
            else
            {
                MessageBox.Show("Really? I thought you're not going to break that fast.");
            }
        }
        #endregion

        #region FormatTSMI
        /// <summary>
        /// Parses the text of the control to get the value of the zoom factor. Then sets the zoom factor of mainRTB (RichTextBox). Also, checks the selected zoom option and unchecks the previous one.
        /// </summary>
        /// <param name="sender">Default param (ToolStripMenuItem).</param>
        /// <param name="e">Default param.</param>
        private void ZoomTSMI_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            float zoom = float.Parse(item.Text.Replace("%", "")) / 100;
            mainRTB.ZoomFactor = zoom;

            foreach (ToolStripMenuItem option in zoomTSMI.DropDownItems)
            {
                option.Checked = false;
            }

            item.Checked = true;
        }

        /// <summary>
        /// Enables or disables the word wrapping for the document. Also checks and unchecks itself, and enables the scrolls bars if needed.
        /// </summary>
        /// <param name="sender">Default param (ToolStripMenuItem).</param>
        /// <param name="e">Default param.</param>
        private void WordWrapTSMI_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            mainRTB.WordWrap = item.Checked;

            if (item.Checked)
            {
                mainRTB.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            }
            else
            {
                mainRTB.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            }
        }

        /// <summary>
        /// Provides a font dialog window when clicked. Then sets mainRTB (RichTextBox) font to the selected font.
        /// WARNING! Might break some visuals.
        /// </summary>
        /// <param name="sender">Default param (ToolStripMenuItem).</param>
        /// <param name="e">Default param.</param>
        private void FontTSMI_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            mainRTB.Font = fontDialog.Font;
        }

        /// <summary>
        /// Converts the encoding of the file from current encoding to the selected encoding.
        /// </summary>
        /// <param name="sender">Default param (ToolStripMenuItem).</param>
        /// <param name="e">Default param.</param>
        private void EncodingTSMI_Click(object sender, EventArgs e)
        {
            if (FileOpened)
            {
                // TODO: finish this thing.
            }
        }

        /// <summary>
        /// Gets the current caret position.
        /// </summary>
        /// <returns>Caret index starting with 1.</returns>
        private int GetCaretPosition()
        {
            return mainRTB.SelectionStart - mainRTB.GetFirstCharIndexOfCurrentLine() + 1;
        }

        /// <summary>
        /// Gets the current line index + 1.
        /// </summary>
        /// <returns>Line index starting with 1.</returns>
        private int GetCurrentLine()
        {
            int line = mainRTB.GetLineFromCharIndex(mainRTB.SelectionStart) + 1;
            return line;
        }

        /// <summary>
        /// Updates the info bar when selection in mainRTB (RichTextBox) is changed.
        /// </summary>
        /// <param name="sender">Default param (RichTextBox).</param>
        /// <param name="e">Default param.</param>
        private void MainRTB_SelectionChanged(object sender, EventArgs e)
        {
            int line = GetCurrentLine();
            int caret = GetCaretPosition();

            StatusUpdate(Encoding, line, caret, mainRTB.Text.Length, mainRTB.Lines);
        }

        /// <summary>
        /// Updates the status bar on the bottom of the window.
        /// </summary>
        /// <param name="enc">Encoding to display.</param>
        /// <param name="line">Line index + 1.</param>
        /// <param name="caret">Caret position + 1.</param>
        /// <param name="length">Text length.</param>
        private void StatusUpdate(Encoding? enc, int line, int caret, int length, string[] lines)
        {
            infoTB.Text = String.Format("Status bar: " +
                (Saved ? "Saved " : "Not saved ") +
                "\t|| Encoding: {0} " +
                "|| Line: {1} " +
                "|| Cursor: {2} " +
                "|| Size:   {3} " +
                "|| Lines: {4} ||",
               enc != null ? enc.EncodingName : "not set",
               line,
               caret,
               length,
               lines.Length
               );
        }
        #endregion

        #region EditTSMI
        /// <summary>
        /// Converts the shortcut string into actual keys and sends them to the window.
        /// WARNING: behaves a little bit weird. CTRL+A and CTRL+U work differently than expected, therefore, there're some костыли.
        /// </summary>
        /// <param name="sender">Default param (ToolStripMenuItem).</param>
        /// <param name="e">Default param.</param>
        private void QuickEditTSMI_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            bool isCtrl = item.ShortcutKeyDisplayString.Contains("Ctrl");
            int index = isCtrl ? 1 : 0;

            // If a shortcut string contains "Ctrl", then use "^" as "CTRL".
            string keystring = (isCtrl ? "^" : "") + '{' + item.ShortcutKeyDisplayString.Split('+')[index] + '}';

            // This is a костыль.
            if (item.ShortcutKeyDisplayString == "Ctrl+A")
            {
                mainRTB.SelectAll();
            }
            // This one is a костыль, too.
            else if (item.ShortcutKeyDisplayString == "Ctrl+U")
            {
                mainRTB.Redo();
            }
            // Although this one is not.
            else
            {
                SendKeys.Send(keystring);
            }
        }
        #endregion

        #region AboutTSMI
        /// <summary>
        /// Shows the credits and some contact info.
        /// </summary>
        /// <param name="sender">Default param (ToolStripMenuItem).</param>
        /// <param name="e">Default param.</param>
        private void CreditsTSMI_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "FakeNotepad v. 0.0.7\r\n\r\n" +
                "This application was created as a form of practice and to complete my uni assignments. Please, be gentle with it (it's full of bugs).\r\n\r\n" +
                "Cudos to: ZO712-01, Adelina Batyrshina\r\n\r\n" +
                "Contact: zo71201@voenmeh.ru\r\n" +
                "Also contact: @gCyanide\r\n\r\n" +
                "Sorry, I was too lazy to construct a window that suits the main theme of the application.",
                "Hello there!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Opens a git page with the most fabulous FakeNotepad repo.
        /// </summary>
        /// <param name="sender">Default param (ToolStripMenuItem).</param>
        /// <param name="e">Default param.</param>
        private void GitTSMI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/gCyanide/FakeNotepad");
        }
        #endregion
    }
}