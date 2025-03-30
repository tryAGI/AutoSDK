//HintName: G.Models.ComputeCorpusSizeResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing the computed size of a corpus
    /// </summary>
    public sealed partial class ComputeCorpusSizeResponse
    {
        /// <summary>
        /// Number of documents in the corpus
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_docs")]
        public long? UsedDocs { get; set; }

        /// <summary>
        /// Number of document parts in the corpus
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_parts")]
        public long? UsedParts { get; set; }

        /// <summary>
        /// Total number of characters in the corpus
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_characters")]
        public long? UsedCharacters { get; set; }

        /// <summary>
        /// Number of metadata characters in the corpus
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_metadata_characters")]
        public long? UsedMetadataCharacters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputeCorpusSizeResponse" /> class.
        /// </summary>
        /// <param name="usedDocs">
        /// Number of documents in the corpus
        /// </param>
        /// <param name="usedParts">
        /// Number of document parts in the corpus
        /// </param>
        /// <param name="usedCharacters">
        /// Total number of characters in the corpus
        /// </param>
        /// <param name="usedMetadataCharacters">
        /// Number of metadata characters in the corpus
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputeCorpusSizeResponse(
            long? usedDocs,
            long? usedParts,
            long? usedCharacters,
            long? usedMetadataCharacters)
        {
            this.UsedDocs = usedDocs;
            this.UsedParts = usedParts;
            this.UsedCharacters = usedCharacters;
            this.UsedMetadataCharacters = usedMetadataCharacters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputeCorpusSizeResponse" /> class.
        /// </summary>
        public ComputeCorpusSizeResponse()
        {
        }
    }
}