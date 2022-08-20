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
    public partial class SimulatorPCB : Form
    {
        public SimulatorPCB()
        {
            InitializeComponent();
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimuladorDesktop fs = new SimuladorDesktop();
            fs.MdiParent = this;
            fs.Show();

        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taskManager ts = new taskManager();
            ts.MdiParent = this;
            ts.Show();
        }

        private void SimulatorPCB_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.word = "apagado";
            Properties.Settings.Default.spotify = "apagado";
            Properties.Settings.Default.chrome = "apagado";
            Properties.Settings.Default.gmail = "apagado";

            Properties.Settings.Default.Save();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logRegister lg = new logRegister(SimuladorDesktop.registroList);
            lg.MdiParent = this;
            lg.Show();
        }
    }
}
