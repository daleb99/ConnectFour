namespace ConnectFour
{
    partial class EndGame
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnRematch = new System.Windows.Forms.Button();
            this.LblConnectFour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(171, 184);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(193, 61);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnRematch
            // 
            this.BtnRematch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRematch.Location = new System.Drawing.Point(171, 117);
            this.BtnRematch.Name = "BtnRematch";
            this.BtnRematch.Size = new System.Drawing.Size(193, 61);
            this.BtnRematch.TabIndex = 4;
            this.BtnRematch.Text = "Rematch?";
            this.BtnRematch.UseVisualStyleBackColor = true;
            this.BtnRematch.Click += new System.EventHandler(this.BtnRematch_Click);
            // 
            // LblConnectFour
            // 
            this.LblConnectFour.AutoSize = true;
            this.LblConnectFour.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConnectFour.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LblConnectFour.Location = new System.Drawing.Point(93, 26);
            this.LblConnectFour.Name = "LblConnectFour";
            this.LblConnectFour.Size = new System.Drawing.Size(349, 75);
            this.LblConnectFour.TabIndex = 3;
            this.LblConnectFour.Text = "Connect 4";
            this.LblConnectFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 271);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnRematch);
            this.Controls.Add(this.LblConnectFour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EndGame";
            this.ShowIcon = false;
            this.Text = "Game Over!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnRematch;
        private System.Windows.Forms.Label LblConnectFour;
    }
}