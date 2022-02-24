
namespace SCCS403_WS_13
{
    partial class PictureBox_1
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
            this.radHamster = new System.Windows.Forms.RadioButton();
            this.picb1 = new System.Windows.Forms.PictureBox();
            this.radShark = new System.Windows.Forms.RadioButton();
            this.radSnake = new System.Windows.Forms.RadioButton();
            this.radTiger = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picb1)).BeginInit();
            this.SuspendLayout();
            // 
            // radHamster
            // 
            this.radHamster.AutoSize = true;
            this.radHamster.Location = new System.Drawing.Point(221, 149);
            this.radHamster.Name = "radHamster";
            this.radHamster.Size = new System.Drawing.Size(70, 19);
            this.radHamster.TabIndex = 0;
            this.radHamster.TabStop = true;
            this.radHamster.Text = "Hamster";
            this.radHamster.UseVisualStyleBackColor = true;
            this.radHamster.CheckedChanged += new System.EventHandler(this.radHamster_CheckedChanged);
            // 
            // picb1
            // 
            this.picb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picb1.Location = new System.Drawing.Point(386, 106);
            this.picb1.Name = "picb1";
            this.picb1.Size = new System.Drawing.Size(284, 261);
            this.picb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb1.TabIndex = 1;
            this.picb1.TabStop = false;
            // 
            // radShark
            // 
            this.radShark.AutoSize = true;
            this.radShark.Location = new System.Drawing.Point(221, 174);
            this.radShark.Name = "radShark";
            this.radShark.Size = new System.Drawing.Size(54, 19);
            this.radShark.TabIndex = 0;
            this.radShark.TabStop = true;
            this.radShark.Text = "Shark";
            this.radShark.UseVisualStyleBackColor = true;
            this.radShark.CheckedChanged += new System.EventHandler(this.radShark_CheckedChanged);
            // 
            // radSnake
            // 
            this.radSnake.AutoSize = true;
            this.radSnake.Location = new System.Drawing.Point(221, 199);
            this.radSnake.Name = "radSnake";
            this.radSnake.Size = new System.Drawing.Size(56, 19);
            this.radSnake.TabIndex = 0;
            this.radSnake.TabStop = true;
            this.radSnake.Text = "Snake";
            this.radSnake.UseVisualStyleBackColor = true;
            this.radSnake.CheckedChanged += new System.EventHandler(this.radSnake_CheckedChanged);
            // 
            // radTiger
            // 
            this.radTiger.AutoSize = true;
            this.radTiger.Location = new System.Drawing.Point(221, 224);
            this.radTiger.Name = "radTiger";
            this.radTiger.Size = new System.Drawing.Size(51, 19);
            this.radTiger.TabIndex = 0;
            this.radTiger.TabStop = true;
            this.radTiger.Text = "Tiger";
            this.radTiger.UseVisualStyleBackColor = true;
            this.radTiger.CheckedChanged += new System.EventHandler(this.radTiger_CheckedChanged);
            // 
            // PictureBox_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picb1);
            this.Controls.Add(this.radTiger);
            this.Controls.Add(this.radSnake);
            this.Controls.Add(this.radShark);
            this.Controls.Add(this.radHamster);
            this.Name = "PictureBox_1";
            this.Text = "Animals";
            ((System.ComponentModel.ISupportInitialize)(this.picb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radHamster;
        private System.Windows.Forms.PictureBox picb1;
        private System.Windows.Forms.RadioButton radShark;
        private System.Windows.Forms.RadioButton radSnake;
        private System.Windows.Forms.RadioButton radTiger;
    }
}