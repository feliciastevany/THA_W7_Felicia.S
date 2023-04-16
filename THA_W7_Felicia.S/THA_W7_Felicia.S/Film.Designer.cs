namespace THA_W7_Felicia.S
{
    partial class Film
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
            this.SeatPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SeatPanel
            // 
            this.SeatPanel.Location = new System.Drawing.Point(683, 119);
            this.SeatPanel.Name = "SeatPanel";
            this.SeatPanel.Size = new System.Drawing.Size(627, 620);
            this.SeatPanel.TabIndex = 0;
            // 
            // Film
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 858);
            this.Controls.Add(this.SeatPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Film";
            this.Text = "Film";
            this.Load += new System.EventHandler(this.Film_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SeatPanel;
    }
}