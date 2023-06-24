
namespace ClockTimerStopwatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toggle = new System.Windows.Forms.Button();
            this.timeDisplay = new System.Windows.Forms.MaskedTextBox();
            this.mode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toggle
            // 
            this.toggle.Location = new System.Drawing.Point(137, 45);
            this.toggle.Name = "toggle";
            this.toggle.Size = new System.Drawing.Size(75, 23);
            this.toggle.TabIndex = 0;
            this.toggle.TabStop = false;
            this.toggle.Text = "Start";
            this.toggle.UseVisualStyleBackColor = true;
            this.toggle.Click += new System.EventHandler(this.toggle_Click);
            // 
            // timeDisplay
            // 
            this.timeDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.timeDisplay.Location = new System.Drawing.Point(12, 12);
            this.timeDisplay.Mask = "90:00";
            this.timeDisplay.Name = "timeDisplay";
            this.timeDisplay.Size = new System.Drawing.Size(116, 56);
            this.timeDisplay.TabIndex = 1;
            this.timeDisplay.TabStop = false;
            this.timeDisplay.ValidatingType = typeof(System.DateTime);
            // 
            // mode
            // 
            this.mode.Location = new System.Drawing.Point(137, 12);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(75, 23);
            this.mode.TabIndex = 2;
            this.mode.TabStop = false;
            this.mode.Text = "Clock";
            this.mode.UseVisualStyleBackColor = true;
            this.mode.Click += new System.EventHandler(this.mode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 80);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.timeDisplay);
            this.Controls.Add(this.toggle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ClockTimerStopwatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toggle;
        private System.Windows.Forms.MaskedTextBox timeDisplay;
        private System.Windows.Forms.Button mode;
    }
}

