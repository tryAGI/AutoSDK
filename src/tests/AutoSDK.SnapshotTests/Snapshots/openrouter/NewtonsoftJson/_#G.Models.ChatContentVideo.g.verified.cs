//HintName: G.Models.ChatContentVideo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Video input content part
    /// </summary>
    public sealed partial class ChatContentVideo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ChatContentVideoType Type { get; set; }

        /// <summary>
        /// Video input object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_url", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatContentVideoInput VideoUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentVideo" /> class.
        /// </summary>
        /// <param name="videoUrl">
        /// Video input object
        /// </param>
        /// <param name="type"></param>
        public ChatContentVideo(
            global::G.ChatContentVideoInput videoUrl,
            global::G.ChatContentVideoType type)
        {
            this.Type = type;
            this.VideoUrl = videoUrl ?? throw new global::System.ArgumentNullException(nameof(videoUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentVideo" /> class.
        /// </summary>
        public ChatContentVideo()
        {
        }
    }
}