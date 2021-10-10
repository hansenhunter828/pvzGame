
namespace pvzGame
{
    partial class GameScreen
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
            this.shooter1Button = new System.Windows.Forms.Button();
            this.flower1Button = new System.Windows.Forms.Button();
            this.shooter2Button = new System.Windows.Forms.Button();
            this.flower2Button = new System.Windows.Forms.Button();
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.sunFlowersLabel = new System.Windows.Forms.Label();
            this.upgradeDamButton = new System.Windows.Forms.Button();
            this.upgradeCashButton = new System.Windows.Forms.Button();
            this.waveLabel = new System.Windows.Forms.Label();
            this.upCashCostLabel = new System.Windows.Forms.Label();
            this.upDamCostLabel = new System.Windows.Forms.Label();
            this.baseHealthLabel = new System.Windows.Forms.Label();
            this.waveTimerLeftLabel = new System.Windows.Forms.Label();
            this.currentWaveLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shooter1Button
            // 
            this.shooter1Button.Location = new System.Drawing.Point(124, 60);
            this.shooter1Button.Margin = new System.Windows.Forms.Padding(2);
            this.shooter1Button.Name = "shooter1Button";
            this.shooter1Button.Size = new System.Drawing.Size(75, 19);
            this.shooter1Button.TabIndex = 0;
            this.shooter1Button.Text = "Shooter 1";
            this.shooter1Button.UseVisualStyleBackColor = true;
            this.shooter1Button.Click += new System.EventHandler(this.plot2_Click);
            // 
            // flower1Button
            // 
            this.flower1Button.Location = new System.Drawing.Point(34, 60);
            this.flower1Button.Margin = new System.Windows.Forms.Padding(2);
            this.flower1Button.Name = "flower1Button";
            this.flower1Button.Size = new System.Drawing.Size(56, 19);
            this.flower1Button.TabIndex = 1;
            this.flower1Button.Text = "Flower 1";
            this.flower1Button.UseVisualStyleBackColor = true;
            this.flower1Button.Click += new System.EventHandler(this.plot1_Click);
            // 
            // shooter2Button
            // 
            this.shooter2Button.Location = new System.Drawing.Point(124, 180);
            this.shooter2Button.Margin = new System.Windows.Forms.Padding(2);
            this.shooter2Button.Name = "shooter2Button";
            this.shooter2Button.Size = new System.Drawing.Size(75, 19);
            this.shooter2Button.TabIndex = 2;
            this.shooter2Button.Text = "Shooter 2";
            this.shooter2Button.UseVisualStyleBackColor = true;
            this.shooter2Button.Click += new System.EventHandler(this.plot4_Click);
            // 
            // flower2Button
            // 
            this.flower2Button.Location = new System.Drawing.Point(34, 180);
            this.flower2Button.Margin = new System.Windows.Forms.Padding(2);
            this.flower2Button.Name = "flower2Button";
            this.flower2Button.Size = new System.Drawing.Size(56, 19);
            this.flower2Button.TabIndex = 3;
            this.flower2Button.Text = "Flower 2";
            this.flower2Button.UseVisualStyleBackColor = true;
            this.flower2Button.Click += new System.EventHandler(this.plot3_Click);
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 20;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // sunFlowersLabel
            // 
            this.sunFlowersLabel.BackColor = System.Drawing.Color.White;
            this.sunFlowersLabel.Location = new System.Drawing.Point(237, 340);
            this.sunFlowersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sunFlowersLabel.Name = "sunFlowersLabel";
            this.sunFlowersLabel.Size = new System.Drawing.Size(75, 19);
            this.sunFlowersLabel.TabIndex = 7;
            this.sunFlowersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upgradeDamButton
            // 
            this.upgradeDamButton.Location = new System.Drawing.Point(10, 334);
            this.upgradeDamButton.Margin = new System.Windows.Forms.Padding(2);
            this.upgradeDamButton.Name = "upgradeDamButton";
            this.upgradeDamButton.Size = new System.Drawing.Size(109, 29);
            this.upgradeDamButton.TabIndex = 8;
            this.upgradeDamButton.Text = "Upgrade Damage";
            this.upgradeDamButton.UseVisualStyleBackColor = true;
            this.upgradeDamButton.Click += new System.EventHandler(this.upgradeDamButton_Click);
            // 
            // upgradeCashButton
            // 
            this.upgradeCashButton.Location = new System.Drawing.Point(124, 334);
            this.upgradeCashButton.Margin = new System.Windows.Forms.Padding(2);
            this.upgradeCashButton.Name = "upgradeCashButton";
            this.upgradeCashButton.Size = new System.Drawing.Size(109, 29);
            this.upgradeCashButton.TabIndex = 9;
            this.upgradeCashButton.Text = "Upgrade Income";
            this.upgradeCashButton.UseVisualStyleBackColor = true;
            this.upgradeCashButton.Click += new System.EventHandler(this.upgradeCashButton_Click);
            // 
            // waveLabel
            // 
            this.waveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waveLabel.Location = new System.Drawing.Point(221, 154);
            this.waveLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.waveLabel.Name = "waveLabel";
            this.waveLabel.Size = new System.Drawing.Size(140, 33);
            this.waveLabel.TabIndex = 10;
            this.waveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upCashCostLabel
            // 
            this.upCashCostLabel.BackColor = System.Drawing.Color.White;
            this.upCashCostLabel.Location = new System.Drawing.Point(124, 313);
            this.upCashCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.upCashCostLabel.Name = "upCashCostLabel";
            this.upCashCostLabel.Size = new System.Drawing.Size(75, 19);
            this.upCashCostLabel.TabIndex = 11;
            this.upCashCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upDamCostLabel
            // 
            this.upDamCostLabel.BackColor = System.Drawing.Color.White;
            this.upDamCostLabel.Location = new System.Drawing.Point(8, 313);
            this.upDamCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.upDamCostLabel.Name = "upDamCostLabel";
            this.upDamCostLabel.Size = new System.Drawing.Size(75, 19);
            this.upDamCostLabel.TabIndex = 12;
            this.upDamCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baseHealthLabel
            // 
            this.baseHealthLabel.BackColor = System.Drawing.Color.White;
            this.baseHealthLabel.Location = new System.Drawing.Point(316, 340);
            this.baseHealthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baseHealthLabel.Name = "baseHealthLabel";
            this.baseHealthLabel.Size = new System.Drawing.Size(75, 19);
            this.baseHealthLabel.TabIndex = 13;
            this.baseHealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waveTimerLeftLabel
            // 
            this.waveTimerLeftLabel.BackColor = System.Drawing.Color.White;
            this.waveTimerLeftLabel.Location = new System.Drawing.Point(396, 340);
            this.waveTimerLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.waveTimerLeftLabel.Name = "waveTimerLeftLabel";
            this.waveTimerLeftLabel.Size = new System.Drawing.Size(75, 19);
            this.waveTimerLeftLabel.TabIndex = 14;
            this.waveTimerLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentWaveLabel
            // 
            this.currentWaveLabel.BackColor = System.Drawing.Color.White;
            this.currentWaveLabel.Location = new System.Drawing.Point(475, 339);
            this.currentWaveLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentWaveLabel.Name = "currentWaveLabel";
            this.currentWaveLabel.Size = new System.Drawing.Size(75, 19);
            this.currentWaveLabel.TabIndex = 15;
            this.currentWaveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.Controls.Add(this.currentWaveLabel);
            this.Controls.Add(this.waveTimerLeftLabel);
            this.Controls.Add(this.baseHealthLabel);
            this.Controls.Add(this.upDamCostLabel);
            this.Controls.Add(this.upCashCostLabel);
            this.Controls.Add(this.waveLabel);
            this.Controls.Add(this.upgradeCashButton);
            this.Controls.Add(this.upgradeDamButton);
            this.Controls.Add(this.sunFlowersLabel);
            this.Controls.Add(this.flower2Button);
            this.Controls.Add(this.shooter2Button);
            this.Controls.Add(this.flower1Button);
            this.Controls.Add(this.shooter1Button);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(600, 366);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shooter1Button;
        private System.Windows.Forms.Button flower1Button;
        private System.Windows.Forms.Button shooter2Button;
        private System.Windows.Forms.Button flower2Button;
        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Label sunFlowersLabel;
        private System.Windows.Forms.Button upgradeDamButton;
        private System.Windows.Forms.Button upgradeCashButton;
        private System.Windows.Forms.Label waveLabel;
        private System.Windows.Forms.Label upCashCostLabel;
        private System.Windows.Forms.Label upDamCostLabel;
        private System.Windows.Forms.Label baseHealthLabel;
        private System.Windows.Forms.Label waveTimerLeftLabel;
        private System.Windows.Forms.Label currentWaveLabel;
    }
}
