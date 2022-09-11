//
//   (c) Copyright Agilent Technologies 2011
//              All rights reserved.
//
//  Customer shall have the personal, non-
// transferable rights to use, copy or modify
// this SAMPLE PROGRAM for Customer's internal
// operations. Customer shall use the SAMPLE
// PROGRAM solely and exclusively for its own
// purpose and shall not license, lease, market
// or distribute the SAMPLE PROGRAM or modification
// or any part thereof.
//
//  Agilent shall not be liable for the quality,
// performance or behavior of the SAMPLE PROGRAM.
// Agilent especially disclaims that the operation
// of the SAMPLE PROGRAM shall be uninterrupted or
// error free. This SAMPLE PROGRAM is provided
// AS IS.
//
//  AGILENT DISCLAIMS THE IMPLIED WARRANTIES OF
// MERCHANTABILITY AND FITNESS FOR A PARTICULAR
// PURPOSE.
//
//  Agilent shall not be liable for any infringement
// of any patent, trademark, copyright or other
// proprietary rights by the SAMPLE PROGRAM or
// its use. Agilent does not warrant that the SAMPLE
// PROGRAM is free from infringements or such
// rights of third parties. However, Agilent will not
// knowingly infringe or deliver a software that
// infringes the patent, trademark, copyright or
// other proprietary right of a third party.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ivi.Visa.Interop;
using System.Diagnostics;

namespace StaowiskoApp
{
    class SmuControl
    {
        private ResourceManager ioMgr = new ResourceManager();
        private FormattedIO488 instrument = null;
        private string visaResStr = "";
        private int maxChannel = 0;
        private string modelName = "";
        private string errorMsg = "";
        private const int WAIT_BEFORE_QUERY = 10;

        //Public Sub New()
        //End Sub

        public const int COLUMN_COUNT = 6;

        public int MaxSmuChannel
        {
            get {return maxChannel;}
        }

        public string ModelName
        {
            get {return modelName;}
        }

        public string ErrorMessage
        {
            get {return errorMsg;}
        }

