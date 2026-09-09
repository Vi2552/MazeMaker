namespace MazeMaker
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
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbCellWidth = new System.Windows.Forms.TrackBar();
            this.lblCellWidth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSpeedset = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkPause = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCellWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeedset)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.Black;
            this.pbCanvas.Location = new System.Drawing.Point(106, 104);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(846, 602);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1031, 104);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 602);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // tbCellWidth
            // 
            this.tbCellWidth.Location = new System.Drawing.Point(332, 11);
            this.tbCellWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCellWidth.Maximum = 80;
            this.tbCellWidth.Minimum = 10;
            this.tbCellWidth.Name = "tbCellWidth";
            this.tbCellWidth.Size = new System.Drawing.Size(388, 69);
            this.tbCellWidth.TabIndex = 2;
            this.tbCellWidth.Value = 80;
            this.tbCellWidth.Scroll += new System.EventHandler(this.tbCellWidth_Scroll);
            // 
            // lblCellWidth
            // 
            this.lblCellWidth.AutoSize = true;
            this.lblCellWidth.Location = new System.Drawing.Point(502, 10);
            this.lblCellWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCellWidth.Name = "lblCellWidth";
            this.lblCellWidth.Size = new System.Drawing.Size(18, 20);
            this.lblCellWidth.TabIndex = 3;
            this.lblCellWidth.Text = "_";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Grid Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(825, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Speed Set";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 6;
            // 
            // tbSpeedset
            // 
            this.tbSpeedset.Location = new System.Drawing.Point(958, 10);
            this.tbSpeedset.Maximum = 1000;
            this.tbSpeedset.Name = "tbSpeedset";
            this.tbSpeedset.Size = new System.Drawing.Size(388, 69);
            this.tbSpeedset.TabIndex = 7;
            this.tbSpeedset.Value = 500;
            this.tbSpeedset.Scroll += new System.EventHandler(this.tbSpeedset_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1066, 711);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stack";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ChkPause
            // 
            this.ChkPause.AutoSize = true;
            this.ChkPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkPause.Location = new System.Drawing.Point(1414, 33);
            this.ChkPause.Name = "ChkPause";
            this.ChkPause.Size = new System.Drawing.Size(119, 33);
            this.ChkPause.TabIndex = 9;
            this.ChkPause.Text = "Pause?";
            this.ChkPause.UseVisualStyleBackColor = true;
            this.ChkPause.CheckedChanged += new System.EventHandler(this.ChkPause_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 731);
            this.Controls.Add(this.ChkPause);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSpeedset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCellWidth);
            this.Controls.Add(this.lblCellWidth);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pbCanvas);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCellWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeedset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TrackBar tbCellWidth;
        private System.Windows.Forms.Label lblCellWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbSpeedset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ChkPause;
    }
}

