namespace BlackjackGame
{
    partial class Form1
    {
        private System.Windows.Forms.Label playerCardsLabel;
        private System.Windows.Forms.Label dealerCardsLabel;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label dealerScoreLabel;
        private System.Windows.Forms.Button HitButton;
        private System.Windows.Forms.Button StandButton;

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerCardsLabel = new System.Windows.Forms.Label();
            this.dealerCardsLabel = new System.Windows.Forms.Label();
            this.HitButton = new System.Windows.Forms.Button();
            this.StandButton = new System.Windows.Forms.Button();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.dealerScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerCardsLabel
            // 
            this.playerCardsLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerCardsLabel.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCardsLabel.ForeColor = System.Drawing.Color.Red;
            this.playerCardsLabel.Location = new System.Drawing.Point(879, 398);
            this.playerCardsLabel.Name = "playerCardsLabel";
            this.playerCardsLabel.Size = new System.Drawing.Size(318, 191);
            this.playerCardsLabel.TabIndex = 0;
            // 
            // dealerCardsLabel
            // 
            this.dealerCardsLabel.BackColor = System.Drawing.Color.Transparent;
            this.dealerCardsLabel.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerCardsLabel.ForeColor = System.Drawing.Color.Red;
            this.dealerCardsLabel.Location = new System.Drawing.Point(879, 689);
            this.dealerCardsLabel.Name = "dealerCardsLabel";
            this.dealerCardsLabel.Size = new System.Drawing.Size(289, 199);
            this.dealerCardsLabel.TabIndex = 1;
            // 
            // HitButton
            // 
            this.HitButton.Location = new System.Drawing.Point(887, 948);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(176, 73);
            this.HitButton.TabIndex = 2;
            this.HitButton.Text = "Hit";
            this.HitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // StandButton
            // 
            this.StandButton.Location = new System.Drawing.Point(1115, 948);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(177, 73);
            this.StandButton.TabIndex = 3;
            this.StandButton.Text = "Stand";
            this.StandButton.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerScoreLabel.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.playerScoreLabel.Location = new System.Drawing.Point(1433, 389);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(300, 229);
            this.playerScoreLabel.TabIndex = 4;
            this.playerScoreLabel.Click += new System.EventHandler(this.playerScoreLabel_Click);
            // 
            // dealerScoreLabel
            // 
            this.dealerScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.dealerScoreLabel.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.dealerScoreLabel.Location = new System.Drawing.Point(1418, 709);
            this.dealerScoreLabel.Name = "dealerScoreLabel";
            this.dealerScoreLabel.Size = new System.Drawing.Size(440, 273);
            this.dealerScoreLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1913, 1151);
            this.Controls.Add(this.playerCardsLabel);
            this.Controls.Add(this.dealerCardsLabel);
            this.Controls.Add(this.HitButton);
            this.Controls.Add(this.StandButton);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.dealerScoreLabel);
            this.Name = "Form1";
            this.Text = "BlackJack Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        // Rest of auto-generated code
        // ...
    }
}

