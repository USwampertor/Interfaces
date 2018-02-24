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
        Data dataHandler = new Data();
        DataBase BaseHandler = new DataBase();
        public Form1()
        {
            InitializeComponent();
        }
        public void Insertintolistbox()
        {
            List<string> temporaryLoad = dataHandler.Getnames();
            for(int index=0;index<temporaryLoad.Count;index++)
            {
                listBox1.Items.Add(temporaryLoad[index]);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            int onload= BaseHandler.InputHandler();
            if(onload==0)
            {
                MessageBox.Show(textBox1.Text + " File not found. Creating one...", "Warning");
            }
            else
            {
               DialogResult result = MessageBox.Show(textBox1.Text + " File found. Wanna Load it?", "Warning",MessageBoxButtons.YesNo);
                if(result==System.Windows.Forms.DialogResult.Yes)
                {
                    dataHandler.Setnames(BaseHandler.Getdatabasenames());
                    Insertintolistbox();
                }
                else
                {

                }
            }
           
            listBox2.Visible = false;
            
            
            dataHandler.Setnames(BaseHandler.Getdatabasenames());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();

            Color BackColor = Color.Green;

            listBox1.Items.Add(textBox1.Text);
            MessageBox.Show(textBox1.Text + " agregado.", "Agregar");
            textBox1.Clear();
            dataHandler.DataFetch(listBox1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();
            //SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            //simpleSound.Play();

            Color BackColor = Color.Red;
            for (int i=0;i<listBox1.Items.Count;i++)
            {
                if(listBox1.Items[i].ToString()==textBox1.Text)
                {
                    listBox1.Items.RemoveAt(i);
                    MessageBox.Show(textBox1.Text + " borrado.");
                    break;
                }
                else
                {
                    MessageBox.Show(textBox1.Text + " no se encontro.", "Borrar");
                }
            }
            textBox1.Clear();
            dataHandler.DataFetch(listBox1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            if (listBox1.Visible)
            {
                listBox2.Visible = true;
                listBox1.Visible = false;
                for (int i = 0; i < dataHandler.GetTeams().Count; i++)
                {
                    listBox2.Items.Add("Equipo " + (i + 1));
                    for (int j = 0; j < dataHandler.GetTeams()[i].Team.Count; j++)
                    {
                        listBox2.Items.Add(dataHandler.GetTeams()[i].Team[j]);
                    }
                }
            }
            else
            {
                listBox1.Visible = true;
                listBox2.Visible = false;
            }
            //SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            //simpleSound.Play();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Hand.Play();
            BaseHandler.OutputHandler(dataHandler.Getnames());
            //SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            //simpleSound.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Question.Play();
            int j;
            if (string.IsNullOrEmpty(textBox1.Text) || !Int32.TryParse(textBox1.Text, out j) || listBox1.Items.Count <= 0)
            {
                MessageBox.Show("Ingrese un numero en la textbox.", "Sortear");
            }
            else
            {
                dataHandler.SortNames(Convert.ToInt32(textBox1.Text));
                MessageBox.Show("Nombres sorteados.", "Sortear");
            }
            //SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            //simpleSound.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
