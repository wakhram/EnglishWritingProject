namespace EnglishWritingProject
{
    partial class loginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.signinButton = new System.Windows.Forms.Button();
            this.signupButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signinButton
            // 
            this.signinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signinButton.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signinButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.signinButton.Image = ((System.Drawing.Image)(resources.GetObject("signinButton.Image")));
            this.signinButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signinButton.Location = new System.Drawing.Point(433, 261);
            this.signinButton.Margin = new System.Windows.Forms.Padding(4);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(235, 69);
            this.signinButton.TabIndex = 1;
            this.signinButton.TabStop = false;
            this.signinButton.Text = "   Sign in";
            this.signinButton.UseVisualStyleBackColor = true;
            this.signinButton.Click += new System.EventHandler(this.signinButtonClick);
            // 
            // signupButton
            // 
            this.signupButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.signupButton.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signupButton.Image = ((System.Drawing.Image)(resources.GetObject("signupButton.Image")));
            this.signupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signupButton.Location = new System.Drawing.Point(433, 347);
            this.signupButton.Margin = new System.Windows.Forms.Padding(4);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(235, 69);
            this.signupButton.TabIndex = 2;
            this.signupButton.TabStop = false;
            this.signupButton.Text = "   Sign up";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButtonClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(467, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signupButton);
            this.Controls.Add(this.signinButton);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Every day english";
            this.Click += new System.EventHandler(this.loginForm_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signinButton;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Label label1;
    }
}

