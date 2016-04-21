namespace mah_stuff
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
            this.exitButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.storyTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.closeFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(620, 404);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 50);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(12, 404);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(86, 50);
            this.openFileButton.TabIndex = 13;
            this.openFileButton.Text = "Open File";
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // storyTextBox
            // 
            this.storyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.storyTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyTextBox.Location = new System.Drawing.Point(12, 6);
            this.storyTextBox.MaxLength = 327670000;
            this.storyTextBox.Multiline = true;
            this.storyTextBox.Name = "storyTextBox";
            this.storyTextBox.ReadOnly = true;
            this.storyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.storyTextBox.Size = new System.Drawing.Size(703, 392);
            this.storyTextBox.TabIndex = 12;
            this.storyTextBox.Text = "Please only select .txt files";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFile_FileOk);
            // 
            // closeFileButton
            // 
            this.closeFileButton.Location = new System.Drawing.Point(104, 404);
            this.closeFileButton.Name = "closeFileButton";
            this.closeFileButton.Size = new System.Drawing.Size(86, 50);
            this.closeFileButton.TabIndex = 14;
            this.closeFileButton.Text = "Close File";
            this.closeFileButton.Click += new System.EventHandler(this.closeFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 466);
            this.Controls.Add(this.closeFileButton);
            this.Controls.Add(this.storyTextBox);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.exitButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Story Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.TextBox storyTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button closeFileButton;
    }
}

