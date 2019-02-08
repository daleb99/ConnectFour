namespace ConnectFour
{
    partial class NameSelection
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
            this.LblConnectFour = new System.Windows.Forms.Label();
            this.LblEnterName1 = new System.Windows.Forms.Label();
            this.TxtName1 = new System.Windows.Forms.TextBox();
            this.BtnNameEnter = new System.Windows.Forms.Button();
            this.TxtName2 = new System.Windows.Forms.TextBox();
            this.LblEnterName2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblConnectFour
            // 
            this.LblConnectFour.AutoSize = true;
            this.LblConnectFour.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConnectFour.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LblConnectFour.Location = new System.Drawing.Point(92, 9);
            this.LblConnectFour.Name = "LblConnectFour";
            this.LblConnectFour.Size = new System.Drawing.Size(349, 75);
            this.LblConnectFour.TabIndex = 1;
            this.LblConnectFour.Text = "Connect 4";
            this.LblConnectFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblEnterName1
            // 
            this.LblEnterName1.AutoSize = true;
            this.LblEnterName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnterName1.Location = new System.Drawing.Point(88, 120);
            this.LblEnterName1.Name = "LblEnterName1";
            this.LblEnterName1.Size = new System.Drawing.Size(156, 20);
            this.LblEnterName1.TabIndex = 2;
            this.LblEnterName1.Text = "Enter Player 1 name:";
            // 
            // TxtName1
            // 
            this.TxtName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName1.Location = new System.Drawing.Point(249, 117);
            this.TxtName1.Name = "TxtName1";
            this.TxtName1.Size = new System.Drawing.Size(192, 26);
            this.TxtName1.TabIndex = 3;
            // 
            // BtnNameEnter
            // 
            this.BtnNameEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnNameEnter.Location = new System.Drawing.Point(249, 213);
            this.BtnNameEnter.Name = "BtnNameEnter";
            this.BtnNameEnter.Size = new System.Drawing.Size(192, 30);
            this.BtnNameEnter.TabIndex = 4;
            this.BtnNameEnter.Text = "Enter";
            this.BtnNameEnter.UseVisualStyleBackColor = true;
            this.BtnNameEnter.Click += new System.EventHandler(this.BtnNameEnter_Click);
            // 
            // TxtName2
            // 
            this.TxtName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName2.Location = new System.Drawing.Point(249, 147);
            this.TxtName2.Name = "TxtName2";
            this.TxtName2.Size = new System.Drawing.Size(192, 26);
            this.TxtName2.TabIndex = 6;
            // 
            // LblEnterName2
            // 
            this.LblEnterName2.AutoSize = true;
            this.LblEnterName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnterName2.Location = new System.Drawing.Point(88, 150);
            this.LblEnterName2.Name = "LblEnterName2";
            this.LblEnterName2.Size = new System.Drawing.Size(156, 20);
            this.LblEnterName2.TabIndex = 5;
            this.LblEnterName2.Text = "Enter Player 2 name:";
            // 
            // NameSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 271);
            this.Controls.Add(this.TxtName2);
            this.Controls.Add(this.LblEnterName2);
            this.Controls.Add(this.BtnNameEnter);
            this.Controls.Add(this.TxtName1);
            this.Controls.Add(this.LblEnterName1);
            this.Controls.Add(this.LblConnectFour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NameSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblConnectFour;
        private System.Windows.Forms.Label LblEnterName1;
        private System.Windows.Forms.TextBox TxtName1;
        private System.Windows.Forms.Button BtnNameEnter;
        private System.Windows.Forms.TextBox TxtName2;
        private System.Windows.Forms.Label LblEnterName2;
    }
}