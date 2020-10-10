using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;

namespace WF
{
    public partial class MainForm : Form
    {
        Dictionary<string, string> data { get; set; }
        string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\plandata.txt";
        public MainForm()
        {
            InitializeComponent();
            this.Text = "The Weekly Plan";
        }
        private string DataForDay(int day)
        {
            string textForTextBox = "";
            textForTextBox = data.Values.ElementAt(day-1);
            return textForTextBox;
        }
        private void LoadDataFromFile(string urlToFile)
        {
            if (!File.Exists(urlToFile))
            {
                using (StreamWriter sw = new StreamWriter(urlToFile, false))
                {
                    sw.Write("{\"Monday\":\"агада\",\"Tuesday\":\"аганет\",\"Wednesday\":\"агадада\nasdasdasd\",\"Thursday\":\"день учителя\nвыходной\",\"Friday\":\"дадая\",\"Saturday\":\"дадая\",\"Sunday\":\"нетнетты\"}");
                }
            }
            using (StreamReader sr = new StreamReader(urlToFile))
            {
                string text = sr.ReadToEnd();
                data = JsonConvert.DeserializeObject<Dictionary<string, string>>(text);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataFromFile(path);
            Title.Text = Title.Text.Replace("[day]", DateTime.Now.DayOfWeek.ToString());
            Today.Text = Today.Text.Replace("[chosenDay]", DateTime.Now.DayOfWeek.ToString());
            foreach (var button in Controls.OfType<Button>())
            {
                if (button.Tag.ToString().StartsWith("dayOfWeek"))
                {
                    string buttonTag = button.Tag.ToString();
                    Today.Text = Today.Text.Replace("[chosenDay]", button.Text);
                    button.Click += (s, eventArgs) => { textBoxPlan.Text = DataForDay(int.Parse(buttonTag[buttonTag.Length - 1].ToString())); Today.Text = $"A plan for {button.Text}"; };
                    if (button.Text == Today.Text.Split(' ')[3]) { textBoxPlan.Text = DataForDay(int.Parse(buttonTag[buttonTag.Length - 1].ToString()));  }
                }
            }
        }

        private void EditPlan_Click(object sender, EventArgs e)
        {
            data[Today.Text.Split(' ')[3]] = textBoxPlan.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(JsonConvert.SerializeObject(data));
            }
        }

        private void Help_Click(object sender, EventArgs e)
        {
            Help helpForm = new Help();
            helpForm.Show();
        }
    }
}
