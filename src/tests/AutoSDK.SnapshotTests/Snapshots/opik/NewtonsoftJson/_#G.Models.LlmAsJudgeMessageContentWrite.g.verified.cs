//HintName: G.Models.LlmAsJudgeMessageContentWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmAsJudgeMessageContentWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public global::G.ImageUrlWrite? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_url")]
        public global::G.VideoUrlWrite? VideoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_url")]
        public global::G.AudioUrlWrite? AudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmAsJudgeMessageContentWrite" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="text"></param>
        /// <param name="imageUrl"></param>
        /// <param name="videoUrl"></param>
        /// <param name="audioUrl"></param>
        public LlmAsJudgeMessageContentWrite(
            string type,
            string? text,
            global::G.ImageUrlWrite? imageUrl,
            global::G.VideoUrlWrite? videoUrl,
            global::G.AudioUrlWrite? audioUrl)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Text = text;
            this.ImageUrl = imageUrl;
            this.VideoUrl = videoUrl;
            this.AudioUrl = audioUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmAsJudgeMessageContentWrite" /> class.
        /// </summary>
        public LlmAsJudgeMessageContentWrite()
        {
        }
    }
}