//HintName: G.Models.AudioEmbeddingResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that contains the generated embedding vector and associated information.
    /// </summary>
    public sealed partial class AudioEmbeddingResult
    {
        /// <summary>
        /// An object that contains the embedding and its start time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::G.AudioSegment>? Segments { get; set; }

        /// <summary>
        /// Error message if the embedding generation failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

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
        /// Initializes a new instance of the <see cref="AudioEmbeddingResult" /> class.
        /// </summary>
        /// <param name="segments">
        /// An object that contains the embedding and its start time.
        /// </param>
        /// <param name="errorMessage">
        /// Error message if the embedding generation failed.
        /// </param>
        /// <param name="metadata">
        /// Metadata about the embedding.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioEmbeddingResult(
            global::System.Collections.Generic.IList<global::G.AudioSegment>? segments,
            string? errorMessage,
            global::G.BaseEmbeddingMetadata? metadata)
        {
            this.Segments = segments;
            this.ErrorMessage = errorMessage;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEmbeddingResult" /> class.
        /// </summary>
        public AudioEmbeddingResult()
        {
        }
    }
}