namespace BrickBreakerUkol
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
            this.components = new System.ComponentModel.Container();
            this.txtScore = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.gameTImer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.White;
            this.txtScore.Location = new System.Drawing.Point(17, 16);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(110, 29);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Skóre: 0";
            this.txtScore.Click += new System.EventHandler(this.txtScore_Click);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.RoyalBlue;
            this.player.Location = new System.Drawing.Point(463, 606);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(133, 39);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Black;
            this.ball.Location = new System.Drawing.Point(503, 366);
            this.ball.Margin = new System.Windows.Forms.Padding(4);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(33, 28);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            this.ball.Paint += new System.Windows.Forms.PaintEventHandler(this.ball_Paint);
            // 
            // gameTImer
            // 
            this.gameTImer.Interval = 20;
            this.gameTImer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 660);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player);
            this.Controls.Add(this.txtScore);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "BrickBreaker-Ukol";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer gameTImer;
    }
}

