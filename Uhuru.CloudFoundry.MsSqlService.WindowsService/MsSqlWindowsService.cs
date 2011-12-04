﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using Uhuru.CloudFoundry.Server.MsSqlNode;
using Uhuru.Configuration.Service;
using Uhuru.Configuration;
using Uhuru.CloudFoundry.ServiceBase;

namespace Uhuru.CloudFoundry.MsSqlService.WindowsService
{
    public partial class MsSqlWindowsService : System.ServiceProcess.ServiceBase
    {
        Node node;

        public MsSqlWindowsService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Start(args);
        }

        protected override void OnStop()
        {
            node.Shutdown();
        }

        internal void Start(string[] args)
        {

            ServiceElement serviceConfig = UhuruSection.GetSection().Service;

            Options options = new Options();
            options.AvailableStorage = serviceConfig.AvailableStorage;
            options.BaseDir = serviceConfig.BaseDir;
            options.Index = serviceConfig.Index;
            options.LocalDB = serviceConfig.LocalDb;
            options.MaxDBSize = serviceConfig.MaxDbSize;
            options.MaxLengthyQuery = serviceConfig.MaxLongQuery;
            options.MaxLengthyTX = serviceConfig.MaxLongTx;
            options.MigrationNFS = serviceConfig.MigrationNfs;
            options.NodeId = serviceConfig.NodeId;
            options.Uri = serviceConfig.MBus;
            options.ZInterval = serviceConfig.ZInterval;

            MsSqlOptions msSqlOptions = new MsSqlOptions();
            msSqlOptions.Host = serviceConfig.MsSql.Host;
            msSqlOptions.User = serviceConfig.MsSql.User;
            msSqlOptions.Port = serviceConfig.MsSql.Port;
            msSqlOptions.Password = serviceConfig.MsSql.Password;

            Node node = new Node();
            node.Start(options, msSqlOptions);
        }
    }
}
