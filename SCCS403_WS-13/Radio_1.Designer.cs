
namespace SCCS403_WS_13
{
    partial class Radio_1
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
            this.radRed = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radCyan = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radOrange = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radPink = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(161, 117);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(45, 19);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(141, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "ปรับสีพื้นหลังของฟอร์ม";
            // 
            // radCyan
            // 
            this.radCyan.AutoSize = true;
            this.radCyan.Location = new System.Drawing.Point(271, 117);
            this.radCyan.Name = "radCyan";
            this.radCyan.Size = new System.Drawing.Size(52, 19);
            this.radCyan.TabIndex = 0;
            this.radCyan.TabStop = true;
            this.radCyan.Text = "Cyan";
            this.radCyan.UseVisualStyleBackColor = true;
            this.radCyan.CheckedChanged += new System.EventHandler(this.radCyan_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Location = new System.Drawing.Point(161, 142);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(56, 19);
            this.radGreen.TabIndex = 0;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radOrange
            // 
            this.radOrange.AutoSize = true;
            this.radOrange.Location = new System.Drawing.Point(271, 142);
            this.radOrange.Name = "radOrange";
            this.radOrange.Size = new System.Drawing.Size(64, 19);
            this.radOrange.TabIndex = 0;
            this.radOrange.TabStop = true;
            this.radOrange.Text = "Orange";
            this.radOrange.UseVisualStyleBackColor = true;
            this.radOrange.CheckedChanged += new System.EventHandler(this.radOrange_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(161, 167);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(48, 19);
            this.radBlue.TabIndex = 0;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radPink
            // 
            this.radPink.AutoSize = true;
            this.radPink.Location = new System.Drawing.Point(271, 167);
            this.radPink.Name = "radPink";
            this.radPink.Size = new System.Drawing.Size(48, 19);
            this.radPink.TabIndex = 0;
            this.radPink.TabStop = true;
            this.radPink.Text = "Pink";
            this.radPink.UseVisualStyleBackColor = true;
            this.radPink.CheckedChanged += new System.EventHandler(this.radPink_CheckedChanged);
            // 
            // Radio_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radPink);
            this.Controls.Add(this.radOrange);
            this.Controls.Add(this.radCyan);
            this.Controls.Add(this.radBlue);
            this.Controls.Add(this.radGreen);
            this.Controls.Add(this.radRed);
            this.Name = "Radio_1";
            this.Text = "การใช้ RadioButton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radCyan;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radOrange;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radPink;
    }
}