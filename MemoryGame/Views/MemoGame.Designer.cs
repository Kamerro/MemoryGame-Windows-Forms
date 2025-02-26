namespace MemoryGame
{
    partial class MemoGame
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.lblPoints = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.tickAfterReveal = new System.Windows.Forms.Timer(this.components);
            this.timerAllTime = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.optionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(333, 226);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1626, 770);
            this.mainPanel.TabIndex = 0;
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.lblPoints);
            this.optionsPanel.Controls.Add(this.btnNewGame);
            this.optionsPanel.Controls.Add(this.lblTimeLeft);
            this.optionsPanel.Location = new System.Drawing.Point(333, 128);
            this.optionsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(1626, 72);
            this.optionsPanel.TabIndex = 1;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPoints.Location = new System.Drawing.Point(1204, 16);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(172, 38);
            this.lblPoints.TabIndex = 3;
            this.lblPoints.Text = "Points:0/6";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Black;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNewGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNewGame.Location = new System.Drawing.Point(542, 4);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(298, 68);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimeLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTimeLeft.Location = new System.Drawing.Point(20, 16);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(236, 38);
            this.lblTimeLeft.TabIndex = 2;
            this.lblTimeLeft.Text = "Time left: 30 s";
            // 
            // tickAfterReveal
            // 
            this.tickAfterReveal.Interval = 1000;
            this.tickAfterReveal.Tick += new System.EventHandler(this.tickAfterReveal_Tick);
            // 
            // timerAllTime
            // 
            this.timerAllTime.Enabled = true;
            this.timerAllTime.Interval = 1000;
            this.timerAllTime.Tick += new System.EventHandler(this.timerAllTime_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 120);
            this.button1.TabIndex = 2;
            this.button1.Text = "switch to match problems";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MemoGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1924, 929);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MemoGame";
            this.Text = "Memory game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.optionsPanel.ResumeLayout(false);
            this.optionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Timer tickAfterReveal;
        private System.Windows.Forms.Timer timerAllTime;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Button button1;
    }
}

