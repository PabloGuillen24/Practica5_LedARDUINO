using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Practica5_LedARDUINO
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();

            serialPort = new SerialPort("COM8", 9600); 
        }

        private void btn_On_Click(object sender, EventArgs e)
        {
            // Enviar comando para encender el LED
            serialPort.Write("1");
        }

        private void btn_Off_Click(object sender, EventArgs e)
        {
            serialPort.Write("0");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Close();
            }
            base.OnFormClosing(e);
        }

    }
}
