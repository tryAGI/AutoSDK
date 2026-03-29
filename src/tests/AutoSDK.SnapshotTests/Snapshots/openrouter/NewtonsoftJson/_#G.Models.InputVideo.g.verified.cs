//HintName: G.Models.InputVideo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Video input content item
    /// </summary>
    public sealed partial class InputVideo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InputVideoType Type { get; set; }

        /// <summary>
        /// A base64 data URL or remote URL that resolves to a video file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string VideoUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputVideo" /> class.
        /// </summary>
        /// <param name="videoUrl">
        /// A base64 data URL or remote URL that resolves to a video file
        /// </param>
        /// <param name="type"></param>
        public InputVideo(
            string videoUrl,
            global::G.InputVideoType type)
        {
            this.Type = type;
            this.VideoUrl = videoUrl ?? throw new global::System.ArgumentNullException(nameof(videoUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputVideo" /> class.
        /// </summary>
        public InputVideo()
        {
        }
    }
}