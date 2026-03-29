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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatContentVideoTypeJsonConverter))]
        public global::G.ChatContentVideoType Type { get; set; }

        /// <summary>
        /// Video input object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatContentVideoInput VideoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentVideo" /> class.
        /// </summary>
        /// <param name="videoUrl">
        /// Video input object
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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