namespace Pong
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
            this.components = new System.ComponentModel.Container();
            this.paddle1 = new System.Windows.Forms.PictureBox();
            this.paddle2 = new System.Windows.Forms.PictureBox();
            this.aTimerPaddle = new System.Windows.Forms.Timer(this.components);
            this.aBall = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.P1Label = new System.Windows.Forms.Label();
            this.P2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).BeginInit();
            this.SuspendLayout();
            // 
            // paddle1
            // 
            this.paddle1.BackColor = System.Drawing.Color.White;
            this.paddle1.Location = new System.Drawing.Point(16, 215);
            this.paddle1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paddle1.Name = "paddle1";
            this.paddle1.Size = new System.Drawing.Size(13, 123);
            this.paddle1.TabIndex = 0;
            this.paddle1.TabStop = false;
            // 
            // paddle2
            // 
            this.paddle2.BackColor = System.Drawing.Color.White;
            this.paddle2.Location = new System.Drawing.Point(1037, 215);
            this.paddle2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paddle2.Name = "paddle2";
            this.paddle2.Size = new System.Drawing.Size(13, 123);
            this.paddle2.TabIndex = 1;
            this.paddle2.TabStop = false;
            // 
            // aTimerPaddle
            // 
            this.aTimerPaddle.Enabled = true;
            this.aTimerPaddle.Tick += new System.EventHandler(this.aTimerPaddle_Tick);
            // 
            // aBall
            // 
            this.aBall.BackColor = System.Drawing.Color.White;
            this.aBall.Location = new System.Drawing.Point(519, 265);
            this.aBall.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aBall.Name = "aBall";
            this.aBall.Size = new System.Drawing.Size(13, 12);
            this.aBall.TabIndex = 2;
            this.aBall.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(508, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 58);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // P1Label
            // 
            this.P1Label.AutoSize = true;
            this.P1Label.BackColor = System.Drawing.Color.Transparent;
            this.P1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Label.Location = new System.Drawing.Point(343, 102);
            this.P1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.P1Label.Name = "P1Label";
            this.P1Label.Size = new System.Drawing.Size(29, 31);
            this.P1Label.TabIndex = 6;
            this.P1Label.Text = "0";
            // 
            // P2Label
            // 
            this.P2Label.AutoSize = true;
            this.P2Label.BackColor = System.Drawing.Color.Transparent;
            this.P2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Label.Location = new System.Drawing.Point(660, 102);
            this.P2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.P2Label.Name = "P2Label";
            this.P2Label.Size = new System.Drawing.Size(29, 31);
            this.P2Label.TabIndex = 7;
            this.P2Label.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.P2Label);
            this.Controls.Add(this.P1Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aBall);
            this.Controls.Add(this.paddle2);
            this.Controls.Add(this.paddle1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.paddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paddle1;
        private System.Windows.Forms.PictureBox paddle2;
        public System.Windows.Forms.PictureBox aBall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label P1Label;
        private System.Windows.Forms.Label P2Label;
        public System.Windows.Forms.Timer aTimerPaddle;
    }
}

