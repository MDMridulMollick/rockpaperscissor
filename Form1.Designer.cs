namespace RPSGame
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
            this.pcboxhuman = new System.Windows.Forms.PictureBox();
            this.pcboxcomputer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblplayer = new System.Windows.Forms.Label();
            this.lblcom = new System.Windows.Forms.Label();
            this.btnrock = new System.Windows.Forms.Button();
            this.btnpaper = new System.Windows.Forms.Button();
            this.btnscissor = new System.Windows.Forms.Button();
            this.tbhuman = new System.Windows.Forms.TextBox();
            this.tbroud = new System.Windows.Forms.TextBox();
            this.tbcomputer = new System.Windows.Forms.TextBox();
            this.lblround = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblhuman = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtry = new System.Windows.Forms.TextBox();
            this.lbltie = new System.Windows.Forms.Label();
            this.tbtie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbtime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxhuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxcomputer)).BeginInit();
            this.SuspendLayout();
            // 
            // pcboxhuman
            // 
            this.pcboxhuman.Location = new System.Drawing.Point(55, 75);
            this.pcboxhuman.Name = "pcboxhuman";
            this.pcboxhuman.Size = new System.Drawing.Size(219, 359);
            this.pcboxhuman.TabIndex = 0;
            this.pcboxhuman.TabStop = false;
            // 
            // pcboxcomputer
            // 
            this.pcboxcomputer.Location = new System.Drawing.Point(427, 75);
            this.pcboxcomputer.Name = "pcboxcomputer";
            this.pcboxcomputer.Size = new System.Drawing.Size(219, 359);
            this.pcboxcomputer.TabIndex = 1;
            this.pcboxcomputer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "VS";
            // 
            // lblplayer
            // 
            this.lblplayer.AutoSize = true;
            this.lblplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblplayer.Location = new System.Drawing.Point(97, 18);
            this.lblplayer.Name = "lblplayer";
            this.lblplayer.Size = new System.Drawing.Size(96, 32);
            this.lblplayer.TabIndex = 3;
            this.lblplayer.Text = "Player";
            // 
            // lblcom
            // 
            this.lblcom.AutoSize = true;
            this.lblcom.BackColor = System.Drawing.Color.Aqua;
            this.lblcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcom.Location = new System.Drawing.Point(454, 18);
            this.lblcom.Name = "lblcom";
            this.lblcom.Size = new System.Drawing.Size(139, 32);
            this.lblcom.TabIndex = 4;
            this.lblcom.Text = "Computer";
            // 
            // btnrock
            // 
            this.btnrock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnrock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrock.Location = new System.Drawing.Point(103, 486);
            this.btnrock.Name = "btnrock";
            this.btnrock.Size = new System.Drawing.Size(117, 63);
            this.btnrock.TabIndex = 5;
            this.btnrock.Text = "Rock";
            this.btnrock.UseVisualStyleBackColor = false;
            this.btnrock.Click += new System.EventHandler(this.btnrock_Click);
            // 
            // btnpaper
            // 
            this.btnpaper.BackColor = System.Drawing.Color.Fuchsia;
            this.btnpaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpaper.Location = new System.Drawing.Point(253, 490);
            this.btnpaper.Name = "btnpaper";
            this.btnpaper.Size = new System.Drawing.Size(135, 59);
            this.btnpaper.TabIndex = 6;
            this.btnpaper.Text = "Paper";
            this.btnpaper.UseVisualStyleBackColor = false;
            this.btnpaper.Click += new System.EventHandler(this.btnpaper_Click);
            // 
            // btnscissor
            // 
            this.btnscissor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnscissor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnscissor.Location = new System.Drawing.Point(427, 490);
            this.btnscissor.Name = "btnscissor";
            this.btnscissor.Size = new System.Drawing.Size(133, 59);
            this.btnscissor.TabIndex = 7;
            this.btnscissor.Text = "Scissor";
            this.btnscissor.UseVisualStyleBackColor = false;
            this.btnscissor.Click += new System.EventHandler(this.btnscissor_Click);
            // 
            // tbhuman
            // 
            this.tbhuman.Location = new System.Drawing.Point(773, 142);
            this.tbhuman.Name = "tbhuman";
            this.tbhuman.Size = new System.Drawing.Size(100, 26);
            this.tbhuman.TabIndex = 8;
            // 
            // tbroud
            // 
            this.tbroud.Location = new System.Drawing.Point(773, 75);
            this.tbroud.Name = "tbroud";
            this.tbroud.ReadOnly = true;
            this.tbroud.Size = new System.Drawing.Size(149, 26);
            this.tbroud.TabIndex = 9;
            // 
            // tbcomputer
            // 
            this.tbcomputer.Location = new System.Drawing.Point(773, 201);
            this.tbcomputer.Name = "tbcomputer";
            this.tbcomputer.ReadOnly = true;
            this.tbcomputer.Size = new System.Drawing.Size(100, 26);
            this.tbcomputer.TabIndex = 10;
            // 
            // lblround
            // 
            this.lblround.AutoSize = true;
            this.lblround.Location = new System.Drawing.Point(670, 75);
            this.lblround.Name = "lblround";
            this.lblround.Size = new System.Drawing.Size(36, 20);
            this.lblround.TabIndex = 11;
            this.lblround.Text = "Win";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(670, 207);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(79, 20);
            this.lblComputer.TabIndex = 12;
            this.lblComputer.Text = "Computer";
            // 
            // lblhuman
            // 
            this.lblhuman.AutoSize = true;
            this.lblhuman.Location = new System.Drawing.Point(670, 142);
            this.lblhuman.Name = "lblhuman";
            this.lblhuman.Size = new System.Drawing.Size(61, 20);
            this.lblhuman.TabIndex = 13;
            this.lblhuman.Text = "Human";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(740, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 59);
            this.button1.TabIndex = 14;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(633, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Round";
            // 
            // tbtry
            // 
            this.tbtry.BackColor = System.Drawing.Color.Aqua;
            this.tbtry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtry.Location = new System.Drawing.Point(773, 24);
            this.tbtry.Name = "tbtry";
            this.tbtry.Size = new System.Drawing.Size(83, 35);
            this.tbtry.TabIndex = 16;
            // 
            // lbltie
            // 
            this.lbltie.AutoSize = true;
            this.lbltie.Location = new System.Drawing.Point(670, 251);
            this.lbltie.Name = "lbltie";
            this.lbltie.Size = new System.Drawing.Size(30, 20);
            this.lbltie.TabIndex = 18;
            this.lbltie.Text = "Tie";
            // 
            // tbtie
            // 
            this.tbtie.Location = new System.Drawing.Point(773, 245);
            this.tbtie.Name = "tbtie";
            this.tbtie.ReadOnly = true;
            this.tbtie.Size = new System.Drawing.Size(100, 26);
            this.tbtie.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(689, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Time";
            // 
            // tbtime
            // 
            this.tbtime.Location = new System.Drawing.Point(773, 326);
            this.tbtime.Name = "tbtime";
            this.tbtime.ReadOnly = true;
            this.tbtime.Size = new System.Drawing.Size(62, 26);
            this.tbtime.TabIndex = 20;
            this.tbtime.Text = "20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(858, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Second";
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(608, 486);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 47);
            this.button2.TabIndex = 22;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(934, 617);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbtime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltie);
            this.Controls.Add(this.tbtie);
            this.Controls.Add(this.tbtry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblhuman);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblround);
            this.Controls.Add(this.tbcomputer);
            this.Controls.Add(this.tbroud);
            this.Controls.Add(this.tbhuman);
            this.Controls.Add(this.btnscissor);
            this.Controls.Add(this.btnpaper);
            this.Controls.Add(this.btnrock);
            this.Controls.Add(this.lblcom);
            this.Controls.Add(this.lblplayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcboxcomputer);
            this.Controls.Add(this.pcboxhuman);
            this.Name = "Form1";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcboxhuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxcomputer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcboxhuman;
        private System.Windows.Forms.PictureBox pcboxcomputer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblplayer;
        private System.Windows.Forms.Label lblcom;
        private System.Windows.Forms.Button btnrock;
        private System.Windows.Forms.Button btnpaper;
        private System.Windows.Forms.Button btnscissor;
        private System.Windows.Forms.TextBox tbhuman;
        private System.Windows.Forms.TextBox tbroud;
        private System.Windows.Forms.TextBox tbcomputer;
        private System.Windows.Forms.Label lblround;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label lblhuman;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbtry;
        private System.Windows.Forms.Label lbltie;
        private System.Windows.Forms.TextBox tbtie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbtime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
    }
}

