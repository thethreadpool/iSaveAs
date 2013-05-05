namespace iSaveAs
{
    partial class iSaveAs
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
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilestoConvert = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdConvert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdPng = new System.Windows.Forms.RadioButton();
            this.rdBmp = new System.Windows.Forms.RadioButton();
            this.rdJpeg = new System.Windows.Forms.RadioButton();
            this.rdGif = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(433, 18);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(24, 23);
            this.cmdBrowse.TabIndex = 0;
            this.cmdBrowse.Text = "...";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Files to convert:";
            // 
            // txtFilestoConvert
            // 
            this.txtFilestoConvert.Location = new System.Drawing.Point(103, 20);
            this.txtFilestoConvert.Name = "txtFilestoConvert";
            this.txtFilestoConvert.Size = new System.Drawing.Size(313, 20);
            this.txtFilestoConvert.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Convert to: ";
            // 
            // cmdConvert
            // 
            this.cmdConvert.Location = new System.Drawing.Point(382, 64);
            this.cmdConvert.Name = "cmdConvert";
            this.cmdConvert.Size = new System.Drawing.Size(75, 23);
            this.cmdConvert.TabIndex = 8;
            this.cmdConvert.Text = "Convert";
            this.cmdConvert.UseVisualStyleBackColor = true;
            this.cmdConvert.Click += new System.EventHandler(this.cmdConvert_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdPng);
            this.panel1.Controls.Add(this.rdBmp);
            this.panel1.Controls.Add(this.rdJpeg);
            this.panel1.Controls.Add(this.rdGif);
            this.panel1.Location = new System.Drawing.Point(103, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 23);
            this.panel1.TabIndex = 9;
            // 
            // rdPng
            // 
            this.rdPng.AutoSize = true;
            this.rdPng.Location = new System.Drawing.Point(203, 3);
            this.rdPng.Name = "rdPng";
            this.rdPng.Size = new System.Drawing.Size(48, 17);
            this.rdPng.TabIndex = 11;
            this.rdPng.Text = "PNG";
            this.rdPng.UseVisualStyleBackColor = true;
            // 
            // rdBmp
            // 
            this.rdBmp.AutoSize = true;
            this.rdBmp.Location = new System.Drawing.Point(137, 3);
            this.rdBmp.Name = "rdBmp";
            this.rdBmp.Size = new System.Drawing.Size(48, 17);
            this.rdBmp.TabIndex = 10;
            this.rdBmp.Text = "BMP";
            this.rdBmp.UseVisualStyleBackColor = true;
            // 
            // rdJpeg
            // 
            this.rdJpeg.AutoSize = true;
            this.rdJpeg.Checked = true;
            this.rdJpeg.Location = new System.Drawing.Point(68, 3);
            this.rdJpeg.Name = "rdJpeg";
            this.rdJpeg.Size = new System.Drawing.Size(52, 17);
            this.rdJpeg.TabIndex = 9;
            this.rdJpeg.TabStop = true;
            this.rdJpeg.Text = "JPEG";
            this.rdJpeg.UseVisualStyleBackColor = true;
            // 
            // rdGif
            // 
            this.rdGif.AutoSize = true;
            this.rdGif.Location = new System.Drawing.Point(9, 3);
            this.rdGif.Name = "rdGif";
            this.rdGif.Size = new System.Drawing.Size(42, 17);
            this.rdGif.TabIndex = 8;
            this.rdGif.Text = "GIF";
            this.rdGif.UseVisualStyleBackColor = true;
            // 
            // iSaveAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 108);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdConvert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilestoConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdBrowse);
            this.Name = "iSaveAs";
            this.Text = "iSaveAs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilestoConvert;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdConvert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdPng;
        private System.Windows.Forms.RadioButton rdBmp;
        private System.Windows.Forms.RadioButton rdJpeg;
        private System.Windows.Forms.RadioButton rdGif;
    }
}

