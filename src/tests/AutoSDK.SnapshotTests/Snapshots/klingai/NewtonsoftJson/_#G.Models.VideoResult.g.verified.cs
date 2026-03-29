//HintName: G.Models.VideoResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoResult
    {
        /// <summary>
        /// Video ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// URL of the generated video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Duration of the video in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResult" /> class.
        /// </summary>
        /// <param name="id">
        /// Video ID.
        /// </param>
        /// <param name="url">
        /// URL of the generated video.
        /// </param>
        /// <param name="duration">
        /// Duration of the video in seconds.
        /// </param>
        public VideoResult(
            string? id,
            string? url,
            string? duration)
        {
            this.Id = id;
            this.Url = url;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResult" /> class.
        /// </summary>
        public VideoResult()
        {
        }
    }
}