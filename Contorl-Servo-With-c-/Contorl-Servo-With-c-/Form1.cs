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

namespace Contorl_Servo_With_c_
{
    public partial class Form1 : Form
    {
        SerialPort port;
        public Form1()
        {
            InitializeComponent();
            contorlservo();
        }

        void contorlservo()
        {
            port = new SerialPort();
            port.PortName = "COM3";
            port.BaudRate = 9600;
            try
            {
                port.Open();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            degree.Text = trackBar1.Value.ToString();

            if (port.IsOpen)
            {

            }
            
        }
    }
}
