namespace mvc_djview
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
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trkBeat = new System.Windows.Forms.TrackBar();
            this.pnlColor = new mvc_djview.BeatPanel();
            this.txtBPM = new mvc_djview.BeatTextBox();
            this.txtCurrentBPM = new mvc_djview.BeatTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBeat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(329, 22);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(218, 19);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBPM);
            this.groupBox1.Controls.Add(this.trkBeat);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Location = new System.Drawing.Point(39, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 116);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DJ Control";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCurrentBPM);
            this.groupBox2.Controls.Add(this.pnlColor);
            this.groupBox2.Location = new System.Drawing.Point(39, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 123);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DJ View";
            // 
            // trkBeat
            // 
            this.trkBeat.Location = new System.Drawing.Point(41, 63);
            this.trkBeat.Maximum = 255;
            this.trkBeat.Name = "trkBeat";
            this.trkBeat.Size = new System.Drawing.Size(252, 45);
            this.trkBeat.TabIndex = 3;
            this.trkBeat.Value = 120;
            this.trkBeat.Scroll += new System.EventHandler(this.trkBeat_Scroll);
            // 
            // pnlColor
            // 
            this.pnlColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.pnlColor.Location = new System.Drawing.Point(41, 59);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(264, 43);
            this.pnlColor.TabIndex = 1;
            // 
            // txtBPM
            // 
            this.txtBPM.Location = new System.Drawing.Point(41, 21);
            this.txtBPM.Name = "txtBPM";
            this.txtBPM.Size = new System.Drawing.Size(171, 20);
            this.txtBPM.TabIndex = 4;
            this.txtBPM.Text = "120";
            // 
            // txtCurrentBPM
            // 
            this.txtCurrentBPM.Location = new System.Drawing.Point(119, 33);
            this.txtCurrentBPM.Name = "txtCurrentBPM";
            this.txtCurrentBPM.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentBPM.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 350);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Name = "Form1";
            this.Text = "MVC Dj View";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBeat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private BeatPanel pnlColor;
        private System.Windows.Forms.TrackBar trkBeat;
        private BeatTextBox txtBPM;
        private BeatTextBox txtCurrentBPM;
    }
}

