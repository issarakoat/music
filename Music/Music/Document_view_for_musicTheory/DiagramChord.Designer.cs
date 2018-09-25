namespace Document_view_for_musicTheory
{
    partial class DiagramChord
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
            this.pictureBox_mode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_mode
            // 
            this.pictureBox_mode.Location = new System.Drawing.Point(10, 13);
            this.pictureBox_mode.Name = "pictureBox_mode";
            this.pictureBox_mode.Size = new System.Drawing.Size(760, 1000);
            this.pictureBox_mode.TabIndex = 2;
            this.pictureBox_mode.TabStop = false;
            this.pictureBox_mode.Click += new System.EventHandler(this.pictureBox_mode_Click);
            // 
            // DiagramChord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 644);
            this.Controls.Add(this.pictureBox_mode);
            this.Name = "DiagramChord";
            this.Text = "DiagramChord";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_mode;
    }
}