using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Threading;

namespace StaowiskoApp
{

    public class TicControls
    {
        static bool _continue;
        static SerialPort ticSerialPort;

        String ticType;
        String ticModel;
        String ticSwVer;
        String ticSerial_Number;
        String ticManufacturer;
        String ticComPort;
        String ticBaudRate;
        String ticStopBits;
        String ticDataBits;
        String ticParity;
        String ticTimeout;

        char[] comBuffer;
        private const int WAIT_BEFORE_QUERY = 50;


        public void readTicSettings()
        {
            readTicDeviceSettings tic = new readTicDeviceSettings();
            
            ticType = tic.MangleString(1); 
            ticModel = tic.MangleString(2);
            ticSwVer = tic.MangleString(3);
            ticSerial_Number = tic.MangleString(4);
            ticManufacturer = tic.MangleString(5);
            ticComPort = tic.MangleString(6);
            ticBaudRate = tic.MangleString(7);
            ticStopBits = tic.MangleString(8);
            ticDataBits = tic.MangleString(9);
            ticParity = tic.MangleString(10);
            ticTimeout = tic.MangleString(11);
        }
        public bool openTicSerialPort()
        {

            ticSerialPort = new SerialPort();

            ticSerialPort.PortName = ticComPort;
            ticSerialPort.BaudRate = Convert.ToInt32(ticBaudRate);
            ticSerialPort.Parity = Parity.None;
            ticSerialPort.DataBits = Convert.ToInt32(ticDataBits);
            ticSerialPort.StopBits = StopBits.One;
            ticSerialPort.Handshake = Handshake.None;
            ticSerialPort.ReadTimeout = Convert.ToInt32(ticTimeout);
            ticSerialPort.WriteTimeout = Convert.ToInt32(ticTimeout);

            ticSerialPort.Open();
            
            _continue = true;
            
            return true; 
        }
        public void closeTicSerialPort()
        {
            if(ticSerialPort.IsOpen)ticSerialPort.Close();
        }
        public void retTicType()
        {
            comBuffer = new char[100];
            ticSerialPort.Write("?S902\r");                                     
            Thread.Sleep(WAIT_BEFORE_QUERY);
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
        }

