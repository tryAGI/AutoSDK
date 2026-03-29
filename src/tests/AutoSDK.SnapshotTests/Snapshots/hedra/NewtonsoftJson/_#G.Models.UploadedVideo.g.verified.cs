//HintName: G.Models.UploadedVideo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadedVideo
    {
        /// <summary>
        /// Default Value: uploaded_video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Width of the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width", Required = global::Newtonsoft.Json.Required.Always)]
        public int Width { get; set; } = default!;

        /// <summary>
        /// Height of the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height", Required = global::Newtonsoft.Json.Required.Always)]
        public int Height { get; set; } = default!;

        /// <summary>
        /// Duration of the video in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int DurationMs { get; set; } = default!;

        /// <summary>
        /// URL of the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// URL to download the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// URL to stream the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("streaming_url")]
        public string? StreamingUrl { get; set; }

        /// <summary>
        /// URL of the poster image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("poster_url")]
        public string? PosterUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedVideo" /> class.
        /// </summary>
        /// <param name="width">
        /// Width of the video.
        /// </param>
        /// <param name="height">
        /// Height of the video.
        /// </param>
        /// <param name="durationMs">
        /// Duration of the video in milliseconds.
        /// </param>
        /// <param name="url">
        /// URL of the video.
        /// </param>
        /// <param name="type">
        /// Default Value: uploaded_video
        /// </param>
        /// <param name="downloadUrl">
        /// URL to download the video.
        /// </param>
        /// <param name="streamingUrl">
        /// URL to stream the video.
        /// </param>
        /// <param name="posterUrl">
        /// URL of the poster image.
        /// </param>
        public UploadedVideo(
            int width,
            int height,
            int durationMs,
            string url,
            string? type,
            string? downloadUrl,
            string? streamingUrl,
            string? posterUrl)
        {
            this.Type = type;
            this.Width = width;
            this.Height = height;
            this.DurationMs = durationMs;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.DownloadUrl = downloadUrl;
            this.StreamingUrl = streamingUrl;
            this.PosterUrl = posterUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedVideo" /> class.
        /// </summary>
        public UploadedVideo()
        {
        }
    }
}