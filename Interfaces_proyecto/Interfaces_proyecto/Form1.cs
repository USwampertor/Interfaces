using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Interfaces_proyecto
{
    public partial class Form1 : Form
    {
        Data vengo_a_valer_verga;

        public Form1()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void Form1_Load(object sender, EventArgs e)
        {
            // Create an instance of the ListBox.
            ListBox listBox1 = new ListBox();
            // Set the size and location of the ListBox.
            listBox1.Size = new System.Drawing.Size(200, 100);
            listBox1.Location = new System.Drawing.Point(10, 10);
            // Add the ListBox to the form.
            this.Controls.Add(listBox1);
            // Set the ListBox to display items in multiple columns.
            listBox1.MultiColumn = true;
            // Set the selection mode to multiple and extended.
            listBox1.SelectionMode = SelectionMode.MultiExtended;

            // Shutdown the painting of the ListBox as items are added.
            listBox1.BeginUpdate();
            // Loop through and add 50 items to the ListBox.
            for (int x = 1; x <= 50; x++)
            {
                listBox1.Items.Add("Item " + x.ToString());
            }
            // Allow the ListBox to repaint and display the new items.
            listBox1.EndUpdate();

            // Select three items from the ListBox.
            listBox1.SetSelected(1, true);
            listBox1.SetSelected(3, true);
            listBox1.SetSelected(5, true);

            // Display the second selected item in the ListBox to the console.
            System.Diagnostics.Debug.WriteLine(listBox1.SelectedItems[1].ToString());
            // Display the index of the first selected item in the ListBox.
            System.Diagnostics.Debug.WriteLine(listBox1.SelectedIndices[0].ToString());
=======
        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();

            Color BackColor = Color.Green;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();
            
            //SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            //simpleSound.Play();

            Color BackColor = Color.Red;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();

            //SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            //simpleSound.Play();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Hand.Play();

            //SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            //simpleSound.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Question.Play();

            //SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            //simpleSound.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {

>>>>>>> 479d609a78c31007ad20e6212c3b18c21ca4ff84
        }
    }
}
