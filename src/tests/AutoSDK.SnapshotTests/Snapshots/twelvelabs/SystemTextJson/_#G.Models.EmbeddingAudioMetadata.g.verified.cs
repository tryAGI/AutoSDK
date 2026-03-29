//HintName: G.Models.EmbeddingAudioMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata for audio embeddings
    /// </summary>
    public sealed partial class EmbeddingAudioMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbeddingAudioMetadataInputTypeJsonConverter))]
        public global::G.EmbeddingAudioMetadataInputType InputType { get; set; }

        /// <summary>
        /// The publicly accessible URL for the audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_url")]
        public string? InputUrl { get; set; }

        /// <summary>
        /// The name of the audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_filename")]
        public string? InputFilename { get; set; }

        /// <summary>
        /// Audio embedding options used for generating the embedding
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EmbeddingOptions { get; set; }

        /// <summary>
        /// Audio embedding scopes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EmbeddingAudioMetadataEmbeddingScopesItems> EmbeddingScopes { get; set; }

        /// <summary>
        /// Duration of the audio in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// Start offset in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_offset_sec")]
        public double? StartOffsetSec { get; set; }

        /// <summary>
        /// End offset in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_offset_sec")]
        public double? EndOffsetSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingAudioMetadata" /> class.
        /// </summary>
        /// <param name="embeddingOptions">
        /// Audio embedding options used for generating the embedding
        /// </param>
        /// <param name="embeddingScopes">
        /// Audio embedding scopes
        /// </param>
        /// <param name="duration">
        /// Duration of the audio in seconds
        /// </param>
        /// <param name="inputType"></param>
        /// <param name="inputUrl">
        /// The publicly accessible URL for the audio file
        /// </param>
        /// <param name="inputFilename">
        /// The name of the audio file
        /// </param>
        /// <param name="startOffsetSec">
        /// Start offset in seconds
        /// </param>
        /// <param name="endOffsetSec">
        /// End offset in seconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingAudioMetadata(
            global::System.Collections.Generic.IList<string> embeddingOptions,
            global::System.Collections.Generic.IList<global::G.EmbeddingAudioMetadataEmbeddingScopesItems> embeddingScopes,
            double duration,
            global::G.EmbeddingAudioMetadataInputType inputType,
            string? inputUrl,
            string? inputFilename,
            double? startOffsetSec,
            double? endOffsetSec)
        {
            this.InputType = inputType;
            this.InputUrl = inputUrl;
            this.InputFilename = inputFilename;
            this.EmbeddingOptions = embeddingOptions ?? throw new global::System.ArgumentNullException(nameof(embeddingOptions));
            this.EmbeddingScopes = embeddingScopes ?? throw new global::System.ArgumentNullException(nameof(embeddingScopes));
            this.Duration = duration;
            this.StartOffsetSec = startOffsetSec;
            this.EndOffsetSec = endOffsetSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingAudioMetadata" /> class.
        /// </summary>
        public EmbeddingAudioMetadata()
        {
        }
    }
}