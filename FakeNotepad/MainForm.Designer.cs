namespace FakeNotepad
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.toolbarMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.newTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTSS1 = new System.Windows.Forms.ToolStripSeparator();
            this.printTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTSS2 = new System.Windows.Forms.ToolStripSeparator();
            this.existTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.formatTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.fontTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom50TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom75TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom100TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom125TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom150TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.themeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.barbiegirlTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.acidpunkTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.blackandwhiteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.grootTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.muricaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.encodingTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.undoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.redoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.editTSS1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.cutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.editTSS2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.gitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.mainRTB = new System.Windows.Forms.RichTextBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fakeMenuStrip = new System.Windows.Forms.MenuStrip();
            this.infoTB = new System.Windows.Forms.TextBox();
            this.gripControl1 = new FakeNotepad.GripControl();
            this.toolbarMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            resources.ApplyResources(this.headerLabel, "headerLabel");
            this.headerLabel.BackColor = System.Drawing.Color.Violet;
            this.headerLabel.ForeColor = System.Drawing.Color.Purple;
            this.headerLabel.Name = "headerLabel";
            // 
            // minimizeButton
            // 
            resources.ApplyResources(this.minimizeButton, "minimizeButton");
            this.minimizeButton.BackColor = System.Drawing.Color.Violet;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.ForeColor = System.Drawing.Color.Purple;
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.BackColor = System.Drawing.Color.Violet;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.ForeColor = System.Drawing.Color.Purple;
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // maximizeButton
            // 
            resources.ApplyResources(this.maximizeButton, "maximizeButton");
            this.maximizeButton.BackColor = System.Drawing.Color.Violet;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.ForeColor = System.Drawing.Color.Purple;
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // toolbarMenuStrip
            // 
            resources.ApplyResources(this.toolbarMenuStrip, "toolbarMenuStrip");
            this.toolbarMenuStrip.AllowItemReorder = true;
            this.toolbarMenuStrip.BackColor = System.Drawing.Color.White;
            this.toolbarMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolbarMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTSMI,
            this.formatTSMI,
            this.editTSMI,
            this.aboutTSMI});
            this.toolbarMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolbarMenuStrip.Name = "toolbarMenuStrip";
            // 
            // fileTSMI
            // 
            resources.ApplyResources(this.fileTSMI, "fileTSMI");
            this.fileTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTSMI,
            this.newWindowTSMI,
            this.openTSMI,
            this.saveTSMI,
            this.saveAsTSMI,
            this.fileTSS1,
            this.printTSMI,
            this.fileTSS2,
            this.existTSMI,
            this.exitTSMI});
            this.fileTSMI.Name = "fileTSMI";
            // 
            // newTSMI
            // 
            resources.ApplyResources(this.newTSMI, "newTSMI");
            this.newTSMI.BackColor = System.Drawing.Color.White;
            this.newTSMI.ForeColor = System.Drawing.Color.Purple;
            this.newTSMI.Name = "newTSMI";
            this.newTSMI.Click += new System.EventHandler(this.NewTSMI_Click);
            // 
            // newWindowTSMI
            // 
            resources.ApplyResources(this.newWindowTSMI, "newWindowTSMI");
            this.newWindowTSMI.BackColor = System.Drawing.Color.White;
            this.newWindowTSMI.ForeColor = System.Drawing.Color.Purple;
            this.newWindowTSMI.Name = "newWindowTSMI";
            this.newWindowTSMI.Click += new System.EventHandler(this.NewWindowTSMI_Click);
            // 
            // openTSMI
            // 
            resources.ApplyResources(this.openTSMI, "openTSMI");
            this.openTSMI.BackColor = System.Drawing.Color.White;
            this.openTSMI.ForeColor = System.Drawing.Color.Purple;
            this.openTSMI.Name = "openTSMI";
            this.openTSMI.Click += new System.EventHandler(this.OpenTSMI_Click);
            // 
            // saveTSMI
            // 
            resources.ApplyResources(this.saveTSMI, "saveTSMI");
            this.saveTSMI.BackColor = System.Drawing.Color.White;
            this.saveTSMI.ForeColor = System.Drawing.Color.Purple;
            this.saveTSMI.Name = "saveTSMI";
            this.saveTSMI.Click += new System.EventHandler(this.SaveTSMI_Click);
            // 
            // saveAsTSMI
            // 
            resources.ApplyResources(this.saveAsTSMI, "saveAsTSMI");
            this.saveAsTSMI.BackColor = System.Drawing.Color.White;
            this.saveAsTSMI.ForeColor = System.Drawing.Color.Purple;
            this.saveAsTSMI.Name = "saveAsTSMI";
            this.saveAsTSMI.Click += new System.EventHandler(this.SaveAsTSMI_Click);
            // 
            // fileTSS1
            // 
            resources.ApplyResources(this.fileTSS1, "fileTSS1");
            this.fileTSS1.BackColor = System.Drawing.Color.White;
            this.fileTSS1.ForeColor = System.Drawing.Color.Purple;
            this.fileTSS1.Name = "fileTSS1";
            // 
            // printTSMI
            // 
            resources.ApplyResources(this.printTSMI, "printTSMI");
            this.printTSMI.BackColor = System.Drawing.Color.White;
            this.printTSMI.ForeColor = System.Drawing.Color.Purple;
            this.printTSMI.Name = "printTSMI";
            this.printTSMI.Click += new System.EventHandler(this.PrintTSMI_Click);
            // 
            // fileTSS2
            // 
            resources.ApplyResources(this.fileTSS2, "fileTSS2");
            this.fileTSS2.BackColor = System.Drawing.Color.White;
            this.fileTSS2.ForeColor = System.Drawing.Color.Purple;
            this.fileTSS2.Name = "fileTSS2";
            // 
            // existTSMI
            // 
            resources.ApplyResources(this.existTSMI, "existTSMI");
            this.existTSMI.BackColor = System.Drawing.Color.White;
            this.existTSMI.ForeColor = System.Drawing.Color.Purple;
            this.existTSMI.Name = "existTSMI";
            this.existTSMI.Click += new System.EventHandler(this.ExistTSMI_Click);
            // 
            // exitTSMI
            // 
            resources.ApplyResources(this.exitTSMI, "exitTSMI");
            this.exitTSMI.BackColor = System.Drawing.Color.White;
            this.exitTSMI.ForeColor = System.Drawing.Color.Purple;
            this.exitTSMI.Name = "exitTSMI";
            // 
            // formatTSMI
            // 
            resources.ApplyResources(this.formatTSMI, "formatTSMI");
            this.formatTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrapTSMI,
            this.fontTSMI,
            this.zoomTSMI,
            this.themeTSMI,
            this.encodingTSMI});
            this.formatTSMI.Name = "formatTSMI";
            // 
            // wordWrapTSMI
            // 
            resources.ApplyResources(this.wordWrapTSMI, "wordWrapTSMI");
            this.wordWrapTSMI.BackColor = System.Drawing.Color.White;
            this.wordWrapTSMI.CheckOnClick = true;
            this.wordWrapTSMI.ForeColor = System.Drawing.Color.Purple;
            this.wordWrapTSMI.Name = "wordWrapTSMI";
            this.wordWrapTSMI.Click += new System.EventHandler(this.WordWrapTSMI_Click);
            // 
            // fontTSMI
            // 
            resources.ApplyResources(this.fontTSMI, "fontTSMI");
            this.fontTSMI.BackColor = System.Drawing.Color.White;
            this.fontTSMI.ForeColor = System.Drawing.Color.Purple;
            this.fontTSMI.Name = "fontTSMI";
            this.fontTSMI.Click += new System.EventHandler(this.FontTSMI_Click);
            // 
            // zoomTSMI
            // 
            resources.ApplyResources(this.zoomTSMI, "zoomTSMI");
            this.zoomTSMI.BackColor = System.Drawing.Color.White;
            this.zoomTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoom50TSMI,
            this.zoom75TSMI,
            this.zoom100TSMI,
            this.zoom125TSMI,
            this.zoom150TSMI});
            this.zoomTSMI.ForeColor = System.Drawing.Color.Purple;
            this.zoomTSMI.Name = "zoomTSMI";
            // 
            // zoom50TSMI
            // 
            resources.ApplyResources(this.zoom50TSMI, "zoom50TSMI");
            this.zoom50TSMI.Name = "zoom50TSMI";
            this.zoom50TSMI.Click += new System.EventHandler(this.ZoomTSMI_Click);
            // 
            // zoom75TSMI
            // 
            resources.ApplyResources(this.zoom75TSMI, "zoom75TSMI");
            this.zoom75TSMI.Name = "zoom75TSMI";
            this.zoom75TSMI.Click += new System.EventHandler(this.ZoomTSMI_Click);
            // 
            // zoom100TSMI
            // 
            resources.ApplyResources(this.zoom100TSMI, "zoom100TSMI");
            this.zoom100TSMI.Checked = true;
            this.zoom100TSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zoom100TSMI.Name = "zoom100TSMI";
            this.zoom100TSMI.Click += new System.EventHandler(this.ZoomTSMI_Click);
            // 
            // zoom125TSMI
            // 
            resources.ApplyResources(this.zoom125TSMI, "zoom125TSMI");
            this.zoom125TSMI.Name = "zoom125TSMI";
            this.zoom125TSMI.Click += new System.EventHandler(this.ZoomTSMI_Click);
            // 
            // zoom150TSMI
            // 
            resources.ApplyResources(this.zoom150TSMI, "zoom150TSMI");
            this.zoom150TSMI.Name = "zoom150TSMI";
            this.zoom150TSMI.Click += new System.EventHandler(this.ZoomTSMI_Click);
            // 
            // themeTSMI
            // 
            resources.ApplyResources(this.themeTSMI, "themeTSMI");
            this.themeTSMI.BackColor = System.Drawing.Color.White;
            this.themeTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barbiegirlTSMI,
            this.acidpunkTSMI,
            this.blackandwhiteTSMI,
            this.grootTSMI,
            this.muricaTSMI});
            this.themeTSMI.ForeColor = System.Drawing.Color.Purple;
            this.themeTSMI.Name = "themeTSMI";
            // 
            // barbiegirlTSMI
            // 
            resources.ApplyResources(this.barbiegirlTSMI, "barbiegirlTSMI");
            this.barbiegirlTSMI.Name = "barbiegirlTSMI";
            this.barbiegirlTSMI.Click += new System.EventHandler(this.BarbiegirlTSMI_Click);
            // 
            // acidpunkTSMI
            // 
            resources.ApplyResources(this.acidpunkTSMI, "acidpunkTSMI");
            this.acidpunkTSMI.Name = "acidpunkTSMI";
            this.acidpunkTSMI.Click += new System.EventHandler(this.AcidpunkTSMI_Click);
            // 
            // blackandwhiteTSMI
            // 
            resources.ApplyResources(this.blackandwhiteTSMI, "blackandwhiteTSMI");
            this.blackandwhiteTSMI.Name = "blackandwhiteTSMI";
            this.blackandwhiteTSMI.Click += new System.EventHandler(this.BlackandwhiteTSMI_Click);
            // 
            // grootTSMI
            // 
            resources.ApplyResources(this.grootTSMI, "grootTSMI");
            this.grootTSMI.Name = "grootTSMI";
            this.grootTSMI.Click += new System.EventHandler(this.GrootTSMI_Click);
            // 
            // muricaTSMI
            // 
            resources.ApplyResources(this.muricaTSMI, "muricaTSMI");
            this.muricaTSMI.Name = "muricaTSMI";
            this.muricaTSMI.Click += new System.EventHandler(this.MuricaTSMI_Click);
            // 
            // encodingTSMI
            // 
            resources.ApplyResources(this.encodingTSMI, "encodingTSMI");
            this.encodingTSMI.BackColor = System.Drawing.Color.White;
            this.encodingTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToolStripMenuItem,
            this.encodeToolStripMenuItem,
            this.decodeToolStripMenuItem});
            this.encodingTSMI.ForeColor = System.Drawing.Color.Purple;
            this.encodingTSMI.Name = "encodingTSMI";
            // 
            // convertToolStripMenuItem
            // 
            resources.ApplyResources(this.convertToolStripMenuItem, "convertToolStripMenuItem");
            this.convertToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.convertToolStripMenuItem.ForeColor = System.Drawing.Color.Purple;
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            // 
            // encodeToolStripMenuItem
            // 
            resources.ApplyResources(this.encodeToolStripMenuItem, "encodeToolStripMenuItem");
            this.encodeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.encodeToolStripMenuItem.ForeColor = System.Drawing.Color.Purple;
            this.encodeToolStripMenuItem.Name = "encodeToolStripMenuItem";
            // 
            // decodeToolStripMenuItem
            // 
            resources.ApplyResources(this.decodeToolStripMenuItem, "decodeToolStripMenuItem");
            this.decodeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.decodeToolStripMenuItem.ForeColor = System.Drawing.Color.Purple;
            this.decodeToolStripMenuItem.Name = "decodeToolStripMenuItem";
            // 
            // editTSMI
            // 
            resources.ApplyResources(this.editTSMI, "editTSMI");
            this.editTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoTSMI,
            this.redoTSMI,
            this.editTSS1,
            this.copyTSMI,
            this.pasteTSMI,
            this.cutTSMI,
            this.deleteTSMI,
            this.editTSS2,
            this.selectTSMI});
            this.editTSMI.Name = "editTSMI";
            // 
            // undoTSMI
            // 
            resources.ApplyResources(this.undoTSMI, "undoTSMI");
            this.undoTSMI.BackColor = System.Drawing.Color.White;
            this.undoTSMI.ForeColor = System.Drawing.Color.Purple;
            this.undoTSMI.Name = "undoTSMI";
            this.undoTSMI.Click += new System.EventHandler(this.QuickEditTSMI_Click);
            // 
            // redoTSMI
            // 
            resources.ApplyResources(this.redoTSMI, "redoTSMI");
            this.redoTSMI.BackColor = System.Drawing.Color.White;
            this.redoTSMI.ForeColor = System.Drawing.Color.Purple;
            this.redoTSMI.Name = "redoTSMI";
            this.redoTSMI.Click += new System.EventHandler(this.QuickEditTSMI_Click);
            // 
            // editTSS1
            // 
            resources.ApplyResources(this.editTSS1, "editTSS1");
            this.editTSS1.BackColor = System.Drawing.Color.White;
            this.editTSS1.ForeColor = System.Drawing.Color.Purple;
            this.editTSS1.Name = "editTSS1";
            // 
            // copyTSMI
            // 
            resources.ApplyResources(this.copyTSMI, "copyTSMI");
            this.copyTSMI.BackColor = System.Drawing.Color.White;
            this.copyTSMI.ForeColor = System.Drawing.Color.Purple;
            this.copyTSMI.Name = "copyTSMI";
            this.copyTSMI.Click += new System.EventHandler(this.QuickEditTSMI_Click);
            // 
            // pasteTSMI
            // 
            resources.ApplyResources(this.pasteTSMI, "pasteTSMI");
            this.pasteTSMI.BackColor = System.Drawing.Color.White;
            this.pasteTSMI.ForeColor = System.Drawing.Color.Purple;
            this.pasteTSMI.Name = "pasteTSMI";
            this.pasteTSMI.Click += new System.EventHandler(this.QuickEditTSMI_Click);
            // 
            // cutTSMI
            // 
            resources.ApplyResources(this.cutTSMI, "cutTSMI");
            this.cutTSMI.BackColor = System.Drawing.Color.White;
            this.cutTSMI.ForeColor = System.Drawing.Color.Purple;
            this.cutTSMI.Name = "cutTSMI";
            this.cutTSMI.Click += new System.EventHandler(this.QuickEditTSMI_Click);
            // 
            // deleteTSMI
            // 
            resources.ApplyResources(this.deleteTSMI, "deleteTSMI");
            this.deleteTSMI.BackColor = System.Drawing.Color.White;
            this.deleteTSMI.ForeColor = System.Drawing.Color.Purple;
            this.deleteTSMI.Name = "deleteTSMI";
            this.deleteTSMI.Click += new System.EventHandler(this.QuickEditTSMI_Click);
            // 
            // editTSS2
            // 
            resources.ApplyResources(this.editTSS2, "editTSS2");
            this.editTSS2.BackColor = System.Drawing.Color.White;
            this.editTSS2.ForeColor = System.Drawing.Color.Purple;
            this.editTSS2.Name = "editTSS2";
            // 
            // selectTSMI
            // 
            resources.ApplyResources(this.selectTSMI, "selectTSMI");
            this.selectTSMI.BackColor = System.Drawing.Color.White;
            this.selectTSMI.ForeColor = System.Drawing.Color.Purple;
            this.selectTSMI.Name = "selectTSMI";
            this.selectTSMI.Click += new System.EventHandler(this.QuickEditTSMI_Click);
            // 
            // aboutTSMI
            // 
            resources.ApplyResources(this.aboutTSMI, "aboutTSMI");
            this.aboutTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gitTSMI,
            this.creditsTSMI});
            this.aboutTSMI.Name = "aboutTSMI";
            // 
            // gitTSMI
            // 
            resources.ApplyResources(this.gitTSMI, "gitTSMI");
            this.gitTSMI.BackColor = System.Drawing.Color.White;
            this.gitTSMI.ForeColor = System.Drawing.Color.Purple;
            this.gitTSMI.Name = "gitTSMI";
            this.gitTSMI.Click += new System.EventHandler(this.GitTSMI_Click);
            // 
            // creditsTSMI
            // 
            resources.ApplyResources(this.creditsTSMI, "creditsTSMI");
            this.creditsTSMI.BackColor = System.Drawing.Color.White;
            this.creditsTSMI.ForeColor = System.Drawing.Color.Purple;
            this.creditsTSMI.Name = "creditsTSMI";
            this.creditsTSMI.Click += new System.EventHandler(this.CreditsTSMI_Click);
            // 
            // mainRTB
            // 
            resources.ApplyResources(this.mainRTB, "mainRTB");
            this.mainRTB.BackColor = System.Drawing.Color.White;
            this.mainRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainRTB.ForeColor = System.Drawing.Color.Purple;
            this.mainRTB.Name = "mainRTB";
            this.mainRTB.SelectionChanged += new System.EventHandler(this.MainRTB_SelectionChanged);
            // 
            // fontDialog
            // 
            this.fontDialog.Color = System.Drawing.Color.White;
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            resources.ApplyResources(this.saveFileDialog, "saveFileDialog");
            this.saveFileDialog.ShowHiddenFiles = true;
            // 
            // openFileDialog
            // 
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            this.openFileDialog.ShowHiddenFiles = true;
            // 
            // fakeMenuStrip
            // 
            resources.ApplyResources(this.fakeMenuStrip, "fakeMenuStrip");
            this.fakeMenuStrip.BackColor = System.Drawing.Color.Violet;
            this.fakeMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fakeMenuStrip.Name = "fakeMenuStrip";
            this.fakeMenuStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FakeMenuStrip_MouseDown);
            // 
            // infoTB
            // 
            resources.ApplyResources(this.infoTB, "infoTB");
            this.infoTB.BackColor = System.Drawing.Color.White;
            this.infoTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoTB.ForeColor = System.Drawing.Color.Purple;
            this.infoTB.Name = "infoTB";
            this.infoTB.ReadOnly = true;
            // 
            // gripControl1
            // 
            resources.ApplyResources(this.gripControl1, "gripControl1");
            this.gripControl1.Name = "gripControl1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.infoTB);
            this.Controls.Add(this.mainRTB);
            this.Controls.Add(this.maximizeButton);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.toolbarMenuStrip);
            this.Controls.Add(this.fakeMenuStrip);
            this.Controls.Add(this.gripControl1);
            this.ForeColor = System.Drawing.Color.Purple;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.toolbarMenuStrip;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.toolbarMenuStrip.ResumeLayout(false);
            this.toolbarMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Button minimizeButton;
        private Button exitButton;
        private Button maximizeButton;
        private MenuStrip toolbarMenuStrip;
        private ToolStripMenuItem fileTSMI;
        private ToolStripMenuItem editTSMI;
        private ToolStripMenuItem formatTSMI;
        private ToolStripMenuItem newTSMI;
        private ToolStripMenuItem newWindowTSMI;
        private ToolStripMenuItem openTSMI;
        private ToolStripMenuItem saveTSMI;
        private ToolStripMenuItem saveAsTSMI;
        private ToolStripSeparator fileTSS1;
        private ToolStripMenuItem printTSMI;
        private ToolStripSeparator fileTSS2;
        private ToolStripMenuItem existTSMI;
        private ToolStripMenuItem exitTSMI;
        private ToolStripMenuItem undoTSMI;
        private ToolStripMenuItem redoTSMI;
        private ToolStripMenuItem copyTSMI;
        private ToolStripMenuItem pasteTSMI;
        private ToolStripMenuItem cutTSMI;
        private ToolStripMenuItem deleteTSMI;
        private ToolStripMenuItem selectTSMI;
        private ToolStripMenuItem wordWrapTSMI;
        private ToolStripMenuItem fontTSMI;
        private ToolStripMenuItem zoomTSMI;
        private ToolStripMenuItem zoom50TSMI;
        private ToolStripMenuItem zoom75TSMI;
        private ToolStripMenuItem zoom100TSMI;
        private ToolStripMenuItem zoom125TSMI;
        private ToolStripMenuItem zoom150TSMI;
        private ToolStripMenuItem aboutTSMI;
        private ToolStripMenuItem gitTSMI;
        private ToolStripMenuItem creditsTSMI;
        private ToolStripSeparator editTSS1;
        private ToolStripSeparator editTSS2;
        private ToolStripMenuItem themeTSMI;
        private RichTextBox mainRTB;
        private ToolStripMenuItem barbiegirlTSMI;
        private ToolStripMenuItem acidpunkTSMI;
        private ToolStripMenuItem blackandwhiteTSMI;
        private ToolStripMenuItem grootTSMI;
        private ToolStripMenuItem muricaTSMI;
        private FontDialog fontDialog;
        private PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private MenuStrip fakeMenuStrip;
        private ToolStripMenuItem encodingTSMI;
        private ToolStripMenuItem convertToolStripMenuItem;
        private ToolStripMenuItem encodeToolStripMenuItem;
        private ToolStripMenuItem decodeToolStripMenuItem;
        private TextBox infoTB;
        private GripControl gripControl1;
    }
}