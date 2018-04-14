namespace DatabaseHomework
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
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.EngineTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.DeveloperTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.DeveloperLabel = new System.Windows.Forms.Label();
            this.EngineLabel = new System.Windows.Forms.Label();
            this.AddGame = new System.Windows.Forms.Button();
            this.UpdateGame = new System.Windows.Forms.Button();
            this.DeleteGame = new System.Windows.Forms.Button();
            this.DisplayGame = new System.Windows.Forms.Button();
            this.ListGames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(78, 52);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(224, 20);
            this.TitleTextBox.TabIndex = 0;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(78, 90);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(224, 100);
            this.DescriptionTextBox.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 55);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Title";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 93);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Description";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(78, 209);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenreTextBox.TabIndex = 4;
            // 
            // EngineTextBox
            // 
            this.EngineTextBox.Location = new System.Drawing.Point(78, 339);
            this.EngineTextBox.Name = "EngineTextBox";
            this.EngineTextBox.Size = new System.Drawing.Size(100, 20);
            this.EngineTextBox.TabIndex = 5;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(78, 254);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(100, 20);
            this.YearTextBox.TabIndex = 6;
            // 
            // DeveloperTextBox
            // 
            this.DeveloperTextBox.Location = new System.Drawing.Point(78, 296);
            this.DeveloperTextBox.Name = "DeveloperTextBox";
            this.DeveloperTextBox.Size = new System.Drawing.Size(100, 20);
            this.DeveloperTextBox.TabIndex = 7;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(37, 212);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(36, 13);
            this.GenreLabel.TabIndex = 8;
            this.GenreLabel.Text = "Genre";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(37, 257);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(29, 13);
            this.YearLabel.TabIndex = 9;
            this.YearLabel.Text = "Year";
            // 
            // DeveloperLabel
            // 
            this.DeveloperLabel.AutoSize = true;
            this.DeveloperLabel.Location = new System.Drawing.Point(17, 299);
            this.DeveloperLabel.Name = "DeveloperLabel";
            this.DeveloperLabel.Size = new System.Drawing.Size(56, 13);
            this.DeveloperLabel.TabIndex = 10;
            this.DeveloperLabel.Text = "Developer";
            // 
            // EngineLabel
            // 
            this.EngineLabel.AutoSize = true;
            this.EngineLabel.Location = new System.Drawing.Point(37, 342);
            this.EngineLabel.Name = "EngineLabel";
            this.EngineLabel.Size = new System.Drawing.Size(40, 13);
            this.EngineLabel.TabIndex = 11;
            this.EngineLabel.Text = "Engine";
            // 
            // AddGame
            // 
            this.AddGame.Location = new System.Drawing.Point(146, 399);
            this.AddGame.Name = "AddGame";
            this.AddGame.Size = new System.Drawing.Size(75, 23);
            this.AddGame.TabIndex = 12;
            this.AddGame.Text = "Add";
            this.AddGame.UseVisualStyleBackColor = true;
            this.AddGame.Click += new System.EventHandler(this.AddGame_Click);
            // 
            // UpdateGame
            // 
            this.UpdateGame.Location = new System.Drawing.Point(227, 399);
            this.UpdateGame.Name = "UpdateGame";
            this.UpdateGame.Size = new System.Drawing.Size(75, 23);
            this.UpdateGame.TabIndex = 13;
            this.UpdateGame.Text = "Update";
            this.UpdateGame.UseVisualStyleBackColor = true;
            // 
            // DeleteGame
            // 
            this.DeleteGame.Location = new System.Drawing.Point(310, 399);
            this.DeleteGame.Name = "DeleteGame";
            this.DeleteGame.Size = new System.Drawing.Size(75, 23);
            this.DeleteGame.TabIndex = 14;
            this.DeleteGame.Text = "Delete";
            this.DeleteGame.UseVisualStyleBackColor = true;
            // 
            // DisplayGame
            // 
            this.DisplayGame.Location = new System.Drawing.Point(391, 399);
            this.DisplayGame.Name = "DisplayGame";
            this.DisplayGame.Size = new System.Drawing.Size(75, 23);
            this.DisplayGame.TabIndex = 15;
            this.DisplayGame.Text = "Display";
            this.DisplayGame.UseVisualStyleBackColor = true;
            this.DisplayGame.Click += new System.EventHandler(this.DisplayGame_Click);
            // 
            // ListGames
            // 
            this.ListGames.FormattingEnabled = true;
            this.ListGames.Location = new System.Drawing.Point(334, 16);
            this.ListGames.Name = "ListGames";
            this.ListGames.Size = new System.Drawing.Size(191, 212);
            this.ListGames.TabIndex = 16;
            this.ListGames.SelectedIndexChanged += new System.EventHandler(this.ListGames_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.ListGames);
            this.Controls.Add(this.DisplayGame);
            this.Controls.Add(this.DeleteGame);
            this.Controls.Add(this.UpdateGame);
            this.Controls.Add(this.AddGame);
            this.Controls.Add(this.EngineLabel);
            this.Controls.Add(this.DeveloperLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.DeveloperTextBox);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.EngineTextBox);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox EngineTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox DeveloperTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label DeveloperLabel;
        private System.Windows.Forms.Label EngineLabel;
        private System.Windows.Forms.Button AddGame;
        private System.Windows.Forms.Button UpdateGame;
        private System.Windows.Forms.Button DeleteGame;
        private System.Windows.Forms.Button DisplayGame;
        private System.Windows.Forms.ListBox ListGames;
    }
}

