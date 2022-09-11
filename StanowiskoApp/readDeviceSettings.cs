using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StaowiskoApp
{
    public  class readSmuDeviceSettings
    {
        public string MangleString(int someValue)
        {
            XmlReader xmlReader = XmlReader.Create("D:/Praca/3_StanowiskoPomiaroweDetektorów/4_Software/StaowiskoApp/devSettings.xml"); ///Zrobić po Bożemu :)
            IXmlLineInfo xmlInfo = (IXmlLineInfo)xmlReader;

            int lineNumber = 0;
            
            String smuType = "null";
            String smuModel = "null";
            String smuSerial_Number = "null";
            String smuManufacturer = "null";
            String smuUsb_Address = "null";
          
            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "SMU"))
                {
                    lineNumber = xmlInfo.LineNumber;
                    if (xmlReader.HasAttributes)
                    {
                        switch (lineNumber)
                        {
                            case 4: smuType = xmlReader.GetAttribute("Type");                   break;
                            case 5: smuModel = xmlReader.GetAttribute("Model");                 break;
                            case 6: smuSerial_Number = xmlReader.GetAttribute("Serial_Number"); break;
                            case 7: smuManufacturer = xmlReader.GetAttribute("Manufacturer");   break;
                            case 8: smuUsb_Address = xmlReader.GetAttribute("Usb_Address");     break;
                        }

                    }
                }
            }
            switch (someValue)
                {
                 case 0: return smuType; 
                 case 1: return smuModel;
                 case 2: return smuSerial_Number;
                 case 3: return smuManufacturer;
                 case 4: return smuUsb_Address;
                }
            return "null";
        }
    }
    public class readTicDeviceSettings
    {
        public string MangleString(int someValue)
        {
            XmlReader xmlReader = XmlReader.Create("D:/Praca/3_StanowiskoPomiaroweDetektorów/4_Software/StaowiskoApp/devSettings.xml"); ///Zrobić po Bożemu :)
            IXmlLineInfo xmlInfo = (IXmlLineInfo)xmlReader;

            int lineNumber = 0;

            String ticType = "null";
            String ticModel = "null";
            String ticSwVer = "null";
            String ticSerial_Number = "null";
            String ticManufacturer = "null";
            String ticComPort = "null";
            String ticBaudRate = "null";
            String ticStopBits = "null";
            String ticDataBits = "null";
            String ticParity   = "null";
            String ticTimeout  = "null";


            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "TIC100"))
                {
                    lineNumber = xmlInfo.LineNumber;
                    if (xmlReader.HasAttributes)
                    {
                        switch (lineNumber)
                        {
                            case 11: ticType = xmlReader.GetAttribute("Type"); break;
                            case 12: ticModel = xmlReader.GetAttribute("Model"); break;
                            case 13: ticSwVer = xmlReader.GetAttribute("Sw_Ver"); break;
                            case 14: ticSerial_Number = xmlReader.GetAttribute("Serial_Number"); break;
                            case 15: ticManufacturer = xmlReader.GetAttribute("Manufacturer"); break;
                            case 16: ticComPort = xmlReader.GetAttribute("Com_Port"); break;
                            case 17: ticBaudRate = xmlReader.GetAttribute("Baud_Rate"); break;
                            case 18: ticStopBits = xmlReader.GetAttribute("Stop_Bits"); break;
                            case 19: ticDataBits = xmlReader.GetAttribute("Data_Bits"); break;
                            case 20: ticParity = xmlReader.GetAttribute("Parity"); break;
                            case 21: ticTimeout = xmlReader.GetAttribute("Timeout"); break;
                        }

                    }
                }
            }
            switch (someValue)
            {
                case 1:  return ticType;
                case 2:  return ticModel;
                case 3:  return ticSwVer;
                case 4:  return ticSerial_Number;
                case 5:  return ticManufacturer;
                case 6:  return ticComPort;
                case 7:  return ticBaudRate;
                case 8:  return ticStopBits;
                case 9:  return ticDataBits;
                case 10: return ticParity;
                case 11: return ticTimeout; 
            }
            return "null";
        }
    }
}
