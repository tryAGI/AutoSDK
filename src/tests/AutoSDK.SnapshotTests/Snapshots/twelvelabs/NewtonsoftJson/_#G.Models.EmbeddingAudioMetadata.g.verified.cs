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
        [global::Newtonsoft.Json.JsonProperty("input_type")]
        public global::G.EmbeddingAudioMetadataInputType InputType { get; set; }

        /// <summary>
        /// The publicly accessible URL for the audio file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_url")]
        public string? InputUrl { get; set; }

        /// <summary>
        /// The name of the audio file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_filename")]
        public string? InputFilename { get; set; }

        /// <summary>
        /// Audio embedding options used for generating the embedding
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_options", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> EmbeddingOptions { get; set; } = default!;

        /// <summary>
        /// Audio embedding scopes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_scopes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EmbeddingAudioMetadataEmbeddingScopesItems> EmbeddingScopes { get; set; } = default!;

        /// <summary>
        /// Duration of the audio in seconds
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