using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace StaowiskoApp
{
    public partial class Settings : Form
    {

        public Settings()
        {
            InitializeComponent();
            //SMU_B2911B smu = new SMU_B2911B();
        }
       
        int lineNumber;

        public String smuType;
        public String smuModel;
        public String smuSerial_Number;
        public String smuManufacturer;
        public String smuUsb_Address;
        public void LoadDevicesParameters()
        {
            XmlReader xmlReader = XmlReader.Create("C:/1_Projekty/VisualStudio/Vigo/1_Stanowisko/2_Software/1_ver_0001/StaowiskoApp/StaowiskoApp/devSettings.xml");
            IXmlLineInfo xmlInfo = (IXmlLineInfo)xmlReader;

            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "SMU"))
                {
                    lineNumber = xmlInfo.LineNumber;
                    if (xmlReader.HasAttributes)
                    {
                        switch (lineNumber)
                        {
                            case 4:
                                smuType = xmlReader.GetAttribute("Type");
                                dataGridViewSmuSettings.Rows.Add();
                                dataGridViewSmuSettings.Rows[0].Cells[0].Value = smuType; break;
                            case 5:
                                smuModel = xmlReader.GetAttribute("Model");
                                dataGridViewSmuSettings.Rows.Add();
                                dataGridViewSmuSettings.Rows[1].Cells[1].Value = "Model";
                                dataGridViewSmuSettings.Rows[1].Cells[2].Value = smuModel; break;
                            case 6:
                                smuSerial_Number = xmlReader.GetAttribute("Serial_Number");
                                dataGridViewSmuSettings.Rows.Add();
                                dataGridViewSmuSettings.Rows[2].Cells[1].Value = "Serial Number";
                                dataGridViewSmuSettings.Rows[2].Cells[2].Value = smuSerial_Number; break;
                            case 7:
                                smuManufacturer = xmlReader.GetAttribute("Manufacturer");
                                dataGridViewSmuSettings.Rows.Add();
                                dataGridViewSmuSettings.Rows[3].Cells[1].Value = "Manufacturer";
                                dataGridViewSmuSettings.Rows[3].Cells[2].Value = smuManufacturer; break;
                            case 8:
                                smuUsb_Address = xmlReader.GetAttribute("Usb_Address");
                                dataGridViewSmuSettings.Rows.Add();
                                dataGridViewSmuSettings.Rows[4].Cells[1].Value = "USB Address";
                                dataGridViewSmuSettings.Rows[4].Cells[2].Value = smuUsb_Address; break;
                        }

                    }
                }
            }
        }
        private void ReadXmlButton_Click(object sender, EventArgs e)
        {
            LoadDevicesParameters();
        }
    }
}
