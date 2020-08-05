namespace _04_Letterfrequenties
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.TEST = new System.Windows.Forms.Button();
            this.btnDisplayFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(111, 12);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(65, 62);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(182, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(337, 313);
            this.textBox.TabIndex = 2;
            // 
            // TEST
            // 
            this.TEST.Location = new System.Drawing.Point(111, 263);
            this.TEST.Name = "TEST";
            this.TEST.Size = new System.Drawing.Size(65, 62);
            this.TEST.TabIndex = 3;
            this.TEST.Text = "test";
            this.TEST.UseVisualStyleBackColor = true;
            this.TEST.Click += new System.EventHandler(this.TEST_Click);
            // 
            // btnDisplayFile
            // 
            this.btnDisplayFile.Location = new System.Drawing.Point(111, 131);
            this.btnDisplayFile.Name = "btnDisplayFile";
            this.btnDisplayFile.Size = new System.Drawing.Size(65, 62);
            this.btnDisplayFile.TabIndex = 4;
            this.btnDisplayFile.Text = "Display File";
            this.btnDisplayFile.UseVisualStyleBackColor = true;
            this.btnDisplayFile.Click += new System.EventHandler(this.btnDisplayFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 337);
            this.Controls.Add(this.btnDisplayFile);
            this.Controls.Add(this.TEST);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnLoadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button TEST;
        private System.Windows.Forms.Button btnDisplayFile;
    }
}

