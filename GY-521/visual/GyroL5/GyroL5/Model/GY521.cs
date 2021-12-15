using System;
using GyroL5.Model.Port_Builder;

namespace GyroL5.Model
{
    internal class GY521
    {
        private IPortBuilder _serialPort;

        public GY521(IPortBuilder serialPort)
        {
            _serialPort = serialPort;
        }

        private void StartMonitoring(TaskDelegate job)
        {
            _serialPort.StartMonitoring(job);
        }
    }
}
