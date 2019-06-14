namespace ScoreBoardApp.Windows
{
    partial class ScoreBoard
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Score1 = new System.Windows.Forms.Label();
            this.Score2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Score1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Score2);
            this.splitContainer1.Size = new System.Drawing.Size(1422, 697);
            this.splitContainer1.SplitterDistance = 702;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 1;
            // 
            // Score1
            // 
            this.Score1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Score1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.Score1.ForeColor = System.Drawing.Color.Black;
            this.Score1.Location = new System.Drawing.Point(140, 147);
            this.Score1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Score1.Name = "Score1";
            this.Score1.Size = new System.Drawing.Size(416, 355);
            this.Score1.TabIndex = 0;
            this.Score1.Text = "0";
            this.Score1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Score2
            // 
            this.Score2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Score2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.Score2.ForeColor = System.Drawing.Color.Black;
            this.Score2.Location = new System.Drawing.Point(155, 160);
            this.Score2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(416, 355);
            this.Score2.TabIndex = 1;
            this.Score2.Text = "0";
            this.Score2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 697);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ScoreBoard";
            this.Text = "ScoreBoard";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label Score1;
        private System.Windows.Forms.Label Score2;
    }
}