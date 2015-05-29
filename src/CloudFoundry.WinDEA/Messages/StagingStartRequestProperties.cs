﻿namespace CloudFoundry.WinDEA.Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using CloudFoundry.Utilities;
    using CloudFoundry.Utilities.Json;

    public class StagingStartRequestProperties : JsonConvertibleObject
    {
        public StagingStartRequestProperties()
        {
            this.Resources = new StagingStartRequestResources();
            this.Meta = new StagingStartRequestMeta();
        }

        [JsonName("services")]
        public Dictionary<string, object>[] Services { get; set; }

        [JsonName("buildpack")]
        public string Buildpack { get; set; }

        [JsonName("buildpack_git_url")]
        public string BuildpackGitUrl { get; set; }

        [JsonName("buildpack_key")]
        public string BuildpackKey { get; set; }

        [JsonName("resources")]
        public StagingStartRequestResources Resources { get; set; }

        [JsonName("environment")]
        public string[] Environment{ get; set; }

        [JsonName("meta")]
        public StagingStartRequestMeta Meta { get; set; }

    }

    public class StagingStartRequestResources : JsonConvertibleObject
    {
        /// <summary>
        /// Gets or sets the maximum memory limit in megabytes.
        /// </summary>
        [JsonName("memory")] 
        public long? MemoryMbytes { get; set; }

        /// <summary>
        /// Gets or sets the maximum disk usage in megabytes.
        /// </summary>
        [JsonName("disk")]
        public long? DiskMbytes { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of open files and sockets.
        /// </summary>
        [JsonName("fds")]
        public long? FileDescriptors { get; set; }
    }

    public class StagingStartRequestMeta : JsonConvertibleObject
    {
        [JsonName("console")]
        public bool Console { get; set; }

        [JsonName("command")]
        public string Command { get; set; }
    }
}
