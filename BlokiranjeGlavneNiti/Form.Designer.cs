﻿namespace BlokiranjeGlavneNiti
{
    partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.textBoxTime = new System.Windows.Forms.TextBox();
			this.buttonBlock = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// textBoxTime
			// 
			this.textBoxTime.Location = new System.Drawing.Point(12, 12);
			this.textBoxTime.Name = "textBoxTime";
			this.textBoxTime.Size = new System.Drawing.Size(129, 20);
			this.textBoxTime.TabIndex = 0;
			// 
			// buttonBlock
			// 
			this.buttonBlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBlock.Location = new System.Drawing.Point(197, 227);
			this.buttonBlock.Name = "buttonBlock";
			this.buttonBlock.Size = new System.Drawing.Size(75, 23);
			this.buttonBlock.TabIndex = 1;
			this.buttonBlock.Text = "&Block";
			this.buttonBlock.UseVisualStyleBackColor = true;
			this.buttonBlock.Click += new System.EventHandler(this.buttonBlock_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.buttonBlock);
			this.Controls.Add(this.textBoxTime);
			this.Name = "MainForm";
			this.Text = "Blokiranje Glavne Niti";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonBlock;
		private System.Windows.Forms.Timer timer1;
	}
}

