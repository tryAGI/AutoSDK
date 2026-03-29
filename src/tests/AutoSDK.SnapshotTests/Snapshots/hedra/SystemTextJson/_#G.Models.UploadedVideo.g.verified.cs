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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Width of the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// Height of the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// Duration of the video in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationMs { get; set; }

        /// <summary>
        /// URL of the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// URL to download the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// URL to stream the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming_url")]
        public string? StreamingUrl { get; set; }

        /// <summary>
        /// URL of the poster image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("poster_url")]
        public string? PosterUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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