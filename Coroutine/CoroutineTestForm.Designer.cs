namespace SafeCoroutine
{
    partial class CoroutineTestForm
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
            this.coroutineTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStartCoroutine = new System.Windows.Forms.Button();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btnStopCoroutine = new System.Windows.Forms.Button();
            this.btnWaitForMe = new System.Windows.Forms.Button();
            this.btnWaitForMe2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coroutineTimer
            // 
            this.coroutineTimer.Enabled = true;
            this.coroutineTimer.Interval = 10;
            this.coroutineTimer.Tick += new System.EventHandler(this.coroutineTimer_Tick);
            // 
            // btnStartCoroutine
            // 
            this.btnStartCoroutine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartCoroutine.Location = new System.Drawing.Point(352, 264);
            this.btnStartCoroutine.Name = "btnStartCoroutine";
            this.btnStartCoroutine.Size = new System.Drawing.Size(75, 23);
            this.btnStartCoroutine.TabIndex = 0;
            this.btnStartCoroutine.Text = "start";
            this.btnStartCoroutine.UseVisualStyleBackColor = true;
            this.btnStartCoroutine.Click += new System.EventHandler(this.btnStartCoroutine_Click);
            // 
            // tbDisplay
            // 
            this.tbDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDisplay.Location = new System.Drawing.Point(12, 12);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDisplay.Size = new System.Drawing.Size(334, 275);
            this.tbDisplay.TabIndex = 1;
            // 
            // btnStopCoroutine
            // 
            this.btnStopCoroutine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopCoroutine.Location = new System.Drawing.Point(352, 235);
            this.btnStopCoroutine.Name = "btnStopCoroutine";
            this.btnStopCoroutine.Size = new System.Drawing.Size(75, 23);
            this.btnStopCoroutine.TabIndex = 0;
            this.btnStopCoroutine.Text = "stop";
            this.btnStopCoroutine.UseVisualStyleBackColor = true;
            this.btnStopCoroutine.Click += new System.EventHandler(this.btnStopCoroutine_Click);
            // 
            // btnWaitForMe
            // 
            this.btnWaitForMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWaitForMe.Location = new System.Drawing.Point(352, 12);
            this.btnWaitForMe.Name = "btnWaitForMe";
            this.btnWaitForMe.Size = new System.Drawing.Size(75, 23);
            this.btnWaitForMe.TabIndex = 0;
            this.btnWaitForMe.Text = "wait for button";
            this.btnWaitForMe.UseVisualStyleBackColor = true;
            this.btnWaitForMe.Click += new System.EventHandler(this.btnStopCoroutine_Click);
            // 
            // btnWaitForMe2
            // 
            this.btnWaitForMe2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWaitForMe2.Location = new System.Drawing.Point(350, 41);
            this.btnWaitForMe2.Name = "btnWaitForMe2";
            this.btnWaitForMe2.Size = new System.Drawing.Size(75, 23);
            this.btnWaitForMe2.TabIndex = 0;
            this.btnWaitForMe2.Text = "wait for button";
            this.btnWaitForMe2.UseVisualStyleBackColor = true;
            this.btnWaitForMe2.Click += new System.EventHandler(this.btnStopCoroutine_Click);
            // 
            // CoroutineTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 299);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.btnWaitForMe2);
            this.Controls.Add(this.btnWaitForMe);
            this.Controls.Add(this.btnStopCoroutine);
            this.Controls.Add(this.btnStartCoroutine);
            this.Name = "CoroutineTestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer coroutineTimer;
        private System.Windows.Forms.Button btnStartCoroutine;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btnStopCoroutine;
        private System.Windows.Forms.Button btnWaitForMe;
        private System.Windows.Forms.Button btnWaitForMe2;
    }
}

