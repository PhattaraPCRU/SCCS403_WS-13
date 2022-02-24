
namespace SCCS403_WS_13
{
    partial class ListBox_1
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
            this.libxFaculty = new System.Windows.Forms.ListBox();
            this.libxProgram = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // libxFaculty
            // 
            this.libxFaculty.FormattingEnabled = true;
            this.libxFaculty.ItemHeight = 15;
            this.libxFaculty.Location = new System.Drawing.Point(106, 57);
            this.libxFaculty.Name = "libxFaculty";
            this.libxFaculty.Size = new System.Drawing.Size(283, 169);
            this.libxFaculty.TabIndex = 0;
            // 
            // libxProgram
            // 
            this.libxProgram.FormattingEnabled = true;
            this.libxProgram.ItemHeight = 15;
            this.libxProgram.Location = new System.Drawing.Point(397, 57);
            this.libxProgram.Name = "libxProgram";
            this.libxProgram.Size = new System.Drawing.Size(283, 169);
            this.libxProgram.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(106, 305);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(605, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ListBox_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.libxProgram);
            this.Controls.Add(this.libxFaculty);
            this.Name = "ListBox_1";
            this.Text = "การใช้งาน ListBox";
            this.Load += new System.EventHandler(this.ListBox_1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox libxFaculty;
        private System.Windows.Forms.ListBox libxProgram;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnExit;
    }
}