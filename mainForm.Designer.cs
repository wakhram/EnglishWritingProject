namespace EnglishWritingProject
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.filesList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.charsCountLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.errorRateLabel = new System.Windows.Forms.Label();
            this.mistakesCountLabel = new System.Windows.Forms.Label();
            this.wordCountLabel = new System.Windows.Forms.Label();
            this.topicLabel = new System.Windows.Forms.Label();
            this.topicButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.createFileButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.toolTipLabel = new System.Windows.Forms.Label();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.mistakesButton = new System.Windows.Forms.Button();
            this.datesComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTextBox
            // 
            this.mainTextBox.Location = new System.Drawing.Point(185, 69);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(710, 483);
            this.mainTextBox.TabIndex = 0;
            // 
            // filesList
            // 
            this.filesList.FormattingEnabled = true;
            this.filesList.ItemHeight = 24;
            this.filesList.Location = new System.Drawing.Point(12, 69);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(156, 484);
            this.filesList.TabIndex = 1;
            this.filesList.SelectedIndexChanged += new System.EventHandler(this.filesList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.charsCountLabel);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.gradeLabel);
            this.groupBox1.Controls.Add(this.errorRateLabel);
            this.groupBox1.Controls.Add(this.mistakesCountLabel);
            this.groupBox1.Controls.Add(this.wordCountLabel);
            this.groupBox1.Location = new System.Drawing.Point(914, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 428);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // charsCountLabel
            // 
            this.charsCountLabel.Location = new System.Drawing.Point(6, 87);
            this.charsCountLabel.Name = "charsCountLabel";
            this.charsCountLabel.Size = new System.Drawing.Size(144, 59);
            this.charsCountLabel.TabIndex = 29;
            this.charsCountLabel.Text = "Chars count :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(0, 334);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 11);
            this.textBox1.TabIndex = 24;
            // 
            // gradeLabel
            // 
            this.gradeLabel.Location = new System.Drawing.Point(6, 366);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(144, 59);
            this.gradeLabel.TabIndex = 28;
            this.gradeLabel.Text = "Your grade :";
            // 
            // errorRateLabel
            // 
            this.errorRateLabel.Location = new System.Drawing.Point(6, 205);
            this.errorRateLabel.Name = "errorRateLabel";
            this.errorRateLabel.Size = new System.Drawing.Size(144, 59);
            this.errorRateLabel.TabIndex = 26;
            this.errorRateLabel.Text = "Error rate :";
            // 
            // mistakesCountLabel
            // 
            this.mistakesCountLabel.Location = new System.Drawing.Point(6, 146);
            this.mistakesCountLabel.Name = "mistakesCountLabel";
            this.mistakesCountLabel.Size = new System.Drawing.Size(144, 59);
            this.mistakesCountLabel.TabIndex = 25;
            this.mistakesCountLabel.Text = "Mistakes count :";
            // 
            // wordCountLabel
            // 
            this.wordCountLabel.Location = new System.Drawing.Point(6, 28);
            this.wordCountLabel.Name = "wordCountLabel";
            this.wordCountLabel.Size = new System.Drawing.Size(144, 59);
            this.wordCountLabel.TabIndex = 24;
            this.wordCountLabel.Text = "Words count :";
            // 
            // topicLabel
            // 
            this.topicLabel.BackColor = System.Drawing.SystemColors.Window;
            this.topicLabel.Location = new System.Drawing.Point(185, 17);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(710, 49);
            this.topicLabel.TabIndex = 3;
            this.topicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topicButton
            // 
            this.topicButton.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topicButton.Image = ((System.Drawing.Image)(resources.GetObject("topicButton.Image")));
            this.topicButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.topicButton.Location = new System.Drawing.Point(914, 17);
            this.topicButton.Name = "topicButton";
            this.topicButton.Size = new System.Drawing.Size(156, 49);
            this.topicButton.TabIndex = 4;
            this.topicButton.Text = "Topic";
            this.topicButton.UseVisualStyleBackColor = true;
            this.topicButton.Click += new System.EventHandler(this.topicButtonClick);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backButton.Font = new System.Drawing.Font("Palatino Linotype", 13F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(12, 17);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(156, 49);
            this.backButton.TabIndex = 20;
            this.backButton.TabStop = false;
            this.backButton.Text = "   Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // createFileButton
            // 
            this.createFileButton.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createFileButton.Image = ((System.Drawing.Image)(resources.GetObject("createFileButton.Image")));
            this.createFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createFileButton.Location = new System.Drawing.Point(185, 569);
            this.createFileButton.Name = "createFileButton";
            this.createFileButton.Size = new System.Drawing.Size(203, 49);
            this.createFileButton.TabIndex = 21;
            this.createFileButton.Text = "   Create a file";
            this.createFileButton.UseVisualStyleBackColor = true;
            this.createFileButton.Click += new System.EventHandler(this.createFileButtonClick);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("saveFileButton.Image")));
            this.saveFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveFileButton.Location = new System.Drawing.Point(692, 569);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(203, 49);
            this.saveFileButton.TabIndex = 22;
            this.saveFileButton.Text = "   Save a file";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButtonClick);
            // 
            // colorBox
            // 
            this.colorBox.Enabled = false;
            this.colorBox.Location = new System.Drawing.Point(185, 541);
            this.colorBox.Multiline = true;
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(710, 11);
            this.colorBox.TabIndex = 23;
            // 
            // toolTipLabel
            // 
            this.toolTipLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolTipLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolTipLabel.Location = new System.Drawing.Point(404, 254);
            this.toolTipLabel.Name = "toolTipLabel";
            this.toolTipLabel.Size = new System.Drawing.Size(287, 114);
            this.toolTipLabel.TabIndex = 24;
            this.toolTipLabel.Text = "First create a file for your theme Don\'t forget, once you create a file, you won\'" +
    "t be able to change the file";
            this.toolTipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statisticsButton
            // 
            this.statisticsButton.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statisticsButton.Image = ((System.Drawing.Image)(resources.GetObject("statisticsButton.Image")));
            this.statisticsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticsButton.Location = new System.Drawing.Point(914, 503);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(156, 49);
            this.statisticsButton.TabIndex = 25;
            this.statisticsButton.Text = "Statistics  ";
            this.statisticsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statisticsButton.UseVisualStyleBackColor = true;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButtonClick);
            // 
            // mistakesButton
            // 
            this.mistakesButton.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mistakesButton.Image = ((System.Drawing.Image)(resources.GetObject("mistakesButton.Image")));
            this.mistakesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mistakesButton.Location = new System.Drawing.Point(914, 569);
            this.mistakesButton.Name = "mistakesButton";
            this.mistakesButton.Size = new System.Drawing.Size(156, 49);
            this.mistakesButton.TabIndex = 26;
            this.mistakesButton.Text = "Mistakes  ";
            this.mistakesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mistakesButton.UseVisualStyleBackColor = true;
            this.mistakesButton.Click += new System.EventHandler(this.mistakesButtonClick);
            // 
            // datesComboBox
            // 
            this.datesComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.datesComboBox.FormattingEnabled = true;
            this.datesComboBox.Location = new System.Drawing.Point(12, 578);
            this.datesComboBox.Name = "datesComboBox";
            this.datesComboBox.Size = new System.Drawing.Size(156, 32);
            this.datesComboBox.TabIndex = 27;
            this.datesComboBox.SelectedIndexChanged += new System.EventHandler(this.datesComboBox_SelectedIndexChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.datesComboBox);
            this.Controls.Add(this.mistakesButton);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.toolTipLabel);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.createFileButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.topicButton);
            this.Controls.Add(this.topicLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.filesList);
            this.Controls.Add(this.mainTextBox);
            this.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Click += new System.EventHandler(this.mainForm_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.ListBox filesList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.Button topicButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button createFileButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label errorRateLabel;
        private System.Windows.Forms.Label mistakesCountLabel;
        private System.Windows.Forms.Label wordCountLabel;
        private System.Windows.Forms.Label charsCountLabel;
        private System.Windows.Forms.Label toolTipLabel;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.Button mistakesButton;
        private System.Windows.Forms.ComboBox datesComboBox;
    }
}