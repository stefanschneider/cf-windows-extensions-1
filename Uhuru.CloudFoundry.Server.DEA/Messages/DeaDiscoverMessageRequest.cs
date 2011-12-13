﻿// -----------------------------------------------------------------------
// <copyright file="DeaDiscoverMessageRequest.cs" company="Uhuru Software">
// Copyright (c) 2011 Uhuru Software, Inc., All Rights Reserved
// </copyright>
// -----------------------------------------------------------------------

namespace Uhuru.CloudFoundry.DEA
{
    using Uhuru.Utilities;
    
    // example: {"droplet":198,"limits":{"mem":128,"disk":2048,"fds":256},"name":"helloworld","runtime":"iis","sha":"98b1159c7d3539dd450fd86f92647d3902a0067b
    /// <summary>
    /// This class encapsulates a request message to discover a DEA that can run a droplet.
    /// </summary>
    public class DeaDiscoverMessageRequest : JsonConvertibleObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeaDiscoverMessageRequest"/> class.
        /// </summary>
        public DeaDiscoverMessageRequest()
        {
            this.Limits = new DropletLimits();
        }

        /// <summary>
        /// Gets or sets the droplet id.
        /// </summary>
        [JsonName("droplet")]
        public int DropletId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the app.
        /// </summary>
        [JsonName("name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the runtime the droplet needs.
        /// </summary>
        [JsonName("runtime")]
        public string Runtime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a hash that uniquely identifies the droplet.
        /// </summary>
        [JsonName("sha")]
        public string Sha
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the usage limits for the application (memory, disk, etc.).
        /// </summary>
        [JsonName("limits")]
        public DropletLimits Limits
        {
            get;
            set;
        }
    }

    /// <summary>
    /// This class contains information about the resource limits of a droplet.
    /// </summary>
    public class DropletLimits : JsonConvertibleObject
    {
        /// <summary>
        /// Gets or sets the maximum memory in megabytes.
        /// </summary>
        [JsonName("mem")]
        public long MemoryMbytes
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the maximum disk usage in megabytes.
        /// </summary>
        [JsonName("disk")]
        public long DiskMbytes
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the maximum number of open files and sockets.
        /// </summary>
        [JsonName("fds")]
        public long Fds
        {
            get;
            set;
        }
    }
}
