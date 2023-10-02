using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace hw_02._10
{
    public partial class Form1 : Form
    {
        private Interview? interview = new();
        private Results results;
        public Form1()
        {
            InitializeComponent();

            btnShowResults.Visible = false;
            btnSave.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            interview.ShowDialog();

            if (interview.DialogResult == DialogResult.OK)
            {
                btnShowResults.Visible = true;
                btnSave.Visible = true;

                results = new(interview);
            }
        }

        private void btnShowResults_Click(object sender, EventArgs e)
        {
            results.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "/results.txt";

            File.Create(path).Close();

            MessageBox.Show("Your results are saved at \"./hw 02.10/hw 02.10/bin/Debug/net7.0-windows\"", "Message", MessageBoxButtons.OK);

            if (results != null)
            {
                File.WriteAllText(path, results.AllInfo);
            }
        }
    }
}