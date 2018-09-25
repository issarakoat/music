namespace Document_view_for_musicTheory
{
    partial class DiagramScale
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
            this.pictureBox_scale = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_scale)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_scale
            // 
            this.pictureBox_scale.Location = new System.Drawing.Point(10, 13);
            this.pictureBox_scale.Name = "pictureBox_scale";
            this.pictureBox_scale.Size = new System.Drawing.Size(760, 970);
            this.pictureBox_scale.TabIndex = 1;
            this.pictureBox_scale.TabStop = false;
            this.pictureBox_scale.Click += new System.EventHandler(this.pictureBox_mode_Click);
            // 
            // DiagramScale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 1051);
            this.Controls.Add(this.pictureBox_scale);
            this.Name = "DiagramScale";
            this.Text = "DiagramScale";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_scale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_scale;
    }
}