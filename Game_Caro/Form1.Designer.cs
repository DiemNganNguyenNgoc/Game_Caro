namespace Game_Caro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnTableChess = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.player1VsPlayer2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnShow = new System.Windows.Forms.Panel();
            this.lbRule = new System.Windows.Forms.Label();
            this.ptbPayer = new System.Windows.Forms.PictureBox();
            this.psbCooldownTime = new System.Windows.Forms.ProgressBar();
            this.txtNamePlayer = new System.Windows.Forms.TextBox();
            this.Avata = new System.Windows.Forms.PictureBox();
            this.tmCooldown = new System.Windows.Forms.Timer(this.components);
            this.playVsComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnTableChess.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avata)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTableChess
            // 
            this.pnTableChess.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnTableChess.Controls.Add(this.menuStrip1);
            this.pnTableChess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTableChess.Location = new System.Drawing.Point(0, 0);
            this.pnTableChess.Margin = new System.Windows.Forms.Padding(4);
            this.pnTableChess.Name = "pnTableChess";
            this.pnTableChess.Size = new System.Drawing.Size(488, 450);
            this.pnTableChess.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGame});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(488, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuGame
            // 
            this.menuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewGame,
            this.menuUndo,
            this.menuQuit});
            this.menuGame.Name = "menuGame";
            this.menuGame.Size = new System.Drawing.Size(60, 24);
            this.menuGame.Text = "Menu";
            // 
            // menuNewGame
            // 
            this.menuNewGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.player1VsPlayer2ToolStripMenuItem,
            this.playVsComputerToolStripMenuItem});
            this.menuNewGame.Name = "menuNewGame";
            this.menuNewGame.Size = new System.Drawing.Size(224, 26);
            this.menuNewGame.Text = "New game";
            // 
            // player1VsPlayer2ToolStripMenuItem
            // 
            this.player1VsPlayer2ToolStripMenuItem.Name = "player1VsPlayer2ToolStripMenuItem";
            this.player1VsPlayer2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.player1VsPlayer2ToolStripMenuItem.Text = "Player1 vs Player2";
            this.player1VsPlayer2ToolStripMenuItem.Click += new System.EventHandler(this.player1VsPlayer2);
            // 
            // menuUndo
            // 
            this.menuUndo.Name = "menuUndo";
            this.menuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuUndo.Size = new System.Drawing.Size(224, 26);
            this.menuUndo.Text = "Undo";
            this.menuUndo.Click += new System.EventHandler(this.menuUndo_Click);
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.menuQuit.Size = new System.Drawing.Size(224, 26);
            this.menuQuit.Text = "Quit";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click_1);
            // 
            // pnShow
            // 
            this.pnShow.BackColor = System.Drawing.Color.BurlyWood;
            this.pnShow.Controls.Add(this.lbRule);
            this.pnShow.Controls.Add(this.ptbPayer);
            this.pnShow.Controls.Add(this.psbCooldownTime);
            this.pnShow.Controls.Add(this.txtNamePlayer);
            this.pnShow.Controls.Add(this.Avata);
            this.pnShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnShow.Location = new System.Drawing.Point(488, 0);
            this.pnShow.Margin = new System.Windows.Forms.Padding(4);
            this.pnShow.Name = "pnShow";
            this.pnShow.Size = new System.Drawing.Size(312, 450);
            this.pnShow.TabIndex = 4;
            // 
            // lbRule
            // 
            this.lbRule.AutoSize = true;
            this.lbRule.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbRule.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRule.Location = new System.Drawing.Point(0, 572);
            this.lbRule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRule.Name = "lbRule";
            this.lbRule.Size = new System.Drawing.Size(291, 34);
            this.lbRule.TabIndex = 4;
            this.lbRule.Text = " 5 in a line to win";
            // 
            // ptbPayer
            // 
            this.ptbPayer.BackColor = System.Drawing.Color.Gray;
            this.ptbPayer.Location = new System.Drawing.Point(175, 352);
            this.ptbPayer.Margin = new System.Windows.Forms.Padding(4);
            this.ptbPayer.Name = "ptbPayer";
            this.ptbPayer.Size = new System.Drawing.Size(133, 106);
            this.ptbPayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPayer.TabIndex = 3;
            this.ptbPayer.TabStop = false;
            // 
            // psbCooldownTime
            // 
            this.psbCooldownTime.Location = new System.Drawing.Point(8, 412);
            this.psbCooldownTime.Margin = new System.Windows.Forms.Padding(4);
            this.psbCooldownTime.Maximum = 20000;
            this.psbCooldownTime.Name = "psbCooldownTime";
            this.psbCooldownTime.Size = new System.Drawing.Size(160, 46);
            this.psbCooldownTime.Step = 100;
            this.psbCooldownTime.TabIndex = 1;
            // 
            // txtNamePlayer
            // 
            this.txtNamePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePlayer.Location = new System.Drawing.Point(8, 352);
            this.txtNamePlayer.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamePlayer.Multiline = true;
            this.txtNamePlayer.Name = "txtNamePlayer";
            this.txtNamePlayer.ReadOnly = true;
            this.txtNamePlayer.Size = new System.Drawing.Size(159, 45);
            this.txtNamePlayer.TabIndex = 10;
            // 
            // Avata
            // 
            this.Avata.Image = ((System.Drawing.Image)(resources.GetObject("Avata.Image")));
            this.Avata.Location = new System.Drawing.Point(4, 4);
            this.Avata.Margin = new System.Windows.Forms.Padding(4);
            this.Avata.Name = "Avata";
            this.Avata.Size = new System.Drawing.Size(305, 272);
            this.Avata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avata.TabIndex = 0;
            this.Avata.TabStop = false;
            // 
            // tmCooldown
            // 
            this.tmCooldown.Tick += new System.EventHandler(this.tmCooldown_Tick);
            // 
            // playVsComputerToolStripMenuItem
            // 
            this.playVsComputerToolStripMenuItem.Name = "playVsComputerToolStripMenuItem";
            this.playVsComputerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.playVsComputerToolStripMenuItem.Text = "Play vs Computer";
            this.playVsComputerToolStripMenuItem.Click += new System.EventHandler(this.PlayVsComputer);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnTableChess);
            this.Controls.Add(this.pnShow);
            this.Name = "Form1";
            this.Text = "Co ca ro";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.pnTableChess.ResumeLayout(false);
            this.pnTableChess.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnShow.ResumeLayout(false);
            this.pnShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTableChess;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuGame;
        private System.Windows.Forms.ToolStripMenuItem menuNewGame;
       // private System.Windows.Forms.ToolStripMenuItem PlayVsComputer;
        private System.Windows.Forms.ToolStripMenuItem player1VsPlayer2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuUndo;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.Panel pnShow;
        private System.Windows.Forms.Label lbRule;
        private System.Windows.Forms.PictureBox ptbPayer;
        private System.Windows.Forms.ProgressBar psbCooldownTime;
        private System.Windows.Forms.TextBox txtNamePlayer;
        private System.Windows.Forms.PictureBox Avata;
        private System.Windows.Forms.Timer tmCooldown;
        private System.Windows.Forms.ToolStripMenuItem playVsComputerToolStripMenuItem;
    }
}

