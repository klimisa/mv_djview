namespace mvp_djview
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
            this.txtCurrentBPM = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.txtBPM = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnSet = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCurrentBPM
            // 
            this.txtCurrentBPM.Location = new System.Drawing.Point(127, 33);
            this.txtCurrentBPM.Name = "txtCurrentBPM";
            this.txtCurrentBPM.Size = new System.Drawing.Size(93, 20);
            this.txtCurrentBPM.TabIndex = 0;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(321, 26);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlColor);
            this.groupBox2.Controls.Add(this.txtCurrentBPM);
            this.groupBox2.Location = new System.Drawing.Point(31, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 123);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DJ View";
            // 
            // pnlColor
            // 
            this.pnlColor.Location = new System.Drawing.Point(74, 69);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(200, 39);
            this.pnlColor.TabIndex = 1;
            // 
            // txtBPM
            // 
            this.txtBPM.Location = new System.Drawing.Point(51, 21);
            this.txtBPM.Name = "txtBPM";
            this.txtBPM.Size = new System.Drawing.Size(161, 20);
            this.txtBPM.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBPM);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Location = new System.Drawing.Point(31, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 116);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DJ Control";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(36, 62);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(273, 45);
            this.trackBar1.TabIndex = 3;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(218, 19);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 350);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MVP Dj View";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentBPM;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.TextBox txtBPM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnSet;
    }
}