        List<string> smuCommandsList = new List<string>();
        public void addVoltCom(String val)
        {
            UpdateCommandsToSmuList(":SOUR1:VOLT " + val);
        }
        public void addModeVoltCom()
        {
            UpdateCommandsToSmuList(":SOUR1:FUNC:MODE VOLT");
        }
        public void addModeCurrCom()
        {
            UpdateCommandsToSmuList(":SOUR1:FUNC:MODE CURR");
        }
        public void addShapeDcCom()
        {
            UpdateCommandsToSmuList(":SOUR1:FUNC:SHAP DC");
            UpdateCommandsToSmuList(":SOUR1:VOLT:MODE SWE");
        }
        public void addShapePulseCom()
        {
            UpdateCommandsToSmuList(":SOUR1:FUNC:SHAP PULSE");
        }
        public void addSweDirUpCom()
        {
            UpdateCommandsToSmuList(":SOUR1:SWE:DIR UP");
        }
        public void addSweDirDownCom()
        {
            UpdateCommandsToSmuList(":SOUR1:SWE:DIR DOWN");
        }
        public void addSweepLinearSingleCom()
        {
            UpdateCommandsToSmuList(":SOUR1:SWE:SPAC LIN");
            UpdateCommandsToSmuList(":SOUR1:SWE:STA SING");
        }
        public void addSweepLinearDoubleCom()
        {
            UpdateCommandsToSmuList(":SOUR1:SWE:SPAC LIN");
            UpdateCommandsToSmuList(":SOUR1:SWE:SPAC DOUB");
        }
        public void addSweepLogSingleCom()
        {
            UpdateCommandsToSmuList(":SOUR1:SWE:SPAC LOG");
            UpdateCommandsToSmuList(":SOUR1:SWE:STA SING");
        }
        public void addSweepLogDoubleCom()
        {
            UpdateCommandsToSmuList(":SOUR1:SWE:SPAC LOG");
            UpdateCommandsToSmuList(":SOUR1:SWE:SPAC DOUB");
        }
        public void addStartVoltValCom(String val)
        {
            UpdateCommandsToSmuList(":SOUR1:VOLT:STAR " + val);
        }
        public void addStopVoltValCom(String val)
        {
            UpdateCommandsToSmuList(":SOUR1:VOLT:STOP " + val);
        }
        public void addStartCurrValCom(String val)
        {
            UpdateCommandsToSmuList(":SOUR1:CURR:STAR " + val);
        }
        public void addStopCurrValCom(String val)
        {
            UpdateCommandsToSmuList(":SOUR1:CURR:STOP " + val);
        }
        public void addStepNrCom(String val)
        {
            UpdateCommandsToSmuList(":SOUR1:SWE:POIN " + val);
        }
        public void addCompCom(String val)
        {
            UpdateCommandsToSmuList(":SENS1:CURR:PROT " + val);
        }
        public void addSourceRangeAutoCom()
        {
            UpdateCommandsToSmuList(":SOUR1:SWE:RANG AUTO");
        }
        public void addSourceRangeValCom(String val)
        {
            UpdateCommandsToSmuList(":SOUR1:SWE:RANG " + val);
        }
        public void addRangeAutoOnCom()
        {
            UpdateCommandsToSmuList(":SENS1:RANG:AUTO ON");
        }
        public void addRangeAutoOffCom()
        {
            UpdateCommandsToSmuList(":SENS1:RANG:AUTO OFF");
        }
        public void addRangeValCom(String val)
        {
            UpdateCommandsToSmuList(":SENS1:RANG " + val);
        }
        public void addMeasureCounCom(String val)
        {
            UpdateCommandsToSmuList(":ARM1:COUN " + val);
        }
        public void addMeasureDelayCom(String val)
        {
            UpdateCommandsToSmuList(":ARM1:DEL " + val);
        }
        public void addMeasureSourAutoCom()
        {
            UpdateCommandsToSmuList(":ARM1:SOUR AINT");
        }
        public void addTriggerAutoCom()
        {
            UpdateCommandsToSmuList(":TRIG1:SOUR AINT");
        }
        public void addTriggerTimerCom(String val)
        {
            UpdateCommandsToSmuList(":TRIG1:TIM " + val);
        }
        public void addTriggerDelCom(String val)
        {
            UpdateCommandsToSmuList(":TRIG1:DEL " + val);
        }
        public void addTriggerStepsCountCom(String val)
        {
            UpdateCommandsToSmuList(":TRIG1:COUN " + val);
        }
        public void addOutputOnCom()
        {
            UpdateCommandsToSmuList(":OUTP1:STAT ON");
        }
        public void UpdateCommandsToSmuList(String command)
        {
            smuCommandsList.Add(command);
        }
        public bool OpenDevice(string address)
        {
            try
            {
                if (instrument != null) {
                    CloseDevice();
                }
                string buf;
                // Open
                visaResStr = address;
                instrument = new FormattedIO488();
                instrument.IO = (IMessage)ioMgr.Open(address);
                instrument.IO.TerminationCharacterEnabled = true;
                instrument.IO.Timeout = 60000;
                System.Threading.Thread.Sleep(200);

                // Check Model Name
                instrument.WriteString("*IDN?");
                System.Threading.Thread.Sleep(WAIT_BEFORE_QUERY);
                buf = instrument.ReadString().Trim();
                string[] tokens = buf.Split(',');
                if (tokens.Length < 2)
                {
                    maxChannel = 0;
                    modelName = "";
                    errorMsg = "Illegal *IDN response.";
                    CloseDevice();
                    return false;
                }

                modelName = buf.Split(',')[1];
                switch (modelName)
                {
                    case "B2901A":
                    case "B2911A":
                        maxChannel = 1;
                        break;
                    case "B2901B":
                    case "B2911B":
                        maxChannel = 1;
                        break;
                    case "B2902A":
                    case "B2912A":
                        maxChannel = 2;
                        break;
                    default:
                        maxChannel = 0;
                        errorMsg = "Unknown model is found.";
                        CloseDevice();
                        return false;
                }
 
                // Check Language Mode
                instrument.WriteString(":SYST:LANG?");
                System.Threading.Thread.Sleep(WAIT_BEFORE_QUERY);
                buf = instrument.ReadString().Trim();
                if (buf != "\"DEF\"")
                {
                    maxChannel = 0;
                    errorMsg = "Not support 2400 language mode.";
                    CloseDevice();
                    return false;
                }

                // Reset
                instrument.WriteString("*RST");
                instrument.WriteString("*CLS");
            }
            catch ( Exception ex )
            {
                instrument = null;
                errorMsg = ex.Message;
                return false;
            }
            return true;
        }

