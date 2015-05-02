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
using Komora.DataTypes;
using System.Threading;

namespace Komora.Windows
{
    public partial class MeasurementForm : Form
    {
        private string serialPort;
        private DataTypes.ControllerValues controllerValues; //dane ze sterownika
        private Classes.Communication.AT_Command atCommand; //komendy AT
        private Classes.Communication.ParserThread parserThread; //parser danych przychodzacych ze sterownika (osobny watek)
        private DataTypes.MeasurementInfo measInfo;
        private Classes.DataBase.LinqDataBaseConnector databaseConnection;

        public MeasurementForm(string serialPort, DataTypes.MeasurementInfo measInfo)
        {
            this.serialPort = serialPort;
            this.measInfo = measInfo;

            InitializeComponent();

            atCommand = new Classes.Communication.AT_Command(serialPort);
            controllerValues = new DataTypes.ControllerValues();
            parserThread = new Classes.Communication.ParserThread(atCommand.RecivedStrings, ref controllerValues);
            databaseConnection = new Classes.DataBase.LinqDataBaseConnector();
            databaseConnection.connect();

            controllerValues.cont_Mode = CONT_MODE.FEEDBACK;
            controllerValues.pwm_Mode = CONTROL_MODE.HEATER;

            atCommand.AT_CONT_MODE(controllerValues.cont_Mode);
            Thread.Sleep(300);
            atCommand.AT_CONTROL_MODE(controllerValues.pwm_Mode);
            Thread.Sleep(300);

            measurementInfoControl.setMeasurementInfo(databaseConnection.getMeasurementInfo(measInfo.measurementName));
        }

        private void MeasurementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parserThread.Stop();
            atCommand.CancelSerialPortDataRecivedHandler();
            atCommand.CloseSerialPort();
        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            
        }
    }
}
