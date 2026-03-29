//HintName: G.Models.VideoResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single video search result.
    /// </summary>
    public sealed partial class VideoResult
    {
        /// <summary>
        /// The type of the result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// URL of the video page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Title of the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Description of the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Human-readable age (e.g., "3 days ago").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("age")]
        public string? Age { get; set; }

        /// <summary>
        /// Age of the page (ISO 8601 date).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_age")]
        public string? PageAge { get; set; }

        /// <summary>
        /// Aggregated URL information for a result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta_url")]
        public global::G.MetaUrl? MetaUrl { get; set; }

        /// <summary>
        /// Thumbnail image information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail")]
        public global::G.Thumbnail? Thumbnail { get; set; }

        /// <summary>
        /// Data about a video result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video")]
        public global::G.VideoData? Video { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResult" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the result.
        /// </param>
        /// <param name="url">
        /// URL of the video page.
        /// </param>
        /// <param name="title">
        /// Title of the video.
        /// </param>
        /// <param name="description">
        /// Description of the video.
        /// </param>
        /// <param name="age">
        /// Human-readable age (e.g., "3 days ago").
        /// </param>
        /// <param name="pageAge">
        /// Age of the page (ISO 8601 date).
        /// </param>
        /// <param name="metaUrl">
        /// Aggregated URL information for a result.
        /// </param>
        /// <param name="thumbnail">
        /// Thumbnail image information.
        /// </param>
        /// <param name="video">
        /// Data about a video result.
        /// </param>
        public VideoResult(
            string? type,
            string? url,
            string? title,
            string? description,
            string? age,
            string? pageAge,
            global::G.MetaUrl? metaUrl,
            global::G.Thumbnail? thumbnail,
            global::G.VideoData? video)
        {
            this.Type = type;
            this.Url = url;
            this.Title = title;
            this.Description = description;
            this.Age = age;
            this.PageAge = pageAge;
            this.MetaUrl = metaUrl;
            this.Thumbnail = thumbnail;
            this.Video = video;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResult" /> class.
        /// </summary>
        public VideoResult()
        {
        }
    }
}