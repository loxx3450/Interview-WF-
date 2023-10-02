using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_02._10
{
    public partial class Results : Form
    {
        public string AllInfo
        {
            get
            {
                string result = string.Empty;

                result += UserName.Text + '\n';
                result += UserGender.Text + '\n';
                result += UserBirthday.Text + '\n';
                result += UserPhoneNumber.Text + '\n';
                result += UserEmail.Text + '\n';

                result += '\n' + SocialLabel.Text + '\n';
                foreach (string item in UserSocialMedias.Items) 
                { 
                    result += item + "\n";
                }

                result += '\n' + TechnLabel.Text + '\n';
                foreach (string item in UserTechnologies.Items)
                {
                    result += item + "\n";
                }

                result += '\n' + LanguagesLabel.Text + '\n';
                foreach (string item in UserLanguages.Items)
                {
                    result += item + "\n";
                }

                return result;
            }
        }

        public Results(Interview interview)
        {
            InitializeComponent();

            UserName.Text = $"Name: {interview.UserName}";
            UserGender.Text = $"Gender: {interview.UserGender}";
            UserBirthday.Text = $"Birthday: {interview.UserBirthday}";
            UserPhoneNumber.Text = $"Phone Number: {interview.UserPhoneNumber}";
            UserEmail.Text = $"Email: {interview.UserEmail}";

            foreach (string socialMedia in interview.UserSocialMedias)
            {
                UserSocialMedias.Items.Add(socialMedia);
            }

            foreach (string technology in interview.UserTechnologies)
            {
                UserTechnologies.Items.Add(technology);
            }

            foreach (string language in interview.UserLanguages)
            {
                UserLanguages.Items.Add(language);
            }
        }
    }
}
