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
    public partial class taskManager : Form
    {
        public taskManager()
        {
            InitializeComponent();
        }
        public void cargaProceso()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("1", SimuladorPCB.Properties.Resources.word20, "Microsot Word", Properties.Settings.Default.word.ToString(), "1", "60.2Mb");
            dataGridView1.Rows.Add("2", SimuladorPCB.Properties.Resources.spotify20, "Spotify", Properties.Settings.Default.spotify.ToString(), "1", "465.4Mb");
            dataGridView1.Rows.Add("3", SimuladorPCB.Properties.Resources.chrome20, "Chrome", Properties.Settings.Default.chrome.ToString(), "1", "152.2Mb");
            dataGridView1.Rows.Add("4", SimuladorPCB.Properties.Resources.gmail20, "Gmail", Properties.Settings.Default.gmail.ToString(), "1", "0.3Mb");
        }


        private void taskManager_Load(object sender, EventArgs e)
        {
            cargaProceso();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cargaProceso();
        }
    }
}
