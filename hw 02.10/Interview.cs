using Microsoft.VisualBasic;
using System;
using System.CodeDom.Compiler;
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
    public partial class Interview : Form
    {
        private TextBox lastSocialMedia;

        public string UserName { get => nameInput.Text; }

        public string UserGender { get => woman.Checked ? "Woman" : "Man"; }

        public string UserBirthday { get => dateInput.Text.Substring(0, 10); }

        public string UserPhoneNumber { get => phoneNumberInput.Text; }

        public string UserEmail { get => emailInput.Text; }

        public List<string> UserSocialMedias { get; } = new();

        public List<string> UserTechnologies
        {
            get
            {
                List<string> technologies = new();

                foreach (TreeNode root in technologiesCheckBox.Nodes)
                {
                    if (root.Checked) { technologies.Add(root.Text); }

                    if (root.Nodes.Count > 0)
                    {
                        foreach (TreeNode branch in root.Nodes)
                        {
                            if (branch.Checked) { technologies.Add(branch.Text); }
                        }
                    }
                }

                return technologies;
            }
        }

        public List<string> UserLanguages
        {
            get
            {
                List<string> languages = new();

                foreach (string item in languagesListBox.CheckedItems)
                {
                    languages.Add(item);
                }

                return languages;
            }
        }

        public Interview()
        {
            InitializeComponent();

            dateInput.MaxDate = DateAndTime.Now.AddYears(-18);
            dateInput.MinDate = DateAndTime.Now.AddYears(-120);

            errorProvider1.BlinkRate = 0;

            lastSocialMedia = socialMediaInput;

            technologiesCheckBox.CheckBoxes = true;
        }

        public bool NameIsValid { get => !(nameInput.Text == string.Empty); }

        public bool GenderIsValid { get => man.Checked || woman.Checked; }

        public bool EmailIsValid { get; private set; }

        public bool PhoneNumberIsValid
        {
            get
            {
                int count = 0;

                foreach (char value in phoneNumberInput.Text)
                {
                    if (value >= '0' && value <= '9')
                    {
                        count++;
                    }
                }

                return count == 10;
            }
        }

        public bool SocialMediasInputIsValid { get => socialMediaInput.Text != string.Empty; }

        public bool TechnologiesAreValid { get => TechnologiesCount > 0; }

        public bool LanguagesAreValid { get => LanguagesCount > 0; }

        public int TechnologiesCount { get; set; } = 0;

        public int SocialMediasCount { get; set; } = 1;

        public int LanguagesCount { get; set; } = 0;

        private bool FirstTabFinished
        {
            get { return NameIsValid && GenderIsValid; }
        }

        private bool SecondTabFinished
        {
            get { return EmailIsValid && PhoneNumberIsValid && SocialMediasInputIsValid; }
        }

        private bool ThirdTabFinished
        {
            get { return TechnologiesAreValid && LanguagesAreValid; }
        }

        private void button_Click(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;

            if (IsTabCompleted(index))
            {
                if (index + 1 == tabControl1.TabCount)
                {
                    if (lastSocialMedia.Text != string.Empty) { UserSocialMedias.Add(lastSocialMedia.Text); }

                    DialogResult = DialogResult.OK;

                    Close();
                }
                else
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[index + 1];
                }
            }
        }

        private bool IsTabCompleted(int index)
        {
            bool completed = true;

            errorProvider1.Clear();

            switch (index)
            {
                case 0:
                    completed = FirstTabFinished;

                    if (!NameIsValid) { errorProvider1.SetError(nameInput, "Input your name please"); }
                    if (!GenderIsValid) { errorProvider1.SetError(groupBoxGender, "Choose your gender"); }

                    break;

                case 1:
                    completed = SecondTabFinished;

                    if (!PhoneNumberIsValid) { errorProvider1.SetError(phoneNumberInput, "Input your phone number correctly please"); }
                    if (!EmailIsValid) { errorProvider1.SetError(emailInput, "Input your email correctly please"); }
                    if (!SocialMediasInputIsValid) { errorProvider1.SetError(socialMediaInput, "Input at least one way how to connect with you"); }

                    break;

                case 2:
                    completed = ThirdTabFinished;

                    if (!TechnologiesAreValid) { errorProvider1.SetError(technologiesCheckBox, "Are you kidding?"); }
                    if (!LanguagesAreValid) { errorProvider1.SetError(languagesListBox, "Then how did you fill previous pages?"); }

                    break;
            }

            return completed;
        }

        private void MaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            EmailIsValid = false;

            if (emailInput.TextLength < 11)
            {
                errorProvider1.SetError(emailInput, "Your email needs to end with \"@gmail.com\"");
            }
            else if (emailInput.Text.Substring(emailInput.TextLength - 10) == "@gmail.com")
            {
                errorProvider1.SetError(emailInput, "");

                EmailIsValid = true;
            }
            else
            {
                errorProvider1.SetError(emailInput, "Your email needs to end with \"@gmail.com\"");
            }
        }

        private void btnNewOne_Click(object sender, EventArgs e)
        {
            if (lastSocialMedia.Text != string.Empty && lastSocialMedia.Enabled)
            {
                lastSocialMedia.Enabled = false;

                if (SocialMediasCount < 6)
                {
                    UserSocialMedias.Add(lastSocialMedia.Text);
                    TextBox temp = new();
                    temp.Location = new Point(lastSocialMedia.Location.X, lastSocialMedia.Location.Y + 48);
                    temp.Size = lastSocialMedia.Size;

                    lastSocialMedia = temp;

                    Connection.Controls.Add(temp);

                    SocialMediasCount++;
                }
            }
        }

        private void socialMediaInput_TextChanged(object sender, EventArgs e)
        {
            if (SocialMediasInputIsValid)
            {
                errorProvider1.SetError(socialMediaInput, "");
            }
        }

        private void technologiesCheckBox_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == "root")
            {
                foreach (TreeNode node in e.Node.Nodes)
                {
                    if (e.Node.Checked)
                    {
                        if (!node.Checked) { node.Checked = true; }
                    }
                    else
                    {
                        if (node.Checked) { node.Checked = false; }
                    }
                }
            }

            if (e.Node.Checked) { TechnologiesCount++; }
            else { TechnologiesCount--; }

            if (TechnologiesAreValid) { errorProvider1.SetError(technologiesCheckBox, ""); }
        }

        private void languagesListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                LanguagesCount++;
                errorProvider1.SetError(languagesListBox, "");
            }
            else
            {
                LanguagesCount--;
            }
        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            if (NameIsValid)
            {
                errorProvider1.SetError(nameInput, "");
            }
        }

        private void Gender_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(groupBoxGender, "");
        }

        private void phoneNumberInput_TextChanged(object sender, EventArgs e)
        {
            if (PhoneNumberIsValid)
            {
                errorProvider1.SetError(phoneNumberInput, "");
            }
        }
    }
}