namespace Scorecard.View
{
    partial class MainWindow
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
            this.uxMainMenu = new System.Windows.Forms.MenuStrip();
            this.uxFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxTabControl = new System.Windows.Forms.TabControl();
            this.uxCategoriesPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.uxMainMenu.SuspendLayout();
            this.uxTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMainMenu
            // 
            this.uxMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFileMenuItem});
            this.uxMainMenu.Location = new System.Drawing.Point(0, 0);
            this.uxMainMenu.Name = "uxMainMenu";
            this.uxMainMenu.Size = new System.Drawing.Size(737, 24);
            this.uxMainMenu.TabIndex = 0;
            // 
            // uxFileMenuItem
            // 
            this.uxFileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenMenuItem,
            this.uxSaveMenuItem,
            this.uxExitMenuItem});
            this.uxFileMenuItem.Name = "uxFileMenuItem";
            this.uxFileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.uxFileMenuItem.Text = "File";
            // 
            // uxOpenMenuItem
            // 
            this.uxOpenMenuItem.Name = "uxOpenMenuItem";
            this.uxOpenMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uxOpenMenuItem.Text = "Open";
            this.uxOpenMenuItem.Click += new System.EventHandler(this.uxOpenMenuItem_Click);
            // 
            // uxSaveMenuItem
            // 
            this.uxSaveMenuItem.Name = "uxSaveMenuItem";
            this.uxSaveMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uxSaveMenuItem.Text = "Save";
            this.uxSaveMenuItem.Click += new System.EventHandler(this.uxSaveMenuItem_Click);
            // 
            // uxExitMenuItem
            // 
            this.uxExitMenuItem.Name = "uxExitMenuItem";
            this.uxExitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uxExitMenuItem.Text = "Exit";
            this.uxExitMenuItem.Click += new System.EventHandler(this.uxExitMenuItem_Click);
            // 
            // uxTabControl
            // 
            this.uxTabControl.Controls.Add(this.uxCategoriesPage);
            this.uxTabControl.Controls.Add(this.tabPage2);
            this.uxTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxTabControl.Location = new System.Drawing.Point(0, 24);
            this.uxTabControl.Name = "uxTabControl";
            this.uxTabControl.SelectedIndex = 0;
            this.uxTabControl.Size = new System.Drawing.Size(737, 455);
            this.uxTabControl.TabIndex = 1;
            // 
            // uxCategoriesPage
            // 
            this.uxCategoriesPage.Location = new System.Drawing.Point(4, 22);
            this.uxCategoriesPage.Name = "uxCategoriesPage";
            this.uxCategoriesPage.Padding = new System.Windows.Forms.Padding(3);
            this.uxCategoriesPage.Size = new System.Drawing.Size(729, 429);
            this.uxCategoriesPage.TabIndex = 0;
            this.uxCategoriesPage.Text = "Categories";
            this.uxCategoriesPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(729, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 479);
            this.Controls.Add(this.uxTabControl);
            this.Controls.Add(this.uxMainMenu);
            this.MainMenuStrip = this.uxMainMenu;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.uxMainMenu.ResumeLayout(false);
            this.uxMainMenu.PerformLayout();
            this.uxTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMainMenu;
        private System.Windows.Forms.ToolStripMenuItem uxFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxOpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxSaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxExitMenuItem;
        private System.Windows.Forms.TabControl uxTabControl;
        private System.Windows.Forms.TabPage uxCategoriesPage;
        private System.Windows.Forms.TabPage tabPage2;
    }
}