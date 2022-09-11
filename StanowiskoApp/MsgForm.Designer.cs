namespace StaowiskoApp
{
    partial class FormMessage
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelMsg = new System.Windows.Forms.Panel();
            this.progressBarMsg = new System.Windows.Forms.ProgressBar();
            this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.panelMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(193, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "msg";
            // 
            // panelMsg
            // 
            this.panelMsg.BackColor = System.Drawing.Color.Silver;
            this.panelMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMsg.Controls.Add(this.progressBarMsg);
            this.panelMsg.Controls.Add(this.label1);
            this.panelMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelMsg.Location = new System.Drawing.Point(3, 3);
            this.panelMsg.Name = "panelMsg";
            this.panelMsg.Size = new System.Drawing.Size(419, 103);
            this.panelMsg.TabIndex = 1;
            // 
            // progressBarMsg
            // 
            this.progressBarMsg.Location = new System.Drawing.Point(8, 59);
            this.progressBarMsg.Name = "progressBarMsg";
            this.progressBarMsg.Size = new System.Drawing.Size(402, 35);
            this.progressBarMsg.TabIndex = 1;
            this.progressBarMsg.Visible = false;
            // 
            // timerProgressBar
            // 
            this.timerProgressBar.Interval = 1000;
            this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
            // 
            // FormMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 114);
            this.Controls.Add(this.panelMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMessage_FormClosed);
            this.Load += new System.EventHandler(this.FormMessage_Load);
            this.panelMsg.ResumeLayout(false);
            this.panelMsg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMsg;
        private System.Windows.Forms.ProgressBar progressBarMsg;
        private System.Windows.Forms.Timer timerProgressBar;
    }
}