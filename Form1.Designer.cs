namespace Rock_Paper_Scissors_Graphic
{
    partial class Form1
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
            this.RockButton = new System.Windows.Forms.Button();
            this.PaperButton = new System.Windows.Forms.Button();
            this.ScissorsButton = new System.Windows.Forms.Button();
            this.GameLabel = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.YourPointsTag = new System.Windows.Forms.Label();
            this.YourPointsCounter = new System.Windows.Forms.Label();
            this.ComputerPointsTag = new System.Windows.Forms.Label();
            this.ComputerPointsCounter = new System.Windows.Forms.Label();
            this.ComputerChoiceLabel = new System.Windows.Forms.Label();
            this.ComputerChoice = new System.Windows.Forms.Label();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResultOfGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RockButton
            // 
            this.RockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RockButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RockButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RockButton.Location = new System.Drawing.Point(103, 121);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(125, 47);
            this.RockButton.TabIndex = 0;
            this.RockButton.Text = "Rock";
            this.RockButton.UseVisualStyleBackColor = false;
            this.RockButton.Visible = false;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // PaperButton
            // 
            this.PaperButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PaperButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PaperButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PaperButton.Location = new System.Drawing.Point(256, 121);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(125, 47);
            this.PaperButton.TabIndex = 1;
            this.PaperButton.Text = "Paper";
            this.PaperButton.UseVisualStyleBackColor = false;
            this.PaperButton.Visible = false;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // ScissorsButton
            // 
            this.ScissorsButton.BackColor = System.Drawing.Color.Orchid;
            this.ScissorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ScissorsButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScissorsButton.Location = new System.Drawing.Point(409, 121);
            this.ScissorsButton.Name = "ScissorsButton";
            this.ScissorsButton.Size = new System.Drawing.Size(125, 47);
            this.ScissorsButton.TabIndex = 2;
            this.ScissorsButton.Text = "Scissors";
            this.ScissorsButton.UseVisualStyleBackColor = false;
            this.ScissorsButton.Visible = false;
            this.ScissorsButton.Click += new System.EventHandler(this.ScissorsButton_Click);
            // 
            // GameLabel
            // 
            this.GameLabel.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameLabel.Location = new System.Drawing.Point(131, 19);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(364, 34);
            this.GameLabel.TabIndex = 3;
            this.GameLabel.Text = "Welcome to our Game!";
            this.GameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Start.Location = new System.Drawing.Point(156, 56);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(319, 43);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // YourPointsTag
            // 
            this.YourPointsTag.BackColor = System.Drawing.Color.Orchid;
            this.YourPointsTag.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YourPointsTag.Location = new System.Drawing.Point(56, 313);
            this.YourPointsTag.Name = "YourPointsTag";
            this.YourPointsTag.Size = new System.Drawing.Size(209, 47);
            this.YourPointsTag.TabIndex = 5;
            this.YourPointsTag.Text = "Your Points:";
            this.YourPointsTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YourPointsTag.Visible = false;
            // 
            // YourPointsCounter
            // 
            this.YourPointsCounter.BackColor = System.Drawing.Color.Orchid;
            this.YourPointsCounter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YourPointsCounter.Location = new System.Drawing.Point(256, 313);
            this.YourPointsCounter.Name = "YourPointsCounter";
            this.YourPointsCounter.Size = new System.Drawing.Size(38, 47);
            this.YourPointsCounter.TabIndex = 6;
            this.YourPointsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YourPointsCounter.Visible = false;
            // 
            // ComputerPointsTag
            // 
            this.ComputerPointsTag.BackColor = System.Drawing.Color.Orchid;
            this.ComputerPointsTag.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComputerPointsTag.Location = new System.Drawing.Point(338, 313);
            this.ComputerPointsTag.Name = "ComputerPointsTag";
            this.ComputerPointsTag.Size = new System.Drawing.Size(209, 47);
            this.ComputerPointsTag.TabIndex = 7;
            this.ComputerPointsTag.Text = "Computer Points:";
            this.ComputerPointsTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComputerPointsTag.Visible = false;
            // 
            // ComputerPointsCounter
            // 
            this.ComputerPointsCounter.BackColor = System.Drawing.Color.Orchid;
            this.ComputerPointsCounter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComputerPointsCounter.Location = new System.Drawing.Point(542, 313);
            this.ComputerPointsCounter.Name = "ComputerPointsCounter";
            this.ComputerPointsCounter.Size = new System.Drawing.Size(38, 47);
            this.ComputerPointsCounter.TabIndex = 8;
            this.ComputerPointsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComputerPointsCounter.Visible = false;
            // 
            // ComputerChoiceLabel
            // 
            this.ComputerChoiceLabel.BackColor = System.Drawing.Color.Violet;
            this.ComputerChoiceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComputerChoiceLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComputerChoiceLabel.Location = new System.Drawing.Point(183, 212);
            this.ComputerChoiceLabel.Name = "ComputerChoiceLabel";
            this.ComputerChoiceLabel.Size = new System.Drawing.Size(180, 47);
            this.ComputerChoiceLabel.TabIndex = 9;
            this.ComputerChoiceLabel.Text = "Computer chose:";
            this.ComputerChoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComputerChoiceLabel.Visible = false;
            // 
            // ComputerChoice
            // 
            this.ComputerChoice.BackColor = System.Drawing.Color.Violet;
            this.ComputerChoice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ComputerChoice.Location = new System.Drawing.Point(355, 212);
            this.ComputerChoice.Name = "ComputerChoice";
            this.ComputerChoice.Size = new System.Drawing.Size(91, 47);
            this.ComputerChoice.TabIndex = 10;
            this.ComputerChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComputerChoice.Visible = false;
            // 
            // ContinueButton
            // 
            this.ContinueButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ContinueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ContinueButton.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContinueButton.Location = new System.Drawing.Point(165, 389);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(126, 39);
            this.ContinueButton.TabIndex = 11;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = false;
            this.ContinueButton.Visible = false;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(338, 389);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(126, 39);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Visible = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResultOfGame
            // 
            this.ResultOfGame.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultOfGame.ForeColor = System.Drawing.Color.Black;
            this.ResultOfGame.Location = new System.Drawing.Point(156, 258);
            this.ResultOfGame.Name = "ResultOfGame";
            this.ResultOfGame.Size = new System.Drawing.Size(330, 45);
            this.ResultOfGame.TabIndex = 13;
            this.ResultOfGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.ResultOfGame);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.ComputerChoice);
            this.Controls.Add(this.ComputerChoiceLabel);
            this.Controls.Add(this.ComputerPointsCounter);
            this.Controls.Add(this.ComputerPointsTag);
            this.Controls.Add(this.YourPointsCounter);
            this.Controls.Add(this.YourPointsTag);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.GameLabel);
            this.Controls.Add(this.ScissorsButton);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.RockButton);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.Button PaperButton;
        private System.Windows.Forms.Button ScissorsButton;
        private System.Windows.Forms.Label GameLabel;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label YourPointsTag;
        private System.Windows.Forms.Label YourPointsCounter;
        private System.Windows.Forms.Label ComputerPointsTag;
        private System.Windows.Forms.Label ComputerPointsCounter;
        private System.Windows.Forms.Label ComputerChoiceLabel;
        private System.Windows.Forms.Label ComputerChoice;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label ResultOfGame;
    }
}
