using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Premier_Application
{
    public partial class Form1 : Form
    {
      private  Dictionary<string, Premier> premiers;
        private Dictionary<string, string> imageFilenameMap;
        private string imageBasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "source", "repos", "csharp2", "Premier_Application", "images");
        public Form1()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui() {
            premiers = new Dictionary<string, Premier>();
            List<Premier> premierList =  Premier.GetPremiers();
            foreach (Premier premier  in premierList)
            {
                premiers.Add(premier.Key, premier);
            }
            listBox1.DataSource = premiers.Keys.ToList();

        }

        private void ShowPremier(string key)
        {
            if (premiers.TryGetValue(key, out Premier premier))
            {
     
                label1.Text += $"{premier.Name} {premier.Life}";

       
                label2.Text += $" Office from {premier.Start} to {premier.End}";

        
                label3.Text += premier.Constituent;

      
                label4.Text += premier.Party;

        
              //  pictureBox1.ImageLocation = $"images\\{key}.jpg";
              //  MessageBox.Show(pictureBox1.ImageLocation);

                string[] imageFiles = Directory.GetFiles(imageBasePath, "*.jpg");
                string matchingImage = imageFiles.FirstOrDefault(file =>
                    Path.GetFileNameWithoutExtension(file)
                        .IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0);

                if (matchingImage != null)
                {
                    pictureBox1.Image = Image.FromFile(matchingImage);
                }
                else
                {
                    pictureBox1.Image = null;
                  //  MessageBox.Show($"Image for {key} not found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Premier not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                string selectedKey = listBox1.SelectedItem.ToString();
                ShowPremier(selectedKey);

             
              //  MessageBox.Show($"Selected: {selectedKey}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }






    }
}
