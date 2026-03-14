//HintName: G.Models.GetDocumentTextConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// User-configurable settings for the get document text tool. These parameters are never exposed to the agent.
    /// </summary>
    public sealed partial class GetDocumentTextConfiguration
    {
        /// <summary>
        /// Configuration for document metadata retrieval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.GetDocumentTextConfigurationMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentTextConfiguration" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Configuration for document metadata retrieval.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDocumentTextConfiguration(
            global::G.GetDocumentTextConfigurationMetadata? metadata)
        {
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentTextConfiguration" /> class.
        /// </summary>
        public GetDocumentTextConfiguration()
        {
        }
    }
}