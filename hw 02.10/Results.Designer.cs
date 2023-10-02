namespace hw_02._10
{
    partial class Results
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
            UserName = new Label();
            UserBirthday = new Label();
            UserPhoneNumber = new Label();
            UserEmail = new Label();
            UserSocialMedias = new ListBox();
            SocialLabel = new Label();
            TechnLabel = new Label();
            UserTechnologies = new ListBox();
            LanguagesLabel = new Label();
            UserLanguages = new ListBox();
            UserGender = new Label();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Location = new Point(12, 20);
            UserName.Name = "UserName";
            UserName.Size = new Size(59, 25);
            UserName.TabIndex = 0;
            UserName.Text = "label1";
            // 
            // UserBirthday
            // 
            UserBirthday.AutoSize = true;
            UserBirthday.Location = new Point(12, 110);
            UserBirthday.Name = "UserBirthday";
            UserBirthday.Size = new Size(59, 25);
            UserBirthday.TabIndex = 1;
            UserBirthday.Text = "label1";
            // 
            // UserPhoneNumber
            // 
            UserPhoneNumber.AutoSize = true;
            UserPhoneNumber.Location = new Point(12, 157);
            UserPhoneNumber.Name = "UserPhoneNumber";
            UserPhoneNumber.Size = new Size(59, 25);
            UserPhoneNumber.TabIndex = 2;
            UserPhoneNumber.Text = "label1";
            // 
            // UserEmail
            // 
            UserEmail.AutoSize = true;
            UserEmail.Location = new Point(12, 200);
            UserEmail.Name = "UserEmail";
            UserEmail.Size = new Size(59, 25);
            UserEmail.TabIndex = 3;
            UserEmail.Text = "label1";
            // 
            // UserSocialMedias
            // 
            UserSocialMedias.FormattingEnabled = true;
            UserSocialMedias.ItemHeight = 25;
            UserSocialMedias.Location = new Point(12, 291);
            UserSocialMedias.Name = "UserSocialMedias";
            UserSocialMedias.Size = new Size(180, 129);
            UserSocialMedias.TabIndex = 4;
            // 
            // SocialLabel
            // 
            SocialLabel.AutoSize = true;
            SocialLabel.Location = new Point(12, 249);
            SocialLabel.Name = "SocialLabel";
            SocialLabel.Size = new Size(186, 25);
            SocialLabel.TabIndex = 5;
            SocialLabel.Text = "Social Medias of User:";
            // 
            // TechnLabel
            // 
            TechnLabel.AutoSize = true;
            TechnLabel.Location = new Point(263, 249);
            TechnLabel.Name = "TechnLabel";
            TechnLabel.Size = new Size(214, 25);
            TechnLabel.TabIndex = 7;
            TechnLabel.Text = "Technologies User knows:";
            // 
            // UserTechnologies
            // 
            UserTechnologies.FormattingEnabled = true;
            UserTechnologies.ItemHeight = 25;
            UserTechnologies.Location = new Point(263, 291);
            UserTechnologies.Name = "UserTechnologies";
            UserTechnologies.Size = new Size(180, 129);
            UserTechnologies.TabIndex = 6;
            // 
            // LanguagesLabel
            // 
            LanguagesLabel.AutoSize = true;
            LanguagesLabel.Location = new Point(539, 249);
            LanguagesLabel.Name = "LanguagesLabel";
            LanguagesLabel.Size = new Size(196, 25);
            LanguagesLabel.TabIndex = 9;
            LanguagesLabel.Text = "Languages User speaks";
            // 
            // UserLanguages
            // 
            UserLanguages.FormattingEnabled = true;
            UserLanguages.ItemHeight = 25;
            UserLanguages.Location = new Point(539, 291);
            UserLanguages.Name = "UserLanguages";
            UserLanguages.Size = new Size(180, 129);
            UserLanguages.TabIndex = 8;
            // 
            // UserGender
            // 
            UserGender.AutoSize = true;
            UserGender.Location = new Point(12, 66);
            UserGender.Name = "UserGender";
            UserGender.Size = new Size(59, 25);
            UserGender.TabIndex = 10;
            UserGender.Text = "label1";
            // 
            // Results
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UserGender);
            Controls.Add(LanguagesLabel);
            Controls.Add(UserLanguages);
            Controls.Add(TechnLabel);
            Controls.Add(UserTechnologies);
            Controls.Add(SocialLabel);
            Controls.Add(UserSocialMedias);
            Controls.Add(UserEmail);
            Controls.Add(UserPhoneNumber);
            Controls.Add(UserBirthday);
            Controls.Add(UserName);
            Name = "Results";
            Text = "Results";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserName;
        private Label UserBirthday;
        private Label UserPhoneNumber;
        private Label UserEmail;
        private ListBox UserSocialMedias;
        private Label SocialLabel;
        private Label TechnLabel;
        private ListBox UserTechnologies;
        private Label LanguagesLabel;
        private ListBox UserLanguages;
        private Label UserGender;
    }
}