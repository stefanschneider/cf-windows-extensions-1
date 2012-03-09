﻿// -----------------------------------------------------------------------
// <copyright file="Announcement.cs" company="Uhuru Software, Inc.">
// Copyright (c) 2011 Uhuru Software, Inc., All Rights Reserved
// </copyright>
// -----------------------------------------------------------------------

namespace Uhuru.CloudFoundry.ServiceBase
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using Uhuru.Utilities;
    using Uhuru.Utilities.Json;

    /// <summary>
    /// This class contains announcement information for a service.
    /// </summary>
    public class Announcement : JsonConvertibleObject
    {
        /// <summary>
        /// Gets or sets the id of the service.
        /// </summary>
        [JsonName("id")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the available storage for the service.
        /// </summary>
        [JsonName("available_storage")]
        public long AvailableStorageBytes
        {
            get;
            set;
        }
    }
}