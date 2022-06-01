namespace ForTextBox
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
            this.textChange = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nupForText = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupForText)).BeginInit();
            this.SuspendLayout();
            // 
            // textChange
            // 
            this.textChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textChange.Location = new System.Drawing.Point(0, 0);
            this.textChange.Multiline = true;
            this.textChange.Name = "textChange";
            this.textChange.Size = new System.Drawing.Size(800, 450);
            this.textChange.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nupForText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 1;
            // 
            // nupForText
            // 
            this.nupForText.Location = new System.Drawing.Point(345, 37);
            this.nupForText.Name = "nupForText";
            this.nupForText.Size = new System.Drawing.Size(82, 22);
            this.nupForText.TabIndex = 0;
            this.nupForText.ValueChanged += new System.EventHandler(this.nupForText_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textChange);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupForText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textChange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nupForText;
    }
}

