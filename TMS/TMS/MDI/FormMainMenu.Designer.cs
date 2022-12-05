namespace TMS.MDI
{
    partial class FormMainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lbllogout = new System.Windows.Forms.Label();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.picemp = new System.Windows.Forms.PictureBox();
            this.lblmenu = new System.Windows.Forms.Label();
            this.Menubutton = new System.Windows.Forms.PictureBox();
            this.HomeContainer = new System.Windows.Forms.Panel();
            this.panelTC = new System.Windows.Forms.Panel();
            this.btngrouptask = new System.Windows.Forms.Button();
            this.panelTS = new System.Windows.Forms.Panel();
            this.btnteamregister = new System.Windows.Forms.Button();
            this.HomeChildContainer = new System.Windows.Forms.Panel();
            this.btnmasterdata = new System.Windows.Forms.Button();
            this.panelTS1 = new System.Windows.Forms.Panel();
            this.btntasksheet = new System.Windows.Forms.Button();
            this.panelTC1 = new System.Windows.Forms.Panel();
            this.btntaskcalender = new System.Windows.Forms.Button();
            this.panelReportAnalysis = new System.Windows.Forms.Panel();
            this.panelTG = new System.Windows.Forms.Panel();
            this.btnTG = new System.Windows.Forms.Button();
            this.panelteam = new System.Windows.Forms.Panel();
            this.btnteam = new System.Windows.Forms.Button();
            this.panelTGvsT = new System.Windows.Forms.Panel();
            this.btnTGVT = new System.Windows.Forms.Button();
            this.panelTvsTG = new System.Windows.Forms.Panel();
            this.btnTVTG = new System.Windows.Forms.Button();
            this.panelRanalysis = new System.Windows.Forms.Panel();
            this.btnreportanalysis = new System.Windows.Forms.Button();
            this.Sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.paneltitlebar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnclosechildform = new System.Windows.Forms.Button();
            this.labeltitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.picboxMDIImage = new System.Windows.Forms.PictureBox();
            this.HomeTimer = new System.Windows.Forms.Timer(this.components);
            this.ReportTimer = new System.Windows.Forms.Timer(this.components);
            this.Sidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menubutton)).BeginInit();
            this.HomeContainer.SuspendLayout();
            this.panelTC.SuspendLayout();
            this.panelTS.SuspendLayout();
            this.HomeChildContainer.SuspendLayout();
            this.panelTS1.SuspendLayout();
            this.panelTC1.SuspendLayout();
            this.panelReportAnalysis.SuspendLayout();
            this.panelTG.SuspendLayout();
            this.panelteam.SuspendLayout();
            this.panelTGvsT.SuspendLayout();
            this.panelTvsTG.SuspendLayout();
            this.panelRanalysis.SuspendLayout();
            this.paneltitlebar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMDIImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Sidebar.Controls.Add(this.panelLogo);
            this.Sidebar.Controls.Add(this.HomeContainer);
            this.Sidebar.Controls.Add(this.panelTS1);
            this.Sidebar.Controls.Add(this.panelTC1);
            this.Sidebar.Controls.Add(this.panelReportAnalysis);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.MaximumSize = new System.Drawing.Size(245, 678);
            this.Sidebar.MinimumSize = new System.Drawing.Size(70, 678);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(245, 678);
            this.Sidebar.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lbllogout);
            this.panelLogo.Controls.Add(this.lblwelcome);
            this.panelLogo.Controls.Add(this.picemp);
            this.panelLogo.Controls.Add(this.lblmenu);
            this.panelLogo.Controls.Add(this.Menubutton);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(240, 120);
            this.panelLogo.TabIndex = 1;
            // 
            // lbllogout
            // 
            this.lbllogout.AutoSize = true;
            this.lbllogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbllogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogout.ForeColor = System.Drawing.Color.White;
            this.lbllogout.Location = new System.Drawing.Point(68, 52);
            this.lbllogout.Name = "lbllogout";
            this.lbllogout.Size = new System.Drawing.Size(66, 21);
            this.lbllogout.TabIndex = 5;
            this.lbllogout.Text = "Logout?";
            this.lbllogout.Click += new System.EventHandler(this.lbllogout_Click);
            this.lbllogout.MouseEnter += new System.EventHandler(this.lbllogout_MouseEnter);
            this.lbllogout.MouseLeave += new System.EventHandler(this.lbllogout_MouseLeave);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblwelcome.ForeColor = System.Drawing.Color.White;
            this.lblwelcome.Location = new System.Drawing.Point(68, 6);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(52, 21);
            this.lblwelcome.TabIndex = 4;
            this.lblwelcome.Text = "label1";
            this.lblwelcome.MouseEnter += new System.EventHandler(this.lblwelcome_MouseEnter);
            this.lblwelcome.MouseLeave += new System.EventHandler(this.lblwelcome_MouseLeave);
            // 
            // picemp
            // 
            this.picemp.Location = new System.Drawing.Point(4, 3);
            this.picemp.Name = "picemp";
            this.picemp.Size = new System.Drawing.Size(59, 59);
            this.picemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picemp.TabIndex = 3;
            this.picemp.TabStop = false;
            // 
            // lblmenu
            // 
            this.lblmenu.AutoSize = true;
            this.lblmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblmenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenu.ForeColor = System.Drawing.Color.White;
            this.lblmenu.Location = new System.Drawing.Point(68, 88);
            this.lblmenu.Name = "lblmenu";
            this.lblmenu.Size = new System.Drawing.Size(50, 21);
            this.lblmenu.TabIndex = 2;
            this.lblmenu.Text = "Menu";
            this.lblmenu.MouseEnter += new System.EventHandler(this.labelmenu_MouseEnter);
            this.lblmenu.MouseLeave += new System.EventHandler(this.labelmenu_MouseLeave);
            // 
            // Menubutton
            // 
            this.Menubutton.Image = ((System.Drawing.Image)(resources.GetObject("Menubutton.Image")));
            this.Menubutton.Location = new System.Drawing.Point(4, 82);
            this.Menubutton.Name = "Menubutton";
            this.Menubutton.Size = new System.Drawing.Size(48, 30);
            this.Menubutton.TabIndex = 1;
            this.Menubutton.TabStop = false;
            this.Menubutton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HomeContainer
            // 
            this.HomeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.HomeContainer.Controls.Add(this.panelTC);
            this.HomeContainer.Controls.Add(this.panelTS);
            this.HomeContainer.Controls.Add(this.HomeChildContainer);
            this.HomeContainer.Location = new System.Drawing.Point(3, 129);
            this.HomeContainer.MaximumSize = new System.Drawing.Size(241, 143);
            this.HomeContainer.MinimumSize = new System.Drawing.Size(241, 56);
            this.HomeContainer.Name = "HomeContainer";
            this.HomeContainer.Size = new System.Drawing.Size(241, 56);
            this.HomeContainer.TabIndex = 6;
            // 
            // panelTC
            // 
            this.panelTC.BackColor = System.Drawing.Color.White;
            this.panelTC.Controls.Add(this.btngrouptask);
            this.panelTC.Location = new System.Drawing.Point(1, 93);
            this.panelTC.MaximumSize = new System.Drawing.Size(241, 92);
            this.panelTC.MinimumSize = new System.Drawing.Size(241, 50);
            this.panelTC.Name = "panelTC";
            this.panelTC.Size = new System.Drawing.Size(241, 50);
            this.panelTC.TabIndex = 8;
            // 
            // btngrouptask
            // 
            this.btngrouptask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btngrouptask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngrouptask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrouptask.ForeColor = System.Drawing.Color.White;
            this.btngrouptask.Image = ((System.Drawing.Image)(resources.GetObject("btngrouptask.Image")));
            this.btngrouptask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrouptask.Location = new System.Drawing.Point(-1, -1);
            this.btngrouptask.Name = "btngrouptask";
            this.btngrouptask.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btngrouptask.Size = new System.Drawing.Size(245, 57);
            this.btngrouptask.TabIndex = 2;
            this.btngrouptask.Text = "             Task Management";
            this.btngrouptask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngrouptask.UseVisualStyleBackColor = false;
            this.btngrouptask.Click += new System.EventHandler(this.btngrouptask_Click);
            // 
            // panelTS
            // 
            this.panelTS.BackColor = System.Drawing.Color.White;
            this.panelTS.Controls.Add(this.btnteamregister);
            this.panelTS.Location = new System.Drawing.Point(1, 55);
            this.panelTS.MaximumSize = new System.Drawing.Size(241, 92);
            this.panelTS.MinimumSize = new System.Drawing.Size(241, 50);
            this.panelTS.Name = "panelTS";
            this.panelTS.Size = new System.Drawing.Size(241, 50);
            this.panelTS.TabIndex = 7;
            // 
            // btnteamregister
            // 
            this.btnteamregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnteamregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnteamregister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteamregister.ForeColor = System.Drawing.Color.White;
            this.btnteamregister.Image = ((System.Drawing.Image)(resources.GetObject("btnteamregister.Image")));
            this.btnteamregister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnteamregister.Location = new System.Drawing.Point(-1, -4);
            this.btnteamregister.Name = "btnteamregister";
            this.btnteamregister.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnteamregister.Size = new System.Drawing.Size(245, 57);
            this.btnteamregister.TabIndex = 2;
            this.btnteamregister.Text = "             Team Management";
            this.btnteamregister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnteamregister.UseVisualStyleBackColor = false;
            this.btnteamregister.Click += new System.EventHandler(this.btnteamregister_Click);
            // 
            // HomeChildContainer
            // 
            this.HomeChildContainer.BackColor = System.Drawing.Color.White;
            this.HomeChildContainer.Controls.Add(this.btnmasterdata);
            this.HomeChildContainer.Location = new System.Drawing.Point(1, 3);
            this.HomeChildContainer.MaximumSize = new System.Drawing.Size(241, 92);
            this.HomeChildContainer.MinimumSize = new System.Drawing.Size(241, 50);
            this.HomeChildContainer.Name = "HomeChildContainer";
            this.HomeChildContainer.Size = new System.Drawing.Size(241, 50);
            this.HomeChildContainer.TabIndex = 5;
            // 
            // btnmasterdata
            // 
            this.btnmasterdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnmasterdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmasterdata.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmasterdata.ForeColor = System.Drawing.Color.White;
            this.btnmasterdata.Image = ((System.Drawing.Image)(resources.GetObject("btnmasterdata.Image")));
            this.btnmasterdata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmasterdata.Location = new System.Drawing.Point(-1, -1);
            this.btnmasterdata.Name = "btnmasterdata";
            this.btnmasterdata.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnmasterdata.Size = new System.Drawing.Size(245, 52);
            this.btnmasterdata.TabIndex = 2;
            this.btnmasterdata.Text = "             Master Data";
            this.btnmasterdata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmasterdata.UseVisualStyleBackColor = false;
            this.btnmasterdata.Click += new System.EventHandler(this.btnmasterdata_Click);
            // 
            // panelTS1
            // 
            this.panelTS1.Controls.Add(this.btntasksheet);
            this.panelTS1.Location = new System.Drawing.Point(3, 191);
            this.panelTS1.Name = "panelTS1";
            this.panelTS1.Size = new System.Drawing.Size(242, 37);
            this.panelTS1.TabIndex = 4;
            // 
            // btntasksheet
            // 
            this.btntasksheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntasksheet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntasksheet.ForeColor = System.Drawing.Color.White;
            this.btntasksheet.Image = ((System.Drawing.Image)(resources.GetObject("btntasksheet.Image")));
            this.btntasksheet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntasksheet.Location = new System.Drawing.Point(-1, -8);
            this.btntasksheet.Name = "btntasksheet";
            this.btntasksheet.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btntasksheet.Size = new System.Drawing.Size(245, 52);
            this.btntasksheet.TabIndex = 2;
            this.btntasksheet.Text = "             Task Sheet";
            this.btntasksheet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntasksheet.UseVisualStyleBackColor = true;
            this.btntasksheet.Click += new System.EventHandler(this.btntasksheet_Click);
            // 
            // panelTC1
            // 
            this.panelTC1.Controls.Add(this.btntaskcalender);
            this.panelTC1.Location = new System.Drawing.Point(3, 234);
            this.panelTC1.Name = "panelTC1";
            this.panelTC1.Size = new System.Drawing.Size(242, 37);
            this.panelTC1.TabIndex = 2;
            // 
            // btntaskcalender
            // 
            this.btntaskcalender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntaskcalender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaskcalender.ForeColor = System.Drawing.Color.White;
            this.btntaskcalender.Image = ((System.Drawing.Image)(resources.GetObject("btntaskcalender.Image")));
            this.btntaskcalender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntaskcalender.Location = new System.Drawing.Point(-1, -8);
            this.btntaskcalender.Name = "btntaskcalender";
            this.btntaskcalender.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btntaskcalender.Size = new System.Drawing.Size(245, 52);
            this.btntaskcalender.TabIndex = 2;
            this.btntaskcalender.Text = "             Task Calender";
            this.btntaskcalender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntaskcalender.UseVisualStyleBackColor = true;
            this.btntaskcalender.Click += new System.EventHandler(this.btntaskcalender_Click);
            // 
            // panelReportAnalysis
            // 
            this.panelReportAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.panelReportAnalysis.Controls.Add(this.panelTG);
            this.panelReportAnalysis.Controls.Add(this.panelteam);
            this.panelReportAnalysis.Controls.Add(this.panelTGvsT);
            this.panelReportAnalysis.Controls.Add(this.panelTvsTG);
            this.panelReportAnalysis.Controls.Add(this.panelRanalysis);
            this.panelReportAnalysis.Location = new System.Drawing.Point(3, 277);
            this.panelReportAnalysis.MaximumSize = new System.Drawing.Size(241, 226);
            this.panelReportAnalysis.MinimumSize = new System.Drawing.Size(241, 54);
            this.panelReportAnalysis.Name = "panelReportAnalysis";
            this.panelReportAnalysis.Size = new System.Drawing.Size(241, 54);
            this.panelReportAnalysis.TabIndex = 7;
            this.panelReportAnalysis.Paint += new System.Windows.Forms.PaintEventHandler(this.panelReportAnalysis_Paint);
            // 
            // panelTG
            // 
            this.panelTG.BackColor = System.Drawing.Color.White;
            this.panelTG.Controls.Add(this.btnTG);
            this.panelTG.Location = new System.Drawing.Point(0, 175);
            this.panelTG.MaximumSize = new System.Drawing.Size(241, 92);
            this.panelTG.MinimumSize = new System.Drawing.Size(241, 50);
            this.panelTG.Name = "panelTG";
            this.panelTG.Size = new System.Drawing.Size(241, 50);
            this.panelTG.TabIndex = 10;
            // 
            // btnTG
            // 
            this.btnTG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTG.ForeColor = System.Drawing.Color.White;
            this.btnTG.Image = ((System.Drawing.Image)(resources.GetObject("btnTG.Image")));
            this.btnTG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTG.Location = new System.Drawing.Point(-1, -1);
            this.btnTG.Name = "btnTG";
            this.btnTG.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnTG.Size = new System.Drawing.Size(245, 57);
            this.btnTG.TabIndex = 2;
            this.btnTG.Text = "             TaskGroup";
            this.btnTG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTG.UseVisualStyleBackColor = false;
            this.btnTG.Click += new System.EventHandler(this.btnTG_Click);
            // 
            // panelteam
            // 
            this.panelteam.BackColor = System.Drawing.Color.White;
            this.panelteam.Controls.Add(this.btnteam);
            this.panelteam.Location = new System.Drawing.Point(0, 134);
            this.panelteam.MaximumSize = new System.Drawing.Size(241, 92);
            this.panelteam.MinimumSize = new System.Drawing.Size(241, 50);
            this.panelteam.Name = "panelteam";
            this.panelteam.Size = new System.Drawing.Size(241, 50);
            this.panelteam.TabIndex = 9;
            // 
            // btnteam
            // 
            this.btnteam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnteam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnteam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteam.ForeColor = System.Drawing.Color.White;
            this.btnteam.Image = ((System.Drawing.Image)(resources.GetObject("btnteam.Image")));
            this.btnteam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnteam.Location = new System.Drawing.Point(-1, -1);
            this.btnteam.Name = "btnteam";
            this.btnteam.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnteam.Size = new System.Drawing.Size(245, 57);
            this.btnteam.TabIndex = 2;
            this.btnteam.Text = "             Team";
            this.btnteam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnteam.UseVisualStyleBackColor = false;
            this.btnteam.Click += new System.EventHandler(this.btnteam_Click);
            // 
            // panelTGvsT
            // 
            this.panelTGvsT.BackColor = System.Drawing.Color.White;
            this.panelTGvsT.Controls.Add(this.btnTGVT);
            this.panelTGvsT.Location = new System.Drawing.Point(1, 93);
            this.panelTGvsT.MaximumSize = new System.Drawing.Size(241, 92);
            this.panelTGvsT.MinimumSize = new System.Drawing.Size(241, 50);
            this.panelTGvsT.Name = "panelTGvsT";
            this.panelTGvsT.Size = new System.Drawing.Size(241, 50);
            this.panelTGvsT.TabIndex = 8;
            // 
            // btnTGVT
            // 
            this.btnTGVT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnTGVT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTGVT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTGVT.ForeColor = System.Drawing.Color.White;
            this.btnTGVT.Image = ((System.Drawing.Image)(resources.GetObject("btnTGVT.Image")));
            this.btnTGVT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTGVT.Location = new System.Drawing.Point(-1, -1);
            this.btnTGVT.Name = "btnTGVT";
            this.btnTGVT.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnTGVT.Size = new System.Drawing.Size(245, 57);
            this.btnTGVT.TabIndex = 2;
            this.btnTGVT.Text = "             Task Group Vs Team";
            this.btnTGVT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTGVT.UseVisualStyleBackColor = false;
            this.btnTGVT.Click += new System.EventHandler(this.btnTGVT_Click);
            // 
            // panelTvsTG
            // 
            this.panelTvsTG.BackColor = System.Drawing.Color.White;
            this.panelTvsTG.Controls.Add(this.btnTVTG);
            this.panelTvsTG.Location = new System.Drawing.Point(1, 55);
            this.panelTvsTG.MaximumSize = new System.Drawing.Size(241, 92);
            this.panelTvsTG.MinimumSize = new System.Drawing.Size(241, 50);
            this.panelTvsTG.Name = "panelTvsTG";
            this.panelTvsTG.Size = new System.Drawing.Size(241, 50);
            this.panelTvsTG.TabIndex = 7;
            // 
            // btnTVTG
            // 
            this.btnTVTG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnTVTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTVTG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTVTG.ForeColor = System.Drawing.Color.White;
            this.btnTVTG.Image = ((System.Drawing.Image)(resources.GetObject("btnTVTG.Image")));
            this.btnTVTG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTVTG.Location = new System.Drawing.Point(-1, -4);
            this.btnTVTG.Name = "btnTVTG";
            this.btnTVTG.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnTVTG.Size = new System.Drawing.Size(245, 57);
            this.btnTVTG.TabIndex = 2;
            this.btnTVTG.Text = "             Team Vs Task Group";
            this.btnTVTG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTVTG.UseVisualStyleBackColor = false;
            this.btnTVTG.Click += new System.EventHandler(this.btnTVTG_Click);
            // 
            // panelRanalysis
            // 
            this.panelRanalysis.BackColor = System.Drawing.Color.White;
            this.panelRanalysis.Controls.Add(this.btnreportanalysis);
            this.panelRanalysis.Location = new System.Drawing.Point(1, 3);
            this.panelRanalysis.MaximumSize = new System.Drawing.Size(241, 92);
            this.panelRanalysis.MinimumSize = new System.Drawing.Size(241, 50);
            this.panelRanalysis.Name = "panelRanalysis";
            this.panelRanalysis.Size = new System.Drawing.Size(241, 50);
            this.panelRanalysis.TabIndex = 5;
            // 
            // btnreportanalysis
            // 
            this.btnreportanalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnreportanalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreportanalysis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportanalysis.ForeColor = System.Drawing.Color.White;
            this.btnreportanalysis.Image = ((System.Drawing.Image)(resources.GetObject("btnreportanalysis.Image")));
            this.btnreportanalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreportanalysis.Location = new System.Drawing.Point(-1, -1);
            this.btnreportanalysis.Name = "btnreportanalysis";
            this.btnreportanalysis.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnreportanalysis.Size = new System.Drawing.Size(245, 52);
            this.btnreportanalysis.TabIndex = 2;
            this.btnreportanalysis.Text = "             Report Analysis";
            this.btnreportanalysis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreportanalysis.UseVisualStyleBackColor = false;
            this.btnreportanalysis.Click += new System.EventHandler(this.btnreportanalysis_Click);
            // 
            // Sidebartimer
            // 
            this.Sidebartimer.Interval = 10;
            this.Sidebartimer.Tick += new System.EventHandler(this.Sidebartimer_Tick);
            // 
            // paneltitlebar
            // 
            this.paneltitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.paneltitlebar.Controls.Add(this.btnMinimize);
            this.paneltitlebar.Controls.Add(this.btnMaximize);
            this.paneltitlebar.Controls.Add(this.btnclose);
            this.paneltitlebar.Controls.Add(this.btnclosechildform);
            this.paneltitlebar.Controls.Add(this.labeltitle);
            this.paneltitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitlebar.Location = new System.Drawing.Point(245, 0);
            this.paneltitlebar.Name = "paneltitlebar";
            this.paneltitlebar.Size = new System.Drawing.Size(899, 65);
            this.paneltitlebar.TabIndex = 1;
            this.paneltitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltitlebar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(822, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(845, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(869, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(30, 30);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "O";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnclosechildform
            // 
            this.btnclosechildform.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnclosechildform.FlatAppearance.BorderSize = 0;
            this.btnclosechildform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclosechildform.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclosechildform.ForeColor = System.Drawing.Color.White;
            this.btnclosechildform.Location = new System.Drawing.Point(0, 0);
            this.btnclosechildform.Name = "btnclosechildform";
            this.btnclosechildform.Size = new System.Drawing.Size(75, 65);
            this.btnclosechildform.TabIndex = 1;
            this.btnclosechildform.Text = "X";
            this.btnclosechildform.UseVisualStyleBackColor = true;
            this.btnclosechildform.Click += new System.EventHandler(this.btnclosechildform_Click);
            // 
            // labeltitle
            // 
            this.labeltitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.ForeColor = System.Drawing.Color.White;
            this.labeltitle.Location = new System.Drawing.Point(371, 14);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(78, 26);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.picboxMDIImage);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(245, 65);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(899, 613);
            this.panelDesktopPanel.TabIndex = 2;
            this.panelDesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPanel_Paint);
            // 
            // picboxMDIImage
            // 
            this.picboxMDIImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picboxMDIImage.Image = ((System.Drawing.Image)(resources.GetObject("picboxMDIImage.Image")));
            this.picboxMDIImage.Location = new System.Drawing.Point(0, 0);
            this.picboxMDIImage.Name = "picboxMDIImage";
            this.picboxMDIImage.Size = new System.Drawing.Size(899, 613);
            this.picboxMDIImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxMDIImage.TabIndex = 0;
            this.picboxMDIImage.TabStop = false;
            // 
            // HomeTimer
            // 
            this.HomeTimer.Interval = 10;
            this.HomeTimer.Tick += new System.EventHandler(this.HomeTimer_Tick);
            // 
            // ReportTimer
            // 
            this.ReportTimer.Interval = 10;
            this.ReportTimer.Tick += new System.EventHandler(this.ReportTimer_Tick);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 678);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.paneltitlebar);
            this.Controls.Add(this.Sidebar);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Management System";
            this.Sidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menubutton)).EndInit();
            this.HomeContainer.ResumeLayout(false);
            this.panelTC.ResumeLayout(false);
            this.panelTS.ResumeLayout(false);
            this.HomeChildContainer.ResumeLayout(false);
            this.panelTS1.ResumeLayout(false);
            this.panelTC1.ResumeLayout(false);
            this.panelReportAnalysis.ResumeLayout(false);
            this.panelTG.ResumeLayout(false);
            this.panelteam.ResumeLayout(false);
            this.panelTGvsT.ResumeLayout(false);
            this.panelTvsTG.ResumeLayout(false);
            this.panelRanalysis.ResumeLayout(false);
            this.paneltitlebar.ResumeLayout(false);
            this.paneltitlebar.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxMDIImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnmasterdata;
        private System.Windows.Forms.Panel panelTC1;
        private System.Windows.Forms.Button btntaskcalender;
        private System.Windows.Forms.Panel panelTS1;
        private System.Windows.Forms.Button btntasksheet;
        private System.Windows.Forms.Label lblmenu;
        private System.Windows.Forms.PictureBox Menubutton;
        private System.Windows.Forms.Timer Sidebartimer;
        private System.Windows.Forms.Panel paneltitlebar;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnclosechildform;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Timer HomeTimer;
        private System.Windows.Forms.Panel HomeContainer;
        private System.Windows.Forms.Panel panelTS;
        private System.Windows.Forms.Button btnteamregister;
        private System.Windows.Forms.Panel HomeChildContainer;
        private System.Windows.Forms.Panel panelTC;
        private System.Windows.Forms.Button btngrouptask;
        private System.Windows.Forms.Panel panelReportAnalysis;
        private System.Windows.Forms.Panel panelteam;
        private System.Windows.Forms.Button btnteam;
        private System.Windows.Forms.Panel panelTGvsT;
        private System.Windows.Forms.Button btnTGVT;
        private System.Windows.Forms.Panel panelTvsTG;
        private System.Windows.Forms.Button btnTVTG;
        private System.Windows.Forms.Panel panelRanalysis;
        private System.Windows.Forms.Button btnreportanalysis;
        private System.Windows.Forms.Panel panelTG;
        private System.Windows.Forms.Button btnTG;
        private System.Windows.Forms.Timer ReportTimer;
        private System.Windows.Forms.PictureBox picboxMDIImage;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.PictureBox picemp;
        private System.Windows.Forms.Label lbllogout;
    }
}