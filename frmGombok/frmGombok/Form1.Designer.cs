﻿namespace frmGombok
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
            this.btnFelrak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFelrak
            // 
            this.btnFelrak.Location = new System.Drawing.Point(42, 49);
            this.btnFelrak.Name = "btnFelrak";
            this.btnFelrak.Size = new System.Drawing.Size(93, 37);
            this.btnFelrak.TabIndex = 0;
            this.btnFelrak.Text = "Felrak";
            this.btnFelrak.UseVisualStyleBackColor = true;
            this.btnFelrak.Click += new System.EventHandler(this.btnFelrak_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.btnFelrak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFelrak;
    }
}

