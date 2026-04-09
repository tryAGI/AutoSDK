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
        [global::Newtonsoft.Json.JsonProperty("input_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EmbeddingVideoMetadataInputTypeJsonConverter))]
        public global::G.EmbeddingVideoMetadataInputType InputType { get; set; }

        /// <summary>
        /// The publicly accessible URL for the video file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_url")]
        public string? InputUrl { get; set; }

        /// <summary>
        /// The name of the video file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_filename")]
        public string? InputFilename { get; set; }

        /// <summary>
        /// Length of each video clip in seconds. Only available for fixed segmentation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clip_length")]
        public int? ClipLength { get; set; }

        /// <summary>
        /// Video embedding scopes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_scopes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EmbeddingVideoMetadataEmbeddingScopesItems> EmbeddingScopes { get; set; } = default!;

        /// <summary>
        /// Video embedding options used for generating the embedding
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_options", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> EmbeddingOptions { get; set; } = default!;

        /// <summary>
        /// Duration of the video in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public double Duration { get; set; } = default!;

        /// <summary>
        /// Start offset in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_offset_sec")]
        public double? StartOffsetSec { get; set; }

        /// <summary>
        /// End offset in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_offset_sec")]
        public double? EndOffsetSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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