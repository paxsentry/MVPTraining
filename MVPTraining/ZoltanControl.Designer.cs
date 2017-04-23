namespace MVPTraining
{
    partial class ZoltanControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ZCLabel = new System.Windows.Forms.Label();
            this.ZCTextBox = new System.Windows.Forms.TextBox();
            this.ZCButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ZCLabel
            // 
            this.ZCLabel.AutoSize = true;
            this.ZCLabel.Location = new System.Drawing.Point(4, 4);
            this.ZCLabel.Name = "ZCLabel";
            this.ZCLabel.Size = new System.Drawing.Size(55, 13);
            this.ZCLabel.TabIndex = 0;
            this.ZCLabel.Text = "SomeText";
            // 
            // ZCTextBox
            // 
            this.ZCTextBox.Location = new System.Drawing.Point(65, 4);
            this.ZCTextBox.Name = "ZCTextBox";
            this.ZCTextBox.Size = new System.Drawing.Size(243, 20);
            this.ZCTextBox.TabIndex = 1;
            // 
            // ZCButton
            // 
            this.ZCButton.Location = new System.Drawing.Point(7, 30);
            this.ZCButton.Name = "ZCButton";
            this.ZCButton.Size = new System.Drawing.Size(75, 23);
            this.ZCButton.TabIndex = 2;
            this.ZCButton.Text = "Press Me!";
            this.ZCButton.UseVisualStyleBackColor = true;
            // 
            // ZoltanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ZCButton);
            this.Controls.Add(this.ZCTextBox);
            this.Controls.Add(this.ZCLabel);
            this.Name = "ZoltanControl";
            this.Size = new System.Drawing.Size(473, 157);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ZCLabel;
        private System.Windows.Forms.TextBox ZCTextBox;
        private System.Windows.Forms.Button ZCButton;
    }
}
