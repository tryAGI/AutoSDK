//HintName: G.Models.EmbeddingVideoMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata for video embeddings
    /// </summary>
    public sealed partial class EmbeddingVideoMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbeddingVideoMetadataInputTypeJsonConverter))]
        public global::G.EmbeddingVideoMetadataInputType InputType { get; set; }

        /// <summary>
        /// The publicly accessible URL for the video file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_url")]
        public string? InputUrl { get; set; }

        /// <summary>
        /// The name of the video file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_filename")]
        public string? InputFilename { get; set; }

        /// <summary>
        /// Length of each video clip in seconds. Only available for fixed segmentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clip_length")]
        public int? ClipLength { get; set; }

        /// <summary>
        /// Video embedding scopes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EmbeddingVideoMetadataEmbeddingScopesItems> EmbeddingScopes { get; set; }

        /// <summary>
        /// Video embedding options used for generating the embedding
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EmbeddingOptions { get; set; }

        /// <summary>
        /// Duration of the video in seconds
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
        /// Initializes a new instance of the <see cref="EmbeddingVideoMetadata" /> class.
        /// </summary>
        /// <param name="embeddingScopes">
        /// Video embedding scopes
        /// </param>
        /// <param name="embeddingOptions">
        /// Video embedding options used for generating the embedding
        /// </param>
        /// <param name="duration">
        /// Duration of the video in seconds
        /// </param>
        /// <param name="inputType"></param>
        /// <param name="inputUrl">
        /// The publicly accessible URL for the video file
        /// </param>
        /// <param name="inputFilename">
        /// The name of the video file
        /// </param>
        /// <param name="clipLength">
        /// Length of each video clip in seconds. Only available for fixed segmentation.
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
        public EmbeddingVideoMetadata(
            global::System.Collections.Generic.IList<global::G.EmbeddingVideoMetadataEmbeddingScopesItems> embeddingScopes,
            global::System.Collections.Generic.IList<string> embeddingOptions,
            double duration,
            global::G.EmbeddingVideoMetadataInputType inputType,
            string? inputUrl,
            string? inputFilename,
            int? clipLength,
            double? startOffsetSec,
            double? endOffsetSec)
        {
            this.InputType = inputType;
            this.InputUrl = inputUrl;
            this.InputFilename = inputFilename;
            this.ClipLength = clipLength;
            this.EmbeddingScopes = embeddingScopes ?? throw new global::System.ArgumentNullException(nameof(embeddingScopes));
            this.EmbeddingOptions = embeddingOptions ?? throw new global::System.ArgumentNullException(nameof(embeddingOptions));
            this.Duration = duration;
            this.StartOffsetSec = startOffsetSec;
            this.EndOffsetSec = endOffsetSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingVideoMetadata" /> class.
        /// </summary>
        public EmbeddingVideoMetadata()
        {
        }
    }
}