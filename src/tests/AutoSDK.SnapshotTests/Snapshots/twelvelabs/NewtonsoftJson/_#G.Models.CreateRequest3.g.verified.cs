//HintName: G.Models.CreateRequest3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequest3
    {
        /// <summary>
        /// The unique identifier of the index to which the video is being uploaded.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string IndexId { get; set; } = default!;

        /// <summary>
        /// Specify this parameter to upload a video from your local file system.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_file")]
        public byte[]? VideoFile { get; set; }

        /// <summary>
        /// Specify this parameter to upload a video from your local file system.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_filename")]
        public string? VideoFilename { get; set; }

        /// <summary>
        /// Specify this parameter to upload a video from a publicly accessible URL.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// This parameter indicates if the platform stores the video for streaming. When set to `true`, the platform stores the video, and you can retrieve its URL by calling the [`GET`](/v1.3/api-reference/videos/retrieve) method of the `/indexes/{index-id}/videos/{video-id}` endpoint. You can then use this URL to access the stream over the &lt;a href="https://en.wikipedia.org/wiki/HTTP_Live_Streaming" target="_blank"&gt;HLS&lt;/a&gt; protocol.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_video_stream")]
        public bool? EnableVideoStream { get; set; }

        /// <summary>
        /// Metadata that helps you categorize your videos. You can specify a list of keys and values. Keys must be of type `string`, and values can be of the following types: `string`, `integer`, `float` or `boolean`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_metadata")]
        public string? UserMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest3" /> class.
        /// </summary>
        /// <param name="indexId">
        /// The unique identifier of the index to which the video is being uploaded.
        /// </param>
        /// <param name="videoFile">
        /// Specify this parameter to upload a video from your local file system.
        /// </param>
        /// <param name="videoFilename">
        /// Specify this parameter to upload a video from your local file system.
        /// </param>
        /// <param name="videoUrl">
        /// Specify this parameter to upload a video from a publicly accessible URL.
        /// </param>
        /// <param name="enableVideoStream">
        /// This parameter indicates if the platform stores the video for streaming. When set to `true`, the platform stores the video, and you can retrieve its URL by calling the [`GET`](/v1.3/api-reference/videos/retrieve) method of the `/indexes/{index-id}/videos/{video-id}` endpoint. You can then use this URL to access the stream over the &lt;a href="https://en.wikipedia.org/wiki/HTTP_Live_Streaming" target="_blank"&gt;HLS&lt;/a&gt; protocol.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="userMetadata">
        /// Metadata that helps you categorize your videos. You can specify a list of keys and values. Keys must be of type `string`, and values can be of the following types: `string`, `integer`, `float` or `boolean`.
        /// </param>
        public CreateRequest3(
            string indexId,
            byte[]? videoFile,
            string? videoFilename,
            string? videoUrl,
            bool? enableVideoStream,
            string? userMetadata)
        {
            this.IndexId = indexId ?? throw new global::System.ArgumentNullException(nameof(indexId));
            this.VideoFile = videoFile;
            this.VideoFilename = videoFilename;
            this.VideoUrl = videoUrl;
            this.EnableVideoStream = enableVideoStream;
            this.UserMetadata = userMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest3" /> class.
        /// </summary>
        public CreateRequest3()
        {
        }
    }
}