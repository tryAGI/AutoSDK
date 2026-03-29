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
        /// Title of the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// URL of the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// Description or snippet for the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet")]
        public string? Snippet { get; set; }

        /// <summary>
        /// Upload or publish date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// URL of the video thumbnail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Duration of the video (e.g., "10:30").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// Video platform or source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Channel name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public string? Channel { get; set; }

        /// <summary>
        /// Position of the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResult" /> class.
        /// </summary>
        /// <param name="title">
        /// Title of the video.
        /// </param>
        /// <param name="link">
        /// URL of the video.
        /// </param>
        /// <param name="snippet">
        /// Description or snippet for the video.
        /// </param>
        /// <param name="date">
        /// Upload or publish date.
        /// </param>
        /// <param name="imageUrl">
        /// URL of the video thumbnail.
        /// </param>
        /// <param name="duration">
        /// Duration of the video (e.g., "10:30").
        /// </param>
        /// <param name="source">
        /// Video platform or source.
        /// </param>
        /// <param name="channel">
        /// Channel name.
        /// </param>
        /// <param name="position">
        /// Position of the result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoResult(
            string? title,
            string? link,
            string? snippet,
            string? date,
            string? imageUrl,
            string? duration,
            string? source,
            string? channel,
            int? position)
        {
            this.Title = title;
            this.Link = link;
            this.Snippet = snippet;
            this.Date = date;
            this.ImageUrl = imageUrl;
            this.Duration = duration;
            this.Source = source;
            this.Channel = channel;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResult" /> class.
        /// </summary>
        public VideoResult()
        {
        }
    }
}