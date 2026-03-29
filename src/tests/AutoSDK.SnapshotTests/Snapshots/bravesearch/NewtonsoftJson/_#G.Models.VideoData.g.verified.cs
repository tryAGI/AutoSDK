//HintName: G.Models.VideoData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Data about a video result.
    /// </summary>
    public sealed partial class VideoData
    {
        /// <summary>
        /// Duration of the video (e.g., "10:30").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// Number of views.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("views")]
        public string? Views { get; set; }

        /// <summary>
        /// Creator/uploader of the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator")]
        public string? Creator { get; set; }

        /// <summary>
        /// Publisher/platform.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publisher")]
        public string? Publisher { get; set; }

        /// <summary>
        /// Thumbnail image information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail")]
        public global::G.Thumbnail? Thumbnail { get; set; }

        /// <summary>
        /// Tags associated with the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoData" /> class.
        /// </summary>
        /// <param name="duration">
        /// Duration of the video (e.g., "10:30").
        /// </param>
        /// <param name="views">
        /// Number of views.
        /// </param>
        /// <param name="creator">
        /// Creator/uploader of the video.
        /// </param>
        /// <param name="publisher">
        /// Publisher/platform.
        /// </param>
        /// <param name="thumbnail">
        /// Thumbnail image information.
        /// </param>
        /// <param name="tags">
        /// Tags associated with the video.
        /// </param>
        public VideoData(
            string? duration,
            string? views,
            string? creator,
            string? publisher,
            global::G.Thumbnail? thumbnail,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Duration = duration;
            this.Views = views;
            this.Creator = creator;
            this.Publisher = publisher;
            this.Thumbnail = thumbnail;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoData" /> class.
        /// </summary>
        public VideoData()
        {
        }
    }
}