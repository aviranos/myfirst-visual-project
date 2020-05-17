namespace CarProjectV1
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnAddNewCarMain = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.אדותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מאפייניםToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.סגורToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEST1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEST2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הוספהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מכוניתחדשהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.קונהחדשToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.רשימותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.סטטיסטיקותToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הוספהלמאגרToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.חיפושToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מכוניתToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.קונהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מוכרToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOutMain = new System.Windows.Forms.Button();
            this.icoEXIT = new System.Windows.Forms.PictureBox();
            this.icoMIN = new System.Windows.Forms.PictureBox();
            this.icoMAX = new System.Windows.Forms.PictureBox();
            this.icoMINW = new System.Windows.Forms.PictureBox();
            this.panelCONTROL = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoEXIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMINW)).BeginInit();
            this.panelCONTROL.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // lblLogo
            // 
            resources.ApplyResources(this.lblLogo, "lblLogo");
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.ForeColor = System.Drawing.Color.Gold;
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddNewCarMain
            // 
            this.btnAddNewCarMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(179)))), ((int)(((byte)(87)))));
            this.btnAddNewCarMain.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnAddNewCarMain, "btnAddNewCarMain");
            this.btnAddNewCarMain.Image = global::CarProjectV1.Properties.Resources.icons8_car_48;
            this.btnAddNewCarMain.Name = "btnAddNewCarMain";
            this.btnAddNewCarMain.UseVisualStyleBackColor = false;
            this.btnAddNewCarMain.Click += new System.EventHandler(this.btnAddNewCarMain_Click);
            this.btnAddNewCarMain.MouseLeave += new System.EventHandler(this.btnAddNewCarMain_MouseDown);
            this.btnAddNewCarMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAddNewCarMain_MouseUp);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(138)))), ((int)(((byte)(183)))));
            resources.ApplyResources(this.button3, "button3");
            this.button3.Image = global::CarProjectV1.Properties.Resources.icons8_search_48;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            resources.ApplyResources(this.button5, "button5");
            this.button5.Image = global::CarProjectV1.Properties.Resources.icons8_bulleted_list_48;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.הוספהToolStripMenuItem,
            this.חיפושToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.fileToolStripMenuItem.AutoToolTip = true;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.אדותToolStripMenuItem,
            this.מאפייניםToolStripMenuItem,
            this.סגורToolStripMenuItem,
            this.tEST1ToolStripMenuItem,
            this.tEST2ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // אדותToolStripMenuItem
            // 
            this.אדותToolStripMenuItem.Name = "אדותToolStripMenuItem";
            resources.ApplyResources(this.אדותToolStripMenuItem, "אדותToolStripMenuItem");
            // 
            // מאפייניםToolStripMenuItem
            // 
            this.מאפייניםToolStripMenuItem.Name = "מאפייניםToolStripMenuItem";
            resources.ApplyResources(this.מאפייניםToolStripMenuItem, "מאפייניםToolStripMenuItem");
            // 
            // סגורToolStripMenuItem
            // 
            this.סגורToolStripMenuItem.Name = "סגורToolStripMenuItem";
            resources.ApplyResources(this.סגורToolStripMenuItem, "סגורToolStripMenuItem");
            this.סגורToolStripMenuItem.Click += new System.EventHandler(this.סגורToolStripMenuItem_Click);
            // 
            // tEST1ToolStripMenuItem
            // 
            this.tEST1ToolStripMenuItem.Name = "tEST1ToolStripMenuItem";
            resources.ApplyResources(this.tEST1ToolStripMenuItem, "tEST1ToolStripMenuItem");
            // 
            // tEST2ToolStripMenuItem
            // 
            this.tEST2ToolStripMenuItem.Name = "tEST2ToolStripMenuItem";
            resources.ApplyResources(this.tEST2ToolStripMenuItem, "tEST2ToolStripMenuItem");
            // 
            // הוספהToolStripMenuItem
            // 
            this.הוספהToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.מכוניתחדשהToolStripMenuItem,
            this.קונהחדשToolStripMenuItem,
            this.רשימותToolStripMenuItem,
            this.סטטיסטיקותToolStripMenuItem,
            this.הוספהלמאגרToolStripMenuItem});
            this.הוספהToolStripMenuItem.Name = "הוספהToolStripMenuItem";
            resources.ApplyResources(this.הוספהToolStripMenuItem, "הוספהToolStripMenuItem");
            // 
            // מכוניתחדשהToolStripMenuItem
            // 
            this.מכוניתחדשהToolStripMenuItem.Name = "מכוניתחדשהToolStripMenuItem";
            resources.ApplyResources(this.מכוניתחדשהToolStripMenuItem, "מכוניתחדשהToolStripMenuItem");
            this.מכוניתחדשהToolStripMenuItem.Click += new System.EventHandler(this.מכוניתחדשהToolStripMenuItem_Click);
            // 
            // קונהחדשToolStripMenuItem
            // 
            this.קונהחדשToolStripMenuItem.Name = "קונהחדשToolStripMenuItem";
            resources.ApplyResources(this.קונהחדשToolStripMenuItem, "קונהחדשToolStripMenuItem");
            // 
            // רשימותToolStripMenuItem
            // 
            this.רשימותToolStripMenuItem.Name = "רשימותToolStripMenuItem";
            resources.ApplyResources(this.רשימותToolStripMenuItem, "רשימותToolStripMenuItem");
            // 
            // סטטיסטיקותToolStripMenuItem
            // 
            this.סטטיסטיקותToolStripMenuItem.Name = "סטטיסטיקותToolStripMenuItem";
            resources.ApplyResources(this.סטטיסטיקותToolStripMenuItem, "סטטיסטיקותToolStripMenuItem");
            // 
            // הוספהלמאגרToolStripMenuItem
            // 
            this.הוספהלמאגרToolStripMenuItem.Name = "הוספהלמאגרToolStripMenuItem";
            resources.ApplyResources(this.הוספהלמאגרToolStripMenuItem, "הוספהלמאגרToolStripMenuItem");
            // 
            // חיפושToolStripMenuItem
            // 
            this.חיפושToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.מכוניתToolStripMenuItem,
            this.קונהToolStripMenuItem,
            this.מוכרToolStripMenuItem});
            this.חיפושToolStripMenuItem.Name = "חיפושToolStripMenuItem";
            resources.ApplyResources(this.חיפושToolStripMenuItem, "חיפושToolStripMenuItem");
            // 
            // מכוניתToolStripMenuItem
            // 
            this.מכוניתToolStripMenuItem.Name = "מכוניתToolStripMenuItem";
            resources.ApplyResources(this.מכוניתToolStripMenuItem, "מכוניתToolStripMenuItem");
            // 
            // קונהToolStripMenuItem
            // 
            this.קונהToolStripMenuItem.Name = "קונהToolStripMenuItem";
            resources.ApplyResources(this.קונהToolStripMenuItem, "קונהToolStripMenuItem");
            // 
            // מוכרToolStripMenuItem
            // 
            this.מוכרToolStripMenuItem.Name = "מוכרToolStripMenuItem";
            resources.ApplyResources(this.מוכרToolStripMenuItem, "מוכרToolStripMenuItem");
            // 
            // btnLogOutMain
            // 
            resources.ApplyResources(this.btnLogOutMain, "btnLogOutMain");
            this.btnLogOutMain.Name = "btnLogOutMain";
            this.btnLogOutMain.UseVisualStyleBackColor = true;
            // 
            // icoEXIT
            // 
            resources.ApplyResources(this.icoEXIT, "icoEXIT");
            this.icoEXIT.BackColor = System.Drawing.Color.Transparent;
            this.icoEXIT.ErrorImage = global::CarProjectV1.Properties.Resources.icons8_shutdown_32;
            this.icoEXIT.Image = global::CarProjectV1.Properties.Resources.icons8_shutdown_32;
            this.icoEXIT.Name = "icoEXIT";
            this.icoEXIT.TabStop = false;
            this.icoEXIT.Click += new System.EventHandler(this.icoEXIT_Click);
            // 
            // icoMIN
            // 
            resources.ApplyResources(this.icoMIN, "icoMIN");
            this.icoMIN.BackColor = System.Drawing.Color.Gold;
            this.icoMIN.Image = global::CarProjectV1.Properties.Resources.icons8_minimize_window_64;
            this.icoMIN.Name = "icoMIN";
            this.icoMIN.TabStop = false;
            // 
            // icoMAX
            // 
            resources.ApplyResources(this.icoMAX, "icoMAX");
            this.icoMAX.BackColor = System.Drawing.Color.LimeGreen;
            this.icoMAX.Image = global::CarProjectV1.Properties.Resources.icons8_maximize_button_64;
            this.icoMAX.Name = "icoMAX";
            this.icoMAX.TabStop = false;
            // 
            // icoMINW
            // 
            resources.ApplyResources(this.icoMINW, "icoMINW");
            this.icoMINW.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.icoMINW.Image = global::CarProjectV1.Properties.Resources.icons8_restore_down_64;
            this.icoMINW.Name = "icoMINW";
            this.icoMINW.TabStop = false;
            this.icoMINW.Click += new System.EventHandler(this.icoMINW_Click);
            // 
            // panelCONTROL
            // 
            this.panelCONTROL.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelCONTROL.BackColor = System.Drawing.Color.DimGray;
            this.panelCONTROL.Controls.Add(this.icoMINW);
            this.panelCONTROL.Controls.Add(this.menuStrip1);
            this.panelCONTROL.Controls.Add(this.icoMAX);
            this.panelCONTROL.Controls.Add(this.icoEXIT);
            this.panelCONTROL.Controls.Add(this.icoMIN);
            resources.ApplyResources(this.panelCONTROL, "panelCONTROL");
            this.panelCONTROL.Name = "panelCONTROL";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.panelCONTROL);
            this.Controls.Add(this.btnAddNewCarMain);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.btnLogOutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoEXIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMINW)).EndInit();
            this.panelCONTROL.ResumeLayout(false);
            this.panelCONTROL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnAddNewCarMain;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem אדותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מאפייניםToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem סגורToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEST1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEST2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem הוספהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מכוניתחדשהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem קונהחדשToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem רשימותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem סטטיסטיקותToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem הוספהלמאגרToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem חיפושToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מכוניתToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem קונהToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מוכרToolStripMenuItem;
        private System.Windows.Forms.Button btnLogOutMain;
        private System.Windows.Forms.PictureBox icoEXIT;
        private System.Windows.Forms.PictureBox icoMIN;
        private System.Windows.Forms.PictureBox icoMAX;
        private System.Windows.Forms.PictureBox icoMINW;
        private System.Windows.Forms.Panel panelCONTROL;
    }
}