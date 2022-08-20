using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SimuladorPCB
{
    public partial class SimuladorDesktop : Form
    {
        public static List<Registro> registroList = new List<Registro>();
        public SimuladorDesktop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.word = "iniciando";
            Properties.Settings.Default.Save();

            startPrograms("Microsoft Word");

            groupBox1.Visible = true;
            button1.Enabled = false;

            label1.Text = Properties.Settings.Default.word.ToString();

            afterStartProgram("Microsoft Word");

            Properties.Settings.Default.word = "encendido";
            Properties.Settings.Default.Save();
        }

        private void close1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            button1.Enabled = true;

            Properties.Settings.Default.word = "apagado";
            Properties.Settings.Default.Save();


        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            button2.Enabled = false;

            Properties.Settings.Default.spotify = "encendido";
            Properties.Settings.Default.Save();

            label2.Text = Properties.Settings.Default.spotify.ToString();
        }


        private void close2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            button2.Enabled = true;

            Properties.Settings.Default.spotify = "apagado";
            Properties.Settings.Default.Save();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            button3.Enabled = false;

            Properties.Settings.Default.chrome = "encendido";
            Properties.Settings.Default.Save();

            label3.Text = Properties.Settings.Default.chrome.ToString();
        }

        private void close3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            button3.Enabled = true;

            Properties.Settings.Default.chrome = "apagado";
            Properties.Settings.Default.Save();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            button4.Enabled = false;

            Properties.Settings.Default.gmail = "encendido";
            Properties.Settings.Default.Save();

            label4.Text = Properties.Settings.Default.gmail.ToString();
        }
        
        private void close4_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            button4.Enabled = true;

            Properties.Settings.Default.gmail = "apagado";
            Properties.Settings.Default.Save();
        }

        private void minimizar1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.word = "espera";
            Properties.Settings.Default.Save();

            label1.Text = Properties.Settings.Default.word.ToString();
        }

        private void minimizar2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.spotify = "espera";
            Properties.Settings.Default.Save();

            label2.Text = Properties.Settings.Default.spotify.ToString();
        }

        private void minimizar3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.chrome = "espera";
            Properties.Settings.Default.Save();

            label3.Text = Properties.Settings.Default.chrome.ToString();
        }

        private void minimizar4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.gmail = "espera";
            Properties.Settings.Default.Save();

            label4.Text = Properties.Settings.Default.gmail.ToString();
        }

        public void startPrograms(string program)
        {
            Registro registro = new Registro();
            registro.name = program;
            registro.dateTime = DateTime.Now.ToString();
            registro.action = "Inicializacion";
            registroList.Add(registro);
        }

        public void finishPrograms(string program)
        {
            Registro registro = new Registro();
            registro.name = program;
            registro.dateTime = DateTime.Now.ToString();
            registro.action = "Finalizacion";
            registroList.Add(registro);
        }

        public void afterStartProgram(string program)
        {
            if (program.Equals("Google Chrome"))
            {
                System.Threading.Thread.Sleep(2500);
            }
            else
            {
                System.Threading.Thread.Sleep(10000);
            }
            Registro registro = new Registro();
            registro.name = program;
            registro.dateTime = DateTime.Now.ToString();
            registro.action = "Ejecutandose";
            registroList.Add(registro);
        }


        private void SimuladorDesktop_Load(object sender, EventArgs e)
        {

        }

    }
}
