﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Komora.Classes;
using Komora;

namespace Komora.Windows
{
    public partial class MeasurementForm : Form
    {
        private string serialPort;
        private DataTypes.ControllerValues controllerValues; //dane ze sterownika
        private Classes.Communication.AT_Command atCommand; //komendy AT
        private Classes.Communication.ParserThread parserThread; //parser danych przychodzacych ze sterownika (osobny watek)
        private DataTypes.MeasurementInfo measInfo;

        public MeasurementForm(string serialPort, DataTypes.MeasurementInfo measInfo)
        {
            this.serialPort = serialPort;
            this.measInfo = measInfo;

            InitializeComponent();
            measurementInfoControl.setMeasurementInfo(this.measInfo);

      

            atCommand = new Classes.Communication.AT_Command(serialPort);
            controllerValues = new DataTypes.ControllerValues();

            parserThread = new Classes.Communication.ParserThread(atCommand.RecivedStrings, ref controllerValues);
        }

        private void MeasurementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parserThread.Stop();
            atCommand.CancelSerialPortDataRecivedHandler();
            atCommand.CloseSerialPort();
        }
    }
}
