
namespace SCCS403_WS_13
{
    partial class Radio_2
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
            this.grpSports = new System.Windows.Forms.GroupBox();
            this.radTableTennis = new System.Windows.Forms.RadioButton();
            this.radTennis = new System.Windows.Forms.RadioButton();
            this.radSwiming = new System.Windows.Forms.RadioButton();
            this.radFootball = new System.Windows.Forms.RadioButton();
            this.grpSports.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSports
            // 
            this.grpSports.Controls.Add(this.radTableTennis);
            this.grpSports.Controls.Add(this.radTennis);
            this.grpSports.Controls.Add(this.radSwiming);
            this.grpSports.Controls.Add(this.radFootball);
            this.grpSports.Location = new System.Drawing.Point(245, 120);
            this.grpSports.Name = "grpSports";
            this.grpSports.Size = new System.Drawing.Size(171, 136);
            this.grpSports.TabIndex = 0;
            this.grpSports.TabStop = false;
            this.grpSports.Text = "Sports";
            // 
            // radTableTennis
            // 
            this.radTableTennis.AutoSize = true;
            this.radTableTennis.Location = new System.Drawing.Point(6, 97);
            this.radTableTennis.Name = "radTableTennis";
            this.radTableTennis.Size = new System.Drawing.Size(88, 19);
            this.radTableTennis.TabIndex = 1;
            this.radTableTennis.TabStop = true;
            this.radTableTennis.Text = "Table Tennis";
            this.radTableTennis.UseVisualStyleBackColor = true;
            this.radTableTennis.CheckedChanged += new System.EventHandler(this.radTableTennis_CheckedChanged);
            // 
            // radTennis
            // 
            this.radTennis.AutoSize = true;
            this.radTennis.Location = new System.Drawing.Point(6, 72);
            this.radTennis.Name = "radTennis";
            this.radTennis.Size = new System.Drawing.Size(58, 19);
            this.radTennis.TabIndex = 1;
            this.radTennis.TabStop = true;
            this.radTennis.Text = "Tennis";
            this.radTennis.UseVisualStyleBackColor = true;
            this.radTennis.CheckedChanged += new System.EventHandler(this.radTennis_CheckedChanged);
            // 
            // radSwiming
            // 
            this.radSwiming.AutoSize = true;
            this.radSwiming.Location = new System.Drawing.Point(6, 47);
            this.radSwiming.Name = "radSwiming";
            this.radSwiming.Size = new System.Drawing.Size(71, 19);
            this.radSwiming.TabIndex = 1;
            this.radSwiming.TabStop = true;
            this.radSwiming.Text = "Swiming";
            this.radSwiming.UseVisualStyleBackColor = true;
            this.radSwiming.CheckedChanged += new System.EventHandler(this.radSwiming_CheckedChanged);
            // 
            // radFootball
            // 
            this.radFootball.AutoSize = true;
            this.radFootball.Location = new System.Drawing.Point(6, 22);
            this.radFootball.Name = "radFootball";
            this.radFootball.Size = new System.Drawing.Size(68, 19);
            this.radFootball.TabIndex = 1;
            this.radFootball.TabStop = true;
            this.radFootball.Text = "Football";
            this.radFootball.UseVisualStyleBackColor = true;
            this.radFootball.CheckedChanged += new System.EventHandler(this.radFootball_CheckedChanged);
            // 
            // Radio_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpSports);
            this.Name = "Radio_2";
            this.Text = "Radio_2";
            this.grpSports.ResumeLayout(false);
            this.grpSports.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSports;
        private System.Windows.Forms.RadioButton radTableTennis;
        private System.Windows.Forms.RadioButton radTennis;
        private System.Windows.Forms.RadioButton radSwiming;
        private System.Windows.Forms.RadioButton radFootball;
    }
}