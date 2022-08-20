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
    public partial class logRegister : Form
    {
        public List<Registro> registros;
        public logRegister(List<Registro> registrosA)
        {
            this.registros = registrosA;
            InitializeComponent();
        }

        private void logRegister_Load(object sender, EventArgs e)
        {
            foreach (var item in registros)
            {
                dataGridView1.Rows.Add(item.name, item.dateTime, item.action);
            }
        }
    }
}
