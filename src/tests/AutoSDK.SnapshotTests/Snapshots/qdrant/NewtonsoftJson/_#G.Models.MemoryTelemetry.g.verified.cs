//HintName: G.Models.MemoryTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoryTelemetry
    {
        /// <summary>
        /// Total number of bytes in active pages allocated by the application
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int ActiveBytes { get; set; } = default!;

        /// <summary>
        /// Total number of bytes allocated by the application
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allocated_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int AllocatedBytes { get; set; } = default!;

        /// <summary>
        /// Total number of bytes dedicated to metadata
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int MetadataBytes { get; set; } = default!;

        /// <summary>
        /// Maximum number of bytes in physically resident data pages mapped
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resident_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int ResidentBytes { get; set; } = default!;

        /// <summary>
        /// Total number of bytes in virtual memory mappings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retained_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int RetainedBytes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryTelemetry" /> class.
        /// </summary>
        /// <param name="activeBytes">
        /// Total number of bytes in active pages allocated by the application
        /// </param>
        /// <param name="allocatedBytes">
        /// Total number of bytes allocated by the application
        /// </param>
        /// <param name="metadataBytes">
        /// Total number of bytes dedicated to metadata
        /// </param>
        /// <param name="residentBytes">
        /// Maximum number of bytes in physically resident data pages mapped
        /// </param>
        /// <param name="retainedBytes">
        /// Total number of bytes in virtual memory mappings
        /// </param>
        public MemoryTelemetry(
            int activeBytes,
            int allocatedBytes,
            int metadataBytes,
            int residentBytes,
            int retainedBytes)
        {
            this.ActiveBytes = activeBytes;
            this.AllocatedBytes = allocatedBytes;
            this.MetadataBytes = metadataBytes;
            this.ResidentBytes = residentBytes;
            this.RetainedBytes = retainedBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryTelemetry" /> class.
        /// </summary>
        public MemoryTelemetry()
        {
        }
    }
}