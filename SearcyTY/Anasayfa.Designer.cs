namespace SearcyTY
{
    partial class SearchTY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchTY));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Lbl_total_Search = new System.Windows.Forms.Label();
            this.LB_Products_links = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_Searching = new System.Windows.Forms.Label();
            this.CW = new CefSharp.WinForms.ChromiumWebBrowser();
            this.Timer_TM = new System.Windows.Forms.Timer(this.components);
            this.Timer_Git = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_Total_Products = new System.Windows.Forms.Label();
            this.S1 = new System.Windows.Forms.TextBox();
            this.S2 = new System.Windows.Forms.TextBox();
            this.S3 = new System.Windows.Forms.TextBox();
            this.LB_ProductId = new System.Windows.Forms.ListBox();
            this.Lbl_Control = new System.Windows.Forms.Label();
            this.Timer_Control = new System.Windows.Forms.Timer(this.components);
            this.TY_Magaza_Name = new System.Windows.Forms.TextBox();
            this.TY_Magaza_Id = new System.Windows.Forms.TextBox();
            this.GB_Group = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TM_Progress = new System.Windows.Forms.Timer(this.components);
            this.Txt_SearchCode1 = new System.Windows.Forms.TextBox();
            this.Txt_SearchCode_barcode = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.GB_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = global::SearcyTY.Properties.Resources.icons8_home_40;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::SearcyTY.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Btn_Start
            // 
            this.Btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Start.Location = new System.Drawing.Point(179, 189);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(104, 38);
            this.Btn_Start.TabIndex = 1;
            this.Btn_Start.Text = "Başlat";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Lbl_total_Search
            // 
            this.Lbl_total_Search.AutoSize = true;
            this.Lbl_total_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_total_Search.Location = new System.Drawing.Point(125, 67);
            this.Lbl_total_Search.Name = "Lbl_total_Search";
            this.Lbl_total_Search.Size = new System.Drawing.Size(15, 16);
            this.Lbl_total_Search.TabIndex = 2;
            this.Lbl_total_Search.Text = "0";
            // 
            // LB_Products_links
            // 
            this.LB_Products_links.FormattingEnabled = true;
            this.LB_Products_links.Location = new System.Drawing.Point(103, 189);
            this.LB_Products_links.Name = "LB_Products_links";
            this.LB_Products_links.Size = new System.Drawing.Size(64, 56);
            this.LB_Products_links.TabIndex = 3;
            this.LB_Products_links.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toplam Tarama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Taranan :";
            // 
            // Lbl_Searching
            // 
            this.Lbl_Searching.AutoSize = true;
            this.Lbl_Searching.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Searching.Location = new System.Drawing.Point(125, 127);
            this.Lbl_Searching.Name = "Lbl_Searching";
            this.Lbl_Searching.Size = new System.Drawing.Size(15, 16);
            this.Lbl_Searching.TabIndex = 5;
            this.Lbl_Searching.Text = "0";
            // 
            // CW
            // 
            this.CW.ActivateBrowserOnCreation = false;
            this.CW.Location = new System.Drawing.Point(3, 389);
            this.CW.Name = "CW";
            this.CW.Size = new System.Drawing.Size(651, 79);
            this.CW.TabIndex = 7;
            // 
            // Timer_TM
            // 
            this.Timer_TM.Interval = 1000;
            this.Timer_TM.Tick += new System.EventHandler(this.Timer_TM_Tick);
            // 
            // Timer_Git
            // 
            this.Timer_Git.Interval = 1000;
            this.Timer_Git.Tick += new System.EventHandler(this.Timer_Git_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Toplam Ürün :";
            // 
            // Lbl_Total_Products
            // 
            this.Lbl_Total_Products.AutoSize = true;
            this.Lbl_Total_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Total_Products.Location = new System.Drawing.Point(125, 97);
            this.Lbl_Total_Products.Name = "Lbl_Total_Products";
            this.Lbl_Total_Products.Size = new System.Drawing.Size(15, 16);
            this.Lbl_Total_Products.TabIndex = 8;
            this.Lbl_Total_Products.Text = "0";
            // 
            // S1
            // 
            this.S1.Location = new System.Drawing.Point(3, 313);
            this.S1.Name = "S1";
            this.S1.Size = new System.Drawing.Size(100, 20);
            this.S1.TabIndex = 14;
            this.S1.Text = "\"merchant\":{\"id\":";
            this.S1.Visible = false;
            // 
            // S2
            // 
            this.S2.Location = new System.Drawing.Point(3, 339);
            this.S2.Name = "S2";
            this.S2.Size = new System.Drawing.Size(100, 20);
            this.S2.TabIndex = 15;
            this.S2.Text = "\"name\":";
            this.S2.Visible = false;
            // 
            // S3
            // 
            this.S3.Location = new System.Drawing.Point(3, 363);
            this.S3.Name = "S3";
            this.S3.Size = new System.Drawing.Size(100, 20);
            this.S3.TabIndex = 16;
            this.S3.Text = ",\"quantity\"";
            this.S3.Visible = false;
            // 
            // LB_ProductId
            // 
            this.LB_ProductId.FormattingEnabled = true;
            this.LB_ProductId.Location = new System.Drawing.Point(6, 189);
            this.LB_ProductId.Name = "LB_ProductId";
            this.LB_ProductId.Size = new System.Drawing.Size(70, 56);
            this.LB_ProductId.TabIndex = 17;
            this.LB_ProductId.Visible = false;
            // 
            // Lbl_Control
            // 
            this.Lbl_Control.AutoSize = true;
            this.Lbl_Control.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Control.Location = new System.Drawing.Point(21, 462);
            this.Lbl_Control.Name = "Lbl_Control";
            this.Lbl_Control.Size = new System.Drawing.Size(15, 16);
            this.Lbl_Control.TabIndex = 18;
            this.Lbl_Control.Text = "0";
            this.Lbl_Control.Click += new System.EventHandler(this.Lbl_Control_Click);
            // 
            // Timer_Control
            // 
            this.Timer_Control.Interval = 1000;
            this.Timer_Control.Tick += new System.EventHandler(this.Timer_Control_Tick);
            // 
            // TY_Magaza_Name
            // 
            this.TY_Magaza_Name.Location = new System.Drawing.Point(3, 522);
            this.TY_Magaza_Name.Name = "TY_Magaza_Name";
            this.TY_Magaza_Name.Size = new System.Drawing.Size(100, 20);
            this.TY_Magaza_Name.TabIndex = 20;
            this.TY_Magaza_Name.Text = "elitesepet";
            this.TY_Magaza_Name.Visible = false;
            // 
            // TY_Magaza_Id
            // 
            this.TY_Magaza_Id.Location = new System.Drawing.Point(3, 498);
            this.TY_Magaza_Id.Name = "TY_Magaza_Id";
            this.TY_Magaza_Id.Size = new System.Drawing.Size(100, 20);
            this.TY_Magaza_Id.TabIndex = 21;
            this.TY_Magaza_Id.Text = "176850";
            this.TY_Magaza_Id.Visible = false;
            // 
            // GB_Group
            // 
            this.GB_Group.Controls.Add(this.label4);
            this.GB_Group.Controls.Add(this.progressBar1);
            this.GB_Group.Location = new System.Drawing.Point(12, 12);
            this.GB_Group.Name = "GB_Group";
            this.GB_Group.Size = new System.Drawing.Size(349, 153);
            this.GB_Group.TabIndex = 22;
            this.GB_Group.TabStop = false;
            this.GB_Group.Text = "Bekleyin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ürünler Yükleniyor Lütfen Bekleyin...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 59);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(337, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // TM_Progress
            // 
            this.TM_Progress.Tick += new System.EventHandler(this.TM_Progress_Tick);
            // 
            // Txt_SearchCode1
            // 
            this.Txt_SearchCode1.Location = new System.Drawing.Point(3, 258);
            this.Txt_SearchCode1.Name = "Txt_SearchCode1";
            this.Txt_SearchCode1.Size = new System.Drawing.Size(100, 20);
            this.Txt_SearchCode1.TabIndex = 23;
            this.Txt_SearchCode1.Text = ",\"sku\":";
            this.Txt_SearchCode1.Visible = false;
            // 
            // Txt_SearchCode_barcode
            // 
            this.Txt_SearchCode_barcode.Location = new System.Drawing.Point(3, 284);
            this.Txt_SearchCode_barcode.Name = "Txt_SearchCode_barcode";
            this.Txt_SearchCode_barcode.Size = new System.Drawing.Size(100, 20);
            this.Txt_SearchCode_barcode.TabIndex = 23;
            this.Txt_SearchCode_barcode.Text = "\"barcode\"";
            this.Txt_SearchCode_barcode.Visible = false;
            // 
            // SearchTY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 167);
            this.Controls.Add(this.Txt_SearchCode_barcode);
            this.Controls.Add(this.Txt_SearchCode1);
            this.Controls.Add(this.GB_Group);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.TY_Magaza_Name);
            this.Controls.Add(this.TY_Magaza_Id);
            this.Controls.Add(this.Lbl_Control);
            this.Controls.Add(this.LB_ProductId);
            this.Controls.Add(this.S1);
            this.Controls.Add(this.S2);
            this.Controls.Add(this.S3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lbl_Total_Products);
            this.Controls.Add(this.CW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_Searching);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_Products_links);
            this.Controls.Add(this.Lbl_total_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SearchTY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SearchTY";
            this.Load += new System.EventHandler(this.SearchTY_Load);
            this.Move += new System.EventHandler(this.SearchTY_Move);
            this.contextMenuStrip1.ResumeLayout(false);
            this.GB_Group.ResumeLayout(false);
            this.GB_Group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Label Lbl_total_Search;
        private System.Windows.Forms.ListBox LB_Products_links;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_Searching;
        private CefSharp.WinForms.ChromiumWebBrowser CW;
        private System.Windows.Forms.Timer Timer_TM;
        private System.Windows.Forms.Timer Timer_Git;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_Total_Products;
        private System.Windows.Forms.TextBox S1;
        private System.Windows.Forms.TextBox S2;
        private System.Windows.Forms.TextBox S3;
        private System.Windows.Forms.ListBox LB_ProductId;
        private System.Windows.Forms.Label Lbl_Control;
        private System.Windows.Forms.Timer Timer_Control;
        private System.Windows.Forms.TextBox TY_Magaza_Name;
        private System.Windows.Forms.TextBox TY_Magaza_Id;
        private System.Windows.Forms.GroupBox GB_Group;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer TM_Progress;
        private System.Windows.Forms.TextBox Txt_SearchCode1;
        private System.Windows.Forms.TextBox Txt_SearchCode_barcode;
    }
}

