namespace AsyncExercises
{
    partial class WebRequestForm
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
            this.webRequestTextBox = new System.Windows.Forms.TextBox();
            this.synchButton = new System.Windows.Forms.Button();
            this.asyncCallbackButton = new System.Windows.Forms.Button();
            this.asyncKeywordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webRequestTextBox
            // 
            this.webRequestTextBox.Location = new System.Drawing.Point(12, 21);
            this.webRequestTextBox.Multiline = true;
            this.webRequestTextBox.Name = "webRequestTextBox";
            this.webRequestTextBox.Size = new System.Drawing.Size(760, 364);
            this.webRequestTextBox.TabIndex = 0;
            // 
            // synchButton
            // 
            this.synchButton.Location = new System.Drawing.Point(12, 408);
            this.synchButton.Name = "synchButton";
            this.synchButton.Size = new System.Drawing.Size(166, 23);
            this.synchButton.TabIndex = 1;
            this.synchButton.Text = "Sync ";
            this.synchButton.UseVisualStyleBackColor = true;
            this.synchButton.Click += new System.EventHandler(this.synchButton_Click);
            // 
            // asyncCallbackButton
            // 
            this.asyncCallbackButton.Location = new System.Drawing.Point(312, 408);
            this.asyncCallbackButton.Name = "asyncCallbackButton";
            this.asyncCallbackButton.Size = new System.Drawing.Size(166, 23);
            this.asyncCallbackButton.TabIndex = 2;
            this.asyncCallbackButton.Text = "Async Callback";
            this.asyncCallbackButton.UseVisualStyleBackColor = true;
            this.asyncCallbackButton.Click += new System.EventHandler(this.asyncCallbackButton_Click);
            // 
            // asyncKeywordButton
            // 
            this.asyncKeywordButton.Location = new System.Drawing.Point(606, 408);
            this.asyncKeywordButton.Name = "asyncKeywordButton";
            this.asyncKeywordButton.Size = new System.Drawing.Size(166, 23);
            this.asyncKeywordButton.TabIndex = 3;
            this.asyncKeywordButton.Text = "Async Keyword";
            this.asyncKeywordButton.UseVisualStyleBackColor = true;
            this.asyncKeywordButton.Click += new System.EventHandler(this.asyncKeywordButton_Click);
            // 
            // WebRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.asyncKeywordButton);
            this.Controls.Add(this.asyncCallbackButton);
            this.Controls.Add(this.synchButton);
            this.Controls.Add(this.webRequestTextBox);
            this.Name = "WebRequestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox webRequestTextBox;
        private System.Windows.Forms.Button synchButton;
        private System.Windows.Forms.Button asyncCallbackButton;
        private System.Windows.Forms.Button asyncKeywordButton;
    }
}

