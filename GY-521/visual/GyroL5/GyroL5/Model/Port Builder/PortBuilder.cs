using Newtonsoft.Json;
using System;
using System.IO.Ports;
using System.Threading.Tasks;

namespace GyroL5.Model.Port_Builder
{
    internal class PortBuilder: IPortBuilder
    {
        public SerialPort _serialPort { get; }

        public PortBuilder(string portName)
        {
            _serialPort = new SerialPort(portName);
            SetBaudRate();
            SetParity();
            SetStopBits();
            SetDataBits();
            SetHandshake();
        }

        public void SetBaudRate(int rate = 9600)
        {
            _serialPort.BaudRate = rate;
        }

        public void SetParity(Parity parity = Parity.None)
        {
            _serialPort.Parity = parity;
        }

        public void SetStopBits(StopBits stopBits = StopBits.One)
        {
            _serialPort.StopBits = stopBits;
        }

        public void SetDataBits(int dataBits = 8)
        {
            _serialPort.DataBits = dataBits;
        }

        public void SetHandshake(Handshake handshake = Handshake.None)
        {
            _serialPort.Handshake = handshake;
        }

        public void StartMonitoring(TaskDelegate job)
        {
            try
            {
                _serialPort.Open();
                ObservePort(job);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void StopMonitoring()
        {
            _serialPort.Close();
        }

        private void ObservePort(TaskDelegate job)
        {
            Task.Run(new Action(() =>
            {
                while (_serialPort.IsOpen)
                {
                    try
                    {
                        string line = _serialPort.ReadLine();
                        GYModel model = JsonConvert.DeserializeObject<GYModel>(line);
                        job(model);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }));
        }
    }
}
