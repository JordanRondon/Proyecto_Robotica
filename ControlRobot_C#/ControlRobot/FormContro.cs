using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ControlRobot
{
    public partial class FormContro : Form
    {
        public FormContro()
        {
            InitializeComponent();
            cargarValoresCmbVelocidad();
            cargarValoresIniciales();
        }

        private void cargarValoresIniciales()
        {
            //comboBox de solo lectura
            cmbPuertoSerial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVelocidad.DropDownStyle = ComboBoxStyle.DropDownList;
            //------------------------
            cmbVelocidad.SelectedIndex = 0;
            panelPosicionServo.Enabled = false;
            btnDesconectar.Enabled = false;
            tkbBrazo2.Value = 180;
        }

        private void cargarValoresCmbVelocidad()
        {
            cmbVelocidad.Items.Add(9600);
            cmbVelocidad.Items.Add(38400);
            cmbVelocidad.Items.Add(57600);
            cmbVelocidad.Items.Add(115200);
        }

        private void habilitarPanelServo()
        {
            panelPosicionServo.Enabled = true;
            panelPuertoCOM.Enabled = false;
            btnConectar.Enabled = false;
            btnDesconectar.Enabled = true;
        }

        private void deshabilitarPanelServo()
        {
            panelPosicionServo.Enabled = false;
            panelPuertoCOM.Enabled = true;
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
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
                habilitarPanelServo();
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
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    MessageBox.Show("Conexión finalizada");
                    deshabilitarPanelServo();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void FormContro_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
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

        private void tkbBase_Scroll(object sender, EventArgs e)
        {
            int angulo = tkbBase.Value;
            lbAnguloBase.Text = angulo.ToString() + '°';

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(angulo + "A" + "\n");
            }
        }

        private void tkbBrazo1_Scroll(object sender, EventArgs e)
        {
            int angulo = tkbBrazo1.Value;
            lbAnguloBrazo1.Text = angulo.ToString() + '°';

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(angulo + "B" + "\n");
            }
        }

        private void tkbBrazo2_Scroll(object sender, EventArgs e)
        {
            int angulo = tkbBrazo2.Value;
            lbAnguloBrazo2.Text = angulo.ToString() + '°';

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(angulo + "C" + "\n");
            }
        }

        private void tkbGarra_Scroll(object sender, EventArgs e)
        {
            int angulo = tkbGarra.Value;
            lbAnguloGarra.Text = angulo.ToString() + '°';

            if (serialPort1.IsOpen)
            {
                serialPort1.Write(angulo + "D" + "\n");
            }
        }
    }
}
