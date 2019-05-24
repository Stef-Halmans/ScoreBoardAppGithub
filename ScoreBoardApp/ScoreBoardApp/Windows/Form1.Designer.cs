﻿namespace ScoreBoardApp
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Player1Score = new System.Windows.Forms.Label();
            this.TakeDownButton1 = new System.Windows.Forms.Button();
            this.HitButton1 = new System.Windows.Forms.Button();
            this.KickButton1 = new System.Windows.Forms.Button();
            this.Player2Score = new System.Windows.Forms.Label();
            this.TakeDownButton2 = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.HitButton2 = new System.Windows.Forms.Button();
            this.KickButton2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Header});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(43, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(296, 579);
            this.listView1.TabIndex = 0;
            this.listView1.TileSize = new System.Drawing.Size(500, 66);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Header
            // 
            this.Header.Text = "Hit";
            this.Header.Width = 300;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Player1Score);
            this.splitContainer1.Panel1.Controls.Add(this.TakeDownButton1);
            this.splitContainer1.Panel1.Controls.Add(this.HitButton1);
            this.splitContainer1.Panel1.Controls.Add(this.KickButton1);
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Player2Score);
            this.splitContainer1.Panel2.Controls.Add(this.TakeDownButton2);
            this.splitContainer1.Panel2.Controls.Add(this.listView3);
            this.splitContainer1.Panel2.Controls.Add(this.HitButton2);
            this.splitContainer1.Panel2.Controls.Add(this.KickButton2);
            this.splitContainer1.Size = new System.Drawing.Size(1888, 992);
            this.splitContainer1.SplitterDistance = 939;
            this.splitContainer1.TabIndex = 3;
            // 
            // Player1Score
            // 
            this.Player1Score.AutoSize = true;
            this.Player1Score.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Player1Score.Cursor = System.Windows.Forms.Cursors.Default;
            this.Player1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Score.Location = new System.Drawing.Point(395, 89);
            this.Player1Score.Margin = new System.Windows.Forms.Padding(0);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(477, 340);
            this.Player1Score.TabIndex = 0;
            this.Player1Score.Text = "10";
            this.Player1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TakeDownButton1
            // 
            this.TakeDownButton1.Location = new System.Drawing.Point(672, 743);
            this.TakeDownButton1.Name = "TakeDownButton1";
            this.TakeDownButton1.Size = new System.Drawing.Size(200, 200);
            this.TakeDownButton1.TabIndex = 4;
            this.TakeDownButton1.Text = "TakeDown";
            this.TakeDownButton1.UseVisualStyleBackColor = true;
            this.TakeDownButton1.Click += new System.EventHandler(this.TakeDownButton1_Click);
            // 
            // HitButton1
            // 
            this.HitButton1.Location = new System.Drawing.Point(373, 743);
            this.HitButton1.Name = "HitButton1";
            this.HitButton1.Size = new System.Drawing.Size(200, 200);
            this.HitButton1.TabIndex = 3;
            this.HitButton1.Text = "Stoot";
            this.HitButton1.UseVisualStyleBackColor = true;
            this.HitButton1.Click += new System.EventHandler(this.HitButton1_Click);
            // 
            // KickButton1
            // 
            this.KickButton1.Location = new System.Drawing.Point(55, 743);
            this.KickButton1.Name = "KickButton1";
            this.KickButton1.Size = new System.Drawing.Size(200, 200);
            this.KickButton1.TabIndex = 2;
            this.KickButton1.Text = "Trap";
            this.KickButton1.UseVisualStyleBackColor = true;
            this.KickButton1.Click += new System.EventHandler(this.KickButton1_Click);
            // 
            // Player2Score
            // 
            this.Player2Score.AutoSize = true;
            this.Player2Score.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Player2Score.Cursor = System.Windows.Forms.Cursors.Default;
            this.Player2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Score.Location = new System.Drawing.Point(60, 89);
            this.Player2Score.Margin = new System.Windows.Forms.Padding(0);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(477, 340);
            this.Player2Score.TabIndex = 8;
            this.Player2Score.Text = "10";
            this.Player2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player2Score.UseMnemonic = false;
            // 
            // TakeDownButton2
            // 
            this.TakeDownButton2.Location = new System.Drawing.Point(680, 743);
            this.TakeDownButton2.Name = "TakeDownButton2";
            this.TakeDownButton2.Size = new System.Drawing.Size(200, 200);
            this.TakeDownButton2.TabIndex = 7;
            this.TakeDownButton2.Text = "TakeDown";
            this.TakeDownButton2.UseVisualStyleBackColor = true;
            this.TakeDownButton2.Click += new System.EventHandler(this.TakeDownButton2_Click);
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(610, 57);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(296, 579);
            this.listView3.TabIndex = 2;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // HitButton2
            // 
            this.HitButton2.Location = new System.Drawing.Point(381, 743);
            this.HitButton2.Name = "HitButton2";
            this.HitButton2.Size = new System.Drawing.Size(200, 200);
            this.HitButton2.TabIndex = 6;
            this.HitButton2.Text = "Stoot";
            this.HitButton2.UseVisualStyleBackColor = true;
            this.HitButton2.Click += new System.EventHandler(this.HitButton2_Click);
            // 
            // KickButton2
            // 
            this.KickButton2.Location = new System.Drawing.Point(63, 743);
            this.KickButton2.Name = "KickButton2";
            this.KickButton2.Size = new System.Drawing.Size(200, 200);
            this.KickButton2.TabIndex = 5;
            this.KickButton2.Text = "Trap";
            this.KickButton2.UseVisualStyleBackColor = true;
            this.KickButton2.Click += new System.EventHandler(this.KickButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Button TakeDownButton1;
        private System.Windows.Forms.Button HitButton1;
        private System.Windows.Forms.Button KickButton1;
        private System.Windows.Forms.Button TakeDownButton2;
        private System.Windows.Forms.Button HitButton2;
        private System.Windows.Forms.Button KickButton2;
        private System.Windows.Forms.ColumnHeader Header;
        private System.Windows.Forms.Label Player1Score;
        private System.Windows.Forms.Label Player2Score;
    }
}