        public String getTicDevicesStatus()
        {
            char[] bufType;
            bufType = new char[21];
            comBuffer = new char[100];
            ticSerialPort.Write("?V902\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            Array.Copy(comBuffer, 6, bufType, 0, 21);
            String val = new String(bufType);

            return val;
        }
        public String retTicModel()
        {
            char[] bufType;
            bufType = new char[6];
            comBuffer = new char[100];
            ticSerialPort.Write("?S902\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            Array.Copy(comBuffer, 6, bufType, 0, 6);
            String val = new String(bufType);

            return val; 
        }
        public String retTicSw_Ver()
        {
            char[] bufType;
            bufType = new char[10];
            comBuffer = new char[100];
            ticSerialPort.Write("?S902\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            Array.Copy(comBuffer, 13, bufType, 0, 10);
            String val = new String(bufType);

            return val; 
        }
        public String retticSerial_Number()
        {
            char[] bufType;
            bufType = new char[9];
            comBuffer = new char[100];
            ticSerialPort.Write("?S902\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            Array.Copy(comBuffer, 24, bufType, 0, 9);
            String val = new String(bufType);

            return val; 
        }

        public String getTicTurboPumpStatus()
        {
            char[] bufType;
            bufType = new char[6];
            comBuffer = new char[100];
            ticSerialPort.Write("?V904\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            Array.Copy(comBuffer, 6, bufType, 0, 6);
            String val = new String(bufType);

            return val;
        }
        public String setTicOnTurboPump()
        {
            char[] bufType;
            bufType = new char[7];
            comBuffer = new char[100];
            ticSerialPort.Write("!C904 1\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            Array.Copy(comBuffer, 0, bufType, 0, 7);
            String val = new String(bufType);

            return val;
        }
        public String setTicOffTurboPump()
        {
            char[] bufType;
            bufType = new char[7];
            comBuffer = new char[100];
            ticSerialPort.Write("!C904 0\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            Array.Copy(comBuffer, 0, bufType, 0, 7);
            String val = new String(bufType);

            return val;
        }
        public String getPumpTypeList()
        {
            char[] bufType;
            bufType = new char[9];
            comBuffer = new char[100];
            ticSerialPort.Write("?S904 3\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            Array.Copy(comBuffer, 0, bufType, 0, 9);
            String val = new String(bufType);

            return val;
        }
        public String getTurboPumpConfig()
        {
            char[] bufType;
            bufType = new char[37];
            comBuffer = new char[100];
            ticSerialPort.Write("?S904 4\r");
            Thread.Sleep(200);
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            Array.Copy(comBuffer, 0, bufType, 0, 36);
            String val = new String(bufType);

            return val;
        }
        public String getTurboPumpSpeed()
        {
            char[] bufType;
            bufType = new char[14];
            comBuffer = new char[100];
            ticSerialPort.Write("?V905\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            Array.Copy(comBuffer, 0, bufType, 0, 13);
            String val = new String(bufType);

            return val;
        }
        public String getTurboPumpSpeedStatus()
        {
            char[] bufType;
            bufType = new char[12];
            comBuffer = new char[100];
            ticSerialPort.Write("?V907\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            Array.Copy(comBuffer, 0, bufType, 0, 11);
            String val = new String(bufType);

            return val;
        }
        public String getTurboPumpFailTime()
        {
            char[] bufType;
            bufType = new char[10];
            comBuffer = new char[100];
            ticSerialPort.Write("?S905\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            Array.Copy(comBuffer, 0, bufType, 0, 9);
            String val = new String(bufType);

            return val;
        }
        public String setTurboPumpFailTime(String failTime)
        {
            char[] bufType;
            bufType = new char[7];
            comBuffer = new char[100];
            ticSerialPort.Write("!S905 " + failTime + "\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            Array.Copy(comBuffer, 0, bufType, 0, 7);
            String val = new String(bufType);

            return val;
        }
        public String getTurboPumpStbyStatus()
        {
            char[] bufType;
            bufType = new char[7];
            comBuffer = new char[100];
            ticSerialPort.Write("?V908\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            Array.Copy(comBuffer, 0, bufType, 0, 7);
            String val = new String(bufType);

            return val;
        }
        public String setTurboPumpStbyOn()
        {
            char[] bufType;
            bufType = new char[7];
            comBuffer = new char[100];
            ticSerialPort.Write("!C908 1\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            Array.Copy(comBuffer, 0, bufType, 0, 7);
            String val = new String(bufType);

            return val;
        }
        public String setTurboPumpStbyOff()
        {
            char[] bufType;
            bufType = new char[7];
            comBuffer = new char[100];
            ticSerialPort.Write("!C908 0\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            Array.Copy(comBuffer, 0, bufType, 0, 7);
            String val = new String(bufType);

            return val;
        }
        public String getTurboPumpWorktime()
        {
            char[] bufType;
            comBuffer = new char[100];
            ticSerialPort.Write("?V909\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            int len = ticSerialPort.BytesToRead;
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            bufType = new char[len - 1];
            Array.Copy(comBuffer, 0, bufType, 0, len - 1);
            String val = new String(bufType);

            return val;
        }
        public String getBackingPumpStatus()
        {
            char[] bufType;
            comBuffer = new char[100];
            ticSerialPort.Write("?V910\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            int len = ticSerialPort.BytesToRead;
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            bufType = new char[len - 1];
            Array.Copy(comBuffer, 0, bufType, 0, len - 1);
            String val = new String(bufType);

            return val;
        }
        public String setBackingPumpOn()
        {
            char[] bufType;
            comBuffer = new char[100];
            ticSerialPort.Write("!C910 1\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            int len = ticSerialPort.BytesToRead;
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            bufType = new char[len - 1];
            Array.Copy(comBuffer, 0, bufType, 0, len - 1);
            String val = new String(bufType);

            return val;
        }
        public String setBackingPumpOff()
        {
            char[] bufType;
            comBuffer = new char[100];
            ticSerialPort.Write("!C910 0\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            int len = ticSerialPort.BytesToRead;
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            bufType = new char[len - 1];
            Array.Copy(comBuffer, 0, bufType, 0, len - 1);
            String val = new String(bufType);

            return val;
        }
        public String getBackingPumpType()
        {
            char[] bufType;
            comBuffer = new char[100];
            ticSerialPort.Write("?S910 3\r");
            Thread.Sleep(WAIT_BEFORE_QUERY);
            int len = ticSerialPort.BytesToRead;
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            bufType = new char[len - 1];
            Array.Copy(comBuffer, 0, bufType, 0, len - 1);
            String val = new String(bufType);

            return val;
        }
        public String getBackingPumpSpeed()
        {
            char[] bufType;
            comBuffer = new char[100];
            ticSerialPort.Write("?V911\r");
            Thread.Sleep(500);
            int len = ticSerialPort.BytesToRead;
            ticSerialPort.Read(comBuffer, 0, ticSerialPort.BytesToRead);
            bufType = new char[len - 1];
            Array.Copy(comBuffer, 0, bufType, 0, len - 1);
            String val = new String(bufType);

            return val;
        }
        public String retticManufacturer()
            { return ticManufacturer; }
        public String retticComPort()
            { return ticComPort; }
        public String retticBaudRate()
            { return ticBaudRate; }
        public String retticStopBits()
            { return ticStopBits; }
        public String retticDataBits()
            { return ticDataBits; }
        public String retticParity()
            { return ticParity; }
        public String retticTimeout()
            { return ticTimeout; }

    }
}
