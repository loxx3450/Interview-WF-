namespace hw_02._10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            btnShowResults = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(230, 103);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(324, 31);
            textBox1.TabIndex = 0;
            textBox1.Text = "Do you want to start your Interview?";
            // 
            // button1
            // 
            button1.Location = new Point(293, 198);
            button1.Name = "button1";
            button1.Size = new Size(196, 39);
            button1.TabIndex = 1;
            button1.Text = "YES!!!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnShowResults
            // 
            btnShowResults.Location = new Point(293, 287);
            btnShowResults.Name = "btnShowResults";
            btnShowResults.Size = new Size(196, 39);
            btnShowResults.TabIndex = 2;
            btnShowResults.Text = "Show my results!";
            btnShowResults.UseVisualStyleBackColor = true;
            btnShowResults.Click += btnShowResults_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(293, 351);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(196, 39);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save results!";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnShowResults);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button btnShowResults;
        private Button btnSave;
    }
}