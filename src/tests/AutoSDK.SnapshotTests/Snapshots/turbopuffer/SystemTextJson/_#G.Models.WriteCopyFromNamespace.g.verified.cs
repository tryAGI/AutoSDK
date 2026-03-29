//HintName: G.Models.WriteCopyFromNamespace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WriteCopyFromNamespace
    {
        /// <summary>
        /// The namespace to copy documents from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceNamespace { get; set; }

        /// <summary>
        /// (Optional) An API key for the organization containing the source namespace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_api_key")]
        public string? SourceApiKey { get; set; }

        /// <summary>
        /// (Optional) The region of the source namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_region")]
        public string? SourceRegion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteCopyFromNamespace" /> class.
        /// </summary>
        /// <param name="sourceNamespace">
        /// The namespace to copy documents from.
        /// </param>
        /// <param name="sourceApiKey">
        /// (Optional) An API key for the organization containing the source namespace
        /// </param>
        /// <param name="sourceRegion">
        /// (Optional) The region of the source namespace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WriteCopyFromNamespace(
            string sourceNamespace,
            string? sourceApiKey,
            string? sourceRegion)
        {
            this.SourceNamespace = sourceNamespace ?? throw new global::System.ArgumentNullException(nameof(sourceNamespace));
            this.SourceApiKey = sourceApiKey;
            this.SourceRegion = sourceRegion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WriteCopyFromNamespace" /> class.
        /// </summary>
        public WriteCopyFromNamespace()
        {
        }
    }
}