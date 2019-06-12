namespace ScoreBoardApp
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NewHitInformation1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NoScoreButton1 = new System.Windows.Forms.Button();
            this.Player1Score = new System.Windows.Forms.Label();
            this.TakeDownButton1 = new System.Windows.Forms.Button();
            this.HitButton1 = new System.Windows.Forms.Button();
            this.KickButton1 = new System.Windows.Forms.Button();
            this.NewHitInformation2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NoScoreButton2 = new System.Windows.Forms.Button();
            this.Player2Score = new System.Windows.Forms.Label();
            this.TakeDownButton2 = new System.Windows.Forms.Button();
            this.HitButton2 = new System.Windows.Forms.Button();
            this.KickButton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.NewHitInformation1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.NoScoreButton1);
            this.splitContainer1.Panel1.Controls.Add(this.Player1Score);
            this.splitContainer1.Panel1.Controls.Add(this.TakeDownButton1);
            this.splitContainer1.Panel1.Controls.Add(this.HitButton1);
            this.splitContainer1.Panel1.Controls.Add(this.KickButton1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.NewHitInformation2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.NoScoreButton2);
            this.splitContainer1.Panel2.Controls.Add(this.Player2Score);
            this.splitContainer1.Panel2.Controls.Add(this.TakeDownButton2);
            this.splitContainer1.Panel2.Controls.Add(this.HitButton2);
            this.splitContainer1.Panel2.Controls.Add(this.KickButton2);
            this.splitContainer1.Size = new System.Drawing.Size(1062, 640);
            this.splitContainer1.SplitterDistance = 528;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 3;
            // 
            // NewHitInformation1
            // 
            this.NewHitInformation1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewHitInformation1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewHitInformation1.Font = new System.Drawing.Font("Microsoft YaHei", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewHitInformation1.Location = new System.Drawing.Point(15, 340);
            this.NewHitInformation1.Name = "NewHitInformation1";
            this.NewHitInformation1.Size = new System.Drawing.Size(501, 111);
            this.NewHitInformation1.TabIndex = 6;
            this.NewHitInformation1.Text = "Volgens de sensor is player1 geraakt was dit een stoot, een strap, een TakeDown o" +
    "f een helemaal niks?";
            this.NewHitInformation1.Visible = false;
            this.NewHitInformation1.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 71);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player 1";
            // 
            // NoScoreButton1
            // 
            this.NoScoreButton1.Location = new System.Drawing.Point(403, 479);
            this.NoScoreButton1.Margin = new System.Windows.Forms.Padding(2);
            this.NoScoreButton1.Name = "NoScoreButton1";
            this.NoScoreButton1.Size = new System.Drawing.Size(112, 129);
            this.NoScoreButton1.TabIndex = 5;
            this.NoScoreButton1.Text = "Geen score";
            this.NoScoreButton1.UseVisualStyleBackColor = true;
            this.NoScoreButton1.Click += new System.EventHandler(this.NoScoreButton1_Click);
            // 
            // Player1Score
            // 
            this.Player1Score.AutoSize = true;
            this.Player1Score.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Player1Score.Cursor = System.Windows.Forms.Cursors.Default;
            this.Player1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Score.Location = new System.Drawing.Point(127, 106);
            this.Player1Score.Margin = new System.Windows.Forms.Padding(0);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(285, 204);
            this.Player1Score.TabIndex = 0;
            this.Player1Score.Text = "10";
            this.Player1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TakeDownButton1
            // 
            this.TakeDownButton1.Location = new System.Drawing.Point(274, 479);
            this.TakeDownButton1.Margin = new System.Windows.Forms.Padding(2);
            this.TakeDownButton1.Name = "TakeDownButton1";
            this.TakeDownButton1.Size = new System.Drawing.Size(112, 129);
            this.TakeDownButton1.TabIndex = 4;
            this.TakeDownButton1.Text = "TakeDown";
            this.TakeDownButton1.UseVisualStyleBackColor = true;
            this.TakeDownButton1.Click += new System.EventHandler(this.TakeDownButton1_Click);
            // 
            // HitButton1
            // 
            this.HitButton1.Location = new System.Drawing.Point(144, 479);
            this.HitButton1.Margin = new System.Windows.Forms.Padding(2);
            this.HitButton1.Name = "HitButton1";
            this.HitButton1.Size = new System.Drawing.Size(112, 129);
            this.HitButton1.TabIndex = 3;
            this.HitButton1.Text = "Stoot";
            this.HitButton1.UseVisualStyleBackColor = true;
            this.HitButton1.Click += new System.EventHandler(this.HitButton1_Click);
            // 
            // KickButton1
            // 
            this.KickButton1.Location = new System.Drawing.Point(15, 479);
            this.KickButton1.Margin = new System.Windows.Forms.Padding(2);
            this.KickButton1.Name = "KickButton1";
            this.KickButton1.Size = new System.Drawing.Size(112, 129);
            this.KickButton1.TabIndex = 2;
            this.KickButton1.Text = "Trap";
            this.KickButton1.UseVisualStyleBackColor = true;
            this.KickButton1.Click += new System.EventHandler(this.KickButton1_Click);
            // 
            // NewHitInformation2
            // 
            this.NewHitInformation2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NewHitInformation2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewHitInformation2.Font = new System.Drawing.Font("Microsoft YaHei", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewHitInformation2.Location = new System.Drawing.Point(19, 340);
            this.NewHitInformation2.Name = "NewHitInformation2";
            this.NewHitInformation2.Size = new System.Drawing.Size(501, 111);
            this.NewHitInformation2.TabIndex = 7;
            this.NewHitInformation2.Text = "Volgens de sensor is player2 geraakt was dit een stoot, een strap, een TakeDown o" +
    "f een helemaal niks?";
            this.NewHitInformation2.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 71);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player 2";
            // 
            // NoScoreButton2
            // 
            this.NoScoreButton2.Location = new System.Drawing.Point(397, 479);
            this.NoScoreButton2.Margin = new System.Windows.Forms.Padding(2);
            this.NoScoreButton2.Name = "NoScoreButton2";
            this.NoScoreButton2.Size = new System.Drawing.Size(112, 129);
            this.NoScoreButton2.TabIndex = 9;
            this.NoScoreButton2.Text = "Geen score";
            this.NoScoreButton2.UseVisualStyleBackColor = true;
            this.NoScoreButton2.Click += new System.EventHandler(this.NoScoreButton2_Click);
            // 
            // Player2Score
            // 
            this.Player2Score.AutoSize = true;
            this.Player2Score.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Player2Score.Cursor = System.Windows.Forms.Cursors.Default;
            this.Player2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Score.Location = new System.Drawing.Point(122, 106);
            this.Player2Score.Margin = new System.Windows.Forms.Padding(0);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(285, 204);
            this.Player2Score.TabIndex = 8;
            this.Player2Score.Text = "10";
            this.Player2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player2Score.UseMnemonic = false;
            // 
            // TakeDownButton2
            // 
            this.TakeDownButton2.Location = new System.Drawing.Point(268, 479);
            this.TakeDownButton2.Margin = new System.Windows.Forms.Padding(2);
            this.TakeDownButton2.Name = "TakeDownButton2";
            this.TakeDownButton2.Size = new System.Drawing.Size(112, 129);
            this.TakeDownButton2.TabIndex = 7;
            this.TakeDownButton2.Text = "TakeDown";
            this.TakeDownButton2.UseVisualStyleBackColor = true;
            this.TakeDownButton2.Click += new System.EventHandler(this.TakeDownButton2_Click);
            // 
            // HitButton2
            // 
            this.HitButton2.Location = new System.Drawing.Point(141, 479);
            this.HitButton2.Margin = new System.Windows.Forms.Padding(2);
            this.HitButton2.Name = "HitButton2";
            this.HitButton2.Size = new System.Drawing.Size(112, 129);
            this.HitButton2.TabIndex = 6;
            this.HitButton2.Text = "Stoot";
            this.HitButton2.UseVisualStyleBackColor = true;
            this.HitButton2.Click += new System.EventHandler(this.HitButton2_Click);
            // 
            // KickButton2
            // 
            this.KickButton2.Location = new System.Drawing.Point(14, 479);
            this.KickButton2.Margin = new System.Windows.Forms.Padding(2);
            this.KickButton2.Name = "KickButton2";
            this.KickButton2.Size = new System.Drawing.Size(112, 129);
            this.KickButton2.TabIndex = 5;
            this.KickButton2.Text = "Trap";
            this.KickButton2.UseVisualStyleBackColor = true;
            this.KickButton2.Click += new System.EventHandler(this.KickButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1062, 640);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button TakeDownButton1;
        private System.Windows.Forms.Button HitButton1;
        private System.Windows.Forms.Button KickButton1;
        private System.Windows.Forms.Button TakeDownButton2;
        private System.Windows.Forms.Button HitButton2;
        private System.Windows.Forms.Button KickButton2;
        private System.Windows.Forms.Label Player1Score;
        private System.Windows.Forms.Label Player2Score;
        private System.Windows.Forms.Button NoScoreButton1;
        private System.Windows.Forms.Button NoScoreButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NewHitInformation1;
        private System.Windows.Forms.Label NewHitInformation2;
    }
}

