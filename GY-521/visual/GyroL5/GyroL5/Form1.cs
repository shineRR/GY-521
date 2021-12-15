using System;
using System.Windows.Forms;
using System.IO.Ports;
using GyroL5.Model.Port_Builder;
using GyroL5.Model;

namespace GyroL5
{
    public partial class Form1 : Form
    {

        IPortBuilder serialPort;
        public Form1()
        {
            InitializeComponent();
            RefreshPorts();
        }

        private void RefreshPorts()
        {
            var ports = SerialPort.GetPortNames();
            portComboBox.Items.Clear();
            foreach(var port in ports)
            {
                portComboBox.Items.Add(port);
            }
            if (ports.Length > 0) {
                portComboBox.SelectedIndex = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshPorts();
        }

        private void startMonitoringButton_Click(object sender, EventArgs e)
        {
            var selectedItem = portComboBox.SelectedItem.ToString();

            IPortBuilder portBuilder = new PortBuilder(selectedItem);
            GY521 gy521 = new GY521(portBuilder);
            this.serialPort = portBuilder;

            portBuilder.StartMonitoring(modelHandler);
        }

        private void stopMonitoringButton_Click(object sender, EventArgs e)
        {
            serialPort.StopMonitoring();
        }

        private void modelHandler(GYModel model)
        {
            // Do smth...
        }
    }
}
