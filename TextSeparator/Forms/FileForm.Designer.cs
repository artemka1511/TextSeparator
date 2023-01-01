
namespace TextSeparator
{
    partial class FileForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SeparatorTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SeparateButton = new System.Windows.Forms.Button();
            this.BrowseFileButton = new System.Windows.Forms.Button();
            this.PathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SeparatorTextBox
            // 
            this.SeparatorTextBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeparatorTextBox.Location = new System.Drawing.Point(24, 306);
            this.SeparatorTextBox.Name = "SeparatorTextBox";
            this.SeparatorTextBox.Size = new System.Drawing.Size(437, 32);
            this.SeparatorTextBox.TabIndex = 2;
            this.SeparatorTextBox.Text = "Input separator here...";
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = global::TextSeparator.Properties.Resources.imgonline_com_ua_Resize_ZdGNs9BcugA;
            this.BackButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(24, 382);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(70, 50);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SeparateButton
            // 
            this.SeparateButton.BackgroundImage = global::TextSeparator.Properties.Resources.imgonline_com_ua_Resize_yMZDeExRrSqFxxuj;
            this.SeparateButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeparateButton.Location = new System.Drawing.Point(149, 382);
            this.SeparateButton.Name = "SeparateButton";
            this.SeparateButton.Size = new System.Drawing.Size(200, 50);
            this.SeparateButton.TabIndex = 4;
            this.SeparateButton.Text = "Separate";
            this.SeparateButton.UseVisualStyleBackColor = true;
            this.SeparateButton.Click += new System.EventHandler(this.SeparateButton_Click);
            // 
            // BrowseFileButton
            // 
            this.BrowseFileButton.BackgroundImage = global::TextSeparator.Properties.Resources.imgonline_com_ua_Resize_yyG6gjHExvIMa0S;
            this.BrowseFileButton.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrowseFileButton.Location = new System.Drawing.Point(149, 53);
            this.BrowseFileButton.Name = "BrowseFileButton";
            this.BrowseFileButton.Size = new System.Drawing.Size(200, 100);
            this.BrowseFileButton.TabIndex = 6;
            this.BrowseFileButton.Text = "BrowseFile";
            this.BrowseFileButton.UseVisualStyleBackColor = true;
            this.BrowseFileButton.Click += new System.EventHandler(this.BrowseFileButton_Click);
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.BackColor = System.Drawing.Color.Transparent;
            this.PathLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathLabel.Location = new System.Drawing.Point(20, 180);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(0, 22);
            this.PathLabel.TabIndex = 7;
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TextSeparator.Properties.Resources.imgonline_com_ua_Resize_rjk9Xod2Sd78i7xb;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.BrowseFileButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SeparateButton);
            this.Controls.Add(this.SeparatorTextBox);
            this.Name = "FileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextSeparator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox SeparatorTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SeparateButton;
        private System.Windows.Forms.Button BrowseFileButton;
        private System.Windows.Forms.Label PathLabel;
    }
}