        public void CloseDevice()
        {
            if (instrument != null) instrument.IO.Close();
            instrument = null;
        }

        private bool ErrorCheck()
        {
            try
            {
                string ret;
                instrument.WriteString(":SYST:ERR:COUNT?");
                System.Threading.Thread.Sleep(WAIT_BEFORE_QUERY);
                ret = instrument.ReadString().Trim();
                if ( int.Parse(ret) > 0 )
                {
                    instrument.WriteString(":SYST:ERR:ALL?");
                    System.Threading.Thread.Sleep(WAIT_BEFORE_QUERY);
                    errorMsg = instrument.ReadString();
                    return false;
                }
            }
            catch ( Exception ex )
            {
                errorMsg = ex.Message;
                return false;
            }
            return true;
        }

        public bool SetSweepChannel()
        {
            try
            {
                int comCount = smuCommandsList.Count;

                for(int idx = 0; idx < comCount; idx++)
                {
                    instrument.WriteString(smuCommandsList[idx]);
                }

                return ErrorCheck();
            }
            catch ( Exception ex )
            {
                errorMsg = ex.Message;
                return false;
            }
        }

        public bool SetConstChannel( int ch, double forcev, double compi )
        {
            try
            {
                instrument.WriteString(":SENS" + ch.ToString() + ":CURR:PROT " + compi.ToString());
                instrument.WriteString(":SOUR" + ch.ToString() + ":VOLT " + forcev.ToString());
                instrument.WriteString(":SOUR" + ch.ToString() + ":FUNC:MODE VOLT");
                instrument.WriteString(":SOUR" + ch.ToString() + ":FUNC:SHAP DC");
                instrument.WriteString(":SOUR" + ch.ToString() + ":VOLT:MODE FIX");
                instrument.WriteString(":OUTP" + ch.ToString() + ":STAT ON");
                return ErrorCheck();
            }
            catch ( Exception ex )
            {
                errorMsg = ex.Message;
                return false;
            }
        }

        public bool Initiate( int[] ch )
        {
            try
            {
                instrument.WriteString(":FORM ASC");
                instrument.WriteString(":FORM:ELEM:SENS VOLT,CURR,RES,TIME,STAT,SOUR");
                string chlist = "(@";
                for ( int i = 0 ; i < ch.Length ; i++ ) 
                {
                    if ( i > 0 ) chlist += ",";
                    chlist += ch[i].ToString();
                }
                chlist += ")";
                instrument.WriteString(":INIT " + chlist);
                smuCommandsList.Clear();
                return ErrorCheck();
            }
            catch ( Exception ex )
            {
                errorMsg = ex.Message;
                return false;
            }
        }

        public bool GetData( int ch, bool fromStart, int len, ref double[,] data, out int actrow )
        {
            actrow = 0;
            try
            {
                string ret;
                bool isBusy;
                do
                {
                    instrument.WriteString(":STAT:OPER:COND?");
                    System.Threading.Thread.Sleep(WAIT_BEFORE_QUERY);
                    ret = instrument.ReadString().Trim();
                    isBusy = ((int.Parse(ret) & 0x0010) == 0);

                    instrument.WriteString(":SENS" + ch.ToString() + ":DATA? " + (fromStart ? "STAR," : "CURR,") + len.ToString());
                    System.Threading.Thread.Sleep(WAIT_BEFORE_QUERY);
                    ret = instrument.ReadString().Trim();
                    string[] ary = ret.Split(',');
                    int row, col;
                    for (row = 0; row < ary.Length / COLUMN_COUNT; row++)
                    {
                        if (double.Parse(ary[row * COLUMN_COUNT]) >= 9.91e37) break;
                        for (col = 0; col < COLUMN_COUNT; col++)
                        {
                            data[row,col] = double.Parse(ary[row * COLUMN_COUNT + col]);
                        }
                    }
                    actrow = row;

                } while (actrow == 0 && isBusy);

                return ErrorCheck();
            }
            catch ( Exception ex )
            {
                errorMsg = ex.Message;
                return false;
            }
        }
        public void SelfTestStart()
        {
            instrument.WriteString("*TST?");
        }
        public String SelfTestStop()
        {
            String val = instrument.ReadString();
            return val; 
        }
    }
}
