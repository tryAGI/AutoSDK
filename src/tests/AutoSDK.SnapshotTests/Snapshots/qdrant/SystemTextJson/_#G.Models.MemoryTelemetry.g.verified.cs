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
        [global::System.Text.Json.Serialization.JsonPropertyName("active_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActiveBytes { get; set; }

        /// <summary>
        /// Total number of bytes allocated by the application
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allocated_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AllocatedBytes { get; set; }

        /// <summary>
        /// Total number of bytes dedicated to metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MetadataBytes { get; set; }

        /// <summary>
        /// Maximum number of bytes in physically resident data pages mapped
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resident_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ResidentBytes { get; set; }

        /// <summary>
        /// Total number of bytes in virtual memory mappings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retained_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RetainedBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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