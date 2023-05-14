namespace EnglishWritingProject
{
    partial class mistakesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mistakesForm));
            this.mainText = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // mainText
            // 
            this.mainText.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.mainText.DisabledLinkColor = System.Drawing.SystemColors.ControlText;
            this.mainText.LinkColor = System.Drawing.Color.Red;
            this.mainText.Location = new System.Drawing.Point(0, 0);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(782, 455);
            this.mainText.TabIndex = 0;
            this.mainText.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // mistakesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.mainText);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mistakesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your mistakes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel mainText;
    }
}