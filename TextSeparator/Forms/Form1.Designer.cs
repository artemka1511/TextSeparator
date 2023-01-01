
namespace TextSeparator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.SelectTextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.BackgroundImage = global::TextSeparator.Properties.Resources.imgonline_com_ua_Resize_yyG6gjHExvIMa0S;
            this.SelectFileButton.Font = new System.Drawing.Font("Consolas", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectFileButton.Location = new System.Drawing.Point(25, 247);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(200, 100);
            this.SelectFileButton.TabIndex = 0;
            this.SelectFileButton.Text = "File";
            this.SelectFileButton.UseVisualStyleBackColor = false;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // SelectTextButton
            // 
            this.SelectTextButton.BackgroundImage = global::TextSeparator.Properties.Resources.imgonline_com_ua_Resize_yyG6gjHExvIMa0S;
            this.SelectTextButton.Font = new System.Drawing.Font("Consolas", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectTextButton.Location = new System.Drawing.Point(260, 247);
            this.SelectTextButton.Name = "SelectTextButton";
            this.SelectTextButton.Size = new System.Drawing.Size(200, 100);
            this.SelectTextButton.TabIndex = 1;
            this.SelectTextButton.Text = "Text";
            this.SelectTextButton.UseVisualStyleBackColor = false;
            this.SelectTextButton.Click += new System.EventHandler(this.SelectTextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(73, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "TextSeparator";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TextSeparator.Properties.Resources.imgonline_com_ua_Resize_rjk9Xod2Sd78i7xb;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectTextButton);
            this.Controls.Add(this.SelectFileButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextSeparator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Button SelectTextButton;
        private System.Windows.Forms.Label label1;
    }
}

