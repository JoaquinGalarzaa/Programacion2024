namespace GOT_App
{
    partial class MenuPrincipal
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
            btnExit = new Button();
            menuStrip2 = new MenuStrip();
            gameOfThronesToolStripMenuItem = new ToolStripMenuItem();
            personajesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.BackColor = Color.DarkSlateGray;
            btnExit.BackgroundImageLayout = ImageLayout.None;
            btnExit.FlatAppearance.BorderSize = 2;
            btnExit.FlatAppearance.MouseDownBackColor = Color.DarkSlateGray;
            btnExit.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnExit.FlatStyle = FlatStyle.System;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = SystemColors.InactiveCaptionText;
            btnExit.Location = new Point(722, 464);
            btnExit.MaximumSize = new Size(90, 90);
            btnExit.Name = "btnExit";
            btnExit.RightToLeft = RightToLeft.Yes;
            btnExit.Size = new Size(66, 22);
            btnExit.TabIndex = 1;
            btnExit.Text = "Salir";
            btnExit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.DarkSlateGray;
            menuStrip2.BackgroundImageLayout = ImageLayout.None;
            menuStrip2.Items.AddRange(new ToolStripItem[] { gameOfThronesToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 66);
            menuStrip2.Stretch = false;
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // gameOfThronesToolStripMenuItem
            // 
            gameOfThronesToolStripMenuItem.BackColor = Color.DarkSlateGray;
            gameOfThronesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personajesToolStripMenuItem });
            gameOfThronesToolStripMenuItem.Font = new Font("Agency FB", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameOfThronesToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            gameOfThronesToolStripMenuItem.Name = "gameOfThronesToolStripMenuItem";
            gameOfThronesToolStripMenuItem.Size = new Size(299, 62);
            gameOfThronesToolStripMenuItem.Text = "Game Of Thrones";
            // 
            // personajesToolStripMenuItem
            // 
            personajesToolStripMenuItem.BackColor = Color.White;
            personajesToolStripMenuItem.Name = "personajesToolStripMenuItem";
            personajesToolStripMenuItem.Size = new Size(288, 62);
            personajesToolStripMenuItem.Text = "Personajes";
            personajesToolStripMenuItem.Click += personajesToolStripMenuItem_Click_1;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 498);
            Controls.Add(btnExit);
            Controls.Add(menuStrip2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            WindowState = FormWindowState.Maximized;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnExit;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem gameOfThronesToolStripMenuItem;
        private ToolStripMenuItem personajesToolStripMenuItem;
    }
}
