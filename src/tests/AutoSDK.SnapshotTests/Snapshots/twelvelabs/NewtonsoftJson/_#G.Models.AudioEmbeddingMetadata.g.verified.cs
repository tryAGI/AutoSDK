//HintName: G.Models.AudioEmbeddingMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object containing metadata associated with the embedding.
    /// </summary>
    public sealed partial class AudioEmbeddingMetadata
    {
        /// <summary>
        /// The URL of the media file used to generate the embedding. Present if a URL was provided in the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_url")]
        public string? InputUrl { get; set; }

        /// <summary>
        /// The name of the media file used to generate the embedding. Present if a file was provided in the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_filename")]
        public string? InputFilename { get; set; }

        /// <summary>
        /// The type of the embedding. It can take one of the following values: ['audio'] or ['transcription'].
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_embedding_options")]
        public global::System.Collections.Generic.IList<string>? AudioEmbeddingOptions { get; set; }

        /// <summary>
        /// The scope you've specified in the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_embedding_scopes")]
        public global::System.Collections.Generic.IList<string>? AudioEmbeddingScopes { get; set; }

        /// <summary>
        /// The total duration of the audio in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// The start offset in seconds from the beginning of the audio where processing should begin.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_offset_sec")]
        public double? StartOffsetSec { get; set; }

        /// <summary>
        /// The end offset in seconds from the beginning of the audio where processing should end.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_offset_sec")]
        public double? EndOffsetSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEmbeddingMetadata" /> class.
        /// </summary>
        /// <param name="inputUrl">
        /// The URL of the media file used to generate the embedding. Present if a URL was provided in the request.
        /// </param>
        /// <param name="inputFilename">
        /// The name of the media file used to generate the embedding. Present if a file was provided in the request.
        /// </param>
        /// <param name="audioEmbeddingOptions">
        /// The type of the embedding. It can take one of the following values: ['audio'] or ['transcription'].
        /// </param>
        /// <param name="audioEmbeddingScopes">
        /// The scope you've specified in the request.
        /// </param>
        /// <param name="duration">
        /// The total duration of the audio in seconds.
        /// </param>
        /// <param name="startOffsetSec">
        /// The start offset in seconds from the beginning of the audio where processing should begin.
        /// </param>
        /// <param name="endOffsetSec">
        /// The end offset in seconds from the beginning of the audio where processing should end.
        /// </param>
        public AudioEmbeddingMetadata(
            string? inputUrl,
            string? inputFilename,
            global::System.Collections.Generic.IList<string>? audioEmbeddingOptions,
            global::System.Collections.Generic.IList<string>? audioEmbeddingScopes,
            double? duration,
            double? startOffsetSec,
            double? endOffsetSec)
        {
            this.InputUrl = inputUrl;
            this.InputFilename = inputFilename;
            this.AudioEmbeddingOptions = audioEmbeddingOptions;
            this.AudioEmbeddingScopes = audioEmbeddingScopes;
            this.Duration = duration;
            this.StartOffsetSec = startOffsetSec;
            this.EndOffsetSec = endOffsetSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioEmbeddingMetadata" /> class.
        /// </summary>
        public AudioEmbeddingMetadata()
        {
        }
    }
}