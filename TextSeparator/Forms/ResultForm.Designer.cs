
namespace TextSeparator.Forms
{
    partial class ResultForm
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
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.RepeatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTextBox.Location = new System.Drawing.Point(12, 12);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTextBox.Size = new System.Drawing.Size(460, 350);
            this.ResultTextBox.TabIndex = 0;
            // 
            // RepeatButton
            // 
            this.RepeatButton.BackgroundImage = global::TextSeparator.Properties.Resources.imgonline_com_ua_Resize_mXIcA0rQ2Em;
            this.RepeatButton.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RepeatButton.Location = new System.Drawing.Point(125, 392);
            this.RepeatButton.Name = "RepeatButton";
            this.RepeatButton.Size = new System.Drawing.Size(200, 50);
            this.RepeatButton.TabIndex = 1;
            this.RepeatButton.Text = "Try again";
            this.RepeatButton.UseVisualStyleBackColor = true;
            this.RepeatButton.Click += new System.EventHandler(this.RepeatButton_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TextSeparator.Properties.Resources.imgonline_com_ua_Resize_rjk9Xod2Sd78i7xb;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.RepeatButton);
            this.Controls.Add(this.ResultTextBox);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextSeparator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button RepeatButton;
    }
}