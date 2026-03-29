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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// URL of the generated video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Duration of the video in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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