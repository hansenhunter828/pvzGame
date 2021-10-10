
namespace pvzGame
{
    partial class MainMenuScreen
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Loop = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(249, 87);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(291, 81);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Plants V Zombies";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(328, 212);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 28);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(328, 247);
            this.quitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(100, 28);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "(Wish Version)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Loop
            // 
            this.Loop.Enabled = true;
            this.Loop.Interval = 20;
            this.Loop.Tick += new System.EventHandler(this.Loop_Tick);
            // 
            // MainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainMenuScreen";
            this.Size = new System.Drawing.Size(800, 450);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenuScreen_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Loop;
    }
}
