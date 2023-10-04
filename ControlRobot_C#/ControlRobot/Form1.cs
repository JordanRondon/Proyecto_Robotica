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

namespace ControlRobot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbPuertoSerial_DropDown(object sender, EventArgs e)
        {
            string[] listaPuertos = SerialPort.GetPortNames();
            cmbPuertoSerial.Items.Clear();
            cmbPuertoSerial.Items.AddRange(listaPuertos);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cmbPuertoSerial.Text;
                serialPort1.BaudRate = Convert.ToInt32(cmbVelocidad.Text);
                serialPort1.Open();
                MessageBox.Show("Conexión establecida");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if(serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    MessageBox.Show("Conexión finalizada");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void tkbBase_Scroll(object sender, EventArgs e)
        {
            int angulo = tkbBase.Value;
            lbAnguloBase.Text = angulo.ToString();

            if(serialPort1.IsOpen)
            {
                serialPort1.Write(angulo + "A" + "\n");
            }
        }

        private void tkbBrazo1_Scroll(object sender, EventArgs e)
        {
            int angulo = tkbBrazo1.Value;
            lbAnguloBrazo1.Text = angulo.ToString();

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(angulo + "B" + "\n");
            }

        }

        private void tkbBrazo2_Scroll(object sender, EventArgs e)
        {
            int angulo = tkbBrazo2.Value;
            lbAnguloBrazo2.Text = angulo.ToString();

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(angulo + "C" + "\n");
            }
        }

        private void tkbGarra_Scroll(object sender, EventArgs e)
        {
            int angulo = tkbGarra.Value;
            lbAnguloGarra.Text = angulo.ToString();

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(angulo + "D" + "\n");
            }
        }
    }
}
