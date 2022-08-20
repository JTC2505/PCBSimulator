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

        public int CodVentana = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            startPrograms("Microsoft Word");
            CodVentana = 1;
            timer1.Start();

            Properties.Settings.Default.word = "espera";
            Properties.Settings.Default.Save();

            afterStartProgram("Microsoft Word");
        }

        private void close1_Click_1(object sender, EventArgs e)
        {

            groupBox1.Visible = false;
            button1.Enabled = true;

            Properties.Settings.Default.word = "finalizado";
            Properties.Settings.Default.Save();

            finishPrograms("Microsoft Word");
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            startPrograms("Spotify");
            CodVentana = 2;
            timer1.Start();

            Properties.Settings.Default.spotify = "espera";
            Properties.Settings.Default.Save();

            afterStartProgram("Spotify");
        }


        private void close2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            button2.Enabled = true;

            Properties.Settings.Default.spotify = "finalizado";
            Properties.Settings.Default.Save();

            finishPrograms("Spotify");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            startPrograms("Chrome");
            CodVentana = 3;
            timer1.Start();

            Properties.Settings.Default.chrome = "espera";
            Properties.Settings.Default.Save();

            afterStartProgram("Chrome");
        }

        private void close3_Click(object sender, EventArgs e)
        {

            groupBox3.Visible = false;
            button3.Enabled = true;

            Properties.Settings.Default.chrome = "finalizado";
            Properties.Settings.Default.Save();

            finishPrograms("Chrome");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            startPrograms("Gmail");
            CodVentana = 4;
            timer1.Start();

            Properties.Settings.Default.gmail = "espera";
            Properties.Settings.Default.Save();

            afterStartProgram("Gmail");

        }
        
        private void close4_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            button4.Enabled = true;

            Properties.Settings.Default.gmail = "finalizado";
            Properties.Settings.Default.Save();

            finishPrograms("Gmail");
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
            Registro registro = new Registro();
            registro.name = program;
            registro.dateTime = DateTime.Now.ToString();
            registro.action = "Ejecutandose";
            registroList.Add(registro);
        }


        private void SimuladorDesktop_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (CodVentana)
            {
                case 1:
                    groupBox1.Visible = true;
                    button1.Enabled = false;

                    Properties.Settings.Default.word = "encendido";
                    Properties.Settings.Default.Save();
                    break;
                case 2:
                    groupBox2.Visible = true;
                    button2.Enabled = false;

                    Properties.Settings.Default.spotify = "encendido";
                    Properties.Settings.Default.Save();
                    break;
                case 3:
                    groupBox3.Visible = true;
                    button3.Enabled = false;

                    Properties.Settings.Default.chrome = "encendido";
                    Properties.Settings.Default.Save();
                    break;
                case 4:
                    groupBox4.Visible = true;
                    button4.Enabled = false;

                    Properties.Settings.Default.gmail = "encendido";
                    Properties.Settings.Default.Save();
                    break;
            }
            

           

            timer1.Stop();
        }

    }
}
