//HintName: G.Models.GetDocumentTextConfigurationMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for document metadata retrieval.
    /// </summary>
    public sealed partial class GetDocumentTextConfigurationMetadata
    {
        /// <summary>
        /// Whether to include document metadata in the response. If false, metadata artifact will not be created.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include")]
        public bool? Include { get; set; }

        /// <summary>
        /// List of JSONPath expressions for metadata fields to exclude from the returned metadata.<br/>
        /// Default Value: []<br/>
        /// Example: [$.internal.processedAt, $.debug]
        /// </summary>
        /// <example>[$.internal.processedAt, $.debug]</example>
        [global::Newtonsoft.Json.JsonProperty("exclude_paths")]
        public global::System.Collections.Generic.IList<string>? ExcludePaths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentTextConfigurationMetadata" /> class.
        /// </summary>
        /// <param name="include">
        /// Whether to include document metadata in the response. If false, metadata artifact will not be created.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="excludePaths">
        /// List of JSONPath expressions for metadata fields to exclude from the returned metadata.<br/>
        /// Default Value: []<br/>
        /// Example: [$.internal.processedAt, $.debug]
        /// </param>
        public GetDocumentTextConfigurationMetadata(
            bool? include,
            global::System.Collections.Generic.IList<string>? excludePaths)
        {
            this.Include = include;
            this.ExcludePaths = excludePaths;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentTextConfigurationMetadata" /> class.
        /// </summary>
        public GetDocumentTextConfigurationMetadata()
        {
        }
    }
}