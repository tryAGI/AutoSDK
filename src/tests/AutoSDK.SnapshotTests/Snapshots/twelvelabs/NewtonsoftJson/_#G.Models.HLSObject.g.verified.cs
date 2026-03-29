//HintName: G.Models.HLSObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The platform returns this object only for the videos that you uploaded with the `enable_video_stream` parameter set to `true`.
    /// </summary>
    public sealed partial class HLSObject
    {
        /// <summary>
        /// A string representing the URL of the video. You can then use this URL to access the stream over the &lt;a href="https://en.wikipedia.org/wiki/HTTP_Live_Streaming" target="_blank"&gt;HLS&lt;/a&gt; protocol.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// An array containing the URL of the thumbnail.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_urls")]
        public global::System.Collections.Generic.IList<string>? ThumbnailUrls { get; set; }

        /// <summary>
        /// A string representing the encoding status of the video file from its original format to a streamable format.<br/>
        /// **Values**:<br/>
        /// - `PROCESSING`: Video is currently being encoded and is not yet ready for streaming<br/>
        /// - `COMPLETE`: Encoding has successfully finished and the video is ready for streaming<br/>
        /// - `CANCELED`: Encoding was manually canceled before completion<br/>
        /// - `ERROR`: An error occurred during the encoding process
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.HlsObjectStatus? Status { get; set; }

        /// <summary>
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the encoding status was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HLSObject" /> class.
        /// </summary>
        /// <param name="videoUrl">
        /// A string representing the URL of the video. You can then use this URL to access the stream over the &lt;a href="https://en.wikipedia.org/wiki/HTTP_Live_Streaming" target="_blank"&gt;HLS&lt;/a&gt; protocol.
        /// </param>
        /// <param name="thumbnailUrls">
        /// An array containing the URL of the thumbnail.
        /// </param>
        /// <param name="status">
        /// A string representing the encoding status of the video file from its original format to a streamable format.<br/>
        /// **Values**:<br/>
        /// - `PROCESSING`: Video is currently being encoded and is not yet ready for streaming<br/>
        /// - `COMPLETE`: Encoding has successfully finished and the video is ready for streaming<br/>
        /// - `CANCELED`: Encoding was manually canceled before completion<br/>
        /// - `ERROR`: An error occurred during the encoding process
        /// </param>
        /// <param name="updatedAt">
        /// A string indicating the date and time, in the RFC 3339 format ("YYYY-MM-DDTHH:mm:ssZ"), that the encoding status was last updated.
        /// </param>
        public HLSObject(
            string? videoUrl,
            global::System.Collections.Generic.IList<string>? thumbnailUrls,
            global::G.HlsObjectStatus? status,
            string? updatedAt)
        {
            this.VideoUrl = videoUrl;
            this.ThumbnailUrls = thumbnailUrls;
            this.Status = status;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HLSObject" /> class.
        /// </summary>
        public HLSObject()
        {
        }
    }
}