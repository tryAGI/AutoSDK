//HintName: G.Models.VideoEmbeddingMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object containing metadata associated with the embedding.
    /// </summary>
    public sealed partial class VideoEmbeddingMetadata
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
        /// The duration for each clip in seconds, as specified in the request. Note that the platform automatically truncates video segments shorter than 2 seconds. For a 31-second video divided into 6-second segments, the final 1-second segment will be truncated. This truncation only applies to the last segment if it does not meet the minimum length requirement of 2 seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_clip_length")]
        public double? VideoClipLength { get; set; }

        /// <summary>
        /// The scope you've specified in the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_embedding_scope")]
        public global::System.Collections.Generic.IList<string>? VideoEmbeddingScope { get; set; }

        /// <summary>
        /// The total duration of the video in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoEmbeddingMetadata" /> class.
        /// </summary>
        /// <param name="inputUrl">
        /// The URL of the media file used to generate the embedding. Present if a URL was provided in the request.
        /// </param>
        /// <param name="inputFilename">
        /// The name of the media file used to generate the embedding. Present if a file was provided in the request.
        /// </param>
        /// <param name="videoClipLength">
        /// The duration for each clip in seconds, as specified in the request. Note that the platform automatically truncates video segments shorter than 2 seconds. For a 31-second video divided into 6-second segments, the final 1-second segment will be truncated. This truncation only applies to the last segment if it does not meet the minimum length requirement of 2 seconds.
        /// </param>
        /// <param name="videoEmbeddingScope">
        /// The scope you've specified in the request.
        /// </param>
        /// <param name="duration">
        /// The total duration of the video in seconds.
        /// </param>
        public VideoEmbeddingMetadata(
            string? inputUrl,
            string? inputFilename,
            double? videoClipLength,
            global::System.Collections.Generic.IList<string>? videoEmbeddingScope,
            double? duration)
        {
            this.InputUrl = inputUrl;
            this.InputFilename = inputFilename;
            this.VideoClipLength = videoClipLength;
            this.VideoEmbeddingScope = videoEmbeddingScope;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoEmbeddingMetadata" /> class.
        /// </summary>
        public VideoEmbeddingMetadata()
        {
        }
    }
}