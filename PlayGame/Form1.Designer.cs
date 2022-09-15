namespace PlayGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.batBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.batBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.BackColor = System.Drawing.Color.DarkRed;
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.startButton.FlatAppearance.BorderSize = 4;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Black;
            this.startButton.Location = new System.Drawing.Point(298, 209);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 100);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "start game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // countdownLabel
            // 
            this.countdownLabel.BackColor = System.Drawing.Color.Transparent;
            this.countdownLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countdownLabel.Font = new System.Drawing.Font("Onyx", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.countdownLabel.Location = new System.Drawing.Point(0, 0);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(797, 519);
            this.countdownLabel.TabIndex = 1;
            this.countdownLabel.Text = "One";
            this.countdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countdownLabel.Click += new System.EventHandler(this.countdownLabel_Click);
            // 
            // batBox
            // 
            this.batBox.BackColor = System.Drawing.Color.Transparent;
            this.batBox.Image = global::PlayGame.Properties.Resources.batpixels;
            this.batBox.Location = new System.Drawing.Point(272, 139);
            this.batBox.Name = "batBox";
            this.batBox.Size = new System.Drawing.Size(253, 240);
            this.batBox.TabIndex = 2;
            this.batBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkRed;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.exitButton.FlatAppearance.BorderSize = 4;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Location = new System.Drawing.Point(298, 325);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 54);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "quit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Onyx", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.titleLabel.Location = new System.Drawing.Point(170, 87);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(456, 79);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "VAMPIRE III: REVENGE";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(797, 519);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.countdownLabel);
            this.Controls.Add(this.batBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VAMPIRE III: REVENGE";
            ((System.ComponentModel.ISupportInitialize)(this.batBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label countdownLabel;
        private System.Windows.Forms.PictureBox batBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
    }
}

