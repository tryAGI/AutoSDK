//HintName: G.Models.ActionsBillingUsageMinutesUsedBreakdown.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsBillingUsageMinutesUsedBreakdown
    {
        /// <summary>
        /// Total minutes used on Ubuntu runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("UBUNTU")]
        public int? UBUNTU { get; set; }

        /// <summary>
        /// Total minutes used on macOS runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("MACOS")]
        public int? MACOS { get; set; }

        /// <summary>
        /// Total minutes used on Windows runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("WINDOWS")]
        public int? WINDOWS { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 4 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ubuntu_4_core")]
        public int? Ubuntu4Core { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 8 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ubuntu_8_core")]
        public int? Ubuntu8Core { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 16 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ubuntu_16_core")]
        public int? Ubuntu16Core { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 32 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ubuntu_32_core")]
        public int? Ubuntu32Core { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 64 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ubuntu_64_core")]
        public int? Ubuntu64Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 4 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("windows_4_core")]
        public int? Windows4Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 8 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("windows_8_core")]
        public int? Windows8Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 16 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("windows_16_core")]
        public int? Windows16Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 32 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("windows_32_core")]
        public int? Windows32Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 64 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("windows_64_core")]
        public int? Windows64Core { get; set; }

        /// <summary>
        /// Total minutes used on macOS 12 core runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("macos_12_core")]
        public int? Macos12Core { get; set; }

        /// <summary>
        /// Total minutes used on all runner machines.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}