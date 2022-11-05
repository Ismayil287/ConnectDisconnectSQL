namespace ConnectDisconnectSQL
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
            this.lblstate = new System.Windows.Forms.Label();
            this.lblOpenClose = new System.Windows.Forms.Label();
            this.btnConnDissconn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblstate.ForeColor = System.Drawing.Color.Purple;
            this.lblstate.Location = new System.Drawing.Point(109, 63);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(264, 31);
            this.lblstate.TabIndex = 0;
            this.lblstate.Text = "Connection State  :";
            // 
            // lblOpenClose
            // 
            this.lblOpenClose.AutoSize = true;
            this.lblOpenClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOpenClose.Location = new System.Drawing.Point(452, 63);
            this.lblOpenClose.Name = "lblOpenClose";
            this.lblOpenClose.Size = new System.Drawing.Size(89, 31);
            this.lblOpenClose.TabIndex = 1;
            this.lblOpenClose.Text = "Close";
            // 
            // btnConnDissconn
            // 
            this.btnConnDissconn.BackColor = System.Drawing.Color.Green;
            this.btnConnDissconn.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnDissconn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConnDissconn.Location = new System.Drawing.Point(299, 236);
            this.btnConnDissconn.Name = "btnConnDissconn";
            this.btnConnDissconn.Size = new System.Drawing.Size(183, 64);
            this.btnConnDissconn.TabIndex = 2;
            this.btnConnDissconn.Text = "Connect";
            this.btnConnDissconn.UseVisualStyleBackColor = false;
            this.btnConnDissconn.Click += new System.EventHandler(this.btnConnDissconn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConnDissconn);
            this.Controls.Add(this.lblOpenClose);
            this.Controls.Add(this.lblstate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstate;
        private System.Windows.Forms.Label lblOpenClose;
        private System.Windows.Forms.Button btnConnDissconn;
    }
}

