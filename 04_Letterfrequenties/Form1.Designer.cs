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
            this.btnDisplayFile = new System.Windows.Forms.Button();
            this.btn_count = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(12, 12);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(97, 62);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(115, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(189, 313);
            this.textBox.TabIndex = 2;
            // 
            // btnDisplayFile
            // 
            this.btnDisplayFile.Location = new System.Drawing.Point(12, 133);
            this.btnDisplayFile.Name = "btnDisplayFile";
            this.btnDisplayFile.Size = new System.Drawing.Size(97, 62);
            this.btnDisplayFile.TabIndex = 4;
            this.btnDisplayFile.Text = "Display File";
            this.btnDisplayFile.UseVisualStyleBackColor = true;
            this.btnDisplayFile.Click += new System.EventHandler(this.btnDisplayFile_Click);
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(12, 263);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(97, 62);
            this.btn_count.TabIndex = 4;
            this.btn_count.Text = "Count Characters";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btnDisplayChars_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 337);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.btnDisplayFile);
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
        private System.Windows.Forms.Button btnDisplayFile;
        private System.Windows.Forms.Button btn_count;
    }
}

