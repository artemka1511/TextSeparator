
namespace TextSeparator.Forms
{
    partial class TextForm
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.SeparatorTextBox = new System.Windows.Forms.TextBox();
            this.SeparateButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.Location = new System.Drawing.Point(23, 20);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox.Size = new System.Drawing.Size(437, 250);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "Input text here...";
            // 
            // SeparatorTextBox
            // 
            this.SeparatorTextBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeparatorTextBox.Location = new System.Drawing.Point(23, 307);
            this.SeparatorTextBox.Name = "SeparatorTextBox";
            this.SeparatorTextBox.Size = new System.Drawing.Size(437, 32);
            this.SeparatorTextBox.TabIndex = 1;
            this.SeparatorTextBox.Text = "Input separator here...";
            // 
            // SeparateButton
            // 
            this.SeparateButton.BackgroundImage = global::TextSeparator.Properties.Resources.imgonline_com_ua_Resize_yMZDeExRrSqFxxuj;
            this.SeparateButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeparateButton.Location = new System.Drawing.Point(150, 380);
            this.SeparateButton.Name = "SeparateButton";
            this.SeparateButton.Size = new System.Drawing.Size(200, 50);
            this.SeparateButton.TabIndex = 2;
            this.SeparateButton.Text = "Separate";
            this.SeparateButton.UseVisualStyleBackColor = true;
            this.SeparateButton.Click += new System.EventHandler(this.SeparateButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = global::TextSeparator.Properties.Resources.imgonline_com_ua_Resize_ZdGNs9BcugA;
            this.BackButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(23, 380);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(70, 50);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TextSeparator.Properties.Resources.imgonline_com_ua_Resize_rjk9Xod2Sd78i7xb;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SeparateButton);
            this.Controls.Add(this.SeparatorTextBox);
            this.Controls.Add(this.TextBox);
            this.Name = "TextForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextSeparator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.TextBox SeparatorTextBox;
        private System.Windows.Forms.Button SeparateButton;
        private System.Windows.Forms.Button BackButton;
    }
}