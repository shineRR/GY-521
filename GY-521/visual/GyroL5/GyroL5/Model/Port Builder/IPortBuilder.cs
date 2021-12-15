using System.IO.Ports;

namespace GyroL5.Model.Port_Builder
{
    public delegate void TaskDelegate(GYModel model);
    internal interface IPortBuilder
    {
        SerialPort _serialPort { get; }
        void SetBaudRate(int rate = 9600);
        void SetParity(Parity parity = Parity.None);
        void SetStopBits(StopBits stopBits = StopBits.One);
        void SetDataBits(int dataBits = 8);
        void SetHandshake(Handshake handshake = Handshake.None);
        void StartMonitoring(TaskDelegate job);
        void StopMonitoring();
    }
}
