﻿namespace fordongusuornek2_1504
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
            this.lbsayılar = new System.Windows.Forms.ListBox();
            this.btngoster = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lbsayılar
            // 
            this.lbsayılar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbsayılar.FormattingEnabled = true;
            this.lbsayılar.ItemHeight = 24;
            this.lbsayılar.Location = new System.Drawing.Point(176, 12);
            this.lbsayılar.Name = "lbsayılar";
            this.lbsayılar.Size = new System.Drawing.Size(206, 268);
            this.lbsayılar.TabIndex = 0;
            // 
            // btngoster
            // 
            this.btngoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngoster.Location = new System.Drawing.Point(-3, 30);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(155, 80);
            this.btngoster.TabIndex = 1;
            this.btngoster.Text = "göster";
            this.btngoster.UseVisualStyleBackColor = true;
            this.btngoster.Click += new System.EventHandler(this.btngoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.btngoster);
            this.Controls.Add(this.lbsayılar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbsayılar;
        private System.Windows.Forms.Button btngoster;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

