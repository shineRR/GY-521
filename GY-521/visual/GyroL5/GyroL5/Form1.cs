using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing;
using GyroL5.Model.Port_Builder;
using GyroL5.Model;
using GyroL5.Model.Game;

namespace GyroL5
{
    public partial class Form1 : Form
    {

        IGame game = new Game();
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

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshPorts();
        }

        private void DidTapOnMonitor(object sender, EventArgs e)
        {
            if (game.IsActiveGame())
            {
                StopMonitoring();
            }
            else
            {
                StartMonitoring();
            }
        }

        private void DidTapOnUpdateGame(object sender, EventArgs e)
        {
            if (game.IsActiveGame()) {
                game.Update();
                combinationTextBox.Text = game.GetWinCombination();
            }
        }

        private void StartMonitoring()
        {
            if (serialPort != null) {
                StopMonitoring();
                return; 
            }

            var selectedItem = portComboBox.SelectedItem.ToString();

            IPortBuilder portBuilder = new PortBuilder(selectedItem);
            GY521 gy521 = new GY521(portBuilder);
            this.serialPort = portBuilder;

            portBuilder.StartMonitoring(ModelHandler);

            SetupUI(Constants.activeTitle, Constants.activeColor, Constants.activeButtonTitle);
            game.Start();
            combinationTextBox.Text = game.GetWinCombination();
        }

        private void StopMonitoring()
        {
            if (serialPort == null) {
                StartMonitoring();
                return; 
            }

            serialPort.StopMonitoring();
            serialPort = null;

            SetupUI(Constants.inactiveTitle, Constants.inactiveColor, Constants.inactiveButtonTitle);
            game.Stop();
        }

        private void SetupUI(string text, Color color, string buttonTitle)
        {
            statusLabel.Text = text;
            statusLabel.ForeColor = color;
            startMonitoringButton.Text = buttonTitle;
        }

        private void ModelHandler(GYModel model)
        {
            if (model == null)
            {
                StopMonitoring();
                return;
            }

            FillTextBoxes(model);
            FindWinner(model);
        }

        private void FindWinner(GYModel model)
        {
            if (!game.IsActiveGame()) { return; }
            if (game.isCorrectResult(model))
            {
                MessageBox.Show("Поооообедитель!!!");
                StopMonitoring();
            }
        }

        private void FillTextBoxes(GYModel model)
        {
            gxTextBox.Text = model.gx.ToString();
            gyTextBox.Text = model.gy.ToString();
            gzTextBox.Text = model.gz.ToString();
            axTextBox.Text = model.ax.ToString();
            ayTextBox.Text = model.ay.ToString();
            azTextBox.Text = model.az.ToString();
            tempTextBox.Text = model.temp.ToString();
        }
    }
}
