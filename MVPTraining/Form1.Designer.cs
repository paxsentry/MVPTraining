namespace MVPTraining
{
    partial class StartingForm
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
            this.zoltanControl1 = new MVPTraining.ZoltanControl();
            this.zoltanControl2 = new MVPTraining.ZoltanControl();
            this.SuspendLayout();
            // 
            // zoltanControl1
            // 
            this.zoltanControl1.Location = new System.Drawing.Point(12, 12);
            this.zoltanControl1.Name = "zoltanControl1";
            this.zoltanControl1.Size = new System.Drawing.Size(336, 71);
            this.zoltanControl1.TabIndex = 0;
            // 
            // zoltanControl2
            // 
            this.zoltanControl2.Location = new System.Drawing.Point(12, 76);
            this.zoltanControl2.Name = "zoltanControl2";
            this.zoltanControl2.Size = new System.Drawing.Size(371, 74);
            this.zoltanControl2.TabIndex = 1;
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 158);
            this.Controls.Add(this.zoltanControl2);
            this.Controls.Add(this.zoltanControl1);
            this.Name = "StartingForm";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private ZoltanControl zoltanControl1;
        private ZoltanControl zoltanControl2;
    }
}

