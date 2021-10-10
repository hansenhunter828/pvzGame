
namespace pvzGame
{
    partial class GameOverScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.subTitleLabel = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.Loop = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(272, 170);
            this.gameOverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(237, 28);
            this.gameOverLabel.TabIndex = 0;
            this.gameOverLabel.Text = "GAME OVER";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.Location = new System.Drawing.Point(285, 198);
            this.subTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subTitleLabel.Name = "subTitleLabel";
            this.subTitleLabel.Size = new System.Drawing.Size(215, 28);
            this.subTitleLabel.TabIndex = 1;
            this.subTitleLabel.Text = "Would you like to play again?";
            this.subTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(329, 230);
            this.playAgainButton.Margin = new System.Windows.Forms.Padding(4);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(128, 28);
            this.playAgainButton.TabIndex = 2;
            this.playAgainButton.Text = "PLAY AGAIN";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(329, 266);
            this.mainMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(128, 28);
            this.mainMenuButton.TabIndex = 3;
            this.mainMenuButton.Text = "MAIN MENU";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(329, 302);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(128, 28);
            this.quitButton.TabIndex = 4;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // Loop
            // 
            this.Loop.Enabled = true;
            this.Loop.Interval = 20;
            this.Loop.Tick += new System.EventHandler(this.Loop_Tick);
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.subTitleLabel);
            this.Controls.Add(this.gameOverLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(800, 450);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameOverScreen_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label subTitleLabel;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Timer Loop;
    }
}
