namespace hw_02._10
{
    partial class Interview
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
            components = new System.ComponentModel.Container();
            TreeNode treeNode18 = new TreeNode("Windows Forms");
            TreeNode treeNode19 = new TreeNode("WPF");
            TreeNode treeNode20 = new TreeNode("Unity");
            TreeNode treeNode21 = new TreeNode("Azure");
            TreeNode treeNode22 = new TreeNode(".NET", new TreeNode[] { treeNode18, treeNode19, treeNode20, treeNode21 });
            TreeNode treeNode23 = new TreeNode("C/C++");
            TreeNode treeNode24 = new TreeNode("Java");
            TreeNode treeNode25 = new TreeNode("MySQL");
            TreeNode treeNode26 = new TreeNode("PHP", new TreeNode[] { treeNode25 });
            TreeNode treeNode27 = new TreeNode("JavaScript");
            TreeNode treeNode28 = new TreeNode("React JS");
            TreeNode treeNode29 = new TreeNode("Node JS");
            TreeNode treeNode30 = new TreeNode("Angular");
            TreeNode treeNode31 = new TreeNode("Web", new TreeNode[] { treeNode27, treeNode28, treeNode29, treeNode30 });
            TreeNode treeNode32 = new TreeNode("QT");
            TreeNode treeNode33 = new TreeNode("Kotlin");
            TreeNode treeNode34 = new TreeNode("Mobile", new TreeNode[] { treeNode32, treeNode33 });
            tabControl1 = new TabControl();
            MainInfo = new TabPage();
            groupBoxGender = new GroupBox();
            man = new RadioButton();
            woman = new RadioButton();
            button1 = new Button();
            stateBox = new TextBox();
            dateInput = new DateTimePicker();
            dateBox = new TextBox();
            nameInput = new TextBox();
            nameBox = new TextBox();
            Connection = new TabPage();
            btnNewOne = new Button();
            socialMediaInput = new TextBox();
            socialMediasBox = new TextBox();
            emailInput = new MaskedTextBox();
            emailBox = new TextBox();
            phoneNumberBox = new TextBox();
            phoneNumberInput = new MaskedTextBox();
            button2 = new Button();
            WorkingExperience = new TabPage();
            languagesListBox = new CheckedListBox();
            languagesBox = new TextBox();
            technologiesCheckBox = new TreeView();
            technologiesBox = new TextBox();
            button3 = new Button();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            MainInfo.SuspendLayout();
            groupBoxGender.SuspendLayout();
            Connection.SuspendLayout();
            WorkingExperience.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(MainInfo);
            tabControl1.Controls.Add(Connection);
            tabControl1.Controls.Add(WorkingExperience);
            tabControl1.Location = new Point(-2, -34);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(805, 515);
            tabControl1.TabIndex = 0;
            // 
            // MainInfo
            // 
            MainInfo.Controls.Add(groupBoxGender);
            MainInfo.Controls.Add(button1);
            MainInfo.Controls.Add(stateBox);
            MainInfo.Controls.Add(dateInput);
            MainInfo.Controls.Add(dateBox);
            MainInfo.Controls.Add(nameInput);
            MainInfo.Controls.Add(nameBox);
            MainInfo.Location = new Point(4, 34);
            MainInfo.Name = "MainInfo";
            MainInfo.Padding = new Padding(3);
            MainInfo.Size = new Size(797, 431);
            MainInfo.TabIndex = 0;
            MainInfo.Text = "Main info";
            MainInfo.UseVisualStyleBackColor = true;
            // 
            // groupBoxGender
            // 
            groupBoxGender.Controls.Add(man);
            groupBoxGender.Controls.Add(woman);
            groupBoxGender.Location = new Point(22, 283);
            groupBoxGender.Name = "groupBoxGender";
            groupBoxGender.Size = new Size(300, 102);
            groupBoxGender.TabIndex = 10;
            groupBoxGender.TabStop = false;
            // 
            // man
            // 
            man.AutoSize = true;
            man.Location = new Point(6, 17);
            man.Name = "man";
            man.Size = new Size(72, 29);
            man.TabIndex = 7;
            man.TabStop = true;
            man.Text = "Man";
            man.UseVisualStyleBackColor = true;
            man.CheckedChanged += Gender_CheckedChanged;
            // 
            // woman
            // 
            woman.AutoSize = true;
            woman.Location = new Point(6, 52);
            woman.Name = "woman";
            woman.Size = new Size(99, 29);
            woman.TabIndex = 8;
            woman.TabStop = true;
            woman.Text = "Woman";
            woman.UseVisualStyleBackColor = true;
            woman.CheckedChanged += Gender_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(657, 351);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // stateBox
            // 
            stateBox.Enabled = false;
            stateBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            stateBox.Location = new Point(22, 246);
            stateBox.Name = "stateBox";
            stateBox.ReadOnly = true;
            stateBox.Size = new Size(173, 31);
            stateBox.TabIndex = 6;
            stateBox.Text = "Choose your state:";
            // 
            // dateInput
            // 
            dateInput.Location = new Point(22, 185);
            dateInput.Name = "dateInput";
            dateInput.Size = new Size(335, 31);
            dateInput.TabIndex = 5;
            // 
            // dateBox
            // 
            dateBox.Enabled = false;
            dateBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateBox.Location = new Point(22, 132);
            dateBox.Name = "dateBox";
            dateBox.ReadOnly = true;
            dateBox.Size = new Size(230, 31);
            dateBox.TabIndex = 3;
            dateBox.Text = "Choose your day of birth:";
            // 
            // nameInput
            // 
            nameInput.Location = new Point(22, 70);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(335, 31);
            nameInput.TabIndex = 2;
            nameInput.TextChanged += nameInput_TextChanged;
            // 
            // nameBox
            // 
            nameBox.Enabled = false;
            nameBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nameBox.Location = new Point(22, 20);
            nameBox.Name = "nameBox";
            nameBox.ReadOnly = true;
            nameBox.Size = new Size(192, 31);
            nameBox.TabIndex = 1;
            nameBox.Text = "Input your full name:";
            // 
            // Connection
            // 
            Connection.Controls.Add(btnNewOne);
            Connection.Controls.Add(socialMediaInput);
            Connection.Controls.Add(socialMediasBox);
            Connection.Controls.Add(emailInput);
            Connection.Controls.Add(emailBox);
            Connection.Controls.Add(phoneNumberBox);
            Connection.Controls.Add(phoneNumberInput);
            Connection.Controls.Add(button2);
            Connection.Location = new Point(4, 34);
            Connection.Name = "Connection";
            Connection.Padding = new Padding(3);
            Connection.Size = new Size(797, 477);
            Connection.TabIndex = 1;
            Connection.Text = "Connection";
            Connection.UseVisualStyleBackColor = true;
            // 
            // btnNewOne
            // 
            btnNewOne.Location = new Point(701, 66);
            btnNewOne.Name = "btnNewOne";
            btnNewOne.Size = new Size(31, 31);
            btnNewOne.TabIndex = 19;
            btnNewOne.Text = "+";
            btnNewOne.UseVisualStyleBackColor = true;
            btnNewOne.Click += btnNewOne_Click;
            // 
            // socialMediaInput
            // 
            socialMediaInput.Location = new Point(384, 66);
            socialMediaInput.Name = "socialMediaInput";
            socialMediaInput.Size = new Size(295, 31);
            socialMediaInput.TabIndex = 18;
            socialMediaInput.TextChanged += socialMediaInput_TextChanged;
            // 
            // socialMediasBox
            // 
            socialMediasBox.Enabled = false;
            socialMediasBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            socialMediasBox.Location = new Point(384, 19);
            socialMediasBox.Name = "socialMediasBox";
            socialMediasBox.Size = new Size(370, 31);
            socialMediasBox.TabIndex = 17;
            socialMediasBox.Text = "Input as much social medias, as you want:";
            // 
            // emailInput
            // 
            emailInput.Location = new Point(28, 229);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(335, 31);
            emailInput.TabIndex = 15;
            emailInput.TextChanged += MaskedTextBox1_TextChanged;
            // 
            // emailBox
            // 
            emailBox.Enabled = false;
            emailBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            emailBox.Location = new Point(28, 180);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(157, 31);
            emailBox.TabIndex = 14;
            emailBox.Text = "Input your Email:";
            // 
            // phoneNumberBox
            // 
            phoneNumberBox.Enabled = false;
            phoneNumberBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            phoneNumberBox.Location = new Point(28, 19);
            phoneNumberBox.Name = "phoneNumberBox";
            phoneNumberBox.Size = new Size(242, 31);
            phoneNumberBox.TabIndex = 13;
            phoneNumberBox.Text = "Input your Phone number:";
            // 
            // phoneNumberInput
            // 
            phoneNumberInput.Location = new Point(28, 66);
            phoneNumberInput.Mask = "(999) 000-0000";
            phoneNumberInput.Name = "phoneNumberInput";
            phoneNumberInput.Size = new Size(124, 31);
            phoneNumberInput.TabIndex = 12;
            phoneNumberInput.TextChanged += phoneNumberInput_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(655, 360);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 10;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // WorkingExperience
            // 
            WorkingExperience.Controls.Add(languagesListBox);
            WorkingExperience.Controls.Add(languagesBox);
            WorkingExperience.Controls.Add(technologiesCheckBox);
            WorkingExperience.Controls.Add(technologiesBox);
            WorkingExperience.Controls.Add(button3);
            WorkingExperience.Location = new Point(4, 34);
            WorkingExperience.Name = "WorkingExperience";
            WorkingExperience.Size = new Size(797, 431);
            WorkingExperience.TabIndex = 2;
            WorkingExperience.Text = "WorkingExperience";
            WorkingExperience.UseVisualStyleBackColor = true;
            // 
            // languagesListBox
            // 
            languagesListBox.CheckOnClick = true;
            languagesListBox.FormattingEnabled = true;
            languagesListBox.Items.AddRange(new object[] { "Amharic", "Arabic", "Bengali", "Bhojpuri", "Burmese", "Chinese (Mandarin)", "English", "French", "Fula", "German", "Gujarati", "Hakka", "Hausa", "Hindi", "Italian", "Japanese", "Javanese", "Jin", "Kannada", "Korean", "Malay (Indonesian)", "Malayalam", "Marathi", "Maithili", "Odia (Oriya)", "Pashto", "Persian (Farsi)", "Polish", "Portuguese", "Punjabi", "Romanian", "Russian", "Sindhi", "Southern Min", "Spanish", "Sundanese", "Swahili", "Tagalog (Filipino)", "Tamil", "Telugu", "Thai", "Turkish", "Ukrainian", "Urdu", "Uzbek", "Vietnamese", "Wu (Shanghainese)", "Xiang", "Yue (Cantonese)", "Yoruba" });
            languagesListBox.Location = new Point(413, 78);
            languagesListBox.Name = "languagesListBox";
            languagesListBox.Size = new Size(257, 256);
            languagesListBox.TabIndex = 18;
            languagesListBox.ItemCheck += languagesListBox_ItemCheck;
            // 
            // languagesBox
            // 
            languagesBox.Enabled = false;
            languagesBox.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            languagesBox.Location = new Point(413, 23);
            languagesBox.Name = "languagesBox";
            languagesBox.Size = new Size(354, 29);
            languagesBox.TabIndex = 16;
            languagesBox.Text = "Choose all languages you can fluently speak:";
            // 
            // technologiesCheckBox
            // 
            technologiesCheckBox.CheckBoxes = true;
            technologiesCheckBox.FullRowSelect = true;
            technologiesCheckBox.Location = new Point(10, 78);
            technologiesCheckBox.Name = "technologiesCheckBox";
            treeNode18.Name = "WF";
            treeNode18.Text = "Windows Forms";
            treeNode19.Name = "WPF";
            treeNode19.Text = "WPF";
            treeNode20.Name = "Unity";
            treeNode20.Text = "Unity";
            treeNode21.Name = "Azure";
            treeNode21.Text = "Azure";
            treeNode22.Name = ".NET";
            treeNode22.Tag = "root";
            treeNode22.Text = ".NET";
            treeNode23.Name = "C";
            treeNode23.Tag = "root";
            treeNode23.Text = "C/C++";
            treeNode24.Name = "Java";
            treeNode24.Tag = "root";
            treeNode24.Text = "Java";
            treeNode25.Name = "MySQL";
            treeNode25.Text = "MySQL";
            treeNode26.Name = "PHP";
            treeNode26.Tag = "root";
            treeNode26.Text = "PHP";
            treeNode27.Name = "JS";
            treeNode27.Text = "JavaScript";
            treeNode28.Name = "React";
            treeNode28.Text = "React JS";
            treeNode29.Name = "Node";
            treeNode29.Text = "Node JS";
            treeNode30.Name = "Angular";
            treeNode30.Text = "Angular";
            treeNode31.Name = "Web";
            treeNode31.Tag = "root";
            treeNode31.Text = "Web";
            treeNode32.Name = "QT";
            treeNode32.Text = "QT";
            treeNode33.Name = "Kotlin";
            treeNode33.Text = "Kotlin";
            treeNode34.Name = "Mobile";
            treeNode34.Tag = "root";
            treeNode34.Text = "Mobile";
            technologiesCheckBox.Nodes.AddRange(new TreeNode[] { treeNode22, treeNode23, treeNode24, treeNode26, treeNode31, treeNode34 });
            technologiesCheckBox.Size = new Size(211, 256);
            technologiesCheckBox.TabIndex = 15;
            technologiesCheckBox.AfterCheck += technologiesCheckBox_AfterCheck;
            // 
            // technologiesBox
            // 
            technologiesBox.Enabled = false;
            technologiesBox.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            technologiesBox.Location = new Point(10, 23);
            technologiesBox.Name = "technologiesBox";
            technologiesBox.Size = new Size(352, 29);
            technologiesBox.TabIndex = 11;
            technologiesBox.Text = "Choose Technologies you have worked with:";
            // 
            // button3
            // 
            button3.Location = new Point(664, 362);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 10;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Interview
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 414);
            Controls.Add(tabControl1);
            MinimumSize = new Size(822, 469);
            Name = "Interview";
            Text = "Interview";
            tabControl1.ResumeLayout(false);
            MainInfo.ResumeLayout(false);
            MainInfo.PerformLayout();
            groupBoxGender.ResumeLayout(false);
            groupBoxGender.PerformLayout();
            Connection.ResumeLayout(false);
            Connection.PerformLayout();
            WorkingExperience.ResumeLayout(false);
            WorkingExperience.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage MainInfo;
        private TabPage Connection;
        private TabPage WorkingExperience;
        private TextBox nameBox;
        private DateTimePicker dateInput;
        private TextBox dateBox;
        private TextBox nameInput;
        private RadioButton woman;
        private RadioButton man;
        private TextBox stateBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private ErrorProvider errorProvider1;
        private GroupBox groupBoxGender;
        private MaskedTextBox phoneNumberInput;
        private MaskedTextBox emailInput;
        private TextBox emailBox;
        private TextBox phoneNumberBox;
        private Button btnNewOne;
        private TextBox socialMediaInput;
        private TextBox socialMediasBox;
        private TextBox technologiesBox;
        private TreeView technologiesCheckBox;
        private TextBox languagesBox;
        private CheckedListBox languagesListBox;
    }
}