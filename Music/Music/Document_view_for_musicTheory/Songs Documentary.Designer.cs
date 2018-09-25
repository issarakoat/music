namespace Document_view_for_musicTheory
{
    partial class Songs_Documentary
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
            this.label_chords_used = new System.Windows.Forms.Label();
            this.label_recommended_scale = new System.Windows.Forms.Label();
            this.textBox_chordsUsed = new System.Windows.Forms.TextBox();
            this.listBox_scales = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label_chords_used
            // 
            this.label_chords_used.AutoSize = true;
            this.label_chords_used.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chords_used.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_chords_used.Location = new System.Drawing.Point(30, 24);
            this.label_chords_used.Name = "label_chords_used";
            this.label_chords_used.Size = new System.Drawing.Size(190, 36);
            this.label_chords_used.TabIndex = 0;
            this.label_chords_used.Text = "Chords Used";
            // 
            // label_recommended_scale
            // 
            this.label_recommended_scale.AutoSize = true;
            this.label_recommended_scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_recommended_scale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_recommended_scale.Location = new System.Drawing.Point(32, 478);
            this.label_recommended_scale.Name = "label_recommended_scale";
            this.label_recommended_scale.Size = new System.Drawing.Size(177, 36);
            this.label_recommended_scale.TabIndex = 1;
            this.label_recommended_scale.Text = "List of Scale";
            // 
            // textBox_chordsUsed
            // 
            this.textBox_chordsUsed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_chordsUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_chordsUsed.Location = new System.Drawing.Point(36, 88);
            this.textBox_chordsUsed.Multiline = true;
            this.textBox_chordsUsed.Name = "textBox_chordsUsed";
            this.textBox_chordsUsed.ReadOnly = true;
            this.textBox_chordsUsed.Size = new System.Drawing.Size(687, 272);
            this.textBox_chordsUsed.TabIndex = 2;
            // 
            // listBox_scales
            // 
            this.listBox_scales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox_scales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_scales.FormattingEnabled = true;
            this.listBox_scales.ItemHeight = 30;
            this.listBox_scales.Location = new System.Drawing.Point(36, 543);
            this.listBox_scales.Name = "listBox_scales";
            this.listBox_scales.Size = new System.Drawing.Size(687, 304);
            this.listBox_scales.TabIndex = 3;
            // 
            // Songs_Documentary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(914, 1016);
            this.Controls.Add(this.listBox_scales);
            this.Controls.Add(this.textBox_chordsUsed);
            this.Controls.Add(this.label_recommended_scale);
            this.Controls.Add(this.label_chords_used);
            this.Name = "Songs_Documentary";
            this.Text = "Songs Documentary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_chords_used;
        private System.Windows.Forms.Label label_recommended_scale;
        private System.Windows.Forms.TextBox textBox_chordsUsed;
        private System.Windows.Forms.ListBox listBox_scales;
    }
}