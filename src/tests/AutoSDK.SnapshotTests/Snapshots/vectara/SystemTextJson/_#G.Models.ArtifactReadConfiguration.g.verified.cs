//HintName: G.Models.ArtifactReadConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// User-configurable settings for the artifact read tool.
    /// </summary>
    public sealed partial class ArtifactReadConfiguration
    {
        /// <summary>
        /// Maximum file size in bytes for full reads without line ranges. Defaults to 256KB.<br/>
        /// Default Value: 262144
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_size_bytes")]
        public long? MaxSizeBytes { get; set; }

        /// <summary>
        /// Maximum number of lines for range-based reads. Defaults to 200.<br/>
        /// Default Value: 200
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_lines")]
        public int? MaxLines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactReadConfiguration" /> class.
        /// </summary>
        /// <param name="maxSizeBytes">
        /// Maximum file size in bytes for full reads without line ranges. Defaults to 256KB.<br/>
        /// Default Value: 262144
        /// </param>
        /// <param name="maxLines">
        /// Maximum number of lines for range-based reads. Defaults to 200.<br/>
        /// Default Value: 200
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArtifactReadConfiguration(
            long? maxSizeBytes,
            int? maxLines)
        {
            this.MaxSizeBytes = maxSizeBytes;
            this.MaxLines = maxLines;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactReadConfiguration" /> class.
        /// </summary>
        public ArtifactReadConfiguration()
        {
        }
    }
}