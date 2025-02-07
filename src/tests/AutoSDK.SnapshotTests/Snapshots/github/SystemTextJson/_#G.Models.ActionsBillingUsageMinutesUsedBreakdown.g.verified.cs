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
        [global::System.Text.Json.Serialization.JsonPropertyName("UBUNTU")]
        public int? UBUNTU { get; set; }

        /// <summary>
        /// Total minutes used on macOS runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MACOS")]
        public int? MACOS { get; set; }

        /// <summary>
        /// Total minutes used on Windows runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("WINDOWS")]
        public int? WINDOWS { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 4 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ubuntu_4_core")]
        public int? Ubuntu4Core { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 8 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ubuntu_8_core")]
        public int? Ubuntu8Core { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 16 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ubuntu_16_core")]
        public int? Ubuntu16Core { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 32 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ubuntu_32_core")]
        public int? Ubuntu32Core { get; set; }

        /// <summary>
        /// Total minutes used on Ubuntu 64 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ubuntu_64_core")]
        public int? Ubuntu64Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 4 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("windows_4_core")]
        public int? Windows4Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 8 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("windows_8_core")]
        public int? Windows8Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 16 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("windows_16_core")]
        public int? Windows16Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 32 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("windows_32_core")]
        public int? Windows32Core { get; set; }

        /// <summary>
        /// Total minutes used on Windows 64 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("windows_64_core")]
        public int? Windows64Core { get; set; }

        /// <summary>
        /// Total minutes used on macOS 12 core runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("macos_12_core")]
        public int? Macos12Core { get; set; }

        /// <summary>
        /// Total minutes used on all runner machines.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsBillingUsageMinutesUsedBreakdown" /> class.
        /// </summary>
        /// <param name="uBUNTU">
        /// Total minutes used on Ubuntu runner machines.
        /// </param>
        /// <param name="mACOS">
        /// Total minutes used on macOS runner machines.
        /// </param>
        /// <param name="wINDOWS">
        /// Total minutes used on Windows runner machines.
        /// </param>
        /// <param name="ubuntu4Core">
        /// Total minutes used on Ubuntu 4 core runner machines.
        /// </param>
        /// <param name="ubuntu8Core">
        /// Total minutes used on Ubuntu 8 core runner machines.
        /// </param>
        /// <param name="ubuntu16Core">
        /// Total minutes used on Ubuntu 16 core runner machines.
        /// </param>
        /// <param name="ubuntu32Core">
        /// Total minutes used on Ubuntu 32 core runner machines.
        /// </param>
        /// <param name="ubuntu64Core">
        /// Total minutes used on Ubuntu 64 core runner machines.
        /// </param>
        /// <param name="windows4Core">
        /// Total minutes used on Windows 4 core runner machines.
        /// </param>
        /// <param name="windows8Core">
        /// Total minutes used on Windows 8 core runner machines.
        /// </param>
        /// <param name="windows16Core">
        /// Total minutes used on Windows 16 core runner machines.
        /// </param>
        /// <param name="windows32Core">
        /// Total minutes used on Windows 32 core runner machines.
        /// </param>
        /// <param name="windows64Core">
        /// Total minutes used on Windows 64 core runner machines.
        /// </param>
        /// <param name="macos12Core">
        /// Total minutes used on macOS 12 core runner machines.
        /// </param>
        /// <param name="total">
        /// Total minutes used on all runner machines.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsBillingUsageMinutesUsedBreakdown(
            int? uBUNTU,
            int? mACOS,
            int? wINDOWS,
            int? ubuntu4Core,
            int? ubuntu8Core,
            int? ubuntu16Core,
            int? ubuntu32Core,
            int? ubuntu64Core,
            int? windows4Core,
            int? windows8Core,
            int? windows16Core,
            int? windows32Core,
            int? windows64Core,
            int? macos12Core,
            int? total)
        {
            this.UBUNTU = uBUNTU;
            this.MACOS = mACOS;
            this.WINDOWS = wINDOWS;
            this.Ubuntu4Core = ubuntu4Core;
            this.Ubuntu8Core = ubuntu8Core;
            this.Ubuntu16Core = ubuntu16Core;
            this.Ubuntu32Core = ubuntu32Core;
            this.Ubuntu64Core = ubuntu64Core;
            this.Windows4Core = windows4Core;
            this.Windows8Core = windows8Core;
            this.Windows16Core = windows16Core;
            this.Windows32Core = windows32Core;
            this.Windows64Core = windows64Core;
            this.Macos12Core = macos12Core;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsBillingUsageMinutesUsedBreakdown" /> class.
        /// </summary>
        public ActionsBillingUsageMinutesUsedBreakdown()
        {
        }
    }
}