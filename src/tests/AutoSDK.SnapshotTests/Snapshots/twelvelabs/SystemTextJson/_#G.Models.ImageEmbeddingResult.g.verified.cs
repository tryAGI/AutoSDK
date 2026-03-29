//HintName: G.Models.ImageEmbeddingResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object containing the generated embedding vector and associated information.
    /// </summary>
    public sealed partial class ImageEmbeddingResult
    {
        /// <summary>
        /// Error message if the embedding generation failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// An object that contains the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::G.BaseSegment>? Segments { get; set; }

        /// <summary>
        /// Metadata about the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.BaseEmbeddingMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEmbeddingResult" /> class.
        /// </summary>
        /// <param name="errorMessage">
        /// Error message if the embedding generation failed.
        /// </param>
        /// <param name="segments">
        /// An object that contains the embedding.
        /// </param>
        /// <param name="metadata">
        /// Metadata about the embedding.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageEmbeddingResult(
            string? errorMessage,
            global::System.Collections.Generic.IList<global::G.BaseSegment>? segments,
            global::G.BaseEmbeddingMetadata? metadata)
        {
            this.ErrorMessage = errorMessage;
            this.Segments = segments;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEmbeddingResult" /> class.
        /// </summary>
        public ImageEmbeddingResult()
        {
        }
    }
}